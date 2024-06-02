using Billing_Payment_System.Server.Data;
using Billing_Payment_System.Server.Models;

namespace Billing_Payment_System.Server.Services
{
    public class PaymentService
    {
        private readonly AppDbContext _context;

        public PaymentService(AppDbContext context)
        {
            _context = context;
        }

        public void AddPayment(Payment payment)
        {
            _context.Payments.Add(payment);
            _context.SaveChanges();
        }

        public IEnumerable<Payment> GetPaymentsByShopId(int shopId)
        {
            return _context.Payments.Where(p => p.ShopId == shopId).ToList();
        }
    }

}
