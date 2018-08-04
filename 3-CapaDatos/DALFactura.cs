using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CapaDatos
{
    public class DALFactura
    {
        private Conexion conexion;
        private String query;
        private DataTable data;

        public Boolean registrarFactura(int idCliente, int tipoFactura, DateTime fecha)
        {
            conexion = new Conexion();
            query = "INSERT INTO FACTURAS (fk_tipo_factura, fk_cliente, fecha) VALUES (" + tipoFactura + ", " + idCliente + ", '" + fecha.ToString("d") + "')";
            return conexion.EscribirPorComando(query) == 1;
        }

        public Boolean registrarItemFactura(int idFactura, int idArticulo, int cantidad)
        {
            conexion = new Conexion();
            query = "INSERT INTO ITEMS_FACTURA (fk_factura, fk_articulo, cantidad) VALUES (" + idFactura + ", " + idArticulo + ", " + cantidad + ")";
            return conexion.EscribirPorComando(query) == 1;
        }

        public int obtenerUltimoIdFactura()
        {
            conexion = new Conexion();
            data = new DataTable();
            query = "SELECT IDENT_CURRENT('FACTURAS') IDENTCURRENT";
            data = conexion.LeerPorComando(query);
            return int.Parse(data.Rows[0][0].ToString());
        }
    }
}
