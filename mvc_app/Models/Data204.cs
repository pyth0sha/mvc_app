using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mvc_app.Models
{
    public class Data204
    {
        public int Id { get; set; }
        public int? ShopId { get; set; }
        public Shop Shop { get; set; }

        public DateTime CreatedAt {get; set;}

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

        // основной ввод
        [Display(Name = "МА")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal MA { get; set; }

        [Display(Name = "Сульфат амония")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal SulphAmonium { get; set; }

        public void Calculate()
        {
            this.NAK = 0.848m * this.MA;
            this.BagPolyprop = 18.5455m * this.MA;
            this.LabelsPolyprop = 19.954545m * this.MA;
            this.ContainerMKR = 0.811688m * this.MA;
            this.CausticSoda = 0.000812m * this.MA;
            this.Hydroxinon = 0.0018m * this.MA;
            this.Laprol = 0.0003447m * this.MA;
            this.Natrium = 0.01m * this.MA;
            this.Metanol = 0.73m * this.MA;
            this.SulphAcid = 2.145m * this.MA;
            this.PMF = 0.0013m * this.MA;
            this.Calcium = 0.0037m * this.MA;
            this.LiquidAmmiak = 0.421362m * this.MA;
            this.SulphAmonium = 2.344156m * this.MA;
            
            this.CreatedAt = DateTime.Now;
        }
    }
}