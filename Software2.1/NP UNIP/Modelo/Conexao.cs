using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NP_UNIP.Modelo
{
    public class Conexao
    {
        SqlConnection conec = new SqlConnection();



        //construtor
        public Conexao()
        {
            conec.ConnectionString = "Data Source=DESKTOP-47NDF7T\\SQLEXPRESS;Initial Catalog=pimteste;Integrated Security=True";


        }
        
        //metodo conectar
        public SqlConnection conectar()
        {
            if(conec.State == System.Data.ConnectionState.Closed)
            {
                conec.Open();
            }
            return conec;

        }
        public void desconectar()
        {
            if (conec.State == System.Data.ConnectionState.Open)
            {
                conec.Close();
            }
            

        }

    

    
    }
}
