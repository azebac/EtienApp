import { Component, OnInit, Injector, ViewChild } from '@angular/core';
import { UserService } from '../../../shared/user.service';
import { Router } from '@angular/router';
import { Country } from '../../../models/country';
import { Preference } from '../../../models/preference';
import {Notification} from '../../../models/notification'
import { NotificationService } from '../../../shared/notification.service';
import { ModalDirective } from 'ngx-bootstrap/modal';
@Component({
  selector: 'app-fcm',
  templateUrl: './fcm.component.html',
  styleUrls: ['./fcm.component.scss']
})
export class FcmComponent implements OnInit {

  private userService: UserService = this.injector.get(UserService);
  private fcmService : NotificationService = this.injector.get(NotificationService);
  @ViewChild('smallModal', {static: false}) public smallModal: ModalDirective;
  public countries: Country[] = [];
  public preferences: Preference[] = [];
  public selectedPreferences: any;
  public selectedCountries: any;
  public messageToSend: string ="";
  public messageTitle: string ="";
  public messageSubTitle: string ="";


  constructor(public injector: Injector) { }

  ngOnInit() {
    this.userService.getClientsPreferences().subscribe(res => {
      res.forEach(element => {
        var preferenceReceived = new Preference(element);
        this.preferences.push(preferenceReceived);
      });

    });

    this.userService.getClientsCountries().subscribe(res => {
      res.forEach(element => {
        var countries = new Country(element);
        this.countries.push(countries);
      });

    });
  }

  sendNotification(){
    let preferencesToNotify = [];
    let countriesToNotify = [];
    this.selectedPreferences.forEach(element => {
      let selectedPreference = new Preference();
      selectedPreference.$Name = element;
      preferencesToNotify.push(selectedPreference);
    });
    this.selectedCountries.forEach(element => {
      countriesToNotify.push(element.$ISO3);
    });
    let notificationToSend = new Notification();
    notificationToSend.$CountryList = countriesToNotify;
    notificationToSend.$PreferenceList = preferencesToNotify;
    notificationToSend.$NotificationTitle = this.messageTitle;
    notificationToSend.$NotificationSubtitle = this.messageSubTitle;
    notificationToSend.$NotificationBody = this.messageToSend;
    console.log(notificationToSend);
    this.fcmService.sendNotification(notificationToSend).subscribe(res=>{console.log(res);this.smallModal.show()});
  }

}
