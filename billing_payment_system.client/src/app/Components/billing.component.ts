import { Component, OnInit } from '@angular/core';
import { BillingService } from '../Services/billing.service';
import { Shop } from '../Models/Shop';

@Component({
  selector: 'app-billing',
  templateUrl: '../Components/billing.component.html'
})
export class BillingComponent implements OnInit {
  shops: Shop[] = [];
  newShop: Shop = {
    shopId: 0,
    owner: '',
    level: '',
    block: '',
    arrears: 0
  };

  constructor(private billingService: BillingService) { }

  ngOnInit() {
    this.billingService.getShops().subscribe(shops => {
      this.shops = shops;
    });
  }

  addShop(shop: Shop) {
    this.billingService.addShop(shop).subscribe(() => {
      this.shops.push(shop);
      this.resetNewShop();
    });
  }

  updateArrears(shopId: number, arrears: number) {
    this.billingService.updateArrears(shopId, arrears).subscribe();
  }

  private resetNewShop() {
    this.newShop = {
      shopId: 0,
      owner: '',
      level: '',
      block: '',
      arrears: 0
    };
  }

}
