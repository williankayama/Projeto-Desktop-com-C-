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
    public partial class FrmEditarFunc : Form
    {
        public FrmEditarFunc()
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
            String Query = "UPDATE Funcionario SET cpf = '" + CPF +
                "', ctps = '" + CTPS +
                "', cargoFuncionario = '" + CargoFunc +
                "', nivelAcesso = '" + NivelAcesso +
                "', dataAdmissao = '" + dtAdmissao +
                "', nome = '" + nome +
                "', telefone = '" + Telefone +
                "', email = '" + Email +
                "', cep = '" + Cep +
                "', numero = '" + Numero +
                "', logradouro = '" + Logradouro +
                "', uf = '" + Uf +
                "', bairro = '" + Bairro +
                "', complemento = '" + Complemento +
                "', cidade = '" + Cidade +
                "' WHERE idFuncionario = '" + IdFunc + "'";
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
    }
}
