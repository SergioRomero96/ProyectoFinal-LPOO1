using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class GestionPrestamo
    {
        public static DataTable GetPeriodos()
        {
            SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM Periodo";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cn;

            //ejecuta la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //Llena los datos de la consulta en el Datatable
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static DataTable GetPeriodo(int periodo)
        {
            SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM Periodo where PER_Codigo = @periodo";

            cmd.CommandType = CommandType.Text;
            cmd.Connection = cn;

            cmd.Parameters.AddWithValue("@periodo", periodo);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }
        
        public static void InsertarPrestamo(Prestamo prestamo)
        {
            SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "prestamo_insertar";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cn;    




            cmd.Parameters.AddWithValue("@dni", prestamo.Cli_Dni);
            cmd.Parameters.AddWithValue("@descodigo", prestamo.Des_Codigo);
            cmd.Parameters.AddWithValue("@percodigo", prestamo.Per_Codigo);
            cmd.Parameters.AddWithValue("@fecha", prestamo.Pre_Fecha);
            cmd.Parameters.AddWithValue("@importe", prestamo.Pre_Importe);
            cmd.Parameters.AddWithValue("@tasainteres", prestamo.Pre_TasaInteres);
            cmd.Parameters.AddWithValue("@cuotas", prestamo.Pre_CantidadCuotas);
            cmd.Parameters.AddWithValue("@estado", prestamo.Pre_Estado);

            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        public static void ActualizarPrestamo(Prestamo prestamo)
        {
            SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "prestamo_actualizar";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cn;    

            cmd.Parameters.AddWithValue("@dni", prestamo.Cli_Dni);
            cmd.Parameters.AddWithValue("@descodigo", prestamo.Des_Codigo);
            cmd.Parameters.AddWithValue("@percodigo", prestamo.Per_Codigo);
            cmd.Parameters.AddWithValue("@fecha", prestamo.Pre_Fecha);
            cmd.Parameters.AddWithValue("@importe", prestamo.Pre_Importe);
            cmd.Parameters.AddWithValue("@tasainteres", prestamo.Pre_TasaInteres);
            cmd.Parameters.AddWithValue("@cuotas", prestamo.Pre_CantidadCuotas);
            cmd.Parameters.AddWithValue("@estado", prestamo.Pre_Estado);

            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        

        public static DataTable ListarPrestamos()
        {

            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "listar_prestamos";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

           
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
           
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            // Llena los datos de la consulta en el DataTable
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
       
        }

        public static DataTable ListarPeriodos()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "periodo_listar";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;


            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();

            //ejecuta la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //Llena los datos de la consulta en el Datatable
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;

        }

        //agregado :: pago
        public static DataTable BuscarPrestamosPorCliente(string dni)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "prestamo_buscar_porcliente";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@dni", dni);

            //ejecuta la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //Llena los datos de la consulta en el Datatable
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static DataTable BuscarPrestamosPendientePorCliente(string dni)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "prestamo_buscar_pendiente_porCliente";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@dni", dni);

            //ejecuta la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //Llena los datos de la consulta en el Datatable
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

     
        //agregado :: pago
        public static void ActualizarEstadoPrestamo(int numero)
        {
            SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "prestamo_actualizarestado";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cn;

            cmd.Parameters.AddWithValue("@numero", numero);

            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        public static void ActualizarEstadoPendiente(int numero)
        {
            SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "prestamo_actualizar_estado";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cn;

            cmd.Parameters.AddWithValue("@numero", numero);

            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }


        public static DataTable BuscarPrestamosPorFecha(DateTime fechaInicio, DateTime fechaFinal)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "listar_prestamos_fecha";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            // Parametro de Entrada
            cmd.Parameters.AddWithValue("@fecha_inicio", fechaInicio);
            cmd.Parameters.AddWithValue("@fecha_final", fechaFinal);
            /*
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();*/

            // Ejecuta la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            // Llena los datos de la consulta en el DataTable
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static DataTable BuscarPrestamoPorDestino(string destino)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "listar_prestamos_destino";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@destino", destino);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static DataTable buscarPrestamoDestinoOtorgado(int id)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "destino_cantidad_otorgados";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public static DataTable buscarPrestamoDestinoPendiente(int id)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "destino_cantidad_pendientes";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public static DataTable buscarPrestamoDestinoCancelado(int id)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "destino_cantidad_cancelados";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public static DataTable buscarPrestamoDestinoAnulado(int id)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "destino_cantidad_anulados";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static int contarPrestamosPendientes(DateTime fechaInicio, DateTime fechaFinal)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "contarPendientesPorFecha";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@fecha_inicio", fechaInicio);
            cmd.Parameters.AddWithValue("@fecha_final", fechaFinal);
            SqlParameter param;
            param = new SqlParameter("@contar", SqlDbType.Int);
            param.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(param);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();

            return (int)cmd.Parameters["@contar"].Value;
        }

        public static int contarPrestamosOtorgados(DateTime fechaInicio, DateTime fechaFinal)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "contarOtorgadosPorFecha";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@fecha_inicio", fechaInicio);
            cmd.Parameters.AddWithValue("@fecha_final", fechaFinal);
            SqlParameter param;
            param = new SqlParameter("@contar", SqlDbType.Int);
            param.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(param);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();

            return (int)cmd.Parameters["@contar"].Value;
        }

        public static int contarPrestamosCancelados(DateTime fechaInicio, DateTime fechaFinal)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "contarCanceladosPorFecha";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@fecha_inicio", fechaInicio);
            cmd.Parameters.AddWithValue("@fecha_final", fechaFinal);
            SqlParameter param;
            param = new SqlParameter("@contar", SqlDbType.Int);
            param.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(param);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();

            return (int)cmd.Parameters["@contar"].Value;
        }

        public static int contarPrestamosAnulados(DateTime fechaInicio, DateTime fechaFinal)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "contarAnuladosPorFecha";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@fecha_inicio", fechaInicio);
            cmd.Parameters.AddWithValue("@fecha_final", fechaFinal);
            SqlParameter param;
            param = new SqlParameter("@contar", SqlDbType.Int);
            param.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(param);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();

            return (int)cmd.Parameters["@contar"].Value;
        }

        public static int ContarPrestamo(int id)
        {
            //int contar = 0;
            SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "prestamo_contar";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cn;

            cmd.Parameters.AddWithValue("@prestamo", id);

            //parametro de salida
            cmd.Parameters.Add("@contar", SqlDbType.Int);
            cmd.Parameters["@contar"].Direction = ParameterDirection.Output;

            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();

            //obtener el valor del parametro de salida
            int contar_mas = (int)cmd.Parameters["@contar"].Value;

            return contar_mas;
        }

        public static int ContarPrestamoPendintes(int id)
        {
            //int contar = 0;
            SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "prestamo_contar_pendiente";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cn;

            cmd.Parameters.AddWithValue("@prestamo", id);

            //parametro de salida
            cmd.Parameters.Add("@contar", SqlDbType.Int);
            cmd.Parameters["@contar"].Direction = ParameterDirection.Output;

            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();

            //obtener el valor del parametro de salida
            int contar_mas = (int)cmd.Parameters["@contar"].Value;
            return contar_mas;
        }

        public static int contarPrestamosPendientes(int dni)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "contarPrestamosPendientes";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@dni", dni);
            SqlParameter param;
            param = new SqlParameter("@contar", SqlDbType.Int);
            param.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(param);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();

            return (int)cmd.Parameters["@contar"].Value;
        }
    }
}
