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
        public Cliente() { }

        // Propriedades

        private int id;
        private int nif;
        private string nome;
        private string estado;

        // Métodos
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int NIF
        {
            get { return nif; }
            set { nif = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string? Estado
        {
            get { return estado; }
            set { estado = value; }
        }
    }
}
