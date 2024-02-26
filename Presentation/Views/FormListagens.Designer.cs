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
            dgvListagem = new DataGridView();
            label7 = new Label();
            label11 = new Label();
            label12 = new Label();
            btnMaiorMil = new Button();
            cbxClienteLis = new ComboBox();
            label1 = new Label();
            cbxMes = new ComboBox();
            rbtTempoPreciso = new RadioButton();
            rbtPeriodoTempo = new RadioButton();
            gbMes = new GroupBox();
            gbPeriodoTempo = new GroupBox();
            dtpListagem = new MonthCalendar();
            btnVoltarLis = new Button();
            btnSaidas = new Button();
            btnEntradas = new Button();
            btnListar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvListagem).BeginInit();
            gbMes.SuspendLayout();
            gbPeriodoTempo.SuspendLayout();
            SuspendLayout();
            // 
            // dgvListagem
            // 
            dgvListagem.BackgroundColor = SystemColors.ControlLight;
            dgvListagem.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListagem.Cursor = Cursors.Hand;
            dgvListagem.Location = new Point(10, 28);
            dgvListagem.Margin = new Padding(3, 2, 3, 2);
            dgvListagem.Name = "dgvListagem";
            dgvListagem.RowHeadersWidth = 51;
            dgvListagem.Size = new Size(887, 173);
            dgvListagem.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(388, 7);
            label7.Name = "label7";
            label7.Size = new Size(125, 21);
            label7.TabIndex = 18;
            label7.Text = "MOVIMENTOS";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(10, 209);
            label11.Name = "label11";
            label11.Size = new Size(80, 21);
            label11.TabIndex = 28;
            label11.Text = "CLIENTE";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Yu Gothic", 12F, FontStyle.Bold);
            label12.Location = new Point(15, 43);
            label12.Name = "label12";
            label12.Size = new Size(46, 21);
            label12.TabIndex = 29;
            label12.Text = "MÊS";
            // 
            // btnMaiorMil
            // 
            btnMaiorMil.Cursor = Cursors.Hand;
            btnMaiorMil.FlatStyle = FlatStyle.Popup;
            btnMaiorMil.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMaiorMil.Location = new Point(114, 267);
            btnMaiorMil.Margin = new Padding(3, 2, 3, 2);
            btnMaiorMil.Name = "btnMaiorMil";
            btnMaiorMil.Size = new Size(99, 22);
            btnMaiorMil.TabIndex = 32;
            btnMaiorMil.Text = ">1000";
            btnMaiorMil.UseVisualStyleBackColor = true;
            btnMaiorMil.Click += btnMaiorMil_Click;
            // 
            // cbxClienteLis
            // 
            cbxClienteLis.Cursor = Cursors.IBeam;
            cbxClienteLis.Font = new Font("Segoe UI", 12F);
            cbxClienteLis.ForeColor = Color.Black;
            cbxClienteLis.FormattingEnabled = true;
            cbxClienteLis.Location = new Point(114, 209);
            cbxClienteLis.Margin = new Padding(3, 2, 3, 2);
            cbxClienteLis.Name = "cbxClienteLis";
            cbxClienteLis.Size = new Size(133, 29);
            cbxClienteLis.TabIndex = 31;
            cbxClienteLis.SelectedIndexChanged += cbxClienteLis_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(10, 269);
            label1.Name = "label1";
            label1.Size = new Size(91, 21);
            label1.TabIndex = 33;
            label1.Text = "CLIENTES";
            // 
            // cbxMes
            // 
            cbxMes.Cursor = Cursors.IBeam;
            cbxMes.Font = new Font("Segoe UI", 12F);
            cbxMes.ForeColor = Color.Black;
            cbxMes.FormattingEnabled = true;
            cbxMes.Location = new Point(70, 38);
            cbxMes.Margin = new Padding(3, 2, 3, 2);
            cbxMes.Name = "cbxMes";
            cbxMes.Size = new Size(133, 29);
            cbxMes.TabIndex = 26;
            cbxMes.SelectedIndexChanged += cbxMes_SelectedIndexChanged;
            // 
            // rbtTempoPreciso
            // 
            rbtTempoPreciso.AutoSize = true;
            rbtTempoPreciso.Checked = true;
            rbtTempoPreciso.Font = new Font("Yu Gothic", 12F, FontStyle.Bold);
            rbtTempoPreciso.Location = new Point(371, 208);
            rbtTempoPreciso.Margin = new Padding(3, 2, 3, 2);
            rbtTempoPreciso.Name = "rbtTempoPreciso";
            rbtTempoPreciso.Size = new Size(64, 25);
            rbtTempoPreciso.TabIndex = 35;
            rbtTempoPreciso.TabStop = true;
            rbtTempoPreciso.Text = "MÊS";
            rbtTempoPreciso.UseVisualStyleBackColor = true;
            rbtTempoPreciso.CheckedChanged += rbtTempoPreciso_CheckedChanged;
            // 
            // rbtPeriodoTempo
            // 
            rbtPeriodoTempo.AutoSize = true;
            rbtPeriodoTempo.Font = new Font("Yu Gothic", 12F, FontStyle.Bold);
            rbtPeriodoTempo.Location = new Point(654, 206);
            rbtPeriodoTempo.Margin = new Padding(3, 2, 3, 2);
            rbtPeriodoTempo.Name = "rbtPeriodoTempo";
            rbtPeriodoTempo.Size = new Size(165, 25);
            rbtPeriodoTempo.TabIndex = 36;
            rbtPeriodoTempo.Text = "PERIODO TEMPO";
            rbtPeriodoTempo.UseVisualStyleBackColor = true;
            rbtPeriodoTempo.CheckedChanged += rbtPeriodoTempo_CheckedChanged;
            // 
            // gbMes
            // 
            gbMes.Controls.Add(label12);
            gbMes.Controls.Add(cbxMes);
            gbMes.Location = new Point(305, 252);
            gbMes.Margin = new Padding(3, 2, 3, 2);
            gbMes.Name = "gbMes";
            gbMes.Padding = new Padding(3, 2, 3, 2);
            gbMes.Size = new Size(219, 94);
            gbMes.TabIndex = 37;
            gbMes.TabStop = false;
            // 
            // gbPeriodoTempo
            // 
            gbPeriodoTempo.Controls.Add(dtpListagem);
            gbPeriodoTempo.Location = new Point(595, 233);
            gbPeriodoTempo.Margin = new Padding(3, 2, 3, 2);
            gbPeriodoTempo.Name = "gbPeriodoTempo";
            gbPeriodoTempo.Padding = new Padding(3, 2, 3, 2);
            gbPeriodoTempo.Size = new Size(303, 163);
            gbPeriodoTempo.TabIndex = 38;
            gbPeriodoTempo.TabStop = false;
            // 
            // dtpListagem
            // 
            dtpListagem.Location = new Point(33, 8);
            dtpListagem.Margin = new Padding(8, 7, 8, 7);
            dtpListagem.MaxSelectionCount = 10957266;
            dtpListagem.Name = "dtpListagem";
            dtpListagem.TabIndex = 0;
            dtpListagem.DateSelected += dtpListagem_DateSelected;
            // 
            // btnVoltarLis
            // 
            btnVoltarLis.Cursor = Cursors.Hand;
            btnVoltarLis.FlatStyle = FlatStyle.Popup;
            btnVoltarLis.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVoltarLis.Location = new Point(10, 381);
            btnVoltarLis.Margin = new Padding(3, 2, 3, 2);
            btnVoltarLis.Name = "btnVoltarLis";
            btnVoltarLis.Size = new Size(99, 22);
            btnVoltarLis.TabIndex = 39;
            btnVoltarLis.Text = "VOLTAR";
            btnVoltarLis.UseVisualStyleBackColor = true;
            btnVoltarLis.Click += btnVoltar_Click;
            // 
            // btnSaidas
            // 
            btnSaidas.Cursor = Cursors.Hand;
            btnSaidas.FlatStyle = FlatStyle.Popup;
            btnSaidas.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSaidas.Location = new Point(10, 333);
            btnSaidas.Margin = new Padding(3, 2, 3, 2);
            btnSaidas.Name = "btnSaidas";
            btnSaidas.Size = new Size(99, 22);
            btnSaidas.TabIndex = 40;
            btnSaidas.Text = "SAÍDAS";
            btnSaidas.UseVisualStyleBackColor = true;
            btnSaidas.Click += btnSaidas_Click;
            // 
            // btnEntradas
            // 
            btnEntradas.Cursor = Cursors.Hand;
            btnEntradas.FlatStyle = FlatStyle.Popup;
            btnEntradas.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEntradas.Location = new Point(10, 307);
            btnEntradas.Margin = new Padding(3, 2, 3, 2);
            btnEntradas.Name = "btnEntradas";
            btnEntradas.Size = new Size(99, 22);
            btnEntradas.TabIndex = 41;
            btnEntradas.Text = "ENTRADAS";
            btnEntradas.UseVisualStyleBackColor = true;
            btnEntradas.Click += btnEntradas_Click;
            // 
            // btnListar
            // 
            btnListar.Cursor = Cursors.Hand;
            btnListar.FlatStyle = FlatStyle.Popup;
            btnListar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnListar.Location = new Point(375, 372);
            btnListar.Margin = new Padding(3, 2, 3, 2);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(99, 22);
            btnListar.TabIndex = 42;
            btnListar.Text = "LISTAR";
            btnListar.UseVisualStyleBackColor = true;
            btnListar.Click += btnListar_Click;
            // 
            // FormListagens
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(908, 405);
            Controls.Add(btnListar);
            Controls.Add(btnEntradas);
            Controls.Add(btnSaidas);
            Controls.Add(btnVoltarLis);
            Controls.Add(gbPeriodoTempo);
            Controls.Add(gbMes);
            Controls.Add(rbtPeriodoTempo);
            Controls.Add(rbtTempoPreciso);
            Controls.Add(label1);
            Controls.Add(cbxClienteLis);
            Controls.Add(label7);
            Controls.Add(btnMaiorMil);
            Controls.Add(dgvListagem);
            Controls.Add(label11);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormListagens";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LISTAGENS";
            Load += FormMovimentos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvListagem).EndInit();
            gbMes.ResumeLayout(false);
            gbMes.PerformLayout();
            gbPeriodoTempo.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgvListagem;
        private Label label7;
        private Label label11;
        private Label label12;
        private Button btnMaiorMil;
        private ComboBox cbxClienteLis;
        private Label label1;
        private ComboBox cbxMes;
        private RadioButton rbtTempoPreciso;
        private RadioButton rbtPeriodoTempo;
        private GroupBox gbMes;
        private GroupBox gbPeriodoTempo;
        private MonthCalendar dtpListagem;
        private Button btnVoltarLis;
        private Button btnSaidas;
        private Button btnEntradas;
        private Button btnListar;
    }
}