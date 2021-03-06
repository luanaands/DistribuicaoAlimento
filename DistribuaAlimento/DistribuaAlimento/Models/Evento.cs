﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DistribuaAlimento.Models
{
    public class Evento
    {

        public Evento() { }

        
        public int id { get; set; }
        //foreign key 
        //one for one
        public int idInstituicao { get; set; }

        public int idArrecadado { get; set; }
        //
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime inicio { get;  set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime fim { get; set; }

        public string nome { get; set; }

        public string publico { get; set; }

        public virtual Estoque estoque { get; set; }

        public virtual Instituicao instituicao { get; set; }

        public virtual Arrecadado arrecadado { get; set; }
    }
}