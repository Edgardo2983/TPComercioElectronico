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
    public partial class frmPrincipal : Form
    {

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            reubicarControles();
            cargarListViewPorCategoria("Cocina");
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            Form frmRegistro = new frmRegistro();
            frmRegistro.Show();
        }

        private void btnSesion_Click(object sender, EventArgs e)
        {
            Form login = new frmLogin(this);
            login.Show();
        }

        public void actualizarLogin(Login login)
        {
            lblUsuario.Text = "Bienvenido/a, " + login.nombreUsuario;
            lblUsuario.Visible = true;
            btnCarrito.Visible = true;
        }

        private void lnkCocina_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            cargarListViewPorCategoria("Cocina");
        }

        private void lnkIluminacion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            cargarListViewPorCategoria("Iluminación");
        }

        private void lnkBaño_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            cargarListViewPorCategoria("Baño");
        }

        private void lnkMuebles_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            cargarListViewPorCategoria("Muebles");
        }

        private void lnkDecoracion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            cargarListViewPorCategoria("Decoración");
        }

        private void lnkAccesorios_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            cargarListViewPorCategoria("Accesorios");
        }

        private void lnkJardin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            cargarListViewPorCategoria("Jardín");
        }

        private void lnkEscritorio_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            cargarListViewPorCategoria("Escritorio");
        }

        private void cargarListViewPorCategoria(String categoria)
        {
            Articulo articulo = new Articulo();
            cargarListView(articulo.listarArticulosPorCategoria(categoria));
            txtBusqueda.Text = "";
        }

        private void cargarListView(List<Articulo> listaArticulos)
        {
            listView.SmallImageList = new ImageList();
            listView.LargeImageList = new ImageList();
            listView.LargeImageList.ImageSize = new Size(256, 256);
            listView.View = View.LargeIcon;
            listView.Items.Clear();
            string proyectDirectory = Environment.CurrentDirectory;
            int indice = 0;

            foreach (Articulo articulo in listaArticulos)
            {
                articulo.imagen = corregirSeparador(articulo.imagen);
                listView.Items.Add(new ListViewItem(articulo.nombre, indice));
                listView.SmallImageList.Images.Add(Bitmap.FromFile(proyectDirectory + "\\" + articulo.imagen));
                listView.LargeImageList.Images.Add(Bitmap.FromFile(proyectDirectory + "\\" + articulo.imagen));
                indice++;
            }
        }

        private String corregirSeparador(String texto)
        {
            return texto.Replace("\\\\", "\\");
        }

        private void listView_DoubleClick(object sender, EventArgs e)
        {
            frmDetalle frmDetalle = new frmDetalle(listView.SelectedItems[0].Text);
            frmDetalle.Show();
        }

        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            cargarListViewPorNombre();
        }

        private void txtBusqueda_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cargarListViewPorNombre();
            }
        }

        private void cargarListViewPorNombre()
        {
            Articulo articulo = new Articulo();
            List<Articulo> listaArticulos = new List<Articulo>();
            listaArticulos = articulo.listarArticulosPorNombre(txtBusqueda.Text);
            cargarListView(listaArticulos);
        }
    }
}
