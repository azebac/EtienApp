import { Injectable, Injector } from '@angular/core';
import { BaseService } from './base.service';
import { Observable } from 'rxjs';
import { environment } from '../../environments/environment';
import { retry, catchError } from 'rxjs/operators';
import {Notification} from '../models/notification'

@Injectable({
  providedIn: 'root'
})
export class NotificationService extends BaseService {

  constructor(injector: Injector) {
    super(injector);
  }

  public sendNotification(notificationToSend: Notification):Observable<any>{
    return this.httpService.post(environment.rest_path.base+environment.rest_path.notification.sendNotification,JSON.stringify(notificationToSend),this.httpOptions).pipe(
      retry(1),
      catchError(this.errorHandl)
    );
  }
}
