using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using iText.Kernel.Pdf.Canvas.Draw;
using System.Diagnostics;
using iText.Kernel.Colors;


namespace SentirseBienApp
{
    public partial class VentanaAdmin : Form
    {
        private Timer tiempo;
        public VentanaAdmin()
        {
            tiempo = new Timer();
            tiempo.Tick += new EventHandler(timer_fechahora_Tick);
            InitializeComponent();
            tiempo.Enabled = true;
        }

        private void button1_Agregar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
            habilitarCampos();
            textBox_dni.Enabled = true;
            button1_modificar.Enabled = false;
            textBox_insert_update.Text = "0";
        }
        private void button1_modificar_Click(object sender, EventArgs e)
        {
            //Traer info de la dataGridView
            //variables hardcodeadas
            button_cancelar.Enabled = true;
            if (dataGridView1.SelectedCells.Count > 0)
            {                
                textBox_insert_update.Text = "1";
                habilitarCampos();                
            }
            else
            {
                MessageBox.Show("Debe seleccionar un Cliente para Modificar!");
            }            
        }
        private void button1_eliminar_Click(object sender, EventArgs e)
        {
            button1_modificar.Enabled = false;
            button_cancelar.Enabled = true;
            if (dataGridView1.SelectedCells.Count > 0)
            {                
                textBox_dni.Text = dataGridView1.SelectedCells[0].Value.ToString();
                textBox_apellido.Text = dataGridView1.SelectedCells[1].Value.ToString();
                textBox_nombre.Text = dataGridView1.SelectedCells[2].Value.ToString();
                textBox_email.Text = dataGridView1.SelectedCells[3].Value.ToString();
                textBox_telefono.Text = dataGridView1.SelectedCells[4].Value.ToString();                
                eliminarCliente(int.Parse(textBox_dni.Text));
            }
            else
            {
                MessageBox.Show("Debe seleccionar un Cliente para Eliminar!");
            }            
        }
        private void button1_actualizar_Click(object sender, EventArgs e)
        {
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
            string actividad = "Actualizo Lista Cliente";
            registroDeActividad(actividad);
        }
        private void button1_buscar_Click(object sender, EventArgs e)
        {
            //Traer todos clientes por DNI al datagrid
            dataGridView1.DataSource = null;
            ConexDB buscarClientes = new ConexDB();
            string query = "SELECT * from cliente WHERE dni = @dni";
            using (MySqlCommand cmd = new MySqlCommand(query, buscarClientes.conectarBD))
            {
                cmd.Parameters.AddWithValue("@dni",Convert.ToInt32(textBox_buscar.Text));
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
            string actividad = "Busco un Cliente DNI:"+textBox_dni.Text;
            registroDeActividad(actividad);
        }
        private void button1_aceptar_Click(object sender, EventArgs e)
        {
            button1_modificar.Enabled = false;
            button1_eliminar.Enabled = false;
            button1_Agregar.Enabled = true;
            if (controlCargaDatos() == true)
            {
                capturarCampos(int.Parse(textBox_insert_update.Text));//0 para INSERT   -   1 para UPDATE                
                limpiarCampos();
                deshabilitarCampos();
            }
        }
        private void button_cancelar_Click(object sender, EventArgs e)
        {
            button1_modificar.Enabled = false;
            button1_eliminar.Enabled = false;
            button1_Agregar.Enabled = true;
            limpiarCampos();
            deshabilitarCampos();
        }
        private void btPDF_Click(object sender, EventArgs e)
        {
            try
            {
                //CREAR PDF
                SaveFileDialog svfd = new SaveFileDialog();
                svfd.Filter = "PDF document (*.pdf)|*.pdf";
                svfd.ShowDialog();
                if (svfd.FileName != "")
                {
                    PdfWriter writer = new PdfWriter(svfd.FileName);
                    PdfDocument pdf = new PdfDocument(writer);
                    Document document = new Document(pdf);

                    //ENCABEZADO
                    Paragraph header = new Paragraph("LISTADO DE CLIENTES")
                       .SetTextAlignment(TextAlignment.CENTER)
                       .SetFontSize(20);

                    //ESPACIO DE SEPARACION
                    Paragraph newline = new Paragraph(new Text("\n"));

                    document.Add(newline);
                    document.Add(header);

                    //SUB ENCABEZADO
                    Paragraph subheader = new Paragraph("SPA SENTIRSE BIEN")
                    .SetTextAlignment(TextAlignment.CENTER)
                    .SetFontSize(15);
                    document.Add(subheader);

                    //LINEA DE SEPARACION
                    LineSeparator ls = new LineSeparator(new SolidLine());
                    document.Add(ls);

                    //PARRAFO 1
                    Paragraph paragraph1 = new Paragraph("Listado de Clientes del Spa");
                    document.Add(paragraph1);

                    //IMAGEN DEL SPA
                    //Image img = new Image(ImageDataFactory
                    //.Create(@"..\..\image.jpg"))
                    //.SetTextAlignment(TextAlignment.CENTER);
                    //document.Add(img);
                    //NUMERO DE PAGINAS 
                    int n = pdf.GetNumberOfPages();
                    for (int i = 1; i <= n; i++)
                    {
                        document.ShowTextAligned(new Paragraph(String
                           .Format("Pag." + i + " of " + n)),
                            559, 806, i, TextAlignment.RIGHT,
                            VerticalAlignment.TOP, 0);
                    }
                    //TABLA DE DATOS
                    Table table = new Table(5, false);
                    Cell cdni = new Cell(1, 1)
                        .SetBackgroundColor(ColorConstants.GREEN)
                        .Add(new Paragraph("DNI"));
                    Cell cnom = new Cell(1, 1)
                        .SetBackgroundColor(ColorConstants.GREEN)
                        .Add(new Paragraph("NOMBRE"));
                    Cell cape = new Cell(1, 1)
                        .SetBackgroundColor(ColorConstants.GREEN)
                        .Add(new Paragraph("APELLIDO"));
                    Cell cema = new Cell(1, 1)
                        .SetBackgroundColor(ColorConstants.GREEN)
                        .Add(new Paragraph("EMAIL"));
                    Cell ctel = new Cell(1, 1)
                        .SetBackgroundColor(ColorConstants.GREEN)
                        .Add(new Paragraph("TELEFONO"));
                    table.AddCell(cdni);
                    table.AddCell(cnom);
                    table.AddCell(cape);
                    table.AddCell(cema);
                    table.AddCell(ctel);
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {

                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            table.AddCell(cell.Value.ToString());
                        }
                    }
                    document.Add(table);
                    document.Close();
                    DialogResult dialogResult = MessageBox.Show("Guardado en " + svfd.FileName + " \nDesea abrirlo?", "PDF Generado Exitosamente!", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        //MessageBox.Show("Metodo abrir pdf!");
                        Process.Start(svfd.FileName);
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            string actividad = "Imprimir PDF";
            registroDeActividad(actividad);
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
        public Boolean existenciaCliente(int dni)
        {
            ConexDB log = new ConexDB();
            string query = "SELECT EXISTS(SELECT 1 FROM cliente WHERE dni = @dni)";
            using (MySqlCommand cmd = new MySqlCommand(query, log.conectarBD))
            {
                log.abrirBD();
                cmd.Parameters.AddWithValue("@dni", textBox_dni.Text);
                int r;
                try
                {
                    r = Convert.ToInt32(cmd.ExecuteScalar());
                    if (r == 1)
                    {                        
                        return false;
                    }
                    else
                    {                        
                        return true;
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Error de Coneccion con la BBDD");
                    return false;
                    throw;
                }
                finally
                {
                    log.cerrarBD();
                }
            }
        }
        public void limpiarCampos()
        {
            textBox_nombre.Text = "";
            textBox_apellido.Text = "";
            textBox_dni.Text = "";
            textBox_email.Text = "";            
            textBox_telefono.Text = "";
        }
        public void capturarCampos(int InsertUpdate)
        {
            string bd_nombre = textBox_nombre.Text;
            string bd_apellido = textBox_apellido.Text;
            int bd_dni = int.Parse(textBox_dni.Text);
            string bd_email = textBox_email.Text;
            Int64 bd_telefono = Convert.ToInt64(textBox_telefono.Text);            
            TablaCliente(bd_nombre, bd_apellido, bd_dni, bd_email, bd_telefono, InsertUpdate);
        }
        public void habilitarCampos()
        {
            textBox_nombre.Enabled = true;
            textBox_apellido.Enabled = true;            
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
            textBox_telefono.Enabled = false;
            button_aceptar.Enabled = false;
            button_cancelar.Enabled = false;            
        }
        public void TablaCliente(string nombre, string apellido, int dni, string email, Int64 telefono, int insUpd)
        {
            //AGREGAR CLIENTE A LA BASE DE DATOS - TABLA CLIENTE
            //datos de los campos guardados
            //tanto para agregar como para modificar            
            if (insUpd == 0)//INSERT
            {               
                if (existenciaCliente(dni) == true)
                {
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
                            string actividad = "agrego Cliente:" + apellido + " " + nombre + " DNI:" + dni;
                            registroDeActividad(actividad);
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
                else
                {
                    MessageBox.Show("¡ERROR!\n¡El DNI ya Existe!");
                    textBox_dni.Text = "";                    
                }
            }
            if (insUpd == 1)//UPDATE
            {                
                ConexDB log = new ConexDB();               
                string query = "UPDATE cliente SET apellido = @apellido, nombre = @nombre, email = @email, telefono = @telefono WHERE dni = @dni";
                using (MySqlCommand cmd = new MySqlCommand(query, log.conectarBD))
                {
                    try
                    {
                        cmd.Parameters.AddWithValue("@dni", dni);
                        cmd.Parameters.AddWithValue("@apellido", apellido);
                        cmd.Parameters.AddWithValue("@nombre", nombre);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@telefono", telefono);
                        log.abrirBD();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Cliente Modificado!");
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("Error!\nNo se ha podido concretar la accion\nException: " + e.Message);
                    }
                    finally
                    {
                        log.cerrarBD();
                        button1_modificar.Enabled = false;
                    }
                }
                string actividad = "Modifico Cliente:" + apellido + " " + nombre + " DNI:" + dni;
                registroDeActividad(actividad);
            }
            if ((insUpd != 0) && (insUpd != 1))
            {
                MessageBox.Show("ERROR SQL");
            }
        }
        public void eliminarCliente(int dni)
        {
            ConexDB log = new ConexDB();
            string query = "DELETE FROM cliente WHERE dni = @dni";
            using (MySqlCommand cmd = new MySqlCommand(query, log.conectarBD))
            {
                try
                {
                    string message = "Esta seguro que se desea Eliminar al Cliente?";
                    string title = "Alerta!";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(message, title, buttons);
                    if (result == DialogResult.Yes)
                    {
                        cmd.Parameters.AddWithValue("@dni",dni);
                        log.abrirBD();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Cliente Eliminado!");
                    }                                       
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
            string actividad = "Elimino Cliente: "+dni;
            registroDeActividad(actividad);
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
                button1_modificar.Enabled = true;
                button1_eliminar.Enabled = true;
                button1_Agregar.Enabled = false;
            }
        }

        private void button_cerrarVentana_Click(object sender, EventArgs e)
        {
            string actividad = "Salio";
            registroDeActividad(actividad);
            this.Close();
        }

        private void timer_fechahora_Tick(object sender, EventArgs e)
        {
            DateTime dia = DateTime.Now;
            label_fecha.Text = dia.ToShortDateString();
            label_hora.Text = dia.ToLongTimeString();
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
                    cmd.Parameters.AddWithValue("@tipo", "Admin");
                    cmd.Parameters.AddWithValue("@msg", actividad);
                    insCli.abrirBD();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    MessageBox.Show("Error! Admin\nNo se ha podido concretar la accion\nException: " + e.Message +"\n"+e.StackTrace);
                }
                finally
                {
                    insCli.cerrarBD();
                }
            }
        }

        private void VentanaAdmin_Load(object sender, EventArgs e)
        {
            dataGridView1.RowHeadersVisible = false;
        }
    }
}
