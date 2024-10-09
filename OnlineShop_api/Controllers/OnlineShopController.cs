using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using OnlineShop_api.logs.Logging;
using OnlineShop_api.Models;

namespace OnlineShop_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OnlineShopController : ControllerBase
    {
        private readonly ILogging _logger; 
        public OnlineShopController(ILogging logger)
        {
            _logger = logger; 
        }

        [HttpGet]
        public ActionResult GetItems()
        {
            Item item = new Item()
            {
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
                Name = "Item",
                Id = 0,
                PhotoUrl = "asasd",
                Price = 20,
                Quantity = 20,
                Description = "This is best product"
            };
            _logger.Log("successfully logged", LogLevel.Warning);
            return Ok(item);
        }
    }
}
