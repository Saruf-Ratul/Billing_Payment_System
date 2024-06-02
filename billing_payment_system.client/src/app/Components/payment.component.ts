import { Component, OnInit } from '@angular/core';
import { PaymentService } from '../Services/payment.service';
import { Payment } from '../Models/Payment';

@Component({
  selector: 'app-payment',
  templateUrl: '../Components/payment.component.html'
})
export class PaymentComponent implements OnInit {
  payments: Payment[] = [];
  newPayment: Payment = {
    paymentId: 0,
    shopId: 0,
    amount: 0,
    paymentDate: new Date(),
    status: ''
  };

  constructor(private paymentService: PaymentService) { }

  ngOnInit() {
    // Assume we have a method to get the current shopId
    const shopId = this.getShopId();
    this.paymentService.getPaymentsByShopId(shopId).subscribe(payments => {
      this.payments = payments;
    });
  }

  addPayment(payment: Payment) {
    this.paymentService.addPayment(payment).subscribe(() => {
      this.payments.push(payment);
    });
  }

  private getShopId(): number {
    // Replace with actual logic to get the current shopId
    return 1;
  }

  private resetNewPayment() {
    this.newPayment = {
      paymentId: 0,
      shopId: 0,
      amount: 0,
      paymentDate: new Date(),
      status: ''
    };
  }

}
