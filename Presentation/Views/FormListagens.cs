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
           
        }

    }
}
