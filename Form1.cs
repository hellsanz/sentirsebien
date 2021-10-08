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
                String password = textBox1_password.Text;  
                textBox1_usuario.Text = "";
                textBox1_password.Text = "";
                if (existeUsuario(usuario) == true)
                {
                    if (verificarPassword(password) == true)
                    {
                        if (int.Parse(textBox_accesoS.Text) == 0)
                        {
                            MessageBox.Show("¡Sistema Abierto!\nUsuario: "+usuario+"\nAcceso: Administrador");
                            VentanaAdmin ventanaAdmin = new VentanaAdmin();
                            AddOwnedForm(ventanaAdmin);
                            usuario = "";
                            password = "";
                            this.Visible = false;
                            ventanaAdmin.ShowDialog();
                        }
                        if (int.Parse(textBox_accesoS.Text) == 1)
                        {
                            MessageBox.Show("¡Sistema Abierto!\nUsuario: " + usuario + "\nAcceso: Profesional");
                            VentanaProfesional ventanaUsuario = new VentanaProfesional();
                            AddOwnedForm(ventanaUsuario);
                            usuario = "";
                            password = "";
                            this.Visible = false;
                            ventanaUsuario.ShowDialog();
                        }
                        if (int.Parse(textBox_accesoS.Text) == 2)
                        {
                            MessageBox.Show("¡Sistema Abierto!\nUsuario: " + usuario + "\nAcceso: Secretaría");
                            VentanaSecretario ventanaSecretario = new VentanaSecretario();
                            AddOwnedForm(ventanaSecretario);
                            usuario = "";
                            password = "";
                            this.Visible = false;
                            ventanaSecretario.ShowDialog();
                        }
                        if ((int.Parse(textBox_accesoS.Text) > 2) || (int.Parse(textBox_accesoS.Text) < 0))
                        {
                            MessageBox.Show("¡ERROR DE ACCESO!\n Consulte con el Administrador");
                            usuario = "";
                            password = "";
                        }
                    }
                    else
                    {
                        MessageBox.Show("¡Password incorrecto!\nIntentos Restantes: "+ intentos);
                        usuario = "";
                        password = "";
                        intentos--;
                        textBox_contador.Text = Convert.ToString(intentos);
                    }
                }
                else
                {
                    MessageBox.Show("¡Usuario inexistente!");
                    usuario = "";
                    password = "";
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
        public Boolean existeUsuario(string usuario)
        {
            //Revisar si el usuario existe en la BD
            //buscar Usuario en BD
            //Traer Nombre Password Acceso
            string nom = "pepe";
            string pass = "1234";
            string acc = "0";

            Boolean existe = true;

            if (existe == true)
            {
                textBox_usuarioS.Text = nom;
                textBox_passwordS.Text = pass;
                textBox_accesoS.Text = acc;
                return true;
            }
            else
            {
                return false;
            }      
        }
        public Boolean verificarPassword(string password)
        {
            //traer de la BD el PASS y ver si coincide
            if (password == textBox_passwordS.Text)
            {
                return true;
            }
            else
            {
                return false;
            }   
        }             
    }
}
