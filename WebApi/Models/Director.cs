
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace WebApi.Models
{
    public class Director
    {

        [Key] 
        public int id_cassette { get; set; }

        public string surname { get; set; } 
        public string firstname { get; set; }
        public string patronymic { get; set; }


    }
}
