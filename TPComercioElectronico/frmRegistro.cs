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
    public partial class frmRegistro : Form
    {
        public frmRegistro()
        {
            InitializeComponent();
        }

        private void frmRegistro_Load(object sender, EventArgs e)
        {
            reubicarControles();
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
            //HARDCODEO PARA PRUEBAS, DESARROLLAR COMO CORRESPONDE, CUATRIVAGOS!
            //se hacen comprobaciones pertinentes de lo ingresado (ej: el usuario ingresado no existe, etc)
            if (txtNombre.Text != "" || txtApellido.Text != "" || txtDomicilio.Text != "" || txtTelefono.Text != "" || txtMail.Text != "" || txtContraseña.Text != "" || txtRepetir.Text != "")
            {
                if (txtNombre.Text == "1" && txtApellido.Text == "1" && txtDomicilio.Text == "1" && txtTelefono.Text == "1" && txtMail.Text == "1" && txtContraseña.Text == "1" && txtRepetir.Text == "1")
                {
                    System.Windows.Forms.MessageBox.Show("Se ha registrado el nuevo usuario exitosamente.", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Error: el usuario ya existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Error: Existen campos que faltan completar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //FIN HARDCODEO


        }
    }
}
