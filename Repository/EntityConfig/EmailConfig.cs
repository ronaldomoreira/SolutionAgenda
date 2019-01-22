using Repository.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.EntityConfig
{
    class EmailConfig: EntityTypeConfiguration<Email>
    {
        public EmailConfig()
        {
            HasKey(e => e.IdEmail);

            Property(e => e.TipoEmail)
                .IsRequired();

            Property(e => e.EnderecoEmail)
                .IsRequired()
                .HasMaxLength(200);

            HasRequired(e => e.ContatoEmail)
                .WithMany(c => c.Emails)
                .HasForeignKey(e => e.IdContato);

            ToTable("Email");


        }
    }
}
