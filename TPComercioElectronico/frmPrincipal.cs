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
        Login login;

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            reubicarControles();
            cargarListView();
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            Form frmRegistro = new frmRegistro();
            frmRegistro.Show();
        }

        private void cargarListView()
        {
            Articulo articulo = new Articulo();
            List<Articulo> listaArticulos = new List<Articulo>();
            cargarListViewPorCaterogia(articulo.listarArticulosPorCategoria("Cocina"));
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
            Articulo articulo = new Articulo();
            List<Articulo> listaArticulos = new List<Articulo>();
            cargarListViewPorCaterogia(articulo.listarArticulosPorCategoria("Cocina"));
        }

        private void lnkIluminacion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Articulo articulo = new Articulo();
            List<Articulo> listaArticulos = new List<Articulo>();
            cargarListViewPorCaterogia(articulo.listarArticulosPorCategoria("Iluminación"));
        }

        private void lnkBaño_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Articulo articulo = new Articulo();
            List<Articulo> listaArticulos = new List<Articulo>();
            cargarListViewPorCaterogia(articulo.listarArticulosPorCategoria("Baño"));
        }

        private void lnkMuebles_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Articulo articulo = new Articulo();
            List<Articulo> listaArticulos = new List<Articulo>();
            cargarListViewPorCaterogia(articulo.listarArticulosPorCategoria("Muebles"));
        }

        private void lnkDecoracion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Articulo articulo = new Articulo();
            List<Articulo> listaArticulos = new List<Articulo>();
            cargarListViewPorCaterogia(articulo.listarArticulosPorCategoria("Decoración"));
        }

        private void lnkAccesorios_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Articulo articulo = new Articulo();
            List<Articulo> listaArticulos = new List<Articulo>();
            cargarListViewPorCaterogia(articulo.listarArticulosPorCategoria("Accesorios"));
        }

        private void lnkJardin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Articulo articulo = new Articulo();
            List<Articulo> listaArticulos = new List<Articulo>();
            cargarListViewPorCaterogia(articulo.listarArticulosPorCategoria("Jardín"));
        }

        private void lnkEscritorio_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Articulo articulo = new Articulo();
            List<Articulo> listaArticulos = new List<Articulo>();
            cargarListViewPorCaterogia(articulo.listarArticulosPorCategoria("Escritorio"));
        }

        private void cargarListViewPorCaterogia(List<Articulo> listaArticulos)
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

    }
}
