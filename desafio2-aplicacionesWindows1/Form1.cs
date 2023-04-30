using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace desafio2_aplicacionesWindows1
{
    public partial class practica1 : Form
    {
        public practica1()
        {
            InitializeComponent();
        }

        //LANZAR CARTEL AL INICIAR EL FORMULARIO
        private void practica1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenidos a la app!");
        }
        
        //LANZAR CARTEL AL CERRAR EL FORMULARIO
        private void practica1_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Gracias por usar la app!");
        }

        //AL DISPARARSE EL EVENTO CLICK, SE CAMBIE EL COLOR DEL FORMULARIO        
        private void btnRun_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Se disparo el evento Click", "Atención");

            //Cambio el color del formulario al hacer click
            //this.BackColor = Color.DarkOrange;

            //En el evento Click del botón creado anteriormente, cancelamos las líneas de código
            //anteriores y colocamos el código para cambiar el color de fondo del TextBox
            //(Propiedad BackColor) si el TextBox se encuentra vació.

            if (txtName.TextLength == 0)
                txtName.BackColor = Color.Red;
            else
                txtName.BackColor = System.Drawing.SystemColors.Control;

            //if (txtName.Text == "")
            //    txtName.BackColor = Color.Red;
            //else
            //    txtName.BackColor = System.Drawing.SystemColors.Control;
        }

        //LANZAR CARTEL SEGUN QUE CLICK SE PRESIONE
        private void practica1_Click(object sender, EventArgs e)
        {
            MouseEventArgs click = (MouseEventArgs)e;
            if (click.Button == MouseButtons.Left)
            {
                MessageBox.Show("Pulsaste el click izquierdo");
            } else
                MessageBox.Show("Pulsaste el click derecho");
            {

            }
        }
        
        //CAMBIAR COLOR DE LA LABEL AL PASAR CON EL MOUSE Y LA FLECHA DEL MOUSE
        private void lblTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            lblTitulo.BackColor = Color.DarkOrange;
            lblTitulo.Cursor = Cursors.Hand;
        }
       
        private void lblTitulo_MouseLeave(object sender, EventArgs e)
        {
            lblTitulo.BackColor = System.Drawing.SystemColors.Control;
            lblTitulo.Cursor = Cursors.Arrow;
        }                

        //ACEPTAR SOLO NUMEROS EN UN TEXTBOX
        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
                e.Handled = true;
        }

        //MOSTRAR CANTIDAD DE CARACTERES AL SALIR DE UN TEXTBOX
        private void textBox1_Leave(object sender, EventArgs e)
        {
            MessageBox.Show("Caracteres ingresados: " + txtCaracteres.Text.Length);
        }
    }
}
