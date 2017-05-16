using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DistribuaAlimento.Models
{
    public class Arrecadado
    {



        public Arrecadado()
        {
            this.eventos = new HashSet<Evento>();
            //this.organizacaoFilatropicas = new HashSet<OrganizacoesFilantropicas>();
        }

        public int id { get; set; }

        public int idEvento { get; set; }
        public virtual ICollection<Evento> eventos { get; set; }

       // public virtual ICollection<OrganizacoesFilantropicas> organizacaoFilatropicas { get; set; }

        public virtual Doacao doacao { get; set; }
    }
}