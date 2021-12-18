using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace HospitalRegionalIca
{
    public class clsCargoDatos
    {

        public DataTable LlenarComboBoxCargo()
        {
            SqlConnection Conexion = new SqlConnection();
            Conexion.ConnectionString = clsConexionBd.CadenaConexion;
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("select id_cargo as ID, descripcion from cargo order by descripcion", Conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
            Conexion.Open();
            adaptador.Fill(dt);
            return dt;
        }
    }
}
