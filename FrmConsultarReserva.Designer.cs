
namespace PIM
{
    partial class FrmConsultarReserva
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btMain = new System.Windows.Forms.Button();
            this.tabelaReserva = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaReserva)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btMain);
            this.groupBox1.Controls.Add(this.tabelaReserva);
            this.groupBox1.Location = new System.Drawing.Point(8, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(786, 439);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consultar Reservas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(335, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Consultar Reservas";
            // 
            // btMain
            // 
            this.btMain.Location = new System.Drawing.Point(338, 375);
            this.btMain.Name = "btMain";
            this.btMain.Size = new System.Drawing.Size(94, 23);
            this.btMain.TabIndex = 11;
            this.btMain.Text = "Consultar";
            this.btMain.UseVisualStyleBackColor = true;
            this.btMain.Click += new System.EventHandler(this.btMain_Click);
            // 
            // tabelaReserva
            // 
            this.tabelaReserva.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tabelaReserva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelaReserva.Location = new System.Drawing.Point(26, 42);
            this.tabelaReserva.Name = "tabelaReserva";
            this.tabelaReserva.Size = new System.Drawing.Size(741, 327);
            this.tabelaReserva.TabIndex = 10;
            // 
            // FrmConsultarReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmConsultarReserva";
            this.Text = "FrmConsultarReserva";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaReserva)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btMain;
        private System.Windows.Forms.DataGridView tabelaReserva;
    }
}