import { Component, Injector } from '@angular/core';
import { User } from '../../models/user';
import { UserService } from '../../shared/user.service';
import { Router } from '@angular/router';


@Component({
  selector: 'app-dashboard',
  templateUrl: 'login.component.html'
})
export class LoginComponent {
  
  userLogginIn: User = new User();
  private userService: UserService = this.injector.get(UserService);
  private router: Router = this.injector.get(Router);

  constructor(public injector: Injector){

  }

  validateLogin(){
    this.userService.validateLogin(this.userLogginIn).subscribe(res=>{
      var acceptedUser: User = new User(res);
      localStorage.setItem('currentUser', JSON.stringify(acceptedUser));
      this.userService.currentUserSubject.next(acceptedUser);
      this.router.navigate(['/dashboard']);
    })
  }
 }
