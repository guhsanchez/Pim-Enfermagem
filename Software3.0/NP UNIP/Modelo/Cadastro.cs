using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using NP_UNIP.Modelo;
using System.Windows.Forms;

namespace NP_UNIP
{
    public class Cadastro
    {
        Conexao conexao = new Conexao();
        SqlCommand comand = new SqlCommand();
        public String mensagem = "";



        public Cadastro(String nome, String email)
        {

            //comando sql  sqlcommand
            comand.CommandText = "insert into(nome, email) values (@nome, @email)";

            //parametros dos dados
            comand.Parameters.AddWithValue("@nome", nome);
            comand.Parameters.AddWithValue("@email", email);

            //conectar com o banco conexao

            try
            {
                //conectar com o banco = conexao
                comand.Connection = conexao.conectar();
                //executar comando
                comand.ExecuteNonQuery();
                //desconectar
                conexao.desconectar();
                //mensagem de erro
                this.mensagem = "cadastrado com sucesso";

            }
            catch(SqlException)
            {
                this.mensagem = "nao cadastrou krl";
                
            }




        }

        public Cadastro(TextBox txbEmail_Cad, TextBox txbNome_Cad)
        {
        }

        public Cadastro(Action<object, KeyPressEventArgs> txbNome_CadUser_KeyPress, Action<object, KeyPressEventArgs> txbEmail_CadUser_KeyPress)
        {
        }
    }
}
