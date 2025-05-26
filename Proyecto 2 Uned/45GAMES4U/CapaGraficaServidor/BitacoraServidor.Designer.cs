namespace CapaGraficaServidor
{
    partial class BitacoraServidor
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
            this.label2 = new System.Windows.Forms.Label();
            this.lblClientes = new System.Windows.Forms.Label();
            this.lstBitacora = new System.Windows.Forms.ListBox();
            this.btnIniciarServidor = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bodoni MT", 27.75F);
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(71, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(646, 44);
            this.label2.TabIndex = 68;
            this.label2.Text = "SERVIDOR CENTRAL - BITÁCORA  ";
            // 
            // lblClientes
            // 
            this.lblClientes.AutoSize = true;
            this.lblClientes.Font = new System.Drawing.Font("Bodoni MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientes.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblClientes.Location = new System.Drawing.Point(48, 107);
            this.lblClientes.Name = "lblClientes";
            this.lblClientes.Size = new System.Drawing.Size(250, 32);
            this.lblClientes.TabIndex = 69;
            this.lblClientes.Text = " Clientes conectados:";
            // 
            // lstBitacora
            // 
            this.lstBitacora.AccessibleName = "";
            this.lstBitacora.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBitacora.FormattingEnabled = true;
            this.lstBitacora.ItemHeight = 25;
            this.lstBitacora.Location = new System.Drawing.Point(69, 159);
            this.lstBitacora.Name = "lstBitacora";
            this.lstBitacora.Size = new System.Drawing.Size(617, 179);
            this.lstBitacora.TabIndex = 71;
            // 
            // btnIniciarServidor
            // 
            this.btnIniciarServidor.Font = new System.Drawing.Font("Bodoni MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarServidor.Location = new System.Drawing.Point(69, 365);
            this.btnIniciarServidor.Name = "btnIniciarServidor";
            this.btnIniciarServidor.Size = new System.Drawing.Size(261, 36);
            this.btnIniciarServidor.TabIndex = 72;
            this.btnIniciarServidor.Text = "Iniciar Servidor";
            this.btnIniciarServidor.UseVisualStyleBackColor = true;
            this.btnIniciarServidor.Click += new System.EventHandler(this.btnIniciarServidor_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Font = new System.Drawing.Font("Bodoni MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.Location = new System.Drawing.Point(425, 365);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(261, 36);
            this.btnMenu.TabIndex = 73;
            this.btnMenu.Text = "Ir al Menú Principal";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Red;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(300, 443);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(154, 40);
            this.btnSalir.TabIndex = 74;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // bitacoraServidor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 495);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.btnIniciarServidor);
            this.Controls.Add(this.lstBitacora);
            this.Controls.Add(this.lblClientes);
            this.Controls.Add(this.label2);
            this.Name = "bitacoraServidor";
            this.Text = "bitacoraServidor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblClientes;
        private System.Windows.Forms.ListBox lstBitacora;
        private System.Windows.Forms.Button btnIniciarServidor;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnSalir;
    }
}