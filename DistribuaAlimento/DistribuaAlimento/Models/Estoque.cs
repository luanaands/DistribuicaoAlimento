using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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

        [Key, ForeignKey("Evento")]
        public int id { get; set; }

        public int idAlimento { get; set; }

        public virtual ICollection<Alimento> alimentos { get; set; }

        public virtual Evento evento { get; set; }
    }
}