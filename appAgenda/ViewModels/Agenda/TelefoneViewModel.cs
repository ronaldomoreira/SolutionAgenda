using Repository.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace appAgenda.ViewModels.Agenda
{
    public class TelefoneViewModel
    {
        public TelefoneViewModel()
        {
            IdTelefone = Guid.NewGuid();
        }

        [Key]
        [ScaffoldColumn(false)]
        public Guid IdTelefone { get; set; }
        [ScaffoldColumn(false)]
        public Guid IdContato { get; set; }

        [Display(Name = "Tipo de telefone")]
        public Tipos TipoTel { get; set; }

        [StringLength(3)]
        [Display(Name = "DDI")]
        [MaxLength(3, ErrorMessage = "Máximo {0} caracteres")]
        public string DDI { get; set; }

        [StringLength(2)]
        [Display(Name = "DDD")]
        [MaxLength(2, ErrorMessage = "Máximo {0} caracteres")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "DDD somente números")]
        public string DDD { get; set; }

        [StringLength(15)]
        [Display(Name = "Num. telefone")]
        [MaxLength(15, ErrorMessage = "Máximo {0} caracteres")]
        public string NumeroTelefone { get; set; }

    }
}