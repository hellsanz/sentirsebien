
namespace SentirseBienApp
{
    partial class VentanaAdmin
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
        {            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaAdmin));
            this.button_cancelar = new System.Windows.Forms.Button();
            this.button_aceptar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_nombre = new System.Windows.Forms.TextBox();
            this.textBox_apellido = new System.Windows.Forms.TextBox();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.textBox_dni = new System.Windows.Forms.TextBox();
            this.button1_turnos = new System.Windows.Forms.Button();
            this.button1_actualizar = new System.Windows.Forms.Button();
            this.textBox_buscar = new System.Windows.Forms.TextBox();
            this.button1_eliminar = new System.Windows.Forms.Button();
            this.button1_modificar = new System.Windows.Forms.Button();
            this.button1_Agregar = new System.Windows.Forms.Button();
            this.button1_buscar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_telefono = new System.Windows.Forms.TextBox();
            this.button_cobros = new System.Windows.Forms.Button();
            this.button_seguridad = new System.Windows.Forms.Button();
            this.textBox_insert_update = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button_cerrarVentana = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_fecha = new System.Windows.Forms.Label();
            this.label_hora = new System.Windows.Forms.Label();
            this.timer_fechahora = new System.Windows.Forms.Timer(this.components);
            this.btPDF = new System.Windows.Forms.Button();
            this.button1_c_sinAtender = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_cancelar
            // 
            this.button_cancelar.BackColor = System.Drawing.Color.White;
            this.button_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_cancelar.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cancelar.Location = new System.Drawing.Point(674, 217);
            this.button_cancelar.Name = "button_cancelar";
            this.button_cancelar.Size = new System.Drawing.Size(98, 23);
            this.button_cancelar.TabIndex = 11;
            this.button_cancelar.Text = "Cancelar";
            this.button_cancelar.UseVisualStyleBackColor = false;
            this.button_cancelar.Click += new System.EventHandler(this.button_cancelar_Click);
            // 
            // button_aceptar
            // 
            this.button_aceptar.BackColor = System.Drawing.Color.White;
            this.button_aceptar.Enabled = false;
            this.button_aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_aceptar.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_aceptar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button_aceptar.Location = new System.Drawing.Point(559, 217);
            this.button_aceptar.Name = "button_aceptar";
            this.button_aceptar.Size = new System.Drawing.Size(100, 23);
            this.button_aceptar.TabIndex = 10;
            this.button_aceptar.Text = "Aceptar";
            this.button_aceptar.UseVisualStyleBackColor = false;
            this.button_aceptar.Click += new System.EventHandler(this.button1_aceptar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(671, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 40;
            this.label4.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(556, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Apellido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(556, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(556, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "DNI";
            // 
            // textBox_nombre
            // 
            this.textBox_nombre.Enabled = false;
            this.textBox_nombre.Location = new System.Drawing.Point(674, 138);
            this.textBox_nombre.Name = "textBox_nombre";
            this.textBox_nombre.Size = new System.Drawing.Size(98, 20);
            this.textBox_nombre.TabIndex = 8;
            // 
            // textBox_apellido
            // 
            this.textBox_apellido.Enabled = false;
            this.textBox_apellido.Location = new System.Drawing.Point(559, 138);
            this.textBox_apellido.Name = "textBox_apellido";
            this.textBox_apellido.Size = new System.Drawing.Size(100, 20);
            this.textBox_apellido.TabIndex = 7;
            // 
            // textBox_email
            // 
            this.textBox_email.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.textBox_email.Enabled = false;
            this.textBox_email.Location = new System.Drawing.Point(559, 179);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(213, 20);
            this.textBox_email.TabIndex = 9;
            // 
            // textBox_dni
            // 
            this.textBox_dni.Enabled = false;
            this.textBox_dni.Location = new System.Drawing.Point(559, 98);
            this.textBox_dni.Name = "textBox_dni";
            this.textBox_dni.Size = new System.Drawing.Size(100, 20);
            this.textBox_dni.TabIndex = 5;
            // 
            // button1_turnos
            // 
            this.button1_turnos.BackColor = System.Drawing.Color.White;
            this.button1_turnos.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1_turnos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1_turnos.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1_turnos.Location = new System.Drawing.Point(591, 280);
            this.button1_turnos.Name = "button1_turnos";
            this.button1_turnos.Size = new System.Drawing.Size(155, 23);
            this.button1_turnos.TabIndex = 12;
            this.button1_turnos.Text = "Turnos Sin Atender";
            this.button1_turnos.UseVisualStyleBackColor = false;
            this.button1_turnos.Click += new System.EventHandler(this.button1_turnos_Click);
            // 
            // button1_actualizar
            // 
            this.button1_actualizar.BackColor = System.Drawing.Color.White;
            this.button1_actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1_actualizar.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1_actualizar.Location = new System.Drawing.Point(5, 11);
            this.button1_actualizar.Name = "button1_actualizar";
            this.button1_actualizar.Size = new System.Drawing.Size(86, 23);
            this.button1_actualizar.TabIndex = 1;
            this.button1_actualizar.Text = "Actualizar";
            this.button1_actualizar.UseVisualStyleBackColor = false;
            this.button1_actualizar.Click += new System.EventHandler(this.button1_actualizar_Click);
            // 
            // textBox_buscar
            // 
            this.textBox_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_buscar.Location = new System.Drawing.Point(313, 11);
            this.textBox_buscar.MaxLength = 100000000;
            this.textBox_buscar.Name = "textBox_buscar";
            this.textBox_buscar.Size = new System.Drawing.Size(156, 23);
            this.textBox_buscar.TabIndex = 3;
            this.textBox_buscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button1_eliminar
            // 
            this.button1_eliminar.BackColor = System.Drawing.Color.White;
            this.button1_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1_eliminar.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1_eliminar.Location = new System.Drawing.Point(172, 423);
            this.button1_eliminar.Name = "button1_eliminar";
            this.button1_eliminar.Size = new System.Drawing.Size(75, 23);
            this.button1_eliminar.TabIndex = 17;
            this.button1_eliminar.Text = "Eliminar";
            this.button1_eliminar.UseVisualStyleBackColor = false;
            this.button1_eliminar.Click += new System.EventHandler(this.button1_eliminar_Click);
            // 
            // button1_modificar
            // 
            this.button1_modificar.BackColor = System.Drawing.Color.White;
            this.button1_modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1_modificar.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1_modificar.Location = new System.Drawing.Point(86, 423);
            this.button1_modificar.Name = "button1_modificar";
            this.button1_modificar.Size = new System.Drawing.Size(80, 23);
            this.button1_modificar.TabIndex = 16;
            this.button1_modificar.Text = "Modificar";
            this.button1_modificar.UseVisualStyleBackColor = false;
            this.button1_modificar.Click += new System.EventHandler(this.button1_modificar_Click);
            // 
            // button1_Agregar
            // 
            this.button1_Agregar.BackColor = System.Drawing.Color.White;
            this.button1_Agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1_Agregar.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1_Agregar.Location = new System.Drawing.Point(5, 423);
            this.button1_Agregar.Name = "button1_Agregar";
            this.button1_Agregar.Size = new System.Drawing.Size(75, 23);
            this.button1_Agregar.TabIndex = 15;
            this.button1_Agregar.Text = "Agregar";
            this.button1_Agregar.UseVisualStyleBackColor = false;
            this.button1_Agregar.Click += new System.EventHandler(this.button1_Agregar_Click);
            // 
            // button1_buscar
            // 
            this.button1_buscar.BackColor = System.Drawing.Color.White;
            this.button1_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1_buscar.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1_buscar.Location = new System.Drawing.Point(475, 11);
            this.button1_buscar.Name = "button1_buscar";
            this.button1_buscar.Size = new System.Drawing.Size(75, 23);
            this.button1_buscar.TabIndex = 4;
            this.button1_buscar.Text = "Buscar";
            this.button1_buscar.UseVisualStyleBackColor = false;
            this.button1_buscar.Click += new System.EventHandler(this.button1_buscar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(5, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(545, 387);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(671, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 46;
            this.label7.Text = "Telefono";
            // 
            // textBox_telefono
            // 
            this.textBox_telefono.Enabled = false;
            this.textBox_telefono.Location = new System.Drawing.Point(674, 98);
            this.textBox_telefono.Name = "textBox_telefono";
            this.textBox_telefono.Size = new System.Drawing.Size(98, 20);
            this.textBox_telefono.TabIndex = 6;
            // 
            // button_cobros
            // 
            this.button_cobros.BackColor = System.Drawing.Color.White;
            this.button_cobros.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_cobros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_cobros.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cobros.Location = new System.Drawing.Point(591, 309);
            this.button_cobros.Name = "button_cobros";
            this.button_cobros.Size = new System.Drawing.Size(155, 23);
            this.button_cobros.TabIndex = 13;
            this.button_cobros.Text = "Cobros";
            this.button_cobros.UseVisualStyleBackColor = false;
            this.button_cobros.Click += new System.EventHandler(this.button_cobros_Click);
            // 
            // button_seguridad
            // 
            this.button_seguridad.BackColor = System.Drawing.Color.White;
            this.button_seguridad.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_seguridad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_seguridad.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_seguridad.Location = new System.Drawing.Point(591, 338);
            this.button_seguridad.Name = "button_seguridad";
            this.button_seguridad.Size = new System.Drawing.Size(155, 23);
            this.button_seguridad.TabIndex = 14;
            this.button_seguridad.Text = "Seguridad";
            this.button_seguridad.UseVisualStyleBackColor = false;
            this.button_seguridad.Click += new System.EventHandler(this.button_seguridad_Click);
            // 
            // textBox_insert_update
            // 
            this.textBox_insert_update.Enabled = false;
            this.textBox_insert_update.Location = new System.Drawing.Point(5, 445);
            this.textBox_insert_update.Name = "textBox_insert_update";
            this.textBox_insert_update.Size = new System.Drawing.Size(43, 20);
            this.textBox_insert_update.TabIndex = 51;
            this.textBox_insert_update.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(317, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 52;
            this.label8.Text = "DNI";
            // 
            // button_cerrarVentana
            // 
            this.button_cerrarVentana.BackColor = System.Drawing.Color.White;
            this.button_cerrarVentana.Cursor = System.Windows.Forms.Cursors.Default;
            this.button_cerrarVentana.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowText;
            this.button_cerrarVentana.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_cerrarVentana.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cerrarVentana.Location = new System.Drawing.Point(591, 368);
            this.button_cerrarVentana.Name = "button_cerrarVentana";
            this.button_cerrarVentana.Size = new System.Drawing.Size(155, 54);
            this.button_cerrarVentana.TabIndex = 19;
            this.button_cerrarVentana.Text = "Salir";
            this.button_cerrarVentana.UseVisualStyleBackColor = false;
            this.button_cerrarVentana.Click += new System.EventHandler(this.button_cerrarVentana_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, -41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(786, 506);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 48;
            this.pictureBox1.TabStop = false;
            // 
            // label_fecha
            // 
            this.label_fecha.AutoSize = true;
            this.label_fecha.Font = new System.Drawing.Font("Microsoft Tai Le", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_fecha.Location = new System.Drawing.Point(589, 8);
            this.label_fecha.Name = "label_fecha";
            this.label_fecha.Size = new System.Drawing.Size(157, 34);
            this.label_fecha.TabIndex = 55;
            this.label_fecha.Text = "19/12/2021";
            // 
            // label_hora
            // 
            this.label_hora.AutoSize = true;
            this.label_hora.Font = new System.Drawing.Font("Microsoft Tai Le", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_hora.Location = new System.Drawing.Point(610, 42);
            this.label_hora.Name = "label_hora";
            this.label_hora.Size = new System.Drawing.Size(117, 34);
            this.label_hora.TabIndex = 54;
            this.label_hora.Text = "12:15:09";
            // 
            // timer_fechahora
            // 
            this.timer_fechahora.Enabled = true;
            this.timer_fechahora.Tick += new System.EventHandler(this.timer_fechahora_Tick);
            // 
            // btPDF
            // 
            this.btPDF.BackColor = System.Drawing.Color.White;
            this.btPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPDF.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPDF.Location = new System.Drawing.Point(97, 11);
            this.btPDF.Name = "btPDF";
            this.btPDF.Size = new System.Drawing.Size(86, 23);
            this.btPDF.TabIndex = 2;
            this.btPDF.Text = "Imprimir";
            this.btPDF.UseVisualStyleBackColor = false;
            this.btPDF.Click += new System.EventHandler(this.btPDF_Click);
            // 
            // button1_c_sinAtender
            // 
            this.button1_c_sinAtender.BackColor = System.Drawing.Color.White;
            this.button1_c_sinAtender.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1_c_sinAtender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1_c_sinAtender.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1_c_sinAtender.Location = new System.Drawing.Point(384, 423);
            this.button1_c_sinAtender.Name = "button1_c_sinAtender";
            this.button1_c_sinAtender.Size = new System.Drawing.Size(166, 23);
            this.button1_c_sinAtender.TabIndex = 18;
            this.button1_c_sinAtender.Text = "Clientes Sin Atender";
            this.button1_c_sinAtender.UseVisualStyleBackColor = false;
            this.button1_c_sinAtender.Click += new System.EventHandler(this.button1_c_sinAtender_Click);
            // 
            // VentanaAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(212)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(781, 450);
            this.Controls.Add(this.button1_c_sinAtender);
            this.Controls.Add(this.btPDF);
            this.Controls.Add(this.label_fecha);
            this.Controls.Add(this.label_hora);
            this.Controls.Add(this.button_cerrarVentana);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button_seguridad);
            this.Controls.Add(this.button_cobros);
            this.Controls.Add(this.textBox_telefono);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button_cancelar);
            this.Controls.Add(this.button_aceptar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_nombre);
            this.Controls.Add(this.textBox_apellido);
            this.Controls.Add(this.textBox_email);
            this.Controls.Add(this.textBox_dni);
            this.Controls.Add(this.button1_turnos);
            this.Controls.Add(this.button1_actualizar);
            this.Controls.Add(this.textBox_buscar);
            this.Controls.Add(this.button1_eliminar);
            this.Controls.Add(this.button1_modificar);
            this.Controls.Add(this.button1_Agregar);
            this.Controls.Add(this.button1_buscar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox_insert_update);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "VentanaAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Administración";
            this.Load += new System.EventHandler(this.VentanaAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_cancelar;
        private System.Windows.Forms.Button button_aceptar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_nombre;
        private System.Windows.Forms.TextBox textBox_apellido;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.TextBox textBox_dni;
        private System.Windows.Forms.Button button1_turnos;
        private System.Windows.Forms.Button button1_actualizar;
        private System.Windows.Forms.TextBox textBox_buscar;
        private System.Windows.Forms.Button button1_eliminar;
        private System.Windows.Forms.Button button1_modificar;
        private System.Windows.Forms.Button button1_Agregar;
        private System.Windows.Forms.Button button1_buscar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_telefono;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_cobros;
        private System.Windows.Forms.Button button_seguridad;
        private System.Windows.Forms.TextBox textBox_insert_update;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button_cerrarVentana;
        private System.Windows.Forms.Label label_fecha;
        private System.Windows.Forms.Label label_hora;
        private System.Windows.Forms.Timer timer_fechahora;
        private System.Windows.Forms.Button btPDF;
        private System.Windows.Forms.Button button1_c_sinAtender;
    }
}