using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mvc_app.Models
{
    public class Data106_1
    {
        public int Id { get; set; }
        public int? ShopId { get; set; }
        public Shop Shop { get; set; }

        public DateTime CreatedAt {get; set;}

        [Display(Name = "Полиэтилен сырец 1-ой очереди")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal PolyethyleneS1 { get;set; }

        [Display(Name = "Мешок полипропиленовый 1х505х755 (шт.)")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal BagPolyprop { get;set; }

        [Display(Name = "Полиэтилен 1-ой очереди")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Polyethylene1 { get;set; }

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

        public void Calculate()
        {
            this.PolyethyleneS1 = 1.0m * this.Polyethylene1;
            this.BagPolyprop = 40.950154m * this.Polyethylene1;
            this.PolyWasteA2 = 0.00009m * this.Polyethylene1;
            this.PolyWasteB = 0.00023m * this.Polyethylene1;
            this.PolyWasteA4 = 0.00067m * this.Polyethylene1;
            this.PolyWasteD = 0.00017m * this.Polyethylene1;
            this.PlenkaWaste = 0.0003m * this.Polyethylene1;
            this.PlenkaWasteE2 = 0.0001m * this.Polyethylene1;

            this.CreatedAt = DateTime.Now;
        }
    }
}