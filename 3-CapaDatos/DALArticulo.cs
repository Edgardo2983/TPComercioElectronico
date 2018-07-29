using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CapaDatos
{
    public class DALArticulo
    {
        private Conexion conexion;
        private String query;
        private DataTable data;
        private DataRow row;

        public DataTable listarCategoria()
        {
            conexion = new Conexion();
            query = "SELECT * FROM CATEGORIAS";
            data = conexion.LeerPorComando(query);
            return data;
        }

        public void actualizar_articulo(int id_articulo,int cantidad)
        {
            conexion=new Conexion();
            query="update ARTICULOS set stock = (select stock from ARTICULOS where id_articulo =" +id_articulo+") + "+ cantidad +" where id_articulo = " + id_articulo+ " ";
            data = conexion.LeerPorComando(query);
        }

        public DataTable articulos_menor_stock()
        {
            conexion= new Conexion();
            query = "SELECT * FROM ARTICULOS  WHERE stock <= 10";
            data = conexion.LeerPorComando(query);
            return data;

        }
        public DataTable listarArticulos()
        {
            conexion = new Conexion();
            query = "SELECT * FROM ARTICULOS, CATEGORIAS WHERE fk_categoria = id_categoria";
            data = conexion.LeerPorComando(query);
            return data;
        }

        public DataTable listarArticulosPorCategoria(String categoria)
        {
            conexion = new Conexion();
            query = "SELECT * FROM ARTICULOS, CATEGORIAS WHERE fk_categoria = id_categoria AND CATEGORIAS.nombre = '" + categoria + "'";
            data = conexion.LeerPorComando(query);
            return data;
        }

        public DataTable obtenerArticuloPorNombre(String nombre)
        {
            conexion = new Conexion();
            query = "SELECT * FROM ARTICULOS, CATEGORIAS WHERE fk_categoria = id_categoria AND ARTICULOS.NOMBRE = '" + nombre + "'";
            data = conexion.LeerPorComando(query);
            return data;
        }
    }
}
