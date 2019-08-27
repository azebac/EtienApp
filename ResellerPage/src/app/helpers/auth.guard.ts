import { Injectable, Injector } from '@angular/core';
import { Router, CanActivate, ActivatedRouteSnapshot, RouterStateSnapshot } from '@angular/router';
import { UserService } from '../shared/user.service';


@Injectable({ providedIn: 'root' })
export class AuthGuard implements CanActivate {


    public userService: UserService = this.injector.get(UserService);
    private router: Router = this.injector.get(Router);
    constructor(
        private injector: Injector
    ) { }

    canActivate(route: ActivatedRouteSnapshot, state: RouterStateSnapshot) {
        
        if (this.userService.currentUserValue) {
            // logged in so return true
            return true;
        }

        // not logged in so redirect to login page with the return url
        this.router.navigate(['/login'], { queryParams: { returnUrl: state.url } });
        return false;
    }


}