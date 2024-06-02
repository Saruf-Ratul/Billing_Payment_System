using Billing_Payment_System.Server.Data;
using Billing_Payment_System.Server.Helpers;
using Billing_Payment_System.Server.Models;
using System.IdentityModel.Tokens.Jwt;

namespace Billing_Payment_System.Server.Services
{
    public class AuthService
    {
        private readonly IUserRepository _userRepository;
        private readonly JwtHelper _jwtHelper;

        public AuthService(IUserRepository userRepository, JwtHelper jwtHelper)
        {
            _userRepository = userRepository;
            _jwtHelper = jwtHelper;
        }

        public string Authenticate(string username, string password)
        {
            var user = _userRepository.Authenticate(username, password);
            if (user == null) return null;
            return _jwtHelper.GenerateToken(user);
        }

        public void Register(User user)
        {
            _userRepository.CreateUser(user);
        }
    }


}
