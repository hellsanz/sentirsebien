using iText.Kernel.Colors;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas.Draw;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SentirseBienApp
{
    public partial class Ventana1Cobros : Form
    {
        public Ventana1Cobros()
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
            buscarTurnos(Convert.ToDateTime(dateTimePicker1desde.Text), Convert.ToDateTime(dateTimePicker1hasta.Text));
        }

        private void button_imprimir_Click(object sender, EventArgs e)
        {
            //EJECUTAR IMPRESION
            imprimirInformePagos();
        }
        public void imprimirInformePagos()
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
                    Paragraph header = new Paragraph("LISTADO DE PAGOS")
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
                    Paragraph paragraph1 = new Paragraph("Listado de Cobros del Spa");
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
                    Table table = new Table(6, false);
                    Cell cID = new Cell(1, 1)
                        .SetBackgroundColor(ColorConstants.GREEN)
                        .Add(new Paragraph("ID"));
                    Cell cDNI = new Cell(1, 1)
                        .SetBackgroundColor(ColorConstants.GREEN)
                        .Add(new Paragraph("DNI"));
                    Cell cMONTO = new Cell(1, 1)
                        .SetBackgroundColor(ColorConstants.GREEN)
                        .Add(new Paragraph("MONTO"));
                    Cell cNROCOM = new Cell(1, 1)
                        .SetBackgroundColor(ColorConstants.GREEN)
                        .Add(new Paragraph("NRO COMPROBANTE"));
                    Cell cTipoPago = new Cell(1, 1)
                        .SetBackgroundColor(ColorConstants.GREEN)
                        .Add(new Paragraph("FORMA DE PAGO"));
                    Cell cNroFactura = new Cell(1, 1)
                        .SetBackgroundColor(ColorConstants.GREEN)
                        .Add(new Paragraph("NRO DE FACTURA"));
                    table.AddCell(cID);
                    table.AddCell(cDNI);
                    table.AddCell(cMONTO);
                    table.AddCell(cNROCOM);
                    table.AddCell(cTipoPago);
                    table.AddCell(cNroFactura);
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
            registroDeActividad("Imprimir Pagos");
        }
        public void registroDeActividad(string msg)
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
                    cmd.Parameters.AddWithValue("@msg", msg);
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
        public void buscarTurnos(DateTime desde, DateTime hasta)
        {
            //traer todos los turnos cargados en la BD
            dataGridView1.DataSource = null;
            ConexDB buscarClientes = new ConexDB();
            string query = "SELECT * from pagos";//; WHERE fecha between @desde and @hasta";
            //Agregar Fecha de Emision de Factura en BBDD
            using (MySqlCommand cmd = new MySqlCommand(query, buscarClientes.conectarBD))
            {
                //cmd.Parameters.AddWithValue("@desde", desde);
                //cmd.Parameters.AddWithValue("@hasta", hasta);
                buscarClientes.abrirBD();
                MySqlDataAdapter mysqlDataAdap = new MySqlDataAdapter(cmd);
                DataTable dtRecord = new DataTable();
                mysqlDataAdap.Fill(dtRecord);
                dataGridView1.DataSource = dtRecord;
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.Columns[0].HeaderText = "ID";
                dataGridView1.Columns[1].HeaderText = "DNI";
                dataGridView1.Columns[2].HeaderText = "Monto";
                dataGridView1.Columns[3].HeaderText = "Comprobante";
                dataGridView1.Columns[4].HeaderText = "Forma de Pago";
                dataGridView1.Columns[5].HeaderText = "Nro. Factura";
                //dataGridView1.Columns[5].Visible = false;
                if (dataGridView1.RowCount == 0)
                {
                    MessageBox.Show("Sin datos para mostrar");//no encuentra turnos de ese DNI                    
                }
            }
        }
        public void buscarTurnosClientePorDNI(int dni)
        {
            //traer todos los turnos cargados en la BD
            dataGridView1.DataSource = null;
            ConexDB buscarClientes = new ConexDB();
            string query = "SELECT * from pagos WHERE dni = @dni";//; WHERE fecha between @desde and @hasta";
            //Agregar Fecha de Emision de Factura en BBDD
            using (MySqlCommand cmd = new MySqlCommand(query, buscarClientes.conectarBD))
            {
                //cmd.Parameters.AddWithValue("@desde", desde);
                //cmd.Parameters.AddWithValue("@hasta", hasta);
                cmd.Parameters.AddWithValue("@dni", dni);
                buscarClientes.abrirBD();
                MySqlDataAdapter mysqlDataAdap = new MySqlDataAdapter(cmd);
                DataTable dtRecord = new DataTable();
                mysqlDataAdap.Fill(dtRecord);
                dataGridView1.DataSource = dtRecord;
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.Columns[0].HeaderText = "ID";
                dataGridView1.Columns[1].HeaderText = "DNI";
                dataGridView1.Columns[2].HeaderText = "Monto";
                dataGridView1.Columns[3].HeaderText = "Comprobante";
                dataGridView1.Columns[4].HeaderText = "Forma de Pago";
                dataGridView1.Columns[5].HeaderText = "Nro. Factura";
                //dataGridView1.Columns[5].Visible = false;
                if (dataGridView1.RowCount == 0)
                {
                    MessageBox.Show("Sin datos para mostrar");//no encuentra turnos de ese DNI                    
                }
            }
        }

        private void button_buscar_dni_Click(object sender, EventArgs e)
        {
            if (controlCargaDatos() == true)
            {
                buscarTurnosClientePorDNI(Convert.ToInt32(textBox1_dniCliente.Text));
            }     
        }

        public Boolean controlCargaDatos()
        {
            Boolean control = true;
            int temp = 0;
            if (string.IsNullOrEmpty(textBox1_dniCliente.Text))
            {
                MessageBox.Show("¡Error en DNI! - Campo Vacio");
                control = false;
            }
            else
            {
                if (!int.TryParse(textBox1_dniCliente.Text, out temp))
                {
                    MessageBox.Show("¡Error en DNI! - Debe cargar un Numero");
                    textBox1_dniCliente.Text = "";
                    control = false;
                }
            }
            return control;
        }
    }
}
