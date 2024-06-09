import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Payment } from '../Models/Payment';

@Injectable({
  providedIn: 'root'
})
export class PaymentService {
  private apiUrl = 'https://localhost:44356/payment';

  constructor(private http: HttpClient) { }

  addPayment(payment: Payment): Observable<any> {
    return this.http.post(this.apiUrl, payment);
  }

  getPaymentsByShopId(shopId: number): Observable<Payment[]> {
    return this.http.get<Payment[]>(`${this.apiUrl}/${shopId}`);
  }
}
