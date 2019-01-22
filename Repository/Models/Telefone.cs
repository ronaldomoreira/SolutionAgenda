using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Models
{
    public class Telefone
    {
        public Telefone()
        {
            IdTelefone = Guid.NewGuid();
        }

        [Key]
        public Guid IdTelefone { get; set; }
        public Guid IdContato { get; set; }
        public Tipos TipoTel { get; set; }
        public string DDI { get; set; }
        public string DDD { get; set; }
        public string NumeroTelefone { get; set; }
        public virtual Contato ContatoTeleFone { get; set; }

    }
}