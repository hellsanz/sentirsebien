
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 313);
            this.dataGridView1.TabIndex = 0;
            // 
            // label_hora
            // 
            this.label_hora.AutoSize = true;
            this.label_hora.Font = new System.Drawing.Font("Microsoft Tai Le", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_hora.Location = new System.Drawing.Point(508, 9);
            this.label_hora.Name = "label_hora";
            this.label_hora.Size = new System.Drawing.Size(117, 34);
            this.label_hora.TabIndex = 1;
            this.label_hora.Text = "12:15:09";
            // 
            // label_fecha
            // 
            this.label_fecha.AutoSize = true;
            this.label_fecha.Font = new System.Drawing.Font("Microsoft Tai Le", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_fecha.Location = new System.Drawing.Point(631, 9);
            this.label_fecha.Name = "label_fecha";
            this.label_fecha.Size = new System.Drawing.Size(157, 34);
            this.label_fecha.TabIndex = 2;
            this.label_fecha.Text = "19/12/2021";
            // 
            // timer_fechahora
            // 
            this.timer_fechahora.Enabled = true;
            this.timer_fechahora.Tick += new System.EventHandler(this.timer_fechahora_Tick);
            // 
            // Ventana1Seguridad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}