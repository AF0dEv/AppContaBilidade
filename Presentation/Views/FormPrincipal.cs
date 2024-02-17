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
            
            DateTime data = dtpMovimento.Value;
            string descricao = txtDescricao.Text;
            string marcacao = txtMarcacao.Text;
            int IdCliente = Convert.ToInt16(cbxClienteMov.SelectedValue);
            int tipoId = Convert.ToInt16(cbxTipo.SelectedValue);
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
                pc.addMovimento(data,descricao,valor,marcacao, IdCliente);
            }
            else
            {
                MessageBox.Show("Preencha os campos corretamente.");
            }

            pc.PreencherDgvMovimentos(dgvPrincipal);
            pc.PreencherDgvMarcados(dgvMvMarcados);
            pc.PreencherDgvLivres(dgvMvLivres);
        }
    }
}
