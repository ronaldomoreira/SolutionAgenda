using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Models
{
    public class Email
    {

        public Email()
        {
            IdEmail = Guid.NewGuid();
        }

        [Key]
        public Guid IdEmail { get; set; }
        public Guid IdContato { get; set; }
        public Tipos TipoEmail { get; set; }
        public string EnderecoEmail { get; set; }
        public virtual Contato  ContatoEmail { get; set; }

    }
}
