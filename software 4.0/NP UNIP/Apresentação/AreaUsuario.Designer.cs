﻿namespace NP_UNIP
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
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.btnCadPac_Au1 = new System.Windows.Forms.Button();
            this.btnHistorico_Au1 = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.lbldata = new System.Windows.Forms.Label();
            this.lblhora = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnLogout_Au1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgdados = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgdados)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPesqPac_Au1
            // 
            this.lblPesqPac_Au1.AutoSize = true;
            this.lblPesqPac_Au1.BackColor = System.Drawing.Color.Transparent;
            this.lblPesqPac_Au1.Font = new System.Drawing.Font("Candara", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesqPac_Au1.ForeColor = System.Drawing.Color.Black;
            this.lblPesqPac_Au1.Location = new System.Drawing.Point(292, 85);
            this.lblPesqPac_Au1.Name = "lblPesqPac_Au1";
            this.lblPesqPac_Au1.Size = new System.Drawing.Size(156, 18);
            this.lblPesqPac_Au1.TabIndex = 82;
            this.lblPesqPac_Au1.Text = "Pesquisar paciente por:";
            // 
            // btnPesqPac_Au1
            // 
            this.btnPesqPac_Au1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPesqPac_Au1.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesqPac_Au1.Location = new System.Drawing.Point(461, 173);
            this.btnPesqPac_Au1.Name = "btnPesqPac_Au1";
            this.btnPesqPac_Au1.Size = new System.Drawing.Size(199, 47);
            this.btnPesqPac_Au1.TabIndex = 7;
            this.btnPesqPac_Au1.Text = "Pesquisar ";
            this.btnPesqPac_Au1.UseVisualStyleBackColor = true;
            this.btnPesqPac_Au1.Click += new System.EventHandler(this.btnPesqPac_Au1_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Nome",
            "CPF",
            "Código"});
            this.checkedListBox1.Location = new System.Drawing.Point(455, 85);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(205, 24);
            this.checkedListBox1.TabIndex = 5;
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
            this.lbldata.Size = new System.Drawing.Size(40, 18);
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
            this.lblhora.Size = new System.Drawing.Size(42, 18);
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
            this.btnLogout_Au1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout_Au1.Location = new System.Drawing.Point(42, 335);
            this.btnLogout_Au1.Name = "btnLogout_Au1";
            this.btnLogout_Au1.Size = new System.Drawing.Size(155, 34);
            this.btnLogout_Au1.TabIndex = 4;
            this.btnLogout_Au1.Text = "Logout";
            this.btnLogout_Au1.UseVisualStyleBackColor = false;
            this.btnLogout_Au1.Click += new System.EventHandler(this.btnLogout_Au1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(455, 115);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(205, 25);
            this.textBox1.TabIndex = 97;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(362, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 18);
            this.label1.TabIndex = 98;
            this.label1.Text = "Digite aqui :";
            // 
            // dgdados
            // 
            this.dgdados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdados.Location = new System.Drawing.Point(295, 249);
            this.dgdados.Name = "dgdados";
            this.dgdados.Size = new System.Drawing.Size(537, 309);
            this.dgdados.TabIndex = 99;
            // 
            // frmAreaUsuario
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.dgdados);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnLogout_Au1);
            this.Controls.Add(this.lblhora);
            this.Controls.Add(this.btnPesqPac_Au1);
            this.Controls.Add(this.lbldata);
            this.Controls.Add(this.btnHistorico_Au1);
            this.Controls.Add(this.btnCadPac_Au1);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.lblPesqPac_Au1);
            this.Font = new System.Drawing.Font("Candara", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAreaUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmAreaUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgdados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblPesqPac_Au1;
        private System.Windows.Forms.Button btnPesqPac_Au1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button btnCadPac_Au1;
        private System.Windows.Forms.Button btnHistorico_Au1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Label lbldata;
        private System.Windows.Forms.Label lblhora;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnLogout_Au1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgdados;
    }
}