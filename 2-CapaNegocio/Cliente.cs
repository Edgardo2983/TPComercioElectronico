using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class Cliente
    {
        private int _id;
        public int id
        {
            get { return _id; }
            set { _id = value; }
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

        private string _direccion;
        public string direccion
        {
            get { return _direccion; }
            set { _direccion = value; }
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

        private String _telefono;
        public String telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
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

        public Boolean registrarCliente()
        {
            DALCliente dalCliente = new DALCliente();
            Encriptacion encriptar = new Encriptacion();
            password = encriptar.generarClaveSHA1(password);
            return dalCliente.registrarCliente(nombre, apellido, direccion, dni, telefono, eMail, usuario, password, 1);
        }

        public Boolean clienteYaExiste(String dni)
        {
            DALCliente dalCliente = new DALCliente();
            DataTable data = dalCliente.buscarCliente(dni);
            return data.Rows.Count == 1;
        }

        public Boolean nombreUsuarioYaExiste(String nombreUsuario)
        {
            DALCliente dalCliente = new DALCliente();
            DataTable data = dalCliente.buscarNombreUsuario(nombreUsuario);
            return data.Rows.Count == 1;
        }

    }
}
