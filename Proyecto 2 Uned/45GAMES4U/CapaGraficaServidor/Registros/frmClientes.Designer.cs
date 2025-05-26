namespace CapaGraficaServidor.Registros
{
    partial class frmClientes
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
            this.btnGuardarCliente = new System.Windows.Forms.Button();
            this.cmbJugadorEnLinea = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.txtPrimerApellidoCliente = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSegundoApellidoCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombreCLiente = new System.Windows.Forms.TextBox();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVolverMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGuardarCliente
            // 
            this.btnGuardarCliente.BackColor = System.Drawing.Color.Turquoise;
            this.btnGuardarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarCliente.Location = new System.Drawing.Point(282, 366);
            this.btnGuardarCliente.Name = "btnGuardarCliente";
            this.btnGuardarCliente.Size = new System.Drawing.Size(156, 54);
            this.btnGuardarCliente.TabIndex = 68;
            this.btnGuardarCliente.Text = "Guardar Registro";
            this.btnGuardarCliente.UseVisualStyleBackColor = false;
            this.btnGuardarCliente.Click += new System.EventHandler(this.btnGuardarCliente_Click_1);
            // 
            // cmbJugadorEnLinea
            // 
            this.cmbJugadorEnLinea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbJugadorEnLinea.FormattingEnabled = true;
            this.cmbJugadorEnLinea.Items.AddRange(new object[] {
            "Si",
            "No"});
            this.cmbJugadorEnLinea.Location = new System.Drawing.Point(317, 297);
            this.cmbJugadorEnLinea.Name = "cmbJugadorEnLinea";
            this.cmbJugadorEnLinea.Size = new System.Drawing.Size(121, 28);
            this.cmbJugadorEnLinea.TabIndex = 67;
            this.cmbJugadorEnLinea.Text = "Elija:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 20);
            this.label5.TabIndex = 66;
            this.label5.Text = "Juega en línea:";
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(236, 242);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaNacimiento.TabIndex = 65;
            // 
            // txtPrimerApellidoCliente
            // 
            this.txtPrimerApellidoCliente.Location = new System.Drawing.Point(264, 143);
            this.txtPrimerApellidoCliente.Name = "txtPrimerApellidoCliente";
            this.txtPrimerApellidoCliente.Size = new System.Drawing.Size(172, 20);
            this.txtPrimerApellidoCliente.TabIndex = 64;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(26, 141);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 20);
            this.label8.TabIndex = 63;
            this.label8.Text = "Primer Apellido:";
            // 
            // txtSegundoApellidoCliente
            // 
            this.txtSegundoApellidoCliente.Location = new System.Drawing.Point(264, 192);
            this.txtSegundoApellidoCliente.Name = "txtSegundoApellidoCliente";
            this.txtSegundoApellidoCliente.Size = new System.Drawing.Size(172, 20);
            this.txtSegundoApellidoCliente.TabIndex = 62;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 20);
            this.label2.TabIndex = 61;
            this.label2.Text = "Segundo Apellido:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(26, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 24);
            this.label7.TabIndex = 60;
            this.label7.Text = "Registrar Clientes:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 20);
            this.label4.TabIndex = 59;
            this.label4.Text = "Fecha de Nacimiento:";
            // 
            // txtNombreCLiente
            // 
            this.txtNombreCLiente.Location = new System.Drawing.Point(264, 93);
            this.txtNombreCLiente.Name = "txtNombreCLiente";
            this.txtNombreCLiente.Size = new System.Drawing.Size(172, 20);
            this.txtNombreCLiente.TabIndex = 58;
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Location = new System.Drawing.Point(264, 52);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(172, 20);
            this.txtIdCliente.TabIndex = 57;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 56;
            this.label3.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 20);
            this.label1.TabIndex = 55;
            this.label1.Text = "Identificación del cliente:";
            // 
            // btnVolverMenu
            // 
            this.btnVolverMenu.BackColor = System.Drawing.Color.Firebrick;
            this.btnVolverMenu.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnVolverMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverMenu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVolverMenu.Location = new System.Drawing.Point(30, 366);
            this.btnVolverMenu.Name = "btnVolverMenu";
            this.btnVolverMenu.Size = new System.Drawing.Size(156, 54);
            this.btnVolverMenu.TabIndex = 69;
            this.btnVolverMenu.Text = "Volver al menú principal";
            this.btnVolverMenu.UseVisualStyleBackColor = false;
            this.btnVolverMenu.Click += new System.EventHandler(this.btnVolverMenu_Click);
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 450);
            this.Controls.Add(this.btnVolverMenu);
            this.Controls.Add(this.btnGuardarCliente);
            this.Controls.Add(this.cmbJugadorEnLinea);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpFechaNacimiento);
            this.Controls.Add(this.txtPrimerApellidoCliente);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtSegundoApellidoCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNombreCLiente);
            this.Controls.Add(this.txtIdCliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "frmClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmClientes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardarCliente;
        private System.Windows.Forms.ComboBox cmbJugadorEnLinea;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.TextBox txtPrimerApellidoCliente;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSegundoApellidoCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombreCLiente;
        private System.Windows.Forms.TextBox txtIdCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVolverMenu;
    }
}