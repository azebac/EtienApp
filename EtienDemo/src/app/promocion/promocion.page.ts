import { Component, OnInit } from '@angular/core';

import { NavigationParamsService } from '../shared/navigation-params.service';

@Component({
  selector: 'app-promocion',
  templateUrl: './promocion.page.html',
  styleUrls: ['./promocion.page.scss'],
})
export class PromocionPage implements OnInit {

  country:any;
  percent:any;
  message: string;

  constructor(private navParams: NavigationParamsService) { }

  ngOnInit() {
    let params = this.navParams.getExtras();
    this.country = params.country;
    this.percent = params.percent;
    this.message = params.message;
  }

}
