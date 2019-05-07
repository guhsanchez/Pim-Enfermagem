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
        }

        public override bool AutoScroll { get; set; }


        private void btnVoltar_Hist_Click(object sender, EventArgs e)
        {
            AreaUsuario _AU1;
            _AU1 = new AreaUsuario();
            _AU1.Show();
            Hide();
        }
    }
}
