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
    public partial class frmABMUsuarios : Form
    {
        public enum esTipo
        {
            nuevoUsuario,
            usuarioExistente
        }

        public frmABMUsuarios(Empleado empleado)
        {
            InitializeComponent();

            if (empleado != null)
            {
                txtNombre.Text = empleado.nombre;
                txtApellido.Text = empleado.apellido;
                txtDni.Text = empleado.dni;
                txtEmail.Text = empleado.eMail;
                txtCodigoInterno.Text = empleado.codigoInterno;
                //cmbTipo.Text = empleado.tipoEmpleado.cargo;
                if (empleado.estaAprobado)
                {
                    btnAprobarUsuario.Enabled = false;
                    btnModificarUsuario.Enabled = true;
                }
                else
                {
                    txtNombre.ReadOnly = true;
                    txtApellido.ReadOnly = true;
                    txtDni.ReadOnly = true;
                    txtEmail.ReadOnly = true;
                    txtCodigoInterno.ReadOnly = true;

                    btnAprobarUsuario.Enabled = true;
                    btnModificarUsuario.Enabled = false;
                }
            }
            else
            {
                btnAprobarUsuario.Enabled = false;
                btnModificarUsuario.Enabled = false;
            }
        }

        private void frmABMUsuarios_Load(object sender, EventArgs e)
        {

        }

        private void btnAprobarUsuario_Click(object sender, EventArgs e)
        {

        }

        private void btnModificarUsuario_Click(object sender, EventArgs e)
        {

        }
    }
}
