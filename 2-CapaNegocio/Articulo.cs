using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class Articulo
    {

        public Articulo()
        {
            _categoria = new CategoriaArticulo();
        }

        private CategoriaArticulo _categoria;
        public CategoriaArticulo categoria
        {
            get { return _categoria; }
            set { _categoria = value; }
        }

        private int _idArticulo;
        public int idArticulo
        {
            get { return _idArticulo; }
            set { _idArticulo = value; }
        }

        private String _nombre;
        public String nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        private String _descripcion;
        public String descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        private String _imagen;
        public String imagen
        {
            get { return _imagen; }
            set { _imagen = value; }
        }

        private int _precio;
        public int precio
        {
            get { return _precio; }
            set { _precio = value; }
        }

        private int _stock;
        public int stock
        {
            get { return _stock; }
            set { _stock = value; }
        }

        public List<Articulo> listarArticulos(String categoria)
        {
            DALArticulo dalArticulo = new DALArticulo();
            List<Articulo> listaArticulos = new List<Articulo>();
            Articulo articulo;
            foreach (DataRow row in dalArticulo.listarArticulos().Rows)
            {
                articulo = new Articulo();
                articulo.idArticulo = int.Parse(row["id_articulo"].ToString());
                articulo.nombre = row["ARTICULOS.nombre"].ToString();
                articulo.descripcion = row["descripcion"].ToString();
                articulo.imagen = row["imagen"].ToString();
                articulo.precio = int.Parse(row["precio"].ToString());
                articulo.stock = int.Parse(row["stock"].ToString());
                articulo.categoria.idCategoria = int.Parse(row["id_categoria"].ToString());
                articulo.categoria.nombre = row["CATEGORIAS.nombre"].ToString();
                listaArticulos.Add(articulo);
            }
            return listaArticulos;
        }

        public List<Articulo> listarArticulosPorCategoria(String categoria)
        {
            DALArticulo dalArticulo = new DALArticulo();
            List<Articulo> listaArticulos = new List<Articulo>();
            Articulo articulo;
            foreach (DataRow row in dalArticulo.listarArticulosPorCategoria(categoria).Rows)
            {
                articulo = new Articulo();
                articulo.idArticulo = int.Parse(row["id_articulo"].ToString());
                articulo.nombre = row["nombre"].ToString();
                articulo.descripcion = row["descripcion"].ToString();
                articulo.imagen = row["imagen"].ToString();
                articulo.precio = int.Parse(row["precio"].ToString());
                articulo.stock = int.Parse(row["stock"].ToString());
                articulo.categoria.idCategoria = int.Parse(row["id_categoria"].ToString());
                articulo.categoria.nombre = row[7].ToString();
                listaArticulos.Add(articulo);
            }
            return listaArticulos;
        }

        public List<Articulo> listarArticulosPorNombre(String nombre)
        {
            DALArticulo dalArticulo = new DALArticulo();
            List<Articulo> listaArticulos = new List<Articulo>();
            Articulo articulo;
            foreach (DataRow row in dalArticulo.listarArticulosPorNombre(nombre).Rows)
            {
                articulo = new Articulo();
                articulo.idArticulo = int.Parse(row["id_articulo"].ToString());
                articulo.nombre = row["nombre"].ToString();
                articulo.descripcion = row["descripcion"].ToString();
                articulo.imagen = row["imagen"].ToString();
                articulo.precio = int.Parse(row["precio"].ToString());
                articulo.stock = int.Parse(row["stock"].ToString());
                articulo.categoria.idCategoria = int.Parse(row["id_categoria"].ToString());
                articulo.categoria.nombre = row[7].ToString();
                listaArticulos.Add(articulo);
            }
            return listaArticulos;
        }

        public void obtenerArticuloPorNombre(String nombre)
        {

            DALArticulo dAlArticulo = new DALArticulo();
            DataRow row = dAlArticulo.obtenerArticuloPorNombre(nombre).Rows[0];

            idArticulo = int.Parse(row["id_articulo"].ToString());
            nombre = row["nombre"].ToString();
            descripcion = row["descripcion"].ToString();
            imagen = row["imagen"].ToString();
            precio = int.Parse(row["precio"].ToString());
            stock = int.Parse(row["stock"].ToString());
            categoria.idCategoria = int.Parse(row["id_categoria"].ToString());
            categoria.nombre = row[7].ToString();
        }

    }
}
