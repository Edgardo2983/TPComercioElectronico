using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace CapaDatos
{
    public class DALIngreso
    {
        private Conexion conexion;
        private String query;
        private DataTable data;
        


        public void insertar_ingreso(int idprov, int idart, int idempl, DateTime fecha, int valor,int cant,string reporte)
        {
            conexion = new Conexion();
            query = "INSERT INTO INGRESOS (fk_proveedor, fk_articulo,fk_empleado,fecha,valor_unitario, cantidad, reporte) " +
                "VALUES ( '"+idprov +"', '"+idart  + "','" +idempl + "','" +fecha+ "','" +valor  + "','" +cant+ "','" +reporte+"')";
            
            
            conexion.EscribirPorComando(query);


        }

    }
}
