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

        private void button5_Click(object sender, EventArgs e)
        {
            CADASTRO _CA1;
            _CA1 = new CADASTRO();
            _CA1.Show();
            Hide();
        }
    }
}
