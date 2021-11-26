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
    public partial class FrmEditarCheckIn : Form
    {
        public FrmEditarCheckIn()
        {
            InitializeComponent();
        }
        private void btUpdate_Click(object sender, EventArgs e)
        {
            String updateCodReserva = txtEditarCodReserva.Text;
            String dataUpdate = dtEditarData.Value.ToString("yyyy-MM-dd");
            String idHospedePF = txtIdHospedePF.Text;
            String idHospedePJ = txtIdHospedePJ.Text;
            String CodCheckin = txtEditarCheckIn.Text;
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
                MessageBox.Show("Preencha somente Id do Hospede PF ou Id do Hospede PJ");
            }
            else
            {
                if (idHospedePF != "" && idHospedePF != null)
                {
                    String strConexao = @"Data Source=BR-IT00230;Initial Catalog=ROYALPLAZA;Integrated Security=True";
                    String query = "UPDATE CheckIn SET dataChegada = '" + dataUpdate +
                        "', idHospedePF = '" + idHospedePF +
                        "', codReserva = '" + updateCodReserva +
                        "', Status =" + statusEdited +
                        " WHERE CodCheckIn = '" + CodCheckin + "'";
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
                if (idHospedePJ != "" && idHospedePJ != null)
                {
                    String strConexao = @"Data Source=BR-IT00230;Initial Catalog=ROYALPLAZA;Integrated Security=True";
                    String query = "UPDATE CheckIn SET dataChegada = '" + dataUpdate +
                        "', idHospedePJ = '" + idHospedePJ +
                        "', codReserva = '" + updateCodReserva +
                        "', Status =" + statusEdited +
                        " WHERE CodCheckIn = '" + CodCheckin + "'";
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
            txtEditarCodReserva.Text = "";
            txtEditarCheckIn.Text = "";
            txtIdHospedePF.Text = "";
            txtIdHospedePJ.Text = "";
            chkStatus.Checked = false;
        }
    }
}
