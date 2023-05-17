
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace WebApi.Models
{
    public class Delivery
    {

        [Key]
        public int id_delivery { get; set; }


        [ForeignKey("Cassette")]
        public int cassette { get; set; }


        public int qty { get; set; }

        }
}
