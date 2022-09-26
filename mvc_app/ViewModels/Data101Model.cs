using System.ComponentModel.DataAnnotations;

namespace mvc_app.ViewModels
{
    public class Data101Model
    {
        [Display(Name = "Бензин легкий")]
        public decimal BenzinLight {get; set;}
        public decimal Butan {get; set;}
        public decimal Kerosin {get; set;}
    }
}
