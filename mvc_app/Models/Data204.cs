using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mvc_app.Models
{
    public class Data204
    {
        public int Id { get; set; }
        public int? ShopId { get; set; }
        public Shop Shop { get; set; }

        [Display(Name = "НАК")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal NAK { get; set; }

        [Display(Name = "Мешок полипропиленовый 1х505х775 (шт.)")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal BagPolyprop { get; set; }

        [Display(Name = "Этикетки полипропиленовые")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal LabelsPolyprop { get; set; }

        [Display(Name = "Контейнер МКР")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal ContainerMKR { get; set; }

        [Display(Name = "Сода каустическая")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal CausticSoda { get; set; }

        [Display(Name = "Гидрохинон")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Hydroxinon { get; set; }

        [Display(Name = "Лапрол 3003")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Laprol { get; set; }

        [Display(Name = "Натрий едкий технический")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Natrium { get; set; }

        [Display(Name = "Метанол")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Metanol { get; set; }

        [Display(Name = "Кислота серная техническая")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal SulphAcid { get; set; }

        [Display(Name = "ПМФ (моноэтиловый эфир гидрохин)")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal PMF { get; set; }

        [Display(Name = "Кальций хлористый 90%")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Calcium { get; set; }

        [Display(Name = "Амиак жидкий импорт")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal LiquidAmmiak { get; set; }

        [Display(Name = "МА")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal MA { get; set; }

        [Display(Name = "Сульфат амония")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal SulphAmonium { get; set; }
    }
}