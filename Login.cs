using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace PIM
{
    public class Login
    {
        public bool LoginUsr(string Login, string Senha)
        {
            bool ret = false;

            string strConexao = @"Data Source=BR-IT00230;Initial Catalog=ROYALPLAZA;Integrated Security=True";
            string Query = "select count (*) from tbUsuario u where Login = '" + Login + "' AND Senha = '" + Senha + "' AND Status = 'A'; ";
            SqlConnection connection = new SqlConnection(strConexao);
            SqlCommand comando = new SqlCommand(Query, connection);

            try
            {
                connection.Open();
                int i = Convert.ToInt32(comando.ExecuteScalar());
                if (i >= 1) return ret = true;
            }
            catch (Exception ex)
            {
                string err = ex.Message;
            }
            finally
            {
                connection.Close();
            }


            return ret;
        }
    }
}
