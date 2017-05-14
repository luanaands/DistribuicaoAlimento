using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DistribuaAlimento.Models
{
    public class Doacao
    {

        public int id { get; set; }

        public int idOrganizacaoFila { get; set; }

        public int idArrecadado { get; set; }

        public virtual IList<Arrecadado> arrecadados { get; set; }

        public virtual IList<OrganizacoesFilantropicas> organizacoes { get; set; }



    }
}