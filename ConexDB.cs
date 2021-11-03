using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using MySql.Data.MySqlClient;


namespace SentirseBienApp
{
    class ConexDB
    {        
        public string conexion = File.ReadAllText(@"C:\conexBD.txt");
        public  MySqlConnection conectarBD = new MySqlConnection();
        public ConexDB() { conectarBD.ConnectionString = conexion; }

        public void abrirBD()
        {
            try
            {
                conectarBD.Open();
                //System.Windows.Forms.MessageBox.Show("Conexion Abierta!");
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error: " + ex.Message);
            }
        }

        public void cerrarBD()
        {
            try
            {
                conectarBD.Close();
                //System.Windows.Forms.MessageBox.Show("Conexcion Cerrada!");
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
