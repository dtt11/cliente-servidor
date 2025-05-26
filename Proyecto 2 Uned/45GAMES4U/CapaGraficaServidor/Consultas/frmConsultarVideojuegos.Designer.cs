namespace CapaGraficaServidor
{
    partial class frmConsultarVideojuegos
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
            this.dgvVideojuegos = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.btnConsultarVideojuegos = new System.Windows.Forms.Button();
            this.btnVolverMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVideojuegos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVideojuegos
            // 
            this.dgvVideojuegos.AllowUserToAddRows = false;
            this.dgvVideojuegos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVideojuegos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVideojuegos.Location = new System.Drawing.Point(12, 68);
            this.dgvVideojuegos.Name = "dgvVideojuegos";
            this.dgvVideojuegos.Size = new System.Drawing.Size(607, 308);
            this.dgvVideojuegos.TabIndex = 48;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.IndianRed;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(12, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 24);
            this.label7.TabIndex = 47;
            this.label7.Text = "Videojuegos";
            // 
            // btnConsultarVideojuegos
            // 
            this.btnConsultarVideojuegos.BackColor = System.Drawing.Color.Red;
            this.btnConsultarVideojuegos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarVideojuegos.Location = new System.Drawing.Point(467, 404);
            this.btnConsultarVideojuegos.Name = "btnConsultarVideojuegos";
            this.btnConsultarVideojuegos.Size = new System.Drawing.Size(152, 54);
            this.btnConsultarVideojuegos.TabIndex = 49;
            this.btnConsultarVideojuegos.Text = "Consultar Registro";
            this.btnConsultarVideojuegos.UseVisualStyleBackColor = false;
            this.btnConsultarVideojuegos.Click += new System.EventHandler(this.btnConsultarVideojuegos_Click);
            // 
            // btnVolverMenu
            // 
            this.btnVolverMenu.BackColor = System.Drawing.Color.Firebrick;
            this.btnVolverMenu.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnVolverMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverMenu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVolverMenu.Location = new System.Drawing.Point(12, 405);
            this.btnVolverMenu.Name = "btnVolverMenu";
            this.btnVolverMenu.Size = new System.Drawing.Size(156, 54);
            this.btnVolverMenu.TabIndex = 64;
            this.btnVolverMenu.Text = "Volver al menú principal";
            this.btnVolverMenu.UseVisualStyleBackColor = false;
            this.btnVolverMenu.Click += new System.EventHandler(this.btnVolverMenu_Click_1);
            // 
            // frmConsultarVideojuegos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 470);
            this.Controls.Add(this.btnVolverMenu);
            this.Controls.Add(this.btnConsultarVideojuegos);
            this.Controls.Add(this.dgvVideojuegos);
            this.Controls.Add(this.label7);
            this.Name = "frmConsultarVideojuegos";
            this.Text = "frmConsultarVideojuegos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVideojuegos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVideojuegos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnConsultarVideojuegos;
        private System.Windows.Forms.Button btnVolverMenu;
    }
}