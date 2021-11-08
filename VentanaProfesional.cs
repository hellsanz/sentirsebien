using System;
using System.Collections.Generic;
using System.ComponentModel;
using MySql.Data.MySqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SentirseBienApp
{
    public partial class VentanaProfesional : Form
    {
        static string atendido = "";        
        public VentanaProfesional()
        {            
            //ICONO DE LA APLICACION
            Icon ic = global::SentirseBienApp.Properties.Resources.este;
            this.Icon = ic;
            timer1 = new Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            InitializeComponent();
            //Setear nombre de Profesional en Label
            label_nombreProfesional.Text = Transferencias.globalnombreUsuario;
            timer1.Enabled = true;            
        }

        public Boolean controlCargaDatos()
        {
            Boolean control = true;
            int temp = 0;
            if (string.IsNullOrEmpty(textBox_cliente_dni.Text))
            {
                MessageBox.Show("¡Error en DNI! - Campo Vacio");
                control = false;
            }
            else
            {
                if (!int.TryParse(textBox_cliente_dni.Text, out temp))
                {
                    MessageBox.Show("¡Error en DNI! - Debe cargar un Numero");
                    textBox_cliente_dni.Text = "";
                    control = false;
                }
            }    
            return control;
        }
        public void hacerUpdate(string profesional, int dni, int id)
        {
            ConexDB log = new ConexDB();
            string query = "UPDATE turno SET profesional = @profesional WHERE dni = @dni and idTurno = @idTurno";
            using (MySqlCommand cmd = new MySqlCommand(query, log.conectarBD))
            {
                try
                {
                    cmd.Parameters.AddWithValue("@dni", dni);
                    cmd.Parameters.AddWithValue("@idTurno", id);
                    cmd.Parameters.AddWithValue("@profesional", profesional);
                    log.abrirBD();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    MessageBox.Show("Error!\nNo se ha podido concretar la accion\nException: " + e.Message);
                }
                finally
                {
                    log.cerrarBD();                    
                }
            }
            registroDeActividad("atendió el turno del cliente con DNI: "+dni);
        }
        private void button_Actualizar_Click(object sender, EventArgs e)
        {
            if (controlCargaDatos() == true)
            {                
                if ((dataGridView_serviciosList.SelectedCells.Count > 0) && (atendido != ""))
                {
                    //hacer el update si selecion tupla y realizado o cancelado
                    
                    hacerUpdate(atendido, Convert.ToInt32(dataGridView_serviciosList.SelectedCells[1].Value.ToString()),
                        Convert.ToInt32(dataGridView_serviciosList.SelectedCells[0].Value.ToString()));//Profesional DNI Id
                    atendido = "";//resetear la static
                }
                else
                {
                    buscarTurnosCliente(Convert.ToInt32(textBox_cliente_dni.Text));//paso DNI
                }                              
            }            
        }
        public void buscarTurnosCliente(int dni)
        {            
            dataGridView_serviciosList.DataSource = null;
            ConexDB buscarClientes = new ConexDB();
            string query = "SELECT * from turno WHERE dni = @dni and profesional is null";
            using (MySqlCommand cmd = new MySqlCommand(query, buscarClientes.conectarBD))
            {
                cmd.Parameters.AddWithValue("@dni", dni);
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
                if (dataGridView_serviciosList.RowCount == 0)
                {
                    MessageBox.Show("Sin datos para mostrar");//no encuentra turnos de ese DNI
                    radioButton1_realizado.Enabled = false;
                    radioButton1_cancelado.Enabled = false;
                }
                else
                {
                    textBox_cliente_dni.Enabled = false;
                    button_Actualizar.Enabled = false;
                }
            }
            registroDeActividad("Actualizó lista turnos no atendidos del cliente con DNI: " + dni);
        }

        public void buscarApeNomCliente(int dni)
        {
            //buscar cliente por DNI
            ConexDB buscarClientes = new ConexDB();
            string query = "SELECT nombre, apellido FROM cliente WHERE dni = @dni";
            using (MySqlCommand cmd = new MySqlCommand(query, buscarClientes.conectarBD))
            {
                cmd.Parameters.AddWithValue("@dni", dni);
                buscarClientes.abrirBD();
                MySqlDataAdapter mysqlDataAdap = new MySqlDataAdapter(cmd);
                DataTable dtRecord = new DataTable();
                mysqlDataAdap.Fill(dtRecord);
                dataGridView_tempApeNom.DataSource = dtRecord;                            
                label_apellido.Text = dataGridView_tempApeNom.Rows[0].Cells[0].Value.ToString();
                label_nombre.Text = dataGridView_tempApeNom.Rows[0].Cells[1].Value.ToString();
                if (dataGridView_tempApeNom.RowCount == 0)
                {
                    label_apellido.Text = "Anonimo";
                    label_nombre.Text = "Anonimo";
                    MessageBox.Show("Cliente No Registrado");
                }
                buscarClientes.cerrarBD();
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView_serviciosList.SelectedCells.Count > 0)
            {
                dataGridView_serviciosList.Rows[e.RowIndex].Selected = true;                 
                textBox_cliente_dni.Text = dataGridView_serviciosList.SelectedCells[1].Value.ToString();
                label_servicio.Text = dataGridView_serviciosList.SelectedCells[2].Value.ToString();
                DateTime fecha = Convert.ToDateTime(dataGridView_serviciosList.SelectedCells[3].Value.ToString());
                label_fecha.Text = fecha.ToShortDateString();                
                label_hora.Text = dataGridView_serviciosList.SelectedCells[4].Value.ToString();
                buscarApeNomCliente(Convert.ToInt32(dataGridView_serviciosList.SelectedCells[1].Value.ToString()));                
                radioButton1_realizado.Enabled = true;
                radioButton1_cancelado.Enabled = true;
                dataGridView_serviciosList.Enabled = false;
            }
        }

        private void radioButton1_realizado_CheckedChanged(object sender, EventArgs e)
        {
            button_Actualizar.Enabled = true;
            atendido = Transferencias.globalnombreUsuario;//nombre del profesional
        }

        private void radioButton1_cancelado_CheckedChanged(object sender, EventArgs e)
        {
            button_Actualizar.Enabled = true;
            atendido = "no";
        }

        private void button_Cancelar_Click(object sender, EventArgs e)
        {
            dataGridView_serviciosList.DataSource = null;
            dataGridView_serviciosList.Enabled = true;
            textBox_cliente_dni.Text = "";
            textBox_cliente_dni.Enabled = true;
            button_Actualizar.Enabled = true;
            label_apellido.Text = "-";
            label_nombre.Text = "-";
            label_servicio.Text = "-";
            label_fecha.Text = "-";
            label_hora.Text = "-";
        }

        public void registroDeActividad(string actividad)
        {
            ConexDB insCli = new ConexDB();
            string query = "INSERT INTO seguridad (usuario, fecha, hora, tipo, msg) VALUES (@usuario, @fecha, @hora, @tipo, @msg)";
            using (MySqlCommand cmd = new MySqlCommand(query, insCli.conectarBD))
            {
                try
                {                    //aaaa/mm/dd
                    cmd.Parameters.AddWithValue("@usuario", Transferencias.globalnombreUsuario);
                    cmd.Parameters.AddWithValue("@fecha", DateTime.Now.ToShortDateString());
                    cmd.Parameters.AddWithValue("@hora", DateTime.Now.ToShortTimeString());
                    cmd.Parameters.AddWithValue("@tipo", "Profesional");
                    cmd.Parameters.AddWithValue("@msg", actividad);
                    insCli.abrirBD();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    MessageBox.Show("Error! Admin\nNo se ha podido concretar la accion\nException: " + e.Message + "\n" + e.StackTrace);
                }
                finally
                {
                    insCli.cerrarBD();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dia = DateTime.Now;
            label_timer_fecha.Text = dia.ToShortDateString();
            label_timer_hora.Text = dia.ToLongTimeString();
        }

        private void VentanaProfesional_Load(object sender, EventArgs e)
        {
            dataGridView_serviciosList.RowHeadersVisible = false;
        }

        private void button1_c_sinAtender_Click(object sender, EventArgs e)
        {
            Ventana1ListadoCliente ventana = new Ventana1ListadoCliente();
            AddOwnedForm(ventana);
            ventana.Show();
        }
    }
}
//Profesionales: Acceso a los servicios que deben prestar por día.

