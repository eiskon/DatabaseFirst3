import { Directive, ElementRef, Input, OnInit } from '@angular/core';
import { AuthService } from '../../_services/auth.service';
import { JwtHelperService } from '@auth0/angular-jwt';

@Directive({
  selector: '[hideIfUnauthorized]'
})
export class HideIfUnauthorizedDirective implements OnInit {
  @Input('hideIfUnauthorized') role: string;

  decodeToken: any;
  jwtHelper = new JwtHelperService();

  constructor(private el: ElementRef, private authService: AuthService) { }

  ngOnInit() {
    if (this.authService.loggedIn()) {
      const token = localStorage.getItem('token');
      this.decodeToken = this.jwtHelper.decodeToken(token);
      const roles = this.decodeToken.role as Array<string>;
      if (Array.isArray(roles)) {
        if (!roles.find(e => e === this.role)) {
          this.el.nativeElement.style.display = 'none';
        }
      } else {
        if (roles !== this.role) {
          this.el.nativeElement.style.display = 'none';
        }
      }     
    }
  }
}
