namespace MyPrimeraApp
{
    partial class frmMaestros
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
            lblNombre = new Label();
            lblApellido = new Label();
            lblEdad = new Label();
            lblEmail = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtEmail = new TextBox();
            txtEdad = new TextBox();
            btnGuardar = new Button();
            txtDireccion = new TextBox();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(45, 73);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(78, 25);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(45, 136);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(78, 25);
            lblApellido.TabIndex = 1;
            lblApellido.Text = "Apellido";
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Location = new Point(45, 284);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(52, 25);
            lblEdad.TabIndex = 3;
            lblEdad.Text = "Edad";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(45, 210);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(54, 25);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Email";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(45, 102);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(150, 31);
            txtNombre.TabIndex = 4;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(45, 176);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(150, 31);
            txtApellido.TabIndex = 5;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(45, 250);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(150, 31);
            txtEmail.TabIndex = 6;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(45, 312);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(150, 31);
            txtEdad.TabIndex = 7;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(204, 379);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(112, 34);
            btnGuardar.TabIndex = 8;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(325, 210);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(150, 31);
            txtDireccion.TabIndex = 9;
            // 
            // frmMaestros
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtDireccion);
            Controls.Add(btnGuardar);
            Controls.Add(txtEdad);
            Controls.Add(txtEmail);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(lblEdad);
            Controls.Add(lblEmail);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Name = "frmMaestros";
            Text = "frmMaestros";
            Load += frmMaestros_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private Label lblApellido;
        private Label lblEdad;
        private Label lblEmail;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtEmail;
        private TextBox txtEdad;
        private Button btnGuardar;
        private TextBox txtDireccion;
    }
}