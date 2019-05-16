namespace NP_UNIP
{
    partial class frmAreaUsuario
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAreaUsuario));
            this.lblPesqPac_Au1 = new System.Windows.Forms.Label();
            this.btnPesqPac_Au1 = new System.Windows.Forms.Button();
            this.grpDatePasc_Au1 = new System.Windows.Forms.GroupBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.btnAltDados_Au1 = new System.Windows.Forms.Button();
            this.txbPesPasc_Au1 = new System.Windows.Forms.TextBox();
            this.btnCadPac_Au1 = new System.Windows.Forms.Button();
            this.btnHistorico_Au1 = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.lbldata = new System.Windows.Forms.Label();
            this.lblhora = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnLogout_Au1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPesqPac_Au1
            // 
            this.lblPesqPac_Au1.AutoSize = true;
            this.lblPesqPac_Au1.BackColor = System.Drawing.Color.Transparent;
            this.lblPesqPac_Au1.Font = new System.Drawing.Font("Candara", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesqPac_Au1.ForeColor = System.Drawing.Color.Black;
            this.lblPesqPac_Au1.Location = new System.Drawing.Point(291, 91);
            this.lblPesqPac_Au1.Name = "lblPesqPac_Au1";
            this.lblPesqPac_Au1.Size = new System.Drawing.Size(201, 23);
            this.lblPesqPac_Au1.TabIndex = 82;
            this.lblPesqPac_Au1.Text = "Pesquisar paciente por:";
            // 
            // btnPesqPac_Au1
            // 
            this.btnPesqPac_Au1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPesqPac_Au1.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesqPac_Au1.Location = new System.Drawing.Point(1024, 110);
            this.btnPesqPac_Au1.Name = "btnPesqPac_Au1";
            this.btnPesqPac_Au1.Size = new System.Drawing.Size(199, 47);
            this.btnPesqPac_Au1.TabIndex = 7;
            this.btnPesqPac_Au1.Text = "Pesquisar paciente";
            this.btnPesqPac_Au1.UseVisualStyleBackColor = true;
            // 
            // grpDatePasc_Au1
            // 
            this.grpDatePasc_Au1.Location = new System.Drawing.Point(295, 180);
            this.grpDatePasc_Au1.Name = "grpDatePasc_Au1";
            this.grpDatePasc_Au1.Size = new System.Drawing.Size(928, 481);
            this.grpDatePasc_Au1.TabIndex = 84;
            this.grpDatePasc_Au1.TabStop = false;
            this.grpDatePasc_Au1.Text = "Dados do paciente:";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Nome",
            "CPF",
            "Código"});
            this.checkedListBox1.Location = new System.Drawing.Point(498, 90);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(314, 28);
            this.checkedListBox1.TabIndex = 5;
            // 
            // btnAltDados_Au1
            // 
            this.btnAltDados_Au1.BackColor = System.Drawing.Color.Transparent;
            this.btnAltDados_Au1.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAltDados_Au1.FlatAppearance.BorderSize = 0;
            this.btnAltDados_Au1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAltDados_Au1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAltDados_Au1.ForeColor = System.Drawing.Color.Black;
            this.btnAltDados_Au1.Location = new System.Drawing.Point(52, 180);
            this.btnAltDados_Au1.Name = "btnAltDados_Au1";
            this.btnAltDados_Au1.Size = new System.Drawing.Size(134, 47);
            this.btnAltDados_Au1.TabIndex = 2;
            this.btnAltDados_Au1.Text = "Alterar dados";
            this.btnAltDados_Au1.UseVisualStyleBackColor = false;
            // 
            // txbPesPasc_Au1
            // 
            this.txbPesPasc_Au1.BackColor = System.Drawing.SystemColors.Menu;
            this.txbPesPasc_Au1.Location = new System.Drawing.Point(295, 124);
            this.txbPesPasc_Au1.Name = "txbPesPasc_Au1";
            this.txbPesPasc_Au1.Size = new System.Drawing.Size(684, 29);
            this.txbPesPasc_Au1.TabIndex = 6;
            this.txbPesPasc_Au1.TextChanged += new System.EventHandler(this.txbPesPasc_Au1_TextChanged);
            // 
            // btnCadPac_Au1
            // 
            this.btnCadPac_Au1.BackColor = System.Drawing.Color.Transparent;
            this.btnCadPac_Au1.FlatAppearance.BorderSize = 0;
            this.btnCadPac_Au1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadPac_Au1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadPac_Au1.Location = new System.Drawing.Point(27, 226);
            this.btnCadPac_Au1.Name = "btnCadPac_Au1";
            this.btnCadPac_Au1.Size = new System.Drawing.Size(185, 47);
            this.btnCadPac_Au1.TabIndex = 1;
            this.btnCadPac_Au1.Text = "Cadastrar paciente";
            this.btnCadPac_Au1.UseVisualStyleBackColor = false;
            this.btnCadPac_Au1.Click += new System.EventHandler(this.BtnCadPac_Au1_Click);
            // 
            // btnHistorico_Au1
            // 
            this.btnHistorico_Au1.BackColor = System.Drawing.Color.Transparent;
            this.btnHistorico_Au1.FlatAppearance.BorderSize = 0;
            this.btnHistorico_Au1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistorico_Au1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistorico_Au1.Location = new System.Drawing.Point(32, 282);
            this.btnHistorico_Au1.Name = "btnHistorico_Au1";
            this.btnHistorico_Au1.Size = new System.Drawing.Size(174, 47);
            this.btnHistorico_Au1.TabIndex = 3;
            this.btnHistorico_Au1.Text = "Histórico Paciente";
            this.btnHistorico_Au1.UseVisualStyleBackColor = false;
            this.btnHistorico_Au1.Click += new System.EventHandler(this.btnHistorico_Au1_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            this.printPreviewDialog1.Load += new System.EventHandler(this.printPreviewDialog1_Load);
            // 
            // lbldata
            // 
            this.lbldata.AutoSize = true;
            this.lbldata.BackColor = System.Drawing.Color.Transparent;
            this.lbldata.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldata.ForeColor = System.Drawing.Color.Black;
            this.lbldata.Location = new System.Drawing.Point(72, 617);
            this.lbldata.Name = "lbldata";
            this.lbldata.Size = new System.Drawing.Size(52, 22);
            this.lbldata.TabIndex = 94;
            this.lbldata.Text = "Data";
            this.lbldata.Click += new System.EventHandler(this.timer1_Tick_1);
            // 
            // lblhora
            // 
            this.lblhora.AutoSize = true;
            this.lblhora.BackColor = System.Drawing.Color.Transparent;
            this.lblhora.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhora.ForeColor = System.Drawing.Color.Black;
            this.lblhora.Location = new System.Drawing.Point(72, 579);
            this.lblhora.Name = "lblhora";
            this.lblhora.Size = new System.Drawing.Size(54, 22);
            this.lblhora.TabIndex = 95;
            this.lblhora.Text = "Hora";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // btnLogout_Au1
            // 
            this.btnLogout_Au1.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout_Au1.FlatAppearance.BorderSize = 0;
            this.btnLogout_Au1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout_Au1.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout_Au1.Location = new System.Drawing.Point(42, 335);
            this.btnLogout_Au1.Name = "btnLogout_Au1";
            this.btnLogout_Au1.Size = new System.Drawing.Size(155, 34);
            this.btnLogout_Au1.TabIndex = 4;
            this.btnLogout_Au1.Text = "Logout";
            this.btnLogout_Au1.UseVisualStyleBackColor = false;
            this.btnLogout_Au1.Click += new System.EventHandler(this.btnLogout_Au1_Click);
            // 
            // frmAreaUsuario
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.btnLogout_Au1);
            this.Controls.Add(this.lblhora);
            this.Controls.Add(this.btnPesqPac_Au1);
            this.Controls.Add(this.txbPesPasc_Au1);
            this.Controls.Add(this.lbldata);
            this.Controls.Add(this.btnHistorico_Au1);
            this.Controls.Add(this.btnCadPac_Au1);
            this.Controls.Add(this.btnAltDados_Au1);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.grpDatePasc_Au1);
            this.Controls.Add(this.lblPesqPac_Au1);
            this.Font = new System.Drawing.Font("Candara", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAreaUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Area do Usuario";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblPesqPac_Au1;
        private System.Windows.Forms.Button btnPesqPac_Au1;
        private System.Windows.Forms.GroupBox grpDatePasc_Au1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button btnAltDados_Au1;
        private System.Windows.Forms.TextBox txbPesPasc_Au1;
        private System.Windows.Forms.Button btnCadPac_Au1;
        private System.Windows.Forms.Button btnHistorico_Au1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Label lbldata;
        private System.Windows.Forms.Label lblhora;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnLogout_Au1;
    }
}