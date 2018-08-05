namespace CapaPresentacion
{
    partial class frmGerencia
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
            this.btnRegistroVentas = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.GrillaVenta = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ProductoVendido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegistroVentas
            // 
            this.btnRegistroVentas.BackgroundImage = global::CapaPresentacion.Properties.Resources.background_boton2;
            this.btnRegistroVentas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRegistroVentas.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistroVentas.Location = new System.Drawing.Point(396, 246);
            this.btnRegistroVentas.Name = "btnRegistroVentas";
            this.btnRegistroVentas.Size = new System.Drawing.Size(222, 36);
            this.btnRegistroVentas.TabIndex = 2;
            this.btnRegistroVentas.Text = "Ver Ventas";
            this.btnRegistroVentas.UseVisualStyleBackColor = true;
            this.btnRegistroVentas.Click += new System.EventHandler(this.btnRegistroVentas_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnRegistroVentas);
            this.panel1.Controls.Add(this.dateTimePicker2);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.GrillaVenta);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(314, 125);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(741, 465);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(100, 129);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(100, 23);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // GrillaVenta
            // 
            this.GrillaVenta.AllowUserToAddRows = false;
            this.GrillaVenta.AllowUserToDeleteRows = false;
            this.GrillaVenta.AllowUserToOrderColumns = true;
            this.GrillaVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductoVendido,
            this.CantidadTotal});
            this.GrillaVenta.Location = new System.Drawing.Point(82, 209);
            this.GrillaVenta.Name = "GrillaVenta";
            this.GrillaVenta.ReadOnly = true;
            this.GrillaVenta.Size = new System.Drawing.Size(282, 204);
            this.GrillaVenta.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hasta:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Desde:";
            // 
            // ProductoVendido
            // 
            this.ProductoVendido.HeaderText = "Articulo";
            this.ProductoVendido.Name = "ProductoVendido";
            this.ProductoVendido.ReadOnly = true;
            // 
            // CantidadTotal
            // 
            this.CantidadTotal.HeaderText = "Cantidad";
            this.CantidadTotal.Name = "CantidadTotal";
            this.CantidadTotal.ReadOnly = true;
            // 
            // frmGerencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1290, 615);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGerencia";
            this.Text = "Gerencia";
            this.Load += new System.EventHandler(this.frmGerencia_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaVenta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRegistroVentas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView GrillaVenta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductoVendido;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadTotal;
    }
}