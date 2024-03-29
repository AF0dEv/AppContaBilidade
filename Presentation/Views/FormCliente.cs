﻿using RegistoMovimentosSrJoaquim.Business.Controllers;
using System.Globalization;

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
        CultureInfo culture = CultureInfo.CreateSpecificCulture("pt-PT");

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
            pc.PreencherDgvClientes(dgvCliente);
            pc.PreencherDgvEstadoAtivo(dgvClienteAtivo);
            pc.PreencherDgvEstadoPendente(dgvClientePendente);
            LimparSelecao();
        }

        private void btnCriarClix_Click(object sender, EventArgs e)
        {
            string nif = txtNIF.Text;
            string nome = txtNome.Text;
            string? estado = null;
            if (txtEstado.Text.Equals(null) || txtEstado.Text.Equals(""))
            {
                estado = null;
            }
            else
            {
                estado = txtEstado.Text;
            }

            string mensagem =
            @$"Está a adicionar o cliente com os seguintes dados: 

                NIF: {nif}
                Nome: {nome}
                Estado: {estado}
            
            Confirmar? ";

            string cabecalho = "Adicionar Cliente";

            var result = MessageBox.Show(mensagem, cabecalho, MessageBoxButtons.YesNo);

            if (!string.IsNullOrWhiteSpace(txtNIF.Text) && !string.IsNullOrWhiteSpace(txtNome.Text))
            {

                if (result == DialogResult.Yes)
                {
                    pc.addCliente(Convert.ToInt32(nif), nome, estado);
                }
                else
                {
                    MessageBox.Show("Operaçao cancelada.");
                }
            }
            else
            {
                MessageBox.Show("Preencha os campos para adicionar um cliente.");
            }
            pc.PreencherDgvClientes(dgvCliente);
            pc.PreencherDgvEstadoAtivo(dgvClienteAtivo);
            pc.PreencherDgvEstadoPendente(dgvClientePendente);
        }

        private void btnAtualizarCli_Click(object sender, EventArgs e)
        {
            string nif = txtNIF.Text;
            string nome = txtNome.Text;
            string estado = txtEstado.Text;

            if (dgvCliente.SelectedRows.Count > 0)
            {
                pc.updateCliente(Convert.ToInt32(nif), nome, estado);
            }
            else
            {
                MessageBox.Show("Selecione um cliente da tabela para atualizar.");
            }
            pc.PreencherDgvClientes(dgvCliente);
            pc.PreencherDgvEstadoAtivo(dgvClienteAtivo);
            pc.PreencherDgvEstadoPendente(dgvClientePendente);
        }

        private void dgvCliente_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                txtIdCliente.Text = dgvCliente.SelectedCells[0].Value.ToString();
                txtNIF.Text = dgvCliente.SelectedCells[1].Value.ToString();
                txtNome.Text = dgvCliente.SelectedCells[2].Value.ToString();
                txtEstado.Text = dgvCliente.SelectedCells[3].Value.ToString();
            }
            catch { }
        }

        private void LimparSelecao()
        {

            // Clientes
            txtIdCliente.Clear();
            txtNIF.Clear();
            txtNome.Clear();
            txtEstado.Clear();
            dgvCliente.ClearSelection();
        }

        private void btnLimparSelecao_Click(object sender, EventArgs e)
        {
            LimparSelecao();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            string idCliente = txtIdCliente.Text;
            if (dgvCliente.SelectedRows.Count > 0)
            {
                if (pc.ListarMovimentosClienteSelecionado(idCliente).Count > 0)
                {
                    MessageBox.Show("O cliente selecionado possui movimentos.");
                }
                else 
                { 
                    pc.deleteCliente(idCliente);
                }
            }
            else
            {
                MessageBox.Show("Selecione um cliente da tabela para remover.");
            }
            pc.PreencherDgvClientes(dgvCliente);
            pc.PreencherDgvEstadoAtivo(dgvClienteAtivo);
            pc.PreencherDgvEstadoPendente(dgvClientePendente);
        }
    }
}
