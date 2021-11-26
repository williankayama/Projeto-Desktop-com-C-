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
    public partial class FrmEditarCheckOut : Form
    {
        public FrmEditarCheckOut()
        {
            InitializeComponent();
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {

            String updateCodReserva = txtReserva.Text;
            String dataUpdate = dtCheckOut.Value.ToString("yyyy-MM-dd");
            String CodCheckOut = txtCheckOut.Text;
            String idHospedePF = txtIdHospedePF.Text;
            String idHospedePJ = txtIdHospedePJ.Text;
            String idPagamento = txtIdPagamento.Text;
            String valorFinal = txtValorFinal.Text;
            int statusEdited;

            if (chkStatus.Checked)
            {
                statusEdited = 1;
            }
            else
            {
                statusEdited = 0;
            }

            if (idHospedePF != "" && idHospedePF != null && idHospedePJ != "" && idHospedePJ != null)
            {
                MessageBox.Show("Preencha somente um campo de Hospede!");
            }
            else
            {
                if (idHospedePF != "" && idHospedePF != null)
                {
                    String strConexao = @"Data Source=BR-IT00230;Initial Catalog=ROYALPLAZA;Integrated Security=True";
                    String query = "UPDATE CheckOut SET dataSaida = '" + dataUpdate +
                        "', idHospedePF = '" + idHospedePF +
                        "', idPagamento = '" + idPagamento +
                        "', valorFinal = '" + valorFinal +
                        "', codReserva = '" + updateCodReserva +
                        "', Status =" + statusEdited +
                        " WHERE CodCheckOut = '" + CodCheckOut + "'";
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

                    txtReserva.Text = "";
                    txtCheckOut.Text = "";
                    txtIdHospedePF.Text = "";
                    txtIdHospedePJ.Text = "";
                    txtIdPagamento.Text = "";
                    txtValorFinal.Text = "";
                    chkStatus.Checked = false;
                }
                if (idHospedePJ != "" && idHospedePJ != null)
                {
                    String strConexao = @"Data Source=BR-IT00230;Initial Catalog=ROYALPLAZA;Integrated Security=True";
                    String query = "UPDATE CheckOut SET dataSaida = '" + dataUpdate +
                        "', idHospedePJ = '" + idHospedePJ +
                        "', idPagamento = '" + idPagamento +
                        "', valorFinal = '" + valorFinal +
                        "', codReserva = '" + updateCodReserva +
                        "', Status =" + statusEdited +
                        " WHERE CodCheckOut = '" + CodCheckOut + "'";
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

                    txtReserva.Text = "";
                    txtCheckOut.Text = "";
                    txtIdHospedePF.Text = "";
                    txtIdHospedePJ.Text = "";
                    txtIdPagamento.Text = "";
                    txtValorFinal.Text = "";
                    chkStatus.Checked = false;
                }
            }
        }
    }
}
