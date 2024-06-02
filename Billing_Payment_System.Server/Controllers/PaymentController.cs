using Billing_Payment_System.Server.Models;
using Billing_Payment_System.Server.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Billing_Payment_System.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize]
    public class PaymentController : ControllerBase
    {
        private readonly PaymentService _paymentService;

        public PaymentController(PaymentService paymentService)
        {
            _paymentService = paymentService;
        }

        [HttpPost]
        public IActionResult AddPayment([FromBody] Payment payment)
        {
            _paymentService.AddPayment(payment);
            return Ok();
        }

        [HttpGet("{shopId}")]
        public IActionResult GetPaymentsByShopId(int shopId)
        {
            var payments = _paymentService.GetPaymentsByShopId(shopId);
            return Ok(payments);
        }
    }

}
