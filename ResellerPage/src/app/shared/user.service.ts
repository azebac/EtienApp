import { Injectable, Injector } from '@angular/core';
import { BaseService } from './base.service';
import { User } from '../models/user';
import { environment } from '../../environments/environment';
import { Observable, throwError, BehaviorSubject } from 'rxjs';
import { retry, catchError } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class UserService extends BaseService {
  
  public currentUserSubject: BehaviorSubject<User>;
  public currentUser: Observable<User>;

  constructor(injector: Injector) {
    super(injector);
    this.currentUserSubject = new BehaviorSubject<User>(JSON.parse(localStorage.getItem('currentUser')));
    this.currentUser = this.currentUserSubject.asObservable();
   }

   public getAllUsers():Observable<any>{
    return this.httpService.get(environment.rest_path.base+environment.rest_path.users.getAllUsers,this.httpOptions).pipe(
      retry(1),
      catchError(this.errorHandl)
    );   
   }

   public validateLogin(user:User):Observable<any>{
    return this.httpService.post(environment.rest_path.base+environment.rest_path.login.authenticate,JSON.stringify(user),this.httpOptions).pipe(
      retry(1),
      catchError(this.errorHandl)
    );
   }

   public getClientsPreferences():Observable<any>{
     return this.httpService.get(environment.rest_path.base+environment.rest_path.users.getPreferences,this.httpOptions).pipe(
      retry(1),
      catchError(this.errorHandl)
    );   
   }

   public getClientsCountries():Observable<any>{
    return this.httpService.get(environment.rest_path.base+environment.rest_path.users.getCountries,this.httpOptions).pipe(
     retry(1),
     catchError(this.errorHandl)
   );   
  }

  public updateUser(user):Observable<any>{
    return this.httpService.post(environment.rest_path.base+environment.rest_path.users.updateUser,JSON.stringify(user),this.httpOptions).pipe(
      retry(1),
      catchError(this.errorHandl)
    );
  }

   public get currentUserValue(): User {
    return this.currentUserSubject.value;
   }

   logout() {
    // remove user from local storage to log user out
    localStorage.removeItem('currentUser');
    this.currentUserSubject.next(null);
   }

}
