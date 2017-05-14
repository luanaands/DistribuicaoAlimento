﻿using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace DistribuaAlimento.Models.Mapping
{
    public class AlimentoMap : EntityTypeConfiguration<Alimento>
    {
        public AlimentoMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.nome)
                .HasMaxLength(30);

            this.Property(t => t.validade)
                .HasMaxLength(30);

            this.Property(t => t.tipo)
                .HasMaxLength(30);


            // Table & Column Mappings
            this.ToTable("Alimento");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.nome).HasColumnName("nome");
            this.Property(t => t.validade).HasColumnName("validade");
            this.Property(t => t.tipo).HasColumnName("tipo");



        }
    }
}