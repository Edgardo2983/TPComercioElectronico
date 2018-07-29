using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class Ingreso
    {
        private int _idproveedor;

        public int idproveedor
        {
            get {return _idproveedor;}
            set{_idproveedor=value;}
        }

        private int _idarticulo;

        public int idarticulo
        {
            get { return _idarticulo; }
            set { _idarticulo = value; }
        }

        private int _idempleado;

        public int idempleado
        {
            get { return _idempleado; }
            set { _idempleado = value;}
        }

        private DateTime _fecha;

        public DateTime fecha
        {
            get { return _fecha; }
            set { _fecha = value; }
        }

        private int _valorunitario;

        public int valorunitario
        {
            get { return _valorunitario; }
            set { _valorunitario = value; }
        }

        private int _cantidad;

        public int cantidad
        {
            get { return _cantidad; }
            set { _cantidad = value; }
        }

        private String _reporte;

        public String reporte
        {
            get { return _reporte; }
            set { _reporte = value; }
        }


        public void cargar_ingreso(int idp, int idart, int idempl, DateTime fecha, int valorU, int cant, string reporte)
        {
            DALIngreso DAlIngreso = new DALIngreso();
            DAlIngreso.insertar_ingreso(idp, idart, idempl, fecha, valorU, cant, reporte);
        }






    }
}
