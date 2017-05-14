using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DistribuaAlimento.Models
{
    public class Alimento
    {

        public int id { get; set; }

        public string nome { get; set; }

        public string validade { get; set; }

        public string tipo { get; set; }

        public virtual Estoque estoque { get; set; }

    }
}