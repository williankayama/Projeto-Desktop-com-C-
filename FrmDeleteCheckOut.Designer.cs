
namespace PIM
{
    partial class FrmDeleteCheckOut
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
            this.btDelete = new System.Windows.Forms.Button();
            this.txtCheckOut = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btDelete);
            this.groupBox1.Controls.Add(this.txtCheckOut);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(249, 152);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Deletar CheckOut";
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(46, 98);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(159, 40);
            this.btDelete.TabIndex = 2;
            this.btDelete.Text = "Excluir";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // txtCheckOut
            // 
            this.txtCheckOut.Location = new System.Drawing.Point(71, 53);
            this.txtCheckOut.Name = "txtCheckOut";
            this.txtCheckOut.Size = new System.Drawing.Size(100, 20);
            this.txtCheckOut.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Insira o Código do CheckOut que deseja excluir:";
            // 
            // FrmDeleteCheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 153);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmDeleteCheckOut";
            this.Text = "FrmDeleteCheckOut";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCheckOut;
        private System.Windows.Forms.Button btDelete;
    }
}