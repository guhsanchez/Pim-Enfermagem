namespace NP_UNIP
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.btnEntrar = new System.Windows.Forms.Button();
            this.linksite = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txbSenha = new System.Windows.Forms.TextBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.txbLogin = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEntrar
            // 
            this.btnEntrar.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnEntrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEntrar.FlatAppearance.BorderSize = 0;
            this.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEntrar.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar.ForeColor = System.Drawing.Color.Black;
            this.btnEntrar.Location = new System.Drawing.Point(458, 295);
            this.btnEntrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(159, 33);
            this.btnEntrar.TabIndex = 3;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.Click += new System.EventHandler(this.BtnEntrar_Click);
            // 
            // linksite
            // 
            this.linksite.AutoSize = true;
            this.linksite.BackColor = System.Drawing.Color.Transparent;
            this.linksite.Font = new System.Drawing.Font("Candara", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linksite.ForeColor = System.Drawing.Color.DimGray;
            this.linksite.LinkColor = System.Drawing.Color.Black;
            this.linksite.Location = new System.Drawing.Point(504, 490);
            this.linksite.Name = "linksite";
            this.linksite.Size = new System.Drawing.Size(378, 23);
            this.linksite.TabIndex = 5;
            this.linksite.TabStop = true;
            this.linksite.Text = "CLIQUE AQUI PARA ACESSAR O SITE DA UNIP";
            this.linksite.VisitedLinkColor = System.Drawing.Color.White;
            this.linksite.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Linksite_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(458, 79);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(360, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.BackColor = System.Drawing.Color.Transparent;
            this.lblSenha.Font = new System.Drawing.Font("Candara", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.ForeColor = System.Drawing.Color.Black;
            this.lblSenha.Location = new System.Drawing.Point(458, 248);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(64, 23);
            this.lblSenha.TabIndex = 6;
            this.lblSenha.Text = "Senha:";
            // 
            // txbSenha
            // 
            this.txbSenha.BackColor = System.Drawing.Color.DimGray;
            this.txbSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbSenha.ForeColor = System.Drawing.SystemColors.Window;
            this.txbSenha.Location = new System.Drawing.Point(539, 248);
            this.txbSenha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbSenha.MaxLength = 15;
            this.txbSenha.Name = "txbSenha";
            this.txbSenha.PasswordChar = '*';
            this.txbSenha.Size = new System.Drawing.Size(279, 22);
            this.txbSenha.TabIndex = 2;
            this.txbSenha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxbSenha_KeyPress);
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.BackColor = System.Drawing.Color.Transparent;
            this.lblLogin.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.Color.Black;
            this.lblLogin.Location = new System.Drawing.Point(458, 200);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(60, 23);
            this.lblLogin.TabIndex = 8;
            this.lblLogin.Text = "Login:";
            // 
            // txbLogin
            // 
            this.txbLogin.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txbLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbLogin.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txbLogin.ForeColor = System.Drawing.SystemColors.Window;
            this.txbLogin.Location = new System.Drawing.Point(539, 200);
            this.txbLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbLogin.MaxLength = 15;
            this.txbLogin.Name = "txbLogin";
            this.txbLogin.Size = new System.Drawing.Size(279, 22);
            this.txbLogin.TabIndex = 1;
            this.txbLogin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxbLogin_KeyPress);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnCadastrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadastrar.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.Color.Black;
            this.btnCadastrar.Location = new System.Drawing.Point(659, 295);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(159, 33);
            this.btnCadastrar.TabIndex = 4;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(912, 518);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txbLogin);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.txbSenha);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.linksite);
            this.Controls.Add(this.btnEntrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UNIP ENFERMAGEM";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel linksite;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txbSenha;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox txbLogin;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnEntrar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

