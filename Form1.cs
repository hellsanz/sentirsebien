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
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using iText.Kernel.Pdf.Canvas.Draw;
using System.Diagnostics;
using iText.Kernel.Colors;
using System.Net.Mail;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Net.Security;
using System.IO;

namespace SentirseBienApp
{
    public partial class Form1 : Form
    {        
        public Form1()
        {
            Icon ic = global::SentirseBienApp.Properties.Resources.este;
            this.Icon = ic;
            InitializeComponent();
            textBox_contador.Text = "2";            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loggeo(int.Parse(textBox_contador.Text));      
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void loggeo(int intentos)
        {
            //traer los datos del usuario buscado por nombre            
            if (intentos == 0)//control de cantidad de intentos
            {
                textBox1_usuario.Enabled = false;
                textBox1_password.Enabled = false;
                button1.Enabled = false;
                registroDeIngreso("Anonimo", "Ingreso Fallido!");
                MessageBox.Show("¡Sistema Bloqueado!\nNumero de Intentos: 0");
            }
            Boolean control = true;
            control = controlDatos();
            if (control == true)
            {
                String usuario = textBox1_usuario.Text;  
                if (existeUsuario() == true)
                {    
                    if (consultaAcceso() == 0)
                    {
                        textBox1_usuario.Text = "";
                        textBox1_password.Text = "";
                        MessageBox.Show("¡Sistema Abierto!\nUsuario: " + usuario + "\nAcceso: Administrador");                        
                        Transferencias.globalnombreUsuario = usuario;
                        usuario = "";                        
                        registroDeIngreso("Admin", "Ingresó");   
                        this.Visible = false;
                        llamarVentanaAdmin();
                        this.Visible = true;
                    }
                    if (consultaAcceso() == 1)
                    {
                        textBox1_usuario.Text = "";
                        textBox1_password.Text = "";
                        MessageBox.Show("¡Sistema Abierto!\nUsuario: " + usuario + "\nAcceso: Profesional");                        
                        Transferencias.globalnombreUsuario = usuario;
                        usuario = "";
                        registroDeIngreso("Profesional", "Ingresó");
                        this.Visible = false;
                        llamarVentanaProfesional();
                        this.Visible = true;
                    }
                    if (consultaAcceso() == 2)
                    {
                        textBox1_usuario.Text = "";
                        textBox1_password.Text = "";
                        MessageBox.Show("¡Sistema Abierto!\nUsuario: " + usuario + "\nAcceso: Secretaría");                        
                        Transferencias.globalnombreUsuario = usuario;
                        usuario = "";
                        registroDeIngreso("Secretario", "Ingresó");
                        this.Visible = false;
                        llamarVentanaSecretario();
                        this.Visible = true;                        
                    }
                    if ((consultaAcceso() > 2) || (consultaAcceso() < 0))
                    {
                        textBox1_usuario.Text = "";
                        textBox1_password.Text = "";
                        MessageBox.Show("¡ERROR DE ACCESO!\n Consulte con el Administrador");
                        usuario = "";                        
                    }                    
                }
                else
                {
                    textBox1_usuario.Text = "";
                    textBox1_password.Text = "";                    
                    usuario = "";                    
                }
            }
        }
        //Llamadas a Ventanas de Usuario
        public void llamarVentanaAdmin()
        {
            VentanaAdmin ventanaAdmin = new VentanaAdmin();
            AddOwnedForm(ventanaAdmin);
            ventanaAdmin.MdiParent = this.MdiParent;
            ventanaAdmin.ShowDialog(this);
        }
        public void llamarVentanaProfesional()
        {
            VentanaProfesional ventanaProfesional = new VentanaProfesional();
            AddOwnedForm(ventanaProfesional);
            ventanaProfesional.MdiParent = this.MdiParent;
            ventanaProfesional.ShowDialog(this);
        }
        public void llamarVentanaSecretario()
        {
            VentanaSecretario ventanaSecretario = new VentanaSecretario();
            AddOwnedForm(ventanaSecretario);
            ventanaSecretario.MdiParent = this.MdiParent;
            ventanaSecretario.ShowDialog(this);
        }
        
        //METODOS de Control y de registro       
        public Boolean controlDatos()
        {
            Boolean control = true;
            if (string.IsNullOrEmpty(textBox1_usuario.Text))
            {
                MessageBox.Show("¡Error! debe cargar Su nombre de usuario");
                control = false;
            }
            if (string.IsNullOrEmpty(textBox1_password.Text))
            {
                MessageBox.Show("¡Error! debe cargar su Contraseña");
                control = false;
            }
            return control;
        }
        public Boolean existeUsuario()
        {
            int intentos = 0;
            intentos = int.Parse(textBox_contador.Text);            
            string acc = "";
            //Conectando Azure MySql
            ConexDB log = new ConexDB();
            string query = "SELECT EXISTS(SELECT 1 FROM empleado WHERE usuario = @nombre and password = @pass)";
            using (MySqlCommand cmd = new MySqlCommand(query, log.conectarBD))
            {
                log.abrirBD();
                cmd.Parameters.AddWithValue("@nombre", textBox1_usuario.Text);
                cmd.Parameters.AddWithValue("@pass", Convert.ToInt32(textBox1_password.Text));
                int r;
                try
                {
                    r = Convert.ToInt32(cmd.ExecuteScalar());
                    if (r == 1)
                    {                        
                        textBox_accesoS.Text = acc;
                        return true;                        
                    }
                    else
                    {                        
                        MessageBox.Show("¡Datos incorrectos!\nIntentos Restantes: " + intentos);
                        intentos--;
                        textBox_contador.Text = Convert.ToString(intentos);
                        return false;                        
                    }                    
                }
                catch (Exception e)
                {                    
                    MessageBox.Show("Error de Coneccion con la BBDD");                    
                    throw;                    
                }
                finally
                {
                    log.cerrarBD();
                }
            }
        }
        public int consultaAcceso()
        {
            //necesito que me traigas el acceso del usuario de BD
            //SI o SI haceme esto
            //si necesitas algun parametro hace una variable hardcodeada y te la conecto despues
            //0 ADMIN - 1 SECRETARIO - 2 USUARIO
            int acc;
            //Conectando Azure MySql
            ConexDB log = new ConexDB();
            string query = "SELECT permisos from empleado where usuario = @nombre";
            using (MySqlCommand cmd = new MySqlCommand(query, log.conectarBD))
            {
                cmd.Parameters.AddWithValue("@nombre", textBox1_usuario.Text);
                try
                {
                    log.abrirBD();
                    acc = Convert.ToInt32(cmd.ExecuteScalar());
                    log.cerrarBD();
                    return acc;
                }
                catch (Exception)
                {
                    MessageBox.Show("Error de Conexion con la BBDD");
                    log.cerrarBD();
                    return -1;  
                }                
            }
        }
        public void registroDeIngreso(string tipo, string actividad)
        {
            ConexDB insCli = new ConexDB();
            string query = "INSERT INTO seguridad (usuario, fecha, hora, tipo, msg ) VALUES (@usuario, @fecha, @hora, @tipo, @msg)";
            using (MySqlCommand cmd = new MySqlCommand(query, insCli.conectarBD))
            {
                try
                {                    //aaaa/mm/dd
                    cmd.Parameters.AddWithValue("@usuario", Transferencias.globalnombreUsuario);
                    cmd.Parameters.AddWithValue("@fecha", DateTime.Now.ToShortDateString());
                    cmd.Parameters.AddWithValue("@hora", DateTime.Now.ToShortTimeString());
                    cmd.Parameters.AddWithValue("@tipo", tipo);
                    cmd.Parameters.AddWithValue("@msg", actividad);
                    insCli.abrirBD();
                    cmd.ExecuteNonQuery();                    
                }
                catch (Exception e)
                {
                    MessageBox.Show("Error Login!\nNo se ha podido concretar la accion\n\nException:\n" + e.Message + "\n\nLugar:\n" + e.StackTrace);
                }
                finally
                {
                    insCli.cerrarBD();
                }
            }
        }

        private void generarFactura()
        {

            //TRAIGO UN CLIENTE Y VERIFICO CANTIDAD DE FACTURAS IMPAGAS

            int dniCliente = 0;
            int cantFacturas = 0;
            ConexDB genFac = new ConexDB();
            string query1 = "select * from (select pagos.dni, count(*) as fac from pagos where nroFactura is null group by dni) as fac limit 1";
            using (MySqlCommand cmd = new MySqlCommand(query1, genFac.conectarBD))
            {
                //cmd.Parameters.AddWithValue();
                genFac.abrirBD();
                try
                {

                    MySqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        dniCliente = Convert.ToInt32(dr["dni"]);
                        cantFacturas = Convert.ToInt32(dr["fac"]);

                    }

                    MessageBox.Show("Funcion 1 OK: " + dniCliente.ToString() + " " + cantFacturas.ToString());
                    genFac.cerrarBD();

                }
                catch (Exception)
                {

                    MessageBox.Show("Error de Conexion con la BBDD // Generar Factura Error!");

                }
                finally
                {
                    genFac.cerrarBD();
                }
            }

            //TRAIGO DNI, NOMBRE, SERVICIO, COSTO DE CADA UNO Y FECHA
            if (dniCliente != 0)
            {

                ConexDB detallesFac = new ConexDB();
                string query2 = "select cliente.nombre, cliente.apellido, pagos.dni , turno.servicio, servicio.costo, turno.fecha from pagos inner join turno inner join servicio inner join cliente where (nroFactura is null) and (idPagos = turno.idTurno) and (servicio.nombre = turno.servicio) and (pagos.dni = cliente.dni) and (pagos.dni = @dniCliente)";

                using (MySqlCommand cmd = new MySqlCommand(query2, detallesFac.conectarBD))
                {

                    detallesFac.abrirBD();
                    try
                    {
                        cmd.Parameters.AddWithValue("@dniCliente", dniCliente);
                        MySqlDataAdapter mysqlDataAdap = new MySqlDataAdapter(cmd);
                        DataTable dtRecord = new DataTable();
                        mysqlDataAdap.Fill(dtRecord);
                        dtgw.DataSource = dtRecord;
                        MessageBox.Show("Funcion 2 OK! ");
                        detallesFac.cerrarBD();
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("Error de Conexion con la BBDD // Generar Factura Error!");

                    }
                    finally
                    {
                        detallesFac.cerrarBD();

                    }
                }
            }


            //TRAIGO EL MONTO TOTAL DE LA FACTURA
            if ((dtgw.RowCount != 0) && (dniCliente != 0))
            {
                int totalFac = 0;
                ConexDB montoFac = new ConexDB();
                string query2 = "select sum(pagos.monto) as Total from pagos where dni = @dniCliente and nroFactura is null";
                using (MySqlCommand cmd = new MySqlCommand(query2, montoFac.conectarBD))
                {

                    montoFac.abrirBD();
                    try
                    {
                        cmd.Parameters.AddWithValue("@dniCliente", dniCliente);

                        totalFac = Convert.ToInt32(cmd.ExecuteScalar());
                        MessageBox.Show("Funcion 3 OK! " + totalFac.ToString());
                        montoFac.cerrarBD();
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("Error de Conexion con la BBDD // Generar Factura Error!");

                    }
                    finally
                    {
                        montoFac.cerrarBD();

                    }
                }

                //GENERO LA FACTURA
                string numeroFactura = "";
                string nombFactura = "FAC";
                if ((dtgw.RowCount != 0) && (dniCliente != 0) && (totalFac != 0))
                {
                    Random r = new Random();
                    int nro = r.Next(000001, 999999);
                    numeroFactura = "0000" + nro.ToString();


                    try
                    {
                        //CREAR PDF

                        //SaveFileDialog svfd = new SaveFileDialog();
                        //svfd.Filter = "PDF document (*.pdf)|*.pdf";
                        //svfd.ShowDialog();

                        PdfWriter writer = new PdfWriter(@"E:\Carpetas\Documentos\" + nombFactura + numeroFactura + ".pdf");
                        PdfDocument pdf = new PdfDocument(writer);
                        Document document = new Document(pdf);

                        //ENCABEZADO
                        Paragraph header = new Paragraph("SPA SENTIRSE BIEN")
                           .SetTextAlignment(TextAlignment.CENTER)
                           .SetFontSize(18);

                        //ESPACIO DE SEPARACION
                        Paragraph newline = new Paragraph(new Text("\n"));

                        document.Add(newline);
                        document.Add(header);

                        //SUB ENCABEZADO
                        int rw = 0;
                        int cs = 0;
                        Paragraph subheader = new Paragraph("FACTURA B NRO: " + numeroFactura + "\n"
                                + "DNI: " + dniCliente.ToString() + "\n"
                                + "NOMBRE CLIENTE: " + dtgw.Rows[rw].Cells[cs].Value.ToString() + " " + dtgw.Rows[rw].Cells[cs + 1].Value.ToString())
                        .SetTextAlignment(TextAlignment.LEFT)
                        .SetFontSize(12);
                        document.Add(subheader);

                        //LINEA DE SEPARACION
                        LineSeparator ls = new LineSeparator(new SolidLine());
                        document.Add(ls);

                        //PARRAFO 1
                        Paragraph paragraph1 = new Paragraph("Detalle de los servicios facturados");
                        document.Add(paragraph1);

                        //IMAGEN DEL SPA
                        //Image img = new Image(ImageDataFactory
                        //.Create(@"..\..\image.jpg"))
                        //.SetTextAlignment(TextAlignment.CENTER);
                        //document.Add(img);
                        //NUMERO DE PAGINAS
                        //

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
                        Cell cnom = new Cell(1, 1)
                            .SetBackgroundColor(ColorConstants.GREEN)
                            .Add(new Paragraph("NOMBRE"));
                        Cell cape = new Cell(1, 1)
                            .SetBackgroundColor(ColorConstants.GREEN)
                            .Add(new Paragraph("APELLIDO"));
                        Cell cdni = new Cell(1, 1)
                            .SetBackgroundColor(ColorConstants.GREEN)
                            .Add(new Paragraph("DNI"));
                        Cell cser = new Cell(1, 1)
                            .SetBackgroundColor(ColorConstants.GREEN)
                            .Add(new Paragraph("SERVICIO"));
                        Cell cpre = new Cell(1, 1)
                            .SetBackgroundColor(ColorConstants.GREEN)
                            .Add(new Paragraph("PRECIO"));
                        Cell cfec = new Cell(1, 1)
                            .SetBackgroundColor(ColorConstants.GREEN)
                            .Add(new Paragraph("FECHA DE REALIZACION"));

                        table.AddCell(cnom);
                        table.AddCell(cape);
                        table.AddCell(cdni);
                        table.AddCell(cser);
                        table.AddCell(cpre);
                        table.AddCell(cfec);

                        foreach (DataGridViewRow row in dtgw.Rows)
                        {

                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                table.AddCell(cell.Value.ToString());
                            }
                        }

                        document.Add(table);

                        //ESPACIO DE SEPARACION
                        Paragraph space = new Paragraph(new Text("\n"));

                        document.Add(space);


                        //LINEA DE SEPARACION
                        LineSeparator ls1 = new LineSeparator(new SolidLine());
                        document.Add(ls);

                        //PARRAFO 1
                        Paragraph lineaMonto = new Paragraph("TOTAL ARS $:" + totalFac.ToString());
                        lineaMonto.SetFontSize(14);
                        document.Add(lineaMonto);
                        document.Close();

                        DialogResult dialogResult = MessageBox.Show("Guardado en " + @"E:\Carpetas\Documentos\" + nombFactura + numeroFactura + " \nDesea abrirlo?", "PDF Generado Exitosamente!", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            //MessageBox.Show("Metodo abrir pdf!");
                            Process.Start(@"E:\Carpetas\Documentos\" + nombFactura + numeroFactura + ".pdf");
                        }

                    }
                    catch (Exception err)
                    {
                        MessageBox.Show(err.Message);
                    }
                }


                //ENVIO POR EMAIL LA FACTURA
                try
                {
                    MailMessage correo = new MailMessage();
                    correo.From = new MailAddress("galileomanuel@gmail.com", "SPA SENTIRSE BIEN S.A", System.Text.Encoding.UTF8);//Correo de salida
                    correo.To.Add("manu92.boca@gmail.com"); //Correo destino?
                    correo.Subject = "Factura Nro " + numeroFactura.ToString(); ; //Asunto
                    correo.Body = "Le acercamos su factura de servicios. \nAtte. Spa Sentirse Bien S.A"; //Mensaje del correo
                    correo.IsBodyHtml = true;
                    correo.Priority = MailPriority.Normal;
                    correo.Attachments.Add(new Attachment(GetStreamFile(@"E:\Carpetas\Documentos\" + nombFactura + numeroFactura + ".pdf"), "fac", "application/pdf"));
                    SmtpClient smtp = new SmtpClient();
                    smtp.UseDefaultCredentials = false;
                    smtp.Host = "smtp.gmail.com"; //Host del servidor de correo
                    smtp.Port = 25; //Puerto de salida
                    smtp.Credentials = new System.Net.NetworkCredential("galileomanuel@gmail.com", "manu:2112");//Cuenta de correo
                    ServicePointManager.ServerCertificateValidationCallback = delegate (object s, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { return true; };
                    smtp.EnableSsl = true;//True si el servidor de correo permite ssl
                    smtp.Send(correo);
                    MessageBox.Show("Correo Enviado Con Exito!");
                }
                catch (Exception err)
                {
                    MessageBox.Show("Correo No Enviado: " + err.Message);
                }

                //INSERTO EL NUMERO DE FACTURA A LOS SERVICIOS CUYO NUM FAC IS NULL
                ConexDB iNroFac = new ConexDB();
                string qIns = "update pagos set nroFactura = @nroFac where nroFactura is null and dni = @dni";
                using (MySqlCommand cmd = new MySqlCommand(qIns, iNroFac.conectarBD))
                {
                    try
                    {
                        cmd.Parameters.AddWithValue("@nroFac", Convert.ToInt32(numeroFactura));
                        cmd.Parameters.AddWithValue("@dni", dniCliente);
                        iNroFac.abrirBD();
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Pagos Actualizado con Exito!");
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message);
                    }
                    finally
                    {
                        iNroFac.cerrarBD();
                    }
                }
            }


        }

        public System.IO.Stream GetStreamFile(string filePath)
        {
            using (System.IO.FileStream fileStream = File.OpenRead(filePath))
            {
                System.IO.MemoryStream memStream = new MemoryStream();
                memStream.SetLength(fileStream.Length);
                fileStream.Read(memStream.GetBuffer(), 0, (int)fileStream.Length);
                return memStream;
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            //generarFactura();
        }
    }
}
