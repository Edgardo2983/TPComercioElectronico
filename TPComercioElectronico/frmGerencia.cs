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
    public partial class frmGerencia : Form
    {
        public frmGerencia()
        {
            InitializeComponent();
        }

        private void frmGerencia_Load(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnRegistroVentas_Click(object sender, EventArgs e)
        {
            GrillaVenta.Rows.Clear();
            string inicio = dateTimePicker1.Text;
            string fin = dateTimePicker2.Text;
            Articulo artfecha = new Articulo();
            List<Articulo> xfecha = artfecha.listarArticulosPorFecha(inicio, fin);
            string nombre;
            int cantidad;
            foreach (Articulo artxfecha in xfecha)
            {
                nombre = artxfecha.nombre;
                cantidad = artxfecha.stock;
                GrillaVenta.Rows.Add(nombre.ToString(), cantidad.ToString());
            }



        }
    }
}
