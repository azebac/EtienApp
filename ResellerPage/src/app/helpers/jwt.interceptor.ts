import { Injectable, Injector } from '@angular/core';
import { HttpRequest, HttpHandler, HttpEvent, HttpInterceptor } from '@angular/common/http';
import { UserService } from '../shared/user.service';


import { Observable } from 'rxjs';

@Injectable()
export class JwtInterceptor implements HttpInterceptor {

    private userService: UserService = this.injector.get(UserService);
    constructor(private injector: Injector) { }

    intercept(request: HttpRequest<any>, next: HttpHandler): Observable<HttpEvent<any>> {
        // add authorization header with jwt token if available
        let currentUser = this.userService.currentUserValue;
        if (currentUser && currentUser.$AppToken) {
            request = request.clone({
                setHeaders: {
                    Authorization: `Bearer ${currentUser.$AppToken}`
                }
            });
        }

        return next.handle(request);
    }
}