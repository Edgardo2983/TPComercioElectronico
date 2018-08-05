using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class Conexion
    {

        private SqlConnection conexion;
        private string cadenaDeConexion;

        private void Conectar()
        {
            cadenaDeConexion = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=ComercioElectronico;Data Source=CM690";
            //cadenaDeConexion = "Server=localhost;Database=ComercioElectronico;Trusted_Connection=True";

            conexion = new SqlConnection();
            conexion.ConnectionString = cadenaDeConexion;
            conexion.Open();
        }

        private void Desconectar()
        {
            conexion.Close();
            conexion.Dispose();
        }

        public DataTable LeerPorComando(string query)
        {
            var tabla = new DataTable();
            var comando = new SqlCommand();
            this.Conectar();

            try
            {
                comando.CommandType = CommandType.Text;
                comando.Connection = this.conexion;
                comando.CommandText = query;
                var adaptador = new SqlDataAdapter(comando);
                adaptador.Fill(tabla);
            }
            catch
            {
                tabla = null;
            }
            finally
            {
                this.Desconectar();
            }
            return tabla;
        }

        public int EscribirPorComando(string query)
        {
            int filasAfectadas = 0;
            var comando = new SqlCommand();
            this.Conectar();

            try
            {
                comando.CommandText = query;
                comando.CommandType = CommandType.Text;
                comando.Connection = this.conexion;
                filasAfectadas = comando.ExecuteNonQuery();
            }
            catch (Exception)
            {
                filasAfectadas = -1;
            }
            finally
            {
                this.Desconectar();
            }
            return filasAfectadas;
        }

    }
}
