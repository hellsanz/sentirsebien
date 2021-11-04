
namespace SentirseBienApp
{
    partial class Ventana1Seguridad
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
            this.label_hora = new System.Windows.Forms.Label();
            this.label_fecha = new System.Windows.Forms.Label();
            this.timer_fechahora = new System.Windows.Forms.Timer(this.components);
            this.button_cerrarVentana = new System.Windows.Forms.Button();
            this.timer_actualizar_lista = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.Black;
            this.dataGridView1.Location = new System.Drawing.Point(4, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 323);
            this.dataGridView1.TabIndex = 0;
            // 
            // label_hora
            // 
            this.label_hora.AutoSize = true;
            this.label_hora.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_hora.Location = new System.Drawing.Point(406, 15);
            this.label_hora.Name = "label_hora";
            this.label_hora.Size = new System.Drawing.Size(125, 34);
            this.label_hora.TabIndex = 1;
            this.label_hora.Text = "12:15:09";
            // 
            // label_fecha
            // 
            this.label_fecha.AutoSize = true;
            this.label_fecha.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_fecha.Location = new System.Drawing.Point(529, 15);
            this.label_fecha.Name = "label_fecha";
            this.label_fecha.Size = new System.Drawing.Size(167, 34);
            this.label_fecha.TabIndex = 2;
            this.label_fecha.Text = "19/12/2021";
            // 
            // timer_fechahora
            // 
            this.timer_fechahora.Enabled = true;
            this.timer_fechahora.Tick += new System.EventHandler(this.timer_fechahora_Tick);
            // 
            // button_cerrarVentana
            // 
            this.button_cerrarVentana.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_cerrarVentana.Cursor = System.Windows.Forms.Cursors.Default;
            this.button_cerrarVentana.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowText;
            this.button_cerrarVentana.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_cerrarVentana.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cerrarVentana.Location = new System.Drawing.Point(4, 9);
            this.button_cerrarVentana.Name = "button_cerrarVentana";
            this.button_cerrarVentana.Size = new System.Drawing.Size(153, 40);
            this.button_cerrarVentana.TabIndex = 54;
            this.button_cerrarVentana.Text = "Salir";
            this.button_cerrarVentana.UseVisualStyleBackColor = false;
            this.button_cerrarVentana.Click += new System.EventHandler(this.button_cerrarVentana_Click);
            // 
            // timer_actualizar_lista
            // 
            this.timer_actualizar_lista.Enabled = true;
            this.timer_actualizar_lista.Interval = 5000;
            this.timer_actualizar_lista.Tick += new System.EventHandler(this.timer_actualizar_lista_Tick);
            // 
            // Ventana1Seguridad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(784, 385);
            this.Controls.Add(this.button_cerrarVentana);
            this.Controls.Add(this.label_fecha);
            this.Controls.Add(this.label_hora);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Ventana1Seguridad";
            this.Text = "Ventana1Seguridad";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label_hora;
        private System.Windows.Forms.Label label_fecha;
        private System.Windows.Forms.Timer timer_fechahora;
        private System.Windows.Forms.Button button_cerrarVentana;
        private System.Windows.Forms.Timer timer_actualizar_lista;
    }
}