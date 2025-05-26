namespace CapaGraficaServidor.Consultas
{
    partial class frmConsultarTiendas
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
            this.btnConsultarTiendas = new System.Windows.Forms.Button();
            this.dgvTiendas = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.btnVolverMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTiendas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConsultarTiendas
            // 
            this.btnConsultarTiendas.BackColor = System.Drawing.Color.Red;
            this.btnConsultarTiendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarTiendas.Location = new System.Drawing.Point(500, 383);
            this.btnConsultarTiendas.Name = "btnConsultarTiendas";
            this.btnConsultarTiendas.Size = new System.Drawing.Size(152, 55);
            this.btnConsultarTiendas.TabIndex = 54;
            this.btnConsultarTiendas.Text = "Consultar Registro";
            this.btnConsultarTiendas.UseVisualStyleBackColor = false;
            this.btnConsultarTiendas.Click += new System.EventHandler(this.btnConsultarTiendas_Click);
            // 
            // dgvTiendas
            // 
            this.dgvTiendas.AllowUserToAddRows = false;
            this.dgvTiendas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTiendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTiendas.Location = new System.Drawing.Point(27, 53);
            this.dgvTiendas.Name = "dgvTiendas";
            this.dgvTiendas.Size = new System.Drawing.Size(625, 308);
            this.dgvTiendas.TabIndex = 53;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.IndianRed;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(23, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 24);
            this.label7.TabIndex = 52;
            this.label7.Text = "Tiendas";
            // 
            // btnVolverMenu
            // 
            this.btnVolverMenu.BackColor = System.Drawing.Color.Firebrick;
            this.btnVolverMenu.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnVolverMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverMenu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVolverMenu.Location = new System.Drawing.Point(27, 383);
            this.btnVolverMenu.Name = "btnVolverMenu";
            this.btnVolverMenu.Size = new System.Drawing.Size(156, 54);
            this.btnVolverMenu.TabIndex = 65;
            this.btnVolverMenu.Text = "Volver al menú principal";
            this.btnVolverMenu.UseVisualStyleBackColor = false;
            this.btnVolverMenu.Click += new System.EventHandler(this.btnVolverMenu_Click);
            // 
            // frmConsultarTiendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 450);
            this.Controls.Add(this.btnVolverMenu);
            this.Controls.Add(this.btnConsultarTiendas);
            this.Controls.Add(this.dgvTiendas);
            this.Controls.Add(this.label7);
            this.Name = "frmConsultarTiendas";
            this.Text = "frmConsultarTiendas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTiendas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConsultarTiendas;
        private System.Windows.Forms.DataGridView dgvTiendas;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnVolverMenu;
    }
}