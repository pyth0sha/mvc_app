using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace mvc_app.Models
{
    public class Data401
    {
        public int Id { get; set; }
        public int? ShopId { get; set; }
        public Shop Shop { get; set; }

        public DateTime CreatedAt {get; set;}

        [Display(Name = "НАК")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal NAK { get; set; }

        [Display(Name = "МА")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal MA { get; set; }

        [Display(Name = "Фильтрпанель САМПС 401")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Filterpanel { get; set; }

        [Display(Name = "Бязь суровая ц.401")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Biaz { get; set; }

        [Display(Name = "Натрий едкий технический")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Natrii { get; set; }
        
        [Display(Name = "Кислота серная техническая")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal SulphAcid { get; set; }

        [Display(Name = "Порофор ЧХЗ-57")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Prophor { get; set; }

        [Display(Name = "Диметилформамид")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Dimethil { get; set; }

        [Display(Name = "Кислота яблочная")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal AppleAcid { get; set; }

        [Display(Name = "АМПС (метилпропансульфокислота)")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal AMPS { get; set; }

        [Display(Name = "Сода кальцинированная")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal SodaCalc { get; set; }

        // основной ввод
        [Display(Name = "Нитрон Д")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal NitronD { get; set; }

        // вода
        [Display(Name = "Вода обессоленная (1000м3)")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Water { get; set; }

        [Display(Name = "Натрий едкий технический")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal NatriiWater { get; set; }
        
        [Display(Name = "Кислота серная техническая")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal SulphAcidWater { get; set; }

        public void Calculate()
        {
            this.NAK = 0.922m * this.NitronD;
            this.MA = 0.0853m * this.NitronD;
            this.Filterpanel = 0.011111m * this.NitronD;
            this.Biaz = 0.0015m * this.NitronD;
            this.Natrii = 0.145m * this.NitronD;
            this.SulphAcid = 0.0156m * this.NitronD;
            this.Prophor = 0.0011m * this.NitronD;
            this.Dimethil = 0.022m * this.NitronD;
            this.AppleAcid = 0.00068m * this.NitronD;
            this.AMPS = 0.0128m * this.NitronD;
            this.SodaCalc = 0.00333m * this.NitronD;

            this.CreatedAt = DateTime.Now;
        }
    }
}
