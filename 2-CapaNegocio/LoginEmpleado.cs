using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class LoginEmpleado : Login
    {

        private DALLoginEmpleado dalLoginEmpleado;
        private Encriptacion encriptar;

        private String _codigoInterno;
        public String codigoInterno
        {
            get { return _codigoInterno; }
            set { _codigoInterno = value; }
        }

        public TipoEmpleado tipoEmpleado;

        public LoginEmpleado()
        {
            tipoEmpleado = new TipoEmpleado();
        }

        public Boolean validarLogin()
        {
            dalLoginEmpleado = new DALLoginEmpleado();
            encriptar = new Encriptacion();
            if (dalLoginEmpleado.esLoginValido(nombreUsuario, encriptar.generarClaveSHA1(password)))
            {
                tipoEmpleado.cargo = dalLoginEmpleado.obtenerTipo(nombreUsuario);
                return true;
            }
            return false;
        }

    }
}
