import { Directive, Injector } from '@angular/core';
import { UniqueDeviceID } from '@ionic-native/unique-device-id/ngx';
import { Uid } from '@ionic-native/uid/ngx';
import { AndroidPermissions } from '@ionic-native/android-permissions/ngx';

@Directive({
  selector: '[appCommonDirective]'
})
export class CommonDirectiveDirective {

  private uniqueDeviceID: UniqueDeviceID = this.injector.get(UniqueDeviceID);
  private uid: Uid = this.injector.get(Uid);
  private androidPermissions: AndroidPermissions = this.injector.get(AndroidPermissions);


  constructor(public injector: Injector) 
  { }

  getMandatoryUUID():Promise<string>{

    return new Promise<string>(resolve =>{
      this.androidPermissions.checkPermission(
        this.androidPermissions.PERMISSION.READ_PHONE_STATE
      ).then(res => {
        if(res.hasPermission){
          resolve( this.uid.UUID);
        }else{
          this.androidPermissions.requestPermission(this.androidPermissions.PERMISSION.READ_PHONE_STATE).then(res => {
            resolve( this.uid.UUID);
          }).catch(error => {
            console.log(error);
            resolve('');
            //navigator['app'].exitApp();
            
          });
        }
      }).catch(error => {
        console.log(error);
        resolve('');
        //navigator['app'].exitApp();
      });
    });

  }

}
