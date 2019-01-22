using Repository.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.EntityConfig
{
    class ContatoConfig : EntityTypeConfiguration<Contato>
    {
        public ContatoConfig()
        {
            HasKey(c => c.IdContato);  //HasKey(c => new {c.ClienteId, c.CPF});

            Property(c => c.Ativo)
                    .IsRequired();

            Property(c => c.Nome)
                    .IsRequired()
                    .HasMaxLength(200);

            Property(c => c.Endereco)
                    .IsRequired()
                    .HasMaxLength(200);
            Property(c => c.Endereco)
                    .HasMaxLength(100);

            ToTable("Contato");
        }
    }
}

















