
namespace PIM
{
    partial class FrmRegistrarCheckIn
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdHospedePF = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCheckIn = new System.Windows.Forms.TextBox();
            this.txtReserva = new System.Windows.Forms.TextBox();
            this.btRegistrar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtCheckIn = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIdHospedePJ = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Data";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Id do Hospede PF";
            // 
            // txtIdHospedePF
            // 
            this.txtIdHospedePF.Location = new System.Drawing.Point(130, 55);
            this.txtIdHospedePF.Name = "txtIdHospedePF";
            this.txtIdHospedePF.Size = new System.Drawing.Size(193, 20);
            this.txtIdHospedePF.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtIdHospedePJ);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtCheckIn);
            this.groupBox1.Controls.Add(this.txtReserva);
            this.groupBox1.Controls.Add(this.btRegistrar);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtCheckIn);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtIdHospedePF);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(409, 257);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados de Check-In";
            // 
            // txtCheckIn
            // 
            this.txtCheckIn.Location = new System.Drawing.Point(95, 140);
            this.txtCheckIn.Name = "txtCheckIn";
            this.txtCheckIn.Size = new System.Drawing.Size(67, 20);
            this.txtCheckIn.TabIndex = 12;
            // 
            // txtReserva
            // 
            this.txtReserva.Location = new System.Drawing.Point(95, 114);
            this.txtReserva.Name = "txtReserva";
            this.txtReserva.Size = new System.Drawing.Size(67, 20);
            this.txtReserva.TabIndex = 11;
            // 
            // btRegistrar
            // 
            this.btRegistrar.Location = new System.Drawing.Point(20, 200);
            this.btRegistrar.Name = "btRegistrar";
            this.btRegistrar.Size = new System.Drawing.Size(163, 23);
            this.btRegistrar.TabIndex = 10;
            this.btRegistrar.Text = "Registrar Check-In";
            this.btRegistrar.UseVisualStyleBackColor = true;
            this.btRegistrar.Click += new System.EventHandler(this.btRegistrar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Cod. Check-In";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Cod. Reserva";
            // 
            // dtCheckIn
            // 
            this.dtCheckIn.Location = new System.Drawing.Point(53, 22);
            this.dtCheckIn.Name = "dtCheckIn";
            this.dtCheckIn.Size = new System.Drawing.Size(257, 20);
            this.dtCheckIn.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Id do Hospede PJ";
            // 
            // txtIdHospedePJ
            // 
            this.txtIdHospedePJ.Location = new System.Drawing.Point(126, 87);
            this.txtIdHospedePJ.Name = "txtIdHospedePJ";
            this.txtIdHospedePJ.Size = new System.Drawing.Size(196, 20);
            this.txtIdHospedePJ.TabIndex = 14;
            // 
            // FrmRegistrarCheckIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 283);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmRegistrarCheckIn";
            this.Text = "Check-In";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIdHospedePF;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtCheckIn;
        private System.Windows.Forms.TextBox txtCheckIn;
        private System.Windows.Forms.TextBox txtReserva;
        private System.Windows.Forms.Button btRegistrar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIdHospedePJ;
        private System.Windows.Forms.Label label5;
    }
}