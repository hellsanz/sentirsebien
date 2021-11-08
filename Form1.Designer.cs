
namespace SentirseBienApp
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1_usuario = new System.Windows.Forms.TextBox();
            this.textBox1_password = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBox_usuarioS = new System.Windows.Forms.TextBox();
            this.textBox_passwordS = new System.Windows.Forms.TextBox();
            this.textBox_accesoS = new System.Windows.Forms.TextBox();
            this.textBox_contador = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dtgw = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgw)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1_usuario
            // 
            resources.ApplyResources(this.textBox1_usuario, "textBox1_usuario");
            this.textBox1_usuario.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.textBox1_usuario.Name = "textBox1_usuario";
            // 
            // textBox1_password
            // 
            resources.ApplyResources(this.textBox1_password, "textBox1_password");
            this.textBox1_password.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.textBox1_password.Name = "textBox1_password";
            this.textBox1_password.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            resources.ApplyResources(this.button1, "button1");
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            resources.ApplyResources(this.button2, "button2");
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(220)))), ((int)(((byte)(250)))));
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(220)))), ((int)(((byte)(250)))));
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Name = "label2";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(220)))), ((int)(((byte)(250)))));
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // textBox_usuarioS
            // 
            resources.ApplyResources(this.textBox_usuarioS, "textBox_usuarioS");
            this.textBox_usuarioS.Name = "textBox_usuarioS";
            this.textBox_usuarioS.TabStop = false;
            // 
            // textBox_passwordS
            // 
            resources.ApplyResources(this.textBox_passwordS, "textBox_passwordS");
            this.textBox_passwordS.Name = "textBox_passwordS";
            this.textBox_passwordS.TabStop = false;
            // 
            // textBox_accesoS
            // 
            resources.ApplyResources(this.textBox_accesoS, "textBox_accesoS");
            this.textBox_accesoS.Name = "textBox_accesoS";
            this.textBox_accesoS.TabStop = false;
            // 
            // textBox_contador
            // 
            resources.ApplyResources(this.textBox_contador, "textBox_contador");
            this.textBox_contador.Name = "textBox_contador";
            this.textBox_contador.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 300000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dtgw
            // 
            this.dtgw.AllowUserToAddRows = false;
            this.dtgw.AllowUserToDeleteRows = false;
            this.dtgw.AllowUserToResizeColumns = false;
            this.dtgw.AllowUserToResizeRows = false;
            this.dtgw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dtgw, "dtgw");
            this.dtgw.Name = "dtgw";
            this.dtgw.TabStop = false;
            // 
            // Form1
            // 
            this.AcceptButton = this.button1;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(212)))), ((int)(((byte)(231)))));
            this.CancelButton = this.button2;
            this.Controls.Add(this.dtgw);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1_password);
            this.Controls.Add(this.textBox1_usuario);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox_accesoS);
            this.Controls.Add(this.textBox_passwordS);
            this.Controls.Add(this.textBox_usuarioS);
            this.Controls.Add(this.textBox_contador);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Opacity = 0.98D;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgw)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1_usuario;
        private System.Windows.Forms.TextBox textBox1_password;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBox_usuarioS;
        private System.Windows.Forms.TextBox textBox_passwordS;
        private System.Windows.Forms.TextBox textBox_accesoS;
        private System.Windows.Forms.TextBox textBox_contador;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView dtgw;
    }
}

