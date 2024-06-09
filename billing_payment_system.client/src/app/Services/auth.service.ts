import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { User } from '../Models/User';

@Injectable({
  providedIn: 'root'
})
export class AuthService {
  private apiUrl = 'https://localhost:44356/auth';

  constructor(private http: HttpClient) { }

  login(user: User): Observable<any> {
    return this.http.post(`${this.apiUrl}/login`, user);
  }

  register(user: User): Observable<any> {
    return this.http.post(`${this.apiUrl}/register`, user);
  }
}
