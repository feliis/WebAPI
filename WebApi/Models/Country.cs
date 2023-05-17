
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace WebApi.Models
{
    public class Country
    {

        [Key] 
        public int id_country { get; set; }

        public string name { get; set; } 
    }
}
