using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CapaDatos
{
    public class DALLoginEmpleado
    {
        private Conexion conexion;
        private String query;
        private DataTable data;

        public Boolean esLoginValido(String usuario, String password)
        {
            conexion = new Conexion();
            query = "SELECT usuario, password FROM EMPLEADOS WHERE usuario = '" + usuario + "' AND password = '" + password + "'";
            data = conexion.LeerPorComando(query);
            return data.Rows.Count == 1;
        }

        public String obtenerTipo(String usuario)
        {
            conexion = new Conexion();
            query = "SELECT cargo FROM TIPOS_EMPLEADO WHERE id_tipo_empleado = (SELECT fk_tipo_empleado FROM EMPLEADOS WHERE usuario = '" + usuario + "')";
            data = conexion.LeerPorComando(query);
            if (data.Rows.Count == 1)
            {
                return data.Rows[0]["cargo"].ToString();
            }
            else
            {
                return "";
            }
        }


    }
}
