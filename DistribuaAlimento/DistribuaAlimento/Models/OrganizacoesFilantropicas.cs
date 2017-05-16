using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DistribuaAlimento.Models
{
    public class OrganizacoesFilantropicas
    {
        public OrganizacoesFilantropicas() {

          //  this.arrecadados= new HashSet<Arrecadado>();
        }

        public int id { get; set; }

        public string nome { get; set; }

        public string nomeRepresentante { get; set; }

        public string cnpj { get; set; }

        public string contato { get; set; }

        public string email { get; set; }
        public virtual Arrecadado arrecadado { get; set; }

      //  public virtual ICollection<Arrecadado> arrecadados { get; set; }

    }
}