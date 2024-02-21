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

        }

        private void btnCriarClix_Click(object sender, EventArgs e)
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
            string tipoId = cbxTipo.SelectedValue.ToString();
            if (tipoId.Equals("01"))
            {
                tipo = 'C';
            }
            else if (tipoId.Equals("02"))
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

            if (!string.IsNullOrWhiteSpace(descricao) && IdCliente != 0 && tipoId != "0")
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

        // ERRO AQUI, INDEXES ERRADOS, CONSERTAR O SELECIONADO MAL FAZ LOAD

        private void dgvPrincipal_SelectionChanged(object sender, EventArgs e)
        {
            dtpMovimento.Text = dgvPrincipal.SelectedCells[1].Value.ToString();
            txtDescricao.Text = dgvPrincipal.SelectedCells[2].Value.ToString();
            txtValor.Text = dgvPrincipal.SelectedCells[3].Value.ToString();
            if (dgvPrincipal.SelectedCells[4].Value.ToString().Equals('C')) 
            {
                cbxTipo.SelectedItem = "Crédito";
            }
            else if (dgvPrincipal.SelectedCells[4].Value.ToString().Equals('D'))
            {
                cbxTipo.SelectedItem = "Débito";
            }
            if (dgvPrincipal.SelectedCells[4].Value.ToString() != null)
            {
                txtMarcacao.Text = dgvPrincipal.SelectedCells[4].Value.ToString();
            }
            cbxClienteMov.SelectedItem = dgvPrincipal.SelectedCells[6].Value.ToString();

        }
    }
}
