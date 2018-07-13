using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class Empleado
    {
        public Empleado()
        {
            _tipoEmpleado = new TipoEmpleado();
        }

        private String _nombre;
        public String nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        private String _apellido;
        public String apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }

        private String _dni;
        public String dni
        {
            get { return _dni; }
            set { _dni = value; }
        }

        private String _eMail;
        public String eMail
        {
            get { return _eMail; }
            set { _eMail = value; }
        }

        private String _codigoInterno;
        public String codigoInterno
        {
            get { return _codigoInterno; }
            set { _codigoInterno = value; }
        }

        private String _usuario;
        public String usuario
        {
            get { return _usuario; }
            set { _usuario = value; }
        }

        private String _password;
        public String password
        {
            get { return _password; }
            set { _password = value; }
        }

        private Boolean _estaAprobado;
        public Boolean estaAprobado
        {
            get { return _estaAprobado; }
            set { _estaAprobado = value; }
        }

        private TipoEmpleado _tipoEmpleado;
        public TipoEmpleado tipoEmpleado
        {
            get { return _tipoEmpleado; }
            set { _tipoEmpleado = value; }
        }

        public List<Empleado> listarEmpleados()
        {

            DALEmpleado dALEmpleado = new DALEmpleado();
            DataTable table = new DataTable();
            List<Empleado> listaEmpleados = new List<Empleado>();
            table = dALEmpleado.listarEmpleados();
            foreach (DataRow row in table.Rows)
            {
                Empleado empleado = new Empleado();
                empleado.nombre = row["nombre"].ToString();
                empleado.apellido = row["apellido"].ToString();
                empleado.dni = row["dni"].ToString();
                empleado.eMail = row["email"].ToString();
                empleado.codigoInterno = row["codigo_interno"].ToString();
                empleado.estaAprobado = (Boolean)row["esta_aprobado"];
                empleado.tipoEmpleado.cargo = row["cargo"].ToString();
                listaEmpleados.Add(empleado);
            }
            return listaEmpleados;
        }

        public Boolean registrarEmpleado()
        {
            DALEmpleado dalEmpleado = new DALEmpleado();
            Encriptacion encriptar = new Encriptacion();
            password = encriptar.generarClaveSHA1(password);
            return dalEmpleado.registrarEmpleado(nombre, apellido, dni, eMail, "0", usuario, password, tipoEmpleado.cargo, 0, 0);
        }

        public Boolean empleadoYaExiste(String dni)
        {
            DALEmpleado dalEmpleado = new DALEmpleado();
            DataTable data = dalEmpleado.buscarEmpleado(dni);
            return data.Rows.Count == 1;
        }

    }
}
