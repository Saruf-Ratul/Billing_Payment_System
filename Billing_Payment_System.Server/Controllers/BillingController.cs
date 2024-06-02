using Billing_Payment_System.Server.Models;
using Billing_Payment_System.Server.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Billing_Payment_System.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize]
    public class BillingController : ControllerBase
    {
        private readonly BillingService _billingService;

        public BillingController(BillingService billingService)
        {
            _billingService = billingService;
        }

        [HttpGet]
        public IActionResult GetShops()
        {
            var shops = _billingService.GetShops();
            return Ok(shops);
        }

        [HttpPost]
        public IActionResult AddShop([FromBody] Shop shop)
        {
            _billingService.AddShop(shop);
            return Ok();
        }

        [HttpPut("{shopId}")]
        public IActionResult UpdateArrears(int shopId, [FromBody] decimal arrears)
        {
            _billingService.UpdateArrears(shopId, arrears);
            return Ok();
        }
    }

}
