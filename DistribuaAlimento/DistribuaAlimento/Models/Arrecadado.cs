using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DistribuaAlimento.Models
{
    public class Arrecadado
    {


        public int id { get; set; }

        public int idEvento { get; set; }
        public virtual IList<Evento> eventos { get; set; }




    }
}