using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPComercioElectronico
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            reubicarControles();
        }

        private void lblSesion_Click(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmLogin.ActiveForm.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //HARDCODEO PARA PRUEBAS, DESARROLLAR COMO CORRESPONDE, CUATRIVAGOS!
            //se hacen comprobaciones pertinentes de lo ingresado (ej: el usuario ingresado no existe, etc)
            if (cmbTipoUsuario.SelectedIndex > 0)
            {
                if (txtUsuario.Text == "1" && txtContraseña.Text == "1" && txtCodigoInterno.Text == "1")
                {
                    System.Windows.Forms.MessageBox.Show("Login exitoso.", "Login exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Error: se ingresó algún valor incorrecto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (txtUsuario.Text == "1" && txtContraseña.Text == "1")
                {
                    System.Windows.Forms.MessageBox.Show("Login exitoso.", "Login exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Error: se ingresó algún valor incorrecto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            //FIN HARDCODEO
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
    }
}
