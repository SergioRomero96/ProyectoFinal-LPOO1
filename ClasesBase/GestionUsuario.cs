using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;
using ClasesBase.Cache;

namespace ClasesBase
{
    public class GestionUsuario
    {
        public static string Get_Rol(int codigo)
        {
            SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "usuario_obtener_rol";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cn;

            //Parametro de Entrada
            cmd.Parameters.AddWithValue("@codigo", codigo);

            //Paramatro de Salida
            cmd.Parameters.Add("@rol", SqlDbType.VarChar, 50);
            cmd.Parameters["@rol"].Direction = ParameterDirection.Output;

            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();

            //Obtengo el valor del parametro de salida
            string rol = cmd.Parameters["@rol"].Value.ToString();
            return rol;
        }

        public static DataTable ValidarLogin(string nombre, string password)
        {
            SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "usuario_validar_login";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cn;

            cmd.Parameters.AddWithValue("@usuario", nombre);
            cmd.Parameters.AddWithValue("@password", password);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count == 1)
            {
                UserLoginCache.UsuarioLogin.Usu_Id = (int)dt.Rows[0][0];

                UserLoginCache.UsuarioLogin.Usu_NombreUsuario = dt.Rows[0][1].ToString();
                UserLoginCache.UsuarioLogin.Usu_Password = dt.Rows[0][2].ToString();
                UserLoginCache.UsuarioLogin.Usu_Apellido = dt.Rows[0][3].ToString();
                UserLoginCache.UsuarioLogin.Usu_Nombre = dt.Rows[0][4].ToString();
                UserLoginCache.UsuarioLogin.Rol_Codigo = (int)dt.Rows[0][5];
            }

            return dt;
        }

        public static int GetCantidadAdministradores()
        {
            SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "usuario_obtener_cantidad_administradores";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cn;

            cmd.Parameters.AddWithValue("@rol", 1);

            cmd.Parameters.Add("@cantidad",SqlDbType.Int);
            cmd.Parameters["@cantidad"].Direction = ParameterDirection.Output;

            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
            int cantidad = (int)cmd.Parameters["@cantidad"].Value;
            return cantidad;
        }

        public static DataTable GetRoles()
        {
            SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM Rol";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cn;

            //ejecuta la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //Llena los datos de la consulta en el Datatable
            DataTable dt = new DataTable();
            da.Fill(dt);
            
            return dt;
        }

        public static void update_Usuario(Usuario usuario) 
        {
            SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "usuario_actualizar";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cn;

            cmd.Parameters.AddWithValue("@idUsuario", usuario.Usu_Id);
            cmd.Parameters.AddWithValue("@usuario", usuario.Usu_NombreUsuario);
            cmd.Parameters.AddWithValue("@password", usuario.Usu_Password);
            cmd.Parameters.AddWithValue("@apellido", usuario.Usu_Apellido.ToUpper());
            cmd.Parameters.AddWithValue("@nombre", usuario.Usu_Nombre.ToUpper());
            cmd.Parameters.AddWithValue("@rol", usuario.Rol_Codigo);

            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        public static void insert_Usuario(Usuario usuario)
        {
            SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "usuario_insertar";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cn;

            cmd.Parameters.AddWithValue("@usuario", usuario.Usu_NombreUsuario);
            cmd.Parameters.AddWithValue("@password", usuario.Usu_Password);
            cmd.Parameters.AddWithValue("@apellido", usuario.Usu_Apellido);
            cmd.Parameters.AddWithValue("@nombre", usuario.Usu_Nombre);
            cmd.Parameters.AddWithValue("@rol", usuario.Rol_Codigo);

            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        public static void delete_Usuario(Usuario usuario) 
        {
            SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "usuario_eliminar";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cn;

            cmd.Parameters.AddWithValue("@idUsuario", usuario.Usu_Id);
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        public static DataTable list_Usuarios()
        {
            SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "usuario_listar";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cn;

            //ejecuta la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //Llena los datos de la consulta en el Datatable
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static DataTable ValidarUsuario(Usuario usuario) 
        {
            SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "usuario_validar";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cn;

            cmd.Parameters.AddWithValue("@usuario", usuario.Usu_NombreUsuario);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static DataTable buscar_Usuario(String apellido, String nombre,bool criterio)
        {
            SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();

            if (criterio)
                cmd.CommandText = "usuario_buscar_apellidoYnombre";
            else
                cmd.CommandText = "usuario_buscar_apellidoOnombre";
                
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cn;

            cmd.Parameters.AddWithValue("@apellido", "%" + apellido + "%");
            cmd.Parameters.AddWithValue("@nombre", "%" + nombre + "%");

            //Ejecuta la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //Llena los datos de la consulta en el Datatable
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;

        }

       public static DataSet ordenar_Usuarios(Boolean radio)
       {
           SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
           SqlDataAdapter da = new SqlDataAdapter();
           da.SelectCommand = new SqlCommand();
           da.SelectCommand.Connection = cn;
           if (radio)
               da.SelectCommand.CommandText = "OrdenarUsuarios";
           else
               da.SelectCommand.CommandText = "OrdenarUsuarios2";

           da.SelectCommand.CommandType = CommandType.StoredProcedure;
           DataSet ds = new DataSet();

           da.Fill(ds, "Usuarios");

           return ds;
       }
    }
}
