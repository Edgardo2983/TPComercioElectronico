using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class Carrito
    {
        private List<ItemCarrito> _listaItems;
        public List<ItemCarrito> listaItems
        {
            get { return _listaItems; }
            set { _listaItems = value; }
        }

        public Carrito()
        {
            _listaItems = new List<ItemCarrito>();
        }

        public void agregarItem(ItemCarrito item)
        {
            _listaItems.Add(item);
        }

        public void quitarItem(int idArticulo)
        {
            int indice = 0;
            foreach (ItemCarrito item in _listaItems)
            {
                if (item.articulo.idArticulo == idArticulo)
                {
                    _listaItems.RemoveAt(indice);
                }
                indice++;
            }
        }

        public void quitarItem(ItemCarrito item)
        {
            _listaItems.Remove(item);
        }

        public void vaciarCarrito()
        {
            _listaItems.Clear();
        }

    }
}
