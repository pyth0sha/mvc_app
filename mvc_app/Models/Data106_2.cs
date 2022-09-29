using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mvc_app.Models
{
    public class Data106_2
    {
        public int Id { get; set; }
        public int? ShopId { get; set; }
        public Shop Shop { get; set; }

        [Display(Name = "Полиэтилен сырец 2-ой очереди")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal PolyethyleneS2 { get;set; }

        [Display(Name = "Полиэтилен 2-ой очереди")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Polyethylene2 { get;set; }

        [Display(Name = "Отходы полиэтилена А-2")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal PolyWasteA2 { get;set; }

        [Display(Name = "Отходы полиэтилена B")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal PolyWasteB { get;set; }

        [Display(Name = "Отходы полиэтилена А-4")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal PolyWasteA4 { get;set; }

        [Display(Name = "Отходы полиэтилена Д")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal PolyWasteD { get;set; }

        [Display(Name = "Отходы при пр-ве пленки тБ")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal PlenkaWaste { get;set; }

        [Display(Name = "Отходы полипропиленовых мешков тип Е-2")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal PlenkaWasteE2 { get;set; }
    }
}