
namespace PIM
{
    partial class FrmConsultarFunc
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btMain = new System.Windows.Forms.Button();
            this.tabelaFuncionario = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaFuncionario)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(420, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Consultar Funcionarios";
            // 
            // btMain
            // 
            this.btMain.Location = new System.Drawing.Point(440, 493);
            this.btMain.Name = "btMain";
            this.btMain.Size = new System.Drawing.Size(94, 23);
            this.btMain.TabIndex = 14;
            this.btMain.Text = "Consultar";
            this.btMain.UseVisualStyleBackColor = true;
            this.btMain.Click += new System.EventHandler(this.btMain_Click);
            // 
            // tabelaFuncionario
            // 
            this.tabelaFuncionario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tabelaFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelaFuncionario.Location = new System.Drawing.Point(25, 45);
            this.tabelaFuncionario.Name = "tabelaFuncionario";
            this.tabelaFuncionario.Size = new System.Drawing.Size(971, 442);
            this.tabelaFuncionario.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btMain);
            this.groupBox1.Controls.Add(this.tabelaFuncionario);
            this.groupBox1.Location = new System.Drawing.Point(5, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1002, 532);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consultar Funcionarios";
            // 
            // FrmConsultarFunc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 554);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmConsultarFunc";
            this.Text = "FrmConsultarFunc";
            ((System.ComponentModel.ISupportInitialize)(this.tabelaFuncionario)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btMain;
        private System.Windows.Forms.DataGridView tabelaFuncionario;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}