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
        frmPrincipal formPrincipal;
        ItemCarrito item;

        public frmDetalle(frmPrincipal pantallaPrincipal, String nombreArticulo)
        {
            InitializeComponent();
            reubicarControles();
            lblAgregado.Visible = false;
            formPrincipal = pantallaPrincipal;
            item = new ItemCarrito();

            Articulo articulo = new Articulo();
            articulo.obtenerArticuloPorNombre(nombreArticulo);
            item.articulo = articulo;

            string proyectDirectory = Environment.CurrentDirectory;
            picArticulo.ImageLocation = proyectDirectory + "\\" + articulo.imagen;
            picArticulo.Load();

            lblNombre.Text = articulo.nombre;
            lblDescripcion.Text = articulo.descripcion;
            lblPrecio.Text = "$" + articulo.precio.ToString() + ",00";
            lblStock.Text = articulo.stock.ToString() + " unidades";
        }

        private void frmDetalle_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Boolean itemYaExiste = false;
            if (!formPrincipal.login.validarLogin())
            {
                MessageBox.Show("Para agregar artículos al carrito, debe estar logeado primero.", "Cuatrivagos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            { 
                if (txtUnidades.Text == "")
                {
                    MessageBox.Show("Ingrese la cantidad primero.", "Cuatrivagos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    if (int.Parse(txtUnidades.Text) > item.articulo.stock)
                    {
                        MessageBox.Show("La cantidad ingresada excede el stock actual. Por favor, ingrese una cantidad menor.", "Cuatrivagos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        //checkear que no se agrega el mismo item de nuevo
                        foreach (ItemCarrito itemCarrito in formPrincipal.carrito.listaItems)
                        {
                            if (itemCarrito.articulo.idArticulo == item.articulo.idArticulo)
                            {
                                itemYaExiste = true;
                            }
                        }
                        if (itemYaExiste)
                        {
                            MessageBox.Show("El artículo ya fue agregado al carrito.", "Cuatrivagos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            item.cantidad = int.Parse(txtUnidades.Text);
                            formPrincipal.agregarItemCarrito(item);
                            lblAgregado.Visible = true;
                        }
                    }
                }
            }
        }

        //este evento es para que solo se puedan agregar numeros
        private void txtUnidades_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void btnAgregar_MouseDown(object sender, MouseEventArgs e)
        {
            btnAgregar.BackgroundImageLayout = ImageLayout.Center;
        }

        private void btnAgregar_MouseUp(object sender, MouseEventArgs e)
        {
            btnAgregar.BackgroundImageLayout = ImageLayout.Stretch;
        }
    }
}
