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
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {
            printPreviewDialog1.WindowState = FormWindowState.Maximized;
        }

        private void printDocument1_PrintPage_1(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font fonte = new Font("Arial", 30, FontStyle.Bold, GraphicsUnit.Pixel);
        }

        private void BtnCadastrarPac_Cadastro_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cadastrado com sucesso!");
        }

        private void BtnVoltar_Cad_Click(object sender, EventArgs e)
        {
            AreaUsuario _AU1;
            _AU1 = new AreaUsuario();
            _AU1.Show();
            Hide();
        }

        private void BtnImprimir_Cad_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }
    }
}
