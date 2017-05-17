﻿using System;
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

        }
    }
}