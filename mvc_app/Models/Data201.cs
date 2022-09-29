using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;
using System.Xml.Linq;

namespace mvc_app.Models
{
    public class Data201
    {
        public int Id { get; set; }
        public int? ShopId { get; set; }
        public Shop Shop { get; set; }

        //[Required]
        [Display(Name = "Пропилен 1 и 2 очередей на НАК")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Propilen { get; set; }

        //[Required]
        [Display(Name = "Ангидрид сернистый жидкий на НАК")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Angidrid { get; set; }

        //[Required]
        [Display(Name = "Лапрол 3003 на НАК")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Laprol { get; set; }
    }
}
