using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalRegionalIca
{
    public class clsLoginAcceso
    {
        private static int mvarIdUsuario;
        private static string mvarNombre;
        private static string mvarNombre_Usuario;
        private static string mvarContraseña;
        private static DateTime mvarFecha;
        private static int mvarEstado;
        private static int mvarId_Departamento;
        private static int mvarId_Rol;

        public static int IdUsario
        {
            get { return mvarIdUsuario; }
            set { mvarIdUsuario = value; }
        }

        public static string Nombre
        {
            get { return mvarNombre; }
            set { mvarNombre = value; }
        }

        public static string Nombre_Usuario
        {
            get { return mvarNombre_Usuario; }
            set { mvarNombre_Usuario = value; }
        }

        public static string Contraseña
        {
            get { return mvarContraseña; }
            set { mvarContraseña = value; }
        }

        public static DateTime Fecha
        {
            get { return mvarFecha; }
            set { mvarFecha = value; }
        }

        public static int Estado
        {
            get { return mvarEstado; }
            set { mvarEstado = value; }
        }

        public static int Departamento
        {
            get { return mvarId_Departamento; }
            set { mvarId_Departamento = value; }
        }

        public static int Rol
        {
            get { return mvarId_Rol; }
            set { mvarId_Rol = value; }
        }
    }
}
