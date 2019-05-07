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
    public partial class AreaUsuario : Form
    {
        public AreaUsuario()
        {
            InitializeComponent();
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
            hora.Text = DateTime.Now.ToString("HH:mm:ss");

        }

        private void BtnCadPac_Au1_Click(object sender, EventArgs e)
        {
            Cadastro _CA1;
            _CA1 = new Cadastro();
            _CA1.Show();
            Hide();
        }

        private void BtnSair_Au1_Click(object sender, EventArgs e)
        {
            frmPrincipal _U1;
            _U1 = new frmPrincipal();
            _U1.Show();
            Hide();
        }

        private void btnHistorico_Au1_Click(object sender, EventArgs e)
        {
            Apresentação.frmHistorico _H1;
            _H1 = new Apresentação.frmHistorico();
            _H1.Show();
            Hide();
        }
    }
}
