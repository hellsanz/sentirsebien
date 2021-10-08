using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SentirseBienApp
{
    public partial class VentanaAdmin : Form
    {
        public VentanaAdmin()
        {
            InitializeComponent();
        }       

        private void button1_Agregar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
            habilitarCampos();
        }
        public Boolean controlCargaDatos()
        {
            Boolean control = true;
            if (string.IsNullOrEmpty(textBox_nombre.Text))
            {
                MessageBox.Show("¡Error en Nombre! - Campo Vacio");
                control = false;
            }
            if (string.IsNullOrEmpty(textBox_apellido.Text))
            {
                MessageBox.Show("¡Error en Apellido! - Campo Vacio");
                control = false;
            }
            if (string.IsNullOrEmpty(textBox_dni.Text))
            {
                MessageBox.Show("¡Error en DNI! - Campo Vacio");
                control = false;
            }
            int temp = 0;
            if (!int.TryParse(textBox_dni.Text, out temp))
            {                     
                MessageBox.Show("¡Error en DNI! - Debe cargar un Numero");
                control = false;
            }
            if (string.IsNullOrEmpty(textBox_email.Text))
            {
                MessageBox.Show("¡Error en Email! - Campo Vacio");
                control = false;
            }
            if (string.IsNullOrEmpty(textBox_nro.Text))
            {
                MessageBox.Show("¡Error en Nro Cliente! - Campo Vacio");
                control = false;
            }           
            if (!int.TryParse(textBox_nro.Text, out temp))
            {
                MessageBox.Show("¡Error en Nro Cliente! - Debe cargar un Numero");
                control = false;
            }
            return control;
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            if (controlCargaDatos() == true)
            {
                capturarCampos();
                limpiarCampos();
                deshabilitarCampos();
            }                       
        }
        private void button_cancelar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
            deshabilitarCampos();
        }
        public void limpiarCampos()
        {
            textBox_nombre.Text = "";
            textBox_apellido.Text = "";
            textBox_dni.Text = "";
            textBox_email.Text = "";
            textBox_nro.Text = "";
            textBox_telefono.Text = "";
        }      
        public void capturarCampos()
        {
            string bd_nombre = textBox_nombre.Text;
            string bd_apellido = textBox_apellido.Text;
            int bd_dni = int.Parse(textBox_dni.Text);
            string bd_email = textBox_email.Text;
            int bd_nro = int.Parse(textBox_nro.Text);
            int bd_telefono = int.Parse(textBox_telefono.Text);
            MessageBox.Show("El Cliente "+bd_nombre+" "+bd_apellido+" con DNI: "+bd_dni+" Ha sido Correctamente cargado");
        }
        public void habilitarCampos()
        {
            textBox_nombre.Enabled = true;
            textBox_apellido.Enabled = true;
            textBox_dni.Enabled = true;
            textBox_email.Enabled = true;
            textBox_nro.Enabled = true;
            textBox_telefono.Enabled = true;
            button_aceptar.Enabled = true;            
            button_cancelar.Enabled = true;
        }
        public void deshabilitarCampos()
        {
            textBox_nombre.Enabled = false;
            textBox_apellido.Enabled = false;
            textBox_dni.Enabled = false;
            textBox_email.Enabled = false;
            textBox_nro.Enabled = false;
            textBox_telefono.Enabled = false;
            button_aceptar.Enabled = false;
            button_cancelar.Enabled = false;
            button_aceptarM.Visible = false;
            button_aceptar.Visible = true;
        }
        public void guardarCampos()
        {
            //datos de los campos guardados
            //tanto para agregar como para modificar



        }
        private void button1_modificar_Click(object sender, EventArgs e)
        {
            //Traer info de la dataGridView
            //variables hardcodeadas
            int hardDNI = 3454784;
            string hardEmail = "pepita_la_pistolera@gmail.com";
            string hardApellido = "Messi";
            string hardNombre = "Leonel";
            int hardNRO = 30;            

            textBox_apellido.Text = hardApellido;
            textBox_nombre.Text = hardNombre;
            textBox_dni.Text = Convert.ToString(hardDNI);
            textBox_email.Text = hardEmail;
            textBox_nro.Text = Convert.ToString(hardNRO);

            habilitarCampos();
            button_aceptar.Visible = false;
            button_aceptarM.Enabled = true;
            button_aceptarM.Visible = true;
        }
        //ACEPTAR DE MODIFICAR
        private void button_aceptarM_Click(object sender, EventArgs e)
        {
            button_aceptarM.Enabled = false;
            button_aceptarM.Visible = false;
            button_aceptar.Visible = true;
            deshabilitarCampos();
        }

        
    }
}
