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
    public partial class frmDetalle : Form
    {

        public frmDetalle(String nombreArticulo)
        {
            InitializeComponent();
            reubicarControles();

            Articulo articulo = new Articulo();
            articulo.obtenerArticuloPorNombre(nombreArticulo);

            string proyectDirectory = Environment.CurrentDirectory;
            picArticulo.ImageLocation = proyectDirectory + "\\" + articulo.imagen;
            picArticulo.Load();

            lblNombre.Text = nombreArticulo;
            lblDescripcion.Text = articulo.descripcion;
            lblPrecio.Text = "$" + articulo.precio.ToString() + ",00";
            lblStock.Text = articulo.stock.ToString() + " unidades";

        }

        private void frmDetalle_Load(object sender, EventArgs e)
        {

        }
    }
}
