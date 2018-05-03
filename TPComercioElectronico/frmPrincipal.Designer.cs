namespace TPComercioElectronico
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.picSlogan = new System.Windows.Forms.PictureBox();
            this.btnBusqueda = new System.Windows.Forms.Button();
            this.picTopMenu = new System.Windows.Forms.PictureBox();
            this.btnRegistro = new System.Windows.Forms.Button();
            this.btnSesion = new System.Windows.Forms.Button();
            this.listView = new System.Windows.Forms.ListView();
            this.picMidMenu = new System.Windows.Forms.PictureBox();
            this.lnkCocina = new System.Windows.Forms.LinkLabel();
            this.lnkBaño = new System.Windows.Forms.LinkLabel();
            this.lnkIluminacion = new System.Windows.Forms.LinkLabel();
            this.lnkMuebles = new System.Windows.Forms.LinkLabel();
            this.lnkDecoracion = new System.Windows.Forms.LinkLabel();
            this.lnkAccesorios = new System.Windows.Forms.LinkLabel();
            this.lnkJardin = new System.Windows.Forms.LinkLabel();
            this.lnkEscritorio = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.picSlogan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTopMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMidMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusqueda.Location = new System.Drawing.Point(21, 31);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(172, 29);
            this.txtBusqueda.TabIndex = 4;
            // 
            // picSlogan
            // 
            this.picSlogan.BackgroundImage = global::TPComercioElectronico.Properties.Resources.slogan1;
            this.picSlogan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picSlogan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picSlogan.Location = new System.Drawing.Point(277, 115);
            this.picSlogan.Name = "picSlogan";
            this.picSlogan.Size = new System.Drawing.Size(740, 159);
            this.picSlogan.TabIndex = 6;
            this.picSlogan.TabStop = false;
            // 
            // btnBusqueda
            // 
            this.btnBusqueda.BackgroundImage = global::TPComercioElectronico.Properties.Resources.background_boton2;
            this.btnBusqueda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBusqueda.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBusqueda.Location = new System.Drawing.Point(214, 31);
            this.btnBusqueda.Name = "btnBusqueda";
            this.btnBusqueda.Size = new System.Drawing.Size(93, 43);
            this.btnBusqueda.TabIndex = 3;
            this.btnBusqueda.Text = "Buscar";
            this.btnBusqueda.UseVisualStyleBackColor = true;
            // 
            // picTopMenu
            // 
            this.picTopMenu.Image = global::TPComercioElectronico.Properties.Resources.background_top_menu4;
            this.picTopMenu.Location = new System.Drawing.Point(12, 12);
            this.picTopMenu.Name = "picTopMenu";
            this.picTopMenu.Size = new System.Drawing.Size(511, 97);
            this.picTopMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTopMenu.TabIndex = 2;
            this.picTopMenu.TabStop = false;
            // 
            // btnRegistro
            // 
            this.btnRegistro.BackgroundImage = global::TPComercioElectronico.Properties.Resources.background_boton21;
            this.btnRegistro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRegistro.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistro.Location = new System.Drawing.Point(1162, 12);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Size = new System.Drawing.Size(111, 38);
            this.btnRegistro.TabIndex = 1;
            this.btnRegistro.Text = "Registrarse";
            this.btnRegistro.UseVisualStyleBackColor = true;
            this.btnRegistro.Click += new System.EventHandler(this.btnRegistro_Click);
            // 
            // btnSesion
            // 
            this.btnSesion.BackgroundImage = global::TPComercioElectronico.Properties.Resources.background_boton2;
            this.btnSesion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSesion.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSesion.Location = new System.Drawing.Point(1295, 12);
            this.btnSesion.Name = "btnSesion";
            this.btnSesion.Size = new System.Drawing.Size(111, 38);
            this.btnSesion.TabIndex = 0;
            this.btnSesion.Text = "Iniciar Sesión";
            this.btnSesion.UseVisualStyleBackColor = true;
            this.btnSesion.Click += new System.EventHandler(this.btnSesion_Click);
            // 
            // listView
            // 
            this.listView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView.Location = new System.Drawing.Point(59, 344);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(1248, 202);
            this.listView.TabIndex = 7;
            this.listView.UseCompatibleStateImageBehavior = false;
            // 
            // picMidMenu
            // 
            this.picMidMenu.Image = global::TPComercioElectronico.Properties.Resources.background_top_menu4;
            this.picMidMenu.Location = new System.Drawing.Point(21, 289);
            this.picMidMenu.Name = "picMidMenu";
            this.picMidMenu.Size = new System.Drawing.Size(1361, 38);
            this.picMidMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMidMenu.TabIndex = 8;
            this.picMidMenu.TabStop = false;
            // 
            // lnkCocina
            // 
            this.lnkCocina.AutoSize = true;
            this.lnkCocina.BackColor = System.Drawing.Color.Transparent;
            this.lnkCocina.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkCocina.Image = global::TPComercioElectronico.Properties.Resources.background_boton21;
            this.lnkCocina.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lnkCocina.LinkColor = System.Drawing.Color.Black;
            this.lnkCocina.Location = new System.Drawing.Point(86, 305);
            this.lnkCocina.Name = "lnkCocina";
            this.lnkCocina.Size = new System.Drawing.Size(75, 22);
            this.lnkCocina.TabIndex = 9;
            this.lnkCocina.TabStop = true;
            this.lnkCocina.Text = "Cocina";
            // 
            // lnkBaño
            // 
            this.lnkBaño.AutoSize = true;
            this.lnkBaño.BackColor = System.Drawing.Color.Transparent;
            this.lnkBaño.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkBaño.Image = global::TPComercioElectronico.Properties.Resources.background_boton2;
            this.lnkBaño.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lnkBaño.LinkColor = System.Drawing.Color.Black;
            this.lnkBaño.Location = new System.Drawing.Point(224, 305);
            this.lnkBaño.Name = "lnkBaño";
            this.lnkBaño.Size = new System.Drawing.Size(59, 22);
            this.lnkBaño.TabIndex = 10;
            this.lnkBaño.TabStop = true;
            this.lnkBaño.Text = "Baño";
            // 
            // lnkIluminacion
            // 
            this.lnkIluminacion.AutoSize = true;
            this.lnkIluminacion.BackColor = System.Drawing.Color.Transparent;
            this.lnkIluminacion.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkIluminacion.Image = global::TPComercioElectronico.Properties.Resources.background_boton2;
            this.lnkIluminacion.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lnkIluminacion.LinkColor = System.Drawing.Color.Black;
            this.lnkIluminacion.Location = new System.Drawing.Point(349, 305);
            this.lnkIluminacion.Name = "lnkIluminacion";
            this.lnkIluminacion.Size = new System.Drawing.Size(117, 22);
            this.lnkIluminacion.TabIndex = 11;
            this.lnkIluminacion.TabStop = true;
            this.lnkIluminacion.Text = "Iluminación";
            // 
            // lnkMuebles
            // 
            this.lnkMuebles.AutoSize = true;
            this.lnkMuebles.BackColor = System.Drawing.Color.Transparent;
            this.lnkMuebles.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkMuebles.Image = global::TPComercioElectronico.Properties.Resources.background_boton2;
            this.lnkMuebles.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lnkMuebles.LinkColor = System.Drawing.Color.Black;
            this.lnkMuebles.Location = new System.Drawing.Point(558, 305);
            this.lnkMuebles.Name = "lnkMuebles";
            this.lnkMuebles.Size = new System.Drawing.Size(89, 22);
            this.lnkMuebles.TabIndex = 12;
            this.lnkMuebles.TabStop = true;
            this.lnkMuebles.Text = "Muebles";
            // 
            // lnkDecoracion
            // 
            this.lnkDecoracion.AutoSize = true;
            this.lnkDecoracion.BackColor = System.Drawing.Color.Transparent;
            this.lnkDecoracion.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkDecoracion.Image = global::TPComercioElectronico.Properties.Resources.background_boton2;
            this.lnkDecoracion.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lnkDecoracion.LinkColor = System.Drawing.Color.Black;
            this.lnkDecoracion.Location = new System.Drawing.Point(725, 305);
            this.lnkDecoracion.Name = "lnkDecoracion";
            this.lnkDecoracion.Size = new System.Drawing.Size(117, 22);
            this.lnkDecoracion.TabIndex = 13;
            this.lnkDecoracion.TabStop = true;
            this.lnkDecoracion.Text = "Decoración";
            // 
            // lnkAccesorios
            // 
            this.lnkAccesorios.AutoSize = true;
            this.lnkAccesorios.BackColor = System.Drawing.Color.Transparent;
            this.lnkAccesorios.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkAccesorios.Image = global::TPComercioElectronico.Properties.Resources.background_boton2;
            this.lnkAccesorios.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lnkAccesorios.LinkColor = System.Drawing.Color.Black;
            this.lnkAccesorios.Location = new System.Drawing.Point(920, 305);
            this.lnkAccesorios.Name = "lnkAccesorios";
            this.lnkAccesorios.Size = new System.Drawing.Size(115, 22);
            this.lnkAccesorios.TabIndex = 14;
            this.lnkAccesorios.TabStop = true;
            this.lnkAccesorios.Text = "Accesorios";
            // 
            // lnkJardin
            // 
            this.lnkJardin.AutoSize = true;
            this.lnkJardin.BackColor = System.Drawing.Color.Transparent;
            this.lnkJardin.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkJardin.Image = global::TPComercioElectronico.Properties.Resources.background_boton2;
            this.lnkJardin.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lnkJardin.LinkColor = System.Drawing.Color.Black;
            this.lnkJardin.Location = new System.Drawing.Point(1108, 305);
            this.lnkJardin.Name = "lnkJardin";
            this.lnkJardin.Size = new System.Drawing.Size(69, 22);
            this.lnkJardin.TabIndex = 15;
            this.lnkJardin.TabStop = true;
            this.lnkJardin.Text = "Jardín";
            // 
            // lnkEscritorio
            // 
            this.lnkEscritorio.AutoSize = true;
            this.lnkEscritorio.BackColor = System.Drawing.Color.Transparent;
            this.lnkEscritorio.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkEscritorio.Image = global::TPComercioElectronico.Properties.Resources.background_boton2;
            this.lnkEscritorio.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lnkEscritorio.LinkColor = System.Drawing.Color.Black;
            this.lnkEscritorio.Location = new System.Drawing.Point(1227, 305);
            this.lnkEscritorio.Name = "lnkEscritorio";
            this.lnkEscritorio.Size = new System.Drawing.Size(101, 22);
            this.lnkEscritorio.TabIndex = 16;
            this.lnkEscritorio.TabStop = true;
            this.lnkEscritorio.Text = "Escritorio";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1418, 624);
            this.Controls.Add(this.lnkEscritorio);
            this.Controls.Add(this.lnkJardin);
            this.Controls.Add(this.lnkAccesorios);
            this.Controls.Add(this.lnkDecoracion);
            this.Controls.Add(this.lnkMuebles);
            this.Controls.Add(this.lnkIluminacion);
            this.Controls.Add(this.lnkBaño);
            this.Controls.Add(this.lnkCocina);
            this.Controls.Add(this.picMidMenu);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.picSlogan);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.btnBusqueda);
            this.Controls.Add(this.picTopMenu);
            this.Controls.Add(this.btnRegistro);
            this.Controls.Add(this.btnSesion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picSlogan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTopMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMidMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        //metodo creado para colocar los controles en coordenadas relativas, ya que cada monitor tiene distintas resoluciones.
        private void reubicarControles()
        {
            int alto, ancho;
            alto = this.Size.Height;
            ancho = this.Size.Width;
            //top menu
            this.btnSesion.Location = new System.Drawing.Point(porcentaje(90, ancho), porcentaje(2, alto));
            this.btnSesion.Size = new System.Drawing.Size(porcentaje(8, ancho), porcentaje(5, alto));
            this.btnRegistro.Location = new System.Drawing.Point(porcentaje(80, ancho), porcentaje(2, alto));
            this.btnRegistro.Size = new System.Drawing.Size(porcentaje(8, ancho), porcentaje(5, alto));
            this.txtBusqueda.Location = new System.Drawing.Point(porcentaje(2, ancho), porcentaje(3, alto));
            this.txtBusqueda.Size = new System.Drawing.Size(porcentaje(16, ancho), porcentaje(5, alto));
            this.btnBusqueda.Location = new System.Drawing.Point(porcentaje(20, ancho), porcentaje(2, alto));
            this.btnBusqueda.Size = new System.Drawing.Size(porcentaje(8, ancho), porcentaje(5, alto));
            this.picTopMenu.Location = new System.Drawing.Point(0, 0);
            this.picTopMenu.Size = new System.Drawing.Size(ancho, porcentaje(8, alto));
            this.picTopMenu.SendToBack();
            //slogan
            this.picSlogan.Location = new System.Drawing.Point(porcentaje(30, ancho), porcentaje(8, alto));
            this.picSlogan.Size = new System.Drawing.Size(porcentaje(40, ancho), porcentaje(25, alto));
            //mid menu
            this.picMidMenu.Location = new System.Drawing.Point(0, porcentaje(33, alto));
            this.picMidMenu.Size = new System.Drawing.Size(ancho, porcentaje(6, alto));
            this.picMidMenu.SendToBack();
            this.lnkCocina.Location = new System.Drawing.Point(porcentaje(10, ancho), porcentaje(35, alto));
            this.lnkBaño.Location = new System.Drawing.Point(porcentaje(20, ancho), porcentaje(35, alto));
            this.lnkIluminacion.Location = new System.Drawing.Point(porcentaje(30, ancho), porcentaje(35, alto));
            this.lnkMuebles.Location = new System.Drawing.Point(porcentaje(40, ancho), porcentaje(35, alto));
            this.lnkDecoracion.Location = new System.Drawing.Point(porcentaje(50, ancho), porcentaje(35, alto));
            this.lnkAccesorios.Location = new System.Drawing.Point(porcentaje(60, ancho), porcentaje(35, alto));
            this.lnkJardin.Location = new System.Drawing.Point(porcentaje(70, ancho), porcentaje(35, alto));
            this.lnkEscritorio.Location = new System.Drawing.Point(porcentaje(80, ancho), porcentaje(35, alto));

            //listview
            this.listView.Location = new System.Drawing.Point(porcentaje(15, ancho), porcentaje(40, alto));
            this.listView.Size = new System.Drawing.Size(porcentaje(70, ancho), porcentaje(50, alto));

        }

        private int porcentaje(int porcentaje, int total)
        {
            return total * porcentaje / 100;
        }

        #endregion

        private System.Windows.Forms.Button btnSesion;
        private System.Windows.Forms.Button btnRegistro;
        private System.Windows.Forms.PictureBox picTopMenu;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.Button btnBusqueda;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.PictureBox picSlogan;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.PictureBox picMidMenu;
        private System.Windows.Forms.LinkLabel lnkCocina;
        private System.Windows.Forms.LinkLabel lnkBaño;
        private System.Windows.Forms.LinkLabel lnkIluminacion;
        private System.Windows.Forms.LinkLabel lnkMuebles;
        private System.Windows.Forms.LinkLabel lnkDecoracion;
        private System.Windows.Forms.LinkLabel lnkAccesorios;
        private System.Windows.Forms.LinkLabel lnkJardin;
        private System.Windows.Forms.LinkLabel lnkEscritorio;
    }
}

