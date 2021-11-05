using MySql.Data.MySqlClient;
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
    public partial class Ventana1ListadoCliente : Form
    {
        public Ventana1ListadoCliente()
        {
            timer = new Timer();
            timer.Tick += new EventHandler(timer_Tick);
            InitializeComponent();
            timer.Enabled = true;
            actualizarLista(dateTimePicker_desde.Value,dateTimePicker_hasta.Value);
        }


        public void actualizarLista(DateTime desde, DateTime hasta)
        {            
            ConexDB buscarClientes = new ConexDB();
            string query = "SELECT cliente.nombre, cliente.apellido, turno.dni, turno.servicio, turno.fecha, turno.hora" +
                "from turno inner join cliente on turno.dni = cliente.dni" +
                "where (turno.profesional is null) and (fecha between @desde and @hasta";
            using (MySqlCommand cmd = new MySqlCommand(query, buscarClientes.conectarBD))
            {
                cmd.Parameters.AddWithValue("@desde",desde);
                cmd.Parameters.AddWithValue("@hasta", hasta);
                buscarClientes.abrirBD();
                MySqlDataAdapter mysqlDataAdap = new MySqlDataAdapter(cmd);
                DataTable dtRecord = new DataTable();
                mysqlDataAdap.Fill(dtRecord);
                dataGridView1.DataSource = dtRecord;
                dataGridView1.AllowUserToAddRows = false;
                if (dataGridView1.RowCount == 0)
                {
                    MessageBox.Show("Sin datos para mostrar");
                }
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            actualizarLista(dateTimePicker_desde.Value, dateTimePicker_hasta.Value);
        }
    }
}
