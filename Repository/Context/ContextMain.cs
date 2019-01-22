using Repository.EntityConfig;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace Repository.Context
{
    public class ContextMain : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx

        public ContextMain() : base("name=DefaultConnection")
        {
            //
        }
        public DbSet<Contato> DbContatos { get; set; }
        public DbSet<Email> DbEmails { get; set; }
        public DbSet<Telefone> DbTelefones { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder
                .Properties<string>()
                .Configure(c => c.IsUnicode(false));

            modelBuilder.Properties<string>()
                .Configure(c => c.HasColumnType("varchar"));

            modelBuilder.Properties<string>()
                .Configure(c => c.HasMaxLength(256));

            modelBuilder.Configurations.Add(new ContatoConfig());
            modelBuilder.Configurations.Add(new EmailConfig());
            modelBuilder.Configurations.Add(new TelefoneConfig());

        }

    }
}