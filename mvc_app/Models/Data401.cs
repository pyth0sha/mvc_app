using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace mvc_app.Models
{
    public class Data401
    {
        public int Id { get; set; }
        public int? ShopId { get; set; }
        public Shop Shop { get; set; }

        //[Required]
        [Display(Name = "НАК")]
        public decimal NAK { get; set; }

        //[Required]
        [Display(Name = "МА")]
        public decimal MA { get; set; }

        //[Required]
        [Display(Name = "Натрий едкий технический")]
        public decimal Natrii { get; set; }
    }
}
