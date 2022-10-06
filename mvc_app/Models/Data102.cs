using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mvc_app.Models
{
    public class Data102
    {
        public int Id { get; set; }
        public int? ShopId { get; set; }
        public Shop Shop { get; set; }

        public DateTime CreatedAt {get; set;}

        [Display(Name = "Этилен 1-ой очереди")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Ethylene1 { get;set; }

        [Display(Name = "Инициатор DTBP")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal InitDTBP { get;set; }

        [Display(Name = "Инициатор BU-50-AL")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal InitBU50AL { get;set; }

        [Display(Name = "Инициатор TBPEH")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal InitTBPEH { get;set; }

        [Display(Name = "Инициаторное масло")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal InitOil { get;set; }

        [Display(Name = "Тригонокс 36 С75")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Trigonox { get;set; }
        
        [Display(Name = "Полиэтилен сырец 1-ой очереди")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal PolyethyleneS1 { get;set; }

        [Display(Name = "Низкомолекулярный полиэтилен")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal PolyethyleneNM { get;set; }

        [Display(Name = "Отходы полиэтилена А-3")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal PolyWasteA3 { get;set; }

        [Display(Name = "Отходы полиэтилена А-2")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal PolyWasteA2 { get;set; }

        [Display(Name = "Отходы полиэтилена B")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal PolyWasteB { get;set; }

        [Display(Name = "Отходы полиэтилена А-4")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal PolyWasteA4 { get;set; }

        public void Calculate()
        {
            this.Ethylene1 = 1.038m * this.PolyethyleneS1;
            this.InitDTBP = 0.000043m * this.PolyethyleneS1;
            this.InitBU50AL = 0.00317m * this.PolyethyleneS1;
            this.InitTBPEH = 0.0001697m * this.PolyethyleneS1;
            this.InitOil = 0.005993m * this.PolyethyleneS1;
            this.Trigonox = 0.003584m * this.PolyethyleneS1;
            this.PolyethyleneNM = 0.00625m * this.PolyethyleneS1;
            this.PolyWasteA3 = 0.0001m * this.PolyethyleneS1;
            this.PolyWasteA2 = 0.00057m * this.PolyethyleneS1;
            this.PolyWasteB = 0.000380m * this.PolyethyleneS1;
            this.PolyWasteA4 = 0.00005m * this.PolyethyleneS1;

            this.CreatedAt = DateTime.Now;
        }
    }
}