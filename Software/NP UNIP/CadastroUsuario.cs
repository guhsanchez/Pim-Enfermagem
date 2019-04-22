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
    public partial class CadastroUsuario : Form
    {
        public CadastroUsuario()
        {
            InitializeComponent();
        }

        private void BtnCadastrarUser_CadUser_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cadastrado com sucesso!");
        }

        private void BtnVoltar_CadUser_Click(object sender, EventArgs e)
        {
            frmPrincipal _U1;
            _U1 = new frmPrincipal();
            _U1.Show();
            Hide();
        }
    }
}
