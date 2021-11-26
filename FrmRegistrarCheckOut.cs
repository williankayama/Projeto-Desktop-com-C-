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
    public partial class FrmRegistrarCheckOut : Form
    {
        public FrmRegistrarCheckOut()
        {
            InitializeComponent();
        }

        private GroupBox groupBox1;
        private Label label1;
        private TextBox txtCheckOut;

        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btRegistrarCheckOut = new System.Windows.Forms.Button();
            this.txtIdHospedePF = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtCheckOut = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtReserva = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCheckOut = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIdHospedePJ = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIdPagamento = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtValorFinal = new System.Windows.Forms.TextBox();
            this.chkStatus = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkStatus);
            this.groupBox1.Controls.Add(this.txtValorFinal);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtIdPagamento);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtIdHospedePJ);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btRegistrarCheckOut);
            this.groupBox1.Controls.Add(this.txtIdHospedePF);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtCheckOut);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtReserva);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtCheckOut);
            this.groupBox1.Location = new System.Drawing.Point(1, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(456, 325);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados de CheckOut";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btRegistrarCheckOut
            // 
            this.btRegistrarCheckOut.Location = new System.Drawing.Point(308, 283);
            this.btRegistrarCheckOut.Name = "btRegistrarCheckOut";
            this.btRegistrarCheckOut.Size = new System.Drawing.Size(118, 23);
            this.btRegistrarCheckOut.TabIndex = 8;
            this.btRegistrarCheckOut.Text = "Registrar CheckOut";
            this.btRegistrarCheckOut.UseVisualStyleBackColor = true;
            this.btRegistrarCheckOut.Click += new System.EventHandler(this.btRegistrarCheckOut_Click);
            // 
            // txtIdHospedePF
            // 
            this.txtIdHospedePF.Location = new System.Drawing.Point(105, 140);
            this.txtIdHospedePF.Name = "txtIdHospedePF";
            this.txtIdHospedePF.Size = new System.Drawing.Size(138, 20);
            this.txtIdHospedePF.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Id do Hospede PF";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Data CheckOut";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dtCheckOut
            // 
            this.dtCheckOut.Location = new System.Drawing.Point(92, 105);
            this.dtCheckOut.Name = "dtCheckOut";
            this.dtCheckOut.Size = new System.Drawing.Size(227, 20);
            this.dtCheckOut.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cod. Reserva";
            // 
            // txtReserva
            // 
            this.txtReserva.Location = new System.Drawing.Point(92, 68);
            this.txtReserva.Name = "txtReserva";
            this.txtReserva.Size = new System.Drawing.Size(139, 20);
            this.txtReserva.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cod. CheckOut";
            // 
            // txtCheckOut
            // 
            this.txtCheckOut.Location = new System.Drawing.Point(92, 35);
            this.txtCheckOut.Name = "txtCheckOut";
            this.txtCheckOut.Size = new System.Drawing.Size(140, 20);
            this.txtCheckOut.TabIndex = 0;
            this.txtCheckOut.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Id do Hospede PJ";
            // 
            // txtIdHospedePJ
            // 
            this.txtIdHospedePJ.Location = new System.Drawing.Point(103, 171);
            this.txtIdHospedePJ.Name = "txtIdHospedePJ";
            this.txtIdHospedePJ.Size = new System.Drawing.Size(140, 20);
            this.txtIdHospedePJ.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Id do Pagamento";
            // 
            // txtIdPagamento
            // 
            this.txtIdPagamento.Location = new System.Drawing.Point(101, 203);
            this.txtIdPagamento.Name = "txtIdPagamento";
            this.txtIdPagamento.Size = new System.Drawing.Size(141, 20);
            this.txtIdPagamento.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 235);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Valor Final";
            // 
            // txtValorFinal
            // 
            this.txtValorFinal.Location = new System.Drawing.Point(101, 235);
            this.txtValorFinal.Name = "txtValorFinal";
            this.txtValorFinal.Size = new System.Drawing.Size(141, 20);
            this.txtValorFinal.TabIndex = 14;
            // 
            // chkStatus
            // 
            this.chkStatus.AutoSize = true;
            this.chkStatus.Location = new System.Drawing.Point(42, 283);
            this.chkStatus.Name = "chkStatus";
            this.chkStatus.Size = new System.Drawing.Size(56, 17);
            this.chkStatus.TabIndex = 15;
            this.chkStatus.Text = "Status";
            this.chkStatus.UseVisualStyleBackColor = true;
            // 
            // FrmRegistrarCheckOut
            // 
            this.ClientSize = new System.Drawing.Size(469, 337);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmRegistrarCheckOut";
            this.Text = "CheckOut";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private Label label3;
        private DateTimePicker dtCheckOut;
        private Label label2;
        private TextBox txtReserva;

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private Button btRegistrarCheckOut;
        private TextBox txtIdHospedePF;
        private Label label4;

        private void btRegistrarCheckOut_Click(object sender, EventArgs e)
        {
            String Reserva = txtReserva.Text;
            String CheckOut = txtCheckOut.Text;
            String dataFormated = dtCheckOut.Value.ToString("yyyy-MM-dd");
            String idHospedePF = txtIdHospedePF.Text;
            String idHospedePJ = txtIdHospedePJ.Text;
            String idPagamento = txtIdPagamento.Text;
            String valorFinal = txtValorFinal.Text;
            int statusCheckOut;

            if (chkStatus.Checked)
            {
                statusCheckOut = 1;
            }
            else
            {
                statusCheckOut = 0;
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
                    String Query = "INSERT INTO CheckOut(codReserva, idHospedePF, dataSaida, codCheckOut, idPagamento, valorFinal, Status) VALUES('" + Reserva + "','" + idHospedePF + "','" + dataFormated + "','" + CheckOut + "','" + idPagamento + "','" + valorFinal + "','" + statusCheckOut + "')";
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
                    String Query = "INSERT INTO CheckOut(codReserva,idHospedePJ, dataSaida, codCheckOut, idPagamento, valorFinal, Status) VALUES('" + Reserva + "','" + idHospedePJ + "','" + dataFormated + "','" + CheckOut + "','" + idPagamento + "','" + valorFinal + "','" + statusCheckOut + "')";
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
                    txtCheckOut.Text = "";
                    txtIdHospedePF.Text = "";
                    txtIdHospedePJ.Text = "";
                    txtIdPagamento.Text = "";
                    txtValorFinal.Text = "";
                    chkStatus.Checked = false;
                }
            }

        }

        private TextBox txtIdHospedePJ;
        private Label label5;
        private CheckBox chkStatus;
        private TextBox txtValorFinal;
        private Label label7;
        private TextBox txtIdPagamento;
        private Label label6;
    }
}