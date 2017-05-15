using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DistribuaAlimento.Models
{
    public class Estoque
    {
        public Estoque()
        {
            this.alimentos = new HashSet<Alimento>();
        }


        public int id { get; set; }

        public int idAlimento { get; set; }

        public virtual ICollection<Alimento> alimentos { get; set; }


    }
}