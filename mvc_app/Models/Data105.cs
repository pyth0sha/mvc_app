using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mvc_app.Models
{
    public class Data105
    {
        public int Id { get; set; }
        public int? ShopId { get; set; }
        public Shop Shop { get; set; }

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
    }
}