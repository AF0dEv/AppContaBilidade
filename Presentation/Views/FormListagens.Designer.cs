namespace RegistoMovimentosSrJoaquim
{
    partial class FormListagens
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormListagens));
            dgvMovimento = new DataGridView();
            label7 = new Label();
            label8 = new Label();
            dgvMvMarcados = new DataGridView();
            label9 = new Label();
            dgvMvLivres = new DataGridView();
            label10 = new Label();
            cbxCliente = new ComboBox();
            label11 = new Label();
            cbxMes = new ComboBox();
            label12 = new Label();
            label13 = new Label();
            txtSaldo = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvMovimento).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvMvMarcados).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvMvLivres).BeginInit();
            SuspendLayout();
            // 
            // dgvMovimento
            // 
            dgvMovimento.BackgroundColor = SystemColors.ControlLight;
            dgvMovimento.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMovimento.Cursor = Cursors.Hand;
            dgvMovimento.Location = new Point(12, 38);
            dgvMovimento.Name = "dgvMovimento";
            dgvMovimento.RowHeadersWidth = 51;
            dgvMovimento.Size = new Size(1014, 193);
            dgvMovimento.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(444, 9);
            label7.Name = "label7";
            label7.Size = new Size(155, 26);
            label7.TabIndex = 18;
            label7.Text = "MOVIMENTOS";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(430, 277);
            label8.Name = "label8";
            label8.Size = new Size(130, 26);
            label8.TabIndex = 19;
            label8.Text = "MARCADOS";
            // 
            // dgvMvMarcados
            // 
            dgvMvMarcados.BackgroundColor = SystemColors.ControlLight;
            dgvMvMarcados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMvMarcados.Cursor = Cursors.Hand;
            dgvMvMarcados.Location = new Point(430, 307);
            dgvMvMarcados.Name = "dgvMvMarcados";
            dgvMvMarcados.RowHeadersWidth = 51;
            dgvMvMarcados.Size = new Size(285, 187);
            dgvMvMarcados.TabIndex = 21;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(942, 277);
            label9.Name = "label9";
            label9.Size = new Size(84, 26);
            label9.TabIndex = 22;
            label9.Text = "LIVRES";
            // 
            // dgvMvLivres
            // 
            dgvMvLivres.BackgroundColor = SystemColors.ControlLight;
            dgvMvLivres.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMvLivres.Cursor = Cursors.Hand;
            dgvMvLivres.Location = new Point(721, 307);
            dgvMvLivres.Name = "dgvMvLivres";
            dgvMvLivres.RowHeadersWidth = 51;
            dgvMvLivres.Size = new Size(305, 187);
            dgvMvLivres.TabIndex = 23;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Yu Gothic", 12F, FontStyle.Bold);
            label10.Location = new Point(271, 381);
            label10.Name = "label10";
            label10.Size = new Size(24, 26);
            label10.TabIndex = 32;
            label10.Text = "€";
            // 
            // cbxCliente
            // 
            cbxCliente.Cursor = Cursors.IBeam;
            cbxCliente.Font = new Font("Segoe UI", 12F);
            cbxCliente.ForeColor = Color.Black;
            cbxCliente.FormattingEnabled = true;
            cbxCliente.Location = new Point(52, 381);
            cbxCliente.Name = "cbxCliente";
            cbxCliente.Size = new Size(151, 36);
            cbxCliente.TabIndex = 31;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(52, 332);
            label11.Name = "label11";
            label11.Size = new Size(99, 26);
            label11.TabIndex = 28;
            label11.Text = "CLIENTE";
            // 
            // cbxMes
            // 
            cbxMes.Cursor = Cursors.IBeam;
            cbxMes.Font = new Font("Segoe UI", 12F);
            cbxMes.ForeColor = Color.Black;
            cbxMes.FormattingEnabled = true;
            cbxMes.Location = new Point(52, 461);
            cbxMes.Name = "cbxMes";
            cbxMes.Size = new Size(151, 36);
            cbxMes.TabIndex = 26;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Yu Gothic", 12F, FontStyle.Bold);
            label12.Location = new Point(52, 432);
            label12.Name = "label12";
            label12.Size = new Size(57, 26);
            label12.TabIndex = 29;
            label12.Text = "MÊS";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Yu Gothic", 12F, FontStyle.Bold);
            label13.Location = new Point(226, 307);
            label13.Name = "label13";
            label13.Size = new Size(81, 26);
            label13.TabIndex = 30;
            label13.Text = "SALDO";
            // 
            // txtSaldo
            // 
            txtSaldo.Cursor = Cursors.IBeam;
            txtSaldo.Font = new Font("Segoe UI", 12F);
            txtSaldo.ForeColor = Color.Black;
            txtSaldo.Location = new Point(215, 344);
            txtSaldo.Name = "txtSaldo";
            txtSaldo.PlaceholderText = "000.000.00";
            txtSaldo.Size = new Size(108, 34);
            txtSaldo.TabIndex = 27;
            // 
            // FormListagens
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(1038, 540);
            Controls.Add(label10);
            Controls.Add(cbxCliente);
            Controls.Add(label11);
            Controls.Add(cbxMes);
            Controls.Add(label12);
            Controls.Add(label13);
            Controls.Add(txtSaldo);
            Controls.Add(dgvMvLivres);
            Controls.Add(label9);
            Controls.Add(dgvMvMarcados);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(dgvMovimento);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormListagens";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LISTAGENS";
            Load += FormMovimentos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMovimento).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvMvMarcados).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvMvLivres).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgvMovimento;
        private Label label7;
        private Label label8;
        private DataGridView dgvMvMarcados;
        private Label label9;
        private DataGridView dgvMvLivres;
        private Label label10;
        private ComboBox cbxCliente;
        private Label label11;
        private ComboBox cbxMes;
        private Label label12;
        private Label label13;
        private TextBox txtSaldo;
    }
}