using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DistribuaAlimento.Models
{
    public class Estoque
    {


        public int id { get; set; }

        public int idAlimento { get; set; }

        public virtual IList<Alimento> alimentos { get; set; }


    }
}