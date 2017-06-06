using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DistribuaAlimento.Models
{
    public class Alimento
    {

        public int id { get; set; }
        [Display(Name = "Data de Emissão")]
        public string nome { get; set; }
        [Display(Name = "Data de Emissão")]
        public string gramas { get; set; }
        [Display(Name = "Data de Emissão")]
        public DateTime validade { get; set; }
        [Display(Name = "Data de Emissão")]
        public string tipo { get; set; }
        [Display(Name = "Data de Emissão")]
        public int idEstoque { get; set; }
        [Display(Name = "Data de Emissão")]
        public virtual Estoque estoque { get; set; }

    }
}