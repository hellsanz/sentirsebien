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
        private static string email;
        private static int telefono;
        public static string globalNombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public static int globalDNI
        {
            get { return dni; }
            set { dni = value; }
        }

        //USUARIOS

        //TURNOS

        //SECRETARIO - PAGOS - COBROS
        private static int SecretarioClienteDNI;
        private static string SecretarioClienteNombre;
        private static string SecretarioClienteApellido;
        private static string SecretarioClienteServicio;
        private static double SecretarioClienteCosto;
        private static DateTime SecretarioClienteFecha;
        private static string SecretarioClienteAtendio;
        private static double SecretarioClienteCobro;

        //PROFESIONAL
        private static string nombreUsuario;
        public static string globalnombreUsuario
        {
            get { return nombreUsuario; }
            set { nombreUsuario = value; }
        }
    }
}
