using Microsoft.EntityFrameworkCore;
using RegistoMovimentosSrJoaquim.Persistence.Data;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistoMovimentosSrJoaquim.Business.Models
{
    internal class Listagem
    {
        // =========== CONSTRUTOR ================
        public Listagem() { }


        // =========== PROPERTIES ==================

        private AppDbContext db;

        // =========== MÉTODOS =====================
        

        
        // ================================== PREENCHER CBX ====================================

        public void preencherCBX(ComboBox cbx, string nomeCbx)
        {
            if (nomeCbx == "Cliente")
            {
                try
                {
                    db = new AppDbContext();
                    List<string> ls = new List<string>();
                    ls = db.Clientes.Select(m =>  m.Nome ).ToList();
                    ls.Insert(0, "Todos");
                    cbx.DataSource = ls;
                   // cbx.ValueMember = "Id";
                   // cbx.DisplayMember = "Nome";
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {

                    db.Dispose();
                }
            }
            else if (nomeCbx == "Mes")
            {
                try
                {
                    DataTable dt = new DataTable();
                    dt.Columns.Add("MesNumero", typeof(string));
                    dt.Columns.Add("MesNome", typeof(string));

                    dt.Rows.Add("00", "Todos");
                    dt.Rows.Add("01", "Janeiro");
                    dt.Rows.Add("02", "Fevereiro");
                    dt.Rows.Add("03", "Março");
                    dt.Rows.Add("04", "Abril");
                    dt.Rows.Add("05", "Maio");
                    dt.Rows.Add("06", "Junho");
                    dt.Rows.Add("07", "Julho");
                    dt.Rows.Add("08", "Agosto");
                    dt.Rows.Add("09", "Setembro");
                    dt.Rows.Add("10", "Outubro");
                    dt.Rows.Add("11", "Novembro");
                    dt.Rows.Add("12", "Dezembro");

                    cbx.DataSource = dt;
                    cbx.ValueMember = "MesNumero";
                    cbx.DisplayMember = "MesNome";

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else if (nomeCbx == "Tipo")
            {
                try
                {
                    DataTable dt = new DataTable();
                    dt.Columns.Add("TipoNumero", typeof(string));
                    dt.Columns.Add("TipoNome", typeof(string));
                    dt.Rows.Add("00", "Todos");
                    dt.Rows.Add("01", "Crédito");
                    dt.Rows.Add("02", "Débito");

                    cbx.DataSource = dt;
                    cbx.ValueMember = "TipoNumero";
                    cbx.DisplayMember = "TipoNome";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        public static decimal GetSaldoCorrente(string cliente, DateTime data)
        {
            AppDbContext db = new AppDbContext();
            var saldoPositivo = db.Movimentos.Where(m => m.IdCliente.Nome == cliente && m.Tipo == 'C' && m.Data <= data).Sum(m => m.Valor);
            var saldoNegativo = db.Movimentos.Where(m => m.IdCliente.Nome == cliente && m.Tipo == 'D' && m.Data <= data).Sum(m => m.Valor);
            return saldoPositivo - saldoNegativo;
            

        }

        public void preencherDGV(DataGridView dgv, string dgvDt)
        {
            DataTable dt = new DataTable();
            db = new AppDbContext();
            
            try
            {
                if (dgvDt == "Movimento")
                {
                    decimal saldo;

                    
                    var ls = db.Movimentos.Select(m => new
                    {
                        m.Id,
                        m.Data,
                        m.Descricao,
                        Cliente = m.IdCliente.Nome,
                        m.Valor,
                        m.Tipo,
                        m.Marcacao,
                        
                    }).ToList();
                    dgv.DataSource = ls;
                    DataGridViewTextBoxColumn coluna = new DataGridViewTextBoxColumn();
                    coluna.HeaderText = "Saldo";
                    coluna.Name = "SaldoCorrente";
                    dgv.Columns.Add(coluna);
                    foreach (DataGridViewRow row in dgv.Rows)
                    {
                        string cliente = row.Cells["Cliente"].Value.ToString();
                        DateTime data = (DateTime)row.Cells["Data"].Value;

                        decimal money = GetSaldoCorrente(cliente, data);
                        row.Cells["SaldoCorrente"].Value = money;
                       
                        
                    }
                    
                }
                else if (dgvDt == "Cliente")
                {
                    dgv.DataSource = db.Clientes.Select(m => new
                    {
                        m.NIF,
                        m.Nome,
                        m.Estado,
                    }).ToList();
                    
                }
                else if (dgvDt == "EstadoAtivo")
                {
                    dgv.DataSource = db.Clientes.Select(m => new
                    {
                        m.Nome,
                        m.Estado,
                    }).Where(m => m.Estado != null && m.Estado != "").ToList();
                }
                else if (dgvDt == "EstadoPendente")
                {
                    dgv.DataSource = db.Clientes.Select(m => new
                    {
                        m.Nome,
                        m.Estado,
                    }).Where(m => m.Estado == null || m.Estado == "").ToList();
                }
                else if (dgvDt == "Marcados")
                {
                    dgv.DataSource = db.Movimentos.Select(m => new
                    {
                        Cliente = m.IdCliente.Nome,
                        m.Marcacao,
                        m.Data,
                        m.Descricao,
                        m.Valor,
                    }).Where(m => m.Marcacao != null).ToList();
                }
                else if (dgvDt == "Livres")
                {
                    dgv.DataSource = db.Movimentos.Select(m => new
                    {
                        Cliente = m.IdCliente.Nome,
                        m.Marcacao,
                        m.Data,
                        m.Descricao,
                        m.Valor,
                    }).Where(m => m.Marcacao == null).ToList();
                }
                else if (dgvDt == "Entradas")
                {
                    dgv.DataSource = db.Movimentos.Select(m => new
                    {
                        Cliente = m.IdCliente.Nome,
                        m.Tipo,
                        m.Valor,
                    }).Where(m => m.Tipo == 'C').ToList();
                }
                else if (dgvDt == "Saidas")
                {
                    dgv.DataSource = db.Movimentos.Select(m => new
                    {
                        Cliente = m.IdCliente.Nome,
                        m.Tipo,
                        m.Valor,
                    }).Where(m => m.Tipo == 'D').ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
