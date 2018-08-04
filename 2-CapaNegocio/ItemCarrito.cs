using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class ItemCarrito
    {

        public ItemCarrito()
        {
            _articulo = new Articulo();
            _cantidad = 0;
        }

        private Articulo _articulo;
        public Articulo articulo
        {
            get { return _articulo; }
            set { _articulo = value; }
        }

        private int _cantidad;
        public int cantidad
        {
            get { return _cantidad; }
            set { _cantidad = value; }
        }

        public int calcularSubtotal()
        {
            if (_articulo == null)
            {
                return 0;
            }
            else
            {
                return _articulo.precio * _cantidad;
            }
        }

    }
}
