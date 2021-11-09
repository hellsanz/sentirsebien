
namespace SentirseBienApp
{
    partial class Ventana1Cobros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ventana1Cobros));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_actualizar = new System.Windows.Forms.Button();
            this.button_cerrar = new System.Windows.Forms.Button();
            this.dateTimePicker1desde = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1hasta = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.button_imprimir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1_dniCliente = new System.Windows.Forms.TextBox();
            this.button_buscar_dni = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(514, 215);
            this.dataGridView1.TabIndex = 23;
            // 
            // button_actualizar
            // 
            this.button_actualizar.BackColor = System.Drawing.Color.White;
            this.button_actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_actualizar.Location = new System.Drawing.Point(1, 247);
            this.button_actualizar.Name = "button_actualizar";
            this.button_actualizar.Size = new System.Drawing.Size(75, 23);
            this.button_actualizar.TabIndex = 43;
            this.button_actualizar.Text = "actualizar";
            this.button_actualizar.UseVisualStyleBackColor = false;
            this.button_actualizar.Click += new System.EventHandler(this.button_actualizar_Click);
            // 
            // button_cerrar
            // 
            this.button_cerrar.BackColor = System.Drawing.Color.White;
            this.button_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_cerrar.Location = new System.Drawing.Point(440, 247);
            this.button_cerrar.Name = "button_cerrar";
            this.button_cerrar.Size = new System.Drawing.Size(75, 23);
            this.button_cerrar.TabIndex = 44;
            this.button_cerrar.Text = "Cerrar";
            this.button_cerrar.UseVisualStyleBackColor = false;
            this.button_cerrar.Click += new System.EventHandler(this.button_cerrar_Click);
            // 
            // dateTimePicker1desde
            // 
            this.dateTimePicker1desde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1desde.Location = new System.Drawing.Point(1, 4);
            this.dateTimePicker1desde.Name = "dateTimePicker1desde";
            this.dateTimePicker1desde.Size = new System.Drawing.Size(86, 20);
            this.dateTimePicker1desde.TabIndex = 46;
            this.dateTimePicker1desde.Value = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            // 
            // dateTimePicker1hasta
            // 
            this.dateTimePicker1hasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1hasta.Location = new System.Drawing.Point(137, 4);
            this.dateTimePicker1hasta.Name = "dateTimePicker1hasta";
            this.dateTimePicker1hasta.Size = new System.Drawing.Size(86, 20);
            this.dateTimePicker1hasta.TabIndex = 47;
            this.dateTimePicker1hasta.Value = new System.DateTime(2021, 12, 31, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(90, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 49;
            this.label2.Text = "Hasta";
            // 
            // button_imprimir
            // 
            this.button_imprimir.BackColor = System.Drawing.Color.White;
            this.button_imprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_imprimir.Location = new System.Drawing.Point(82, 247);
            this.button_imprimir.Name = "button_imprimir";
            this.button_imprimir.Size = new System.Drawing.Size(75, 23);
            this.button_imprimir.TabIndex = 50;
            this.button_imprimir.Text = "Imprimir";
            this.button_imprimir.UseVisualStyleBackColor = false;
            this.button_imprimir.Click += new System.EventHandler(this.button_imprimir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-3, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(525, 299);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 51;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1_dniCliente
            // 
            this.textBox1_dniCliente.Location = new System.Drawing.Point(341, 4);
            this.textBox1_dniCliente.Name = "textBox1_dniCliente";
            this.textBox1_dniCliente.Size = new System.Drawing.Size(100, 20);
            this.textBox1_dniCliente.TabIndex = 52;
            // 
            // button_buscar_dni
            // 
            this.button_buscar_dni.BackColor = System.Drawing.Color.White;
            this.button_buscar_dni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_buscar_dni.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_buscar_dni.Location = new System.Drawing.Point(447, 3);
            this.button_buscar_dni.Name = "button_buscar_dni";
            this.button_buscar_dni.Size = new System.Drawing.Size(68, 21);
            this.button_buscar_dni.TabIndex = 76;
            this.button_buscar_dni.Text = "Buscar";
            this.button_buscar_dni.UseVisualStyleBackColor = false;
            this.button_buscar_dni.Click += new System.EventHandler(this.button_buscar_dni_Click);
            // 
            // Ventana1Cobros
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(207)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(517, 273);
            this.Controls.Add(this.button_buscar_dni);
            this.Controls.Add(this.textBox1_dniCliente);
            this.Controls.Add(this.button_imprimir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1hasta);
            this.Controls.Add(this.dateTimePicker1desde);
            this.Controls.Add(this.button_cerrar);
            this.Controls.Add(this.button_actualizar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Ventana1Cobros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Historial de Cobros";
            this.Load += new System.EventHandler(this.Ventana1Cobros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_actualizar;
        private System.Windows.Forms.Button button_cerrar;
        private System.Windows.Forms.DateTimePicker dateTimePicker1desde;
        private System.Windows.Forms.DateTimePicker dateTimePicker1hasta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_imprimir;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1_dniCliente;
        private System.Windows.Forms.Button button_buscar_dni;
    }
}