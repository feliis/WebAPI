
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace WebApi.Models
{
    public class Sale
    {

        [Key]
        public int id_sale { get; set; }


        [ForeignKey("Cassette")]
        public int id_cassette { get; set; }

        [ForeignKey("Customer")]
        public int id_customer { get; set; }

        [ForeignKey("Employee")]
        public int id_employee { get; set; }

        public int qty { get; set; }

        public virtual int NewIndex()
        {
            using (ContextDB DB = new ContextDB())
            {
                int Max = -1;
                var SaleList = DB.sale.ToList();
                foreach (Sale p in SaleList)
                {
                    if (p.id_sale > Max) Max = p.id_sale;
                }
                return (Max + 1);
            }
        }
    }
}
