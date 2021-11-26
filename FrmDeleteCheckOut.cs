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
    public partial class FrmDeleteCheckOut : Form
    {
        public FrmDeleteCheckOut()
        {
            InitializeComponent();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            String deleteCheckOut = txtCheckOut.Text;

            String strConexao = @"Data Source=BR-IT00230;Initial Catalog=ROYALPLAZA;Integrated Security=True";
            String query = "DELETE FROM CheckOut WHERE codCheckOut = '" + deleteCheckOut + "'";

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
