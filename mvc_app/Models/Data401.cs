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

        [Display(Name = "Нитрон Д")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal NitronD { get; set; }
    }
}
