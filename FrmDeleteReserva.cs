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

namespace PIM
{
    public partial class FrmDeleteReserva : Form
    {
        public FrmDeleteReserva()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string deleteReserva = txtDeleteRe.Text;

            String strConexao = @"Data Source=BR-IT00230;Initial Catalog=ROYALPLAZA;Integrated Security=True";
            String query = "DELETE FROM Reserva WHERE codReserva = '" + deleteReserva + "'";

            SqlConnection conexao = new SqlConnection(strConexao);
            SqlCommand comando = new SqlCommand(query, conexao);
            conexao.Open();
            try
            {
                comando.ExecuteNonQuery();
                conexao.Close();
                MessageBox.Show("OK! Feito!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                conexao.Close();
            }
        }
    }
    
}
