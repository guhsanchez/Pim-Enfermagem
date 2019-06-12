using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace NP_UNIP
{
    public partial class frmPrincipal : Form
    {
        Thread nt;

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroPaciente _c1;
            _c1 = new frmCadastroPaciente();
            _c1.Show();
            Hide();
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            frmCadastroUsuario _CU1;
            _CU1 = new frmCadastroUsuario();
            _CU1.Show();
            Hide();
        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            if (txbLogin.Text == "ADM" && txbSenha.Text == "123")
            {
                this.Close();
                nt = new Thread(areaUser);
                nt.SetApartmentState(ApartmentState.STA);
                nt.Start();
            }
            else
            {
                MessageBox.Show("Senha ou Login Incorretos! ");
            }
        }

        private void areaUser()
        {
            Application.Run(new frmAreaUsuario());
        }

        private void TxbLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void TxbSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void Linksite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                VisitLink();
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to open link that was clicked.");
            }
        }

        private void VisitLink()
        {
            linksite.LinkVisited = true;
            System.Diagnostics.Process.Start("https://www.unip.br/portal.aspx");
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
