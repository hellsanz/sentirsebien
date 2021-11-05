
namespace SentirseBienApp
{
    partial class VentanaProfesional
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaProfesional));
            this.dataGridView_serviciosList = new System.Windows.Forms.DataGridView();
            this.button_Actualizar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6_bienvenido = new System.Windows.Forms.Label();
            this.label_nombreProfesional = new System.Windows.Forms.Label();
            this.radioButton1_realizado = new System.Windows.Forms.RadioButton();
            this.radioButton1_cancelado = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label_nombre = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label_apellido = new System.Windows.Forms.Label();
            this.label_servicio = new System.Windows.Forms.Label();
            this.label_fecha = new System.Windows.Forms.Label();
            this.label_hora = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.textBox_cliente_dni = new System.Windows.Forms.TextBox();
            this.dataGridView_tempApeNom = new System.Windows.Forms.DataGridView();
            this.button_resetear = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label_timer_fecha = new System.Windows.Forms.Label();
            this.label_timer_hora = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_serviciosList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_tempApeNom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_serviciosList
            // 
            this.dataGridView_serviciosList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView_serviciosList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_serviciosList.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_serviciosList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView_serviciosList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_serviciosList.Location = new System.Drawing.Point(13, 87);
            this.dataGridView_serviciosList.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView_serviciosList.Name = "dataGridView_serviciosList";
            this.dataGridView_serviciosList.Size = new System.Drawing.Size(689, 345);
            this.dataGridView_serviciosList.TabIndex = 66;
            this.dataGridView_serviciosList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // button_Actualizar
            // 
            this.button_Actualizar.Location = new System.Drawing.Point(719, 317);
            this.button_Actualizar.Margin = new System.Windows.Forms.Padding(4);
            this.button_Actualizar.Name = "button_Actualizar";
            this.button_Actualizar.Size = new System.Drawing.Size(163, 28);
            this.button_Actualizar.TabIndex = 3;
            this.button_Actualizar.Text = "Actualizar";
            this.button_Actualizar.UseVisualStyleBackColor = true;
            this.button_Actualizar.Click += new System.EventHandler(this.button_Actualizar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(745, 227);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 69;
            this.label2.Text = "Fecha:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(753, 255);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 70;
            this.label3.Text = "Hora:";
            // 
            // label6_bienvenido
            // 
            this.label6_bienvenido.AutoSize = true;
            this.label6_bienvenido.BackColor = System.Drawing.Color.Transparent;
            this.label6_bienvenido.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6_bienvenido.Location = new System.Drawing.Point(2, 5);
            this.label6_bienvenido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6_bienvenido.Name = "label6_bienvenido";
            this.label6_bienvenido.Size = new System.Drawing.Size(108, 19);
            this.label6_bienvenido.TabIndex = 73;
            this.label6_bienvenido.Text = "Bienvenido:";
            // 
            // label_nombreProfesional
            // 
            this.label_nombreProfesional.AutoSize = true;
            this.label_nombreProfesional.BackColor = System.Drawing.Color.Transparent;
            this.label_nombreProfesional.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nombreProfesional.Location = new System.Drawing.Point(108, 5);
            this.label_nombreProfesional.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_nombreProfesional.Name = "label_nombreProfesional";
            this.label_nombreProfesional.Size = new System.Drawing.Size(72, 19);
            this.label_nombreProfesional.TabIndex = 74;
            this.label_nombreProfesional.Text = "$nombre";
            // 
            // radioButton1_realizado
            // 
            this.radioButton1_realizado.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton1_realizado.AutoSize = true;
            this.radioButton1_realizado.Enabled = false;
            this.radioButton1_realizado.Location = new System.Drawing.Point(719, 282);
            this.radioButton1_realizado.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton1_realizado.Name = "radioButton1_realizado";
            this.radioButton1_realizado.Size = new System.Drawing.Size(81, 27);
            this.radioButton1_realizado.TabIndex = 1;
            this.radioButton1_realizado.TabStop = true;
            this.radioButton1_realizado.Text = "Realizado";
            this.radioButton1_realizado.UseVisualStyleBackColor = true;
            this.radioButton1_realizado.CheckedChanged += new System.EventHandler(this.radioButton1_realizado_CheckedChanged);
            // 
            // radioButton1_cancelado
            // 
            this.radioButton1_cancelado.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton1_cancelado.AutoSize = true;
            this.radioButton1_cancelado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.radioButton1_cancelado.Enabled = false;
            this.radioButton1_cancelado.Location = new System.Drawing.Point(797, 282);
            this.radioButton1_cancelado.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton1_cancelado.Name = "radioButton1_cancelado";
            this.radioButton1_cancelado.Size = new System.Drawing.Size(85, 27);
            this.radioButton1_cancelado.TabIndex = 2;
            this.radioButton1_cancelado.TabStop = true;
            this.radioButton1_cancelado.Text = "Cancelado";
            this.radioButton1_cancelado.UseVisualStyleBackColor = true;
            this.radioButton1_cancelado.CheckedChanged += new System.EventHandler(this.radioButton1_cancelado_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(734, 172);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 16);
            this.label10.TabIndex = 71;
            this.label10.Text = "Nombre:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(734, 199);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 16);
            this.label11.TabIndex = 72;
            this.label11.Text = "Servicio:";
            // 
            // label_nombre
            // 
            this.label_nombre.AutoSize = true;
            this.label_nombre.Location = new System.Drawing.Point(800, 172);
            this.label_nombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_nombre.Name = "label_nombre";
            this.label_nombre.Size = new System.Drawing.Size(13, 17);
            this.label_nombre.TabIndex = 78;
            this.label_nombre.Text = "-";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(734, 144);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 16);
            this.label13.TabIndex = 79;
            this.label13.Text = "Apellido:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(725, 90);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 16);
            this.label14.TabIndex = 80;
            this.label14.Text = "DNI:";
            // 
            // label_apellido
            // 
            this.label_apellido.AutoSize = true;
            this.label_apellido.Location = new System.Drawing.Point(800, 144);
            this.label_apellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_apellido.Name = "label_apellido";
            this.label_apellido.Size = new System.Drawing.Size(13, 17);
            this.label_apellido.TabIndex = 81;
            this.label_apellido.Text = "-";
            // 
            // label_servicio
            // 
            this.label_servicio.AutoSize = true;
            this.label_servicio.Location = new System.Drawing.Point(800, 199);
            this.label_servicio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_servicio.Name = "label_servicio";
            this.label_servicio.Size = new System.Drawing.Size(13, 17);
            this.label_servicio.TabIndex = 83;
            this.label_servicio.Text = "-";
            // 
            // label_fecha
            // 
            this.label_fecha.AutoSize = true;
            this.label_fecha.Location = new System.Drawing.Point(800, 227);
            this.label_fecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_fecha.Name = "label_fecha";
            this.label_fecha.Size = new System.Drawing.Size(13, 17);
            this.label_fecha.TabIndex = 84;
            this.label_fecha.Text = "-";
            // 
            // label_hora
            // 
            this.label_hora.AutoSize = true;
            this.label_hora.Location = new System.Drawing.Point(800, 255);
            this.label_hora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_hora.Name = "label_hora";
            this.label_hora.Size = new System.Drawing.Size(13, 17);
            this.label_hora.TabIndex = 85;
            this.label_hora.Text = "-";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(731, 118);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(138, 18);
            this.label20.TabIndex = 86;
            this.label20.Text = "DATOS CLIENTE";
            // 
            // textBox_cliente_dni
            // 
            this.textBox_cliente_dni.Location = new System.Drawing.Point(758, 87);
            this.textBox_cliente_dni.Name = "textBox_cliente_dni";
            this.textBox_cliente_dni.Size = new System.Drawing.Size(125, 23);
            this.textBox_cliente_dni.TabIndex = 88;
            // 
            // dataGridView_tempApeNom
            // 
            this.dataGridView_tempApeNom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView_tempApeNom.Enabled = false;
            this.dataGridView_tempApeNom.Location = new System.Drawing.Point(907, 9);
            this.dataGridView_tempApeNom.Name = "dataGridView_tempApeNom";
            this.dataGridView_tempApeNom.ReadOnly = true;
            this.dataGridView_tempApeNom.Size = new System.Drawing.Size(240, 150);
            this.dataGridView_tempApeNom.TabIndex = 89;
            this.dataGridView_tempApeNom.Visible = false;
            // 
            // button_resetear
            // 
            this.button_resetear.Location = new System.Drawing.Point(719, 353);
            this.button_resetear.Margin = new System.Windows.Forms.Padding(4);
            this.button_resetear.Name = "button_resetear";
            this.button_resetear.Size = new System.Drawing.Size(163, 28);
            this.button_resetear.TabIndex = 90;
            this.button_resetear.Text = "Resetear";
            this.button_resetear.UseVisualStyleBackColor = true;
            this.button_resetear.Click += new System.EventHandler(this.button_Cancelar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(719, 404);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 28);
            this.button1.TabIndex = 91;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(191)))), ((int)(((byte)(186)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-4, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(905, 436);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 87;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label_timer_fecha
            // 
            this.label_timer_fecha.AutoSize = true;
            this.label_timer_fecha.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_timer_fecha.Location = new System.Drawing.Point(751, 16);
            this.label_timer_fecha.Name = "label_timer_fecha";
            this.label_timer_fecha.Size = new System.Drawing.Size(114, 23);
            this.label_timer_fecha.TabIndex = 92;
            this.label_timer_fecha.Text = "20/06/2021";
            // 
            // label_timer_hora
            // 
            this.label_timer_hora.AutoSize = true;
            this.label_timer_hora.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_timer_hora.Location = new System.Drawing.Point(765, 49);
            this.label_timer_hora.Name = "label_timer_hora";
            this.label_timer_hora.Size = new System.Drawing.Size(86, 23);
            this.label_timer_hora.TabIndex = 93;
            this.label_timer_hora.Text = "17:20:56";
            // 
            // VentanaProfesional
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(207)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(895, 445);
            this.Controls.Add(this.label_timer_hora);
            this.Controls.Add(this.label_timer_fecha);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_resetear);
            this.Controls.Add(this.dataGridView_tempApeNom);
            this.Controls.Add(this.textBox_cliente_dni);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label_hora);
            this.Controls.Add(this.label_fecha);
            this.Controls.Add(this.label_servicio);
            this.Controls.Add(this.label_apellido);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label_nombre);
            this.Controls.Add(this.radioButton1_cancelado);
            this.Controls.Add(this.radioButton1_realizado);
            this.Controls.Add(this.label_nombreProfesional);
            this.Controls.Add(this.label6_bienvenido);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_Actualizar);
            this.Controls.Add(this.dataGridView_serviciosList);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "VentanaProfesional";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profesional";
            this.Load += new System.EventHandler(this.VentanaProfesional_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_serviciosList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_tempApeNom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView_serviciosList;
        private System.Windows.Forms.Button button_Actualizar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6_bienvenido;
        private System.Windows.Forms.Label label_nombreProfesional;
        private System.Windows.Forms.RadioButton radioButton1_realizado;
        private System.Windows.Forms.RadioButton radioButton1_cancelado;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label_nombre;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label_apellido;
        private System.Windows.Forms.Label label_servicio;
        private System.Windows.Forms.Label label_fecha;
        private System.Windows.Forms.Label label_hora;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox textBox_cliente_dni;
        private System.Windows.Forms.DataGridView dataGridView_tempApeNom;
        private System.Windows.Forms.Button button_resetear;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label_timer_fecha;
        private System.Windows.Forms.Label label_timer_hora;
    }
}