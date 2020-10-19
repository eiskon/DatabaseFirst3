import { Injectable } from '@angular/core';
import { ActivatedRouteSnapshot, CanActivate } from '@angular/router';
import { AuthService } from '../_services/auth.service';
import { AlertifyService } from '../_services/alertify.service';
import { Router } from '@angular/router';

@Injectable({
  providedIn: 'root'
})
export class AuthGuard implements CanActivate {
  constructor(
    private authService: AuthService,
    private router: Router,
    private alertify: AlertifyService
  ) { }
  canActivate(next: ActivatedRouteSnapshot): boolean {
    const roles = next.data['roles'] as Array<string>;
    if (roles) {
      const match = this.authService.roleMatch(roles);
      if (match) {
        return true;
      } else {
        this.router.navigate(['home']);
        this.alertify.error('You are not autheorize to access this area');
      }
    }
    if (this.authService.loggedIn()) {
      return true;
    }

    this.alertify.error('You shall not pass!!!');
    this.router.navigate(['/home']);
    return false;
  }

}
