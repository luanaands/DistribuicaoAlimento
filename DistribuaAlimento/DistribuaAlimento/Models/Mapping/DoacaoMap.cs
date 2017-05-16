using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace DistribuaAlimento.Models.Mapping
{
    public class DoacaoMap : EntityTypeConfiguration<Doacao>
    {
        public DoacaoMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
           


            // Table & Column Mappings
            this.ToTable("Alimento");
            this.Property(t => t.id).HasColumnName("id");
      

        }
    }
}