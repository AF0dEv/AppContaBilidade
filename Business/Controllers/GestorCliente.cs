using RegistoMovimentosSrJoaquim.Business.Models;
using RegistoMovimentosSrJoaquim.Persistence.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistoMovimentosSrJoaquim.Business.Controllers
{
    internal class GestorCliente
    {
        // ============== CONSTRUTOR ===============
        public GestorCliente() { }


        // ============== PROPERTIES ===============
        private AppDbContext db;

        // ============= MÉTODOS ================

        public void addCliente(Cliente c) {
            try
            {
                db = new AppDbContext();
                db.Clientes.Add(c);

            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }finally 
            { 
                db.Dispose();
            }  
        }
        public void updateCliente(Cliente c)
        {
            try
            {
                db = new AppDbContext();
                db.Clientes.Update(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { db.Dispose(); }
        }
        // * FUTURAMENTE IMPLEMENTAR REMOVER APESAR DE NAO SER USADO * \\


    }
}
