﻿using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;
namespace SentirseBienApp
{
    public partial class VentanaAdmin : Form
    {
        public VentanaAdmin()
        {
            InitializeComponent();
        }

        private void button1_Agregar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
            habilitarCampos();
            textBox_insert_update.Text = "0";
        }
        private void button1_modificar_Click(object sender, EventArgs e)
        {
            //Traer info de la dataGridView
            //variables hardcodeadas
            int hardDNI = 10;
            string hardEmail = "elbarsalacome@elmejor.com";
            string hardApellido = "Messi";
            string hardNombre = "Leonel";
            int hardNRO = 30;
            int hardTelefono = 545782;

            textBox_apellido.Text = hardApellido;
            textBox_nombre.Text = hardNombre;
            textBox_dni.Text = Convert.ToString(hardDNI);
            textBox_email.Text = hardEmail;
            textBox_nro.Text = Convert.ToString(hardNRO);
            textBox_telefono.Text = Convert.ToString(hardTelefono);

            textBox_insert_update.Text = "1";
            habilitarCampos();
        }
        private void button1_eliminar_Click(object sender, EventArgs e)
        {
            int hardDNI = 10;
            string hardEmail = "elbarsalacome@elmejor.com";
            string hardApellido = "Messi";
            string hardNombre = "Leonel";
            int hardNRO = 30;

            textBox_apellido.Text = hardApellido;
            textBox_nombre.Text = hardNombre;
            textBox_dni.Text = Convert.ToString(hardDNI);
            textBox_email.Text = hardEmail;
            textBox_nro.Text = Convert.ToString(hardNRO);

            MessageBox.Show("el Usuario: " + hardNombre + " " + hardApellido + "\nHa sido eliminado de la BBDD");
            int dni = int.Parse(textBox_dni.Text);
            eliminarCliente(dni);
        }
        private void button1_actualizar_Click(object sender, EventArgs e)
        {

            //CAMBIAR CONECCION de SQLServer a MYSQL
            //Traer todos clientes de la  db al datagrid


            ConexDB buscarClientes = new ConexDB();
            string query = "SELECT * from cliente";
            using (MySqlCommand cmd = new MySqlCommand(query, buscarClientes.conectarBD))
            {
                buscarClientes.abrirBD();
                MySqlDataAdapter mysqlDataAdap = new MySqlDataAdapter(cmd);
                DataTable dtRecord = new DataTable();
                mysqlDataAdap.Fill(dtRecord);
                dataGridView1.DataSource = dtRecord;
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.Columns[0].HeaderText = "DNI";
                dataGridView1.Columns[1].HeaderText = "APELLIDO";
                dataGridView1.Columns[2].HeaderText = "NOMBRE";
                dataGridView1.Columns[3].HeaderText = "EMAIL";
                dataGridView1.Columns[4].HeaderText = "TELEFONO";
                if (dataGridView1.RowCount == 0)
                {
                    MessageBox.Show("Sin datos para mostrar");
                }
            }

        }
        private void button1_buscar_Click(object sender, EventArgs e)
        {
            //Traer todos clientes por DNI al datagrid
        }
        private void button1_aceptar_Click(object sender, EventArgs e)//ACEPTAR
        {
            if (controlCargaDatos() == true)
            {
                capturarCampos(int.Parse(textBox_insert_update.Text));//0 para INSERT   -   1 para UPDATE                
                limpiarCampos();
                deshabilitarCampos();
            }
        }
        private void button_cancelar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
            deshabilitarCampos();
        }

        private void button_seguridad_Click(object sender, EventArgs e)
        {
            Ventana1Seguridad ventanaSeguridad = new Ventana1Seguridad();
            AddOwnedForm(ventanaSeguridad);
            ventanaSeguridad.ShowDialog();
        }
        private void button1_turnos_Click(object sender, EventArgs e)
        {
            Ventana1Turnos ventanaTurno = new Ventana1Turnos();
            AddOwnedForm(ventanaTurno);
            ventanaTurno.ShowDialog();
        }
        private void button_cobros_Click(object sender, EventArgs e)
        {
            Ventana1Cobros ventanaCobro = new Ventana1Cobros();
            AddOwnedForm(ventanaCobro);
            ventanaCobro.ShowDialog();
        }


        //METODOS
        public Boolean controlCargaDatos()
        {
            Boolean control = true;
            if (string.IsNullOrEmpty(textBox_nombre.Text))
            {
                MessageBox.Show("¡Error en Nombre! - Campo Vacio");
                control = false;
            }
            if (string.IsNullOrEmpty(textBox_apellido.Text))
            {
                MessageBox.Show("¡Error en Apellido! - Campo Vacio");
                control = false;
            }
            if (string.IsNullOrEmpty(textBox_dni.Text))
            {
                MessageBox.Show("¡Error en DNI! - Campo Vacio");
                control = false;
            }
            int temp = 0;
            if (!int.TryParse(textBox_dni.Text, out temp))
            {
                MessageBox.Show("¡Error en DNI! - Debe cargar un Numero");
                control = false;
            }
            if (string.IsNullOrEmpty(textBox_email.Text))
            {
                MessageBox.Show("¡Error en Email! - Campo Vacio");
                control = false;
            }
            return control;
        }
        public void limpiarCampos()
        {
            textBox_nombre.Text = "";
            textBox_apellido.Text = "";
            textBox_dni.Text = "";
            textBox_email.Text = "";
            textBox_nro.Text = "";
            textBox_telefono.Text = "";
        }
        public void capturarCampos(int InsertUpdate)
        {
            string bd_nombre = textBox_nombre.Text;
            string bd_apellido = textBox_apellido.Text;
            int bd_dni = int.Parse(textBox_dni.Text);
            string bd_email = textBox_email.Text;
            Int64 bd_telefono = Convert.ToInt64(textBox_telefono.Text);
            MessageBox.Show("El Cliente " + bd_nombre + " " + bd_apellido + " con DNI: " + bd_dni + " Ha sido Correctamente cargado");
            TablaCliente(bd_nombre, bd_apellido, bd_dni, bd_email, bd_telefono, InsertUpdate);
        }
        public void habilitarCampos()
        {
            textBox_nombre.Enabled = true;
            textBox_apellido.Enabled = true;
            textBox_dni.Enabled = true;
            textBox_email.Enabled = true;
            textBox_telefono.Enabled = true;
            button_aceptar.Enabled = true;
            button_cancelar.Enabled = true;
        }
        public void deshabilitarCampos()
        {
            textBox_nombre.Enabled = false;
            textBox_apellido.Enabled = false;
            textBox_dni.Enabled = false;
            textBox_email.Enabled = false;
            textBox_nro.Enabled = false;
            textBox_telefono.Enabled = false;
            button_aceptar.Enabled = false;
            button_cancelar.Enabled = false;
            button_aceptar.Visible = true;
        }
        public void TablaCliente(string nombre, string apellido, int dni, string email, Int64 telefono, int insUpd)
        {
            //AGREGAR CLIENTE A LA BASE DE DATOS - TABLA CLIENTE
            //datos de los campos guardados
            //tanto para agregar como para modificar            
            if (insUpd == 0)//INSERT
            {
                //MessageBox.Show("HACIENDO INSERT");
                ConexDB insCli = new ConexDB();
                string query = "INSERT INTO cliente (dni, apellido, nombre, email, telefono) VALUES (@dni, @apellido, @nombre, @email, @telefono)";
                using (MySqlCommand cmd = new MySqlCommand(query, insCli.conectarBD))
                {
                    try
                    {
                        cmd.Parameters.AddWithValue("@dni", Convert.ToInt32(textBox_dni.Text));
                        cmd.Parameters.AddWithValue("@apellido", textBox_apellido.Text);
                        cmd.Parameters.AddWithValue("@nombre", textBox_nombre.Text);
                        cmd.Parameters.AddWithValue("@email", textBox_email.Text);
                        cmd.Parameters.AddWithValue("@telefono", Convert.ToInt64(textBox_telefono.Text));
                        insCli.abrirBD();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Cliente Agregado!");
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("Error!\nNo se ha podido concretar la accion\nException: " + e.Message);
                    }
                    finally
                    {
                        insCli.cerrarBD();
                    }
                }
            }
            if (insUpd == 1)//UPDATE
            {
                MessageBox.Show("HACIENDO UPDATE");
                ConexDB log = new ConexDB();
                string query = "UPDATE Personas SET dni='" + dni + "', apellido='" + apellido + "', nombre='" + nombre + "', email='" + email + "', telefono='" + telefono +
                               "'WHERE dni='" + Convert.ToInt32(textBox_dni.Text) + "'";
                using (MySqlCommand cmd = new MySqlCommand(query, log.conectarBD))
                {
                    try
                    {
                        log.abrirBD();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Cliente Agregado!");
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

            }
            if ((insUpd != 0) && (insUpd != 1))
            {
                MessageBox.Show("ERROR SQL");
            }
        }
        public void eliminarCliente(int dni)
        {
            ConexDB log = new ConexDB();
            string query = "DELETE FROM Personas WHERE dni = @dni";
            using (MySqlCommand cmd = new MySqlCommand(query, log.conectarBD))
            {
                try
                {
                    log.abrirBD();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cliente Eliminado!");
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
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                dataGridView1.Rows[e.RowIndex].Selected = true;
                textBox_dni.Text = dataGridView1.SelectedCells[0].Value.ToString();
                textBox_apellido.Text = dataGridView1.SelectedCells[1].Value.ToString();
                textBox_nombre.Text = dataGridView1.SelectedCells[2].Value.ToString();
                textBox_email.Text = dataGridView1.SelectedCells[3].Value.ToString();
                textBox_telefono.Text = dataGridView1.SelectedCells[4].Value.ToString();

            }
        }
    }
}
