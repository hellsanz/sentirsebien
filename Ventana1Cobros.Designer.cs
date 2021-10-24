
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_actualizar = new System.Windows.Forms.Button();
            this.button_cerrar = new System.Windows.Forms.Button();
            this.dateTimePicker1desde = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1hasta = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_imprimir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(469, 215);
            this.dataGridView1.TabIndex = 23;
            // 
            // button_actualizar
            // 
            this.button_actualizar.Enabled = false;
            this.button_actualizar.Location = new System.Drawing.Point(12, 287);
            this.button_actualizar.Name = "button_actualizar";
            this.button_actualizar.Size = new System.Drawing.Size(75, 23);
            this.button_actualizar.TabIndex = 43;
            this.button_actualizar.Text = "actualizar";
            this.button_actualizar.UseVisualStyleBackColor = true;
            this.button_actualizar.Click += new System.EventHandler(this.button_actualizar_Click);
            // 
            // button_cerrar
            // 
            this.button_cerrar.Enabled = false;
            this.button_cerrar.Location = new System.Drawing.Point(406, 287);
            this.button_cerrar.Name = "button_cerrar";
            this.button_cerrar.Size = new System.Drawing.Size(75, 23);
            this.button_cerrar.TabIndex = 44;
            this.button_cerrar.Text = "Cerrar";
            this.button_cerrar.UseVisualStyleBackColor = true;
            this.button_cerrar.Click += new System.EventHandler(this.button_cerrar_Click);
            // 
            // dateTimePicker1desde
            // 
            this.dateTimePicker1desde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1desde.Location = new System.Drawing.Point(53, 12);
            this.dateTimePicker1desde.Name = "dateTimePicker1desde";
            this.dateTimePicker1desde.Size = new System.Drawing.Size(86, 20);
            this.dateTimePicker1desde.TabIndex = 46;
            this.dateTimePicker1desde.Value = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            // 
            // dateTimePicker1hasta
            // 
            this.dateTimePicker1hasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1hasta.Location = new System.Drawing.Point(53, 40);
            this.dateTimePicker1hasta.Name = "dateTimePicker1hasta";
            this.dateTimePicker1hasta.Size = new System.Drawing.Size(86, 20);
            this.dateTimePicker1hasta.TabIndex = 47;
            this.dateTimePicker1hasta.Value = new System.DateTime(2021, 12, 31, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 48;
            this.label1.Text = "Desde";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 49;
            this.label2.Text = "Hasta";
            // 
            // button_imprimir
            // 
            this.button_imprimir.Enabled = false;
            this.button_imprimir.Location = new System.Drawing.Point(93, 287);
            this.button_imprimir.Name = "button_imprimir";
            this.button_imprimir.Size = new System.Drawing.Size(75, 23);
            this.button_imprimir.TabIndex = 50;
            this.button_imprimir.Text = "Imprimir";
            this.button_imprimir.UseVisualStyleBackColor = true;
            this.button_imprimir.Click += new System.EventHandler(this.button_imprimir_Click);
            // 
            // Ventana1Cobros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(495, 319);
            this.Controls.Add(this.button_imprimir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1hasta);
            this.Controls.Add(this.dateTimePicker1desde);
            this.Controls.Add(this.button_cerrar);
            this.Controls.Add(this.button_actualizar);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Ventana1Cobros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Historial de Cobros";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_actualizar;
        private System.Windows.Forms.Button button_cerrar;
        private System.Windows.Forms.DateTimePicker dateTimePicker1desde;
        private System.Windows.Forms.DateTimePicker dateTimePicker1hasta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_imprimir;
    }
}