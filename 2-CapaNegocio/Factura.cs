using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class Factura
    {
        public Boolean registrarFactura(int idCliente, Carrito carrito, int tipoFactura)
        {
            DateTime hoy = DateTime.Today;
            DALFactura dalFactura = new DALFactura();
            int idFacturaActual;
            Boolean sePudoRegistrarFactura = false, sePudoRegistrarItem = false, sePudoQuitarStock = false;

            sePudoRegistrarFactura = dalFactura.registrarFactura(idCliente, tipoFactura, hoy);
            idFacturaActual = dalFactura.obtenerUltimoIdFactura();
            foreach (ItemCarrito item in carrito.listaItems)
            {
                sePudoRegistrarItem = dalFactura.registrarItemFactura(idFacturaActual, item.articulo.idArticulo, item.cantidad);
                sePudoQuitarStock = item.articulo.quitarDelStock(item.cantidad);
                if (!sePudoRegistrarItem || !sePudoQuitarStock)
                {
                    break;
                }
            }
            return sePudoRegistrarFactura && sePudoRegistrarItem && sePudoQuitarStock;
        }

    }
}
