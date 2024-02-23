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
            btnAtualizarCli = new Button();
            btnApagar = new Button();
            txtIdCliente = new TextBox();
            gbxCriarCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCliente).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvClienteAtivo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvClientePendente).BeginInit();
            SuspendLayout();
            // 
            // gbxCriarCliente
            // 
            gbxCriarCliente.Controls.Add(txtIdCliente);
            gbxCriarCliente.Controls.Add(btnVoltar);
            gbxCriarCliente.Controls.Add(txtNome);
            gbxCriarCliente.Controls.Add(txtEstado);
            gbxCriarCliente.Controls.Add(btnCriarClix);
            gbxCriarCliente.Controls.Add(label3);
            gbxCriarCliente.Controls.Add(label1);
            gbxCriarCliente.Controls.Add(txtNIF);
            gbxCriarCliente.Controls.Add(label2);
            gbxCriarCliente.Location = new Point(11, 12);
            gbxCriarCliente.Name = "gbxCriarCliente";
            gbxCriarCliente.Size = new Size(219, 516);
            gbxCriarCliente.TabIndex = 0;
            gbxCriarCliente.TabStop = false;
            gbxCriarCliente.Text = "CLIENTE";
            // 
            // btnVoltar
            // 
            btnVoltar.Cursor = Cursors.Hand;
            btnVoltar.FlatStyle = FlatStyle.Popup;
            btnVoltar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVoltar.Location = new Point(125, 481);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(85, 29);
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
            txtNome.Location = new Point(6, 320);
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "ESCREVA AQUI...";
            txtNome.Size = new Size(155, 34);
            txtNome.TabIndex = 15;
            // 
            // txtEstado
            // 
            txtEstado.Cursor = Cursors.IBeam;
            txtEstado.Font = new Font("Segoe UI", 12F);
            txtEstado.ForeColor = SystemColors.WindowText;
            txtEstado.Location = new Point(6, 435);
            txtEstado.Name = "txtEstado";
            txtEstado.PlaceholderText = "ESCREVA AQUI...";
            txtEstado.Size = new Size(155, 34);
            txtEstado.TabIndex = 14;
            // 
            // btnCriarClix
            // 
            btnCriarClix.Cursor = Cursors.Hand;
            btnCriarClix.FlatStyle = FlatStyle.Popup;
            btnCriarClix.Location = new Point(6, 481);
            btnCriarClix.Name = "btnCriarClix";
            btnCriarClix.Size = new Size(113, 29);
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
            label3.Location = new Point(6, 406);
            label3.Name = "label3";
            label3.Size = new Size(94, 26);
            label3.TabIndex = 11;
            label3.Text = "ESTADO";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(6, 292);
            label1.Name = "label1";
            label1.Size = new Size(75, 26);
            label1.TabIndex = 9;
            label1.Text = "NOME";
            // 
            // txtNIF
            // 
            txtNIF.Cursor = Cursors.IBeam;
            txtNIF.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNIF.ForeColor = SystemColors.WindowText;
            txtNIF.Location = new Point(6, 216);
            txtNIF.Name = "txtNIF";
            txtNIF.PlaceholderText = "ESCREVA AQUI...";
            txtNIF.Size = new Size(155, 34);
            txtNIF.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(6, 187);
            label2.Name = "label2";
            label2.Size = new Size(47, 26);
            label2.TabIndex = 7;
            label2.Text = "NIF";
            // 
            // dgvCliente
            // 
            dgvCliente.BackgroundColor = SystemColors.ControlLight;
            dgvCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCliente.Cursor = Cursors.Hand;
            dgvCliente.Location = new Point(237, 23);
            dgvCliente.Name = "dgvCliente";
            dgvCliente.RowHeadersWidth = 51;
            dgvCliente.Size = new Size(487, 469);
            dgvCliente.TabIndex = 2;
            dgvCliente.SelectionChanged += dgvCliente_SelectionChanged;
            // 
            // dgvClienteAtivo
            // 
            dgvClienteAtivo.BackgroundColor = SystemColors.ControlLight;
            dgvClienteAtivo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClienteAtivo.Cursor = Cursors.Hand;
            dgvClienteAtivo.Location = new Point(730, 52);
            dgvClienteAtivo.Name = "dgvClienteAtivo";
            dgvClienteAtivo.RowHeadersWidth = 51;
            dgvClienteAtivo.Size = new Size(296, 173);
            dgvClienteAtivo.TabIndex = 3;
            // 
            // dgvClientePendente
            // 
            dgvClientePendente.BackgroundColor = SystemColors.ControlLight;
            dgvClientePendente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientePendente.Cursor = Cursors.Hand;
            dgvClientePendente.Location = new Point(730, 325);
            dgvClientePendente.Name = "dgvClientePendente";
            dgvClientePendente.RowHeadersWidth = 51;
            dgvClientePendente.Size = new Size(296, 167);
            dgvClientePendente.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic", 12F, FontStyle.Bold);
            label4.Location = new Point(730, 23);
            label4.Name = "label4";
            label4.Size = new Size(161, 26);
            label4.TabIndex = 5;
            label4.Text = "ESTADO ATIVO";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Yu Gothic", 12F, FontStyle.Bold);
            label5.Location = new Point(730, 297);
            label5.Name = "label5";
            label5.Size = new Size(213, 26);
            label5.TabIndex = 6;
            label5.Text = "ESTADO PENDENTE";
            // 
            // btnAtualizarCli
            // 
            btnAtualizarCli.Cursor = Cursors.Hand;
            btnAtualizarCli.FlatStyle = FlatStyle.Popup;
            btnAtualizarCli.Location = new Point(611, 499);
            btnAtualizarCli.Name = "btnAtualizarCli";
            btnAtualizarCli.Size = new Size(113, 29);
            btnAtualizarCli.TabIndex = 16;
            btnAtualizarCli.Text = "ATUALIZAR";
            btnAtualizarCli.UseVisualStyleBackColor = true;
            btnAtualizarCli.Click += btnAtualizarCli_Click;
            // 
            // btnApagar
            // 
            btnApagar.Cursor = Cursors.Hand;
            btnApagar.FlatStyle = FlatStyle.Popup;
            btnApagar.Location = new Point(492, 499);
            btnApagar.Name = "btnApagar";
            btnApagar.Size = new Size(113, 29);
            btnApagar.TabIndex = 17;
            btnApagar.Text = "APAGAR";
            btnApagar.UseVisualStyleBackColor = true;
            // 
            // txtIdCliente
            // 
            txtIdCliente.Cursor = Cursors.IBeam;
            txtIdCliente.Enabled = false;
            txtIdCliente.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIdCliente.ForeColor = SystemColors.WindowText;
            txtIdCliente.Location = new Point(6, 26);
            txtIdCliente.Name = "txtIdCliente";
            txtIdCliente.PlaceholderText = "ID...";
            txtIdCliente.Size = new Size(155, 34);
            txtIdCliente.TabIndex = 22;
            // 
            // FormCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(1038, 540);
            Controls.Add(btnApagar);
            Controls.Add(btnAtualizarCli);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(dgvClientePendente);
            Controls.Add(dgvClienteAtivo);
            Controls.Add(dgvCliente);
            Controls.Add(gbxCriarCliente);
            Icon = (Icon)resources.GetObject("$this.Icon");
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
        private Button btnAtualizarCli;
        private Button btnApagar;
        private TextBox txtIdCliente;
    }
}