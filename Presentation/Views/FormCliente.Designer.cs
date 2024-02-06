namespace RegistoMovimentosSrJoaquim
{
    partial class FormCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCliente));
            gbxCriarCliente = new GroupBox();
            btnVoltar = new Button();
            txtNome = new TextBox();
            txtEstado = new TextBox();
            btnCriarClix = new Button();
            label3 = new Label();
            label1 = new Label();
            txtNIF = new TextBox();
            label2 = new Label();
            dgvCliente = new DataGridView();
            dgvClienteAtivo = new DataGridView();
            dgvClientePendente = new DataGridView();
            label4 = new Label();
            label5 = new Label();
            btnAtualizarEP = new Button();
            btnAtualizarEA = new Button();
            btnAtualizarCli = new Button();
            gbxCriarCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCliente).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvClienteAtivo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvClientePendente).BeginInit();
            SuspendLayout();
            // 
            // gbxCriarCliente
            // 
            gbxCriarCliente.Controls.Add(btnVoltar);
            gbxCriarCliente.Controls.Add(txtNome);
            gbxCriarCliente.Controls.Add(txtEstado);
            gbxCriarCliente.Controls.Add(btnCriarClix);
            gbxCriarCliente.Controls.Add(label3);
            gbxCriarCliente.Controls.Add(label1);
            gbxCriarCliente.Controls.Add(txtNIF);
            gbxCriarCliente.Controls.Add(label2);
            gbxCriarCliente.Location = new Point(10, 9);
            gbxCriarCliente.Margin = new Padding(3, 2, 3, 2);
            gbxCriarCliente.Name = "gbxCriarCliente";
            gbxCriarCliente.Padding = new Padding(3, 2, 3, 2);
            gbxCriarCliente.Size = new Size(192, 387);
            gbxCriarCliente.TabIndex = 0;
            gbxCriarCliente.TabStop = false;
            gbxCriarCliente.Text = "CLIENTE";
            // 
            // btnVoltar
            // 
            btnVoltar.Cursor = Cursors.Hand;
            btnVoltar.FlatStyle = FlatStyle.Popup;
            btnVoltar.Location = new Point(122, 361);
            btnVoltar.Margin = new Padding(3, 2, 3, 2);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(62, 22);
            btnVoltar.TabIndex = 21;
            btnVoltar.Text = "VOLTAR";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click_1;
            // 
            // txtNome
            // 
            txtNome.Cursor = Cursors.IBeam;
            txtNome.Font = new Font("Segoe UI", 12F);
            txtNome.ForeColor = SystemColors.WindowText;
            txtNome.Location = new Point(5, 130);
            txtNome.Margin = new Padding(3, 2, 3, 2);
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "ESCREVA AQUI...";
            txtNome.Size = new Size(136, 29);
            txtNome.TabIndex = 15;
            // 
            // txtEstado
            // 
            txtEstado.Cursor = Cursors.IBeam;
            txtEstado.Font = new Font("Segoe UI", 12F);
            txtEstado.ForeColor = SystemColors.WindowText;
            txtEstado.Location = new Point(5, 216);
            txtEstado.Margin = new Padding(3, 2, 3, 2);
            txtEstado.Name = "txtEstado";
            txtEstado.PlaceholderText = "ESCREVA AQUI...";
            txtEstado.Size = new Size(136, 29);
            txtEstado.TabIndex = 14;
            // 
            // btnCriarClix
            // 
            btnCriarClix.Cursor = Cursors.Hand;
            btnCriarClix.FlatStyle = FlatStyle.Popup;
            btnCriarClix.Location = new Point(5, 361);
            btnCriarClix.Margin = new Padding(3, 2, 3, 2);
            btnCriarClix.Name = "btnCriarClix";
            btnCriarClix.Size = new Size(99, 22);
            btnCriarClix.TabIndex = 13;
            btnCriarClix.Text = "CRIAR";
            btnCriarClix.UseVisualStyleBackColor = true;
            btnCriarClix.Click += btnCriarClix_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(5, 194);
            label3.Name = "label3";
            label3.Size = new Size(76, 21);
            label3.TabIndex = 11;
            label3.Text = "ESTADO";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(5, 109);
            label1.Name = "label1";
            label1.Size = new Size(60, 21);
            label1.TabIndex = 9;
            label1.Text = "NOME";
            // 
            // txtNIF
            // 
            txtNIF.Cursor = Cursors.IBeam;
            txtNIF.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNIF.ForeColor = SystemColors.WindowText;
            txtNIF.Location = new Point(5, 52);
            txtNIF.Margin = new Padding(3, 2, 3, 2);
            txtNIF.Name = "txtNIF";
            txtNIF.PlaceholderText = "ESCREVA AQUI...";
            txtNIF.Size = new Size(136, 29);
            txtNIF.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(5, 30);
            label2.Name = "label2";
            label2.Size = new Size(38, 21);
            label2.TabIndex = 7;
            label2.Text = "NIF";
            // 
            // dgvCliente
            // 
            dgvCliente.BackgroundColor = SystemColors.ControlLight;
            dgvCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCliente.Cursor = Cursors.Hand;
            dgvCliente.Location = new Point(207, 17);
            dgvCliente.Margin = new Padding(3, 2, 3, 2);
            dgvCliente.Name = "dgvCliente";
            dgvCliente.RowHeadersWidth = 51;
            dgvCliente.Size = new Size(426, 352);
            dgvCliente.TabIndex = 2;
            // 
            // dgvClienteAtivo
            // 
            dgvClienteAtivo.BackgroundColor = SystemColors.ControlLight;
            dgvClienteAtivo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClienteAtivo.Cursor = Cursors.Hand;
            dgvClienteAtivo.Location = new Point(639, 39);
            dgvClienteAtivo.Margin = new Padding(3, 2, 3, 2);
            dgvClienteAtivo.Name = "dgvClienteAtivo";
            dgvClienteAtivo.RowHeadersWidth = 51;
            dgvClienteAtivo.Size = new Size(259, 130);
            dgvClienteAtivo.TabIndex = 3;
            // 
            // dgvClientePendente
            // 
            dgvClientePendente.BackgroundColor = SystemColors.ControlLight;
            dgvClientePendente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientePendente.Cursor = Cursors.Hand;
            dgvClientePendente.Location = new Point(639, 244);
            dgvClientePendente.Margin = new Padding(3, 2, 3, 2);
            dgvClientePendente.Name = "dgvClientePendente";
            dgvClientePendente.RowHeadersWidth = 51;
            dgvClientePendente.Size = new Size(259, 125);
            dgvClientePendente.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic", 12F, FontStyle.Bold);
            label4.Location = new Point(639, 17);
            label4.Name = "label4";
            label4.Size = new Size(130, 21);
            label4.TabIndex = 5;
            label4.Text = "ESTADO ATIVO";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Yu Gothic", 12F, FontStyle.Bold);
            label5.Location = new Point(639, 223);
            label5.Name = "label5";
            label5.Size = new Size(171, 21);
            label5.TabIndex = 6;
            label5.Text = "ESTADO PENDENTE";
            // 
            // btnAtualizarEP
            // 
            btnAtualizarEP.Cursor = Cursors.Hand;
            btnAtualizarEP.FlatStyle = FlatStyle.Popup;
            btnAtualizarEP.Location = new Point(799, 374);
            btnAtualizarEP.Margin = new Padding(3, 2, 3, 2);
            btnAtualizarEP.Name = "btnAtualizarEP";
            btnAtualizarEP.Size = new Size(99, 22);
            btnAtualizarEP.TabIndex = 14;
            btnAtualizarEP.Text = "ATUALIZAR";
            btnAtualizarEP.UseVisualStyleBackColor = true;
            // 
            // btnAtualizarEA
            // 
            btnAtualizarEA.Cursor = Cursors.Hand;
            btnAtualizarEA.FlatStyle = FlatStyle.Popup;
            btnAtualizarEA.Location = new Point(799, 174);
            btnAtualizarEA.Margin = new Padding(3, 2, 3, 2);
            btnAtualizarEA.Name = "btnAtualizarEA";
            btnAtualizarEA.Size = new Size(99, 22);
            btnAtualizarEA.TabIndex = 15;
            btnAtualizarEA.Text = "ATUALIZAR";
            btnAtualizarEA.UseVisualStyleBackColor = true;
            // 
            // btnAtualizarCli
            // 
            btnAtualizarCli.Cursor = Cursors.Hand;
            btnAtualizarCli.FlatStyle = FlatStyle.Popup;
            btnAtualizarCli.Location = new Point(535, 374);
            btnAtualizarCli.Margin = new Padding(3, 2, 3, 2);
            btnAtualizarCli.Name = "btnAtualizarCli";
            btnAtualizarCli.Size = new Size(99, 22);
            btnAtualizarCli.TabIndex = 16;
            btnAtualizarCli.Text = "ATUALIZAR";
            btnAtualizarCli.UseVisualStyleBackColor = true;
            // 
            // FormCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(908, 405);
            Controls.Add(btnAtualizarCli);
            Controls.Add(btnAtualizarEA);
            Controls.Add(btnAtualizarEP);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(dgvClientePendente);
            Controls.Add(dgvClienteAtivo);
            Controls.Add(dgvCliente);
            Controls.Add(gbxCriarCliente);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CLIENTE";
            Load += FormCliente_Load;
            gbxCriarCliente.ResumeLayout(false);
            gbxCriarCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCliente).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvClienteAtivo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvClientePendente).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gbxCriarCliente;
        private Label label2;
        private Label label3;
        private Label label1;
        private TextBox txtNIF;
        private Button btnCriarClix;
        private DataGridView dgvCliente;
        private TextBox txtNome;
        private TextBox txtEstado;
        private Button btnVoltar;
        private DataGridView dgvClienteAtivo;
        private DataGridView dgvClientePendente;
        private Label label4;
        private Label label5;
        private Button btnAtualizarEP;
        private Button btnAtualizarEA;
        private Button btnAtualizarCli;
    }
}