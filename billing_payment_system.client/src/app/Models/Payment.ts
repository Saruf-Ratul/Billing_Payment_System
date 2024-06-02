export interface Payment {
  paymentId: number;
  shopId: number;
  amount: number;
  paymentDate: Date;
  status: string;
}
