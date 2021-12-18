using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalRegionalIca
{
    public class clsTrabajador
    {
        private int mvarIdTrabajador;
        private string mvarDNI;
        private string mvarPrimerNombre;
        private string mvarSegundoNombre;
        private string mvarApellidoPaterno;
        private string mvarApellidoMaterno;
        private string mvarPlaza;
        private string mvarEstado;
        private decimal mvarRemuneracion;
        private string mvarNivel;
        private DateTime mvarFechaNacimiento;
        private int mvarIdCargo;
        private int mvarIdCategoria;
        private int mvarIdPersonal;
        private int mvarIdDepartamento;
        private DateTime mvarFechaIngreso;

        public int IdTrabajador
        {
            get { return mvarIdTrabajador; }
            set { mvarIdTrabajador = value; }
        }

        public string DNI
        {
            get { return mvarDNI; }
            set { mvarDNI = value; }
        }

        public string PrimerNombre
        {
            get { return mvarPrimerNombre; }
            set { mvarPrimerNombre = value; }
        }

        public string SegundoNombre
        {
            get { return mvarSegundoNombre; }
            set { mvarSegundoNombre = value; }
        }

        public string ApellidoPaterno
        {
            get { return mvarApellidoPaterno; }
            set { mvarApellidoPaterno = value; }
        }

        public string ApellidoMaterno
        {
            get { return mvarApellidoMaterno; }
            set { mvarApellidoMaterno = value; }
        }

        public string Plaza
        {
            get { return mvarPlaza; }
            set { mvarPlaza = value; }
        }

        public string Estado
        {
            get { return mvarEstado; }
            set { mvarEstado = value; }
        }

        public decimal Remuneracion
        {
            get { return mvarRemuneracion; }
            set { mvarRemuneracion = value; }
        }

        public string Nivel
        {
            get { return mvarNivel; }
            set { mvarNivel = value; }
        }

        public DateTime FechaNacimiento
        {
            get { return mvarFechaNacimiento; }
            set { mvarFechaNacimiento = value; }
        }

        public int IdCargo
        {
            get { return mvarIdCargo; }
            set { mvarIdCargo = value; }
        }

        public int IdCategoria
        {
            get { return mvarIdCategoria; }
            set { mvarIdCategoria = value; }
        }

        public int IdPersonal
        {
            get { return mvarIdPersonal; }
            set { mvarIdPersonal = value; }
        }

        public int IdDepartamento
        {
            get { return mvarIdDepartamento; }
            set { mvarIdDepartamento = value; }
        }

        public DateTime FechaIngreso
        {
            get { return mvarFechaIngreso; }
            set { mvarFechaIngreso = value; }
        }
    }
}
