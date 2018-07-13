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
            this.btnRegistroUsuarios = new System.Windows.Forms.Button();
            this.btnRegistroVentas = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.monthCalendar2 = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ProductoVendido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegistroUsuarios
            // 
            this.btnRegistroUsuarios.BackgroundImage = global::CapaPresentacion.Properties.Resources.background_boton2;
            this.btnRegistroUsuarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRegistroUsuarios.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistroUsuarios.Location = new System.Drawing.Point(51, 214);
            this.btnRegistroUsuarios.Name = "btnRegistroUsuarios";
            this.btnRegistroUsuarios.Size = new System.Drawing.Size(195, 36);
            this.btnRegistroUsuarios.TabIndex = 1;
            this.btnRegistroUsuarios.Text = "Registros de Usuarios";
            this.btnRegistroUsuarios.UseVisualStyleBackColor = true;
            // 
            // btnRegistroVentas
            // 
            this.btnRegistroVentas.BackgroundImage = global::CapaPresentacion.Properties.Resources.background_boton2;
            this.btnRegistroVentas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRegistroVentas.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistroVentas.Location = new System.Drawing.Point(51, 148);
            this.btnRegistroVentas.Name = "btnRegistroVentas";
            this.btnRegistroVentas.Size = new System.Drawing.Size(195, 36);
            this.btnRegistroVentas.TabIndex = 2;
            this.btnRegistroVentas.Text = "Registros de Ventas";
            this.btnRegistroVentas.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.monthCalendar2);
            this.panel1.Controls.Add(this.monthCalendar1);
            this.panel1.Location = new System.Drawing.Point(314, 125);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(741, 465);
            this.panel1.TabIndex = 3;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(91, 23);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            // 
            // monthCalendar2
            // 
            this.monthCalendar2.Location = new System.Drawing.Point(415, 23);
            this.monthCalendar2.Name = "monthCalendar2";
            this.monthCalendar2.TabIndex = 1;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(365, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hasta:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductoVendido,
            this.CantidadTotal});
            this.dataGridView1.Location = new System.Drawing.Point(100, 256);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(563, 150);
            this.dataGridView1.TabIndex = 4;
            // 
            // ProductoVendido
            // 
            this.ProductoVendido.HeaderText = "Producto Vendido";
            this.ProductoVendido.Name = "ProductoVendido";
            this.ProductoVendido.ReadOnly = true;
            // 
            // CantidadTotal
            // 
            this.CantidadTotal.HeaderText = "Cantidad Total";
            this.CantidadTotal.Name = "CantidadTotal";
            this.CantidadTotal.ReadOnly = true;
            // 
            // frmGerencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1290, 615);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnRegistroVentas);
            this.Controls.Add(this.btnRegistroUsuarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGerencia";
            this.Text = "Gerencia";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRegistroUsuarios;
        private System.Windows.Forms.Button btnRegistroVentas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductoVendido;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MonthCalendar monthCalendar2;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
    }
}