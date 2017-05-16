using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DistribuaAlimento.Models
{
    public class Doacao
    {

        public Doacao()
        {
            this.organizacoes = new HashSet<OrganizacoesFilantropicas>();
            this.arrecadados = new HashSet<Arrecadado>();
        }



        public int id { get; set; }

        public int idOrganizacaoFila { get; set; }

        public int idArrecadado { get; set; }

        public virtual ICollection<Arrecadado> arrecadados { get; set; }

        public virtual ICollection<OrganizacoesFilantropicas> organizacoes { get; set; }



    }
}