
namespace PIM
{
    partial class FrmEditarQuartos
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtAndar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTelefoneQuarto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdTipoQuarto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumQuarto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCodReserva = new System.Windows.Forms.TextBox();
            this.chkDisponibilidade = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(168, 219);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 41);
            this.button1.TabIndex = 17;
            this.button1.Text = "Editar Quarto";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtAndar
            // 
            this.txtAndar.Location = new System.Drawing.Point(136, 128);
            this.txtAndar.Name = "txtAndar";
            this.txtAndar.Size = new System.Drawing.Size(148, 20);
            this.txtAndar.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Andar";
            // 
            // txtTelefoneQuarto
            // 
            this.txtTelefoneQuarto.Location = new System.Drawing.Point(136, 91);
            this.txtTelefoneQuarto.Name = "txtTelefoneQuarto";
            this.txtTelefoneQuarto.Size = new System.Drawing.Size(148, 20);
            this.txtTelefoneQuarto.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Telefone do quarto";
            // 
            // txtIdTipoQuarto
            // 
            this.txtIdTipoQuarto.Location = new System.Drawing.Point(136, 53);
            this.txtIdTipoQuarto.Name = "txtIdTipoQuarto";
            this.txtIdTipoQuarto.Size = new System.Drawing.Size(148, 20);
            this.txtIdTipoQuarto.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Id do tipo de quarto";
            // 
            // txtNumQuarto
            // 
            this.txtNumQuarto.Location = new System.Drawing.Point(136, 25);
            this.txtNumQuarto.Name = "txtNumQuarto";
            this.txtNumQuarto.Size = new System.Drawing.Size(148, 20);
            this.txtNumQuarto.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Numero do quarto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Codigo da Reserva";
            // 
            // txtCodReserva
            // 
            this.txtCodReserva.Location = new System.Drawing.Point(136, 163);
            this.txtCodReserva.Name = "txtCodReserva";
            this.txtCodReserva.Size = new System.Drawing.Size(148, 20);
            this.txtCodReserva.TabIndex = 19;
            // 
            // chkDisponibilidade
            // 
            this.chkDisponibilidade.AutoSize = true;
            this.chkDisponibilidade.Location = new System.Drawing.Point(34, 232);
            this.chkDisponibilidade.Name = "chkDisponibilidade";
            this.chkDisponibilidade.Size = new System.Drawing.Size(70, 17);
            this.chkDisponibilidade.TabIndex = 21;
            this.chkDisponibilidade.Text = "Ocupado";
            this.chkDisponibilidade.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkDisponibilidade);
            this.groupBox1.Controls.Add(this.txtCodReserva);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtAndar);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtTelefoneQuarto);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtIdTipoQuarto);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNumQuarto);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(2, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(349, 286);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Editar Quartos";
            // 
            // FrmEditarQuartos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 288);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmEditarQuartos";
            this.Text = "FrmEditarQuartos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtAndar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTelefoneQuarto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIdTipoQuarto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumQuarto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCodReserva;
        private System.Windows.Forms.CheckBox chkDisponibilidade;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}