namespace CapaGraficaServidor.Registros
{
    partial class frmInventario
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
            this.btnGuardarVideojuego = new System.Windows.Forms.Button();
            this.dgvVideojuegos = new System.Windows.Forms.DataGridView();
            this.cmbTienda = new System.Windows.Forms.ComboBox();
            this.txtExistencias = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVolverMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVideojuegos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardarVideojuego
            // 
            this.btnGuardarVideojuego.BackColor = System.Drawing.Color.Turquoise;
            this.btnGuardarVideojuego.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarVideojuego.Location = new System.Drawing.Point(693, 412);
            this.btnGuardarVideojuego.Name = "btnGuardarVideojuego";
            this.btnGuardarVideojuego.Size = new System.Drawing.Size(156, 54);
            this.btnGuardarVideojuego.TabIndex = 74;
            this.btnGuardarVideojuego.Text = "Guardar Registro";
            this.btnGuardarVideojuego.UseVisualStyleBackColor = false;
            this.btnGuardarVideojuego.Click += new System.EventHandler(this.btnGuardarVideojuego_Click);
            // 
            // dgvVideojuegos
            // 
            this.dgvVideojuegos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVideojuegos.Location = new System.Drawing.Point(254, 120);
            this.dgvVideojuegos.Name = "dgvVideojuegos";
            this.dgvVideojuegos.Size = new System.Drawing.Size(595, 219);
            this.dgvVideojuegos.TabIndex = 73;
            // 
            // cmbTienda
            // 
            this.cmbTienda.FormattingEnabled = true;
            this.cmbTienda.Location = new System.Drawing.Point(254, 76);
            this.cmbTienda.Name = "cmbTienda";
            this.cmbTienda.Size = new System.Drawing.Size(595, 21);
            this.cmbTienda.TabIndex = 72;
            // 
            // txtExistencias
            // 
            this.txtExistencias.Location = new System.Drawing.Point(254, 362);
            this.txtExistencias.Name = "txtExistencias";
            this.txtExistencias.Size = new System.Drawing.Size(595, 20);
            this.txtExistencias.TabIndex = 71;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(44, 362);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 20);
            this.label8.TabIndex = 70;
            this.label8.Text = "Existencias:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(35, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(175, 24);
            this.label7.TabIndex = 69;
            this.label7.Text = "Registrar Inventario:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 68;
            this.label3.Text = "Videojuego:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 67;
            this.label1.Text = "Tienda:";
            // 
            // btnVolverMenu
            // 
            this.btnVolverMenu.BackColor = System.Drawing.Color.Firebrick;
            this.btnVolverMenu.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnVolverMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverMenu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVolverMenu.Location = new System.Drawing.Point(39, 412);
            this.btnVolverMenu.Name = "btnVolverMenu";
            this.btnVolverMenu.Size = new System.Drawing.Size(156, 54);
            this.btnVolverMenu.TabIndex = 75;
            this.btnVolverMenu.Text = "Volver al menú principal";
            this.btnVolverMenu.UseVisualStyleBackColor = false;
            this.btnVolverMenu.Click += new System.EventHandler(this.btnVolverMenu_Click);
            // 
            // frmInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 488);
            this.Controls.Add(this.btnVolverMenu);
            this.Controls.Add(this.btnGuardarVideojuego);
            this.Controls.Add(this.dgvVideojuegos);
            this.Controls.Add(this.cmbTienda);
            this.Controls.Add(this.txtExistencias);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "frmInventario";
            this.Text = "frmVideojuegosXTienda";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVideojuegos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardarVideojuego;
        private System.Windows.Forms.DataGridView dgvVideojuegos;
        private System.Windows.Forms.ComboBox cmbTienda;
        private System.Windows.Forms.TextBox txtExistencias;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVolverMenu;
    }
}