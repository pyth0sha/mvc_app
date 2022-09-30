using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;
using System.Xml.Linq;

namespace mvc_app.Models
{
    public class Data201
    {
        public int Id { get; set; }
        public int? ShopId { get; set; }
        public Shop Shop { get; set; }

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
    }
}
