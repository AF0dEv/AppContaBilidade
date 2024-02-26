using RegistoMovimentosSrJoaquim.Business.Controllers;
using RegistoMovimentosSrJoaquim.Business.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistoMovimentosSrJoaquim
{
    public partial class FormListagens : Form
    {
        // ============== CONSTRUTOR ===============
        public FormListagens()
        {
            InitializeComponent();
        }

        // ============== PROPERTIES ===============
        ProgramController pc = new ProgramController();
        CultureInfo culture = CultureInfo.CreateSpecificCulture("pt-PT");


        // ============= MÉTODOS ================
        private void FormMovimentos_Load(object sender, EventArgs e)
        {
            pc.PreencherCbxMes(cbxMes);
            pc.PreencherCbxClientesListagem(cbxClienteLis);
            pc.PreencherDgvMovimentos(dgvListagem);

            gbPeriodoTempo.Hide();
            gbPeriodoTempo.Enabled = false;
            LimparSelecao();
        }
        // ================= VOLTAR FORM ORIGINAL =====================
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            FormPrincipal fp = new FormPrincipal();
            this.Hide();
            fp.Show();
        }

        private void rbtTempoPreciso_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtTempoPreciso.Checked)
            {
                gbMes.Show();
                gbMes.Enabled = true;
                // melhorar aqui adicionando botaao de limpar selecao de periodo tempo e melhorar como limpa pois nao fica ate o dia de hoje
                dtpListagem.SelectionStart = DateTime.Now;
                dtpListagem.SelectionEnd = DateTime.Now;
            }
            else
            {
                gbMes.Hide();
                gbMes.Enabled = false;
            }

        }

        private void rbtPeriodoTempo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtPeriodoTempo.Checked)
            {
                gbPeriodoTempo.Show();
                gbPeriodoTempo.Enabled = true;
            }
            else
            {
                gbPeriodoTempo.Hide();
                gbPeriodoTempo.Enabled = false;
            }
        }

        private void cbxMes_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string? clienteId = null;
            //// se for todos / todos
            //if (rbtTempoPreciso.Checked && cbxMes.SelectedValue.ToString().Equals("00") && cbxClienteLis.SelectedValue.ToString().Equals("00"))
            //{
            //    pc.PreencherDgvMovimentos(dgvListagem);
            //}
            //// se for todos e mes preciso
            //else if (rbtTempoPreciso.Checked && cbxClienteLis.SelectedValue.ToString().Equals("00") && !cbxMes.SelectedValue.ToString().Equals("00"))
            //{
            //    string data = cbxMes.SelectedValue.ToString();
            //    dgvListagem.DataSource = pc.ListarMovimentosTodosClientesMesPeriodo(data, null, 1);
            //}
            //// se for cliente preciso e todos mes
            //else if (!cbxClienteLis.SelectedValue.ToString().Equals("00") && rbtTempoPreciso.Checked && cbxMes.SelectedValue.ToString().Equals("00"))
            //{
            //    clienteId = cbxClienteLis.SelectedValue.ToString();
            //    dgvListagem.DataSource = pc.ListarMovimentosClienteSelecionado(clienteId);
            //}
        }

        private void cbxClienteLis_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string? clienteId = null;
            //// se for todos / todos
            //if (rbtTempoPreciso.Checked && cbxMes.SelectedValue.ToString().Equals("00") && cbxClienteLis.SelectedValue.ToString().Equals("00"))
            //{
            //    pc.PreencherDgvMovimentos(dgvListagem);
            //}
            //// se for todos e mes preciso
            //else if (rbtTempoPreciso.Checked && cbxClienteLis.SelectedValue.ToString().Equals("00") && !cbxMes.SelectedValue.ToString().Equals("00"))
            //{
            //    string data = cbxMes.SelectedValue.ToString();
            //    dgvListagem.DataSource = pc.ListarMovimentosTodosClientesMesPeriodo(data, null, 1);
            //}
            //// se for todos e periodo de tempo
            //else if (rbtPeriodoTempo.Checked && cbxClienteLis.SelectedValue.ToString().Equals("00"))
            //{
            //    SelectionRange data = dtpListagem.SelectionRange;
            //    dgvListagem.DataSource = pc.ListarMovimentosTodosClientesMesPeriodo(null, data, 2);
            //}
            //// se for cliente preciso e todos mes
            //else if (!cbxClienteLis.SelectedValue.ToString().Equals("00") && rbtTempoPreciso.Checked && cbxMes.SelectedValue.ToString().Equals("00"))
            //{
            //    clienteId = cbxClienteLis.SelectedValue.ToString();
            //    dgvListagem.DataSource = pc.ListarMovimentosClienteSelecionado(clienteId);
            //}
            //// se for cliente preciso e qql periodo tempo
            //else if (!cbxClienteLis.SelectedValue.ToString().Equals("00") && rbtPeriodoTempo.Checked)
            //{
            //    clienteId = cbxClienteLis.SelectedValue.ToString();
            //    dgvListagem.DataSource = pc.ListarMovimentosClienteSelecionado(clienteId);
            //}
        }

        private void dtpListagem_DateSelected(object sender, DateRangeEventArgs e)
        {
            //string? clienteId = null;

            //// se for todos e periodo de tempo
            //if (rbtPeriodoTempo.Checked && cbxClienteLis.SelectedValue.ToString().Equals("00"))
            //{
            //    SelectionRange data = dtpListagem.SelectionRange;
            //    dgvListagem.DataSource = pc.ListarMovimentosTodosClientesMesPeriodo(null, data, 2);
            //}
            //// se for cliente preciso e qql periodo tempo
            //else if (!cbxClienteLis.SelectedValue.ToString().Equals("00") && rbtPeriodoTempo.Checked)
            //{
            //    clienteId = cbxClienteLis.SelectedValue.ToString();
            //    dgvListagem.DataSource = pc.ListarMovimentosClienteSelecionado(clienteId);
            //}
        }

        private void LimparSelecao()
        {
            cbxClienteLis.SelectedIndex = -1;
            cbxMes.SelectedIndex = -1;
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            string? clienteId = null;
            string? data = null;
            SelectionRange? range = null;
            // se for todos / todos
            if (rbtTempoPreciso.Checked && cbxMes.SelectedValue.ToString().Equals("00") && cbxClienteLis.SelectedValue.ToString().Equals("0"))
            {
                pc.PreencherDgvMovimentos(dgvListagem);
            }
            // se for todos e mes preciso
            else if (rbtTempoPreciso.Checked && cbxClienteLis.SelectedValue.ToString().Equals("0") && !cbxMes.SelectedValue.ToString().Equals("00"))
            {
                data = cbxMes.SelectedValue.ToString();
                dgvListagem.DataSource = pc.ListarMovimentosTodosClientesMesPeriodo(data, null, 1);
            }
            // se for cliente preciso e mes todos
            else if (rbtTempoPreciso.Checked && !cbxClienteLis.SelectedValue.ToString().Equals("0") && cbxMes.SelectedValue.ToString().Equals("00"))
            {
                clienteId = cbxClienteLis.SelectedValue.ToString();
                dgvListagem.DataSource = pc.ListarMovimentosClienteSelecionado(clienteId);
            }
            // se for cliente preciso e mes preciso 
            else if (rbtTempoPreciso.Checked && !cbxClienteLis.SelectedValue.ToString().Equals("0") && !cbxMes.SelectedValue.ToString().Equals("00"))
            {
                clienteId = cbxClienteLis.SelectedValue.ToString();
                data = cbxMes.SelectedValue.ToString();
                dgvListagem.DataSource = pc.ListarMovimentosClienteMesPeriodo(clienteId, data, null, 1);
            }
            // se for todos e periodo de tempo preciso
            else if (rbtPeriodoTempo.Checked && cbxClienteLis.SelectedValue.ToString().Equals("0") && !dtpListagem.SelectionRange.Equals(null))
            {
                range = dtpListagem.SelectionRange;
                dgvListagem.DataSource = pc.ListarMovimentosTodosClientesMesPeriodo(null, range, 2);
            }

            // ================= MELHORAR DAQUI PARA BAIXO --> sFALTA SO OS BOTOES E ESTA FORM LISTAGEM COMPLETO (falta apenas arranjos finais formatacao dgv e tudo message box em todas as confirmaçoes e isso)
            else if (rbtPeriodoTempo.Checked && !cbxClienteLis.SelectedValue.ToString().Equals("0") && !dtpListagem.SelectionRange.Equals(null))
            {
                string mensagem =
            @$"Não Selecionou Nenhum Periodo de Tempo!
               Apenas Dia Especifico!
               Deseja Continuar?";

                string cabecalho = "PERIODO TEMPO NÃO SELECIONADO";

                var result = MessageBox.Show(mensagem, cabecalho, MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    range = dtpListagem.SelectionRange;
                    range.Start = DateTime.MinValue;
                    clienteId = cbxClienteLis.SelectedValue.ToString();
                    dgvListagem.DataSource = pc.ListarMovimentosClienteMesPeriodo(clienteId, null, range, 2);
                }
                else
                {
                    MessageBox.Show("Operaçao cancelada.");
                }

            }
        }

        private void btnEntradas_Click(object sender, EventArgs e)
        {
            pc.PreencherDgvEntradas(dgvListagem);
        }

        private void btnSaidas_Click(object sender, EventArgs e)
        {
            pc.PreencherDgvSaidas(dgvListagem);
        }

        private void btnMaiorMil_Click(object sender, EventArgs e)
        {
            
        }
    }
}
