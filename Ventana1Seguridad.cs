using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SentirseBienApp
{
    public partial class Ventana1Seguridad : Form
    {
        private Timer tiempo;
        public Ventana1Seguridad()
        {
            
            tiempo = new Timer();
            tiempo.Tick += new EventHandler(timer_fechahora_Tick);
            InitializeComponent();
            tiempo.Enabled = true;
        }

        private void timer_fechahora_Tick(object sender, EventArgs e)
        {
            DateTime dia = DateTime.Now;
            label_fecha.Text = dia.ToShortDateString();
            label_hora.Text = dia.ToLongTimeString();
        }
    }
}
