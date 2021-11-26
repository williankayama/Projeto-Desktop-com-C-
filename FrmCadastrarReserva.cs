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
    public partial class FrmCadastrarReserva : Form
    {
        public FrmCadastrarReserva()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String codReserva = txtReserva.Text;
            String idHospedePF = txtIdHospedePF.Text;
            String idHospedePJ = txtIdHospedePJ.Text;
            String telefone = txtTelefone.Text;
            String dataCheckIn = dtCheckIn.Value.ToString("yyyy-MM-dd");
            String dataCheckOut = dtCheckOut.Value.ToString("yyyy-MM-dd");
            String numPessoa = txtNumPessoas.Text;
            String numCrianca = txtNumCriancas.Text;
            String idadeCrianca = txtIdadeCriancas.Text;

            if (idHospedePF != "" && idHospedePF != null && idHospedePJ != "" && idHospedePJ != null)
            {
                MessageBox.Show("Preencha somente um campo de Hospede!");
            }
            else
            {
                if (idHospedePF != "" && idHospedePF != null)
                {
                    String strConexao = @"Data Source=BR-IT00230;Initial Catalog=ROYALPLAZA;Integrated Security=True";
                    String Query = "INSERT INTO Reserva(codReserva, idHospedePF, telefone, checkIn, checkOut, numPessoas, numCriancas, idadeCrianca) " +
                        "VALUES('" + codReserva + "', '" + idHospedePF + "' , '" + telefone + "','" + dataCheckIn + "','" + dataCheckOut + "','" + numPessoa + "','" + numCrianca + "','" + idadeCrianca + "')";
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
                    txtReserva.Text = "";
                    txtIdHospedePF.Text = "";
                    txtIdHospedePJ.Text = "";
                    txtTelefone.Text = "";
                    txtNumPessoas.Text = "";
                    txtNumCriancas.Text = "";
                    txtIdadeCriancas.Text = "";
                }
                if (idHospedePJ != "" && idHospedePJ != null)
                {
                    String strConexao = @"Data Source=BR-IT00230;Initial Catalog=ROYALPLAZA;Integrated Security=True";
                    String Query = "INSERT INTO Reserva(codReserva, idHospedePJ, telefone, checkIn, checkOut, numPessoas, numCriancas, idadeCrianca) " +
                        "VALUES('" + codReserva + "', '" + idHospedePJ + "','" + telefone + "','" + dataCheckIn + "','" + dataCheckOut + "','" + numPessoa + "','" + numCrianca + "','" + idadeCrianca + "')";
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
                    txtReserva.Text = "";
                    txtIdHospedePF.Text = "";
                    txtIdHospedePJ.Text = "";
                    txtTelefone.Text = "";
                    txtNumPessoas.Text = "";
                    txtNumCriancas.Text = "";
                    txtIdadeCriancas.Text = "";
                }
            }      
        }
    }
}