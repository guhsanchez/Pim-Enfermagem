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
            Cadastro _c1;
            _c1 = new Cadastro();
            _c1.Show();
            Hide();
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            CadastroUsuario _CU1;
            _CU1 = new CadastroUsuario();
            _CU1.Show();
            Hide();
        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            AreaUsuario _AU1;
            _AU1 = new AreaUsuario();
            _AU1.Show();
            Hide();
        }
    }
}
