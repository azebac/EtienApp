import { Component, OnInit, Injector } from '@angular/core';
import { AuthenticationService } from '../services/Authentication.service';
import { CommonDirectiveDirective } from '../common-directive.directive';
import { User } from '../models/user';
import { Platform } from '@ionic/angular';

@Component({
  selector: 'app-login',
  templateUrl: './login.page.html',
  styleUrls: ['./login.page.scss'],
})
export class LoginPage extends CommonDirectiveDirective implements OnInit  {

  private authService: AuthenticationService = this.injector.get(AuthenticationService);
  private platform: Platform = this.injector.get(Platform);
  public userLogginIn: User = new User();
  constructor(
    public injector: Injector
  ) {
    super(injector);
    this.platform.ready().then(() => {
      this.getMandatoryUUID().then(res=>{
        this.userLogginIn.$UserDeviceId = res;
      });
    });
  }

  ngOnInit() {

  }

  loginUser(){
    this.authService.login()
  }

  

}
