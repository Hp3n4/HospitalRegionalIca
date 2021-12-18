using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalRegionalIca
{
    public class clsRolUsuario
    {
        private int mvarIdRol;
        private string mvarDescripcion;
        private string mvarEstado;
        

        public int IdRol
        {
            get { return mvarIdRol; }
            set { mvarIdRol = value; }
        }

        public string Descripcion
        {
            get { return mvarDescripcion; }
            set { mvarDescripcion = value; }
        }

        public string Estado
        {
            get { return mvarEstado; }
            set { mvarEstado = value; }
        }
    }
}
