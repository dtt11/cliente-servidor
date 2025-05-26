namespace CapaGraficaServidor
{
    partial class frmConsultarTiposVideojuegos
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
            this.label7 = new System.Windows.Forms.Label();
            this.dgvTiposVideojuegos = new System.Windows.Forms.DataGridView();
            this.btnConsultarTiposVideojuegos = new System.Windows.Forms.Button();
            this.btnVolverMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTiposVideojuegos)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.IndianRed;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(12, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(196, 24);
            this.label7.TabIndex = 45;
            this.label7.Text = "Tipos de Videojuegos";
            // 
            // dgvTiposVideojuegos
            // 
            this.dgvTiposVideojuegos.AllowUserToAddRows = false;
            this.dgvTiposVideojuegos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTiposVideojuegos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTiposVideojuegos.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvTiposVideojuegos.Location = new System.Drawing.Point(12, 69);
            this.dgvTiposVideojuegos.Name = "dgvTiposVideojuegos";
            this.dgvTiposVideojuegos.Size = new System.Drawing.Size(476, 308);
            this.dgvTiposVideojuegos.TabIndex = 46;
            // 
            // btnConsultarTiposVideojuegos
            // 
            this.btnConsultarTiposVideojuegos.BackColor = System.Drawing.Color.Red;
            this.btnConsultarTiposVideojuegos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarTiposVideojuegos.Location = new System.Drawing.Point(336, 394);
            this.btnConsultarTiposVideojuegos.Name = "btnConsultarTiposVideojuegos";
            this.btnConsultarTiposVideojuegos.Size = new System.Drawing.Size(152, 55);
            this.btnConsultarTiposVideojuegos.TabIndex = 47;
            this.btnConsultarTiposVideojuegos.Text = "Consultar Registro";
            this.btnConsultarTiposVideojuegos.UseVisualStyleBackColor = false;
            this.btnConsultarTiposVideojuegos.Click += new System.EventHandler(this.btnConsultarTiposVideojuegos_Click);
            // 
            // btnVolverMenu
            // 
            this.btnVolverMenu.BackColor = System.Drawing.Color.Firebrick;
            this.btnVolverMenu.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnVolverMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverMenu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVolverMenu.Location = new System.Drawing.Point(12, 394);
            this.btnVolverMenu.Name = "btnVolverMenu";
            this.btnVolverMenu.Size = new System.Drawing.Size(156, 54);
            this.btnVolverMenu.TabIndex = 63;
            this.btnVolverMenu.Text = "Volver al menú principal";
            this.btnVolverMenu.UseVisualStyleBackColor = false;
            this.btnVolverMenu.Click += new System.EventHandler(this.btnVolverMenu_Click);
            // 
            // frmConsultarTiposVideojuegos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 460);
            this.Controls.Add(this.btnVolverMenu);
            this.Controls.Add(this.btnConsultarTiposVideojuegos);
            this.Controls.Add(this.dgvTiposVideojuegos);
            this.Controls.Add(this.label7);
            this.Name = "frmConsultarTiposVideojuegos";
            this.Text = "frmConsultarTiposVideojuegos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTiposVideojuegos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvTiposVideojuegos;
        private System.Windows.Forms.Button btnConsultarTiposVideojuegos;
        private System.Windows.Forms.Button btnVolverMenu;
    }
}