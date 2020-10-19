import { Component, OnInit, ViewChild } from '@angular/core';
import { AuthService } from 'src/app/_services/auth.service';
import { AlertifyService } from 'src/app/_services/alertify.service';
import { Router } from '@angular/router';
import { NgForm } from '@angular/forms';

@Component({
  selector: 'app-login-dialog',
  templateUrl: './login-dialog.component.html',
  styleUrls: ['./login-dialog.component.css']
})
export class LoginDialogComponent implements OnInit {
  @ViewChild('loginForm') loginForm: NgForm;
  model: any = {};

  constructor(public authService: AuthService, 
              private alertify: AlertifyService, 
              private router: Router) {}

  ngOnInit() {}

  login() {
    this.authService.login(this.model).subscribe(() => {
      this.alertify.success('Logged in successfully');
      this.loginForm.reset();
    }, error => {
      this.alertify.error(error);
    });
  }
  loggedIn() {
    return this.authService.loggedIn();
  }

  logout() {
    
    localStorage.removeItem('token');
    localStorage.removeItem('user');  // ?
    this.alertify.message('logged out');
    this.router.navigate(['/home']);
  }

}
