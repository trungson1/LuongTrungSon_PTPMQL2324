using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoMVC.Models
{
    [Table("Persons")]
    public class Person
    {
        [Key]
        public string PersonID {get; set; }
        public string Fullname {get; set; }
        public string Address {get; set; }
    }
}