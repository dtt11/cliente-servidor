namespace CapaGraficaServidor.Registros
{
    partial class frmTiendas
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
            this.btnGuardarTiendas = new System.Windows.Forms.Button();
            this.cmbActiva = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbAdministrador = new System.Windows.Forms.ComboBox();
            this.txtNombreTienda = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnVolverMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGuardarTiendas
            // 
            this.btnGuardarTiendas.BackColor = System.Drawing.Color.Turquoise;
            this.btnGuardarTiendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarTiendas.Location = new System.Drawing.Point(401, 355);
            this.btnGuardarTiendas.Name = "btnGuardarTiendas";
            this.btnGuardarTiendas.Size = new System.Drawing.Size(156, 54);
            this.btnGuardarTiendas.TabIndex = 64;
            this.btnGuardarTiendas.Text = "Guardar Registro";
            this.btnGuardarTiendas.UseVisualStyleBackColor = false;
            this.btnGuardarTiendas.Click += new System.EventHandler(this.btnGuardarTiendas_Click);
            // 
            // cmbActiva
            // 
            this.cmbActiva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbActiva.FormattingEnabled = true;
            this.cmbActiva.Items.AddRange(new object[] {
            "Sí",
            "No"});
            this.cmbActiva.Location = new System.Drawing.Point(436, 291);
            this.cmbActiva.Name = "cmbActiva";
            this.cmbActiva.Size = new System.Drawing.Size(121, 28);
            this.cmbActiva.TabIndex = 63;
            this.cmbActiva.Text = "Elija:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(53, 299);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 20);
            this.label6.TabIndex = 62;
            this.label6.Text = "Activa:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(385, 248);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(172, 20);
            this.txtTelefono.TabIndex = 61;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(53, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 60;
            this.label4.Text = "Teléfono:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(51, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 24);
            this.label7.TabIndex = 59;
            this.label7.Text = "Registrar Tiendas";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(385, 197);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(172, 20);
            this.txtDireccion.TabIndex = 58;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(53, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 20);
            this.label5.TabIndex = 57;
            this.label5.Text = "Dirección:";
            // 
            // cmbAdministrador
            // 
            this.cmbAdministrador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAdministrador.FormattingEnabled = true;
            this.cmbAdministrador.Location = new System.Drawing.Point(312, 133);
            this.cmbAdministrador.Name = "cmbAdministrador";
            this.cmbAdministrador.Size = new System.Drawing.Size(245, 28);
            this.cmbAdministrador.TabIndex = 56;
            this.cmbAdministrador.Text = "Elija:";
            // 
            // txtNombreTienda
            // 
            this.txtNombreTienda.Location = new System.Drawing.Point(385, 72);
            this.txtNombreTienda.Name = "txtNombreTienda";
            this.txtNombreTienda.Size = new System.Drawing.Size(172, 20);
            this.txtNombreTienda.TabIndex = 55;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(53, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 20);
            this.label3.TabIndex = 53;
            this.label3.Text = "Nombre de la tienda:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 52;
            this.label2.Text = "Administrador:";
            // 
            // btnVolverMenu
            // 
            this.btnVolverMenu.BackColor = System.Drawing.Color.Firebrick;
            this.btnVolverMenu.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnVolverMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverMenu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVolverMenu.Location = new System.Drawing.Point(55, 356);
            this.btnVolverMenu.Name = "btnVolverMenu";
            this.btnVolverMenu.Size = new System.Drawing.Size(156, 54);
            this.btnVolverMenu.TabIndex = 65;
            this.btnVolverMenu.Text = "Volver al menú principal";
            this.btnVolverMenu.UseVisualStyleBackColor = false;
            this.btnVolverMenu.Click += new System.EventHandler(this.btnVolverMenu_Click);
            // 
            // frmTiendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 493);
            this.Controls.Add(this.btnVolverMenu);
            this.Controls.Add(this.btnGuardarTiendas);
            this.Controls.Add(this.cmbActiva);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbAdministrador);
            this.Controls.Add(this.txtNombreTienda);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "frmTiendas";
            this.Text = "frmTiendas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardarTiendas;
        private System.Windows.Forms.ComboBox cmbActiva;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbAdministrador;
        private System.Windows.Forms.TextBox txtNombreTienda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnVolverMenu;
    }
}