namespace CapaGraficaServidor.Registros
{
    partial class frmTipoVideojuegos
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtTipoVideojuego = new System.Windows.Forms.TextBox();
            this.txtDescripcionVideojuego = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnGuardarTipoVideojuego = new System.Windows.Forms.Button();
            this.btnVolverMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo de videojuego:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(61, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descripción videojuego:";
            // 
            // txtTipoVideojuego
            // 
            this.txtTipoVideojuego.Location = new System.Drawing.Point(341, 87);
            this.txtTipoVideojuego.Name = "txtTipoVideojuego";
            this.txtTipoVideojuego.Size = new System.Drawing.Size(172, 20);
            this.txtTipoVideojuego.TabIndex = 4;
            // 
            // txtDescripcionVideojuego
            // 
            this.txtDescripcionVideojuego.Location = new System.Drawing.Point(341, 156);
            this.txtDescripcionVideojuego.Name = "txtDescripcionVideojuego";
            this.txtDescripcionVideojuego.Size = new System.Drawing.Size(172, 20);
            this.txtDescripcionVideojuego.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(61, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(275, 24);
            this.label7.TabIndex = 32;
            this.label7.Text = "Registrar Tipos de Videojuegos";
            // 
            // btnGuardarTipoVideojuego
            // 
            this.btnGuardarTipoVideojuego.BackColor = System.Drawing.Color.Turquoise;
            this.btnGuardarTipoVideojuego.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarTipoVideojuego.Location = new System.Drawing.Point(357, 247);
            this.btnGuardarTipoVideojuego.Name = "btnGuardarTipoVideojuego";
            this.btnGuardarTipoVideojuego.Size = new System.Drawing.Size(156, 54);
            this.btnGuardarTipoVideojuego.TabIndex = 33;
            this.btnGuardarTipoVideojuego.Text = "Guardar Registro";
            this.btnGuardarTipoVideojuego.UseVisualStyleBackColor = false;
            this.btnGuardarTipoVideojuego.Click += new System.EventHandler(this.btnGuardarTipoVideojuego_Click);
            // 
            // btnVolverMenu
            // 
            this.btnVolverMenu.BackColor = System.Drawing.Color.Firebrick;
            this.btnVolverMenu.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnVolverMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverMenu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVolverMenu.Location = new System.Drawing.Point(65, 247);
            this.btnVolverMenu.Name = "btnVolverMenu";
            this.btnVolverMenu.Size = new System.Drawing.Size(156, 54);
            this.btnVolverMenu.TabIndex = 62;
            this.btnVolverMenu.Text = "Volver al menú principal";
            this.btnVolverMenu.UseVisualStyleBackColor = false;
            this.btnVolverMenu.Click += new System.EventHandler(this.btnVolverMenu_Click);
            // 
            // frmTipoVideojuegos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 313);
            this.Controls.Add(this.btnVolverMenu);
            this.Controls.Add(this.btnGuardarTipoVideojuego);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDescripcionVideojuego);
            this.Controls.Add(this.txtTipoVideojuego);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "frmTipoVideojuegos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTipoVideojuegos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTipoVideojuego;
        private System.Windows.Forms.TextBox txtDescripcionVideojuego;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnGuardarTipoVideojuego;
        private System.Windows.Forms.Button btnVolverMenu;
    }
}