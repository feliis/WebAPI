﻿using Microsoft.AspNetCore.Mvc;
using WebApi.Models;

namespace WebApi.Controllers
{
    [ApiController]

    public class SaleController : Controller
    {
        [Route("Add/[controller]")]
        [HttpPost]
        public IActionResult AddSale([FromBody] Sale NewSale)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            using (ContextDB DB = new ContextDB())
            {
                NewSale.id_sale = NewSale.NewIndex();
                DB.Add(NewSale);
                DB.SaveChanges();
                return Ok();
            }
        }

        [Route("Show/[controller]")]
        [HttpGet]
        public IActionResult Show()
        {
            ContextDB DB = new ContextDB();
            Sale newSale = new Sale();
            var sale = DB.sale.ToList();
            return Ok(sale);
        }

        [Route("Delete/[controller]")]
        [HttpDelete]
        public IActionResult DeleteSaleByID(int id_sale)
        {
            using (ContextDB DB = new ContextDB())
            {
                Sale data = DB.sale.Find(id_sale);
                if (data != null)
                {
                    DB.sale.Remove(data);
                    DB.SaveChanges();
                    return Ok();
                }
                return BadRequest(ModelState);

            }
        }
    }
}
