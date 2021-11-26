
namespace PIM
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trocarDeUsuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarFuncionárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirFuncionárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarFuncionárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quartoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarCheckInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarCheckInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirCheckInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarCheckOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarCheckOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirCheckOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirReservaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarReservasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarReservaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.criarReservaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataTabelaPrincipal = new System.Windows.Forms.DataGridView();
            this.btMain = new System.Windows.Forms.Button();
            this.criarQuartosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirQuartosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarQuartosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarCheckInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarCheckOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarFuncionárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTabelaPrincipal)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.cadastroToolStripMenuItem,
            this.quartoToolStripMenuItem,
            this.reservaToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(558, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trocarDeUsuárioToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // trocarDeUsuárioToolStripMenuItem
            // 
            this.trocarDeUsuárioToolStripMenuItem.Name = "trocarDeUsuárioToolStripMenuItem";
            this.trocarDeUsuárioToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.trocarDeUsuárioToolStripMenuItem.Text = "Trocar de usuário";
            this.trocarDeUsuárioToolStripMenuItem.Click += new System.EventHandler(this.trocarDeUsuárioToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarFuncionárioToolStripMenuItem,
            this.excluirFuncionárioToolStripMenuItem,
            this.editarFuncionárioToolStripMenuItem,
            this.consultarFuncionárioToolStripMenuItem});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // cadastrarFuncionárioToolStripMenuItem
            // 
            this.cadastrarFuncionárioToolStripMenuItem.Name = "cadastrarFuncionárioToolStripMenuItem";
            this.cadastrarFuncionárioToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.cadastrarFuncionárioToolStripMenuItem.Text = "Cadastrar Funcionário";
            this.cadastrarFuncionárioToolStripMenuItem.Click += new System.EventHandler(this.cadastrarFuncionárioToolStripMenuItem_Click);
            // 
            // excluirFuncionárioToolStripMenuItem
            // 
            this.excluirFuncionárioToolStripMenuItem.Name = "excluirFuncionárioToolStripMenuItem";
            this.excluirFuncionárioToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.excluirFuncionárioToolStripMenuItem.Text = "Excluir Funcionário";
            this.excluirFuncionárioToolStripMenuItem.Click += new System.EventHandler(this.excluirFuncionárioToolStripMenuItem_Click);
            // 
            // editarFuncionárioToolStripMenuItem
            // 
            this.editarFuncionárioToolStripMenuItem.Name = "editarFuncionárioToolStripMenuItem";
            this.editarFuncionárioToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.editarFuncionárioToolStripMenuItem.Text = "Editar Funcionário";
            this.editarFuncionárioToolStripMenuItem.Click += new System.EventHandler(this.editarFuncionárioToolStripMenuItem_Click);
            // 
            // quartoToolStripMenuItem
            // 
            this.quartoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.criarQuartosToolStripMenuItem,
            this.excluirQuartosToolStripMenuItem,
            this.editarQuartosToolStripMenuItem});
            this.quartoToolStripMenuItem.Name = "quartoToolStripMenuItem";
            this.quartoToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.quartoToolStripMenuItem.Text = "Quarto";
            // 
            // reservaToolStripMenuItem
            // 
            this.reservaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkInToolStripMenuItem,
            this.checkOutToolStripMenuItem,
            this.excluirReservaToolStripMenuItem,
            this.consultarReservasToolStripMenuItem,
            this.editarReservaToolStripMenuItem,
            this.criarReservaToolStripMenuItem});
            this.reservaToolStripMenuItem.Name = "reservaToolStripMenuItem";
            this.reservaToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.reservaToolStripMenuItem.Text = "Reserva";
            // 
            // checkInToolStripMenuItem
            // 
            this.checkInToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarCheckInToolStripMenuItem,
            this.editarCheckInToolStripMenuItem,
            this.excluirCheckInToolStripMenuItem,
            this.consultarCheckInToolStripMenuItem});
            this.checkInToolStripMenuItem.Name = "checkInToolStripMenuItem";
            this.checkInToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.checkInToolStripMenuItem.Text = "Check-In";
            // 
            // registrarCheckInToolStripMenuItem
            // 
            this.registrarCheckInToolStripMenuItem.Name = "registrarCheckInToolStripMenuItem";
            this.registrarCheckInToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.registrarCheckInToolStripMenuItem.Text = "Registrar Check-In";
            this.registrarCheckInToolStripMenuItem.Click += new System.EventHandler(this.registrarCheckInToolStripMenuItem_Click);
            // 
            // editarCheckInToolStripMenuItem
            // 
            this.editarCheckInToolStripMenuItem.Name = "editarCheckInToolStripMenuItem";
            this.editarCheckInToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.editarCheckInToolStripMenuItem.Text = "Editar Check-In";
            this.editarCheckInToolStripMenuItem.Click += new System.EventHandler(this.editarCheckInToolStripMenuItem_Click);
            // 
            // excluirCheckInToolStripMenuItem
            // 
            this.excluirCheckInToolStripMenuItem.Name = "excluirCheckInToolStripMenuItem";
            this.excluirCheckInToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.excluirCheckInToolStripMenuItem.Text = "Excluir Check-In";
            this.excluirCheckInToolStripMenuItem.Click += new System.EventHandler(this.excluirCheckInToolStripMenuItem_Click);
            // 
            // checkOutToolStripMenuItem
            // 
            this.checkOutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarCheckOutToolStripMenuItem,
            this.editarCheckOutToolStripMenuItem,
            this.excluirCheckOutToolStripMenuItem,
            this.consultarCheckOutToolStripMenuItem});
            this.checkOutToolStripMenuItem.Name = "checkOutToolStripMenuItem";
            this.checkOutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.checkOutToolStripMenuItem.Text = "Check-Out";
            // 
            // registrarCheckOutToolStripMenuItem
            // 
            this.registrarCheckOutToolStripMenuItem.Name = "registrarCheckOutToolStripMenuItem";
            this.registrarCheckOutToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.registrarCheckOutToolStripMenuItem.Text = "Registrar Check-Out";
            this.registrarCheckOutToolStripMenuItem.Click += new System.EventHandler(this.registrarCheckOutToolStripMenuItem_Click);
            // 
            // editarCheckOutToolStripMenuItem
            // 
            this.editarCheckOutToolStripMenuItem.Name = "editarCheckOutToolStripMenuItem";
            this.editarCheckOutToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.editarCheckOutToolStripMenuItem.Text = "Editar Check-Out";
            this.editarCheckOutToolStripMenuItem.Click += new System.EventHandler(this.editarCheckOutToolStripMenuItem_Click);
            // 
            // excluirCheckOutToolStripMenuItem
            // 
            this.excluirCheckOutToolStripMenuItem.Name = "excluirCheckOutToolStripMenuItem";
            this.excluirCheckOutToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.excluirCheckOutToolStripMenuItem.Text = "Excluir Check-Out";
            this.excluirCheckOutToolStripMenuItem.Click += new System.EventHandler(this.excluirCheckOutToolStripMenuItem_Click);
            // 
            // excluirReservaToolStripMenuItem
            // 
            this.excluirReservaToolStripMenuItem.Name = "excluirReservaToolStripMenuItem";
            this.excluirReservaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.excluirReservaToolStripMenuItem.Text = "Excluir reserva";
            this.excluirReservaToolStripMenuItem.Click += new System.EventHandler(this.excluirReservaToolStripMenuItem_Click);
            // 
            // consultarReservasToolStripMenuItem
            // 
            this.consultarReservasToolStripMenuItem.Name = "consultarReservasToolStripMenuItem";
            this.consultarReservasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.consultarReservasToolStripMenuItem.Text = "Consultar reserva";
            this.consultarReservasToolStripMenuItem.Click += new System.EventHandler(this.consultarReservasToolStripMenuItem_Click);
            // 
            // editarReservaToolStripMenuItem
            // 
            this.editarReservaToolStripMenuItem.Name = "editarReservaToolStripMenuItem";
            this.editarReservaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editarReservaToolStripMenuItem.Text = "Editar reserva";
            this.editarReservaToolStripMenuItem.Click += new System.EventHandler(this.editarReservaToolStripMenuItem_Click);
            // 
            // criarReservaToolStripMenuItem
            // 
            this.criarReservaToolStripMenuItem.Name = "criarReservaToolStripMenuItem";
            this.criarReservaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.criarReservaToolStripMenuItem.Text = "Criar Reserva";
            this.criarReservaToolStripMenuItem.Click += new System.EventHandler(this.criarReservaToolStripMenuItem_Click);
            // 
            // dataTabelaPrincipal
            // 
            this.dataTabelaPrincipal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataTabelaPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTabelaPrincipal.Location = new System.Drawing.Point(12, 38);
            this.dataTabelaPrincipal.Name = "dataTabelaPrincipal";
            this.dataTabelaPrincipal.Size = new System.Drawing.Size(534, 246);
            this.dataTabelaPrincipal.TabIndex = 2;
            // 
            // btMain
            // 
            this.btMain.Location = new System.Drawing.Point(241, 290);
            this.btMain.Name = "btMain";
            this.btMain.Size = new System.Drawing.Size(75, 23);
            this.btMain.TabIndex = 3;
            this.btMain.Text = "Consultar";
            this.btMain.UseVisualStyleBackColor = true;
            this.btMain.Click += new System.EventHandler(this.btMain_Click);
            // 
            // criarQuartosToolStripMenuItem
            // 
            this.criarQuartosToolStripMenuItem.Name = "criarQuartosToolStripMenuItem";
            this.criarQuartosToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.criarQuartosToolStripMenuItem.Text = "Criar quartos";
            this.criarQuartosToolStripMenuItem.Click += new System.EventHandler(this.criarQuartosToolStripMenuItem_Click);
            // 
            // excluirQuartosToolStripMenuItem
            // 
            this.excluirQuartosToolStripMenuItem.Name = "excluirQuartosToolStripMenuItem";
            this.excluirQuartosToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.excluirQuartosToolStripMenuItem.Text = "Excluir quartos";
            this.excluirQuartosToolStripMenuItem.Click += new System.EventHandler(this.excluirQuartosToolStripMenuItem_Click);
            // 
            // editarQuartosToolStripMenuItem
            // 
            this.editarQuartosToolStripMenuItem.Name = "editarQuartosToolStripMenuItem";
            this.editarQuartosToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.editarQuartosToolStripMenuItem.Text = "Editar quartos";
            this.editarQuartosToolStripMenuItem.Click += new System.EventHandler(this.editarQuartosToolStripMenuItem_Click);
            // 
            // consultarCheckInToolStripMenuItem
            // 
            this.consultarCheckInToolStripMenuItem.Name = "consultarCheckInToolStripMenuItem";
            this.consultarCheckInToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.consultarCheckInToolStripMenuItem.Text = "Consultar Check-In";
            this.consultarCheckInToolStripMenuItem.Click += new System.EventHandler(this.consultarCheckInToolStripMenuItem_Click);
            // 
            // consultarCheckOutToolStripMenuItem
            // 
            this.consultarCheckOutToolStripMenuItem.Name = "consultarCheckOutToolStripMenuItem";
            this.consultarCheckOutToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.consultarCheckOutToolStripMenuItem.Text = "Consultar Check-Out";
            this.consultarCheckOutToolStripMenuItem.Click += new System.EventHandler(this.consultarCheckOutToolStripMenuItem_Click);
            // 
            // consultarFuncionárioToolStripMenuItem
            // 
            this.consultarFuncionárioToolStripMenuItem.Name = "consultarFuncionárioToolStripMenuItem";
            this.consultarFuncionárioToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.consultarFuncionárioToolStripMenuItem.Text = "Consultar Funcionário";
            this.consultarFuncionárioToolStripMenuItem.Click += new System.EventHandler(this.consultarFuncionárioToolStripMenuItem_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 335);
            this.Controls.Add(this.btMain);
            this.Controls.Add(this.dataTabelaPrincipal);
            this.Controls.Add(this.menuStrip2);
            this.Name = "FrmPrincipal";
            this.Text = "Form1";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTabelaPrincipal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarFuncionárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excluirFuncionárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarFuncionárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quartoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reservaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarCheckInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarCheckInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excluirCheckInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarCheckOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarCheckOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excluirCheckOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excluirReservaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarReservasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarReservaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trocarDeUsuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataTabelaPrincipal;
        private System.Windows.Forms.Button btMain;
        private System.Windows.Forms.ToolStripMenuItem criarReservaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem criarQuartosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excluirQuartosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarQuartosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarCheckInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarCheckOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarFuncionárioToolStripMenuItem;
    }
}

