import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { BillingComponent } from './Components/billing.component';
import { PaymentComponent } from './Components/payment.component';
import { LoginComponent } from './Components/login.component';
import { RegisterComponent } from './Components/register.component';

const routes: Routes = [
  { path: 'billing', component: BillingComponent },
  { path: 'payment', component: PaymentComponent },
  { path: 'login', component: LoginComponent },
  { path: 'register', component: RegisterComponent },
  { path: '', redirectTo: '/login', pathMatch: 'full' }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
