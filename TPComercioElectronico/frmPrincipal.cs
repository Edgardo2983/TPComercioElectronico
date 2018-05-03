using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPComercioElectronico
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
            cargarListView(256, 256);
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {

        }

        private void cargarListView(int anchoImagen, int altoImagen)
        {
            listView.SmallImageList = new ImageList();
            listView.LargeImageList = new ImageList();
            listView.LargeImageList.ImageSize = new Size(anchoImagen, altoImagen);
            listView.View = View.LargeIcon;
            string proyectDirectory = Environment.CurrentDirectory;

            //BORRAR Y REEMPLAZAR POR DATOS DESDE LA BASE DE DATOS
            System.Collections.ArrayList nombreProductos = new System.Collections.ArrayList();
            nombreProductos.Add(new ListViewItem("vaso naranja", 0));
            nombreProductos.Add(new ListViewItem("vaso rojo", 1));
            nombreProductos.Add(new ListViewItem("vaso azul", 2));
            nombreProductos.Add(new ListViewItem("vaso verde", 3));
            nombreProductos.Add(new ListViewItem("vaso violeta", 4));
            nombreProductos.Add(new ListViewItem("vaso termico rojo", 5));
            nombreProductos.Add(new ListViewItem("vaso termico azul", 6));
            nombreProductos.Add(new ListViewItem("vaso termico rosa", 7));
            nombreProductos.Add(new ListViewItem("vaso termico verde", 8));
            nombreProductos.Add(new ListViewItem("copa de vino", 9));
            nombreProductos.Add(new ListViewItem("copa de vino grande", 10));
            nombreProductos.Add(new ListViewItem("copa de vino recta", 11));
            nombreProductos.Add(new ListViewItem("copa martini", 12));
            nombreProductos.Add(new ListViewItem("vaso skull", 13));
            nombreProductos.Add(new ListViewItem("jarra de acrilico", 14));
            nombreProductos.Add(new ListViewItem("lunchera azul", 15));
            nombreProductos.Add(new ListViewItem("lunchera rosa", 16));
            nombreProductos.Add(new ListViewItem("lunchera verde", 17));

            System.Collections.ArrayList dirProductos = new System.Collections.ArrayList();
            dirProductos.Add(proyectDirectory + "\\productos\\Cocina\\vaso naranja.jpg");
            dirProductos.Add(proyectDirectory + "\\productos\\Cocina\\vaso rojo.jpg");
            dirProductos.Add(proyectDirectory + "\\productos\\Cocina\\vaso azul.jpg");
            dirProductos.Add(proyectDirectory + "\\productos\\Cocina\\vaso verde.jpg");
            dirProductos.Add(proyectDirectory + "\\productos\\Cocina\\vaso violeta.jpg");
            dirProductos.Add(proyectDirectory + "\\productos\\Cocina\\vaso termico rojo.jpg");
            dirProductos.Add(proyectDirectory + "\\productos\\Cocina\\vaso termico azul.jpg");
            dirProductos.Add(proyectDirectory + "\\productos\\Cocina\\vaso termico rosa.jpg");
            dirProductos.Add(proyectDirectory + "\\productos\\Cocina\\vaso termico verde.jpg");
            dirProductos.Add(proyectDirectory + "\\productos\\Cocina\\copa vino.jpg");
            dirProductos.Add(proyectDirectory + "\\productos\\Cocina\\copa vino grande.jpg");
            dirProductos.Add(proyectDirectory + "\\productos\\Cocina\\copa vino recta.jpg");
            dirProductos.Add(proyectDirectory + "\\productos\\Cocina\\copa martini.jpg");
            dirProductos.Add(proyectDirectory + "\\productos\\Cocina\\vaso skull.jpg");
            dirProductos.Add(proyectDirectory + "\\productos\\Cocina\\jarra de acrilico.jpg");
            dirProductos.Add(proyectDirectory + "\\productos\\Cocina\\lunchera azul.jpg");
            dirProductos.Add(proyectDirectory + "\\productos\\Cocina\\lunchera rosa.jpg");
            dirProductos.Add(proyectDirectory + "\\productos\\Cocina\\lunchera verde.jpg");
            //FIN BORRAR

            foreach (ListViewItem nombreProducto in nombreProductos)
            {
                listView.Items.Add(nombreProducto);
            }

            foreach (string dirProducto in dirProductos)
            {
                listView.SmallImageList.Images.Add(Bitmap.FromFile(dirProducto));
                listView.LargeImageList.Images.Add(Bitmap.FromFile(dirProducto));
            }

        }

        private void btnSesion_Click(object sender, EventArgs e)
        {
            Form login = new frmLogin();
            login.Show();

        }
    }
}
