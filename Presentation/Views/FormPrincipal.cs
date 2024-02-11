using RegistoMovimentosSrJoaquim.Business.Controllers;
using RegistoMovimentosSrJoaquim.Business.Models;
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

        Listagem ls = new Listagem();
        ProgramController pc = new ProgramController();

        // ============= M�TODOS ================
        private void V_Load(object sender, EventArgs e)
        {
            ls.preencherCBX(cbxClienteMov, "Cliente");
            ls.preencherCBX(cbxTipo, "Tipo");
            ls.preencherDGV(dgvPrincipal, "Movimento");
            ls.preencherDGV(dgvMvMarcados, "Marcados");
            ls.preencherDGV(dgvMvLivres, "Livres");
            pc.FormatarDGV(dgvPrincipal, "Movimento");
            pc.FormatarDGV(dgvMvMarcados, "Marcados");
            pc.FormatarDGV(dgvMvLivres, "Livres");
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
