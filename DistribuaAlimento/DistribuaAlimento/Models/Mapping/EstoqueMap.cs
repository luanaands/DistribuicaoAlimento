﻿using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace DistribuaAlimento.Models.Mapping
{
    public class EstoqueMap : EntityTypeConfiguration<Estoque>
    {
        public EstoqueMap()
        {
            

            // Table & Column Mappings
            this.ToTable("estoque");
            this.Property(t => t.id).HasColumnName("id");

        

        }
    }
}