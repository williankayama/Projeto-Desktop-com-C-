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
    public partial class FrmCriarQuartos : Form
    {
        public FrmCriarQuartos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String numQuarto = txtNumQuarto.Text;
            String idTipoQuarto = txtIdTipoQuarto.Text;
            String telefoneQuarto = txtTelefoneQuarto.Text;
            String andar = txtAndar.Text;



            String strConexao = @"Data Source=BR-IT00230;Initial Catalog=ROYALPLAZA;Integrated Security=True";
            String Query = "INSERT INTO Quarto(numQuarto, idTipoQuarto, telefoneQuarto, andar) VALUES('" + numQuarto + "', '" + idTipoQuarto + "' , '" + telefoneQuarto + "','" + andar + "')";
            SqlConnection conexao = new SqlConnection(strConexao);
            SqlCommand comando = new SqlCommand(Query, conexao);

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

            txtNumQuarto.Text = "";
            txtTelefoneQuarto.Text = "";
            txtAndar.Text = "";
            txtIdTipoQuarto.Text = "";
        }
    }
}
