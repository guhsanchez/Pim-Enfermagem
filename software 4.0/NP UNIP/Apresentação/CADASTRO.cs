using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace NP_UNIP
{
    public partial class frmCadastroPaciente : Form
    {
        public frmCadastroPaciente()
        {
            InitializeComponent();

            this.Height = Screen.PrimaryScreen.Bounds.Height;
            this.Width = Screen.PrimaryScreen.Bounds.Width;
            this.TopMost = true;
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
        {      // string conexao
            SqlConnection conec = new SqlConnection("");//Cadeia de conexao do banco
            
           
            //strin inserçao
            string sql = "INSERT INTO Paciente (idcadPac,cpfPac, workPac, sexoPac, nomePac, civilPac, emailPac, escolPac, falarcom, endereco,numero,cep,bairro,estado,idade,cidade,tel) values (@idcadPac,@cpfPac, @workPac, @sexoPac, @nomePac, @civilPac, @emailPac, @escolPac, @falarcom,@endereco,@numero,@cep,@bairro,@estado,@idade,@cidade,@tel)";
            Random idcadPac = new Random();
            idcadPac.Next();


            try {
                SqlCommand cm = new SqlCommand(sql, conec);

                cm.Parameters.Add(new SqlParameter("idcadPac", idcadPac.Next()));
                cm.Parameters.Add(new SqlParameter("cpfPac", mktCPF.Text));
                cm.Parameters.Add(new SqlParameter("workPac", txbJob_Cad.Text));
                cm.Parameters.Add(new SqlParameter("sexoPac", txbSexo_Cad.Text));
                cm.Parameters.Add(new SqlParameter("nomePac", txbNome_Cad.Text));
                cm.Parameters.Add(new SqlParameter("civilPac", txbEstCiv_Cad.Text));
                cm.Parameters.Add(new SqlParameter("emailPac", txbEmail_Cad.Text));
                cm.Parameters.Add(new SqlParameter("escolPac", txbEscol_Cad.Text));
                cm.Parameters.Add(new SqlParameter("falarcom", txbTalk_Cad.Text));
                cm.Parameters.Add(new SqlParameter("endereco", txbEnder_Cad.Text));
                cm.Parameters.Add(new SqlParameter("numero", txbNum_Cad.Text));
                cm.Parameters.Add(new SqlParameter("cep", mktCep_Cad.Text));
                cm.Parameters.Add(new SqlParameter("bairro", txbBairro_Cad.Text));
                cm.Parameters.Add(new SqlParameter("estado", txbEstado_Cad.Text));
                cm.Parameters.Add(new SqlParameter("idade", txbIdade_Cad.Text));
                cm.Parameters.Add(new SqlParameter("cidade", txbCit_Cad.Text));
                cm.Parameters.Add(new SqlParameter("tel", mktTel.Text));



                conec.Open();

                cm.ExecuteNonQuery();


                conec.Close();

                MessageBox.Show("CADASTRADO COM SUCESSO");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("ERRO AO SALVAR" + ex);

            }
            finally
            {
                conec.Close();
            }

        

        }

        private void BtnVoltar_Cad_Click(object sender, EventArgs e)
        {
            frmAreaUsuario _AU1;
            _AU1 = new frmAreaUsuario();
            _AU1.Show();
            Hide();
        }

        private void BtnImprimir_Cad_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void TxbNome_Cad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void TxbIdade_Cad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void TxbEscol_Cad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void TxbEmail_Cad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsWhiteSpace(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void TxbEstCiv_Cad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void TxbSexo_Cad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void TxbJob_Cad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void TxbTalk_Cad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void TxbEnder_Cad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void TxbNum_Cad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void TxbBairro_Cad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void TxbCit_Cad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void TxbEstado_Cad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void frmCadastroPaciente_Load(object sender, EventArgs e)
        {

        }
    }
}
