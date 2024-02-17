﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistoMovimentosSrJoaquim.Business.Models
{
    internal class ListaMovimento
    {
        public int Id { get; set; }
        public string Data { get; set; }
        public string Descricao { get; set; }
        public int Valor { get; set; }
        public char Tipo { get; set; }
        public string Marcacao { get; set; }
        public string Cliente { get; set; }  
        public int ClienteId { get; set;}
    }
}