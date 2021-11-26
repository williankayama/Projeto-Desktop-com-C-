
namespace PIM
{
    partial class FrmConsultarCheckOut
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
            this.tabelaCheckOut = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaCheckOut)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(307, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Consultar Check-Out";
            // 
            // btMain
            // 
            this.btMain.Location = new System.Drawing.Point(310, 333);
            this.btMain.Name = "btMain";
            this.btMain.Size = new System.Drawing.Size(94, 23);
            this.btMain.TabIndex = 8;
            this.btMain.Text = "Consultar";
            this.btMain.UseVisualStyleBackColor = true;
            this.btMain.Click += new System.EventHandler(this.btMain_Click);
            // 
            // tabelaCheckOut
            // 
            this.tabelaCheckOut.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tabelaCheckOut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelaCheckOut.Location = new System.Drawing.Point(6, 51);
            this.tabelaCheckOut.Name = "tabelaCheckOut";
            this.tabelaCheckOut.Size = new System.Drawing.Size(704, 276);
            this.tabelaCheckOut.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btMain);
            this.groupBox1.Controls.Add(this.tabelaCheckOut);
            this.groupBox1.Location = new System.Drawing.Point(7, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(718, 373);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consulta de Check-Out";
            // 
            // FrmConsultarCheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 389);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmConsultarCheckOut";
            this.Text = "FrmConsultarCheckOut";
            ((System.ComponentModel.ISupportInitialize)(this.tabelaCheckOut)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btMain;
        private System.Windows.Forms.DataGridView tabelaCheckOut;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}