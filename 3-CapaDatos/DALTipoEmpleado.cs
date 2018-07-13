using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CapaDatos
{
    public class DALTipoEmpleado
    {
        private Conexion conexion;
        private String query;
        private DataTable data;

        public DataTable listarTiposEmpleado()
        {
            conexion = new Conexion();
            query = "SELECT * FROM TIPOS_EMPLEADO";
            data = conexion.LeerPorComando(query);
            return data;
        }

    }
}
