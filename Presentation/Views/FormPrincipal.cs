using RegistoMovimentosSrJoaquim.Business.Controllers;
using RegistoMovimentosSrJoaquim.Business.Models;
using System.Drawing;
using System.Globalization;
using System.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace RegistoMovimentosSrJoaquim
{
    public partial class FormPrincipal : Form
    {
        // ============== CONSTRUTOR ===============
        public FormPrincipal()
        {
            InitializeComponent();
        }

        // ============== PROPERTIES ===============
        ProgramController pc = new ProgramController();
        CultureInfo culture = CultureInfo.CreateSpecificCulture("pt-PT");

        // ============= MÉTODOS ================
        private void V_Load(object sender, EventArgs e)
        {
            txtIdMovimento.Text = "0";
            pc.PreencherCbxClientesMov(cbxClienteMov);
            pc.PreencherCbxTipos(cbxTipo);
            pc.PreencherDgvMovimentos(dgvPrincipal);
            pc.PreencherDgvMarcados(dgvMvMarcados);
            pc.PreencherDgvLivres(dgvMvLivres);
        }

        private void btnMnListagem_Click(object sender, EventArgs e)
        {
            FormListagens fl = new FormListagens();
            fl.Show();
            this.Hide();
        }

        private void btnMnClientes_Click(object sender, EventArgs e)
        {
            FormCliente fc = new FormCliente();
            fc.Show();
            this.Hide();
        }

        private void btnAtualizarMov_Click(object sender, EventArgs e)
        {
            int idMov = Convert.ToInt16(txtIdMovimento.Text);
            DateTime data = dtpMovimento.Value;
            string descricao = txtDescricao.Text;
            string? marcacao = null;
            if (txtMarcacao.Text.Equals(null) || txtMarcacao.Text.Equals(""))
            {
                marcacao = null;
            }
            else
            {
                marcacao = txtMarcacao.Text;
            }
            int idCliente = Convert.ToInt16(cbxClienteMov.SelectedValue);
            int tipoId = Convert.ToInt16(cbxTipo.SelectedValue);
            char tipo = 'C';
            if (tipoId == 1)
            {
                tipo = 'C';
            }
            else if (tipoId == 2)
            {
                tipo = 'D';
            }
            decimal valor = 0.0m;
            try
            {
                valor = Convert.ToDecimal(txtValor.Text);
            }
            catch
            {
                MessageBox.Show("Preencha o camp 'Valor' corretamente.");
                return;
            }
            if (dgvPrincipal.SelectedRows.Count > 0)
            {
                pc.updateMovimento(data, descricao, valor, tipo, marcacao, idCliente, idMov);
                MessageBox.Show("Movimento Atualizado com Sucesso");
            }
            else
            {
                MessageBox.Show("Selecione um movimento da tabela para atualizar.");
            }
            pc.PreencherDgvMovimentos(dgvPrincipal);
            pc.PreencherDgvMarcados(dgvMvMarcados);
            pc.PreencherDgvLivres(dgvMvLivres);
        }

        private void btnCriarMov_Click(object sender, EventArgs e)
        {
            char tipo = 'C';
            string? marcacao = null;
            DateTime data = dtpMovimento.Value;
            string descricao = txtDescricao.Text;
            if (txtMarcacao.Text == null || txtMarcacao.Text == "")
            {
                marcacao = null;
            }
            else
            {
                marcacao = txtMarcacao.Text;
            }
            int IdCliente = Convert.ToInt16(cbxClienteMov.SelectedValue);
            int tipoId = Convert.ToInt16(cbxTipo.SelectedValue);
            if (tipoId == 1)
            {
                tipo = 'C';
            }
            else if (tipoId == 2)
            {
                tipo = 'D';
            }

            decimal valor = 0.0m;
            try
            {
                valor = Convert.ToDecimal(txtValor.Text);
            }
            catch
            {
                MessageBox.Show("Preencha o camp 'Valor' corretamente.");
                return;
            }

            if (!string.IsNullOrWhiteSpace(descricao) && IdCliente != 0 && tipoId != 0)
            {
                pc.addMovimento(data, descricao, valor, tipo, marcacao, IdCliente);
            }
            else
            {
                MessageBox.Show("Preencha os campos corretamente.");
            }

            pc.PreencherDgvMovimentos(dgvPrincipal);
            pc.PreencherDgvMarcados(dgvMvMarcados);
            pc.PreencherDgvLivres(dgvMvLivres);
        }

        private void dgvPrincipal_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                txtIdMovimento.Text = dgvPrincipal.SelectedCells[0].Value.ToString();
                dtpMovimento.Text = dgvPrincipal.SelectedCells[1].Value.ToString();
                txtDescricao.Text = dgvPrincipal.SelectedCells[2].Value.ToString();
                txtValor.Text = dgvPrincipal.SelectedCells[3].Value.ToString();
                cbxClienteMov.SelectedValue = dgvPrincipal.SelectedCells[7].Value;
                if (dgvPrincipal.SelectedCells[4].Value.Equals('C'))
                {
                    cbxTipo.SelectedValue = 1;
                }
                else if (dgvPrincipal.SelectedCells[4].Value.Equals('D'))
                {
                    cbxTipo.SelectedValue = 2;
                }
                if (!dgvPrincipal.SelectedCells[5].Value.Equals(null))
                {
                    txtMarcacao.Text = dgvPrincipal.SelectedCells[5].Value.ToString();
                }

            }
            catch { }


        }
        private void LimparSelecao()
        {

            // Movimentos
            txtIdMovimento.Clear();
            txtDescricao.Clear();
            txtMarcacao.Clear();
            cbxClienteMov.SelectedIndex = -1;
            cbxTipo.SelectedIndex = -1;
            dtpMovimento.ResetText();
            dgvPrincipal.ClearSelection();
        }

        private void btnApagarMov_Click(object sender, EventArgs e)
        {
            int idMov = Convert.ToInt16(txtIdMovimento.Text);
            if (dgvPrincipal.SelectedRows.Count > 0)
            {
                pc.deleteMovimento(idMov);
                MessageBox.Show("Movimento Apagado com Sucesso");
            }
            else
            {
                MessageBox.Show("Selecione um movimento da tabela para atualizar.");
            }
            pc.PreencherDgvMovimentos(dgvPrincipal);
            pc.PreencherDgvMarcados(dgvMvMarcados);
            pc.PreencherDgvLivres(dgvMvLivres);
        }
    }

}
