import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Shop } from '../Models/Shop';

@Injectable({
  providedIn: 'root'
})
export class BillingService {
  private apiUrl = 'https://your-api-url/billing';

  constructor(private http: HttpClient) { }

  getShops(): Observable<Shop[]> {
    return this.http.get<Shop[]>(this.apiUrl);
  }

  addShop(shop: Shop): Observable<any> {
    return this.http.post(this.apiUrl, shop);
  }

  updateArrears(shopId: number, arrears: number): Observable<any> {
    return this.http.put(`${this.apiUrl}/${shopId}`, { arrears });
  }
}
