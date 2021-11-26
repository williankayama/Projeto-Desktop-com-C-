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
    public partial class FrmRegistrarCheckIn : Form
    {
        public FrmRegistrarCheckIn()
        {
            InitializeComponent();
        }

        private void btRegistrar_Click(object sender, EventArgs e)
        {
            String Reserva = txtReserva.Text;
            String CheckIn = txtCheckIn.Text;
            String idHospedePF = txtIdHospedePF.Text;
            String idHospedePJ = txtIdHospedePJ.Text;
            String dataFormated = dtCheckIn.Value.ToString("yyyy-MM-dd");


            
            if(idHospedePF != "" && idHospedePF != null && idHospedePJ != "" && idHospedePJ != null)
            {
                MessageBox.Show("Preencha somente Id do Hospede PF ou Id do Hospede PJ");
            }
            else
            {
                if (idHospedePF != "" && idHospedePF != null)
                {
                    String strConexao = @"Data Source=BR-IT00230;Initial Catalog=ROYALPLAZA;Integrated Security=True";
                    String Query = "INSERT INTO CheckIn(codReserva, status, idHospedePF, dataChegada, codCheckIn) VALUES('" + Reserva + "', 'True' , '" + idHospedePF + "','" + dataFormated + "','" + CheckIn + "')";
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
                }
                if (idHospedePJ != "" && idHospedePJ != null)
                {
                    String strConexao = @"Data Source=BR-IT00230;Initial Catalog=ROYALPLAZA;Integrated Security=True";
                    String Query = "INSERT INTO CheckIn(codReserva, status, idHospedePJ, dataChegada, codCheckIn) VALUES('" + Reserva + "', 'True' , '" + idHospedePJ + "','" + dataFormated + "','" + CheckIn + "')";
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
                }
            }
                
            txtReserva.Text = "";
            txtCheckIn.Text = "";
            txtIdHospedePF.Text = "";
            txtIdHospedePJ.Text = "";
        }
    }
}
