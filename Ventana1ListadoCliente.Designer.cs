
namespace SentirseBienApp
{
    partial class Ventana1ListadoCliente
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dateTimePicker_desde = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_hasta = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.button_aceptar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(661, 262);
            this.dataGridView1.TabIndex = 0;
            // 
            // dateTimePicker_desde
            // 
            this.dateTimePicker_desde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_desde.Location = new System.Drawing.Point(1, 5);
            this.dateTimePicker_desde.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker_desde.Name = "dateTimePicker_desde";
            this.dateTimePicker_desde.Size = new System.Drawing.Size(85, 20);
            this.dateTimePicker_desde.TabIndex = 1;
            this.dateTimePicker_desde.Value = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            // 
            // dateTimePicker_hasta
            // 
            this.dateTimePicker_hasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_hasta.Location = new System.Drawing.Point(144, 5);
            this.dateTimePicker_hasta.MinDate = new System.DateTime(2024, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker_hasta.Name = "dateTimePicker_hasta";
            this.dateTimePicker_hasta.Size = new System.Drawing.Size(85, 20);
            this.dateTimePicker_hasta.TabIndex = 2;
            this.dateTimePicker_hasta.Value = new System.DateTime(2024, 1, 1, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(92, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "hasta";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 60000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // button_aceptar
            // 
            this.button_aceptar.BackColor = System.Drawing.Color.White;
            this.button_aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_aceptar.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_aceptar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button_aceptar.Location = new System.Drawing.Point(562, 2);
            this.button_aceptar.Name = "button_aceptar";
            this.button_aceptar.Size = new System.Drawing.Size(100, 23);
            this.button_aceptar.TabIndex = 8;
            this.button_aceptar.Text = "Actualizar";
            this.button_aceptar.UseVisualStyleBackColor = false;
            this.button_aceptar.Click += new System.EventHandler(this.button_aceptar_Click);
            // 
            // Ventana1ListadoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(663, 290);
            this.Controls.Add(this.button_aceptar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker_hasta);
            this.Controls.Add(this.dateTimePicker_desde);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Ventana1ListadoCliente";
            this.Text = "Clientes Sin Atender";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTimePicker_desde;
        private System.Windows.Forms.DateTimePicker dateTimePicker_hasta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button button_aceptar;
    }
}