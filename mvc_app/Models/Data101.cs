using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mvc_app.Models
{
    public class Data101
    {
        public int Id { get; set; }
        public int? ShopId { get; set; }
        public Shop Shop { get; set; }
        
        public DateTime CreatedAt {get; set;}

        [Display(Name = "УВС (общее количество)")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal UVS {get; set;} 

        [Display(Name = "Бензин легкий")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal BenzinLight { get; set; }

        [Display(Name = "Бензин тяжелый")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal BenzinHard { get; set; }
        
        [Display(Name = "Рефлюкс")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Reflux { get; set; }

        [Display(Name = "Бутан")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Butan { get; set; }

        [Display(Name = "Керосин осветительный")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Kerosin { get; set; }

        [Display(Name = "Натрий едкий технический")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Natrium { get; set; }

        [Display(Name = "Метанол")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Metanol { get; set; }

        [Display(Name = "Агидол-1")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Agidol { get; set; }

        [Display(Name = "Ингибитор ц.101")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Ingibitor { get; set; }

        [Display(Name = "Этилен 1-ой очереди")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Ethylene { get; set; }

        [Display(Name = "Пропилен 1-ой очереди")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Propylene { get; set; }

        [Display(Name = "Фракция С4")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal FractionC4 { get; set; }

        [Display(Name = "Фракция пропановая")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal FractionPropan { get; set; }

        [Display(Name = "Фракция пиролизная, ПГС")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal FractionPyrolize { get; set; }

        [Display(Name = "СПТ,ППТ")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal SPT { get; set; }

        [Display(Name = "МВФ")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal MVF { get; set; }

        [Display(Name = "Отходы")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Waste { get; set; }

        public void Calculate()
        {
            var EthProp = this.Ethylene + this.Propylene;
            this.UVS = this.BenzinLight + this.BenzinHard + this.Reflux;

            this.Kerosin = 0.00095m * EthProp;
            this.Natrium = 0.00194m * EthProp;
            this.Metanol = 0.000234m * EthProp;
            this.Agidol = 0.0004m * EthProp;
            this.Ingibitor = 0.000257m * EthProp;
            this.FractionC4 = 0.24039m * EthProp;
            this.FractionPropan = 0.055335m * EthProp;
            this.FractionPyrolize = 0.4928m * EthProp;
            this.SPT = 0.122576m * EthProp;
            this.MVF = 0.444772m * EthProp;
            this.Waste = 0.02m * this.UVS;

            this.CreatedAt = DateTime.Now;
        }
    }
}
