using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace HospitalRegionalIca
{
    public class clsTrabajadorDatos
    {        public DataTable LlenarDataGridViewTrabajador()
        {
            SqlConnection Conexion = new SqlConnection();
            Conexion.ConnectionString = clsConexionBd.CadenaConexion;
            DataTable dt = new DataTable();
            SqlDataReader dr;
            SqlCommand cmd = new SqlCommand("SELECT id_trabajador as ID, DNI, apellido_paterno + ' ' + apellido_materno + ' ' + primer_nombre + ' ' + segundo_nombre as Trabajador, "
                + " Plaza, Remuneracion, Nivel, Fecha_Nacimiento as FNacimiento, tra.id_cargo, car.descripcion as Cargo, "
                + " tra.id_categoria, cat.descripcion as Categoria, tra.id_personal, per.descripcion as Personal, "
                + " tra.id_departamento, dep.descripcion as Departamento, F_Ingreso as FIngreso, Estado, "
                + " apellido_paterno as APaterno, apellido_materno as AMaterno, primer_nombre as PNombre, segundo_nombre as SNombre FROM Trabajador as tra "
                + " inner join cargo as car on tra.id_cargo = car.id_cargo "
                + " inner join categoria as cat on tra.id_categoria = cat.id_categoria "
                + " inner join Personal as per on tra.id_personal = per.id_personal "
                + " inner join Departamento as dep on tra.id_departamento = dep.id_departamento "                
                + " order by Trabajador", Conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
            Conexion.Open();
            adaptador.Fill(dt);
            dr = cmd.ExecuteReader();
            Conexion.Close();
            return dt;
        }

        public void EliminarTrabajador(clsTrabajador objtrabajador)
        {
            SqlConnection Conexion = new SqlConnection();
            Conexion.ConnectionString = clsConexionBd.CadenaConexion;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Conexion;
            cmd.CommandText = "DELETE FROM trabajador "
                + " where id_trabajador = " + objtrabajador.IdTrabajador;
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
            SqlCommand cmd = new SqlCommand("SELECT id_trabajador as ID, DNI, apellido_paterno + ' ' + apellido_materno + ' ' + primer_nombre + ' ' + segundo_nombre as Trabajador, "
                + " Plaza, Remuneracion, Nivel, Fecha_Nacimiento as FNacimiento, tra.id_cargo, car.descripcion as Cargo, "
                + " tra.id_categoria, cat.descripcion as Categoria, tra.id_personal, per.descripcion as Personal, "
                + " tra.id_departamento, dep.descripcion as Departamento, F_Ingreso as FIngreso, Estado, "
                + " apellido_paterno as APaterno, apellido_materno as AMaterno, primer_nombre as PNombre, segundo_nombre as SNombre FROM Trabajador as tra "
                + " inner join cargo as car on tra.id_cargo = car.id_cargo "
                + " inner join categoria as cat on tra.id_categoria = cat.id_categoria "
                + " inner join Personal as per on tra.id_personal = per.id_personal "
                + " inner join Departamento as dep on tra.id_departamento = dep.id_departamento "
                + " WHERE Trabajador like '%" + Condicion + "%' "//or dep.descripcion like '%" + Condicion + "%'"
                + " order by Trabajador "
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
