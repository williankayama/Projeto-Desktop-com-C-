
namespace PIM
{
    partial class FrmCriarQuartos
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
            this.txtNumQuarto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdTipoQuarto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTelefoneQuarto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAndar = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtAndar);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtTelefoneQuarto);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtIdTipoQuarto);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNumQuarto);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(329, 256);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero do quarto";
            // 
            // txtNumQuarto
            // 
            this.txtNumQuarto.Location = new System.Drawing.Point(117, 24);
            this.txtNumQuarto.Name = "txtNumQuarto";
            this.txtNumQuarto.Size = new System.Drawing.Size(149, 20);
            this.txtNumQuarto.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Id do tipo de quarto";
            // 
            // txtIdTipoQuarto
            // 
            this.txtIdTipoQuarto.Location = new System.Drawing.Point(118, 66);
            this.txtIdTipoQuarto.Name = "txtIdTipoQuarto";
            this.txtIdTipoQuarto.Size = new System.Drawing.Size(148, 20);
            this.txtIdTipoQuarto.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Telefone do quarto";
            // 
            // txtTelefoneQuarto
            // 
            this.txtTelefoneQuarto.Location = new System.Drawing.Point(118, 104);
            this.txtTelefoneQuarto.Name = "txtTelefoneQuarto";
            this.txtTelefoneQuarto.Size = new System.Drawing.Size(148, 20);
            this.txtTelefoneQuarto.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Andar";
            // 
            // txtAndar
            // 
            this.txtAndar.Location = new System.Drawing.Point(118, 141);
            this.txtAndar.Name = "txtAndar";
            this.txtAndar.Size = new System.Drawing.Size(148, 20);
            this.txtAndar.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(183, 193);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 41);
            this.button1.TabIndex = 8;
            this.button1.Text = "Criar Quarto";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmCriarQuartos1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 274);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmCriarQuartos1";
            this.Text = "FrmCriarQuartos1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtAndar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTelefoneQuarto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIdTipoQuarto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumQuarto;
        private System.Windows.Forms.Label label1;
    }
}