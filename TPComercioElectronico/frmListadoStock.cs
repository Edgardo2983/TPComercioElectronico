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
    public partial class frmListadoStock : Form
    {
        private int _idEncargado;
        public int idEncargado
        {
            set
            {
                _idEncargado = value;

            }
        }


        public frmListadoStock()
        {
            InitializeComponent();
        }

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
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

        

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void grillaDetalleStock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btnMostrarDetalle_Click(object sender, EventArgs e)
        {
            string nombre = cmbArticulo.SelectedItem.ToString();
            Articulo articulo = new Articulo();
            Articulo detalle = new Articulo();
            detalle=articulo.obtener_detalle(nombre);

            int algo=detalle.stock;
            string Nombre = detalle.nombre;
            int idart = detalle.idArticulo;
            

            grillaDetalleStock.Rows.Add(idart.ToString(),Nombre.ToString(),algo.ToString());
           
            
            
        }

        private void frmListadoStock_Load(object sender, EventArgs e)
        {
            obtenerTodasCategorias();
            DateTime thisDay = DateTime.Today;
            txtFecha.Text = thisDay.ToString("d");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            grillaDetalleStock.Rows.Clear();


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            GrillaStockMenor.Rows.Clear();
            Articulo articulos = new Articulo();
            List < Articulo > menor= articulos.listarArtMenorStock();
            int id, stock;
            string nombre;
            foreach (Articulo art in menor)
            {
                id = art.idArticulo;
                nombre = art.nombre;
                stock = art.stock;
                GrillaStockMenor.Rows.Add(id.ToString(),nombre.ToString(),stock.ToString());
            }

            
        }

        private void btnPedido_Click(object sender, EventArgs e)
        {
            Articulo articulo = new Articulo();
            Encargado encargado = new Encargado();
            List <frmPedido> pedidos=new List <frmPedido>();
            frmPedido formularioPedido=new frmPedido();
            




            foreach (DataGridViewRow row in GrillaStockMenor.Rows)
            {

                formularioPedido = new frmPedido();
                int idArticulo = Convert.ToInt32(row.Cells[0].Value);
                string nombre = row.Cells[1].Value.ToString();
                formularioPedido.idArticulo=idArticulo;
                formularioPedido.idEncargado = _idEncargado;
                formularioPedido.Nombre = nombre;
                pedidos.Add(formularioPedido);
                
            }
            formularioPedido.Pedidos = pedidos;

            formularioPedido.ShowDialog();
            
            

        }

        private void GrillaStockMenor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
