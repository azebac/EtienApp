import { Component } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-home',
  templateUrl: 'home.page.html',
  styleUrls: ['home.page.scss'],
})
export class HomePage {
  postsToShow = [];
  currentPage = 1;

  constructor(private http: HttpClient) {
    this.doInfinite();
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
}
