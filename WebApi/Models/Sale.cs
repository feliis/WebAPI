
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace WebApi.Models
{
    public class Sale
    {

        [Key]
        public int id_sale { get; set; }


        [ForeignKey("Cassette")]
        public string cassette { get; set; }

        [ForeignKey("Customer")]
        public string customer { get; set; }

        [ForeignKey("Employee")]
        public string employee { get; set; }


        public int qty { get; set; }
    }
}
