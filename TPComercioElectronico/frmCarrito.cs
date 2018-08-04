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
    public partial class frmCarrito : Form
    {
        frmPrincipal formPrincipal;

        public frmCarrito(frmPrincipal pantallaPrincipal)
        {
            InitializeComponent();
            formPrincipal = pantallaPrincipal;
        }

        private void frmCarrito_Load(object sender, EventArgs e)
        {
            reubicarControles();
            cargarGrilla(formPrincipal.carrito);
        }

        private void cargarGrilla(Carrito carrito)
        {
            grilla.Rows.Clear();
            int indice = 1;
            int total = 0;
            foreach (ItemCarrito item in carrito.listaItems)
            {
                total = total + item.calcularSubtotal();
                grilla.Rows.Add(indice, item.articulo.nombre, item.articulo.precio, item.cantidad, item.calcularSubtotal(), "x");
                indice++;
            }
            lblTotal.Text = "El total hasta el momento es: $" + total + ",00";
        }

        private void grilla_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex + 1 == grilla.ColumnCount)
            {
                if (MessageBox.Show("Está a punto de quitar un artículo del carrito, ¿está seguro?", "Cuatrivagos", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    grilla.Rows.RemoveAt(e.RowIndex);
                    formPrincipal.carrito.quitarItem(formPrincipal.carrito.listaItems.ElementAt(e.RowIndex));
                    int total = 0;
                    foreach (ItemCarrito item in formPrincipal.carrito.listaItems)
                    {
                        total = total + (item.calcularSubtotal());
                    }
                    lblTotal.Text = "El total hasta el momento es: $" + total + ",00";
                }
            }
        }

        private void btnComprar_MouseDown(object sender, MouseEventArgs e)
        {
            btnComprar.BackgroundImageLayout = ImageLayout.Center;
        }

        private void btnComprar_MouseUp(object sender, MouseEventArgs e)
        {
            btnComprar.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Realizar la compra generará la facturación de los artículos incluidos en el carrito. Debe imprimir la factura o solicitarsela a un vendedor, y luego abonarla por caja para poder retirar sus productos.\n\n¿Desea realizar la compra?", "Cuatrivagos", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Factura factura = new Factura();
                Cliente cliente = new Cliente();
                Boolean sePudoFacturar = false;
                int tipoFacturaC = 3; //de momento solo vendemos a consumidor final
                cliente = cliente.obtenerCliente(formPrincipal.login.nombreUsuario);
                sePudoFacturar = factura.registrarFactura(cliente.idCliente, formPrincipal.carrito, tipoFacturaC);
                if (sePudoFacturar)
                {
                    MessageBox.Show("Factura registrada. ¡Muchas gracias por su compra!", "Cuatrivagos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    formPrincipal.carrito.vaciarCarrito();
                    cargarGrilla(formPrincipal.carrito);
                }
                else
                {
                    MessageBox.Show("Ocurrió un problema al intentar registrar la factura. Vuelva a intentar más tarde, y si el error persiste, póngase en contacto con atención al cliente. Disculpe las molestias ocasionadas.", "Cuatrivagos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
