using Billing_Payment_System.Server.Data;
using Billing_Payment_System.Server.Models;

namespace Billing_Payment_System.Server.Services
{
    public class BillingService
    {
        private readonly AppDbContext _context;

        public BillingService(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Shop> GetShops()
        {
            return _context.Shops.ToList();
        }

        public void AddShop(Shop shop)
        {
            _context.Shops.Add(shop);
            _context.SaveChanges();
        }

        public void UpdateArrears(int shopId, decimal arrears)
        {
            var shop = _context.Shops.Find(shopId);
            if (shop != null)
            {
                shop.Arrears = arrears;
                _context.SaveChanges();
            }
        }
    }

}
