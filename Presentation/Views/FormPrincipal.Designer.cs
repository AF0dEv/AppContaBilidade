namespace RegistoMovimentosSrJoaquim
{
    partial class FormPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            label6 = new Label();
            btnMnListagem = new ToolStripMenuItem();
            btnMnClientes = new ToolStripMenuItem();
            mnForms = new MenuStrip();
            dgvPrincipal = new DataGridView();
            dgvMvLivres = new DataGridView();
            label9 = new Label();
            dgvMvMarcados = new DataGridView();
            btnAtualizarMov = new Button();
            label8 = new Label();
            gbxCriarCliente = new GroupBox();
            btnApagar = new Button();
            label1 = new Label();
            cbxTipo = new ComboBox();
            label5 = new Label();
            dtpMovimento = new DateTimePicker();
            label4 = new Label();
            cbxClienteMov = new ComboBox();
            btnCriarClix = new Button();
            txtMarcacao = new TextBox();
            label3 = new Label();
            label2 = new Label();
            txtDescricao = new TextBox();
            label7 = new Label();
            txtValor = new TextBox();
            mnForms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPrincipal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvMvLivres).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvMvMarcados).BeginInit();
            gbxCriarCliente.SuspendLayout();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Yu Gothic", 12F, FontStyle.Bold);
            label6.Location = new Point(417, 12);
            label6.Name = "label6";
            label6.Size = new Size(155, 26);
            label6.TabIndex = 18;
            label6.Text = "MOVIMENTOS";
            // 
            // btnMnListagem
            // 
            btnMnListagem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMnListagem.Name = "btnMnListagem";
            btnMnListagem.Size = new Size(123, 32);
            btnMnListagem.Text = "LISTAGENS";
            btnMnListagem.Click += btnMnListagem_Click;
            // 
            // btnMnClientes
            // 
            btnMnClientes.BackColor = Color.Transparent;
            btnMnClientes.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMnClientes.Name = "btnMnClientes";
            btnMnClientes.Size = new Size(108, 32);
            btnMnClientes.Text = "CLIENTES";
            btnMnClientes.Click += btnMnClientes_Click;
            // 
            // mnForms
            // 
            mnForms.BackColor = Color.Transparent;
            mnForms.Dock = DockStyle.None;
            mnForms.ImageScalingSize = new Size(20, 20);
            mnForms.Items.AddRange(new ToolStripItem[] { btnMnListagem, btnMnClientes });
            mnForms.Location = new Point(6, 503);
            mnForms.Name = "mnForms";
            mnForms.Size = new Size(239, 36);
            mnForms.TabIndex = 21;
            // 
            // dgvPrincipal
            // 
            dgvPrincipal.BackgroundColor = SystemColors.ControlLight;
            dgvPrincipal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPrincipal.Cursor = Cursors.Hand;
            dgvPrincipal.Location = new Point(417, 41);
            dgvPrincipal.Name = "dgvPrincipal";
            dgvPrincipal.RowHeadersWidth = 51;
            dgvPrincipal.Size = new Size(607, 223);
            dgvPrincipal.TabIndex = 1;
            // 
            // dgvMvLivres
            // 
            dgvMvLivres.BackgroundColor = SystemColors.ControlLight;
            dgvMvLivres.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMvLivres.Cursor = Cursors.Hand;
            dgvMvLivres.Location = new Point(719, 313);
            dgvMvLivres.Name = "dgvMvLivres";
            dgvMvLivres.RowHeadersWidth = 51;
            dgvMvLivres.Size = new Size(305, 187);
            dgvMvLivres.TabIndex = 28;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(719, 284);
            label9.Name = "label9";
            label9.Size = new Size(84, 26);
            label9.TabIndex = 27;
            label9.Text = "LIVRES";
            // 
            // dgvMvMarcados
            // 
            dgvMvMarcados.BackgroundColor = SystemColors.ControlLight;
            dgvMvMarcados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMvMarcados.Cursor = Cursors.Hand;
            dgvMvMarcados.Location = new Point(428, 313);
            dgvMvMarcados.Name = "dgvMvMarcados";
            dgvMvMarcados.RowHeadersWidth = 51;
            dgvMvMarcados.Size = new Size(285, 187);
            dgvMvMarcados.TabIndex = 26;
            // 
            // btnAtualizarMov
            // 
            btnAtualizarMov.BackColor = Color.LightSteelBlue;
            btnAtualizarMov.Cursor = Cursors.Hand;
            btnAtualizarMov.FlatStyle = FlatStyle.Popup;
            btnAtualizarMov.Location = new Point(145, 452);
            btnAtualizarMov.Name = "btnAtualizarMov";
            btnAtualizarMov.Size = new Size(130, 29);
            btnAtualizarMov.TabIndex = 25;
            btnAtualizarMov.Text = "ATUALIZAR";
            btnAtualizarMov.UseVisualStyleBackColor = false;
            btnAtualizarMov.Click += btnAtualizarMov_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(428, 284);
            label8.Name = "label8";
            label8.Size = new Size(130, 26);
            label8.TabIndex = 24;
            label8.Text = "MARCADOS";
            // 
            // gbxCriarCliente
            // 
            gbxCriarCliente.BackColor = Color.Transparent;
            gbxCriarCliente.Controls.Add(txtValor);
            gbxCriarCliente.Controls.Add(btnApagar);
            gbxCriarCliente.Controls.Add(label1);
            gbxCriarCliente.Controls.Add(cbxTipo);
            gbxCriarCliente.Controls.Add(label5);
            gbxCriarCliente.Controls.Add(dtpMovimento);
            gbxCriarCliente.Controls.Add(btnAtualizarMov);
            gbxCriarCliente.Controls.Add(label4);
            gbxCriarCliente.Controls.Add(cbxClienteMov);
            gbxCriarCliente.Controls.Add(btnCriarClix);
            gbxCriarCliente.Controls.Add(txtMarcacao);
            gbxCriarCliente.Controls.Add(label3);
            gbxCriarCliente.Controls.Add(label2);
            gbxCriarCliente.Controls.Add(txtDescricao);
            gbxCriarCliente.Controls.Add(label7);
            gbxCriarCliente.Location = new Point(0, 10);
            gbxCriarCliente.Name = "gbxCriarCliente";
            gbxCriarCliente.Size = new Size(411, 487);
            gbxCriarCliente.TabIndex = 29;
            gbxCriarCliente.TabStop = false;
            gbxCriarCliente.Text = "MOVIMENTO";
            // 
            // btnApagar
            // 
            btnApagar.BackColor = Color.LightSteelBlue;
            btnApagar.Cursor = Cursors.Hand;
            btnApagar.FlatStyle = FlatStyle.Popup;
            btnApagar.Location = new Point(281, 452);
            btnApagar.Name = "btnApagar";
            btnApagar.Size = new Size(124, 29);
            btnApagar.TabIndex = 26;
            btnApagar.Text = "APAGAR";
            btnApagar.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(246, 145);
            label1.Name = "label1";
            label1.Size = new Size(60, 26);
            label1.TabIndex = 19;
            label1.Text = "TIPO";
            // 
            // cbxTipo
            // 
            cbxTipo.Cursor = Cursors.IBeam;
            cbxTipo.Font = new Font("Segoe UI", 12F);
            cbxTipo.ForeColor = Color.Black;
            cbxTipo.FormattingEnabled = true;
            cbxTipo.Location = new Point(246, 173);
            cbxTipo.Name = "cbxTipo";
            cbxTipo.Size = new Size(151, 36);
            cbxTipo.TabIndex = 18;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(246, 40);
            label5.Name = "label5";
            label5.Size = new Size(130, 26);
            label5.TabIndex = 17;
            label5.Text = "DESCRIÇÃO";
            // 
            // dtpMovimento
            // 
            dtpMovimento.AllowDrop = true;
            dtpMovimento.CalendarFont = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpMovimento.Location = new Point(6, 69);
            dtpMovimento.MaxDate = new DateTime(2100, 12, 31, 0, 0, 0, 0);
            dtpMovimento.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dtpMovimento.Name = "dtpMovimento";
            dtpMovimento.Size = new Size(217, 27);
            dtpMovimento.TabIndex = 16;
            dtpMovimento.Value = new DateTime(2024, 1, 29, 16, 6, 0, 0);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(6, 265);
            label4.Name = "label4";
            label4.Size = new Size(99, 26);
            label4.TabIndex = 15;
            label4.Text = "CLIENTE";
            // 
            // cbxClienteMov
            // 
            cbxClienteMov.Cursor = Cursors.IBeam;
            cbxClienteMov.Font = new Font("Segoe UI", 12F);
            cbxClienteMov.ForeColor = Color.Black;
            cbxClienteMov.Location = new Point(6, 293);
            cbxClienteMov.Name = "cbxClienteMov";
            cbxClienteMov.Size = new Size(151, 36);
            cbxClienteMov.TabIndex = 14;
            // 
            // btnCriarClix
            // 
            btnCriarClix.Cursor = Cursors.Hand;
            btnCriarClix.FlatStyle = FlatStyle.Popup;
            btnCriarClix.Location = new Point(6, 452);
            btnCriarClix.Name = "btnCriarClix";
            btnCriarClix.Size = new Size(133, 29);
            btnCriarClix.TabIndex = 13;
            btnCriarClix.Text = "CRIAR";
            btnCriarClix.UseVisualStyleBackColor = true;
            btnCriarClix.Click += btnCriarClix_Click;
            // 
            // txtMarcacao
            // 
            txtMarcacao.Cursor = Cursors.IBeam;
            txtMarcacao.Font = new Font("Segoe UI", 12F);
            txtMarcacao.ForeColor = Color.Black;
            txtMarcacao.Location = new Point(246, 296);
            txtMarcacao.Name = "txtMarcacao";
            txtMarcacao.PlaceholderText = "ESCREVA AQUI...";
            txtMarcacao.Size = new Size(151, 34);
            txtMarcacao.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(246, 265);
            label3.Name = "label3";
            label3.Size = new Size(130, 26);
            label3.TabIndex = 11;
            label3.Text = "MARCAÇÃO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(6, 145);
            label2.Name = "label2";
            label2.Size = new Size(80, 26);
            label2.TabIndex = 9;
            label2.Text = "VALOR";
            // 
            // txtDescricao
            // 
            txtDescricao.Cursor = Cursors.IBeam;
            txtDescricao.Font = new Font("Segoe UI", 12F);
            txtDescricao.ForeColor = Color.Black;
            txtDescricao.Location = new Point(246, 67);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.PlaceholderText = "ESCREVA AQUI...";
            txtDescricao.Size = new Size(151, 34);
            txtDescricao.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(6, 40);
            label7.Name = "label7";
            label7.Size = new Size(66, 26);
            label7.TabIndex = 7;
            label7.Text = "DATA";
            // 
            // txtValor
            // 
            txtValor.Cursor = Cursors.IBeam;
            txtValor.Font = new Font("Segoe UI", 12F);
            txtValor.ForeColor = Color.Black;
            txtValor.Location = new Point(6, 175);
            txtValor.Name = "txtValor";
            txtValor.PlaceholderText = "ESCREVA AQUI...";
            txtValor.Size = new Size(151, 34);
            txtValor.TabIndex = 27;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1038, 540);
            Controls.Add(gbxCriarCliente);
            Controls.Add(dgvMvLivres);
            Controls.Add(label9);
            Controls.Add(dgvMvMarcados);
            Controls.Add(label8);
            Controls.Add(mnForms);
            Controls.Add(label6);
            Controls.Add(dgvPrincipal);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = mnForms;
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LAVAGENS MUNDIAIS";
            Load += V_Load;
            mnForms.ResumeLayout(false);
            mnForms.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPrincipal).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvMvLivres).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvMvMarcados).EndInit();
            gbxCriarCliente.ResumeLayout(false);
            gbxCriarCliente.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label6;
        private ToolStripMenuItem btnMnListagem;
        private ToolStripMenuItem btnMnClientes;
        private MenuStrip mnForms;
        private DataGridView dgvPrincipal;
        private DataGridView dgvMvLivres;
        private Label label9;
        private DataGridView dgvMvMarcados;
        private Button btnAtualizarMov;
        private Label label8;
        private GroupBox gbxCriarCliente;
        private Label label1;
        private ComboBox cbxTipo;
        private Label label5;
        private DateTimePicker dtpMovimento;
        private Button btnCriarClix;
        private TextBox txtMarcacao;
        private Label label3;
        private Label label2;
        private TextBox txtDescricao;
        private Label label7;
        private Button btnCriarCliente;
        private Button btnCriarMov;
        private Label label4;
        private ComboBox cbxClienteMov;
        private Button btnApagar;
        private TextBox txtValor;
    }
}
