using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace mvc_app.Models
{
    public class Data201
    {
        public int Id { get; set; }
        public int ShopId { get; set; }
        public Shop Shop { get; set; }

        //[Required]
        [Display(Name = "Пропилен 1 и 2 очередей на НАК")]
        public decimal Propilen { get; set; }

        //[Required]
        [Display(Name = "Ангидрид сернистый жидкий на НАК")]
        public decimal Angidrid { get; set; }

        //[Required]
        [Display(Name = "Лапрол 3003 на НАК")]
        public decimal Laprol { get; set; }
    }
}
