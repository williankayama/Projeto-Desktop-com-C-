
namespace PIM
{
    partial class FrmEditarCheckIn
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
            this.dtEditarData = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodCheckIn = new System.Windows.Forms.Label();
            this.txtEditarCodReserva = new System.Windows.Forms.TextBox();
            this.txtEditarCheckIn = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btUpdate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkStatus = new System.Windows.Forms.CheckBox();
            this.txtIdHospedePJ = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIdHospedePF = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selecione o Cód. Check-In";
            // 
            // dtEditarData
            // 
            this.dtEditarData.Location = new System.Drawing.Point(55, 48);
            this.dtEditarData.Name = "dtEditarData";
            this.dtEditarData.Size = new System.Drawing.Size(236, 20);
            this.dtEditarData.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Data:";
            // 
            // txtCodCheckIn
            // 
            this.txtCodCheckIn.AutoSize = true;
            this.txtCodCheckIn.Location = new System.Drawing.Point(153, 138);
            this.txtCodCheckIn.Name = "txtCodCheckIn";
            this.txtCodCheckIn.Size = new System.Drawing.Size(0, 13);
            this.txtCodCheckIn.TabIndex = 7;
            // 
            // txtEditarCodReserva
            // 
            this.txtEditarCodReserva.Location = new System.Drawing.Point(117, 154);
            this.txtEditarCodReserva.Name = "txtEditarCodReserva";
            this.txtEditarCodReserva.Size = new System.Drawing.Size(100, 20);
            this.txtEditarCodReserva.TabIndex = 8;
            // 
            // txtEditarCheckIn
            // 
            this.txtEditarCheckIn.Location = new System.Drawing.Point(150, 19);
            this.txtEditarCheckIn.Name = "txtEditarCheckIn";
            this.txtEditarCheckIn.Size = new System.Drawing.Size(100, 20);
            this.txtEditarCheckIn.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Cod. da Reserva:";
            // 
            // btUpdate
            // 
            this.btUpdate.Location = new System.Drawing.Point(130, 180);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(75, 23);
            this.btUpdate.TabIndex = 10;
            this.btUpdate.Text = "Modificar";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtIdHospedePJ);
            this.groupBox1.Controls.Add(this.btUpdate);
            this.groupBox1.Controls.Add(this.chkStatus);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtIdHospedePF);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtEditarCheckIn);
            this.groupBox1.Controls.Add(this.dtEditarData);
            this.groupBox1.Controls.Add(this.txtEditarCodReserva);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 215);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inserir dados";
            // 
            // chkStatus
            // 
            this.chkStatus.AutoSize = true;
            this.chkStatus.Location = new System.Drawing.Point(235, 157);
            this.chkStatus.Name = "chkStatus";
            this.chkStatus.Size = new System.Drawing.Size(56, 17);
            this.chkStatus.TabIndex = 10;
            this.chkStatus.Text = "Ativo?";
            this.chkStatus.UseVisualStyleBackColor = true;
            // 
            // txtIdHospedePJ
            // 
            this.txtIdHospedePJ.Location = new System.Drawing.Point(117, 119);
            this.txtIdHospedePJ.Name = "txtIdHospedePJ";
            this.txtIdHospedePJ.Size = new System.Drawing.Size(193, 20);
            this.txtIdHospedePJ.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Id do Hospede PJ";
            // 
            // txtIdHospedePF
            // 
            this.txtIdHospedePF.Location = new System.Drawing.Point(117, 83);
            this.txtIdHospedePF.Name = "txtIdHospedePF";
            this.txtIdHospedePF.Size = new System.Drawing.Size(193, 20);
            this.txtIdHospedePF.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Id do Hospede PF";
            // 
            // FrmEditarCheckIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 235);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtCodCheckIn);
            this.Name = "FrmEditarCheckIn";
            this.Text = "FrmEditarCheckIn";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtEditarData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtCodCheckIn;
        private System.Windows.Forms.TextBox txtEditarCodReserva;
        private System.Windows.Forms.TextBox txtEditarCheckIn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkStatus;
        private System.Windows.Forms.TextBox txtIdHospedePJ;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIdHospedePF;
        private System.Windows.Forms.Label label3;
    }
}