using RegistoMovimentosSrJoaquim.Business.Controllers;
using RegistoMovimentosSrJoaquim.Business.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistoMovimentosSrJoaquim
{
    public partial class FormCliente : Form
    {
        // ============== CONSTRUTOR ===============
        public FormCliente()
        {
            InitializeComponent();
        }

        // ============== PROPERTIES ===============
        ProgramController pc = new ProgramController();
        Cliente c = new Cliente();
        Listagem ls = new Listagem();

        // ============= MÉTODOS ================


        // ================= VOLTAR FORM ORIGINAL =====================
        private void btnVoltar_Click_1(object sender, EventArgs e)
        {
            FormPrincipal formPrincipal = new FormPrincipal();
            this.Hide();
            formPrincipal.Show();
        }

        private void FormCliente_Load(object sender, EventArgs e)
        {
            ls.preencherDGV(dgvCliente, "Cliente");
            ls.preencherDGV(dgvClienteAtivo, "EstadoAtivo");
            ls.preencherDGV(dgvClientePendente, "EstadoPendente");
            pc.FormatarDGV(dgvCliente, "Cliente");
            pc.FormatarDGV(dgvClienteAtivo, "EstadoAtivo");
            pc.FormatarDGV(dgvClientePendente, "EstadoPendente");
        }

        private void btnCriarClix_Click(object sender, EventArgs e)
        {
            try
            {
                int nif = Convert.ToInt32(txtNIF.Text.ToString());
                string nome = txtNome.Text.ToString();
                string estado = txtEstado.Text.ToString();

                c.NIF = nif;
                c.Nome = nome;
                c.Estado = estado;

                pc.addCliente(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
