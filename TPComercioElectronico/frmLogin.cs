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
    public partial class frmLogin : Form
    {
        frmPrincipal pantallaPrincipal;

        public frmLogin(frmPrincipal frmMain)
        {
            InitializeComponent();
            pantallaPrincipal = frmMain;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            reubicarControles();
            obtenerTiposUsuario();
        }

        private void lblSesion_Click(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (noHayCamposNulos())
            {
                if (cmbTipoUsuario.SelectedIndex == 0)
                {
                    Login login = new Login();
                    login.nombreUsuario = txtUsuario.Text;
                    login.password = txtContrasenia.Text;
                    if (login.validarLogin())
                    {
                        pantallaPrincipal.actualizarLogin(login);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Los datos ingresados son incorrectos. Por favor, verifique y vuelva a intentar.", "Cuatrivagos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    LoginEmpleado loginEmpleado = new LoginEmpleado();
                    loginEmpleado.nombreUsuario = txtUsuario.Text;
                    loginEmpleado.password = txtContrasenia.Text;
                    loginEmpleado.codigoInterno = txtCodigoInterno.Text;
                    if (loginEmpleado.validarLogin())
                    {
                        switch (cmbTipoUsuario.SelectedIndex)
                        {
                            case 1:
                                loginEmpleado.tipoEmpleado.esAdministrador = true;
                                break;
                            case 2:
                                loginEmpleado.tipoEmpleado.esEncargado = true;
                                break;
                            case 3:
                                loginEmpleado.tipoEmpleado.esGerente = true;
                                break;
                        }

                        if (loginEmpleado.tipoEmpleado.esAdministrador)
                        {
                            frmAdministracion frmAdministracion = new frmAdministracion();
                            frmAdministracion.Show();
                        }

                        if (loginEmpleado.tipoEmpleado.esEncargado)
                        {
                            frmStock frmStock = new frmStock();
                            frmStock.Show();
                        }
                        if (loginEmpleado.tipoEmpleado.esGerente)
                        {
                            frmGerencia frmGerencia = new frmGerencia();
                            frmGerencia.Show();
                        }

                    }
                    else
                    {
                        MessageBox.Show("Los datos ingresados son incorrectos. Por favor, verifique y vuelva a intentar.", "Cuatrivagos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe completar todos los campos para ingresar al sistema.", "Cuatrivagos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private Boolean noHayCamposNulos()
        {
            if (cmbTipoUsuario.SelectedIndex > 0)
            {
                return txtUsuario.Text != "" && txtContrasenia.Text != "" && txtCodigoInterno.Text != "";
            }
            else
            {
                return txtUsuario.Text != "" && txtContrasenia.Text != "";
            }
        }

        private void cmbTipoUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipoUsuario.SelectedIndex > 0)
            {
                lblCodigoInterno.Visible = true;
                txtCodigoInterno.Visible = true;
            }
            else
            {
                lblCodigoInterno.Visible = false;
                txtCodigoInterno.Visible = false;
            }
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            Form frmRegistro = new frmRegistro();
            frmRegistro.Show();
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

    }
}
