using Microsoft.AspNetCore.Mvc;
using System;
using WebApi.Models;

namespace WebApi.Controllers
{
    public class CassetteController : Controller
    {

        [Route("Add/[controller]")]
        [HttpPost]
        public IActionResult AddCassette([FromBody] Cassette NewCassette)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            using (ContextDB DB = new ContextDB())
            {
                NewCassette.id_cassette = NewCassette.NewIndex();
                DB.Add(NewCassette);
                DB.SaveChanges();
                return Ok();
            }
        }

        [Route("Show/[controller]")]
        [HttpGet]
        public IActionResult Show()
        {
            ContextDB DB = new ContextDB();
            Cassette newCassette = new Cassette();
            var cassette = DB.cassette.ToList();
            return Ok(cassette);
        }


        [Route("DeleteCassette/[controller]")]
        [HttpDelete]
        public IActionResult DeleteCassetteByID(int id_cassette)
        {
            using (ContextDB DB = new ContextDB())
            {
                Cassette data = DB.cassette.Find(id_cassette);
                if (data != null)
                {
                    DB.cassette.Remove(data);
                    DB.SaveChanges();
                    return Ok();
                }
                return BadRequest(ModelState);

            }
        }
    }
}
