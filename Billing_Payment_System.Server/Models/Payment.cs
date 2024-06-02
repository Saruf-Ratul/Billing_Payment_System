namespace Billing_Payment_System.Server.Models
{
    public class Payment
    {
        public int PaymentId { get; set; }
        public int ShopId { get; set; }
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; }
        public string Status { get; set; }
    }

}
