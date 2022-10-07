using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mvc_app.Models
{
    public class Data201
    {
        public int Id { get; set; }
        public int? ShopId { get; set; }
        public Shop Shop { get; set; }

        public DateTime CreatedAt {get; set;}

        [Display(Name = "Пропилен 1 и 2 очередей на НАК")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Propilen { get; set; }

        [Display(Name = "Ангидрид сернистый жидкий на НАК")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Angidrid { get; set; }

        [Display(Name = "Гидрохинон на НАК")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Hydroxinon { get; set; }

        [Display(Name = "Лапрол 3003 на НАК")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Laprol { get; set; }

        [Display(Name = "Натрий едкий технический на НАК")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Natrium { get; set; }

        [Display(Name = "Кислота уксусная на НАК")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal AceticAcid { get; set; }

        [Display(Name = "Триполифосфат натрия на НАК")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Triphosphat { get; set; }

        [Display(Name = "Гидразингидрат на НАК")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Hydrozin { get; set; }

        [Display(Name = "Кислота серная техническая на НАК")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal SulfAcid { get; set; }

        [Display(Name = "ПМФ (моноэтиловый эфир гидрохин) на НАК")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal PMF { get; set; }

        [Display(Name = "Амиак жидкий импорт на НАК")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Ammiak { get; set; }

        [Display(Name = "Ацетон на АЦГ")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Aceton { get; set; }

        [Display(Name = "Кислота азотная 65% на Кат. А-112")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal NitricAcid { get; set; }

        [Display(Name = "Натрий едкий очищенный на Кат. А-112")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal NatriumEdk { get; set; }

        [Display(Name = "Уголь активный древесный на Кат. А-112")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal WoodCoal { get; set; }

        [Display(Name = "Амоний молибденовокислый 99% на Кат. А-112")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Amonii { get; set; }

        [Display(Name = "Аэросил м.А-175 на Кат. А-112")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Aerosil { get; set; }

        [Display(Name = "Калий азотнокислый 99,8% на Кат. А-112")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal NitroKalium { get; set; }

        [Display(Name = "Натрий азотнокислый 99,8% на Кат. А-112")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal NitroNatrium { get; set; }

        [Display(Name = "Амиак жидкий РБ на Кат. А-112")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal LiquidAmmiak { get; set; }

        [Display(Name = "Висмут металлический на на Кат. А-112")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Vismuth { get; set; }

        [Display(Name = "Порошок железный на Кат. А-112")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal IronPowder { get; set; }

        [Display(Name = "Кислота ортофосфорная 85% на Кат. А-112")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal OrtophoAcid { get; set; }

        // НАК АЦН Кислота синильная АЦГ Катализатор ??
        // основной ввод?
        [Display(Name = "НАК")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal NAK { get; set; }

        [Display(Name = "НАК товар")] // ввод?
        [Column(TypeName = "decimal(18,2)")]
        public decimal NAKtovar { get; set; }

        [Display(Name = "НАК полуфаб.")] // ввод?
        [Column(TypeName = "decimal(18,2)")]
        public decimal NAKpolufab { get; set; }

        [Display(Name = "АЦГ")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal ACG { get; set; }

        [Display(Name = "Катализатор А-112 на НАК")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Katalizator { get; set; }

        public void Calculate()
        {
            this.Angidrid = 0.0072m * this.NAK;
            this.Hydroxinon = 0.00018m * this.NAK;
            this.Laprol = 0.00018m * this.NAK;
            this.Natrium = 0.010843m * this.NAK;
            this.AceticAcid = 0.003402m * this.NAK;
            this.Triphosphat = 0.0000125m * this.NAK;
            this.Hydrozin = 0.000006m * this.NAK;
            this.SulfAcid = 0.1m * this.NAK;
            this.Ammiak = 0.558879m * this.NAK;

            this.PMF = 0.000045m * this.NAKtovar + 0.000032m * this.NAKpolufab;

            this.Aceton = 0.702m * this.ACG;

            this.NitricAcid = 0.785714m * this.Katalizator;
            this.NatriumEdk = 0.4576m * this.Katalizator;
            this.WoodCoal = 0.0001m * this.Katalizator;
            this.Amonii = 0.3813m * this.Katalizator;
            this.Aerosil = 0.7253m * this.Katalizator;
            this.NitroKalium = 0.00098m * this.Katalizator;
            this.NitroNatrium = 0.0012m * this.Katalizator;
            this.LiquidAmmiak = 0.01m * this.Katalizator;
            this.Vismuth = 0.145m * this.Katalizator;
            this.IronPowder = 0.28m * this.Katalizator;
            this.OrtophoAcid = 0.0175m * this.Katalizator;

            this.CreatedAt = DateTime.Now;
        }
    }
}
