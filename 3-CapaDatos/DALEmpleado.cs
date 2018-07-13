using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CapaDatos
{
    public class DALEmpleado
    {
        private Conexion conexion;
        private String query;
        private DataTable data;

        public DataTable listarEmpleados()
        {
            conexion = new Conexion();
            query = "SELECT * FROM EMPLEADOS, TIPOS_EMPLEADO WHERE fk_tipo_empleado = id_tipo_empleado";
            data = conexion.LeerPorComando(query);
            return data;
        }

        public Boolean registrarEmpleado(String nombre, String apellido, String dni, String eMail, String codigoInterno, String usuario, String password, String tipoEmpleado, int esActivo, int estaAprobado)
        {
            conexion = new Conexion();
            String fkEmpleado;
            query = "SELECT id_tipo_empleado FROM TIPOS_EMPLEADO WHERE cargo = '" + tipoEmpleado + "'";
            data = conexion.LeerPorComando(query);
            if (data.Rows.Count == 1)
            {
                fkEmpleado = data.Rows[0]["id_tipo_empleado"].ToString();

                query = "INSERT INTO EMPLEADOS (fk_tipo_empleado, nombre, apellido, dni, email, codigo_interno, usuario, password, es_activo, esta_aprobado) VALUES (" +
                    fkEmpleado + ", '" +
                    nombre + "', '" +
                    apellido + "', '" +
                    dni + "', '" +
                    eMail + "', '" +
                    codigoInterno + "', '" +
                    usuario + "', '" +
                    password + "', " + 
                    esActivo + ", " +
                    estaAprobado + ")";

                return conexion.EscribirPorComando(query) == 1;
            }
            else
            {
                return false;
            }
        }

        public DataTable buscarEmpleado(String dni)
        {
            conexion = new Conexion();
            query = "SELECT * FROM EMPLEADOS WHERE DNI = '" + dni + "'";
            data = conexion.LeerPorComando(query);
            return data;
        }
    }
}
