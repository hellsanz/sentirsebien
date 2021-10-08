
namespace SentirseBienApp
{
    partial class VentanaSecretario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaSecretario));
            this.dataGridView_serviciosList = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox_formapago = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_monto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_cobrar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_busqueda = new System.Windows.Forms.TextBox();
            this.label_nombreProfesional = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label_cliente_fecha = new System.Windows.Forms.Label();
            this.label_cliente_servicio = new System.Windows.Forms.Label();
            this.label_cliente_dni = new System.Windows.Forms.Label();
            this.label_cliente_apellido = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label_cliente_nombre = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_buscar = new System.Windows.Forms.Button();
            this.textBox_dniS = new System.Windows.Forms.TextBox();
            this.textBox_nombreS = new System.Windows.Forms.TextBox();
            this.textBox_apellidoS = new System.Windows.Forms.TextBox();
            this.textBox_servicioS = new System.Windows.Forms.TextBox();
            this.textBox_costoS = new System.Windows.Forms.TextBox();
            this.textBox_fechaS = new System.Windows.Forms.TextBox();
            this.textBox_atendidoS = new System.Windows.Forms.TextBox();
            this.textBox_quiencobraS = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_serviciosList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_serviciosList
            // 
            this.dataGridView_serviciosList.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_serviciosList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView_serviciosList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView_serviciosList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_serviciosList.Location = new System.Drawing.Point(15, 114);
            this.dataGridView_serviciosList.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView_serviciosList.Name = "dataGridView_serviciosList";
            this.dataGridView_serviciosList.Size = new System.Drawing.Size(450, 202);
            this.dataGridView_serviciosList.TabIndex = 67;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(296, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 13);
            this.label6.TabIndex = 68;
            this.label6.Text = "Listado de Turnos";
            // 
            // comboBox_formapago
            // 
            this.comboBox_formapago.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox_formapago.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_formapago.FormattingEnabled = true;
            this.comboBox_formapago.Items.AddRange(new object[] {
            "Credito",
            "Debito"});
            this.comboBox_formapago.Location = new System.Drawing.Point(15, 341);
            this.comboBox_formapago.Name = "comboBox_formapago";
            this.comboBox_formapago.Size = new System.Drawing.Size(126, 21);
            this.comboBox_formapago.TabIndex = 69;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 325);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 70;
            this.label1.Text = "Forma de Pago";
            // 
            // textBox_monto
            // 
            this.textBox_monto.Enabled = false;
            this.textBox_monto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_monto.Location = new System.Drawing.Point(147, 341);
            this.textBox_monto.Name = "textBox_monto";
            this.textBox_monto.Size = new System.Drawing.Size(102, 21);
            this.textBox_monto.TabIndex = 71;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(149, 325);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 72;
            this.label2.Text = "Monto";
            // 
            // button_cobrar
            // 
            this.button_cobrar.BackColor = System.Drawing.Color.White;
            this.button_cobrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_cobrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cobrar.Location = new System.Drawing.Point(255, 340);
            this.button_cobrar.Name = "button_cobrar";
            this.button_cobrar.Size = new System.Drawing.Size(68, 24);
            this.button_cobrar.TabIndex = 75;
            this.button_cobrar.Text = "Cobrar";
            this.button_cobrar.UseVisualStyleBackColor = false;
            this.button_cobrar.Click += new System.EventHandler(this.button_cobrar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 78;
            this.label4.Text = "DNI Cliente";
            // 
            // textBox_busqueda
            // 
            this.textBox_busqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_busqueda.Location = new System.Drawing.Point(15, 90);
            this.textBox_busqueda.Name = "textBox_busqueda";
            this.textBox_busqueda.ShortcutsEnabled = false;
            this.textBox_busqueda.Size = new System.Drawing.Size(121, 20);
            this.textBox_busqueda.TabIndex = 77;
            // 
            // label_nombreProfesional
            // 
            this.label_nombreProfesional.AutoSize = true;
            this.label_nombreProfesional.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nombreProfesional.Location = new System.Drawing.Point(123, 9);
            this.label_nombreProfesional.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_nombreProfesional.Name = "label_nombreProfesional";
            this.label_nombreProfesional.Size = new System.Drawing.Size(67, 19);
            this.label_nombreProfesional.TabIndex = 83;
            this.label_nombreProfesional.Text = "$nombre";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 9);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 19);
            this.label7.TabIndex = 82;
            this.label7.Text = "Cuenta Activa:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-33, -348);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1268, 876);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 84;
            this.pictureBox1.TabStop = false;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(489, 114);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(110, 18);
            this.label20.TabIndex = 97;
            this.label20.Text = "Datos Cliente";
            // 
            // label_cliente_fecha
            // 
            this.label_cliente_fecha.AutoSize = true;
            this.label_cliente_fecha.Location = new System.Drawing.Point(549, 287);
            this.label_cliente_fecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_cliente_fecha.Name = "label_cliente_fecha";
            this.label_cliente_fecha.Size = new System.Drawing.Size(40, 13);
            this.label_cliente_fecha.TabIndex = 96;
            this.label_cliente_fecha.Text = "$fecha";
            // 
            // label_cliente_servicio
            // 
            this.label_cliente_servicio.AutoSize = true;
            this.label_cliente_servicio.Location = new System.Drawing.Point(549, 253);
            this.label_cliente_servicio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_cliente_servicio.Name = "label_cliente_servicio";
            this.label_cliente_servicio.Size = new System.Drawing.Size(49, 13);
            this.label_cliente_servicio.TabIndex = 95;
            this.label_cliente_servicio.Text = "$servicio";
            // 
            // label_cliente_dni
            // 
            this.label_cliente_dni.AutoSize = true;
            this.label_cliente_dni.Location = new System.Drawing.Point(549, 145);
            this.label_cliente_dni.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_cliente_dni.Name = "label_cliente_dni";
            this.label_cliente_dni.Size = new System.Drawing.Size(28, 13);
            this.label_cliente_dni.TabIndex = 94;
            this.label_cliente_dni.Text = "$nro";
            // 
            // label_cliente_apellido
            // 
            this.label_cliente_apellido.AutoSize = true;
            this.label_cliente_apellido.Location = new System.Drawing.Point(549, 179);
            this.label_cliente_apellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_cliente_apellido.Name = "label_cliente_apellido";
            this.label_cliente_apellido.Size = new System.Drawing.Size(49, 13);
            this.label_cliente_apellido.TabIndex = 93;
            this.label_cliente_apellido.Text = "$apellido";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(489, 145);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(29, 13);
            this.label14.TabIndex = 92;
            this.label14.Text = "DNI:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(489, 179);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 13);
            this.label13.TabIndex = 91;
            this.label13.Text = "Apellido:";
            // 
            // label_cliente_nombre
            // 
            this.label_cliente_nombre.AutoSize = true;
            this.label_cliente_nombre.Location = new System.Drawing.Point(549, 216);
            this.label_cliente_nombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_cliente_nombre.Name = "label_cliente_nombre";
            this.label_cliente_nombre.Size = new System.Drawing.Size(48, 13);
            this.label_cliente_nombre.TabIndex = 90;
            this.label_cliente_nombre.Text = "$nombre";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(489, 253);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 13);
            this.label11.TabIndex = 89;
            this.label11.Text = "Servicio:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(489, 216);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 88;
            this.label10.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(489, 287);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 87;
            this.label3.Text = "Fecha:";
            // 
            // button_buscar
            // 
            this.button_buscar.BackColor = System.Drawing.Color.White;
            this.button_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_buscar.Location = new System.Drawing.Point(142, 89);
            this.button_buscar.Name = "button_buscar";
            this.button_buscar.Size = new System.Drawing.Size(56, 21);
            this.button_buscar.TabIndex = 98;
            this.button_buscar.Text = "Buscar";
            this.button_buscar.UseVisualStyleBackColor = false;
            this.button_buscar.Click += new System.EventHandler(this.button_buscar_Click);
            // 
            // textBox_dniS
            // 
            this.textBox_dniS.Location = new System.Drawing.Point(127, 546);
            this.textBox_dniS.Name = "textBox_dniS";
            this.textBox_dniS.Size = new System.Drawing.Size(100, 20);
            this.textBox_dniS.TabIndex = 99;
            this.textBox_dniS.Text = "dni";
            // 
            // textBox_nombreS
            // 
            this.textBox_nombreS.Location = new System.Drawing.Point(127, 573);
            this.textBox_nombreS.Name = "textBox_nombreS";
            this.textBox_nombreS.Size = new System.Drawing.Size(100, 20);
            this.textBox_nombreS.TabIndex = 100;
            this.textBox_nombreS.Text = "nombre";
            // 
            // textBox_apellidoS
            // 
            this.textBox_apellidoS.Location = new System.Drawing.Point(127, 600);
            this.textBox_apellidoS.Name = "textBox_apellidoS";
            this.textBox_apellidoS.Size = new System.Drawing.Size(100, 20);
            this.textBox_apellidoS.TabIndex = 101;
            this.textBox_apellidoS.Text = "apellido";
            // 
            // textBox_servicioS
            // 
            this.textBox_servicioS.Location = new System.Drawing.Point(246, 545);
            this.textBox_servicioS.Name = "textBox_servicioS";
            this.textBox_servicioS.Size = new System.Drawing.Size(100, 20);
            this.textBox_servicioS.TabIndex = 102;
            this.textBox_servicioS.Text = "servicio";
            // 
            // textBox_costoS
            // 
            this.textBox_costoS.Location = new System.Drawing.Point(246, 572);
            this.textBox_costoS.Name = "textBox_costoS";
            this.textBox_costoS.Size = new System.Drawing.Size(100, 20);
            this.textBox_costoS.TabIndex = 103;
            this.textBox_costoS.Text = "costo";
            // 
            // textBox_fechaS
            // 
            this.textBox_fechaS.Location = new System.Drawing.Point(246, 599);
            this.textBox_fechaS.Name = "textBox_fechaS";
            this.textBox_fechaS.Size = new System.Drawing.Size(100, 20);
            this.textBox_fechaS.TabIndex = 104;
            this.textBox_fechaS.Text = "fecha";
            // 
            // textBox_atendidoS
            // 
            this.textBox_atendidoS.Location = new System.Drawing.Point(376, 546);
            this.textBox_atendidoS.Name = "textBox_atendidoS";
            this.textBox_atendidoS.Size = new System.Drawing.Size(100, 20);
            this.textBox_atendidoS.TabIndex = 105;
            this.textBox_atendidoS.Text = "atendio";
            // 
            // textBox_quiencobraS
            // 
            this.textBox_quiencobraS.Location = new System.Drawing.Point(376, 572);
            this.textBox_quiencobraS.Name = "textBox_quiencobraS";
            this.textBox_quiencobraS.Size = new System.Drawing.Size(100, 20);
            this.textBox_quiencobraS.TabIndex = 106;
            this.textBox_quiencobraS.Text = "cobro";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(363, 340);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 24);
            this.button1.TabIndex = 107;
            this.button1.Text = "Imprimir Ticket";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // VentanaSecretario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(212)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(1015, 658);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_quiencobraS);
            this.Controls.Add(this.textBox_atendidoS);
            this.Controls.Add(this.textBox_fechaS);
            this.Controls.Add(this.textBox_costoS);
            this.Controls.Add(this.textBox_servicioS);
            this.Controls.Add(this.textBox_apellidoS);
            this.Controls.Add(this.textBox_nombreS);
            this.Controls.Add(this.textBox_dniS);
            this.Controls.Add(this.button_buscar);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label_cliente_fecha);
            this.Controls.Add(this.label_cliente_servicio);
            this.Controls.Add(this.label_cliente_dni);
            this.Controls.Add(this.label_cliente_apellido);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label_cliente_nombre);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_nombreProfesional);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_busqueda);
            this.Controls.Add(this.button_cobrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_monto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_formapago);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView_serviciosList);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "VentanaSecretario";
            this.Text = "Pagos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_serviciosList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_serviciosList;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox_formapago;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_monto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_cobrar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_busqueda;
        private System.Windows.Forms.Label label_nombreProfesional;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label_cliente_fecha;
        private System.Windows.Forms.Label label_cliente_servicio;
        private System.Windows.Forms.Label label_cliente_dni;
        private System.Windows.Forms.Label label_cliente_apellido;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label_cliente_nombre;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_buscar;
        private System.Windows.Forms.TextBox textBox_dniS;
        private System.Windows.Forms.TextBox textBox_nombreS;
        private System.Windows.Forms.TextBox textBox_apellidoS;
        private System.Windows.Forms.TextBox textBox_servicioS;
        private System.Windows.Forms.TextBox textBox_costoS;
        private System.Windows.Forms.TextBox textBox_fechaS;
        private System.Windows.Forms.TextBox textBox_atendidoS;
        private System.Windows.Forms.TextBox textBox_quiencobraS;
        private System.Windows.Forms.Button button1;
    }
}