using Microsoft.AspNetCore.Mvc;
using WebApi.Models;

namespace WebApi.Controllers
{
    [ApiController]


        [Route("/api/[controller]")]
    public class SaleController : Controller
    {
        [HttpGet]
    public IActionResult Show()
        {
            Delivery newDelivery = new Delivery();
            ContextDB DB = new ContextDB();
            var delivery = DB.delivery.ToList();
            return Ok(delivery);
        }


    }
}
