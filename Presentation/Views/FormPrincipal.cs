using RegistoMovimentosSrJoaquim.Business.Controllers;
using RegistoMovimentosSrJoaquim.Business.Models;
using System.Globalization;
using System.Linq;

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
    }
}
