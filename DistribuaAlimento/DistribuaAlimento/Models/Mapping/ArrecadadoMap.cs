using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace DistribuaAlimento.Models.Mapping
{
    public class ArrecadadoMap : EntityTypeConfiguration<Arrecadado>
    {
        public ArrecadadoMap()
        {
            // Primary Key
            this.HasKey(t => t.id);
        
            // Table & Column Mappings
            this.ToTable("Arrecadado");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.idEvento).HasColumnName("idEvento");

            this.HasRequired<Doacao>(s => s)
                    .WithMany(s => s.organizacaoFilatropicas)
                    .HasForeignKey(s => s.id);

            //this.HasMany<OrganizacoesFilantropicas>(s => s.organizacaoFilatropicas)
            //    .WithMany(c => c.arrecadados)
            //    .Map(cs =>
            //    {
            //        cs.MapLeftKey("id");
            //        cs.MapRightKey("id");
            //        cs.ToTable("Doacao");
            //    });
        }
    }
}