using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace HospitalRegionalIca
{
    public class clsUsuarioConexion
    {
        private String CadenaConexion = @"Data Source=SISGALENPLUSHRI;Initial Catalog=BDHRI;User ID=Sisgalenplus02;Password=Vannia1419;Connect Timeout=50;"; //sin usuario y contraseña


        public bool Login (clsUsuarioAcceder objUsuarioAcceder)
        {            
            SqlConnection conexion = new SqlConnection(CadenaConexion);
            SqlDataReader dr;
            SqlCommand cmd = new SqlCommand("dbo.uspEmpleadosBuscarUsuario",conexion);
            conexion.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Usuario", objUsuarioAcceder.Usuario);
            cmd.Parameters.AddWithValue("@Clave", objUsuarioAcceder.Clave);
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    objUsuarioAcceder.IdEmpleado = dr.GetInt32(0);
                    objUsuarioAcceder.ApellidoPaterno= dr.GetString(1);
                    objUsuarioAcceder.ApellidoMaterno = dr.GetString(2);
                    objUsuarioAcceder.Nombres = dr.GetString(3);
                    objUsuarioAcceder.Email = dr.GetString(18);
                }
                return true;
            }
            else return false;
        }


    }
}
