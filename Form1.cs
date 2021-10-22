using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SentirseBienApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {            
            InitializeComponent();
            textBox_contador.Text = "2";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loggeo(int.Parse(textBox_contador.Text));      
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void loggeo(int intentos)
        {
            //traer los datos del usuario buscado por nombre            
            
            if (intentos == 0)//control de cantidad de intentos
            {
                textBox1_usuario.Enabled = false;
                textBox1_password.Enabled = false;
                button1.Enabled = false;
                MessageBox.Show("¡Sistema Bloqueado!\nNumero de Intentos: 0");
            }
            Boolean control = true;
            control = controlDatos();
            if (control == true)
            {
                String usuario = textBox1_usuario.Text;  
                if (existeUsuario() == true)
                {            
                    textBox1_usuario.Text = "";
                    textBox1_password.Text = "";
                    if (consultaAcceso() == 0)
                    {
                        MessageBox.Show("¡Sistema Abierto!\nUsuario: " + usuario + "\nAcceso: Administrador");
                        VentanaAdmin ventanaAdmin = new VentanaAdmin();
                        AddOwnedForm(ventanaAdmin);
                        usuario = "";                        
                        //this.Visible = false;
                        ventanaAdmin.ShowDialog();
                    }
                    if (consultaAcceso() == 1)
                    {
                        MessageBox.Show("¡Sistema Abierto!\nUsuario: " + usuario + "\nAcceso: Profesional");
                        VentanaProfesional ventanaUsuario = new VentanaProfesional();
                        AddOwnedForm(ventanaUsuario);
                        usuario = "";                        
                        this.Visible = false;
                        ventanaUsuario.ShowDialog();
                    }
                    if (consultaAcceso() == 2)
                    {
                        MessageBox.Show("¡Sistema Abierto!\nUsuario: " + usuario + "\nAcceso: Secretaría");
                        VentanaSecretario ventanaSecretario = new VentanaSecretario();
                        AddOwnedForm(ventanaSecretario);
                        usuario = "";                       
                        this.Visible = false;
                        ventanaSecretario.ShowDialog();
                    }
                    if ((consultaAcceso() > 2) || (consultaAcceso() < 0))
                    {
                        MessageBox.Show("¡ERROR DE ACCESO!\n Consulte con el Administrador");
                        usuario = "";                        
                    }
                }
                else
                {
                    textBox1_usuario.Text = "";
                    textBox1_password.Text = "";                    
                    usuario = "";                    
                }
            }
        }

        //METODOS
        public Boolean controlDatos()
        {
            Boolean control = true;
            if (string.IsNullOrEmpty(textBox1_usuario.Text))
            {
                MessageBox.Show("¡Error! debe cargar Su nombre de usuario");
                control = false;
            }
            if (string.IsNullOrEmpty(textBox1_password.Text))
            {
                MessageBox.Show("¡Error! debe cargar su Contraseña");
                control = false;
            }
            return control;
        }
        public Boolean existeUsuario()
        {
            int intentos = 0;
            intentos = int.Parse(textBox_contador.Text);            
            string acc = "";
            //Conectando Azure MySql
            ConexDB log = new ConexDB();
            string query = "SELECT EXISTS(SELECT 1 FROM usuarios WHERE nombre = @nombre and dni = @pass)";
            using (MySqlCommand cmd = new MySqlCommand(query, log.conectarBD))
            {
                log.abrirBD();
                cmd.Parameters.AddWithValue("@nombre", textBox1_usuario.Text);
                cmd.Parameters.AddWithValue("@pass", Convert.ToInt32(textBox1_password.Text));
                int r;
                try
                {
                    r = Convert.ToInt32(cmd.ExecuteScalar());
                    if (r == 1)
                    {
                        log.cerrarBD();
                        textBox_accesoS.Text = acc;
                        return true;                        
                    }
                    else
                    {
                        log.cerrarBD();
                        MessageBox.Show("¡Datos incorrectos!\nIntentos Restantes: " + intentos);
                        intentos--;
                        textBox_contador.Text = Convert.ToString(intentos);
                        return false;                        
                    }
                    
                }
                catch (Exception)
                {
                    log.cerrarBD();
                    MessageBox.Show("Error de Coneccion con la BBDD");
                    throw;                    
                }                   
            }
        }
        public int consultaAcceso()
        {
            //necesito que me traigas el acceso del usuario de BD
            //SI o SI haceme esto
            //si necesitas algun parametro hace una variable hardcodeada y te la conecto despues
            int acc = 0;            
            return acc;
        }             
    }
}
