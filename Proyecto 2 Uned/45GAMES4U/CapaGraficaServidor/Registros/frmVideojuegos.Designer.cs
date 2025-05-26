namespace CapaGraficaServidor
{
    partial class frmVideojuegos
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
            this.txtNombreVideojuego = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTipoVideojuego = new System.Windows.Forms.ComboBox();
            this.txtDesarrolladora = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAnoLanzamiento = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbFisicoVirtual = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnGuardarVideojuego = new System.Windows.Forms.Button();
            this.btnVolverMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNombreVideojuego
            // 
            this.txtNombreVideojuego.Location = new System.Drawing.Point(324, 64);
            this.txtNombreVideojuego.Name = "txtNombreVideojuego";
            this.txtNombreVideojuego.Size = new System.Drawing.Size(172, 20);
            this.txtNombreVideojuego.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nombre videojuego:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tipo videojuego:";
            // 
            // cmbTipoVideojuego
            // 
            this.cmbTipoVideojuego.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoVideojuego.FormattingEnabled = true;
            this.cmbTipoVideojuego.Location = new System.Drawing.Point(324, 111);
            this.cmbTipoVideojuego.Name = "cmbTipoVideojuego";
            this.cmbTipoVideojuego.Size = new System.Drawing.Size(172, 28);
            this.cmbTipoVideojuego.TabIndex = 12;
            this.cmbTipoVideojuego.Text = "Elija:";
            // 
            // txtDesarrolladora
            // 
            this.txtDesarrolladora.Location = new System.Drawing.Point(324, 159);
            this.txtDesarrolladora.Name = "txtDesarrolladora";
            this.txtDesarrolladora.Size = new System.Drawing.Size(172, 20);
            this.txtDesarrolladora.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Desarrolladora:";
            // 
            // txtAnoLanzamiento
            // 
            this.txtAnoLanzamiento.Location = new System.Drawing.Point(324, 210);
            this.txtAnoLanzamiento.Name = "txtAnoLanzamiento";
            this.txtAnoLanzamiento.Size = new System.Drawing.Size(172, 20);
            this.txtAnoLanzamiento.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Año de lanzamiento:";
            // 
            // cmbFisicoVirtual
            // 
            this.cmbFisicoVirtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFisicoVirtual.FormattingEnabled = true;
            this.cmbFisicoVirtual.Items.AddRange(new object[] {
            "Físico",
            "Virtual"});
            this.cmbFisicoVirtual.Location = new System.Drawing.Point(375, 261);
            this.cmbFisicoVirtual.Name = "cmbFisicoVirtual";
            this.cmbFisicoVirtual.Size = new System.Drawing.Size(121, 28);
            this.cmbFisicoVirtual.TabIndex = 18;
            this.cmbFisicoVirtual.Text = "Elija:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(33, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Físico o Virtual:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(33, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(196, 24);
            this.label7.TabIndex = 32;
            this.label7.Text = "Registrar Videojuegos";
            // 
            // btnGuardarVideojuego
            // 
            this.btnGuardarVideojuego.BackColor = System.Drawing.Color.Turquoise;
            this.btnGuardarVideojuego.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarVideojuego.Location = new System.Drawing.Point(340, 335);
            this.btnGuardarVideojuego.Name = "btnGuardarVideojuego";
            this.btnGuardarVideojuego.Size = new System.Drawing.Size(156, 54);
            this.btnGuardarVideojuego.TabIndex = 34;
            this.btnGuardarVideojuego.Text = "Guardar Registro";
            this.btnGuardarVideojuego.UseVisualStyleBackColor = false;
            this.btnGuardarVideojuego.Click += new System.EventHandler(this.btnGuardarVideojuego_Click);
            // 
            // btnVolverMenu
            // 
            this.btnVolverMenu.BackColor = System.Drawing.Color.Firebrick;
            this.btnVolverMenu.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnVolverMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverMenu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVolverMenu.Location = new System.Drawing.Point(37, 336);
            this.btnVolverMenu.Name = "btnVolverMenu";
            this.btnVolverMenu.Size = new System.Drawing.Size(156, 54);
            this.btnVolverMenu.TabIndex = 63;
            this.btnVolverMenu.Text = "Volver al menú principal";
            this.btnVolverMenu.UseVisualStyleBackColor = false;
            this.btnVolverMenu.Click += new System.EventHandler(this.btnVolverMenu_Click);
            // 
            // frmVideojuegos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 490);
            this.Controls.Add(this.btnVolverMenu);
            this.Controls.Add(this.btnGuardarVideojuego);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbFisicoVirtual);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAnoLanzamiento);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDesarrolladora);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbTipoVideojuego);
            this.Controls.Add(this.txtNombreVideojuego);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "frmVideojuegos";
            this.Text = "frmVideojuegos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombreVideojuego;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbTipoVideojuego;
        private System.Windows.Forms.TextBox txtDesarrolladora;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAnoLanzamiento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbFisicoVirtual;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnGuardarVideojuego;
        private System.Windows.Forms.Button btnVolverMenu;
    }
}