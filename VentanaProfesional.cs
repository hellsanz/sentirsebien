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
    public partial class VentanaProfesional : Form
    {
        public VentanaProfesional()
        {
            InitializeComponent();
        }

        private void button_Actualizar_Click(object sender, EventArgs e)
        {
            buscarTurnosCliente();
        }
        public void buscarTurnosCliente()
        {            
            dataGridView_serviciosList.DataSource = null;
            ConexDB buscarClientes = new ConexDB();
            string query = "SELECT * from turno WHERE dni = @dni and profesional is null";
            using (MySqlCommand cmd = new MySqlCommand(query, buscarClientes.conectarBD))
            {
                cmd.Parameters.AddWithValue("@dni", Convert.ToInt32(textBox_cliente_dni.Text));
                buscarClientes.abrirBD();
                MySqlDataAdapter mysqlDataAdap = new MySqlDataAdapter(cmd);
                DataTable dtRecord = new DataTable();
                mysqlDataAdap.Fill(dtRecord);
                dataGridView_serviciosList.DataSource = dtRecord;
                dataGridView_serviciosList.AllowUserToAddRows = false;
                dataGridView_serviciosList.Columns[0].HeaderText = "ID";
                dataGridView_serviciosList.Columns[1].HeaderText = "DNI";
                dataGridView_serviciosList.Columns[2].HeaderText = "SERVICIO";
                dataGridView_serviciosList.Columns[3].HeaderText = "FECHA";
                dataGridView_serviciosList.Columns[4].HeaderText = "HORA";
                dataGridView_serviciosList.Columns[5].HeaderText = "PROFESIONAL";
                dataGridView_serviciosList.Columns[6].HeaderText = "PAGO";                
                if (dataGridView_serviciosList.RowCount == 0)
                {
                    MessageBox.Show("Sin datos para mostrar");
                }
            }
        }
    }
}
//Profesionales: Acceso a los servicios que deben prestar por día.

