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

        [Display(Name = "Бензин тяжелый")]
        public decimal BenzinHard { get; set; }
        
        [Display(Name = "Рефлюкс")]
        public decimal Reflux { get; set; }

        [Display(Name = "Бутан")]
        public decimal Butan { get; set; }

        [Display(Name = "Керосин осветительный")]
        public decimal Kerosin { get; set; }

        [Display(Name = "Натрий едкий технический")]
        public decimal Natrium { get; set; }

        [Display(Name = "Метанол")]
        public decimal Metanol { get; set; }

        [Display(Name = "Агидол-1")]
        public decimal Agidol { get; set; }

        [Display(Name = "Ингибитор ц.101")]
        public decimal Ingibitor { get; set; }

        [Display(Name = "Этилен 1-ой очереди")]
        public decimal Ethylene { get; set; }

        [Display(Name = "Пропилен 1-ой очереди")]
        public decimal Propylene { get; set; }

        [Display(Name = "Фракция С4")]
        public decimal FractionC4 { get; set; }

        [Display(Name = "Фракция пропановая")]
        public decimal FractionPropan { get; set; }

        [Display(Name = "Фракция пиролизная, ПГС")]
        public decimal FractionPyrolize { get; set; }

        [Display(Name = "СПТ,ППТ")]
        public decimal SPT { get; set; }

        [Display(Name = "МВФ")]
        public decimal MVF { get; set; }

        [Display(Name = "Отходы")]
        public decimal Waste { get; set; }

    }
}
