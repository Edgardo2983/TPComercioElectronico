using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CategoriaArticulo
    {

        private int _idCategoria;
        public int idCategoria
        {
            get { return _idCategoria; }
            set { _idCategoria = value; }
        }

        private String _nombre;
        public String nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

    }
}
