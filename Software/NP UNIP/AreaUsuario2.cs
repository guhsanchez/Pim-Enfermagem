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
    public partial class AreaUsuario2 : Form
    {
        public AreaUsuario2()
        {
            InitializeComponent();
        }

        private void BtnCadPac_A2_Click(object sender, EventArgs e)
        {
            Cadastro _CA1;
            _CA1 = new Cadastro();
            _CA1.Show();
            Hide();
        }

        private void BtnImprimir_A2_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnAltDados_A2_Click(object sender, EventArgs e)
        {

        }

        private void BtnPesqPac_2_Click(object sender, EventArgs e)
        {

        }

        private void BtnMarCon_A2_Click(object sender, EventArgs e)
        {

        }

        private void BtnRemarCon_A2_Click(object sender, EventArgs e)
        {

        }
    }
}
