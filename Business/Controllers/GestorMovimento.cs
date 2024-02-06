using RegistoMovimentosSrJoaquim.Business.Models;
using RegistoMovimentosSrJoaquim.Persistence.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistoMovimentosSrJoaquim.Business.Controllers
{
    internal class GestorMovimento
    {
        // ============== CONSTRUTOR ===============
        public GestorMovimento() { }

        // ============== PROPERTIES ===============
        private AppDbContext db;

        // ============= MÉTODOS ================
        public void addMovimento(Movimento mv)
        {
            try
            {
                db = new AppDbContext();
                db.Movimentos.Add(mv);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { db.Dispose(); }
        }

        public void updateMovimento(Movimento mv)
        {
            try
            {
                db = new AppDbContext();
                db.Movimentos.Update(mv);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { db.Dispose(); }
        }
    }
}
