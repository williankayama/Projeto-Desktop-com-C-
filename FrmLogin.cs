using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIM
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btEntrar_Click(object sender, EventArgs e)
        {
            String proveLogin = txtLogin.Text;
            String proveSenha = txtSenha.Text;

            Login login = new Login();

            if (login.LoginUsr(proveLogin, proveSenha))
            {
                this.Visible = false;
                FrmPrincipal principal = new FrmPrincipal();
                principal.JanLogin = this;
                principal.Show();
            }
            else
            {
                MessageBox.Show("Dados Invalidos",
                    "Aviso", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
