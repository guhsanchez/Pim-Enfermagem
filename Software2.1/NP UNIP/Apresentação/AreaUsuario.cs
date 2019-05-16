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
    public partial class frmAreaUsuario : Form
    {
        public frmAreaUsuario()
        {
            InitializeComponent();

            this.Height = Screen.PrimaryScreen.Bounds.Height;
            this.Width = Screen.PrimaryScreen.Bounds.Width;
            this.TopMost = true;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font fonte = new Font("Arial", 30, FontStyle.Bold, GraphicsUnit.Pixel);
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {
            printPreviewDialog1.WindowState = FormWindowState.Maximized;
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            lblhora.Text = DateTime.Now.ToString("HH:mm:ss");
            lbldata.Text = DateTime.Now.ToString("ddd dd/MMM/yyyy");
        }

        private void BtnCadPac_Au1_Click(object sender, EventArgs e)
        {
            frmCadastroPaciente _CA1;
            _CA1 = new frmCadastroPaciente();
            _CA1.Show();
            Hide();
        }

        private void btnHistorico_Au1_Click(object sender, EventArgs e)
        {
            Apresentação.frmHistorico _H1;
            _H1 = new Apresentação.frmHistorico();
            _H1.Show();
            Hide();
        }

        private void txbPesPasc_Au1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogout_Au1_Click(object sender, EventArgs e)
        {
            frmPrincipal _U1;
            _U1 = new frmPrincipal();
            _U1.Show();
            Hide();
        }
    }
}
