using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistoMovimentosSrJoaquim.Business.Models
{
    internal class Cliente
    {
        // Construtor
        public Cliente(int nif, string nome, string estado) 
        {
            this.nif = nif;
            this.nome = nome;
            this.estado = estado;
        }

        // Propriedades

        private int id;
        private int nif;
        private string nome;
        private string estado;

        // Métodos
        public int Id { get; set; }

        public int NIF { get; set; }
        public string Nome { get; set; }
        public string? Estado { get; set; }
    }
}
