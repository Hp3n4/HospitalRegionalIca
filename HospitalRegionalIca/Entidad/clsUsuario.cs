using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalRegionalIca
{
    public class clsUsuario
    {
        private int mvarIdUsuario;
        private string mvarNombre;
        private string mvarNombreUsuario;
        private string mvarContraseña;
        private DateTime mvarFecha;
        private string mvarEstado;
        private int mvarIdDepartamento;
        private int mvarIdRol;

        public int IdUsuario
        {
            get { return mvarIdUsuario; }
            set { mvarIdUsuario = value; }
        }

        public string Nombre
        {
            get { return mvarNombre; }
            set { mvarNombre = value; }
        }

        public string NombreUsuario
        {
            get { return mvarNombreUsuario; }
            set { mvarNombreUsuario = value; }
        }

        public string Contraseña
        {
            get { return mvarContraseña; }
            set { mvarContraseña = value; }
        }

        public DateTime Fecha
        {
            get { return mvarFecha; }
            set { mvarFecha = value; }
        }

        public string Estado
        {
            get { return mvarEstado; }
            set { mvarEstado = value; }
        }

        public int IdDepartamento
        {
            get { return mvarIdDepartamento; }
            set { mvarIdDepartamento = value; }
        }

        public int IdRol
        {
            get { return mvarIdRol; }
            set { mvarIdRol = value; }
        }
    }
}
