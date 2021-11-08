﻿using MySql.Data.MySqlClient;
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
    public partial class Ventana1Seguridad : Form
    {
        private Timer tiempo;
        public Ventana1Seguridad()
        {
            Icon ic = global::SentirseBienApp.Properties.Resources.este;
            this.Icon = ic;
            tiempo = new Timer();
            tiempo.Tick += new EventHandler(timer_fechahora_Tick);
            InitializeComponent();
            tiempo.Enabled = true;
            dataGridView1.RowHeadersVisible = false;
            actualizarLista();
        }

        private void timer_fechahora_Tick(object sender, EventArgs e)
        {
            DateTime dia = DateTime.Now;
            label_fecha.Text = dia.ToShortDateString();
            label_hora.Text = dia.ToLongTimeString();
        }        

        private void button_cerrarVentana_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer_actualizar_lista_Tick(object sender, EventArgs e)
        {
            dataGridView1.RowHeadersVisible = false;
            actualizarLista();           
        }
        public void actualizarLista()
        {
            ConexDB buscarClientes = new ConexDB();
            string query = "SELECT * from seguridad ORDER BY idSeguridad DESC";
            using (MySqlCommand cmd = new MySqlCommand(query, buscarClientes.conectarBD))
            {                
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.RowHeadersVisible = false;
        }
    }
}
