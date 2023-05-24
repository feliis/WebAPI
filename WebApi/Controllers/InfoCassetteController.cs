using Microsoft.AspNetCore.Mvc;
using WebApi.Models;

namespace WebApi.Controllers
{
    [ApiController]

    public class InfoCassetteController : Controller
    {
        [Route("AddCountry/[controller]")]
        [HttpPost]
        public IActionResult AddCountry([FromBody] Country NewCountry)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            using (ContextDB DB = new ContextDB())
            {
                NewCountry.id_country = NewCountry.NewIndex();
                DB.Add(NewCountry);
                DB.SaveChanges();
                return Ok();
            }
        }

        [Route("AddGenre/[controller]")]
        [HttpPost]
        public IActionResult AddGenre([FromBody] Genre NewGenre)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            using (ContextDB DB = new ContextDB())
            {
                NewGenre.id_genre = NewGenre.NewIndex();
                DB.Add(NewGenre);
                DB.SaveChanges();
                return Ok();
            }
        }

        [Route("AddDirector/[controller]")]
        [HttpPost]
        public IActionResult AddDirector([FromBody] Director NewDirector)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            using (ContextDB DB = new ContextDB())
            {
                NewDirector.id_director = NewDirector.NewIndex();
                DB.Add(NewDirector);
                DB.SaveChanges();
                return Ok();
            }
        }

        [Route("ShowCountry/[controller]")]
        [HttpGet]
        public IActionResult ShowCountry()
        {
            ContextDB DB = new ContextDB();
            Country newCountry = new Country();
            var country = DB.country.ToList();
            return Ok(country);
        }

        [Route("ShowGenre/[controller]")]
        [HttpGet]
        public IActionResult ShowGenre()
        {
            ContextDB DB = new ContextDB();
            Genre newGenre = new Genre();
            var genre = DB.genre.ToList();
            return Ok(genre);
        }

        [Route("ShowDirector/[controller]")]
        [HttpGet]
        public IActionResult ShowDirector()
        {
            ContextDB DB = new ContextDB();
            Director newDirector = new Director();
            var director = DB.director.ToList();
            return Ok(director);
        }

        [Route("DeleteCountry/[controller]")]
        [HttpDelete]
        public IActionResult DeleteCountryByID(int id_country)
        {
            using (ContextDB DB = new ContextDB())
            {
                Country data = DB.country.Find(id_country);
                if (data != null)
                {
                    DB.country.Remove(data);
                    DB.SaveChanges();
                    return Ok();
                }
                return BadRequest(ModelState);

            }
        }

        [Route("DeleteGenre/[controller]")]
        [HttpDelete]
        public IActionResult DeleteGenreByID(int id_genre)
        {
            using (ContextDB DB = new ContextDB())
            {
                Genre data = DB.genre.Find(id_genre);
                if (data != null)
                {
                    DB.genre.Remove(data);
                    DB.SaveChanges();
                    return Ok();
                }
                return BadRequest(ModelState);

            }
        }

        [Route("DeleteDirector/[controller]")]
        [HttpDelete]
        public IActionResult DeleteDirectorByID(int id_director)
        {
            using (ContextDB DB = new ContextDB())
            {
                Director data = DB.director.Find(id_director);
                if (data != null)
                {
                    DB.director.Remove(data);
                    DB.SaveChanges();
                    return Ok();
                }
                return BadRequest(ModelState);

            }
        }
    }
}
