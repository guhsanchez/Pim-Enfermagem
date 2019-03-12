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
    public partial class SITE : Form
    {
        public SITE()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CADASTRO _c1;
            _c1 = new CADASTRO();
            _c1.Show();
            Hide();
        }

        private void Cadastrar_Click(object sender, EventArgs e)
        {
            CadastroUsuario _CU1;
            _CU1 = new CadastroUsuario();
            _CU1.Show();
            Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Entrar_Click(object sender, EventArgs e)
        {
            AreaUsuario _AU1;
            _AU1 = new AreaUsuario();
            _AU1.Show();
            Hide();
        }
    }
}
