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
    public partial class frmCadastroUsuario : Form
    {
        public frmCadastroUsuario()
        {
            InitializeComponent();

            this.Height = Screen.PrimaryScreen.Bounds.Height;
            this.Width = Screen.PrimaryScreen.Bounds.Width;
            this.TopMost = true;
        }

        private void BtnCadastrarUser_CadUser_Click(object sender, EventArgs e)
        {
            Cadastro cad = new Cadastro(TxbNome_CadUser_KeyPress, TxbEmail_CadUser_KeyPress);
            MessageBox.Show(cad.mensagem);
        }

        private void BtnVoltar_CadUser_Click(object sender, EventArgs e)
        {
            frmPrincipal _U1;
            _U1 = new frmPrincipal();
            _U1.Show();
            Hide();
        }

        private void TxbNome_CadUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void TxbCit_CadUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void TxbFuncao_CadUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void TxbEnder_CadUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void TxbBairro_CadUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void TxbEmail_CadUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void TxbLogin_CadUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void TxbSenha_CadUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void TxbConfSenha_CadUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void frmCadastroUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}
