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
                registroDeIngreso("Anonimo", "Ingreso Fallido!");
                MessageBox.Show("¡Sistema Bloqueado!\nNumero de Intentos: 0");
            }
            Boolean control = true;
            control = controlDatos();
            if (control == true)
            {
                String usuario = textBox1_usuario.Text;  
                if (existeUsuario() == true)
                {    
                    if (consultaAcceso() == 0)
                    {
                        MessageBox.Show("¡Sistema Abierto!\nUsuario: " + usuario + "\nAcceso: Administrador");
                        VentanaAdmin ventanaAdmin = new VentanaAdmin();
                        AddOwnedForm(ventanaAdmin);
                        Transferencias.globalnombreUsuario = usuario;
                        usuario = "";
                        registroDeIngreso("Admin", "Ingresó");                        
                        textBox1_usuario.Text = "";
                        textBox1_password.Text = "";
                        ventanaAdmin.ShowDialog();
                    }
                    if (consultaAcceso() == 1)
                    {
                        MessageBox.Show("¡Sistema Abierto!\nUsuario: " + usuario + "\nAcceso: Profesional");
                        VentanaProfesional ventanaUsuario = new VentanaProfesional();
                        AddOwnedForm(ventanaUsuario);
                        Transferencias.globalnombreUsuario = usuario;
                        usuario = "";
                        registroDeIngreso("Profesional", "Ingresó");
                        textBox1_usuario.Text = "";
                        textBox1_password.Text = "";
                        ventanaUsuario.ShowDialog();
                    }
                    if (consultaAcceso() == 2)
                    {
                        MessageBox.Show("¡Sistema Abierto!\nUsuario: " + usuario + "\nAcceso: Secretaría");
                        VentanaSecretario ventanaSecretario = new VentanaSecretario();
                        AddOwnedForm(ventanaSecretario);
                        Transferencias.globalnombreUsuario = usuario;
                        usuario = "";
                        registroDeIngreso("Secretario", "Ingresó");
                        textBox1_usuario.Text = "";
                        textBox1_password.Text = "";
                        ventanaSecretario.ShowDialog();
                    }
                    if ((consultaAcceso() > 2) || (consultaAcceso() < 0))
                    {
                        textBox1_usuario.Text = "";
                        textBox1_password.Text = "";
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
            string query = "SELECT EXISTS(SELECT 1 FROM empleado WHERE usuario = @nombre and password = @pass)";
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
                        textBox_accesoS.Text = acc;
                        return true;                        
                    }
                    else
                    {                        
                        MessageBox.Show("¡Datos incorrectos!\nIntentos Restantes: " + intentos);
                        intentos--;
                        textBox_contador.Text = Convert.ToString(intentos);
                        return false;                        
                    }                    
                }
                catch (Exception e)
                {                    
                    MessageBox.Show("Error de Coneccion con la BBDD");                    
                    throw;                    
                }
                finally
                {
                    log.cerrarBD();
                }
            }
        }
        public int consultaAcceso()
        {
            //necesito que me traigas el acceso del usuario de BD
            //SI o SI haceme esto
            //si necesitas algun parametro hace una variable hardcodeada y te la conecto despues
            //0 ADMIN - 1 SECRETARIO - 2 USUARIO
            int acc;
            //Conectando Azure MySql
            ConexDB log = new ConexDB();
            string query = "SELECT permisos from empleado where usuario = @nombre";
            using (MySqlCommand cmd = new MySqlCommand(query, log.conectarBD))
            {
                cmd.Parameters.AddWithValue("@nombre", textBox1_usuario.Text);
                try
                {
                    log.abrirBD();
                    acc = Convert.ToInt32(cmd.ExecuteScalar());
                    log.cerrarBD();
                    return acc;
                }
                catch (Exception)
                {
                    MessageBox.Show("Error de Conexion con la BBDD");
                    log.cerrarBD();
                    return -1;  
                }                
            }
        }
        //metodos control
        public void registroDeIngreso(string tipo, string actividad)
        {
            ConexDB insCli = new ConexDB();
            string query = "INSERT INTO seguridad (usuario, fecha, hora, tipo, msg ) VALUES (@usuario, @fecha, @hora, @tipo, @msg)";
            using (MySqlCommand cmd = new MySqlCommand(query, insCli.conectarBD))
            {
                try
                {                    //aaaa/mm/dd
                    cmd.Parameters.AddWithValue("@usuario", Transferencias.globalnombreUsuario);
                    cmd.Parameters.AddWithValue("@fecha", DateTime.Now.ToShortDateString());
                    cmd.Parameters.AddWithValue("@hora", DateTime.Now.ToShortTimeString());
                    cmd.Parameters.AddWithValue("@tipo", tipo);
                    cmd.Parameters.AddWithValue("@msg", actividad);
                    insCli.abrirBD();
                    cmd.ExecuteNonQuery();                    
                }
                catch (Exception e)
                {
                    MessageBox.Show("Error! Login\nNo se ha podido concretar la accion\nException: " + e.Message + "\n" + e.StackTrace);
                }
                finally
                {
                    insCli.cerrarBD();
                }
            }
        }
    }
}
