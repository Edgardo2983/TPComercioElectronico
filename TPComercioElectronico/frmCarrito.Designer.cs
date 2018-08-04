namespace CapaPresentacion
{
    partial class frmCarrito
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
            this.components = new System.ComponentModel.Container();
            this.picTopMenu = new System.Windows.Forms.PictureBox();
            this.lblCarrito = new System.Windows.Forms.Label();
            this.grilla = new System.Windows.Forms.DataGridView();
            this.lblTotal = new System.Windows.Forms.Label();
            this.carritoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnComprar = new System.Windows.Forms.Button();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quitar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picTopMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grilla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carritoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // picTopMenu
            // 
            this.picTopMenu.Image = global::CapaPresentacion.Properties.Resources.background_top_menu4;
            this.picTopMenu.Location = new System.Drawing.Point(12, 12);
            this.picTopMenu.Name = "picTopMenu";
            this.picTopMenu.Size = new System.Drawing.Size(511, 97);
            this.picTopMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTopMenu.TabIndex = 3;
            this.picTopMenu.TabStop = false;
            // 
            // lblCarrito
            // 
            this.lblCarrito.AutoSize = true;
            this.lblCarrito.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarrito.Image = global::CapaPresentacion.Properties.Resources.background_boton2;
            this.lblCarrito.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblCarrito.Location = new System.Drawing.Point(393, 59);
            this.lblCarrito.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCarrito.Name = "lblCarrito";
            this.lblCarrito.Size = new System.Drawing.Size(106, 32);
            this.lblCarrito.TabIndex = 10;
            this.lblCarrito.Text = "Carrito";
            // 
            // grilla
            // 
            this.grilla.AllowUserToAddRows = false;
            this.grilla.AllowUserToDeleteRows = false;
            this.grilla.AllowUserToOrderColumns = true;
            this.grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Item,
            this.Nombre,
            this.Precio,
            this.Cantidad,
            this.SubTotal,
            this.Quitar});
            this.grilla.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grilla.Location = new System.Drawing.Point(160, 204);
            this.grilla.Name = "grilla";
            this.grilla.ReadOnly = true;
            this.grilla.Size = new System.Drawing.Size(694, 194);
            this.grilla.TabIndex = 11;
            this.grilla.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grilla_CellClick);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(155, 446);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(325, 27);
            this.lblTotal.TabIndex = 12;
            this.lblTotal.Text = "El total hasta el momento es:";
            // 
            // carritoBindingSource
            // 
            this.carritoBindingSource.DataSource = typeof(CapaNegocio.Carrito);
            // 
            // btnComprar
            // 
            this.btnComprar.BackgroundImage = global::CapaPresentacion.Properties.Resources.background_boton2;
            this.btnComprar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnComprar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComprar.Location = new System.Drawing.Point(322, 517);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(177, 38);
            this.btnComprar.TabIndex = 21;
            this.btnComprar.Text = "Comprar";
            this.btnComprar.UseVisualStyleBackColor = true;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(155, 156);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(486, 27);
            this.lblDescripcion.TabIndex = 22;
            this.lblDescripcion.Text = "Listado de los artículos agregados al carrito:";
            // 
            // Item
            // 
            this.Item.HeaderText = "Item";
            this.Item.Name = "Item";
            this.Item.ReadOnly = true;
            this.Item.Width = 50;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 250;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // SubTotal
            // 
            this.SubTotal.HeaderText = "Sub Total";
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.ReadOnly = true;
            // 
            // Quitar
            // 
            this.Quitar.HeaderText = "Quitar";
            this.Quitar.Name = "Quitar";
            this.Quitar.ReadOnly = true;
            this.Quitar.Width = 50;
            // 
            // btnVolver
            // 
            this.btnVolver.BackgroundImage = global::CapaPresentacion.Properties.Resources.background_boton2;
            this.btnVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVolver.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(598, 517);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(177, 38);
            this.btnVolver.TabIndex = 23;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // frmCarrito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 593);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.btnComprar);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.grilla);
            this.Controls.Add(this.lblCarrito);
            this.Controls.Add(this.picTopMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCarrito";
            this.Text = "Carrito";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCarrito_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picTopMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grilla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carritoBindingSource)).EndInit();
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

            //top menu
            this.picTopMenu.Location = new System.Drawing.Point(0, 0);
            this.picTopMenu.Size = new System.Drawing.Size(ancho, porcentaje(8, alto));
            this.picTopMenu.SendToBack();
            this.lblCarrito.Location = new System.Drawing.Point(porcentaje(45, ancho), porcentaje(3, alto));
            //lblDescripcion
            this.lblDescripcion.Location = new System.Drawing.Point(porcentaje(38, ancho), porcentaje(16, alto));
            //listview
            this.grilla.Location = new System.Drawing.Point(porcentaje(30, ancho), porcentaje(20, alto));
            this.grilla.Size = new System.Drawing.Size(porcentaje(40, ancho), porcentaje(30, alto));
            //lblTotal
            this.lblTotal.Location = new System.Drawing.Point(porcentaje(38, ancho), porcentaje(55, alto));
            //btnComprar
            this.btnComprar.Location = new System.Drawing.Point(porcentaje(35, ancho), porcentaje(65, alto));
            //btnVolver
            this.btnVolver.Location = new System.Drawing.Point(porcentaje(50, ancho), porcentaje(65, alto));

        }

        private int porcentaje(int porcentaje, int total)
        {
            return total * porcentaje / 100;
        }

        private System.Windows.Forms.PictureBox picTopMenu;
        private System.Windows.Forms.Label lblCarrito;
        private System.Windows.Forms.DataGridView grilla;
        private System.Windows.Forms.BindingSource carritoBindingSource;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.DataGridViewButtonColumn Quitar;
        private System.Windows.Forms.Button btnVolver;
    }
}