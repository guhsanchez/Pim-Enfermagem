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
    public partial class frmCadastroUsuario : Form
    {
        public frmCadastroUsuario()
        {
            InitializeComponent();

            this.Height = Screen.PrimaryScreen.Bounds.Height;
            this.Width = Screen.PrimaryScreen.Bounds.Width;
            this.TopMost = true;
        }

        private void BtnCadastrarUser_CadUser_Click(object sender, EventArgs e)
        {
            // string conexao
            SqlConnection conec = new SqlConnection("");// cadeia de conexao do banco


            //strin inserçao
            string sql = "INSERT INTO Usuario (idUsuario, loginn, funcao, senha, email, regFuncional, nome, ogadouroEnd,BairroEnd,Tel,cel,cidade) values (@idUsuario, @loginn, @funcao, @senha, @email, @regFuncional, @nome, @ogadouroEnd,@bairroEnd,@tel,@cel,@cidade)";
            Random idUsuario = new Random();
            idUsuario.Next();

            //parametros para entrada de dados
            try
            {
                SqlCommand cm = new SqlCommand(sql, conec);

                cm.Parameters.Add(new SqlParameter("idUsuario", idUsuario.Next()));
               
                cm.Parameters.Add(new SqlParameter("loginn", txbLogin_CadUser.Text));
                cm.Parameters.Add(new SqlParameter("funcao", txbFuncao_CadUser.Text));
                cm.Parameters.Add(new SqlParameter("senha", txbSenha_CadUser.Text));               
                cm.Parameters.Add(new SqlParameter("email", txbEmail_CadUser.Text));
                cm.Parameters.Add(new SqlParameter("regFuncional", txbRegFunc_CadUser.Text));
                cm.Parameters.Add(new SqlParameter("nome", txbNome_CadUser.Text));
                cm.Parameters.Add(new SqlParameter("ogadouroEnd", txbEnder_CadUser.Text));
                cm.Parameters.Add(new SqlParameter("bairroEnd", txbBairro_CadUser.Text));
                cm.Parameters.Add(new SqlParameter("tel", mktTel_CadUser.Mask));
                cm.Parameters.Add(new SqlParameter("cel", mktCel_CadUser.Mask));
                cm.Parameters.Add(new SqlParameter("cidade", txbCit_CadUser.Text));





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

        private void BtnVoltar_CadUser_Click(object sender, EventArgs e)
        {
            frmPrincipal _U1;
            _U1 = new frmPrincipal();
            _U1.Show();
            Hide();
        }

        private void TxbNome_CadUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void TxbCit_CadUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void TxbFuncao_CadUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void TxbEnder_CadUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void TxbBairro_CadUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void TxbEmail_CadUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void TxbLogin_CadUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void TxbSenha_CadUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void TxbConfSenha_CadUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void frmCadastroUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}
