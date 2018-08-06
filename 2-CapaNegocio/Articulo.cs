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

        public List<Articulo> listarArtMenorStock()
        {
            DALArticulo dalArticulo = new DALArticulo();
            List<Articulo> lista_de_menores = new List<Articulo>();
            Articulo articulo;
            foreach (DataRow row in dalArticulo.articulos_menor_stock().Rows)
            {
                articulo = new Articulo();
                articulo.idArticulo = int.Parse(row["id_articulo"].ToString());
                articulo.nombre = row["nombre"].ToString();
                articulo.descripcion = row["descripcion"].ToString();
                articulo.stock = int.Parse(row["stock"].ToString());
                lista_de_menores.Add(articulo);
            }
            return lista_de_menores;
        }

        public void obtenerArticuloPorNombre(String nombre)
        {
            DALArticulo dAlArticulo = new DALArticulo();
            DataRow row = dAlArticulo.obtenerArticuloPorNombre(nombre).Rows[0];

            this.idArticulo = int.Parse(row["id_articulo"].ToString());
            this.nombre = row["nombre"].ToString();
            this.descripcion = row["descripcion"].ToString();
            this.imagen = row["imagen"].ToString();
            this.precio = int.Parse(row["precio"].ToString());
            this.stock = int.Parse(row["stock"].ToString());
            this.categoria.idCategoria = int.Parse(row["id_categoria"].ToString());
            this.categoria.nombre = row[8].ToString();
        }

        public Articulo obtener_detalle(String nombre)
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
            Articulo articulo = new Articulo();
            articulo.idArticulo = idArticulo;
            articulo.nombre = nombre;
            articulo.stock = stock;
            return articulo;
        }

        public int obtener_ID_Articulo(String nombre)
        {
            DALArticulo dAlArticulo = new DALArticulo();
            DataRow row = dAlArticulo.obtenerArticuloPorNombre(nombre).Rows[0];

            idArticulo = int.Parse(row["id_articulo"].ToString());
            return idArticulo;
        }

        public void actualizar_datos(int id, int cantidad)
        {
            DALArticulo dAlArticulo = new DALArticulo();
            dAlArticulo.actualizar_articulo(id, cantidad);
        }

        public Boolean quitarDelStock(int cantidad)
        {
            if (idArticulo != 0)
            {
                DALArticulo dalArticulo = new DALArticulo();
                return dalArticulo.quitarDelStock(idArticulo, cantidad);
            }
            return false;
        }

        public List<Articulo> listarArticulosPorFecha(String inicio, String fin)
        {
            DALGerente dalGerente = new DALGerente();
            List<Articulo> listaArticulos = new List<Articulo>();
            Articulo articulo;
            foreach (DataRow row in dalGerente.ver_ventas(inicio, fin).Rows)
            {
                articulo = new Articulo();
                articulo.nombre = row["nombre"].ToString();
                articulo.stock = int.Parse(row["cantidad"].ToString());
                listaArticulos.Add(articulo);
            }
            return listaArticulos;
        }
    }
}
