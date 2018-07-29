using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class Encargado : Empleado
    {
        private Encriptacion encriptar;
        public int saber_id(String usuario, String password)
        {
            encriptar = new Encriptacion();
            DALEncargado encargado = new DALEncargado();

            int id=encargado.en_sesion(usuario, encriptar.generarClaveSHA1(password));
            return id;
        }

    }
}
