import { Component } from '@angular/core';
import { AuthService } from '../Services/auth.service';
import { User } from '../Models/User';

@Component({
  selector: 'app-register',
  templateUrl: '../Components/register.component.html'
})
export class RegisterComponent {
  user: User = { userId: 0, username: '', password: '', role: '' };

  constructor(private authService: AuthService) { }

  register() {
    this.authService.register(this.user).subscribe(() => {

    });
  }
}
