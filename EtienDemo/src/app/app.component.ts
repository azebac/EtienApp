import { Component } from '@angular/core';

import { Platform } from '@ionic/angular';
import { SplashScreen } from '@ionic-native/splash-screen/ngx';
import { StatusBar } from '@ionic-native/status-bar/ngx';

import { FCM } from '@ionic-native/fcm/ngx';
import { Router } from '@angular/router';
import { NavigationParamsService } from './shared/navigation-params.service';
import { TranslateService } from '@ngx-translate/core';

@Component({
  selector: 'app-root',
  templateUrl: 'app.component.html'
})
export class AppComponent {
  public appPages = [
    {
      title: 'Home',
      url: '/home',
      icon: 'home'
    },
    {
      title: 'List',
      url: '/list',
      icon: 'list'
    }
  ];

  constructor(
    private platform: Platform,
    private splashScreen: SplashScreen,
    private statusBar: StatusBar,
    private fcm: FCM,
    private navParams: NavigationParamsService,
    private _translate: TranslateService,
    private router: Router
  ) {
    this.initializeApp();

    let userLang = navigator.language.split('-')[0];
    userLang = /(en|de|it|fr|es|be)/gi.test(userLang) ? userLang : 'en';
    this._translate.use(userLang);
  }

  initializeApp() {
    this.platform.ready().then(() => {
      this.statusBar.styleDefault();
      this.splashScreen.hide();


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
    });
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
