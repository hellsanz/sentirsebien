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
            Icon ic = global::SentirseBienApp.Properties.Resources.este;
            this.Icon = ic;
            InitializeComponent();            
            inicializarLabels();
            label_nombreProfesional.Text = Transferencias.globalnombreUsuario;
            dataGridView_serviciosList.RowHeadersVisible = false;
        }

        //Eventos de Boton
        private void button_buscar_Click(object sender, EventArgs e)
        {
            //traer todos los turnos de clientes
            //consulta interseccion            
            Boolean control = true;            
            int temp = 0;
            if (!int.TryParse(textBox_busqueda.Text, out temp))
            {
                MessageBox.Show("Error! - ¡Debe cargar un Numero!");
                control = false;
            }
            if (control == true)
            {
                buscarTurnos(int.Parse(textBox_busqueda.Text));                
            }
        }
        

        //Metodos
        public void buscarTurnos(int dni)
        {                   
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
            registroDeActividad("Busco Turno de Cliente");
        }
        public void buscarProfesional(string Nombreservicio)
        {
            //buscar costo en base de datos por nombre de servicio
            int costo = 100;

            textBox_costoS.Text = Convert.ToString(costo);
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

        private void button2_Click(object sender, EventArgs e)
        {
            //hacer el llamado de ventana cobros
            registroDeActividad("Revisa Cobros");
            Ventana1Cobros ventanaCobro = new Ventana1Cobros();
            AddOwnedForm(ventanaCobro);
            ventanaCobro.Show();
        }

        private void button_imprimir_Click(object sender, EventArgs e)
        {
            registroDeActividad("Imprime Informe");
        }

        private void dataGridView_serviciosList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView_serviciosList.SelectedCells.Count > 0)
            {
                //id dni servicio fecha hora profesional
                dataGridView_serviciosList.Rows[e.RowIndex].Selected = true;
                label_cliente_dni.Text = dataGridView_serviciosList.SelectedCells[1].Value.ToString();                
                label_cliente_servicio.Text = dataGridView_serviciosList.SelectedCells[2].Value.ToString();
                label_cliente_fecha.Text = dataGridView_serviciosList.SelectedCells[3].Value.ToString();
                buscarApeNom(Convert.ToInt32(dataGridView_serviciosList.SelectedCells[1].Value));
                buscarCosto(dataGridView_serviciosList.SelectedCells[2].Value.ToString());
                if (Transferencias.globalNombre != "")
                {
                    label_cliente_nombre.Text = Transferencias.globalNombre;
                }else{
                    MessageBox.Show("¡ERROR!\n - El Cliente no tiene nombre - ");
                }
                if (Transferencias.globalApellido != "")
                {
                    label_cliente_apellido.Text = Transferencias.globalApellido;
                }else{
                    MessageBox.Show("¡ERROR!\n - El Cliente no tiene apellido - ");
                }
                //costo
                if (Transferencias.globalmontoServicio > 0)
                {
                    textBox_monto.Text = Convert.ToString(Transferencias.globalmontoServicio);
                }
                else
                {
                    textBox_monto.Text = "No pago";
                }
                                                  
            }
        }

        public void buscarApeNom(int dni)
        {
            ConexDB buscarClientes = new ConexDB();
            string query = "SELECT * from cliente WHERE dni = @dni";
            using (MySqlCommand cmd = new MySqlCommand(query, buscarClientes.conectarBD))
            {
                cmd.Parameters.AddWithValue("@dni", Convert.ToInt32(label_cliente_dni.Text));
                buscarClientes.abrirBD();
                MySqlDataAdapter mysqlDataAdap = new MySqlDataAdapter(cmd);
                DataTable dtRecord = new DataTable();
                mysqlDataAdap.Fill(dtRecord);
                dataGridView1.DataSource = dtRecord;
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.Columns[0].HeaderText = "DNI";
                dataGridView1.Columns[1].HeaderText = "APELLIDO";
                dataGridView1.Columns[2].HeaderText = "NOMBRE";                
                if (dataGridView1.RowCount != 0)
                {                    
                    Transferencias.globalApellido = Convert.ToString(dataGridView1.Rows[0].Cells[1].Value.ToString());
                    Transferencias.globalNombre = Convert.ToString(dataGridView1.Rows[0].Cells[2].Value.ToString());
                }
            }                     
        }
        public void buscarCosto(string nombreServicio)
        {
            ConexDB buscarClientes = new ConexDB();
            string query = "SELECT * from servicio WHERE nombre = @nombre";
            using (MySqlCommand cmd = new MySqlCommand(query, buscarClientes.conectarBD))
            {
                cmd.Parameters.AddWithValue("@nombre", nombreServicio);
                buscarClientes.abrirBD();
                MySqlDataAdapter mysqlDataAdap = new MySqlDataAdapter(cmd);
                DataTable dtRecord = new DataTable();
                mysqlDataAdap.Fill(dtRecord);
                dataGridView1.DataSource = dtRecord;
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.Columns[0].HeaderText = "ID";
                dataGridView1.Columns[1].HeaderText = "Nombre";                
                if (dataGridView1.RowCount != 0)
                {                    
                    Transferencias.globalmontoServicio =Convert.ToInt32(dataGridView1.Rows[0].Cells[1].Value.ToString());                    
                }
                else
                {
                    MessageBox.Show("El monto es 0");
                }
            }            
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
                    cmd.Parameters.AddWithValue("@tipo", "Secretario");
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

        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            registroDeActividad("Imprime Informe");
        }

        private void cobrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //hacer el llamado de ventana cobros
            registroDeActividad("Revisa Cobros");
            Ventana1Cobros ventanaCobro = new Ventana1Cobros();
            AddOwnedForm(ventanaCobro);
            ventanaCobro.Show();
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            registroDeActividad("Cerro Sesión");
            this.Close();
        }

        private void sALIRToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            registroDeActividad("Salió de la Aplicación");            
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dia = DateTime.Now;
            label_timer_fecha.Text = dia.ToShortDateString();
            label_timer_hora.Text = dia.ToLongTimeString();
        }

        private void sESIONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Usuario: " + Transferencias.globalnombreUsuario + "\nAbierta a las: " + Transferencias.globalfechaHora + "\nNivel de Acceso: Admin");
        }

        private void iNFORMACIONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Windows Forms\nAplicacion de Escritorio\nVersion Alpha 0.1\nPrograma Desarrollado por TLC");
        }

        private void cONTACTOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Desarrolladores: Alonso Manuel G - Sanchez Pablo S.N.\n - 2021 -" +
                "\nthelazycompany@gmail.com");
        }
    }
}
