using RegistoMovimentosSrJoaquim.Business.Models;
using RegistoMovimentosSrJoaquim.Persistence;
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
        Listagem ls = new Listagem();

        // ====================================== MÉTODOS ======================================
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
                    if (Convert.ToInt32(row.Cells["Saldo"].Value.ToString()) < 0)
                    {
                        row.Cells["Saldo"].Style.ForeColor = Color.Red;
                    }
                    else
                    {
                        row.Cells["Saldo"].Style.ForeColor = Color.Green;
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
        public decimal GetSaldoCorrente(string nomeCliente, DateTime data)
        {
            return Listagem.GetSaldoCorrente(nomeCliente, data);
        }

        // ================================== PREENCHER CBX ====================================

        public void PreencherCbxTipos(ComboBox cbx)
        {
            ls.PreencherCbxTipos(cbx);
        }
        public void PreenchreCbxMes(ComboBox cbx)
        {
            ls.PreencherCbxMeses(cbx);
        }
        public void PreencherCbxClientesListagem(ComboBox cbx)
        {
            ls.PreencherCbxClientesListagem(cbx);
        }
        public void PreencherCbxClientesMov(ComboBox cbx)
        {
            ls.PreencherCbxClientesMov(cbx);
        }

        // ================================== PREENCHER DGV ====================================

        public void PreencherDgvClientes(DataGridView dgvClientes)
        {
            dgvClientes.DataSource = ls.PreencherDgvClientes();
        }
        public void PreencherDgvMovimentos(DataGridView dgvMovimentos)
        {
            dgvMovimentos.DataSource = ls.PreencherDgvMovimentos();
        }
        public void PreencherDgvLivres(DataGridView dgvLivres)
        {
            dgvLivres.DataSource = ls.PreencherDgvLivres();
        }
        public void PreencherDgvMarcados(DataGridView dgvMarcados)
        {
            dgvMarcados.DataSource = ls.PreencherDgvMarcados();
        }
        public void PreencherDgvEstadoPendente(DataGridView dgvEstadoPendente)
        {
            dgvEstadoPendente.DataSource = ls.PreencherDgvEstadoPendente();
        }
        public void PreencherDgvEstadoAtivo(DataGridView dgvEstadoAtivo)
        {
            dgvEstadoAtivo.DataSource = ls.PreencherDgvEstadoAtivo();
        }
        public void PreencherDgvEntradas(DataGridView dgvEntradas)
        {
            dgvEntradas.DataSource = ls.PreencherDgvEntradas();
        }
        public void PreencherDgvSaidas(DataGridView dgvSaidas)
        {
            dgvSaidas.DataSource = ls.PreencherDgvSaidas();
        }

        // ================================== LISTAGENS ====================================

        public List<ListaMovimentos>? ListarMovimentosClienteSelecionado(string ClienteId)
        {
            return ls.ListarMovimentosClienteSelecionado(ClienteId);
        }
        public List<ListaMovimentos>? ListarMovimentosClienteMesPeriodo(string ClienteId, string? mesNumero, SelectionRange? periodoTempo, int mesPeriodo)
        {
            return ls.ListarMovimentosClienteMesPeriodo(ClienteId, mesNumero, periodoTempo, mesPeriodo);
        }
        public List<ListaMovimentos>? ListarMovimentosTodosClientesMesPeriodo(string? mesNumero, SelectionRange? periodoTempo, int mesPeriodo)
        {
            return ls.ListarMovimentosTodosClientesMesPeriodo(mesNumero, periodoTempo, mesPeriodo);
        }
        public List<ListaClientes>? ListarClientesDevemMaisMil()
        {
            return ls.ListarClientesDevemMaisMil();
        }
    }
}

