
namespace PIM
{
    partial class FrmDeleteCheckIn
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
            this.txtDelete = new System.Windows.Forms.TextBox();
            this.btDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Insira o Código do Check-In que deseja excluir:";
            // 
            // txtDelete
            // 
            this.txtDelete.Location = new System.Drawing.Point(81, 31);
            this.txtDelete.Name = "txtDelete";
            this.txtDelete.Size = new System.Drawing.Size(81, 20);
            this.txtDelete.TabIndex = 1;
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(53, 63);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(136, 59);
            this.btDelete.TabIndex = 2;
            this.btDelete.Text = "Excluir Check-In";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // FrmDeleteCheckIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 134);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.txtDelete);
            this.Controls.Add(this.label1);
            this.Name = "FrmDeleteCheckIn";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDelete;
        private System.Windows.Forms.Button btDelete;
    }
}