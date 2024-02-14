using RegistoMovimentosSrJoaquim.Business.Models;
using RegistoMovimentosSrJoaquim.Persistence.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistoMovimentosSrJoaquim.Business.Controllers
{
    internal class GestorListagem
    {
        // ==== CONSTRUTOR =====
        public GestorListagem() { }

        // ==== PROPERTIES =====

        AppDbContext db = new AppDbContext();
        Listagem ls = new Listagem();

        // ==== MÉTODOS ========
        public void FormatarDGV(DataGridView dgv, string dgvDt)
        {
            if (dgvDt == "Movimento")
            {
                // ROWS Background Color
                dgv.RowsDefaultCellStyle.BackColor = Color.LightGray;
                dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.White; // OVERRIDES RowsDefaultCellStyle

                // Estrutura

                dgv.AllowUserToAddRows = false; // para contar linhas/registos
                                                // dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                dgv.RowHeadersVisible = false;
                dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgv.ReadOnly = true;
                dgv.AllowUserToResizeRows = false;
                dgv.AllowUserToResizeColumns = false;

                // Id

                //dgv.Columns[0].Width = 50;
                dgv.Columns[0].HeaderText = "Nº Movimento";
                dgv.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                // Data

                dgv.Columns[1].Width = 80;
                dgv.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv.Columns[1].HeaderText = "Data";
                dgv.Columns[1].DefaultCellStyle.Format = "yyyy-MM-dd";
                dgv.Columns[1].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("pt-PT");

                // Valor

                dgv.Columns[4].Width = 85;
                dgv.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv.Columns[4].HeaderText = "Valor";
                dgv.Columns[4].DefaultCellStyle.Format = "c"; // c -> currency
                dgv.Columns[4].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("pt-PT");
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    if (row.Cells["Tipo"].Value.ToString() == "C")
                    {
                        row.Cells["Valor"].Style.ForeColor = Color.Green;
                    }
                    else
                    {
                        row.Cells["Valor"].Style.ForeColor = Color.Red;
                    }
                }

                // Tipo

                dgv.Columns[5].Width = 55;
                dgv.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv.Columns[5].HeaderText = "Tipo";

                // Cliente

                dgv.Columns[3].Width = 250;
                dgv.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv.Columns[3].HeaderText = "Cliente";

                // Marcador 

                dgv.Columns[6].Width = 80;
                dgv.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv.Columns[6].HeaderText = "Marcador";

                // Saldo

                dgv.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    if (Convert.ToInt32(row.Cells["SaldoCorrente"].Value.ToString()) < 0)
                    {
                        row.Cells["SaldoCorrente"].Style.ForeColor = Color.Red;
                    }
                    else
                    {
                        row.Cells["SaldoCorrente"].Style.ForeColor = Color.Green;
                    }
                }

            }
            else if (dgvDt == "Cliente")
            {
                // ROWS Background Color
                dgv.RowsDefaultCellStyle.BackColor = Color.LightGray;
                dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.White; // OVERRIDES RowsDefaultCellStyle

                // Estrutura

                dgv.AllowUserToAddRows = false; // para contar linhas/registos
                dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                dgv.RowHeadersVisible = false;
                dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgv.ReadOnly = true;
                dgv.AllowUserToResizeRows = false;
                dgv.AllowUserToResizeColumns = false;

                // NIF 

                dgv.Columns[0].Width = 50;
                dgv.Columns[0].HeaderText = "NIF";
                dgv.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                // Nome

                dgv.Columns[1].Width = 250;
                dgv.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv.Columns[1].HeaderText = "Cliente";

                // Estado

                dgv.Columns[2].Width = 80;
                dgv.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv.Columns[2].HeaderText = "Estado";
            }
            else if (dgvDt == "EstadoAtivo")
            {
                // ROWS Background Color
                dgv.RowsDefaultCellStyle.BackColor = Color.LightGray;
                dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.White; // OVERRIDES RowsDefaultCellStyle

                // Estrutura

                dgv.AllowUserToAddRows = false; // para contar linhas/registos
                dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                dgv.RowHeadersVisible = false;
                dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgv.ReadOnly = true;
                dgv.AllowUserToResizeRows = false;
                dgv.AllowUserToResizeColumns = false;

                // Nome

                dgv.Columns[0].Width = 50;
                dgv.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv.Columns[0].HeaderText = "Cliente";

                // Estado

                dgv.Columns[1].Width = 80;
                dgv.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv.Columns[1].HeaderText = "Estado";
            }
            else if (dgvDt == "EstadoPendente")
            {
                // ROWS Background Color
                dgv.RowsDefaultCellStyle.BackColor = Color.LightGray;
                dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.White; // OVERRIDES RowsDefaultCellStyle

                // Estrutura

                dgv.AllowUserToAddRows = false; // para contar linhas/registos
                dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                dgv.RowHeadersVisible = false;
                dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgv.ReadOnly = true;
                dgv.AllowUserToResizeRows = false;
                dgv.AllowUserToResizeColumns = false;

                // Nome

                dgv.Columns[0].Width = 50;
                dgv.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv.Columns[0].HeaderText = "Cliente";

                // Estado

                dgv.Columns[1].Width = 80;
                dgv.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv.Columns[1].HeaderText = "Estado";
            }
            else if (dgvDt == "Marcados")
            {
                // ROWS Background Color
                dgv.RowsDefaultCellStyle.BackColor = Color.LightGray;
                dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.White; // OVERRIDES RowsDefaultCellStyle

                // Estrutura

                dgv.AllowUserToAddRows = false; // para contar linhas/registos
                // dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                dgv.RowHeadersVisible = false;
                dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgv.ReadOnly = true;
                dgv.AllowUserToResizeRows = false;
                dgv.AllowUserToResizeColumns = false;

                // Cliente

                dgv.Columns[0].Width = 50;
                dgv.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv.Columns[0].HeaderText = "Cliente";

                // Marcacao

                dgv.Columns[1].Width = 80;
                dgv.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv.Columns[1].HeaderText = "Marcador";

                // Data

                dgv.Columns[2].Width = 80;
                dgv.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv.Columns[2].HeaderText = "Data";
                dgv.Columns[2].DefaultCellStyle.Format = "yyyy-MM-dd";
                dgv.Columns[2].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("pt-PT");

                // Valor

                dgv.Columns[4].Width = 85;
                dgv.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv.Columns[4].HeaderText = "Valor";
                dgv.Columns[4].DefaultCellStyle.Format = "c"; // c -> currency
                dgv.Columns[4].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("pt-PT");
            }
            else if (dgvDt == "Livres")
            {
                // ROWS Background Color
                dgv.RowsDefaultCellStyle.BackColor = Color.LightGray;
                dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.White; // OVERRIDES RowsDefaultCellStyle

                // Estrutura

                dgv.AllowUserToAddRows = false; // para contar linhas/registos
                // dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                dgv.RowHeadersVisible = false;
                dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgv.ReadOnly = true;
                dgv.AllowUserToResizeRows = false;
                dgv.AllowUserToResizeColumns = false;

                // Cliente

                dgv.Columns[0].Width = 50;
                dgv.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv.Columns[0].HeaderText = "Cliente";

                // Marcacao

                dgv.Columns[1].Width = 80;
                dgv.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv.Columns[1].HeaderText = "Marcador";

                // Data

                dgv.Columns[2].Width = 80;
                dgv.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv.Columns[2].HeaderText = "Data";
                dgv.Columns[2].DefaultCellStyle.Format = "yyyy-MM-dd";
                dgv.Columns[2].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("pt-PT");

                // Valor

                dgv.Columns[4].Width = 85;
                dgv.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv.Columns[4].HeaderText = "Valor";
                dgv.Columns[4].DefaultCellStyle.Format = "c"; // c -> currency
                dgv.Columns[4].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("pt-PT");
            }
            else if (dgvDt == "Entradas")
            {
                // ROWS Background Color
                dgv.RowsDefaultCellStyle.BackColor = Color.LightGray;
                dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.White; // OVERRIDES RowsDefaultCellStyle

                // Estrutura

                dgv.AllowUserToAddRows = false; // para contar linhas/registos
                dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                dgv.RowHeadersVisible = false;
                dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgv.ReadOnly = true;
                dgv.AllowUserToResizeRows = false;
                dgv.AllowUserToResizeColumns = false;

                // Cliente 

                dgv.Columns[0].Width = 250;
                dgv.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv.Columns[0].HeaderText = "Cliente";

                // Tipo 

                dgv.Columns[1].Width = 55;
                dgv.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv.Columns[1].HeaderText = "Tipo";

                // Valor

                dgv.Columns[2].Width = 85;
                dgv.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv.Columns[2].HeaderText = "Valor";
                dgv.Columns[2].DefaultCellStyle.Format = "c"; // c -> currency
                dgv.Columns[2].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("pt-PT");
            }
            else if (dgvDt == "Saidas")
            {
                // ROWS Background Color
                dgv.RowsDefaultCellStyle.BackColor = Color.LightGray;
                dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.White; // OVERRIDES RowsDefaultCellStyle

                // Estrutura

                dgv.AllowUserToAddRows = false; // para contar linhas/registos
                dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                dgv.RowHeadersVisible = false;
                dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgv.ReadOnly = true;
                dgv.AllowUserToResizeRows = false;
                dgv.AllowUserToResizeColumns = false;

                // Cliente 

                dgv.Columns[0].Width = 250;
                dgv.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv.Columns[0].HeaderText = "Cliente";

                // Tipo 

                dgv.Columns[1].Width = 55;
                dgv.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv.Columns[1].HeaderText = "Tipo";

                // Valor

                dgv.Columns[2].Width = 85;
                dgv.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv.Columns[2].HeaderText = "Valor";
                dgv.Columns[2].DefaultCellStyle.Format = "c"; // c -> currency
                dgv.Columns[2].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("pt-PT");


            }
        }

        public void ListarClienteSelecionado(ComboBox cbx, DataGridView dgv)
        {
            var lsa = dgv.DataSource;
            string dt = cbx.Text.ToString();
           
            if (dt == "Todos")
            {

                lsa = db.Movimentos.Select(m => new
                {
                    m.Id,
                    m.Data,
                    m.Descricao,
                    Cliente = m.IdCliente.Nome,
                    m.Valor,
                    m.Tipo,
                    m.Marcacao,
                }).ToList();
                dgv.DataSource = lsa;
                foreach (var DataGridViewRow in dgv)
                {
                    // estava aqui, a tentar que a dgv nao rebentasse por causa do formato, loop para ver se existe coli¡una saldo senao cria la
                }

            }
            else
            {

                 lsa = db.Movimentos.Select(m => new
                {
                    m.Id,
                    m.Data,
                    m.Descricao,
                    Cliente = m.IdCliente.Nome,
                    m.Valor,
                    m.Tipo,
                    m.Marcacao,
                }).Where(m => m.Cliente == dt).ToList();
                dgv.DataSource = lsa;
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    string cliente = row.Cells["Cliente"].Value.ToString();
                    DateTime data = (DateTime)row.Cells["Data"].Value;

                    decimal money = ls.GetSaldoCorrente(cliente, data);
                    row.Cells["SaldoCorrente"].Value = money;


                }
                //// formatar saldo
                //dgv.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                //dgv.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                //foreach (DataGridViewRow row in dgv.Rows)
                //{
                //    if (Convert.ToInt32(row.Cells["SaldoCorrente"].Value.ToString()) < 0)
                //    {
                //        row.Cells["SaldoCorrente"].Style.ForeColor = Color.Red;
                //    }
                //    else
                //    {
                //        row.Cells["SaldoCorrente"].Style.ForeColor = Color.Green;
                //    }
                //}

                //// formatar valor

                //foreach (DataGridViewRow row in dgv.Rows)
                //{
                //    if (row.Cells["Tipo"].Value.ToString() == "C")
                //    {
                //        row.Cells["Valor"].Style.ForeColor = Color.Green;
                //    }
                //    else
                //    {
                //        row.Cells["Valor"].Style.ForeColor = Color.Red;
                //    }
                //}
            }


        }

        public void ListarAteMes(ComboBox cbx, DataGridView dgv)
        {
            string dt = cbx.Text.ToString();
            //if (dt == "Todos")
            //{
            //    ls.preencherDGV(dgv, "Movimentos");
            //}
            //else
            //{
            //    var ls = db.Movimentos
            //}
            // * COMPARAR MOVIMENTOS DE UM ANO PARA O OUTRO E MENSAIS * \\ 

        }
    }
}
