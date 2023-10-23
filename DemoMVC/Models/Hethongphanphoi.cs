using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoMVC.Models
{
    [Table("HTPP")]
    public class Hethongphanphoi
    {
        [Key]
        public string Madaily {get; set; }
        public string Tendaily {get; set; }
        public string Diachi {get; set; }
        public string Nguoidaidien {get; set; }
        public string Dienthoai {get; set; }
        public string MaHTPP {get; set; }
    }
}