namespace CapaPresentacion
{
    partial class frmLogin
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
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.txtContrasenia = new System.Windows.Forms.TextBox();
            this.lblCodigoInterno = new System.Windows.Forms.Label();
            this.txtCodigoInterno = new System.Windows.Forms.TextBox();
            this.lblTipoUsuario = new System.Windows.Forms.Label();
            this.cmbTipoUsuario = new System.Windows.Forms.ComboBox();
            this.lblSesion = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnRegistro = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picTopMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // picTopMenu
            // 
            this.picTopMenu.Image = global::CapaPresentacion.Properties.Resources.background_top_menu4;
            this.picTopMenu.Location = new System.Drawing.Point(18, 17);
            this.picTopMenu.Margin = new System.Windows.Forms.Padding(4);
            this.picTopMenu.Name = "picTopMenu";
            this.picTopMenu.Size = new System.Drawing.Size(1016, 102);
            this.picTopMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTopMenu.TabIndex = 0;
            this.picTopMenu.TabStop = false;
            this.picTopMenu.Click += new System.EventHandler(this.picTopMenu_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(309, 285);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(290, 26);
            this.txtUsuario.TabIndex = 1;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(130, 285);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(66, 18);
            this.lblUsuario.TabIndex = 2;
            this.lblUsuario.Text = "Usuario:";
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Location = new System.Drawing.Point(130, 345);
            this.lblContraseña.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(93, 18);
            this.lblContraseña.TabIndex = 3;
            this.lblContraseña.Text = "Contraseña:";
            // 
            // txtContrasenia
            // 
            this.txtContrasenia.Location = new System.Drawing.Point(309, 345);
            this.txtContrasenia.Margin = new System.Windows.Forms.Padding(4);
            this.txtContrasenia.Name = "txtContrasenia";
            this.txtContrasenia.PasswordChar = '*';
            this.txtContrasenia.Size = new System.Drawing.Size(290, 26);
            this.txtContrasenia.TabIndex = 4;
            // 
            // lblCodigoInterno
            // 
            this.lblCodigoInterno.AutoSize = true;
            this.lblCodigoInterno.Location = new System.Drawing.Point(130, 400);
            this.lblCodigoInterno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigoInterno.Name = "lblCodigoInterno";
            this.lblCodigoInterno.Size = new System.Drawing.Size(115, 18);
            this.lblCodigoInterno.TabIndex = 5;
            this.lblCodigoInterno.Text = "Código interno:";
            this.lblCodigoInterno.Visible = false;
            // 
            // txtCodigoInterno
            // 
            this.txtCodigoInterno.Location = new System.Drawing.Point(309, 400);
            this.txtCodigoInterno.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigoInterno.Name = "txtCodigoInterno";
            this.txtCodigoInterno.Size = new System.Drawing.Size(290, 26);
            this.txtCodigoInterno.TabIndex = 6;
            this.txtCodigoInterno.Visible = false;
            // 
            // lblTipoUsuario
            // 
            this.lblTipoUsuario.AutoSize = true;
            this.lblTipoUsuario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoUsuario.Location = new System.Drawing.Point(130, 230);
            this.lblTipoUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoUsuario.Name = "lblTipoUsuario";
            this.lblTipoUsuario.Size = new System.Drawing.Size(119, 18);
            this.lblTipoUsuario.TabIndex = 7;
            this.lblTipoUsuario.Text = "Tipo de usuario:";
            // 
            // cmbTipoUsuario
            // 
            this.cmbTipoUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoUsuario.FormattingEnabled = true;
            this.cmbTipoUsuario.Location = new System.Drawing.Point(309, 226);
            this.cmbTipoUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTipoUsuario.Name = "cmbTipoUsuario";
            this.cmbTipoUsuario.Size = new System.Drawing.Size(290, 26);
            this.cmbTipoUsuario.TabIndex = 8;
            this.cmbTipoUsuario.SelectedIndexChanged += new System.EventHandler(this.cmbTipoUsuario_SelectedIndexChanged);
            // 
            // lblSesion
            // 
            this.lblSesion.AutoSize = true;
            this.lblSesion.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSesion.Image = global::CapaPresentacion.Properties.Resources.background_boton2;
            this.lblSesion.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblSesion.Location = new System.Drawing.Point(516, 152);
            this.lblSesion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSesion.Name = "lblSesion";
            this.lblSesion.Size = new System.Drawing.Size(223, 32);
            this.lblSesion.TabIndex = 9;
            this.lblSesion.Text = "Inicio de sesión";
            this.lblSesion.Click += new System.EventHandler(this.lblSesion_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackgroundImage = global::CapaPresentacion.Properties.Resources.background_boton2;
            this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogin.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(192, 497);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(149, 36);
            this.btnLogin.TabIndex = 10;
            this.btnLogin.Text = "Iniciar sesión";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.BackgroundImage = global::CapaPresentacion.Properties.Resources.background_boton2;
            this.btnVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVolver.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(601, 497);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(149, 36);
            this.btnVolver.TabIndex = 11;
            this.btnVolver.Text = "Volver al inicio";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnRegistro
            // 
            this.btnRegistro.BackgroundImage = global::CapaPresentacion.Properties.Resources.background_boton2;
            this.btnRegistro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRegistro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistro.Location = new System.Drawing.Point(394, 497);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Size = new System.Drawing.Size(149, 36);
            this.btnRegistro.TabIndex = 12;
            this.btnRegistro.Text = "Registrarme";
            this.btnRegistro.UseVisualStyleBackColor = true;
            this.btnRegistro.Click += new System.EventHandler(this.btnRegistro_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 572);
            this.Controls.Add(this.btnRegistro);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblSesion);
            this.Controls.Add(this.cmbTipoUsuario);
            this.Controls.Add(this.lblTipoUsuario);
            this.Controls.Add(this.txtCodigoInterno);
            this.Controls.Add(this.lblCodigoInterno);
            this.Controls.Add(this.txtContrasenia);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.picTopMenu);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.Text = "Inicio de Sesión";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmLogin_Load);
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
            this.lblSesion.Location = new System.Drawing.Point(porcentaje(45, ancho), porcentaje(3, alto));
            //formulario
            this.lblTipoUsuario.Location = new System.Drawing.Point(porcentaje(35, ancho), porcentaje(30, alto));
            this.lblUsuario.Location = new System.Drawing.Point(porcentaje(35, ancho), porcentaje(35, alto));
            this.lblContraseña.Location = new System.Drawing.Point(porcentaje(35, ancho), porcentaje(40, alto));
            this.lblCodigoInterno.Location = new System.Drawing.Point(porcentaje(35, ancho), porcentaje(45, alto));

            this.cmbTipoUsuario.Location = new System.Drawing.Point(porcentaje(45, ancho), porcentaje(30, alto));
            this.txtUsuario.Location = new System.Drawing.Point(porcentaje(45, ancho), porcentaje(35, alto));
            this.txtContrasenia.Location = new System.Drawing.Point(porcentaje(45, ancho), porcentaje(40, alto));
            this.txtCodigoInterno.Location = new System.Drawing.Point(porcentaje(45, ancho), porcentaje(45, alto));
            //botones
            this.btnLogin.Location = new System.Drawing.Point(porcentaje(35, ancho), porcentaje(50, alto));
            this.btnRegistro.Location = new System.Drawing.Point(porcentaje(45, ancho), porcentaje(50, alto));
            this.btnVolver.Location = new System.Drawing.Point(porcentaje(55, ancho), porcentaje(50, alto));

        }

        private int porcentaje(int porcentaje, int total)
        {
            return total * porcentaje / 100;
        }

        private System.Windows.Forms.PictureBox picTopMenu;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.TextBox txtContrasenia;
        private System.Windows.Forms.Label lblCodigoInterno;
        private System.Windows.Forms.TextBox txtCodigoInterno;
        private System.Windows.Forms.Label lblTipoUsuario;
        private System.Windows.Forms.ComboBox cmbTipoUsuario;
        private System.Windows.Forms.Label lblSesion;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnRegistro;
    }
}