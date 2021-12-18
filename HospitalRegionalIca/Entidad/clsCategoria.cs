using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalRegionalIca
{
    public class clsCategoria
    {
        private int mvarIdCategoria;
        private string mvarDescripcion;

        public int IdCargo
        {
            get { return mvarIdCategoria; }
            set { mvarIdCategoria = value; }
        }

        public string Descripcion
        {
            get { return mvarDescripcion; }
            set { mvarDescripcion = value; }
        }
    }
}
