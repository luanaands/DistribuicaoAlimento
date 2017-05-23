using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DistribuaAlimento.Models
{
    [Table("instituicao")]
    public class Instituicao
    {


        public Instituicao()
        {
            this.eventos = new HashSet<Evento>();
        }

        [Key]
        public int id { get; set; }

        public string razaosocial { get; set; }

        public string nomeRepresentante { get; set; }

        public string cnpj { get; set; }

        //[Column("contato")]
        public string telefone { get; set; }

        public string email { get; set; }

        public ICollection<Evento> eventos { get; set; }

    }
}