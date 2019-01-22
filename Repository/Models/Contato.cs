using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repository.Models
{
    public class Contato
    {
        /// <summary>
        /// Cosntructor
        /// </summary>
        public Contato()
        {
            IdContato = Guid.NewGuid();
            Emails = new List<Email>();
            Telefones = new List<Telefone>();

        }

        [Key]
        public Guid IdContato { get; set; }
        public bool Ativo { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Empresa { get; set; }
        [ForeignKey("IdContato")]
        public virtual ICollection<Email> Emails { get; set; }
        [ForeignKey("IdContato")]
        public virtual ICollection<Telefone> Telefones { get; set; }
    }
}

