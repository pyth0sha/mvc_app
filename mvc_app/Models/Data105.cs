using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mvc_app.Models
{
    public class Data105
    {
        public int Id { get; set; }
        public int? ShopId { get; set; }
        public Shop Shop { get; set; }

        public DateTime CreatedAt {get; set;}

        [Display(Name = "Этилен 1-ой очереди")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Ethylene1 { get;set; }

        [Display(Name = "Этилен 2-ой очереди")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Ethylene2 { get;set; }

        [Display(Name = "Инициатор DTBP")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal InitDTBP { get;set; }

        [Display(Name = "Инициатор TBPEH")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal InitTBPEH { get;set; }

        [Display(Name = "Инициаторное масло")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal InitOil { get;set; }

        [Display(Name = "Кислород")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Oxygen { get;set; }

        [Display(Name = "Пропан")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Propan { get;set; }
        
        // основной ввод
        [Display(Name = "Полиэтилен сырец 2-ой очереди")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal PolyethyleneS2 { get;set; }

        [Display(Name = "Низкомолекулярный полиэтилен")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal PolyethyleneNM { get;set; }

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
            this.Ethylene1 = 0.25866m * this.PolyethyleneS2;
            this.Ethylene2 = 0.79134m * this.PolyethyleneS2;
            this.InitDTBP = 0.0002m * this.PolyethyleneS2;
            this.InitTBPEH = 0.00045m * this.PolyethyleneS2;
            this.InitOil = 0.0023m * this.PolyethyleneS2;
            this.Oxygen = 0.00051m * this.PolyethyleneS2;
            this.Propan = 0.00035m * this.PolyethyleneS2;
            this.PolyethyleneNM = 0.000499m * this.PolyethyleneS2;
            this.PolyWasteA2 = 0.00035m * this.PolyethyleneS2;
            this.PolyWasteB = 0.0001m * this.PolyethyleneS2;
            this.PolyWasteA4 = 0.00001m * this.PolyethyleneS2;

            this.CreatedAt = DateTime.Now;
        }
    }
}