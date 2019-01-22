using Repository.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace appAgenda.ViewModels.Agenda
{
    public class EmailViewModel
    {
        public EmailViewModel()
        {
            IdEmail = Guid.NewGuid();
        }

        [Key]
        [ScaffoldColumn(false)]
        public Guid IdEmail { get; set; }

        [ScaffoldColumn(false)]
        public Guid IdContato { get; set; }

        [Display(Name = "Tipo de email")]
        public Tipos TipoEmail { get; set; }

        [Display(Name = "E-mail")]
        [EmailAddress(ErrorMessage = "E-mail inválido")]
        [Required(ErrorMessage = "Campo E-mail é obrigatório")]
        [MaxLength(200, ErrorMessage = "Máximo {0} caracteres")]
        public string EnderecoEmail { get; set; }

    }
}