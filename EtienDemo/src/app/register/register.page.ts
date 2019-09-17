import { Component, OnInit, Injector } from '@angular/core';
import { User } from '../models/user';
import { UserService } from '../services/user.service';
import { Preference } from '../models/preference';
import { Country } from '../models/country';

@Component({
  selector: 'app-register',
  templateUrl: './register.page.html',
  styleUrls: ['./register.page.scss'],
})
export class RegisterPage implements OnInit {

  public userToRegister: User = new User();
  private userService: UserService = this.injector.get(UserService);
  public availablePreferences: Preference[] = [];
  public availableCountries: Country[] = [];
  constructor(public injector: Injector) { 

  }

  ngOnInit() {

    this.userService.getClientsPreferences().then(res=>{
      res.forEach(element => {
        this.availablePreferences.push(new Preference(element));
      });
    });

    this.userService.getClientsCountries().then(res=>{
      res.forEach(element => {
        this.availableCountries.push(new Country(element));
      });
    });

  }

}
