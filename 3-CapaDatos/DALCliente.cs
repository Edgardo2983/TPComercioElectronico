using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CapaDatos
{
    public class DALCliente
    {
        private Conexion conexion;
        private String query;
        private DataTable data;

        public DataTable listarClientes()
        {
            conexion = new Conexion();
            query = "SELECT * FROM CLIENTES";
            data = conexion.LeerPorComando(query);
            return data;
        }

        public Boolean registrarCliente(String nombre, String apellido, String direccion, String dni, String telefono, String eMail, String usuario, String password, int esActivo)
        {
            conexion = new Conexion();
            query = "INSERT INTO CLIENTES (nombre, apellido, direccion, dni, telefono, email, usuario, password, es_activo) VALUES ('" +
                nombre + "', '" +
                apellido + "', '" +
                direccion + "', '" +
                dni + "', '" +
                telefono + "', '" +
                eMail + "', '" +
                usuario + "', '" +
                password + "', " +
                esActivo + ")";

            return conexion.EscribirPorComando(query) == 1;
        }

        public DataTable buscarCliente(String dni)
        {
            conexion = new Conexion();
            query = "SELECT * FROM CLIENTES WHERE DNI = '" + dni + "'";
            data = conexion.LeerPorComando(query);
            return data;
        }

        public DataTable buscarClientePorNombreUsuario(String nombreUsuario)
        {
            conexion = new Conexion();
            query = "SELECT * FROM CLIENTES WHERE usuario = '" + nombreUsuario + "'";
            data = conexion.LeerPorComando(query);
            return data;
        }
    }
}
