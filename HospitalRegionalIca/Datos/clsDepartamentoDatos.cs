using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace HospitalRegionalIca
{
    public class clsDepartamentoDatos
    {

        public DataTable LlenarDataGridViewDepartamento()
        {
            SqlConnection Conexion = new SqlConnection();
            Conexion.ConnectionString = clsConexionBd.CadenaConexion;            
            DataTable dt = new DataTable();
            SqlDataReader dr;
            SqlCommand cmd = new SqlCommand("select id_departamento as ID,descripcion as Departamento,Jefe from Departamento Order by descripcion", Conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
            Conexion.Open();
            adaptador.Fill(dt);
            dr = cmd.ExecuteReader();
            Conexion.Close();
            return dt;
        }

        public void InsertarDepartamento(clsDepartamento objDepartament)
        {
            SqlConnection Conexion = new SqlConnection();
            Conexion.ConnectionString = clsConexionBd.CadenaConexion;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Conexion;
            cmd.CommandText = "INSERT INTO Departamento (descripcion,Jefe) VALUES " 
                + " ('" + objDepartament.Descripcion + "', "
                + " '" + objDepartament.Jefe + "') ";
            Conexion.Open();            
            cmd.ExecuteNonQuery();
            Conexion.Close();
        }

        public void ActualizarDepartamento(clsDepartamento objDepartament)
        {            
            SqlConnection Conexion = new SqlConnection();
            Conexion.ConnectionString = clsConexionBd.CadenaConexion;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Conexion;
            cmd.CommandText = "UPDATE Departamento SET "                    
                + " descripcion = '" + objDepartament.Descripcion + "', "
                + " Jefe = '" + objDepartament.Jefe +"' "
                + " WHERE id_departamento=" + objDepartament.IdDepartamento;
            Conexion.Open();
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            Conexion.Close();               
        }

        public void EliminarDepartamento(clsDepartamento objDepartament)
        {
            SqlConnection Conexion = new SqlConnection();
            Conexion.ConnectionString = clsConexionBd.CadenaConexion;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Conexion;
            cmd.CommandText = "DELETE FROM Departamento "
                + " where id_departamento = " + objDepartament.IdDepartamento;
            Conexion.Open();
            cmd.ExecuteNonQuery();
            Conexion.Close();
        }

        public DataTable Filtrar(string Condicion)
        {
            SqlConnection Conexion = new SqlConnection();
            Conexion.ConnectionString = clsConexionBd.CadenaConexion;
            DataTable dt = new DataTable();
            SqlDataReader dr;            
            SqlCommand cmd = new SqlCommand("SELECT id_departamento as ID,descripcion as Departamento, Jefe FROM Departamento " 
                + " WHERE descripcion like '%" + Condicion + "%' or Jefe like '%" + Condicion + "%'",Conexion);
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

        public DataTable LlenarComboBoxDepartamento()
        {
            SqlConnection Conexion = new SqlConnection();
            Conexion.ConnectionString = clsConexionBd.CadenaConexion;
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("select id_departamento as ID, descripcion from departamento order by descripcion", Conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
            Conexion.Open();
            adaptador.Fill(dt);
            return dt;
        }

    }
}
