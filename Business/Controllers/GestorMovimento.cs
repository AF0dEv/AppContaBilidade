using Microsoft.EntityFrameworkCore;
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
        private AppDbContext db = AppDbContext.getInstancia();
        Movimento? mv = null;

        // ============= MÉTODOS ================
        public void addMovimento(DateTime data, string descricao, decimal valor, char tipo, string marcacao, int Idcliente)
        {
            mv = new Movimento(data, descricao, valor, tipo, marcacao, Idcliente);

            if (db.Movimentos is not null)
            {
                db.Movimentos.Add(mv);
                db.SaveChanges();
            }

            mv = null;
        }
        public void updateMovimento(DateTime data, string descricao, int valor, string marcacao, int Idcliente)
        {
            mv = null;

            if (db.Movimentos is not null && mv is not null)
            {
                mv = db.Movimentos.FirstOrDefault(m => m.Id == Convert.ToInt16(Idcliente));

                if (mv is not null)
                {
                    mv.Data = data;
                    mv.Descricao = descricao;
                    mv.Valor = valor;
                    mv.Marcacao = marcacao;
                    mv.ClienteId = Idcliente;
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
        public void deleteMovimento(int idMovimento)
        {
            mv = null;

            if (db.Movimentos is not null)
            {
                mv = db.Movimentos.Where(m => m.Id == Convert.ToInt16(idMovimento)).FirstOrDefault();

                if (mv is not null)
                {
                    db.Movimentos.Remove(mv);
                    db.SaveChanges();
                    mv = null;
                }
            }
        }
    }
}
