using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DistribuaAlimento.Models
{
    public class Evento
    {
        public int id { get; set; }

        public string nome { get; set; }

        public string numeroEstimadoPessoas { get; set; }

        public int idEstoque { get; set; }

        public virtual Estoque estoque { get; set; }

        public virtual Instituicao instituicao { get; set; }

    }
}