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
    public partial class FrmConsultarFunc : Form
    {
        public FrmConsultarFunc()
        {
            InitializeComponent();
        }

        private void btMain_Click(object sender, EventArgs e)
        {
            String strConexao = @"Data Source=BR-IT00230;Initial Catalog=ROYALPLAZA;Integrated Security=True";
            String query = "SELECT idFuncionario, cpf, ctps, cargoFuncionario, nivelAcesso, dataAdmissao, nome, telefone, email, cep, numero, logradouro, uf, bairro, complemento, cidade FROM Funcionario";

            SqlConnection conexao = new SqlConnection(strConexao);
            SqlDataAdapter da = new SqlDataAdapter(query, strConexao);

            DataTable Tabela = new DataTable();

            da.Fill(Tabela);
            tabelaFuncionario.DataSource = Tabela;
        }
    }
}
