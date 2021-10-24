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
    public partial class Ventana1Turnos : Form
    {
        public Ventana1Turnos()
        {
            InitializeComponent();
        }

        private void button_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_actualizar_Click(object sender, EventArgs e)
        {
            //traer todos los turnos cargados en la BD
        }
    }
}
