using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace HospitalRegionalIca
{
    public class clsServicioDatos
    {
        public DataTable LlenarDataGridViewServicio()
        {
            SqlConnection Conexion = new SqlConnection();
            Conexion.ConnectionString = clsConexionBd.CadenaConexion;
            DataTable dt = new DataTable();
            SqlDataReader dr;
            SqlCommand cmd = new SqlCommand("select ser.id_servicio as ID,dep.descripcion as Departamento, "
                + " ser.id_departamento as IDdep, "
                + " ser.descripcion as Servicio from Servicio as ser "
                + " inner join departamento as dep on ser.id_departamento = dep.id_departamento "
                + "order by dep.descripcion", Conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
            Conexion.Open();
            adaptador.Fill(dt);
            dr = cmd.ExecuteReader();
            Conexion.Close();
            return dt;
        }

        public void InsertarServicios(clsServicio objServicio)
        {
            SqlConnection Conexion = new SqlConnection();
            Conexion.ConnectionString = clsConexionBd.CadenaConexion;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Conexion;
            cmd.CommandText = "INSERT INTO servicio (descripcion, id_departamento) "
                + " VALUES ('" + objServicio.Descripcion + "', " + objServicio.IdDepartamento + ")";
            Conexion.Open();
            cmd.ExecuteNonQuery();
            Conexion.Close();
        }

        public void EliminarServicio(clsServicio objServicio)
        {
            SqlConnection Conexion = new SqlConnection();
            Conexion.ConnectionString = clsConexionBd.CadenaConexion;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Conexion;
            cmd.CommandText = "DELETE FROM Servicio "
                + " where id_servicio = " + objServicio.IdServicio;
            Conexion.Open();
            cmd.ExecuteNonQuery();
            Conexion.Close();
        }

        public void ActualizarServicio(clsServicio objServicio)
        {
            SqlConnection Conexion = new SqlConnection();
            Conexion.ConnectionString = clsConexionBd.CadenaConexion;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Conexion;
            cmd.CommandText = "UPDATE servicio SET "
                + " descripcion = '" + objServicio.Descripcion + "', "                 
                + " id_departamento = " + objServicio.IdDepartamento                
                + " WHERE id_servicio =" + objServicio.IdServicio;
            Conexion.Open();
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            Conexion.Close();
        }

        public DataTable Filtrar(string Condicion)
        {
            SqlConnection Conexion = new SqlConnection();
            Conexion.ConnectionString = clsConexionBd.CadenaConexion;
            DataTable dt = new DataTable();
            SqlDataReader dr;
            SqlCommand cmd = new SqlCommand("select ser.id_servicio as ID,dep.descripcion as Departamento, "
                + " ser.id_departamento as IDdep, "
                + " ser.descripcion as Servicio from Servicio as ser "
                + " inner join departamento as dep on ser.id_departamento = dep.id_departamento "                
                + " WHERE ser.descripcion like '%" + Condicion + "%' or dep.descripcion like '%" + Condicion + "%'"
                + "order by dep.descripcion"
                , Conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
            Conexion.Open();
            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
            {
                adapter.Fill(dt);
            }
            dr = cmd.ExecuteReader();
            Conexion.Close();
            return dt;
        }

    }
}
