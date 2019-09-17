import { Component } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { FCM } from '@ionic-native/fcm/ngx';
import { NavigationParamsService } from '../shared/navigation-params.service';
import { TranslateService } from '@ngx-translate/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-home',
  templateUrl: 'home.page.html',
  styleUrls: ['home.page.scss'],
})
export class HomePage {
  postsToShow = [];
  currentPage = 1;

  constructor(private http: HttpClient,
    private fcm: FCM,
    private navParams: NavigationParamsService,
    private _translate: TranslateService,
    private router: Router) {
    this.doInfinite();
    

    this.getFCMToken();

    this.fcm.subscribeToTopic('promociones');

    this.fcm.onTokenRefresh().subscribe(token => {
      console.log(token);
    });

    this.fcm.onNotification().subscribe(data => {
      console.log(data);
      var params = {
        message: data.message,
        country: data.country,
        percent: data.percent 
      }
      this.navParams.setExtras(params);

      if (data.wasTapped) {
        console.log('Received in background');
        this.router.navigate([data.landing_page]);
      } else {
        console.log('Received in foreground');
        this.router.navigate([data.landing_page]);
      }
    });
  }

  doInfinite(): Promise<any> {
    return this.http.get('https://www.etienreseller.com/wp-json/wp/v2/posts?page=' + this.currentPage).toPromise().then((response) => {
      var formattedResponse = <any>response
      if (!formattedResponse.code) {
        this.currentPage = this.currentPage + 1;
        var posts = Object.values(response);
        for (var i = 0; i < posts.length; i++) {
          this.postsToShow.push(posts[i]);
        }
      }
    });
  }

  formatExcerpt(text:string){
    var result = text.replace(/<(?:.|\n)*?>/gm, '');
    result = result.replace(/&nbsp;/g,'');
    result = result.replace(/\[&hellip;\]/g,'');
    result = result + "...";
    return result;
  }

  
  getFCMToken() {
    this.fcm.getToken().then(token => {
      if (token == null) {
        setTimeout(this.getFCMToken, 1000);
      }
      else {

      }
    }, e => {
      console.log(e);
    });
  }
}
