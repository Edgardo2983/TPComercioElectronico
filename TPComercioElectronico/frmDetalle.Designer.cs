namespace CapaPresentacion
{
    partial class frmDetalle
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
            this.lblSesion = new System.Windows.Forms.Label();
            this.picArticulo = new System.Windows.Forms.PictureBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblStaticNombre = new System.Windows.Forms.Label();
            this.lblStaticDescripcion = new System.Windows.Forms.Label();
            this.lblStaticPrecio = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblStaticStock = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picTopMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // picTopMenu
            // 
            this.picTopMenu.Image = global::CapaPresentacion.Properties.Resources.background_top_menu4;
            this.picTopMenu.Location = new System.Drawing.Point(65, 27);
            this.picTopMenu.Margin = new System.Windows.Forms.Padding(4);
            this.picTopMenu.Name = "picTopMenu";
            this.picTopMenu.Size = new System.Drawing.Size(1016, 102);
            this.picTopMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTopMenu.TabIndex = 1;
            this.picTopMenu.TabStop = false;
            // 
            // lblSesion
            // 
            this.lblSesion.AutoSize = true;
            this.lblSesion.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSesion.Image = global::CapaPresentacion.Properties.Resources.background_boton2;
            this.lblSesion.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblSesion.Location = new System.Drawing.Point(544, 142);
            this.lblSesion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSesion.Name = "lblSesion";
            this.lblSesion.Size = new System.Drawing.Size(273, 32);
            this.lblSesion.TabIndex = 10;
            this.lblSesion.Text = "Detalle de producto";
            // 
            // picArticulo
            // 
            this.picArticulo.Location = new System.Drawing.Point(65, 199);
            this.picArticulo.Name = "picArticulo";
            this.picArticulo.Size = new System.Drawing.Size(393, 323);
            this.picArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picArticulo.TabIndex = 11;
            this.picArticulo.TabStop = false;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(652, 238);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(64, 18);
            this.lblNombre.TabIndex = 12;
            this.lblNombre.Text = "Nombre";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(652, 284);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(92, 18);
            this.lblDescripcion.TabIndex = 13;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // lblStaticNombre
            // 
            this.lblStaticNombre.AutoSize = true;
            this.lblStaticNombre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaticNombre.Location = new System.Drawing.Point(535, 239);
            this.lblStaticNombre.Name = "lblStaticNombre";
            this.lblStaticNombre.Size = new System.Drawing.Size(68, 18);
            this.lblStaticNombre.TabIndex = 14;
            this.lblStaticNombre.Text = "Nombre:";
            // 
            // lblStaticDescripcion
            // 
            this.lblStaticDescripcion.AutoSize = true;
            this.lblStaticDescripcion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaticDescripcion.Location = new System.Drawing.Point(535, 284);
            this.lblStaticDescripcion.Name = "lblStaticDescripcion";
            this.lblStaticDescripcion.Size = new System.Drawing.Size(96, 18);
            this.lblStaticDescripcion.TabIndex = 15;
            this.lblStaticDescripcion.Text = "Descripción:";
            // 
            // lblStaticPrecio
            // 
            this.lblStaticPrecio.AutoSize = true;
            this.lblStaticPrecio.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaticPrecio.Location = new System.Drawing.Point(542, 338);
            this.lblStaticPrecio.Name = "lblStaticPrecio";
            this.lblStaticPrecio.Size = new System.Drawing.Size(58, 18);
            this.lblStaticPrecio.TabIndex = 16;
            this.lblStaticPrecio.Text = "Precio:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(662, 338);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(54, 18);
            this.lblPrecio.TabIndex = 17;
            this.lblPrecio.Text = "Precio";
            // 
            // lblStaticStock
            // 
            this.lblStaticStock.AutoSize = true;
            this.lblStaticStock.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaticStock.Location = new System.Drawing.Point(542, 390);
            this.lblStaticStock.Name = "lblStaticStock";
            this.lblStaticStock.Size = new System.Drawing.Size(52, 18);
            this.lblStaticStock.TabIndex = 18;
            this.lblStaticStock.Text = "Stock:";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock.Location = new System.Drawing.Point(664, 390);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(48, 18);
            this.lblStock.TabIndex = 19;
            this.lblStock.Text = "Stock";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackgroundImage = global::CapaPresentacion.Properties.Resources.background_boton2;
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(550, 484);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(215, 38);
            this.btnAgregar.TabIndex = 20;
            this.btnAgregar.Text = "Agregar al carrito";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // frmDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 602);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.lblStaticStock);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblStaticPrecio);
            this.Controls.Add(this.lblStaticDescripcion);
            this.Controls.Add(this.lblStaticNombre);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.picArticulo);
            this.Controls.Add(this.lblSesion);
            this.Controls.Add(this.picTopMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDetalle";
            this.Text = "frmDetalle";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDetalle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picTopMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picArticulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        //metodo creado para colocar los controles en coordenadas relativas, ya que cada monitor tiene distintas resoluciones.
        private void reubicarControles()
        {
            //int alto, ancho;
            //alto = this.Size.Height;
            //ancho = this.Size.Width;
            System.Windows.Forms.Screen screen = System.Windows.Forms.Screen.PrimaryScreen;
            int ancho = screen.Bounds.Width;
            int alto = screen.Bounds.Height;

            this.picTopMenu.Location = new System.Drawing.Point(0, 0);
            this.picTopMenu.Size = new System.Drawing.Size(ancho, porcentaje(8, alto));
            this.picTopMenu.SendToBack();
            this.lblSesion.Location = new System.Drawing.Point(porcentaje(45, ancho), porcentaje(3, alto));

            this.picArticulo.Location = new System.Drawing.Point(porcentaje(5, ancho), porcentaje(15, alto));
            this.picArticulo.Size = new System.Drawing.Size(porcentaje(25, ancho), porcentaje(40, alto));

            this.lblStaticNombre.Location = new System.Drawing.Point(porcentaje(35, ancho), porcentaje(20, alto));
            this.lblStaticDescripcion.Location = new System.Drawing.Point(porcentaje(35, ancho), porcentaje(25, alto));
            this.lblStaticPrecio.Location = new System.Drawing.Point(porcentaje(35, ancho), porcentaje(30, alto));
            this.lblStaticStock.Location = new System.Drawing.Point(porcentaje(35, ancho), porcentaje(35, alto));

            this.lblNombre.Location = new System.Drawing.Point(porcentaje(42, ancho), porcentaje(20, alto));
            this.lblDescripcion.Location = new System.Drawing.Point(porcentaje(42, ancho), porcentaje(25, alto));
            this.lblPrecio.Location = new System.Drawing.Point(porcentaje(42, ancho), porcentaje(30, alto));
            this.lblStock.Location = new System.Drawing.Point(porcentaje(42, ancho), porcentaje(35, alto));

            this.btnAgregar.Location = new System.Drawing.Point(porcentaje(35, ancho), porcentaje(51, alto));
            this.btnAgregar.Size = new System.Drawing.Size(porcentaje(12, ancho), porcentaje(4, alto));
        }

        private int porcentaje(int porcentaje, int total)
        {
            return total * porcentaje / 100;
        }

        private System.Windows.Forms.PictureBox picTopMenu;
        private System.Windows.Forms.Label lblSesion;
        private System.Windows.Forms.PictureBox picArticulo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblStaticNombre;
        private System.Windows.Forms.Label lblStaticDescripcion;
        private System.Windows.Forms.Label lblStaticPrecio;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblStaticStock;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Button btnAgregar;
    }
}