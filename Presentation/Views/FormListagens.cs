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
            if (cbxClienteLis.SelectedValue is not null)
            {
                dgvListagem.DataSource = pc.ListarMovimentosClienteMesPeriodo(cbxClienteLis.SelectedValue.ToString(), cbxMes.SelectedValue.ToString(), null, 1);
            }
            
        }

        private void cbxClienteLis_SelectedIndexChanged(object sender, EventArgs e)
        {
            //dgvListagem.DataSource = pc.ListarMovimentosClienteSelecionado(cbxClienteLis.ValueMember);
           
        }
    }
}
