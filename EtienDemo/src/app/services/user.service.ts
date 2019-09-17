import { Injectable, Injector } from '@angular/core';
import { BaseService } from './base.service';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class UserService extends BaseService {

  constructor(public injector: Injector) {
    super(injector);
  }

  public getClientsPreferences(): Promise<any> {
    return this.httpService.get(environment.rest_path.base + environment.rest_path.users.getPreferences, {}, this.httpOptions).catch(this.errorHandl);

  }

  public getClientsCountries(): Promise<any> {
    return this.httpService.get(environment.rest_path.base + environment.rest_path.users.getCountries, {}, this.httpOptions).catch(this.errorHandl);
  }

  public registerUser(user):Promise<any>{
    return this.httpService.post(environment.rest_path.base+ environment.rest_path.users.register,JSON.stringify(user),this.httpOptions).catch(this.errorHandl);
  }
}
