using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalRegionalIca
{
    public class clsMoivo
    {
        private int mvarIdMotivo;
        private string mvarDescripcion;

        public int IdMotivo
        {
            get { return mvarIdMotivo; }
            set { mvarIdMotivo = value; }
        }

        public string Descripcion
        {
            get { return mvarDescripcion; }
            set { mvarDescripcion = value; }
        }
    }
}
