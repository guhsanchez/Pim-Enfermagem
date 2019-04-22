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

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
           
        }

        private void data_Click(object sender, EventArgs e)
        {
            data.Text = DateTime.Now.ToString("dd/MM/yyyy");
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

        private void BtnAltDados_Au1_Click(object sender, EventArgs e)
        {

        }

        private void BtnImprimir_Au1_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void BtnPesqPac_Au1_Click(object sender, EventArgs e)
        {

        }

        private void BtnMarCons_Au1_Click(object sender, EventArgs e)
        {

        }

        private void BtnRemCons_Au1_Click(object sender, EventArgs e)
        {

        }

        private void BtnSair_Au1_Click(object sender, EventArgs e)
        {
            frmPrincipal _U1;
            _U1 = new frmPrincipal();
            _U1.Show();
            Hide();
        }
    }
}
