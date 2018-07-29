using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class Proveedor
    {
        private int _id;

        public int id
        {
            get { return _id; }
            set { _id = value; }
        }


        private String _direccion;
        public String direccion
        {
            get { return _direccion; }
            set { _direccion = value; }
        }


        private String _telefono;

        public String telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
        }

        private String _nombre;

        public String nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        private String _email;

        public String email
        {
            get { return _email; }
            set { _email = value; }

        }

        public List<Proveedor> listar_proveedores()
        {

            DALProveedor dALProveedor = new DALProveedor();
            DataTable table = new DataTable();
            List<Proveedor> lista_proveedor = new List<Proveedor>();
            table = dALProveedor.listar_proveedores();
            Proveedor proveedor;
            foreach (DataRow row in table.Rows)
            {
                proveedor = new Proveedor();
                proveedor.nombre = row["nombre"].ToString();
                proveedor.id =Convert.ToInt32 (row["id_proveedor"]);
                lista_proveedor.Add(proveedor);
            }
            return lista_proveedor;
        }

        public int buscar_id_proveedor(String nombre)
        {
            Proveedor proveedor = new Proveedor();
            int id = 0;
            foreach (Proveedor prov in proveedor.listar_proveedores())
            {
                if (nombre == prov.nombre)
                {
                    id = prov.id;
                }

            }
            return id;
        }




    }

}

