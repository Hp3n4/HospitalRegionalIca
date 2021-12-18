using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalRegionalIca
{
    public class clsPapeleta
    {
        private int mvarIdPapeleta;
        private int mvarIdTipoPapeleta;
        private int mvarIdTrabajador;
        private int mvarIdMotivo;
        private int mvarIdTurno;
        private int mvarIdUsuario;
        private string mvarNumerodocumento;
        private DateTime mvarFechaInicio;
        private DateTime mvarFechaFin;
        private int mvarHoraInicio;
        private int mvarMinutoInicio;
        private int mvarHoraFin;
        private int mvarMinutoFin;
        private decimal mvarRemuneracion;
        private decimal mvarRemuneracionDia;
        private decimal mvarRemuneracionMinuto;
        private decimal mvarDescuento;
        private string mvarSustento;
        private DateTime mvarFechaRegistro;
        private int mvarEstado;

        public int IdPapeleta
        {
            get { return mvarIdPapeleta; }
            set { mvarIdPapeleta = value; }
        }

        public int IdTipoPapeleta
        {
            get { return mvarIdTipoPapeleta; }
            set { mvarIdTipoPapeleta = value; }
        }

        public int IdTrabajador
        {
            get { return mvarIdTrabajador; }
            set { mvarIdTrabajador = value; }
        }

        public int IdMotivo
        {
            get { return mvarIdMotivo; }
            set { mvarIdMotivo = value; }
        }

        public int IdTurno
        {
            get { return mvarIdTurno; }
            set { mvarIdTurno = value; }
        }

        public int IdUsuario
        {
            get { return mvarIdUsuario; }
            set { mvarIdUsuario = value; }
        }

        public string Numerodocumento
        {
            get { return mvarNumerodocumento; }
            set { mvarNumerodocumento = value; }
        }

        public DateTime FechaInicio
        {
            get { return mvarFechaInicio; }
            set { mvarFechaInicio = value; }
        }

        public DateTime FechaFin
        {
            get { return mvarFechaFin; }
            set { mvarFechaFin = value; }
        }

        public int HoraInicio
        {
            get { return mvarHoraInicio; }
            set { mvarHoraInicio = value; }
        }

        public int MinutoInicio
        {
            get { return mvarMinutoInicio; }
            set { mvarMinutoInicio = value; }
        }

        public int HoraFin
        {
            get { return mvarHoraFin; }
            set { mvarHoraFin = value; }
        }

        public int MinutoFin
        {
            get { return mvarMinutoFin; }
            set { mvarMinutoFin = value; }
        }

        public decimal Remuneracion
        {
            get { return mvarRemuneracion; }
            set { mvarRemuneracion = value; }
        }

        public decimal RemuneracionDia
        {
            get { return mvarRemuneracionDia; }
            set { mvarRemuneracionDia = value; }
        }

        public decimal RemuneracionMinuto
        {
            get { return mvarRemuneracionMinuto; }
            set { mvarRemuneracionMinuto = value; }
        }

        public decimal Descuento
        {
            get { return mvarDescuento; }
            set { mvarDescuento = value; }
        }

        public string Sustento
        {
            get { return mvarSustento; }
            set { mvarSustento = value; }
        }

        public DateTime FechaRegistro
        {
            get { return mvarFechaRegistro; }
            set { mvarFechaRegistro = value; }
        }

        public int Estado
        {
            get { return mvarEstado; }
            set { mvarEstado = value; }
        }
    }
}
