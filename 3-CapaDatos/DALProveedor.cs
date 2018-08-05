using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CapaDatos
{
    public class DALProveedor
    {
        private Conexion conexion;
        private String query;
        private DataTable data;

        public DataTable listar_proveedores()
        {
            conexion = new Conexion();
            query = "SELECT * FROM PROVEEDORES";
            data = conexion.LeerPorComando(query);
            return data;
        }
    }
}
