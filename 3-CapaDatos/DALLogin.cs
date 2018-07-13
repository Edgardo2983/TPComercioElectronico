using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CapaDatos
{
    public class DALLogin
    {
        private Conexion conexion;
        private String query;
        private DataTable data;

        public Boolean esLoginValido(String usuario, String password)
        {
            conexion = new Conexion();
            query = "SELECT usuario, password FROM CLIENTES WHERE usuario = '" + usuario + "' AND password = '" + password + "'";
            data = conexion.LeerPorComando(query);
            return data.Rows.Count == 1;
        }

    }
}
