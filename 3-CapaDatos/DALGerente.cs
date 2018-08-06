using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CapaDatos
{
    public class DALGerente
    {
        private Conexion conexion;
        private String query;
        private DataTable data;
        private DataRow row;

        public DataTable ver_ventas(String fechainicial, String fechafinal)
        {
            conexion = new Conexion();
            query = "SELECT ARTICULOS.nombre, SUM(ITEMS_FACTURA.cantidad) AS cantidad FROM ARTICULOS, ITEMS_FACTURA, FACTURAS WHERE ITEMS_FACTURA.fk_articulo = ARTICULOS.id_articulo AND ITEMS_FACTURA.fk_factura = FACTURAS.id_factura and FACTURAS.fecha BETWEEN '" + fechainicial + "' AND '" + fechafinal + "' GROUP BY ARTICULOS.nombre";
            data = conexion.LeerPorComando(query);
            return data;
        }
    }
}
