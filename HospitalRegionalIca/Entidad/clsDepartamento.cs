using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalRegionalIca
{
    public class clsDepartamento
    {
        private int mvarIdDepartamento;
        private string mvarDescripcion;
        private string mvarJefe;

        public int IdDepartamento
        {
            get { return mvarIdDepartamento; }
            set { mvarIdDepartamento = value; }
        }

        public string Descripcion
        {
            get { return mvarDescripcion; }
            set { mvarDescripcion = value; }
        }

        public string Jefe
        {
            get { return mvarJefe; }
            set { mvarJefe = value; }
        }

    }
}
