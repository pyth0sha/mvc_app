using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mvc_app.Models
{
    public class Data402
    {
        public int Id { get; set; }
        public int? ShopId { get; set; }
        public Shop Shop { get; set; }

        public DateTime CreatedAt {get; set;}

        [Display(Name = "Нитрон Д")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal NitronD { get; set; }

        [Display(Name = "Сорбитан С")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal SorbitanC { get; set; }

        [Display(Name = "Сорбиталь С-20")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal SorbitalC20 { get; set; }

        [Display(Name = "Кислота азотная 65%")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal NitroAcid { get; set; }

        [Display(Name = "Жидкость ПМС-300 или Пеногаситель")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal PMS300 { get; set; }

        [Display(Name = "Синтезин")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Synthezin { get; set; }

        [Display(Name = "Двуокись титана")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Titan { get; set; }

        // основной ввод
        [Display(Name = "Волокно ПАН Д")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal PAND { get; set; }

        [Display(Name = "Волокно смесовое Д")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal VoloknoD { get; set; }

        [Display(Name = "Волокно техническое Ж")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal VoloknoTexJ { get; set; }

        // комплект упаковочный
        [Display(Name = "Комплект упаковочный")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal PackagingKit { get; set; }

        public void Calculate()
        {
            this.NitronD = 1.0m * this.PAND;
            this.SorbitanC = 0.0051m * this.PAND;
            this.SorbitalC20 = 0.0017m * this.PAND;
            this.NitroAcid = 0.000001m * this.PAND;
            this.PMS300 = 0.00008m * this.PAND;
            this.Synthezin = 0.00097m * this.PAND;
            this.Titan = 0.00076m * this.PAND;
            this.VoloknoD = 0.207222m * this.PAND;
            this.VoloknoTexJ = 0.004m * this.PAND;

            this.CreatedAt = DateTime.Now;
        }
    }
}