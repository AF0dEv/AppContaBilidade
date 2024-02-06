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
            dgvPrincipal = new DataGridView();
            cbxMes = new ComboBox();
            txtSaldo = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnCriarCliente = new Button();
            btnCriarMov = new Button();
            label4 = new Label();
            cbxCliente = new ComboBox();
            label5 = new Label();
            dgvEntradas = new DataGridView();
            dgvSaidas = new DataGridView();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPrincipal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvEntradas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSaidas).BeginInit();
            SuspendLayout();
            // 
            // dgvPrincipal
            // 
            dgvPrincipal.BackgroundColor = SystemColors.ControlLight;
            dgvPrincipal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPrincipal.Cursor = Cursors.Hand;
            dgvPrincipal.Location = new Point(148, 31);
            dgvPrincipal.Margin = new Padding(3, 2, 3, 2);
            dgvPrincipal.Name = "dgvPrincipal";
            dgvPrincipal.RowHeadersWidth = 51;
            dgvPrincipal.Size = new Size(748, 167);
            dgvPrincipal.TabIndex = 1;
            // 
            // cbxMes
            // 
            cbxMes.Cursor = Cursors.IBeam;
            cbxMes.Font = new Font("Segoe UI", 12F);
            cbxMes.ForeColor = Color.Black;
            cbxMes.FormattingEnabled = true;
            cbxMes.Location = new Point(10, 145);
            cbxMes.Margin = new Padding(3, 2, 3, 2);
            cbxMes.Name = "cbxMes";
            cbxMes.Size = new Size(133, 29);
            cbxMes.TabIndex = 4;
            // 
            // txtSaldo
            // 
            txtSaldo.Cursor = Cursors.IBeam;
            txtSaldo.Font = new Font("Segoe UI", 12F);
            txtSaldo.ForeColor = Color.Black;
            txtSaldo.Location = new Point(10, 254);
            txtSaldo.Margin = new Padding(3, 2, 3, 2);
            txtSaldo.Name = "txtSaldo";
            txtSaldo.PlaceholderText = "000.000.00";
            txtSaldo.Size = new Size(95, 29);
            txtSaldo.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(10, 7);
            label1.Name = "label1";
            label1.Size = new Size(80, 21);
            label1.TabIndex = 6;
            label1.Text = "CLIENTE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic", 12F, FontStyle.Bold);
            label2.Location = new Point(10, 123);
            label2.Name = "label2";
            label2.Size = new Size(46, 21);
            label2.TabIndex = 7;
            label2.Text = "MÊS";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic", 12F, FontStyle.Bold);
            label3.Location = new Point(10, 232);
            label3.Name = "label3";
            label3.Size = new Size(66, 21);
            label3.TabIndex = 8;
            label3.Text = "SALDO";
            // 
            // btnCriarCliente
            // 
            btnCriarCliente.BackColor = Color.LightSteelBlue;
            btnCriarCliente.Cursor = Cursors.Hand;
            btnCriarCliente.FlatStyle = FlatStyle.Popup;
            btnCriarCliente.Location = new Point(10, 62);
            btnCriarCliente.Margin = new Padding(3, 2, 3, 2);
            btnCriarCliente.Name = "btnCriarCliente";
            btnCriarCliente.Size = new Size(82, 22);
            btnCriarCliente.TabIndex = 9;
            btnCriarCliente.Text = "CRIAR";
            btnCriarCliente.UseVisualStyleBackColor = false;
            btnCriarCliente.Click += btnCriarCliente_Click;
            // 
            // btnCriarMov
            // 
            btnCriarMov.BackColor = Color.LightSteelBlue;
            btnCriarMov.Cursor = Cursors.Hand;
            btnCriarMov.FlatStyle = FlatStyle.Popup;
            btnCriarMov.Location = new Point(816, 378);
            btnCriarMov.Margin = new Padding(3, 2, 3, 2);
            btnCriarMov.Name = "btnCriarMov";
            btnCriarMov.Size = new Size(82, 22);
            btnCriarMov.TabIndex = 10;
            btnCriarMov.Text = "CRIAR";
            btnCriarMov.UseVisualStyleBackColor = false;
            btnCriarMov.Click += btnCriarMov_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic", 12F, FontStyle.Bold);
            label4.Location = new Point(675, 380);
            label4.Name = "label4";
            label4.Size = new Size(125, 21);
            label4.TabIndex = 12;
            label4.Text = "MOVIMENTOS";
            // 
            // cbxCliente
            // 
            cbxCliente.Cursor = Cursors.IBeam;
            cbxCliente.Font = new Font("Segoe UI", 12F);
            cbxCliente.ForeColor = Color.Black;
            cbxCliente.FormattingEnabled = true;
            cbxCliente.Location = new Point(10, 31);
            cbxCliente.Margin = new Padding(3, 2, 3, 2);
            cbxCliente.Name = "cbxCliente";
            cbxCliente.Size = new Size(133, 29);
            cbxCliente.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Yu Gothic", 12F, FontStyle.Bold);
            label5.Location = new Point(110, 259);
            label5.Name = "label5";
            label5.Size = new Size(20, 21);
            label5.TabIndex = 15;
            label5.Text = "€";
            // 
            // dgvEntradas
            // 
            dgvEntradas.BackgroundColor = SystemColors.ControlLight;
            dgvEntradas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEntradas.Cursor = Cursors.Hand;
            dgvEntradas.Location = new Point(148, 232);
            dgvEntradas.Margin = new Padding(3, 2, 3, 2);
            dgvEntradas.Name = "dgvEntradas";
            dgvEntradas.RowHeadersWidth = 51;
            dgvEntradas.Size = new Size(350, 142);
            dgvEntradas.TabIndex = 16;
            // 
            // dgvSaidas
            // 
            dgvSaidas.BackgroundColor = SystemColors.ControlLight;
            dgvSaidas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSaidas.Cursor = Cursors.Hand;
            dgvSaidas.Location = new Point(546, 232);
            dgvSaidas.Margin = new Padding(3, 2, 3, 2);
            dgvSaidas.Name = "dgvSaidas";
            dgvSaidas.RowHeadersWidth = 51;
            dgvSaidas.Size = new Size(350, 142);
            dgvSaidas.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Yu Gothic", 12F, FontStyle.Bold);
            label6.Location = new Point(149, 9);
            label6.Name = "label6";
            label6.Size = new Size(125, 21);
            label6.TabIndex = 18;
            label6.Text = "MOVIMENTOS";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Yu Gothic", 12F, FontStyle.Bold);
            label7.Location = new Point(548, 209);
            label7.Name = "label7";
            label7.Size = new Size(71, 21);
            label7.TabIndex = 19;
            label7.Text = "SAÍDAS";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Yu Gothic", 12F, FontStyle.Bold);
            label8.Location = new Point(148, 209);
            label8.Name = "label8";
            label8.Size = new Size(100, 21);
            label8.TabIndex = 20;
            label8.Text = "ENTRADAS";
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(908, 405);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(dgvSaidas);
            Controls.Add(dgvEntradas);
            Controls.Add(label5);
            Controls.Add(cbxCliente);
            Controls.Add(label4);
            Controls.Add(btnCriarMov);
            Controls.Add(btnCriarCliente);
            Controls.Add(label1);
            Controls.Add(cbxMes);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(txtSaldo);
            Controls.Add(dgvPrincipal);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LAVAGENS MUNDIAIS";
            Load += V_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPrincipal).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvEntradas).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvSaidas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgvPrincipal;
        private ComboBox cbxMes;
        private TextBox txtSaldo;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnCriarCliente;
        private Button btnCriarMov;
        private Label label4;
        private ComboBox cbxCliente;
        private Label label5;
        private DataGridView dgvEntradas;
        private DataGridView dgvSaidas;
        private Label label6;
        private Label label7;
        private Label label8;
    }
}
