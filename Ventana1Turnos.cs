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
    public partial class Ventana1Turnos : Form
    {
        public Ventana1Turnos()
        {
            Icon ic = global::SentirseBienApp.Properties.Resources.este;
            this.Icon = ic;
            InitializeComponent();
            dataGridView1.RowHeadersVisible = false;           
        }

        private void button_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_actualizar_Click(object sender, EventArgs e)
        {
            buscarTurnosSinAtender(Convert.ToDateTime(dateTimePicker1desde.Text),Convert.ToDateTime(dateTimePicker1hasta.Text));
        }
        public void buscarTurnosSinAtender(DateTime desde, DateTime hasta)
        {
            dataGridView1.DataSource = null;
            ConexDB buscarClientes = new ConexDB();
            string query = "SELECT * from turno WHERE (profesional is null) and (fecha between @desde and @hasta)";
            using (MySqlCommand cmd = new MySqlCommand(query, buscarClientes.conectarBD))
            {
                cmd.Parameters.AddWithValue("@desde", desde);
                cmd.Parameters.AddWithValue("@hasta", hasta);
                buscarClientes.abrirBD();
                MySqlDataAdapter mysqlDataAdap = new MySqlDataAdapter(cmd);
                DataTable dtRecord = new DataTable();
                mysqlDataAdap.Fill(dtRecord);
                dataGridView1.DataSource = dtRecord;
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.Columns[0].HeaderText = "ID";
                dataGridView1.Columns[1].HeaderText = "DNI";
                dataGridView1.Columns[2].HeaderText = "SERVICIO";
                dataGridView1.Columns[3].HeaderText = "FECHA";
                dataGridView1.Columns[4].HeaderText = "HORA";
                dataGridView1.Columns[5].Visible = false;
                if (dataGridView1.RowCount == 0)
                {
                    MessageBox.Show("Sin datos para mostrar");//no encuentra turnos de ese DNI                    
                }                
            }
        }
    }
}