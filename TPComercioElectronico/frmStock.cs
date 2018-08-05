using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class frmStock : Form
    {
        private int _idEncargado;

        public frmStock()
        {
            InitializeComponent();
        }

        public int idEncargado
        {
            set { 
                _idEncargado = value;
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void frmStock_Load(object sender, EventArgs e)
        {
            obtenerTodasCategorias();
            todos_los_proveedores();
            DateTime thisDay = DateTime.Today;
            txtFecha.Text = thisDay.ToString("d");
            cmbReporte.SelectedIndex = 0;
            

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbArticulo.Items.Clear();
            String categoria = cmbCategoria.SelectedItem.ToString();
            Articulo catArticulo = new Articulo();
            foreach (Articulo art in catArticulo.listarArticulosPorCategoria(categoria))
            {
                cmbArticulo.Items.Add(art.nombre);
            }
            cmbArticulo.SelectedIndex = 0;
        }
        private void obtenerTodasCategorias()
        {
            cmbCategoria.Items.Clear();
            CategoriaArticulo categoria = new CategoriaArticulo();
            foreach (CategoriaArticulo CAT in categoria.listarTipos())
            {
                cmbCategoria.Items.Add(CAT.nombre);
            }
            cmbCategoria.SelectedIndex = 0;
        }

        private void todos_los_proveedores()
        {
            cmbProveedor.Items.Clear();
            Proveedor proveedor = new Proveedor();
            foreach (Proveedor prov in proveedor.listar_proveedores())
            {
                cmbProveedor.Items.Add(prov.nombre);
            }
            cmbProveedor.SelectedIndex = 0;
        }



        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void grillaIngresos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int columna = e.ColumnIndex;
            int fila = e.RowIndex;
            if (columna == 7)
            {
               grillaIngresos.Rows.RemoveAt(fila);
            }
        }

        private bool es_valido()
        {
            bool noError = true;
            try
            {
                int cantidad = Convert.ToInt32(txtCantidad.Text);
            }
            catch
            {
                IconoError.Clear();
                IconoError.SetError(txtCantidad, "ingrese solo numeros");
                noError = false;
            }

            try
            {
                int valor = Convert.ToInt32(txtValorUnitario.Text);
            }
            catch
            {
                IconoError.Clear();
                IconoError.SetError(txtValorUnitario, "ingrese solo numeros");
                noError = false;
            }

            return noError;

        }



        private void btnAgregar_Click(object sender, EventArgs e)
        {
            IconoError.Clear();
            if (txtCantidad.Text != "" && txtValorUnitario.Text != "")
            {
                if (es_valido())
                {


                    if (Convert.ToInt32(txtCantidad.Text) > 0)
                    {

                        grillaIngresos.Rows.Add();
                        int cant_filas = grillaIngresos.Rows.Count - 1;
                        grillaIngresos[1, cant_filas].Value = cmbArticulo.SelectedItem.ToString();
                        grillaIngresos[2, cant_filas].Value = txtCantidad.Text;
                        Articulo Art = new Articulo();
                        int id = Art.obtener_ID_Articulo(cmbArticulo.SelectedItem.ToString());
                        grillaIngresos[0, cant_filas].Value = id;
                        Proveedor prov = new Proveedor();
                        String nombre = cmbProveedor.SelectedItem.ToString();
                        int id_proveedor = prov.buscar_id_proveedor(nombre);

                        grillaIngresos[3, cant_filas].Value = txtValorUnitario.Text;
                        grillaIngresos[4, cant_filas].Value = id_proveedor;
                        grillaIngresos[5, cant_filas].Value = nombre;

                        grillaIngresos[6, cant_filas].Value = cmbReporte.SelectedItem.ToString() + txtDetalleReporte.Text;
                        grillaIngresos[7, cant_filas].Value = "borrar";
                        txtCantidad.Clear();
                        txtValorUnitario.Clear();
                        cmbReporte.SelectedIndex = 0;
                    }
                    else
                    {
                        MessageBox.Show("la cantidad debe ser mayor a cero.", "Cuatrivagos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe completar los campos cantidad y valor unitario para agregar a la grilla.", "Cuatrivagos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (grillaIngresos.RowCount == 0)
            {
                MessageBox.Show("la grilla esta vacia no se puede seguir.", "Cuatrivagos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Articulo articulo = new Articulo();
                Ingreso ingreso = new Ingreso();
                Encargado encargado = new Encargado();



                foreach (DataGridViewRow row in grillaIngresos.Rows)
                {

                    DateTime thisDay = DateTime.Today;
                    DateTime hoy = thisDay;

                    int idArticulo = Convert.ToInt32(row.Cells[0].Value);
                    int stock = Convert.ToInt32(row.Cells[2].Value);
                    int valorunitario = Convert.ToInt32(row.Cells[3].Value);
                    int id_proveedor = Convert.ToInt32(row.Cells[4].Value);
                    string reporte = Convert.ToString(row.Cells[6].Value);

                    ingreso.cargar_ingreso(id_proveedor, idArticulo, _idEncargado, hoy, valorunitario, stock, reporte);
                    articulo.actualizar_datos(idArticulo, stock);


                }
                MessageBox.Show("LOS ARTICULOS SE HAN CARGADO CORRECTAMENTE");
            }
        }

        private void cmbReporte_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbReporte.SelectedItem.ToString() == "STOCK FALTANTE")
            {
                txtDetalleReporte.Visible = true;
                txtDetalleReporte.Text = "  cantidad faltante:";

            }
            else if (cmbReporte.SelectedItem.ToString() == "STOCK DEFECTOUSO")
            {
                txtDetalleReporte.Visible = true;
                txtDetalleReporte.Text = "  cantidad defectuosa:";
            }

            else
            {
                txtDetalleReporte.Visible = false;
                txtDetalleReporte.Clear();
             
            }
        }

        private void cmbProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmListadoStock listado = new frmListadoStock();
            listado.idEncargado = _idEncargado;
            listado.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           grillaIngresos.Rows.Clear();
        }

        private void txtDetalleReporte_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
