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
            query = "SELECT ARTICULOS.nombre,ITEMS_FACTURA.cantidad FROM ITEMS_FACTURA,ARTICULOS,FACTURAS WHERE FACTURAS.fecha BETWEEN'" + fechainicial + "' and '" + fechafinal + "' and FACTURAS.id_factura = ITEMS_FACTURA.fk_factura and ITEMS_FACTURA.fk_articulo = ARTICULOS.id_articulo";
            data = conexion.LeerPorComando(query);
            return data;
        }
    }
}
