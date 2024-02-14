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
    public partial class FormListagens : Form
    {
        // ============== CONSTRUTOR ===============
        public FormListagens()
        {
            InitializeComponent();
        }

        // ============== PROPERTIES ===============

        Listagem ls = new Listagem();
        Movimento mv = new Movimento();
        ProgramController pc = new ProgramController();


        // ============= MÉTODOS ================

        // ================= VOLTAR FORM ORIGINAL =====================

        private void FormMovimentos_Load(object sender, EventArgs e)
        {
            ls.preencherCBX(cbxMes, "Mes");
            ls.preencherCBX(cbxClienteLis, "Cliente");
            //pc.FormatarDGV(dgvListagem, "Movimento");


            gbPeriodoTempo.Hide();
            gbPeriodoTempo.Enabled = false;
        }

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

        }

        private void cbxClienteLis_SelectedIndexChanged(object sender, EventArgs e)
        {
           pc.ListarClienteSelecionado(cbxClienteLis, dgvListagem);
           
        }
    }
}
