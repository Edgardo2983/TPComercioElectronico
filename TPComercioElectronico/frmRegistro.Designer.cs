namespace TPComercioElectronico
{
    partial class frmRegistro
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
            this.picTopMenu = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblDomicilio = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.lblRepetir = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtDomicilio = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.txtRepetir = new System.Windows.Forms.TextBox();
            this.btnRegistro = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picTopMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // picTopMenu
            // 
            this.picTopMenu.BackgroundImage = global::TPComercioElectronico.Properties.Resources.background_top_menu4;
            this.picTopMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picTopMenu.Location = new System.Drawing.Point(36, 27);
            this.picTopMenu.Name = "picTopMenu";
            this.picTopMenu.Size = new System.Drawing.Size(726, 112);
            this.picTopMenu.TabIndex = 0;
            this.picTopMenu.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Image = global::TPComercioElectronico.Properties.Resources.background_boton2;
            this.lblTitulo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblTitulo.Location = new System.Drawing.Point(398, 94);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(364, 32);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Registro de nuevo usuario";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(214, 196);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(68, 18);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre:";
            this.lblNombre.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(214, 234);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(65, 18);
            this.lblApellido.TabIndex = 3;
            this.lblApellido.Text = "Apellido";
            // 
            // lblDomicilio
            // 
            this.lblDomicilio.AutoSize = true;
            this.lblDomicilio.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDomicilio.Location = new System.Drawing.Point(214, 269);
            this.lblDomicilio.Name = "lblDomicilio";
            this.lblDomicilio.Size = new System.Drawing.Size(78, 18);
            this.lblDomicilio.TabIndex = 4;
            this.lblDomicilio.Text = "Domicilio:";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(214, 305);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(70, 18);
            this.lblTelefono.TabIndex = 5;
            this.lblTelefono.Text = "Teléfono:";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMail.Location = new System.Drawing.Point(214, 344);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(41, 18);
            this.lblMail.TabIndex = 6;
            this.lblMail.Text = "Mail:";
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseña.Location = new System.Drawing.Point(214, 382);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(93, 18);
            this.lblContraseña.TabIndex = 7;
            this.lblContraseña.Text = "Contraseña:";
            // 
            // lblRepetir
            // 
            this.lblRepetir.AutoSize = true;
            this.lblRepetir.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepetir.Location = new System.Drawing.Point(214, 421);
            this.lblRepetir.Name = "lblRepetir";
            this.lblRepetir.Size = new System.Drawing.Size(144, 18);
            this.lblRepetir.TabIndex = 8;
            this.lblRepetir.Text = "Repetir contraseña:";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(404, 197);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(256, 26);
            this.txtNombre.TabIndex = 9;
            // 
            // txtApellido
            // 
            this.txtApellido.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.Location = new System.Drawing.Point(404, 234);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(256, 26);
            this.txtApellido.TabIndex = 10;
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDomicilio.Location = new System.Drawing.Point(404, 269);
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.Size = new System.Drawing.Size(256, 26);
            this.txtDomicilio.TabIndex = 11;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(404, 305);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(256, 26);
            this.txtTelefono.TabIndex = 12;
            // 
            // txtMail
            // 
            this.txtMail.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMail.Location = new System.Drawing.Point(404, 344);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(256, 26);
            this.txtMail.TabIndex = 13;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.Location = new System.Drawing.Point(404, 382);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.Size = new System.Drawing.Size(256, 26);
            this.txtContraseña.TabIndex = 14;
            // 
            // txtRepetir
            // 
            this.txtRepetir.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRepetir.Location = new System.Drawing.Point(404, 421);
            this.txtRepetir.Name = "txtRepetir";
            this.txtRepetir.PasswordChar = '*';
            this.txtRepetir.Size = new System.Drawing.Size(256, 26);
            this.txtRepetir.TabIndex = 15;
            // 
            // btnRegistro
            // 
            this.btnRegistro.BackgroundImage = global::TPComercioElectronico.Properties.Resources.background_boton2;
            this.btnRegistro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRegistro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistro.Location = new System.Drawing.Point(259, 514);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Size = new System.Drawing.Size(149, 36);
            this.btnRegistro.TabIndex = 16;
            this.btnRegistro.Text = "Registrarse";
            this.btnRegistro.UseVisualStyleBackColor = true;
            this.btnRegistro.Click += new System.EventHandler(this.btnRegistro_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.BackgroundImage = global::TPComercioElectronico.Properties.Resources.background_boton2;
            this.btnVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVolver.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(511, 514);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(149, 36);
            this.btnVolver.TabIndex = 17;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // frmRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 629);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnRegistro);
            this.Controls.Add(this.txtRepetir);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtDomicilio);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblRepetir);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblDomicilio);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.picTopMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRegistro";
            this.Text = "Registro de nuevo usuario";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmRegistro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picTopMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private void reubicarControles()
        {
            int alto, ancho;
            alto = this.Size.Height;
            ancho = this.Size.Width;
            //top menu
            this.picTopMenu.Location = new System.Drawing.Point(0, 0);
            this.picTopMenu.Size = new System.Drawing.Size(ancho, porcentaje(8, alto));
            this.lblTitulo.Location = new System.Drawing.Point(porcentaje(45, ancho), porcentaje(3, alto));
            //formulario
            this.lblNombre.Location = new System.Drawing.Point(porcentaje(35, ancho), porcentaje(30, alto));
            this.lblApellido.Location = new System.Drawing.Point(porcentaje(35, ancho), porcentaje(35, alto));
            this.lblDomicilio.Location = new System.Drawing.Point(porcentaje(35, ancho), porcentaje(40, alto));
            this.lblTelefono.Location = new System.Drawing.Point(porcentaje(35, ancho), porcentaje(45, alto));
            this.lblMail.Location = new System.Drawing.Point(porcentaje(35, ancho), porcentaje(50, alto));
            this.lblContraseña.Location = new System.Drawing.Point(porcentaje(35, ancho), porcentaje(55, alto));
            this.lblRepetir.Location = new System.Drawing.Point(porcentaje(35, ancho), porcentaje(60, alto));

            this.txtNombre.Location = new System.Drawing.Point(porcentaje(45, ancho), porcentaje(30, alto));
            this.txtApellido.Location = new System.Drawing.Point(porcentaje(45, ancho), porcentaje(35, alto));
            this.txtDomicilio.Location = new System.Drawing.Point(porcentaje(45, ancho), porcentaje(40, alto));
            this.txtTelefono.Location = new System.Drawing.Point(porcentaje(45, ancho), porcentaje(45, alto));
            this.txtMail.Location = new System.Drawing.Point(porcentaje(45, ancho), porcentaje(50, alto));
            this.txtContraseña.Location = new System.Drawing.Point(porcentaje(45, ancho), porcentaje(55, alto));
            this.txtRepetir.Location = new System.Drawing.Point(porcentaje(45, ancho), porcentaje(60, alto));

            this.btnRegistro.Location = new System.Drawing.Point(porcentaje(40, ancho), porcentaje (70, alto));
            this.btnVolver.Location = new System.Drawing.Point(porcentaje(50, ancho), porcentaje(70, alto));

        }

        private int porcentaje(int porcentaje, int total)
        {
            return total * porcentaje / 100;
        }

        private System.Windows.Forms.PictureBox picTopMenu;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblDomicilio;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.Label lblRepetir;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtDomicilio;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.TextBox txtRepetir;
        private System.Windows.Forms.Button btnRegistro;
        private System.Windows.Forms.Button btnVolver;
    }
}