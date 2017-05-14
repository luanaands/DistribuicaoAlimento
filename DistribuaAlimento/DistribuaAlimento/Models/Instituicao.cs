using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DistribuaAlimento.Models
{
    public class Instituicao
    {

        public int id { get; set; }

        public string nome { get; set; }

        public string nomeRepresentante { get; set; }

        public string cnpj { get; set; }

        public string contato { get; set; }

        public string email { get; set; }

        public IList<Evento> eventos { get; set; }

    }
}