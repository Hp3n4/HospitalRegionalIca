using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalRegionalIca
{
    public class clsCargo
    {
        private int mvarIdCargo;
        private string mvarDescripcion;        

        public int IdCargo
        {
            get { return mvarIdCargo; }
            set { mvarIdCargo = value; }
        }

        public string Descripcion
        {
            get { return mvarDescripcion; }
            set { mvarDescripcion = value; }
        }
    }
}
