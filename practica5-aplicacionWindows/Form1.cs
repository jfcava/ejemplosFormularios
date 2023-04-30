using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica5_aplicacionWindows
{
    public partial class datosPersonales : Form
    {
        public datosPersonales()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            estaVacio(txtApellido);
            estaVacio(txtNombre);
            estaVacio(txtEdad);
            estaVacio(txtDireccion);

            txtResultado.Text = ("APELLIDO Y NOMBRE: " + txtApellido.Text + " " + txtNombre.Text + "\r\nEDAD: " + txtEdad.Text + "\r\nDIRECCION: " + txtDireccion.Text);

        }

        private void estaVacio(TextBox txt)
        {
            if (txt.Text == "")
                txt.BackColor = Color.Red;
            else
                txt.BackColor = SystemColors.Control;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
                e.Handled = true;
        }
    }
}
