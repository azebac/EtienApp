import { Component, OnInit, Injector, OnDestroy, ViewChild } from '@angular/core';
import { UserService } from '../../../shared/user.service';
import { User } from '../../../models/user';
import { Subject } from 'rxjs';
import { ModalDirective } from 'ngx-bootstrap/modal';

@Component({
  selector: 'app-usuarios',
  templateUrl: './usuarios.component.html',
  styleUrls: ['./usuarios.component.scss']
})
export class UsuariosComponent implements OnInit, OnDestroy {

  private userService: UserService = this.injector.get(UserService);

  public userList:User[] = [];
  dtTrigger: Subject<any> = new Subject();
  public detailingUser: User = new User();
  public userToBan: User = new User();
  public userToActivate: User = new User();

  @ViewChild('smallModalDetail', {static: false}) public smallModalDetail: ModalDirective;
  @ViewChild('smallModalBan', {static: false}) public smallModalBan: ModalDirective;  
  @ViewChild('smallModalActivate', {static: false}) public smallModalActivate: ModalDirective;  
  
  constructor(public injector: Injector) { }

  ngOnInit() {
    this.userService.getAllUsers().subscribe(res=>{
      res.forEach(element => {
        let user = new User(element);
        this.userList.push(user);
      });
      this.dtTrigger.next();
      console.log(this.userList);
    });
  }

  setDetailingUser(userToDetail){
    this.detailingUser = userToDetail;
    console.log(this.detailingUser);
    this.smallModalDetail.show();
  }

  setUserToBan(selectedUser){
    this.userToBan = selectedUser;
    this.smallModalBan.show();
  }
  
  setUserToActivate(selectedUser){
    this.userToActivate = selectedUser;
    this.smallModalActivate.show();
  }

  banUser(){
    this.userToBan.$Status = 2;
    this.userService.updateUser(this.userToBan).subscribe(res=>{
      console.log(res);
      this.smallModalBan.hide();
    });
  }

  activateUser(){
    this.userToActivate.$Status = 1;
    this.userService.updateUser(this.userToActivate).subscribe(res=>{
      console.log(res);
      this.smallModalActivate.hide();
    });
  }

  

  ngOnDestroy(): void {
    // Do not forget to unsubscribe the event
    this.dtTrigger.unsubscribe();
  }

}
