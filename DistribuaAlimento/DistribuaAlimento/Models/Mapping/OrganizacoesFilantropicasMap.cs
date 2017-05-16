using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace DistribuaAlimento.Models.Mapping
{
    public class OrganizacoesFilantropicasMap : EntityTypeConfiguration<OrganizacoesFilantropicas>
    {
        public OrganizacoesFilantropicasMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties

            // Table & Column Mappings
            this.ToTable("Alimento");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.nome).HasColumnName("nome");

            this.HasRequired<Arrecadado>(s => s.arrecadado)
                    .WithMany(s => s.organizacaoFilatropicas)
                    .HasForeignKey(s => s.id);
        }
    }
}