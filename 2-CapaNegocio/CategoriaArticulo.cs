using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;

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

        public List<CategoriaArticulo> listarTipos()
        {

            DALArticulo dALcategoriaArt = new DALArticulo();
            DataTable table = new DataTable();
            List<CategoriaArticulo> lista_categoria = new List<CategoriaArticulo>();
            table = dALcategoriaArt.listarCategoria();
            CategoriaArticulo categorias;
            foreach (DataRow row in table.Rows)
            {
                categorias = new CategoriaArticulo();
                categorias.nombre = row["nombre"].ToString();
                lista_categoria.Add(categorias);
            }
            return lista_categoria;
        }
    }
}
