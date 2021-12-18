using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalRegionalIca
{
    public class clsPersonal
    {
        private int mvarIdPersonal;
        private string mvarDescripcion;


        public int IdPersonal
        {
            get { return mvarIdPersonal; }
            set { mvarIdPersonal = value; }
        }

        public string Descripcion
        {
            get { return mvarDescripcion; }
            set { mvarDescripcion = value; }
        }
    }
}
