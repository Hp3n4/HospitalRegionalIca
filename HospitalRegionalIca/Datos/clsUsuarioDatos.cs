using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace HospitalRegionalIca
{
    public class clsUsuarioDatos
    {
        public DataTable LlenarDataGridViewDepartamento()
        {
            SqlConnection Conexion = new SqlConnection();
            Conexion.ConnectionString = clsConexionBd.CadenaConexion;
            DataTable dt = new DataTable();
            SqlDataReader dr;
            SqlCommand cmd = new SqlCommand("select usu.id_usuario as ID, usu.nombre,usu.nombre_usuario as Usuario, usu.Contraseña,  "
                + " usu.fecha, usu.estado, usu.id_departamento, dep.descripcion as Departamento, usu.id_rol, rou.descripcion as Rol from usuario as usu "
                + " inner join departamento as dep on usu.id_departamento = dep.id_departamento "
                + " inner join rol_usuario as rou on usu.id_rol = rou.id_rol "
                + "order by usu.nombre", Conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
            Conexion.Open();
            adaptador.Fill(dt);
            dr = cmd.ExecuteReader();
            Conexion.Close();
            return dt;
        }
        //<!-- REALIZA LA CONSULTA PARA LLENAR UN COMBOBOX DE Departamento -->
       
        //<!----------- -------- ------FIN -- ----- -- ------ ----------->

        //<!-- REALIZA LA CONSULTA PARA LLENAR UN COMBOBOX DE ROL -->
        public DataTable LlenarComboBoxRol()
        {
            SqlConnection Conexion = new SqlConnection();
            Conexion.ConnectionString = clsConexionBd.CadenaConexion;
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("select id_rol as ID, descripcion from rol_usuario order by descripcion", Conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
            Conexion.Open();
            adaptador.Fill(dt);
            return dt;
        }
        //<!----------- -------- ------FIN -- ----- -- ------ ----------->

        public void InsertarUsuario(clsUsuario objUsuario)
        {
            SqlConnection Conexion = new SqlConnection();
            Conexion.ConnectionString = clsConexionBd.CadenaConexion;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Conexion;
            cmd.CommandText = "INSERT INTO usuario (nombre, nombre_usuario, contraseña, fecha, estado, id_departamento, id_rol) "
                + " VALUES ('" + objUsuario.Nombre + "', '" + objUsuario.NombreUsuario + "', '" + objUsuario.Contraseña + "', GETDATE(), "
                + " '1'," + objUsuario.IdDepartamento + "," + objUsuario.IdRol + ")";
            Conexion.Open();
            cmd.ExecuteNonQuery();
            Conexion.Close();
        }

        public void ActualizarUsuario(clsUsuario objUsuario)
        {
            SqlConnection Conexion = new SqlConnection();
            Conexion.ConnectionString = clsConexionBd.CadenaConexion;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Conexion;
            cmd.CommandText = "UPDATE usuario SET "
                + " nombre = '" + objUsuario.Nombre + "', "
                + " nombre_usuario = '" + objUsuario.NombreUsuario + "', "
                + " contraseña = '" + objUsuario.Contraseña + "', "
                + " fecha = GETDATE(), "
                + " estado = '" + objUsuario.Estado + "', "
                + " id_departamento = " + objUsuario.IdDepartamento + ", "
                + " id_rol = " + objUsuario.IdRol
                + " WHERE id_usuario=" + objUsuario.IdUsuario;
            Conexion.Open();
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            Conexion.Close();
        }

        public void EliminarUsuario(clsUsuario objUsuario)
        {
            SqlConnection Conexion = new SqlConnection();
            Conexion.ConnectionString = clsConexionBd.CadenaConexion;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Conexion;
            cmd.CommandText = "DELETE FROM usuario "
                + " where id_usuario = " + objUsuario.IdUsuario;
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
            SqlCommand cmd = new SqlCommand("select usu.id_usuario as ID, usu.nombre,usu.nombre_usuario as Usuario, usu.Contraseña,  "
                + " usu.fecha, usu.estado, usu.id_departamento, dep.descripcion as Departamento, usu.id_rol, rou.descripcion as Rol from usuario as usu "
                + " inner join departamento as dep on usu.id_departamento = dep.id_departamento "
                + " inner join rol_usuario as rou on usu.id_rol = rou.id_rol "
                + " WHERE usu.nombre_usuario like '%" + Condicion + "%' or dep.descripcion like '%" + Condicion + "%'"
                + "order by usu.nombre" 
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
