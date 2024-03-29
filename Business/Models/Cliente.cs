﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistoMovimentosSrJoaquim.Business.Models
{
    internal class Cliente
    {
        // Propriedades
        public int Id { get; set; } 
        public int NIF { get; set; }
        public string Nome { get; set; }
        public string? Estado { get; set; }

        // Construtor
        public Cliente(int nif, string nome, string estado)
        {
            this.NIF = nif;
            this.Nome = nome;
            this.Estado = estado;
        }
        public Cliente() { }
    }
}
