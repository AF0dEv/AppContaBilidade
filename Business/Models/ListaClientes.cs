using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistoMovimentosSrJoaquim.Business.Models
{
    internal class ListaClientes
    {
        public int Id { get; set; }
        public int NIF { get; set; }
        public string Nome { get; set; }
        public string? Estado { get; set; }

    }
}
