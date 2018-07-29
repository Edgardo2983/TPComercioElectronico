using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmPedido : Form
    {
        private List<frmPedido> _Pedidos;
        public List<frmPedido> Pedidos
        {
            set
            {
                _Pedidos = value;

            }
        }
       
        
        private int _idArticulo;
        public int idArticulo
        {
            set
            {
                _idArticulo = value;

            }
        }

        private int _idEncargado;
        public int idEncargado
        {
            set
            {
                _idEncargado = value;

            }
        }

        private string _Nombre;
        public string Nombre
        {
            set
            {
                _Nombre = value;

            }
        }



        public frmPedido()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmPedido_Load(object sender, EventArgs e)
        {
            foreach (frmPedido todos in _Pedidos)
            {
                int idArt = todos._idArticulo;
                int idEncar = _idEncargado;
                string nombre = todos._Nombre;
                GrillaPedido.Rows.Add(idArt.ToString(), idEncar.ToString(), nombre.ToString(),"","borrar");


            }
            
            
        }

        private void GrillaPedido_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int columna = e.ColumnIndex;
            int fila = e.RowIndex;
            if (columna == 4)
            {
                GrillaPedido.Rows.RemoveAt(fila);
            }
        }
    }
}
