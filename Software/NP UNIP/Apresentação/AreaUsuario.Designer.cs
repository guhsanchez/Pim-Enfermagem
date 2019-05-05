namespace NP_UNIP
{
    partial class AreaUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AreaUsuario));
            this.label18 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblPesqPac_Au1 = new System.Windows.Forms.Label();
            this.btnPesqPac_Au1 = new System.Windows.Forms.Button();
            this.grpDatePasc_Au1 = new System.Windows.Forms.GroupBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.lblMarcCons_Au1 = new System.Windows.Forms.Label();
            this.pnlMarCons_Au1 = new System.Windows.Forms.Panel();
            this.btnMarCons_Au1 = new System.Windows.Forms.Button();
            this.btnRemCons_Au1 = new System.Windows.Forms.Button();
            this.btnAltDados_Au1 = new System.Windows.Forms.Button();
            this.txbPesPasc_Au1 = new System.Windows.Forms.TextBox();
            this.btnCadPac_Au1 = new System.Windows.Forms.Button();
            this.btnImprimir_Au1 = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.data = new System.Windows.Forms.Label();
            this.hora = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnSair_Au1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Candara", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(402, 90);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(107, 18);
            this.label18.TabIndex = 80;
            this.label18.Text = "Área do usuário";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(301, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(339, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 81;
            this.pictureBox1.TabStop = false;
            // 
            // lblPesqPac_Au1
            // 
            this.lblPesqPac_Au1.AutoSize = true;
            this.lblPesqPac_Au1.BackColor = System.Drawing.Color.Transparent;
            this.lblPesqPac_Au1.Font = new System.Drawing.Font("Candara", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesqPac_Au1.ForeColor = System.Drawing.Color.White;
            this.lblPesqPac_Au1.Location = new System.Drawing.Point(36, 187);
            this.lblPesqPac_Au1.Name = "lblPesqPac_Au1";
            this.lblPesqPac_Au1.Size = new System.Drawing.Size(156, 18);
            this.lblPesqPac_Au1.TabIndex = 82;
            this.lblPesqPac_Au1.Text = "Pesquisar paciente por:";
            // 
            // btnPesqPac_Au1
            // 
            this.btnPesqPac_Au1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPesqPac_Au1.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesqPac_Au1.Location = new System.Drawing.Point(671, 187);
            this.btnPesqPac_Au1.Name = "btnPesqPac_Au1";
            this.btnPesqPac_Au1.Size = new System.Drawing.Size(197, 28);
            this.btnPesqPac_Au1.TabIndex = 7;
            this.btnPesqPac_Au1.Text = "Pesquisar paciente";
            this.btnPesqPac_Au1.UseVisualStyleBackColor = true;
            this.btnPesqPac_Au1.Click += new System.EventHandler(this.BtnPesqPac_Au1_Click);
            // 
            // grpDatePasc_Au1
            // 
            this.grpDatePasc_Au1.Location = new System.Drawing.Point(40, 234);
            this.grpDatePasc_Au1.Name = "grpDatePasc_Au1";
            this.grpDatePasc_Au1.Size = new System.Drawing.Size(828, 191);
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
            this.checkedListBox1.Location = new System.Drawing.Point(243, 187);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(137, 24);
            this.checkedListBox1.TabIndex = 5;
            // 
            // lblMarcCons_Au1
            // 
            this.lblMarcCons_Au1.AutoSize = true;
            this.lblMarcCons_Au1.BackColor = System.Drawing.Color.Transparent;
            this.lblMarcCons_Au1.Font = new System.Drawing.Font("Candara", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarcCons_Au1.ForeColor = System.Drawing.Color.White;
            this.lblMarcCons_Au1.Location = new System.Drawing.Point(36, 443);
            this.lblMarcCons_Au1.Name = "lblMarcCons_Au1";
            this.lblMarcCons_Au1.Size = new System.Drawing.Size(114, 18);
            this.lblMarcCons_Au1.TabIndex = 86;
            this.lblMarcCons_Au1.Text = "Marcar consulta:";
            // 
            // pnlMarCons_Au1
            // 
            this.pnlMarCons_Au1.Location = new System.Drawing.Point(185, 444);
            this.pnlMarCons_Au1.Name = "pnlMarCons_Au1";
            this.pnlMarCons_Au1.Size = new System.Drawing.Size(455, 100);
            this.pnlMarCons_Au1.TabIndex = 8;
            // 
            // btnMarCons_Au1
            // 
            this.btnMarCons_Au1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMarCons_Au1.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMarCons_Au1.Location = new System.Drawing.Point(671, 444);
            this.btnMarCons_Au1.Name = "btnMarCons_Au1";
            this.btnMarCons_Au1.Size = new System.Drawing.Size(197, 28);
            this.btnMarCons_Au1.TabIndex = 9;
            this.btnMarCons_Au1.Text = "Marcar consulta";
            this.btnMarCons_Au1.UseVisualStyleBackColor = true;
            this.btnMarCons_Au1.Click += new System.EventHandler(this.BtnMarCons_Au1_Click);
            // 
            // btnRemCons_Au1
            // 
            this.btnRemCons_Au1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRemCons_Au1.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemCons_Au1.Location = new System.Drawing.Point(671, 478);
            this.btnRemCons_Au1.Name = "btnRemCons_Au1";
            this.btnRemCons_Au1.Size = new System.Drawing.Size(197, 28);
            this.btnRemCons_Au1.TabIndex = 10;
            this.btnRemCons_Au1.Text = "Remarcar consulta";
            this.btnRemCons_Au1.UseVisualStyleBackColor = true;
            this.btnRemCons_Au1.Click += new System.EventHandler(this.BtnRemCons_Au1_Click);
            // 
            // btnAltDados_Au1
            // 
            this.btnAltDados_Au1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAltDados_Au1.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAltDados_Au1.Location = new System.Drawing.Point(301, 138);
            this.btnAltDados_Au1.Name = "btnAltDados_Au1";
            this.btnAltDados_Au1.Size = new System.Drawing.Size(197, 28);
            this.btnAltDados_Au1.TabIndex = 2;
            this.btnAltDados_Au1.Text = "Alterar dados";
            this.btnAltDados_Au1.UseVisualStyleBackColor = true;
            this.btnAltDados_Au1.Click += new System.EventHandler(this.BtnAltDados_Au1_Click);
            // 
            // txbPesPasc_Au1
            // 
            this.txbPesPasc_Au1.Location = new System.Drawing.Point(387, 187);
            this.txbPesPasc_Au1.Name = "txbPesPasc_Au1";
            this.txbPesPasc_Au1.Size = new System.Drawing.Size(278, 25);
            this.txbPesPasc_Au1.TabIndex = 6;
            // 
            // btnCadPac_Au1
            // 
            this.btnCadPac_Au1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadPac_Au1.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadPac_Au1.Location = new System.Drawing.Point(39, 138);
            this.btnCadPac_Au1.Name = "btnCadPac_Au1";
            this.btnCadPac_Au1.Size = new System.Drawing.Size(197, 28);
            this.btnCadPac_Au1.TabIndex = 1;
            this.btnCadPac_Au1.Text = "Cadastrar paciente";
            this.btnCadPac_Au1.UseVisualStyleBackColor = true;
            this.btnCadPac_Au1.Click += new System.EventHandler(this.BtnCadPac_Au1_Click);
            // 
            // btnImprimir_Au1
            // 
            this.btnImprimir_Au1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnImprimir_Au1.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir_Au1.Location = new System.Drawing.Point(552, 138);
            this.btnImprimir_Au1.Name = "btnImprimir_Au1";
            this.btnImprimir_Au1.Size = new System.Drawing.Size(197, 28);
            this.btnImprimir_Au1.TabIndex = 3;
            this.btnImprimir_Au1.Text = "Imprimir Formulário";
            this.btnImprimir_Au1.UseVisualStyleBackColor = true;
            this.btnImprimir_Au1.Click += new System.EventHandler(this.BtnImprimir_Au1_Click);
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
            // data
            // 
            this.data.AutoSize = true;
            this.data.BackColor = System.Drawing.Color.Transparent;
            this.data.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.data.ForeColor = System.Drawing.Color.White;
            this.data.Location = new System.Drawing.Point(667, 544);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(40, 18);
            this.data.TabIndex = 94;
            this.data.Text = "Data";
            this.data.Click += new System.EventHandler(this.data_Click);
            // 
            // hora
            // 
            this.hora.AutoSize = true;
            this.hora.BackColor = System.Drawing.Color.Transparent;
            this.hora.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hora.ForeColor = System.Drawing.Color.White;
            this.hora.Location = new System.Drawing.Point(764, 544);
            this.hora.Name = "hora";
            this.hora.Size = new System.Drawing.Size(42, 18);
            this.hora.TabIndex = 95;
            this.hora.Text = "Hora";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // btnSair_Au1
            // 
            this.btnSair_Au1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSair_Au1.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair_Au1.Location = new System.Drawing.Point(816, 138);
            this.btnSair_Au1.Name = "btnSair_Au1";
            this.btnSair_Au1.Size = new System.Drawing.Size(52, 28);
            this.btnSair_Au1.TabIndex = 4;
            this.btnSair_Au1.Text = "Sair";
            this.btnSair_Au1.UseVisualStyleBackColor = true;
            this.btnSair_Au1.Click += new System.EventHandler(this.BtnSair_Au1_Click);
            // 
            // AreaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(914, 592);
            this.Controls.Add(this.btnSair_Au1);
            this.Controls.Add(this.hora);
            this.Controls.Add(this.data);
            this.Controls.Add(this.btnImprimir_Au1);
            this.Controls.Add(this.btnCadPac_Au1);
            this.Controls.Add(this.txbPesPasc_Au1);
            this.Controls.Add(this.btnAltDados_Au1);
            this.Controls.Add(this.btnRemCons_Au1);
            this.Controls.Add(this.btnMarCons_Au1);
            this.Controls.Add(this.pnlMarCons_Au1);
            this.Controls.Add(this.lblMarcCons_Au1);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.grpDatePasc_Au1);
            this.Controls.Add(this.btnPesqPac_Au1);
            this.Controls.Add(this.lblPesqPac_Au1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label18);
            this.Font = new System.Drawing.Font("Candara", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AreaUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AreaUsuario";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblPesqPac_Au1;
        private System.Windows.Forms.Button btnPesqPac_Au1;
        private System.Windows.Forms.GroupBox grpDatePasc_Au1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label lblMarcCons_Au1;
        private System.Windows.Forms.Panel pnlMarCons_Au1;
        private System.Windows.Forms.Button btnMarCons_Au1;
        private System.Windows.Forms.Button btnRemCons_Au1;
        private System.Windows.Forms.Button btnAltDados_Au1;
        private System.Windows.Forms.TextBox txbPesPasc_Au1;
        private System.Windows.Forms.Button btnCadPac_Au1;
        private System.Windows.Forms.Button btnImprimir_Au1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Label data;
        private System.Windows.Forms.Label hora;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnSair_Au1;
    }
}