namespace CapaGraficaServidor
{
    partial class FormPrincipal
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
            this.btnConsultarForm = new System.Windows.Forms.Button();
            this.btnRegistrarForm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnServidor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConsultarForm
            // 
            this.btnConsultarForm.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnConsultarForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarForm.Location = new System.Drawing.Point(73, 242);
            this.btnConsultarForm.Name = "btnConsultarForm";
            this.btnConsultarForm.Size = new System.Drawing.Size(267, 63);
            this.btnConsultarForm.TabIndex = 9;
            this.btnConsultarForm.Text = "Consultar Registros";
            this.btnConsultarForm.UseVisualStyleBackColor = false;
            this.btnConsultarForm.Click += new System.EventHandler(this.btnConsultarForm_Click);
            // 
            // btnRegistrarForm
            // 
            this.btnRegistrarForm.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnRegistrarForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarForm.Location = new System.Drawing.Point(73, 145);
            this.btnRegistrarForm.Name = "btnRegistrarForm";
            this.btnRegistrarForm.Size = new System.Drawing.Size(267, 63);
            this.btnRegistrarForm.TabIndex = 10;
            this.btnRegistrarForm.Text = "Registrar Formularios";
            this.btnRegistrarForm.UseVisualStyleBackColor = false;
            this.btnRegistrarForm.Click += new System.EventHandler(this.btnRegistrarForm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bodoni MT", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(74, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 44);
            this.label1.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bodoni MT", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(80, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(260, 44);
            this.label3.TabIndex = 13;
            this.label3.Text = "Menú Principal";
            // 
            // btnServidor
            // 
            this.btnServidor.BackColor = System.Drawing.Color.OrangeRed;
            this.btnServidor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServidor.Location = new System.Drawing.Point(73, 330);
            this.btnServidor.Name = "btnServidor";
            this.btnServidor.Size = new System.Drawing.Size(267, 63);
            this.btnServidor.TabIndex = 14;
            this.btnServidor.Text = "Volver al Servidor";
            this.btnServidor.UseVisualStyleBackColor = false;
            this.btnServidor.Click += new System.EventHandler(this.btnServidor_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 418);
            this.Controls.Add(this.btnServidor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRegistrarForm);
            this.Controls.Add(this.btnConsultarForm);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormInicio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnConsultarForm;
        private System.Windows.Forms.Button btnRegistrarForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnServidor;
    }
}