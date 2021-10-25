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
    public partial class VentanaSecretario : Form
    {
        public VentanaSecretario()
        {
            InitializeComponent();
            inicializarLabels();
        }

        //Eventos de Boton
        private void button_buscar_Click(object sender, EventArgs e)
        {
            Boolean control = true;            
            int temp = 0;
            if (!int.TryParse(textBox_busqueda.Text, out temp))
            {
                MessageBox.Show("Error! - ¡Debe cargar un Numero!");
                control = false;
            }
            if (control == true)
            {
                buscarTurnosAtendidos(int.Parse(textBox_busqueda.Text));
                cargarLabels();
            }
        }
        private void button_cobrar_Click(object sender, EventArgs e)
        {

        }

        //Metodos
        public void buscarTurnosAtendidos(int dni)//sin cobro
        {
            //buscar TODOS los turnos atendidos
            //y cargarlos en el DataGridView
            //donde seleciono uno
            //y capturo el ID para luego            
            ConexDB clientes = new ConexDB();
            string query = "SELECT * from Turno WHERE dni = @dni";
            using (MySqlCommand cmd = new MySqlCommand(query, clientes.conectarBD))
            {
                clientes.abrirBD();
                cmd.Parameters.AddWithValue("@dni", dni);
                MySqlDataAdapter mysqlDataAdap = new MySqlDataAdapter(cmd);
                DataTable dtRecord = new DataTable();
                mysqlDataAdap.Fill(dtRecord);
                dataGridView_serviciosList.DataSource = dtRecord;
                dataGridView_serviciosList.AllowUserToAddRows = false;
                if (dataGridView_serviciosList.RowCount == 0)
                {
                    MessageBox.Show("Sin datos para mostrar");
                }
                clientes.cerrarBD();
            }
        }
        public void buscarProfesional(string Nombreservicio)
        {
            //buscar costo en base de datos por nombre de servicio
            int costo = 100;

            textBox_costoS.Text = Convert.ToString(costo);
        }
        public void cargarLabels()
        {
            //tomar datos buscados y cargarlos en las labels
        }

        public void buscarCliente(int dni)
        {
            //traer nombre y apellido por dni
            string nombre = "pedro";
            string apellido = "soto";

            textBox_nombreS.Text = nombre;
            textBox_apellidoS.Text = apellido;
        }
        public void inicializarLabels()
        {
            label_cliente_apellido.Text = "-";
            label_cliente_nombre.Text = "-";
            label_cliente_dni.Text = "-";
            label_cliente_fecha.Text = "-";
            label_cliente_servicio.Text = "-";
        }
    }
}
