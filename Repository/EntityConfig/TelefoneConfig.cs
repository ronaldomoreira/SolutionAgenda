using Repository.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.EntityConfig
{
    class TelefoneConfig: EntityTypeConfiguration<Telefone>
    {
        public TelefoneConfig()
        {
            HasKey(t => t.IdTelefone);

            Property(e => e.TipoTel)
              .IsRequired();

            Property(t => t.DDI)
                .IsRequired()
                .HasMaxLength(3);

            Property(t => t.DDD)
                  .HasMaxLength(2);

            Property(t => t.NumeroTelefone)
                  .IsRequired()
                  .HasMaxLength(15);

            HasRequired(t => t.ContatoTeleFone)
                .WithMany(c => c.Telefones)
                .HasForeignKey(e => e.IdContato);

            ToTable("Telefone");

        }
    }
}
