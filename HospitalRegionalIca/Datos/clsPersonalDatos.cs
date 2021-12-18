using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace HospitalRegionalIca
{
    public class clsPersonalDatos
    {
        public DataTable LlenarComboBoxPersonal()
        {
            SqlConnection Conexion = new SqlConnection();
            Conexion.ConnectionString = clsConexionBd.CadenaConexion;
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("select id_personal as ID, descripcion from Personal order by descripcion", Conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
            Conexion.Open();
            adaptador.Fill(dt);
            return dt;
        }
    }
}
