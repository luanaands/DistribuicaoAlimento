using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DistribuaAlimento.Models
{
    public class Evento
    {

        public Evento() { }

        public int id { get; set; }

        public DateTime inicio { get;  set; }

        public DateTime fim { get; set; }

        public string nome { get; set; }

        public string publico { get; set; }

        public int idEstoque { get; set; }

        public virtual Estoque estoque { get; set; }

        public virtual Instituicao instituicao { get; set; }

        public virtual Arrecadado arrecadado { get; set; }
    }
}