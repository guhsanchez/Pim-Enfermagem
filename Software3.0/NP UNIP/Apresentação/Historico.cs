using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NP_UNIP.Apresentação
{
    public partial class frmHistorico : Form
    {
        public frmHistorico()
        {
            InitializeComponent();

            this.Height = Screen.PrimaryScreen.Bounds.Height;
            this.Width = Screen.PrimaryScreen.Bounds.Width;
            this.TopMost = true;
        }

        public override bool AutoScroll { get; set; }


        private void btnVoltar_Hist_Click(object sender, EventArgs e)
        {
            frmAreaUsuario _AU1;
            _AU1 = new frmAreaUsuario();
            _AU1.Show();
            Hide();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            frmAreaUsuario _AU1;
            _AU1 = new frmAreaUsuario();
            _AU1.Show();
            Hide();
        }

        private void BtnVoltar_Hist_Click_1(object sender, EventArgs e)
        {
            frmAreaUsuario _AU1;
            _AU1 = new frmAreaUsuario();
            _AU1.Show();
            Hide();
        }

        private void BtnVoltar_Hist_Click_2(object sender, EventArgs e)
        {
            frmAreaUsuario _AU1;
            _AU1 = new frmAreaUsuario();
            _AU1.Show();
            Hide();
        }

        private void FrmHistorico_Load(object sender, EventArgs e)
        {

        }
    }
}
