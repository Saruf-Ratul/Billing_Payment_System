namespace Billing_Payment_System.Server.Models
{
    public class Shop
    {
        public int ShopId { get; set; }
        public string Owner { get; set; }
        public string Level { get; set; }
        public string Block { get; set; }
        public decimal Arrears { get; set; }
    }

}
