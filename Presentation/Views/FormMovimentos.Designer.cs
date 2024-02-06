namespace RegistoMovimentosSrJoaquim
{
    partial class FormMovimentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMovimentos));
            gbxCriarCliente = new GroupBox();
            btnVoltar = new Button();
            label6 = new Label();
            cbxTipo = new ComboBox();
            label5 = new Label();
            dtMovimento = new DateTimePicker();
            label4 = new Label();
            cbxClienteMov = new ComboBox();
            btnCriarClix = new Button();
            txtMarcacao = new TextBox();
            label3 = new Label();
            txtValor = new TextBox();
            label1 = new Label();
            txtDescricao = new TextBox();
            label2 = new Label();
            dgvMovimento = new DataGridView();
            label7 = new Label();
            label8 = new Label();
            btnAtualizarMov = new Button();
            dgvMvMarcados = new DataGridView();
            label9 = new Label();
            dgvMvLivres = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            gbxCriarCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMovimento).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvMvMarcados).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvMvLivres).BeginInit();
            SuspendLayout();
            // 
            // gbxCriarCliente
            // 
            gbxCriarCliente.Controls.Add(btnVoltar);
            gbxCriarCliente.Controls.Add(label6);
            gbxCriarCliente.Controls.Add(cbxTipo);
            gbxCriarCliente.Controls.Add(label5);
            gbxCriarCliente.Controls.Add(dtMovimento);
            gbxCriarCliente.Controls.Add(label4);
            gbxCriarCliente.Controls.Add(cbxClienteMov);
            gbxCriarCliente.Controls.Add(btnCriarClix);
            gbxCriarCliente.Controls.Add(txtMarcacao);
            gbxCriarCliente.Controls.Add(label3);
            gbxCriarCliente.Controls.Add(txtValor);
            gbxCriarCliente.Controls.Add(label1);
            gbxCriarCliente.Controls.Add(txtDescricao);
            gbxCriarCliente.Controls.Add(label2);
            gbxCriarCliente.Location = new Point(10, 9);
            gbxCriarCliente.Margin = new Padding(3, 2, 3, 2);
            gbxCriarCliente.Name = "gbxCriarCliente";
            gbxCriarCliente.Padding = new Padding(3, 2, 3, 2);
            gbxCriarCliente.Size = new Size(360, 387);
            gbxCriarCliente.TabIndex = 1;
            gbxCriarCliente.TabStop = false;
            gbxCriarCliente.Text = "MOVIMENTO";
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.LightSteelBlue;
            btnVoltar.Cursor = Cursors.Hand;
            btnVoltar.FlatStyle = FlatStyle.Popup;
            btnVoltar.Location = new Point(241, 361);
            btnVoltar.Margin = new Padding(3, 2, 3, 2);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(107, 22);
            btnVoltar.TabIndex = 20;
            btnVoltar.Text = "VOLTAR";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(215, 109);
            label6.Name = "label6";
            label6.Size = new Size(49, 21);
            label6.TabIndex = 19;
            label6.Text = "TIPO";
            // 
            // cbxTipo
            // 
            cbxTipo.Cursor = Cursors.IBeam;
            cbxTipo.Font = new Font("Segoe UI", 12F);
            cbxTipo.ForeColor = Color.Black;
            cbxTipo.FormattingEnabled = true;
            cbxTipo.Location = new Point(215, 130);
            cbxTipo.Margin = new Padding(3, 2, 3, 2);
            cbxTipo.Name = "cbxTipo";
            cbxTipo.Size = new Size(133, 29);
            cbxTipo.TabIndex = 18;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(215, 30);
            label5.Name = "label5";
            label5.Size = new Size(104, 21);
            label5.TabIndex = 17;
            label5.Text = "DESCRIÇÃO";
            // 
            // dtMovimento
            // 
            dtMovimento.AllowDrop = true;
            dtMovimento.CalendarFont = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtMovimento.Location = new Point(5, 52);
            dtMovimento.Margin = new Padding(3, 2, 3, 2);
            dtMovimento.MaxDate = new DateTime(2100, 12, 31, 0, 0, 0, 0);
            dtMovimento.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dtMovimento.Name = "dtMovimento";
            dtMovimento.Size = new Size(190, 23);
            dtMovimento.TabIndex = 16;
            dtMovimento.Value = new DateTime(2024, 1, 29, 16, 6, 0, 0);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(5, 199);
            label4.Name = "label4";
            label4.Size = new Size(80, 21);
            label4.TabIndex = 15;
            label4.Text = "CLIENTE";
            // 
            // cbxClienteMov
            // 
            cbxClienteMov.Cursor = Cursors.IBeam;
            cbxClienteMov.Font = new Font("Segoe UI", 12F);
            cbxClienteMov.ForeColor = Color.Black;
            cbxClienteMov.Location = new Point(5, 220);
            cbxClienteMov.Margin = new Padding(3, 2, 3, 2);
            cbxClienteMov.Name = "cbxClienteMov";
            cbxClienteMov.Size = new Size(133, 29);
            cbxClienteMov.TabIndex = 14;
            // 
            // btnCriarClix
            // 
            btnCriarClix.Cursor = Cursors.Hand;
            btnCriarClix.FlatStyle = FlatStyle.Popup;
            btnCriarClix.Location = new Point(5, 361);
            btnCriarClix.Margin = new Padding(3, 2, 3, 2);
            btnCriarClix.Name = "btnCriarClix";
            btnCriarClix.Size = new Size(107, 22);
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
            txtMarcacao.Location = new Point(215, 222);
            txtMarcacao.Margin = new Padding(3, 2, 3, 2);
            txtMarcacao.Name = "txtMarcacao";
            txtMarcacao.PlaceholderText = "ESCREVA AQUI...";
            txtMarcacao.Size = new Size(133, 29);
            txtMarcacao.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(215, 199);
            label3.Name = "label3";
            label3.Size = new Size(103, 21);
            label3.TabIndex = 11;
            label3.Text = "MARCAÇÃO";
            // 
            // txtValor
            // 
            txtValor.Cursor = Cursors.IBeam;
            txtValor.Font = new Font("Segoe UI", 12F);
            txtValor.ForeColor = Color.Black;
            txtValor.Location = new Point(5, 130);
            txtValor.Margin = new Padding(3, 2, 3, 2);
            txtValor.Name = "txtValor";
            txtValor.PlaceholderText = "ESCREVA AQUI...";
            txtValor.Size = new Size(133, 29);
            txtValor.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(5, 109);
            label1.Name = "label1";
            label1.Size = new Size(64, 21);
            label1.TabIndex = 9;
            label1.Text = "VALOR";
            // 
            // txtDescricao
            // 
            txtDescricao.Cursor = Cursors.IBeam;
            txtDescricao.Font = new Font("Segoe UI", 12F);
            txtDescricao.ForeColor = Color.Black;
            txtDescricao.Location = new Point(215, 50);
            txtDescricao.Margin = new Padding(3, 2, 3, 2);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.PlaceholderText = "ESCREVA AQUI...";
            txtDescricao.Size = new Size(133, 29);
            txtDescricao.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(5, 30);
            label2.Name = "label2";
            label2.Size = new Size(53, 21);
            label2.TabIndex = 7;
            label2.Text = "DATA";
            // 
            // dgvMovimento
            // 
            dgvMovimento.BackgroundColor = SystemColors.ControlLight;
            dgvMovimento.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMovimento.Cursor = Cursors.Hand;
            dgvMovimento.Location = new Point(376, 42);
            dgvMovimento.Margin = new Padding(3, 2, 3, 2);
            dgvMovimento.Name = "dgvMovimento";
            dgvMovimento.RowHeadersWidth = 51;
            dgvMovimento.Size = new Size(522, 131);
            dgvMovimento.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(376, 20);
            label7.Name = "label7";
            label7.Size = new Size(125, 21);
            label7.TabIndex = 18;
            label7.Text = "MOVIMENTOS";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(376, 208);
            label8.Name = "label8";
            label8.Size = new Size(104, 21);
            label8.TabIndex = 19;
            label8.Text = "MARCADOS";
            // 
            // btnAtualizarMov
            // 
            btnAtualizarMov.BackColor = Color.LightSteelBlue;
            btnAtualizarMov.Cursor = Cursors.Hand;
            btnAtualizarMov.FlatStyle = FlatStyle.Popup;
            btnAtualizarMov.Location = new Point(802, 178);
            btnAtualizarMov.Margin = new Padding(3, 2, 3, 2);
            btnAtualizarMov.Name = "btnAtualizarMov";
            btnAtualizarMov.Size = new Size(95, 22);
            btnAtualizarMov.TabIndex = 20;
            btnAtualizarMov.Text = "ATUALIZAR";
            btnAtualizarMov.UseVisualStyleBackColor = false;
            // 
            // dgvMvMarcados
            // 
            dgvMvMarcados.BackgroundColor = SystemColors.ControlLight;
            dgvMvMarcados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMvMarcados.Cursor = Cursors.Hand;
            dgvMvMarcados.Location = new Point(376, 230);
            dgvMvMarcados.Margin = new Padding(3, 2, 3, 2);
            dgvMvMarcados.Name = "dgvMvMarcados";
            dgvMvMarcados.RowHeadersWidth = 51;
            dgvMvMarcados.Size = new Size(249, 140);
            dgvMvMarcados.TabIndex = 21;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(824, 208);
            label9.Name = "label9";
            label9.Size = new Size(68, 21);
            label9.TabIndex = 22;
            label9.Text = "LIVRES";
            // 
            // dgvMvLivres
            // 
            dgvMvLivres.BackgroundColor = SystemColors.ControlLight;
            dgvMvLivres.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMvLivres.Cursor = Cursors.Hand;
            dgvMvLivres.Location = new Point(631, 230);
            dgvMvLivres.Margin = new Padding(3, 2, 3, 2);
            dgvMvLivres.Name = "dgvMvLivres";
            dgvMvLivres.RowHeadersWidth = 51;
            dgvMvLivres.Size = new Size(267, 140);
            dgvMvLivres.TabIndex = 23;
            // 
            // button1
            // 
            button1.BackColor = Color.LightSteelBlue;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(530, 374);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(95, 22);
            button1.TabIndex = 24;
            button1.Text = "ATUALIZAR";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.LightSteelBlue;
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Location = new Point(802, 374);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(95, 22);
            button2.TabIndex = 25;
            button2.Text = "ATUALIZAR";
            button2.UseVisualStyleBackColor = false;
            // 
            // FormMovimentos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(908, 405);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dgvMvLivres);
            Controls.Add(label9);
            Controls.Add(dgvMvMarcados);
            Controls.Add(btnAtualizarMov);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(dgvMovimento);
            Controls.Add(gbxCriarCliente);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormMovimentos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MOVIMENTO";
            Load += FormMovimentos_Load;
            gbxCriarCliente.ResumeLayout(false);
            gbxCriarCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMovimento).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvMvMarcados).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvMvLivres).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gbxCriarCliente;
        private Button btnCriarClix;
        private TextBox txtMarcacao;
        private Label label3;
        private TextBox txtValor;
        private Label label1;
        private TextBox txtDescricao;
        private Label label2;
        private Label label4;
        private ComboBox cbxClienteMov;
        private DateTimePicker dtMovimento;
        private Label label5;
        private Label label6;
        private ComboBox cbxTipo;
        private DataGridView dgvMovimento;
        private Button btnVoltar;
        private Label label7;
        private Label label8;
        private Button btnAtualizarMov;
        private DataGridView dgvMvMarcados;
        private Label label9;
        private DataGridView dgvMvLivres;
        private Button button1;
        private Button button2;
    }
}