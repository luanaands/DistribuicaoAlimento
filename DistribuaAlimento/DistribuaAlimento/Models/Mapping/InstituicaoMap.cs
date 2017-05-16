using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace DistribuaAlimento.Models.Mapping
{
    public class InstituicaoMap : EntityTypeConfiguration<Instituicao>
    {
        public InstituicaoMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
        

            // Table & Column Mappings
            this.ToTable("Instituicao");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.nome).HasColumnName("nome");
            this.Property(t => t.cnpj).HasColumnName("cnpj");
            this.Property(t => t.contato).HasColumnName("contato");
            this.Property(t => t.email).HasColumnName("email");
            this.Property(t => t.nomeRepresentante).HasColumnName("nomeRepresentante");
            this.Property(t => t.idEvento).HasColumnName("idEvento");

        }
    }
}