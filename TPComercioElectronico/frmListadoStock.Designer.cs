namespace CapaPresentacion
{
    partial class frmListadoStock
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.btnPedido = new System.Windows.Forms.Button();
            this.btnMostrarArticulos = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.GrillaStockMenor = new System.Windows.Forms.DataGridView();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnMostrarDetalle = new System.Windows.Forms.Button();
            this.cmbArticulo = new System.Windows.Forms.ComboBox();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.grillaDetalleStock = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ID_Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaStockMenor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaDetalleStock)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtFecha);
            this.panel1.Controls.Add(this.btnPedido);
            this.panel1.Controls.Add(this.btnMostrarArticulos);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.GrillaStockMenor);
            this.panel1.Controls.Add(this.btnBorrar);
            this.panel1.Controls.Add(this.btnMostrarDetalle);
            this.panel1.Controls.Add(this.cmbArticulo);
            this.panel1.Controls.Add(this.cmbCategoria);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.grillaDetalleStock);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(131, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(976, 533);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtFecha
            // 
            this.txtFecha.BackColor = System.Drawing.SystemColors.Control;
            this.txtFecha.Location = new System.Drawing.Point(156, 23);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.ReadOnly = true;
            this.txtFecha.Size = new System.Drawing.Size(100, 20);
            this.txtFecha.TabIndex = 21;
            // 
            // btnPedido
            // 
            this.btnPedido.Location = new System.Drawing.Point(612, 495);
            this.btnPedido.Name = "btnPedido";
            this.btnPedido.Size = new System.Drawing.Size(118, 23);
            this.btnPedido.TabIndex = 20;
            this.btnPedido.Text = "HACER PEDIDO";
            this.btnPedido.UseVisualStyleBackColor = true;
            this.btnPedido.Visible = false;
            this.btnPedido.Click += new System.EventHandler(this.btnPedido_Click);
            // 
            // btnMostrarArticulos
            // 
            this.btnMostrarArticulos.Location = new System.Drawing.Point(579, 150);
            this.btnMostrarArticulos.Name = "btnMostrarArticulos";
            this.btnMostrarArticulos.Size = new System.Drawing.Size(139, 23);
            this.btnMostrarArticulos.TabIndex = 19;
            this.btnMostrarArticulos.Text = "MOSTRAR ARTICULOS";
            this.btnMostrarArticulos.UseVisualStyleBackColor = true;
            this.btnMostrarArticulos.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(545, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "ARTICULOS CON STOCK MENOR AL BASE";
            // 
            // GrillaStockMenor
            // 
            this.GrillaStockMenor.AllowUserToAddRows = false;
            this.GrillaStockMenor.AllowUserToDeleteRows = false;
            this.GrillaStockMenor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaStockMenor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.GrillaStockMenor.Location = new System.Drawing.Point(548, 198);
            this.GrillaStockMenor.Name = "GrillaStockMenor";
            this.GrillaStockMenor.ReadOnly = true;
            this.GrillaStockMenor.Size = new System.Drawing.Size(406, 278);
            this.GrillaStockMenor.TabIndex = 17;
            this.GrillaStockMenor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrillaStockMenor_CellContentClick);
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.Yellow;
            this.btnBorrar.Location = new System.Drawing.Point(123, 150);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(80, 23);
            this.btnBorrar.TabIndex = 16;
            this.btnBorrar.Text = "Limpiar Grilla";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnMostrarDetalle
            // 
            this.btnMostrarDetalle.Location = new System.Drawing.Point(219, 150);
            this.btnMostrarDetalle.Name = "btnMostrarDetalle";
            this.btnMostrarDetalle.Size = new System.Drawing.Size(158, 23);
            this.btnMostrarDetalle.TabIndex = 14;
            this.btnMostrarDetalle.Text = "MOSTRAR DETALLE";
            this.btnMostrarDetalle.UseVisualStyleBackColor = true;
            this.btnMostrarDetalle.Click += new System.EventHandler(this.btnMostrarDetalle_Click);
            // 
            // cmbArticulo
            // 
            this.cmbArticulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbArticulo.FormattingEnabled = true;
            this.cmbArticulo.Location = new System.Drawing.Point(156, 114);
            this.cmbArticulo.Name = "cmbArticulo";
            this.cmbArticulo.Size = new System.Drawing.Size(221, 21);
            this.cmbArticulo.TabIndex = 13;
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(156, 82);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(221, 21);
            this.cmbCategoria.TabIndex = 11;
            this.cmbCategoria.SelectedIndexChanged += new System.EventHandler(this.cmbCategoria_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Categoria:";
            // 
            // grillaDetalleStock
            // 
            this.grillaDetalleStock.AllowUserToAddRows = false;
            this.grillaDetalleStock.AllowUserToDeleteRows = false;
            this.grillaDetalleStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaDetalleStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Producto,
            this.Producto,
            this.Cantidad});
            this.grillaDetalleStock.Location = new System.Drawing.Point(27, 198);
            this.grillaDetalleStock.Name = "grillaDetalleStock";
            this.grillaDetalleStock.ReadOnly = true;
            this.grillaDetalleStock.Size = new System.Drawing.Size(393, 278);
            this.grillaDetalleStock.TabIndex = 7;
            this.grillaDetalleStock.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grillaDetalleStock_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Articulo:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha:";
            // 
            // ID_Producto
            // 
            this.ID_Producto.HeaderText = "ID_Articulo";
            this.ID_Producto.Name = "ID_Producto";
            this.ID_Producto.ReadOnly = true;
            this.ID_Producto.Visible = false;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Articulo";
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            this.Producto.Width = 200;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ID_Articulo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Articulo";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Cantidad";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // frmListadoStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 589);
            this.Controls.Add(this.panel1);
            this.Name = "frmListadoStock";
            this.Text = "frmListadoStock";
            this.Load += new System.EventHandler(this.frmListadoStock_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaStockMenor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaDetalleStock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbArticulo;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView grillaDetalleStock;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMostrarDetalle;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.DataGridView GrillaStockMenor;
        private System.Windows.Forms.Button btnMostrarArticulos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPedido;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
    }
}