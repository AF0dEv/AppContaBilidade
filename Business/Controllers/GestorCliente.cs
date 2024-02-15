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
        private AppDbContext db = AppDbContext.getInstance();
        Cliente? c = null;

        // ============= MÉTODOS ================

        public void addCliente(int nif, string nome, string estado) {
            try
            {
                c = new Cliente(nif, nome, estado);

                if (db.Clientes is not null && c is not null)
                {
                    db.Clientes.Add(c);
                    db.SaveChanges();
                }
                c = null;
            }catch (Exception ex) { MessageBox.Show(ex.Message); } 
        }


        public void updateCliente(string idCliente, int nif, string nome, string estado)
        {
            c = null;

            if (db.Clientes is not null)
            {
                c = db.Clientes.FirstOrDefault(m => m.Id == Convert.ToInt16(idCliente);

                if (c is not null)
                {
                    c.Nome = nome;
                    c.NIF = nif;
                    c.Estado = estado;
                }
            }

            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        
        public void deleteCliente(string idCliente)
        {
            c = null;

            if (db.Clientes is not null)
            {
                c = db.Clientes.Where(m => m.Id == Convert.ToInt16(idCliente)).FirstOrDefault();

                if (c is not null)
                {
                    db.Clientes.Remove(c);
                    db.SaveChanges();
                    c = null;
                }
            } 
        }


    }
}
