using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace HospitalRegionalIca
{
    public class clsCategoriaDatos
    {
        public DataTable LlenarComboBoxCategoria()
        {
            SqlConnection Conexion = new SqlConnection();
            Conexion.ConnectionString = clsConexionBd.CadenaConexion;
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("select id_categoria as ID, descripcion from Categoria order by descripcion", Conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
            Conexion.Open();
            adaptador.Fill(dt);
            return dt;
        }
    }
}
