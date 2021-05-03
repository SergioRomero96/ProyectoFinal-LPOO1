using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class GestionDestino
    {
        public static String Get_Destino(int destino)
        {
            SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "destino_obtener";

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cn;

            cmd.Parameters.AddWithValue("@destino", destino);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt.Rows[0][0].ToString();

        }

        public static DataTable Get_UltimoID() 
        {
            //establece la conexion
            SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT TOP(1) * FROM Destino ORDER BY DES_Codigo DESC";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cn;
            //ejecuta la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            //llena los datos de la consulta en el datatable
            da.Fill(dt);
            return dt;
        }

        public static void insert_Destino(Destino destino)
        {
            SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "destino_insertar";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cn;

            cmd.Parameters.AddWithValue("@descripcion", destino.Des_Descripcion);

            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        public static void delete_Destino(Destino destino)
        {
            SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "destino_eliminar";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cn;

            cmd.Parameters.AddWithValue("@idDestino", destino.Des_Codigo);
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        public static DataTable list()
        {
            SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM Destino";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cn;

            //ejecuta la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //Llena los datos de la consulta en el Datatable
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static DataTable list_Destino()
        {
            SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "destino_listar";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cn;

            //ejecuta la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //Llena los datos de la consulta en el Datatable
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static DataTable validar_Destino(Destino destino)
        {
            SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "destino_validar";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cn;

            cmd.Parameters.AddWithValue("@descripcion", destino.Des_Descripcion.ToUpper());

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static void update_Destino(Destino destino)
        {
            SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "destino_actualizar";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cn;

            cmd.Parameters.AddWithValue("@idDestino", destino.Des_Codigo);
            cmd.Parameters.AddWithValue("@Descripcion", destino.Des_Descripcion.ToUpper());

            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        public static int devolverTienePrestamo(int id)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "destinoTienePrestamo";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@id", id);
            SqlParameter param;
            param = new SqlParameter("@band", SqlDbType.Int);
            param.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(param);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();

            return (int)cmd.Parameters["@band"].Value;
        }
    }
}
