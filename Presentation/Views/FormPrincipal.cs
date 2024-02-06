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

        // ============= MÉTODOS ================
        private void V_Load(object sender, EventArgs e)
        {

            ls.preencherCBX(cbxMes, "Mes");
            ls.preencherCBX(cbxCliente, "Cliente");
            ls.preencherDGV(dgvPrincipal, "Movimento");
            ls.preencherDGV(dgvEntradas, "Entradas");
            ls.preencherDGV(dgvSaidas, "Saidas");
            pc.FormatarDGV(dgvPrincipal, "Movimento");
            pc.FormatarDGV(dgvEntradas, "Entradas");
            pc.FormatarDGV(dgvSaidas, "Saidas");













            // * PERGUNTAR PJ PORQUE NÃO FUNCIONA ASSIM * \\

            //for (int i = 0; i <= cbxCliente.Items.Count; i++)
            //{
            //    cbxFullList.Add(cbxCliente.Items[i].ToString(), i); 
            //}


            //ls.FilterList(false, cbxCliente, cbxBusy, cbxFullList, cbxFilteredList);
        }

        private void btnCriarCliente_Click(object sender, EventArgs e)
        {
            FormCliente formCliente = new FormCliente();
            formCliente.Show();
            this.Hide();
        }

        private void btnCriarMov_Click(object sender, EventArgs e)
        {
            FormMovimentos formMovimentos = new FormMovimentos();
            formMovimentos.Show();
            this.Hide();
        }
    }
}
