using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SentirseBienApp
{
    static class Transferencias
    {
        //PERSONA
        private static int dni;
        private static string apellido;
        private static string nombre;
        //private static string email;
        //private static int telefono;
        public static string globalNombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public static string globalApellido
        {
            get { return apellido; }
            set { apellido = value; }
        }
        public static int globalDNI
        {
            get { return dni; }
            set { dni = value; }
        }

        //MONTOS
        private static int montoServicio;
        public static int globalmontoServicio
        {
            get { return montoServicio; }
            set { montoServicio = value; }
        }

        //ADMIN
        private static DateTime fechaHora;
        public static DateTime globalfechaHora
        {
            get { return fechaHora; }
            set { fechaHora = value; }
        }


        //PROFESIONAL
        private static string nombreUsuario;
        public static string globalnombreUsuario
        {
            get { return nombreUsuario; }
            set { nombreUsuario = value; }
        }
    }
}
