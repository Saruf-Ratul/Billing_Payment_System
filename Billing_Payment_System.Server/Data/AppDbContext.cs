using Billing_Payment_System.Server.Models;
using Microsoft.EntityFrameworkCore;
namespace Billing_Payment_System.Server.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Shop> Shops { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<User> Users { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
    }

}
