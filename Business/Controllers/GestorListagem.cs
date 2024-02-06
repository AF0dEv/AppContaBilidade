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
                dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                dgv.RowHeadersVisible = false;
                dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgv.ReadOnly = true;
                dgv.AllowUserToResizeRows = false;
                dgv.AllowUserToResizeColumns = false;

                // Id

                dgv.Columns[0].Width = 50;
                dgv.Columns[0].HeaderText = "Nº Movimento";
                dgv.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                // Data

                dgv.Columns[1].Width = 80;
                dgv.Columns[1].HeaderCell.Style.Alignment= DataGridViewContentAlignment.MiddleCenter;
                dgv.Columns[1].DefaultCellStyle.Alignment= DataGridViewContentAlignment.MiddleCenter;
                dgv.Columns[1].HeaderText = "Data";
                dgv.Columns[1].DefaultCellStyle.Format = "yyyy-MM-dd";
                dgv.Columns[1].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("pt-PT");

                // Valor

                dgv.Columns[3].Width = 85;
                dgv.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv.Columns[3].HeaderText = "Valor";
                dgv.Columns[3].DefaultCellStyle.Format = "c"; // c -> currency
                dgv.Columns[3].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("pt-PT");
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    if (row.Cells["Tipo"].Value.ToString() == "C")
                    {
                        row.Cells["Valor"].Style.ForeColor = Color.Green;
                    }
                    else
                    {
                        row.Cells["Valor"].Style.ForeColor= Color.Red;
                    }
                }

                // Tipo

                dgv.Columns[4].Width = 55;
                dgv.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv.Columns[4].HeaderText = "Tipo";

                // Cliente

                dgv.Columns[5].Width = 250;
                dgv.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv.Columns[5].HeaderText = "Cliente";

                // Marcador 

                dgv.Columns[6].Width = 80;
                dgv.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv.Columns[6].HeaderText = "Marcador";
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

        // * LISTAR CLIENTES * \\
        // * LISTAR MOVIMENTOS CLIENTE * \\ 
        // * COMPARAR MOVIMENTOS DE UM ANO PARA O OUTRO E MENSAIS * \\ 

    }
}
