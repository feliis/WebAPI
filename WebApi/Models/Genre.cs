
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace WebApi.Models
{
    public class Genre
    {

        [Key] 
        public int id_genre { get; set; }

        public string name { get; set; } 
    }
}
