
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace WebApi.Models
{
    public class Cassette
    {

        [Key] 
        public int id_employee { get; set; }

        public string name { get; set; }

        [ForeignKey("Genre")]
        public int id_genre { get; set; }

        [ForeignKey("Country")]
        public int country { get; set; }

        [ForeignKey("Director")]
        public int director { get; set; }

        public int price { get; set; }

        public int year { get; set; }

        public int qty { get; set; }

    }
}
