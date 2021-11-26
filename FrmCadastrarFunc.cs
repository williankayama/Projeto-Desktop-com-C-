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
    public partial class FrmCadastrarFunc : Form
    {
        public FrmCadastrarFunc()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String IdFunc = txtIdFuncionario.Text;
            String CPF = txtCPF.Text;
            String CTPS = txtCTPS.Text;
            String CargoFunc = txtCargoFunc.Text;
            String NivelAcesso = txtNivelAcesso.Text;
            String dtAdmissao = dataAdmissao.Value.ToString("yyyy-MM-dd");
            String nome = txtNome.Text;
            String Telefone = txtTelefone.Text;
            String Email = txtEmail.Text;
            String Cep = txtCEP.Text;
            String Numero = txtNumero.Text;
            String Logradouro = txtLogradouro.Text;
            String Uf = txtUF.Text;
            String Bairro = txtBairro.Text;
            String Complemento = txtComplemento.Text;
            String Cidade = txtCidade.Text;


            String strConexao = @"Data Source=BR-IT00230;Initial Catalog=ROYALPLAZA;Integrated Security=True";
            String Query = "INSERT INTO Funcionario(idFuncionario, cpf, ctps, cargoFuncionario, nivelAcesso, dataAdmissao, nome, telefone, email, cep, numero, logradouro, uf, bairro, complemento, cidade ) VALUES('" + IdFunc + "','" + CPF + "','" + CTPS + "','" + CargoFunc + "','" + NivelAcesso + "','" + dtAdmissao + "','" + nome + "','" + Telefone + "','" + Email + "','" + Cep + "','" + Numero + "','" + Logradouro + "','" + Uf + "','" + Bairro + "','" + Complemento + "','" + Cidade + "')";
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
            txtIdFuncionario.Text = "";
            txtCPF.Text = "";
            txtCTPS.Text = "";
            txtCargoFunc.Text = "";
            txtNivelAcesso.Text = "";
            txtNome.Text = "";
            txtTelefone.Text = "";
            txtEmail.Text = "";
            txtCEP.Text = "";
            txtNumero.Text = "";
            txtLogradouro.Text = "";
            txtUF.Text = "";
            txtBairro.Text = "";
            txtComplemento.Text = "";
            txtCidade.Text = "";           
        }

        private void txtCidade_TextChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void txtComplemento_TextChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void txtBairro_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void txtUF_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void txtLogradouro_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void txtCEP_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txtTelefone_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dataAdmissao_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtNivelAcesso_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtCargoFunc_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtCTPS_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtCPF_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtIdFuncionario_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
