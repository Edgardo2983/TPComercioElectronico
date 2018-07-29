using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace CapaDatos
{
   public class DALEncargado
    {
        private Conexion conexion;
        private String query;
        private DataTable data;


        public int en_sesion(String usuario, String password)
        {
            conexion = new Conexion();
            query = "SELECT id_empleado FROM EMPLEADOS WHERE usuario = '" + usuario + "' and password = '" + password + "'";
            //la variable data, como esta declarado arriba, es un DataTable, o sea un objeto que tiene toda la informacion de una tabla
            data = conexion.LeerPorComando(query);
            //el DataRow, es el que tiene informacion de una fila (o registro) de una tabla
            DataRow row;
            //yo se que mi consulta va a devolver una solo registro, asique le paso la fila de indice 0 al objeto row
            row = data.Rows[0];
            //y por ultimo consulto la columna de id (o columna de indice cero, porque solo me trae una sola columna, la de id)
            int id = int.Parse(row[0].ToString());
            //devuelvo el entero obtenido
            return id;
        }

    }
}
