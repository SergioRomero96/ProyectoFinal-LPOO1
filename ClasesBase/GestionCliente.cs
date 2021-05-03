using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class GestionCliente
    {

        public static void insert_Cliente(Cliente cliente)
        {
            SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "cliente_insertar";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cn;

            cmd.Parameters.AddWithValue("@dni", cliente.Cli_Dni);
            cmd.Parameters.AddWithValue("@nombre", cliente.Cli_Nombre);
            cmd.Parameters.AddWithValue("@apellido", cliente.Cli_Apellido);
            cmd.Parameters.AddWithValue("@sexo", cliente.Cli_Sexo);
            cmd.Parameters.AddWithValue("@fechanac", cliente.Cli_FechaNacimiento);
            cmd.Parameters.AddWithValue("@ingresos", cliente.Cli_Ingresos);
            cmd.Parameters.AddWithValue("@direccion", cliente.Cli_Direccion);
            cmd.Parameters.AddWithValue("@telefono", cliente.Cli_Telefono);

            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        public static void update_Cliente(Cliente cliente)
        {

            SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "cliente_actualizar";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cn;

            cmd.Parameters.AddWithValue("@dni", cliente.Cli_Dni);
            cmd.Parameters.AddWithValue("@nombre", cliente.Cli_Nombre);
            cmd.Parameters.AddWithValue("@apellido", cliente.Cli_Apellido);
            cmd.Parameters.AddWithValue("@sexo", cliente.Cli_Sexo);
            cmd.Parameters.AddWithValue("@fechanac", cliente.Cli_FechaNacimiento);
            cmd.Parameters.AddWithValue("@ingresos", cliente.Cli_Ingresos);
            cmd.Parameters.AddWithValue("@direccion", cliente.Cli_Direccion);
            cmd.Parameters.AddWithValue("@telefono", cliente.Cli_Telefono);

            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        public static DataTable list() 
        {
            SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * from Cliente";

            cmd.CommandType = CommandType.Text;
            cmd.Connection = cn;

            //ejecuta la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //Llena los datos de la consulta en el Datatable
            DataTable dt = new DataTable();
            da.Fill(dt);
            dt.Columns.Add("apellidoYnombre", typeof(string), "CLI_Apellido+', '+CLI_Nombre");
            dt.Columns.Add("detalle", typeof(string), "CLI_DNI+' - '+ CLI_Apellido+', '+CLI_Nombre");

            return dt;
        }

        public static DataTable listarPrestamoCliente()
        {
            SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "prestamo_por_cliente";

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cn;

            //ejecuta la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //Llena los datos de la consulta en el Datatable
            DataTable dt = new DataTable();
            da.Fill(dt);
            dt.Columns.Add("detalle", typeof(string), "CLI_DNI+' - '+ CLI_Apellido+', '+CLI_Nombre");

            return dt;
        }

        public static DataTable list_Clientes()
        {
            SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            
            cmd.CommandText += "cliente_listar";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cn;

            //ejecuta la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //Llena los datos de la consulta en el Datatable
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;

        }

        public static DataTable validar_Cliente(Cliente cliente)
        {
            SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "cliente_validar";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cn;

            cmd.Parameters.AddWithValue("@dni", cliente.Cli_Dni);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static DataTable buscar_Cliente(String busqueda)
        {
            SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText += "cliente_buscar_cliente";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cn;

            cmd.Parameters.AddWithValue("@busqueda", "%" + busqueda + "%");

            //Ejecuta la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //Llena los datos de la consulta en el Datatable
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;

        }

        public static void delete_Cliente(Cliente cliente)
        {
            SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "DELETE FROM Cliente WHERE CLI_DNI = @dni";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cn;

            cmd.Parameters.AddWithValue("@dni", cliente.Cli_Dni);
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        public static DataSet ordenar_Clientes()
        {
            SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand();
            da.SelectCommand.Connection = cn;

            da.SelectCommand.CommandText = "OrdenarClientesPorApellido";
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataSet ds = new DataSet();

            da.Fill(ds, "clientes");

            return ds;
        }

        public static int devolverTienePrestamo(int dni)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "clienteTienePrestamo";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@dni", dni);
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
