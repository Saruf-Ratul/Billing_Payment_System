using Billing_Payment_System.Server.Models;

namespace Billing_Payment_System.Server.Data
{
    public interface IUserRepository
    {
        User Authenticate(string username, string password);
        User GetUserById(int userId);
        void CreateUser(User user);
    }
}
