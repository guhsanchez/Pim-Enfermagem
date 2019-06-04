using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NP_UNIP
{
    public partial class frmPrincipal : Form
    {
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
            #region
            frmAreaUsuario _AU1;
            _AU1 = new frmAreaUsuario();
            _AU1.Show();
            Hide();
            #endregion
            #region
            if (true)
            {

            }
            else
            {
                MessageBox.Show("Senho e/ou Login invalido!");
            }
            #endregion
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
    }
}
