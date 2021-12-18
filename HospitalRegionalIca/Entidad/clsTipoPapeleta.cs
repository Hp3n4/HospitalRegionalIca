using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalRegionalIca
{
    public class clsTipoPapeleta
    {
        private int mvarIdTipoPapeleta;
        private string mvarDescripcion;
       

        public int IdUsuario
        {
            get { return mvarIdTipoPapeleta; }
            set { mvarIdTipoPapeleta = value; }
        }

        public string Descripcion
        {
            get { return mvarDescripcion; }
            set { mvarDescripcion = value; }
        }
    }
}
