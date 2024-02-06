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
    public partial class FormMovimentos : Form
    {
        // ============== CONSTRUTOR ===============
        public FormMovimentos()
        {
            InitializeComponent();
        }

        // ============== PROPERTIES ===============

        Listagem ls = new Listagem();
        ProgramController pc = new ProgramController();


        // ============= MÉTODOS ================

        // ================= VOLTAR FORM ORIGINAL =====================
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            FormPrincipal formPrincipal = new FormPrincipal();
            this.Hide();
            formPrincipal.Show();
        }

        private void FormMovimentos_Load(object sender, EventArgs e)
        {
            ls.preencherCBX(cbxClienteMov, "Cliente");
            ls.preencherCBX(cbxTipo, "Tipo");
            ls.preencherDGV(dgvMovimento, "Movimento");
            ls.preencherDGV(dgvMvMarcados, "Marcados");
            ls.preencherDGV(dgvMvLivres, "Livres");
            pc.FormatarDGV(dgvMovimento, "Movimento");
            pc.FormatarDGV(dgvMvMarcados, "Marcados");
            pc.FormatarDGV(dgvMvLivres, "Livres");
        }
    }
}
