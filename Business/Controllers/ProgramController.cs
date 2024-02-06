using RegistoMovimentosSrJoaquim.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistoMovimentosSrJoaquim.Business.Controllers
{
    internal class ProgramController
    {
        // ==== CONSTRUTOR =====
        public ProgramController() { }

        // ==== PROPERTIES =====
        private GestorListagem gl = new GestorListagem();
        private GestorCliente gc = new GestorCliente();
        private GestorMovimento gm = new GestorMovimento();

        // ==== MÉTODOS ========

        // GESTOR MOVIMENTO

        public void addMovimento(Movimento mv)
        {
            gm.addMovimento(mv);
        }

        public void updateMovimento(Movimento mv)
        {
            gm.updateMovimento(mv);
        }

        // GESTOR CLIENTE
        public void addCliente(Cliente c)
        {
            gc.addCliente(c);
        }

        public void updateCliente (Cliente c)
        {
            gc.updateCliente(c);
        }

        // GESTOR LISTAGEM

        public void FormatarDGV(DataGridView dgv, string dgvDt)
        {
            gl.FormatarDGV(dgv, dgvDt);
        }
    }
}
