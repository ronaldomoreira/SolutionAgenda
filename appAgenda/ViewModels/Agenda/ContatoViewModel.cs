using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace appAgenda.ViewModels.Agenda
{
    public class ContatoViewModel
    {
        public ContatoViewModel()
        {
            IdContato = Guid.NewGuid();
            Emails = new List<EmailViewModel>();
            Telefones = new List<TelefoneViewModel>();

        }

        [Key]
        [ScaffoldColumn(false)]
        public Guid IdContato { get; set; }

        [StringLength(200)]
        [Display(Name = "Nome")]
        [Required(ErrorMessage = "Campo Nome é Obrigatório", AllowEmptyStrings = false)]
        [MaxLength(200, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(5, ErrorMessage = "Mínimo {0} caracteres")]
        public string Nome { get; set; }

        [StringLength(200)]
        [Display(Name = "Endereço")]
        [MaxLength(200, ErrorMessage = "Máximo {0} caracteres")]
        public string Endereco { get; set; }

        [StringLength(100)]
        [Display(Name = "Empresa")]
        [MaxLength(100, ErrorMessage = "Máximo {0} caracteres")]
        public string Empresa { get; set; }

        [ScaffoldColumn(false)]
        public bool Ativo { get; set; }

        [ForeignKey("IdContato")]
        public virtual ICollection<EmailViewModel> Emails { get; set; }

        [ForeignKey("IdContato")]
        public virtual ICollection<TelefoneViewModel> Telefones { get; set; }
    }
}