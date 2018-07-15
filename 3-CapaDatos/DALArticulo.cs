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

        public DataTable listarArticulosPorNombre(String nombre)
        {
            conexion = new Conexion();
            query = "SELECT * FROM ARTICULOS, CATEGORIAS WHERE fk_categoria = id_categoria AND ARTICULOS.NOMBRE like '" + nombre + "%'";
            data = conexion.LeerPorComando(query);
            return data;
        }


    }
}
