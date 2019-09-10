import { Component, OnInit, Injector } from '@angular/core';
import { UserService } from '../../../shared/user.service';
import { Router } from '@angular/router';
import { Country } from '../../../models/country';
import { Preference } from '../../../models/preference';

@Component({
  selector: 'app-fcm',
  templateUrl: './fcm.component.html',
  styleUrls: ['./fcm.component.scss']
})
export class FcmComponent implements OnInit {

  private userService: UserService = this.injector.get(UserService);
  public countries: Country[] = [];
  public preferences: Preference[] = [];
  public selectedPreferences: any;
  public selectedCountries: any;
  public messageToSend: string;
  public messageTitle: string;


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
    console.log(this.selectedPreferences);
    console.log(this.selectedCountries);
  }

}
