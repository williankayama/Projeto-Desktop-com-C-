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
    public partial class FrmEditarQuartos : Form
    {
        public FrmEditarQuartos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String numQuarto = txtNumQuarto.Text;
            String idTipoQuarto = txtIdTipoQuarto.Text;
            int disponibilidade;
            String telefoneQuarto = txtTelefoneQuarto.Text;
            String andar = txtAndar.Text;
            String codReserva = txtCodReserva.Text;

            if (chkDisponibilidade.Checked)
            {
                disponibilidade = 1;
            }
            else
            {
                disponibilidade = 0;
            }

            String strConexao = @"Data Source=BR-IT00230;Initial Catalog=ROYALPLAZA;Integrated Security=True";
            String query = "UPDATE Quarto SET idTipoQuarto = '" + idTipoQuarto +
                "', telefoneQuarto = '" + telefoneQuarto +
                "', andar = '" + andar +
                "', codReserva = '" + codReserva +
                "', disponibilidade =" + disponibilidade +
                " WHERE numQuarto = '" + numQuarto + "'";
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

            txtNumQuarto.Text = "";
            chkDisponibilidade.Checked = false;
            txtTelefoneQuarto.Text = "";
            txtAndar.Text = "";
            txtCodReserva.Text = "";
            txtIdTipoQuarto.Text = "";
        }
    }
}
