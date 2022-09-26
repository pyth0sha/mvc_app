using System;
using System.ComponentModel.DataAnnotations;

namespace mvc_app.Models
{
    public class Data101
    {
        public int Id { get; set; }
        public int? ShopId { get; set; }
        public Shop Shop { get; set; }

        //[Required]
        [Display(Name = "Бензин легкий")]
        public decimal BenzinLight { get; set; }

        //[Required]
        [Display(Name = "Бутан")]
        public decimal Butan { get; set; }

        //[Required]
        [Display(Name = "Керосин")]
        public decimal Kerosin { get; set; }

    }
}
