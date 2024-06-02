import { Component } from '@angular/core';
import { AuthService } from '../Services/auth.service';
import { User } from '../Models/User';

@Component({
  selector: 'app-login',
  templateUrl: '../Components/login.component.html'
})
export class LoginComponent {
  user: User = { userId: 0, username: '', password: '', role: '' };

  constructor(private authService: AuthService) { }

  login() {
    this.authService.login(this.user).subscribe(response => {
      localStorage.setItem('token', response.token);
      // Redirect to the billing component or dashboard
    });
  }
}
