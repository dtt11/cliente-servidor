namespace CapaGraficaServidor.Consultas
{
    partial class frmConsultarAdministradores
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
            this.btnConsultarAdministradores = new System.Windows.Forms.Button();
            this.dgvAdministradores = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.btnVolverMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdministradores)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConsultarAdministradores
            // 
            this.btnConsultarAdministradores.BackColor = System.Drawing.Color.Red;
            this.btnConsultarAdministradores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarAdministradores.Location = new System.Drawing.Point(542, 354);
            this.btnConsultarAdministradores.Name = "btnConsultarAdministradores";
            this.btnConsultarAdministradores.Size = new System.Drawing.Size(152, 55);
            this.btnConsultarAdministradores.TabIndex = 54;
            this.btnConsultarAdministradores.Text = "Consultar Registro";
            this.btnConsultarAdministradores.UseVisualStyleBackColor = false;
            this.btnConsultarAdministradores.Click += new System.EventHandler(this.btnConsultarAdministradores_Click);
            // 
            // dgvAdministradores
            // 
            this.dgvAdministradores.AllowUserToAddRows = false;
            this.dgvAdministradores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAdministradores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdministradores.Location = new System.Drawing.Point(37, 73);
            this.dgvAdministradores.Name = "dgvAdministradores";
            this.dgvAdministradores.Size = new System.Drawing.Size(657, 255);
            this.dgvAdministradores.TabIndex = 53;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.IndianRed;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(33, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 24);
            this.label7.TabIndex = 52;
            this.label7.Text = "Administradores";
            // 
            // btnVolverMenu
            // 
            this.btnVolverMenu.BackColor = System.Drawing.Color.Firebrick;
            this.btnVolverMenu.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnVolverMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverMenu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVolverMenu.Location = new System.Drawing.Point(37, 355);
            this.btnVolverMenu.Name = "btnVolverMenu";
            this.btnVolverMenu.Size = new System.Drawing.Size(156, 54);
            this.btnVolverMenu.TabIndex = 64;
            this.btnVolverMenu.Text = "Volver al menú principal";
            this.btnVolverMenu.UseVisualStyleBackColor = false;
            this.btnVolverMenu.Click += new System.EventHandler(this.btnVolverMenu_Click);
            // 
            // frmConsultarAdministradores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 450);
            this.Controls.Add(this.btnVolverMenu);
            this.Controls.Add(this.btnConsultarAdministradores);
            this.Controls.Add(this.dgvAdministradores);
            this.Controls.Add(this.label7);
            this.Name = "frmConsultarAdministradores";
            this.Text = "frmConsultarAdministradores";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdministradores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConsultarAdministradores;
        private System.Windows.Forms.DataGridView dgvAdministradores;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnVolverMenu;
    }
}