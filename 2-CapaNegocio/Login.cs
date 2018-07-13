using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class Login
    {
        private DALLogin dalLogin;
        private Encriptacion encriptar;

        private String _nombreUsuario;
        public String nombreUsuario
        {
            get { return _nombreUsuario; }
            set { _nombreUsuario = value; }
        }

        private String _password;
        public String password
        {
            get { return _password; }
            set { _password = value; }
        }

        public Boolean validarLogin()
        {
            dalLogin = new DALLogin();
            encriptar = new Encriptacion();
            return dalLogin.esLoginValido(nombreUsuario, encriptar.generarClaveSHA1(password));
        }
    }
}
