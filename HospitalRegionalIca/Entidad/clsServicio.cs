using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalRegionalIca
{
    public class clsServicio
    {
        private int mvarIdServicio;
        private string mvarDescripcion;
        private int mvarIdDepartamento;


        public int IdServicio
        {
            get { return mvarIdServicio; }
            set { mvarIdServicio = value; }
        }

        public string Descripcion
        {
            get { return mvarDescripcion; }
            set { mvarDescripcion = value; }
        }

        public int IdDepartamento
        {
            get { return mvarIdDepartamento; }
            set { mvarIdDepartamento = value; }
        }
    }
}
