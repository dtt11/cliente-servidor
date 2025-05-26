namespace CapaGraficaServidor.Consultas
{
    partial class frmConsultarClientes
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
            this.btnConsultarClientes = new System.Windows.Forms.Button();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.btnVolverMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConsultarClientes
            // 
            this.btnConsultarClientes.BackColor = System.Drawing.Color.Red;
            this.btnConsultarClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarClientes.Location = new System.Drawing.Point(432, 383);
            this.btnConsultarClientes.Name = "btnConsultarClientes";
            this.btnConsultarClientes.Size = new System.Drawing.Size(152, 55);
            this.btnConsultarClientes.TabIndex = 54;
            this.btnConsultarClientes.Text = "Consultar Registro";
            this.btnConsultarClientes.UseVisualStyleBackColor = false;
            this.btnConsultarClientes.Click += new System.EventHandler(this.btnConsultarClientes_Click);
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(24, 58);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.Size = new System.Drawing.Size(560, 308);
            this.dgvClientes.TabIndex = 53;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.IndianRed;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(20, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 24);
            this.label7.TabIndex = 52;
            this.label7.Text = "Clientes";
            // 
            // btnVolverMenu
            // 
            this.btnVolverMenu.BackColor = System.Drawing.Color.Firebrick;
            this.btnVolverMenu.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnVolverMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverMenu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVolverMenu.Location = new System.Drawing.Point(24, 383);
            this.btnVolverMenu.Name = "btnVolverMenu";
            this.btnVolverMenu.Size = new System.Drawing.Size(156, 54);
            this.btnVolverMenu.TabIndex = 65;
            this.btnVolverMenu.Text = "Volver al menú principal";
            this.btnVolverMenu.UseVisualStyleBackColor = false;
            this.btnVolverMenu.Click += new System.EventHandler(this.btnVolverMenu_Click);
            // 
            // frmConsultarClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 450);
            this.Controls.Add(this.btnVolverMenu);
            this.Controls.Add(this.btnConsultarClientes);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.label7);
            this.Name = "frmConsultarClientes";
            this.Text = "frmConsultarClientes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConsultarClientes;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnVolverMenu;
    }
}