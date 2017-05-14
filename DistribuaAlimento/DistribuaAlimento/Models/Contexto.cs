using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DistribuaAlimento.Models
{
    public partial class Contexto : DbContext
    {
        public Contexto() : base("name=Contexto")
        { }

        public virtual DbSet<Alimento> Alimento { get; set; }
        public virtual DbSet<Evento> Evento { get; set; }
        public virtual DbSet<Doacao> Doacao { get; set; }
        public virtual DbSet<Instituicao> Instituicao { get; set; }
        public virtual DbSet<OrganizacoesFilantropicas> OrganizacoesFilantropicas { get; set; }
        public virtual DbSet<Arrecadado> Arrecadado { get; set; }
        public virtual DbSet<Estoque> Estoque { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add();
            modelBuilder.Configurations.Add();
            modelBuilder.Configurations.Add();
            modelBuilder.Configurations.Add();

            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;
        }

    }
}