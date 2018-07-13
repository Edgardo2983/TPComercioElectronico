using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class TipoEmpleado
    {
        private int _idTipoEmpleado;
        public int idTipoEmpleado
        {
            get { return _idTipoEmpleado; }
            set { _idTipoEmpleado = value; }
        }

        private String _cargo;
        public String cargo
        {
            get { return _cargo; }
            set { _cargo = value; }
        }


        private Boolean _esAdministrador;
        public Boolean esAdministrador
        {
            get { return _esAdministrador; }
            set
            {
                _esAdministrador = value;
                if (value)
                {
                    _esEncargado = false;
                    _esGerente = false;
                }
            }
        }

        private Boolean _esEncargado;
        public Boolean esEncargado
        {
            get { return _esEncargado; }
            set
            {
                _esEncargado = value;
                if (value)
                {
                    _esAdministrador = false;
                    _esGerente = false;
                }
            }
        }

        private Boolean _esGerente;
        public Boolean esGerente
        {
            get { return _esGerente; }
            set
            {
                _esGerente = value;
                if (value)
                {
                    _esAdministrador = false;
                    _esEncargado = false;
                }
            }
        }

        public List<TipoEmpleado> listarTipos()
        {

            DALTipoEmpleado dALTipoEmpleado = new DALTipoEmpleado();
            DataTable table = new DataTable();
            List<TipoEmpleado> listTiposEmpleado = new List<TipoEmpleado>();
            table = dALTipoEmpleado.listarTiposEmpleado();
            TipoEmpleado tipoEmpleado;
            foreach (DataRow row in table.Rows)
            {
                tipoEmpleado = new TipoEmpleado();
                tipoEmpleado.idTipoEmpleado = int.Parse(row["id_tipo_empleado"].ToString());
                tipoEmpleado.cargo = row["cargo"].ToString();
                listTiposEmpleado.Add(tipoEmpleado);
            }
            return listTiposEmpleado;
        }

    }
}
