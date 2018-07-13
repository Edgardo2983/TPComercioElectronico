using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class frmAdministracion : Form
    {
        public frmAdministracion()
        {
            InitializeComponent();
        }

        private void frmAdministracion_Load(object sender, EventArgs e)
        {
            cargarGrilla();
        }

        private void btnAprobarUsuario_Click(object sender, EventArgs e)
        {
            abrirDetalle();
        }

        private void btnModificarUsuario_Click(object sender, EventArgs e)
        {
            abrirDetalle();
        }

        private void gridUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            abrirDetalle();
        }

        private void abrirDetalle()
        {
            if (gridUsuarios.CurrentCell.RowIndex >= 0)
            {
                Empleado empleado = new Empleado();
                int indice = gridUsuarios.CurrentRow.Index;
                empleado.nombre = (String)gridUsuarios[0, indice].Value;
                empleado.apellido = (String)gridUsuarios[1, indice].Value;
                empleado.dni = (String)gridUsuarios[2, indice].Value;
                empleado.eMail = (String)gridUsuarios[3, indice].Value;
                empleado.codigoInterno = (String)gridUsuarios[4, indice].Value;
                empleado.tipoEmpleado.cargo = (String)gridUsuarios[5, indice].Value;
                empleado.estaAprobado = (Boolean)gridUsuarios[7, indice].Value;
                frmABMUsuarios frmABMusuarios = new frmABMUsuarios(empleado);
                frmABMusuarios.Show();
            }
            else
            {
                MessageBox.Show("Se debe seleccionar un elemento de la grilla primero.", "Cuatrivagos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cargarGrilla()
        {
            Empleado empleado = new Empleado();
            foreach (Empleado emp in empleado.listarEmpleados())
            {
                String aprobado;
                if (emp.estaAprobado)
                {
                    aprobado = "Sí";
                }
                else
                {
                    aprobado = "No";
                }
                gridUsuarios.Rows.Add(emp.nombre, emp.apellido, emp.dni, emp.eMail, emp.codigoInterno, emp.tipoEmpleado.cargo, aprobado, emp.estaAprobado);
            }
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            if (gridUsuarios.CurrentRow.Index >= 0)
            {

            }
        }

        private void gridUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
