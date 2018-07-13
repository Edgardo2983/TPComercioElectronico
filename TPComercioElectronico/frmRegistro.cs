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
    public partial class frmRegistro : Form
    {
        public frmRegistro()
        {
            InitializeComponent();
        }

        private void frmRegistro_Load(object sender, EventArgs e)
        {
            reubicarControles();
            obtenerTiposUsuario();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmRegistro.ActiveForm.Close();
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            if (!hayCamposVacios())
            {
                if (txtContraseña.Text == txtRepetir.Text)
                {
                    if (cmbTipoUsuario.SelectedIndex == 0)
                    {
                        Cliente cliente = new Cliente();
                        cliente.nombre = txtNombre.Text;
                        cliente.apellido = txtApellido.Text;
                        cliente.direccion = txtDomicilio.Text;
                        cliente.dni = txtDni.Text;
                        cliente.telefono = txtTelefono.Text;
                        cliente.eMail = txtMail.Text;
                        cliente.usuario = txtUsuario.Text;
                        cliente.password = txtContraseña.Text;
                        if (!cliente.clienteYaExiste(cliente.dni))
                        {
                            if (cliente.registrarCliente())
                            {
                                MessageBox.Show("El usuario se ha creado correctamente.", "cuatrivagos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Ocurrió un error al intentar crear el usuario.", "cuatrivagos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("El usuario ya se encuentra registrado.", "cuatrivagos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        Empleado empleado = new Empleado();
                        empleado.nombre = txtNombre.Text;
                        empleado.apellido = txtApellido.Text;
                        empleado.dni = txtDni.Text;
                        empleado.eMail = txtMail.Text;
                        empleado.usuario = txtUsuario.Text;
                        empleado.password = txtContraseña.Text;
                        empleado.estaAprobado = false;
                        empleado.tipoEmpleado.cargo = cmbTipoUsuario.Text;
                        if (!empleado.empleadoYaExiste(empleado.dni))
                        {
                            if (empleado.registrarEmpleado())
                            {
                                MessageBox.Show("El usuario se ha creado correctamente.", "cuatrivagos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Ocurrió un error al intentar crear el usuario.", "cuatrivagos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("El usuario ya se encuentra registrado.", "cuatrivagos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Las contraseñas no coinciden, por favor reintente nuevamente.", "Cuatrivagos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtContraseña.Text = "";
                    txtRepetir.Text = "";
                    txtContraseña.Focus();
                }
            }
            else
            {
                MessageBox.Show("Debe completar todos los campos.", "Cuatrivagos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void obtenerTiposUsuario()
        {
            cmbTipoUsuario.Items.Clear();
            cmbTipoUsuario.Items.Add("Cliente");
            TipoEmpleado tipoEmpleado = new TipoEmpleado();
            foreach (TipoEmpleado tipo in tipoEmpleado.listarTipos())
            {
                cmbTipoUsuario.Items.Add(tipo.cargo);
            }
            cmbTipoUsuario.SelectedIndex = 0;
        }

        private Boolean hayCamposVacios()
        {
            return txtUsuario.Text == "" || txtNombre.Text == "" || txtApellido.Text == "" || txtDomicilio.Text == "" || txtDni.Text == "" || txtTelefono.Text == "" || txtMail.Text == "" || txtContraseña.Text == "" || txtRepetir.Text == "";
        }
    }
}
