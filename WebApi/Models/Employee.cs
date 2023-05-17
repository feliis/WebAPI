
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace WebApi.Models
{
    public class Employee
    {

        [Key] 
        public int id_employee { get; set; }

        public string surname { get; set; } 
        public string firstname { get; set; }
        public string patronymic { get; set; }
        public string phone { get; set; }

    }
}
