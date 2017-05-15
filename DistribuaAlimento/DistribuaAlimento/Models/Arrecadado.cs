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
        }

        public int id { get; set; }

        public int idEvento { get; set; }
        public virtual ICollection<Evento> eventos { get; set; }




    }
}