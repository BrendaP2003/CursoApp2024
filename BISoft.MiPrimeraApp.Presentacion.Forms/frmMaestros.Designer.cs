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
            lblDirecion = new Label();
            lblEmail = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtEmail = new TextBox();
            txtDirecion = new TextBox();
            btnGuardar = new Button();
            txtTelefono = new TextBox();
            lblTelefono = new Label();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(32, 44);
            lblNombre.Margin = new Padding(2, 0, 2, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(32, 82);
            lblApellido.Margin = new Padding(2, 0, 2, 0);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(51, 15);
            lblApellido.TabIndex = 1;
            lblApellido.Text = "Apellido";
            // 
            // lblDirecion
            // 
            lblDirecion.AutoSize = true;
            lblDirecion.Location = new Point(32, 170);
            lblDirecion.Margin = new Padding(2, 0, 2, 0);
            lblDirecion.Name = "lblDirecion";
            lblDirecion.Size = new Size(57, 15);
            lblDirecion.TabIndex = 3;
            lblDirecion.Text = "Direccion";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(32, 126);
            lblEmail.Margin = new Padding(2, 0, 2, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Email";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(32, 61);
            txtNombre.Margin = new Padding(2, 2, 2, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(106, 23);
            txtNombre.TabIndex = 4;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(32, 106);
            txtApellido.Margin = new Padding(2, 2, 2, 2);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(106, 23);
            txtApellido.TabIndex = 5;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(32, 150);
            txtEmail.Margin = new Padding(2, 2, 2, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(106, 23);
            txtEmail.TabIndex = 6;
            // 
            // txtDirecion
            // 
            txtDirecion.Location = new Point(32, 187);
            txtDirecion.Margin = new Padding(2, 2, 2, 2);
            txtDirecion.Name = "txtDirecion";
            txtDirecion.Size = new Size(106, 23);
            txtDirecion.TabIndex = 7;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(143, 227);
            btnGuardar.Margin = new Padding(2, 2, 2, 2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(78, 20);
            btnGuardar.TabIndex = 8;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(228, 126);
            txtTelefono.Margin = new Padding(2, 2, 2, 2);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(106, 23);
            txtTelefono.TabIndex = 9;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(228, 106);
            lblTelefono.Margin = new Padding(2, 0, 2, 0);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(52, 15);
            lblTelefono.TabIndex = 10;
            lblTelefono.Text = "Telefono";
            // 
            // frmMaestros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 270);
            Controls.Add(lblTelefono);
            Controls.Add(txtTelefono);
            Controls.Add(btnGuardar);
            Controls.Add(txtDirecion);
            Controls.Add(txtEmail);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(lblDirecion);
            Controls.Add(lblEmail);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Margin = new Padding(2, 2, 2, 2);
            Name = "frmMaestros";
            Text = "frmMaestros";
            Load += frmMaestros_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private Label lblApellido;
        private Label lblDirecion;
        private Label lblEmail;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtEmail;
        private TextBox txtDirecion;
        private Button btnGuardar;
        private TextBox txtTelefono;
        private Label lblTelefono;
    }
}