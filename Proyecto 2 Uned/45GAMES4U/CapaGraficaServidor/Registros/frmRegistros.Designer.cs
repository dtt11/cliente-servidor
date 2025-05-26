namespace CapaGraficaServidor
{
    partial class frmRegistros
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
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnInventario = new System.Windows.Forms.Button();
            this.btnTiendas = new System.Windows.Forms.Button();
            this.btnAdministradoresTiendas = new System.Windows.Forms.Button();
            this.btnVideoJuegos = new System.Windows.Forms.Button();
            this.btntiposVideoJuegos = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnVolverMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClientes
            // 
            this.btnClientes.Location = new System.Drawing.Point(307, 256);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(171, 69);
            this.btnClientes.TabIndex = 12;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnInventario
            // 
            this.btnInventario.Location = new System.Drawing.Point(589, 256);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Size = new System.Drawing.Size(171, 69);
            this.btnInventario.TabIndex = 11;
            this.btnInventario.Text = "Inventario";
            this.btnInventario.UseVisualStyleBackColor = true;
            this.btnInventario.Click += new System.EventHandler(this.btnInventario_Click_1);
            // 
            // btnTiendas
            // 
            this.btnTiendas.Location = new System.Drawing.Point(40, 256);
            this.btnTiendas.Name = "btnTiendas";
            this.btnTiendas.Size = new System.Drawing.Size(171, 69);
            this.btnTiendas.TabIndex = 10;
            this.btnTiendas.Text = "Tiendas";
            this.btnTiendas.UseVisualStyleBackColor = true;
            this.btnTiendas.Click += new System.EventHandler(this.btnTiendas_Click);
            // 
            // btnAdministradoresTiendas
            // 
            this.btnAdministradoresTiendas.Location = new System.Drawing.Point(589, 134);
            this.btnAdministradoresTiendas.Name = "btnAdministradoresTiendas";
            this.btnAdministradoresTiendas.Size = new System.Drawing.Size(171, 69);
            this.btnAdministradoresTiendas.TabIndex = 9;
            this.btnAdministradoresTiendas.Text = "Administradores de tiendas";
            this.btnAdministradoresTiendas.UseVisualStyleBackColor = true;
            this.btnAdministradoresTiendas.Click += new System.EventHandler(this.btnAdministradoresTiendas_Click);
            // 
            // btnVideoJuegos
            // 
            this.btnVideoJuegos.Location = new System.Drawing.Point(307, 134);
            this.btnVideoJuegos.Name = "btnVideoJuegos";
            this.btnVideoJuegos.Size = new System.Drawing.Size(171, 69);
            this.btnVideoJuegos.TabIndex = 8;
            this.btnVideoJuegos.Text = "Videojuegos";
            this.btnVideoJuegos.UseVisualStyleBackColor = true;
            this.btnVideoJuegos.Click += new System.EventHandler(this.btnVideoJuegos_Click_1);
            // 
            // btntiposVideoJuegos
            // 
            this.btntiposVideoJuegos.Location = new System.Drawing.Point(40, 134);
            this.btntiposVideoJuegos.Name = "btntiposVideoJuegos";
            this.btntiposVideoJuegos.Size = new System.Drawing.Size(171, 69);
            this.btntiposVideoJuegos.TabIndex = 7;
            this.btntiposVideoJuegos.Text = "Tipos de Videojuegos";
            this.btntiposVideoJuegos.UseVisualStyleBackColor = true;
            this.btntiposVideoJuegos.Click += new System.EventHandler(this.btntiposVideoJuegos_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(267, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(268, 33);
            this.label7.TabIndex = 60;
            this.label7.Text = "Llenar Formularios:";
            // 
            // btnVolverMenu
            // 
            this.btnVolverMenu.BackColor = System.Drawing.Color.Firebrick;
            this.btnVolverMenu.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnVolverMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverMenu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVolverMenu.Location = new System.Drawing.Point(307, 358);
            this.btnVolverMenu.Name = "btnVolverMenu";
            this.btnVolverMenu.Size = new System.Drawing.Size(171, 26);
            this.btnVolverMenu.TabIndex = 61;
            this.btnVolverMenu.Text = "Volver al menú principal";
            this.btnVolverMenu.UseVisualStyleBackColor = false;
            this.btnVolverMenu.Click += new System.EventHandler(this.btnVolverMenu_Click);
            // 
            // frmRegistros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 408);
            this.Controls.Add(this.btnVolverMenu);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnClientes);
            this.Controls.Add(this.btnInventario);
            this.Controls.Add(this.btnTiendas);
            this.Controls.Add(this.btnAdministradoresTiendas);
            this.Controls.Add(this.btnVideoJuegos);
            this.Controls.Add(this.btntiposVideoJuegos);
            this.Name = "frmRegistros";
            this.Text = "frmLlenarFormularios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnInventario;
        private System.Windows.Forms.Button btnTiendas;
        private System.Windows.Forms.Button btnAdministradoresTiendas;
        private System.Windows.Forms.Button btnVideoJuegos;
        private System.Windows.Forms.Button btntiposVideoJuegos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnVolverMenu;
    }
}