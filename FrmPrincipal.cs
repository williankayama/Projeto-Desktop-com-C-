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
    public partial class FrmPrincipal : Form
    {
        public Form JanLogin = null;
        public FrmPrincipal()
        {
            InitializeComponent();
        }
        private void registrarCheckInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRegistrarCheckIn paginaRegistrarCheckIn = new FrmRegistrarCheckIn();
            paginaRegistrarCheckIn.Show();
        }

        private void btMain_Click(object sender, EventArgs e)
        {
            String strConexao = @"Data Source=BR-IT00230;Initial Catalog=ROYALPLAZA;Integrated Security=True";
            String query = "SELECT numQuarto, codReserva, idTipoQuarto, telefoneQuarto, andar, disponibilidade FROM Quarto";

            SqlConnection conexao = new SqlConnection(strConexao);
            SqlDataAdapter da = new SqlDataAdapter(query, strConexao);

            DataTable Tabela = new DataTable();

            da.Fill(Tabela);
            dataTabelaPrincipal.DataSource = Tabela;
        }

        private void editarCheckInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEditarCheckIn paginaEditarCheckIn = new FrmEditarCheckIn();
            paginaEditarCheckIn.Show();
        }

        private void excluirCheckInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDeleteCheckIn paginaDeleteCheckIn = new FrmDeleteCheckIn();
            paginaDeleteCheckIn.Show();
       
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void editarCheckOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEditarCheckOut paginaEditarCheckOut = new FrmEditarCheckOut();
            paginaEditarCheckOut.Show();
        }

        private void registrarCheckOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRegistrarCheckOut paginaRegistrarCheckOut = new FrmRegistrarCheckOut();
            paginaRegistrarCheckOut.Show();
        }
        
        private void excluirCheckOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDeleteCheckOut paginaExcluirCheckOut = new FrmDeleteCheckOut();
            paginaExcluirCheckOut.Show();
        }

        private void excluirFuncionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDeleteFunc paginaDeleteFunc = new FrmDeleteFunc();
            paginaDeleteFunc.Show();
        }

        private void excluirReservaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDeleteReserva paginaDeleteReserva = new FrmDeleteReserva();
            paginaDeleteReserva.Show();
        }

        private void cadastrarFuncionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastrarFunc paginaCadastrarFunc = new FrmCadastrarFunc();
            paginaCadastrarFunc.Show();
        }

        private void trocarDeUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            FrmLogin paginaLogin = new FrmLogin();
            paginaLogin.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void editarFuncionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEditarFunc paginaEditarFunc = new FrmEditarFunc();
            paginaEditarFunc.Show();
        }

        private void criarReservaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastrarReserva paginaCadastrarReserva = new FrmCadastrarReserva();
            paginaCadastrarReserva.Show();
        }

        private void editarReservaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEditarReserva paginaEditarReserva = new FrmEditarReserva();
            paginaEditarReserva.Show();
        }

        private void criarQuartosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCriarQuartos paginaCriarQuartos = new FrmCriarQuartos();
            paginaCriarQuartos.Show();
        }

        private void editarQuartosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEditarQuartos paginaEditarQuartos = new FrmEditarQuartos();
            paginaEditarQuartos.Show();
        }

        private void excluirQuartosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDeleteQuarto paginaDeleteQuarto = new FrmDeleteQuarto();
            paginaDeleteQuarto.Show();
        }

        private void consultarCheckInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultarCheckIn paginaConsultarCheckIn = new FrmConsultarCheckIn();
            paginaConsultarCheckIn.Show();
        }

        private void consultarCheckOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultarCheckOut paginaConsultarCheckOut = new FrmConsultarCheckOut();
            paginaConsultarCheckOut.Show();
        }

        private void consultarReservasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultarReserva paginaConsultarReserva = new FrmConsultarReserva();
            paginaConsultarReserva.Show();
        }

        private void consultarFuncionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultarFunc paginaConsultarFunc = new FrmConsultarFunc();
            paginaConsultarFunc.Show();
        }
    }
}
