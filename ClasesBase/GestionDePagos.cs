using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class GestionDePagos
    {
        public static void insert_Pago(Pago pago)
        {
            SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "pago_insertar";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cn;

            cmd.Parameters.AddWithValue("@codigo", pago.Cuo_Codigo);
            cmd.Parameters.AddWithValue("@fecha", pago.Pag_Fecha);
            cmd.Parameters.AddWithValue("@importe", pago.Pag_Importe);

            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        public static DataTable buscar_Pagos(string dni)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "listar_pagos_cliente";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            // Parametro de Entrada
            cmd.Parameters.AddWithValue("@dni", dni);
            
            // Ejecuta la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            // Llena los datos de la consulta en el DataTable
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static DataTable BuscarPagosPorFecha(string dni, DateTime fechaInicio, DateTime fechaFin)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "listar_pagos_cliente_fecha";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            // Parametro de Entrada
            cmd.Parameters.AddWithValue("@dni", dni);
            cmd.Parameters.AddWithValue("@fechaInicio", fechaInicio);
            cmd.Parameters.AddWithValue("@fechaFin", fechaFin);

            // Ejecuta la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            // Llena los datos de la consulta en el DataTable
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static int contarPagos(string dni)
        {
            //int contar = 0;
            SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();

           cmd.CommandText = "listar_clientes_pagados";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cn;

            cmd.Parameters.AddWithValue("@dni", dni);

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

        public static double sumarPagos(string dni)
        {
            try
            {
                //int contar = 0;
                SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
                SqlCommand cmd = new SqlCommand();

                cmd.CommandText = "Listar_Suma_Pagadas";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = cn;

                cmd.Parameters.AddWithValue("@dni", dni);

                //parametro de salida
                cmd.Parameters.Add("@sumar", SqlDbType.Int);
                cmd.Parameters["@sumar"].Direction = ParameterDirection.Output;


                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();

                //obtener el valor del parametro de salida
                double contar_mas = (int)cmd.Parameters["@sumar"].Value;

                //contar = (int)cmd.Parameters["@contar"].Value;
                return contar_mas;
            }
            catch { }
            return 0d;
        }

        public static int ContarPagosClienteFecha(string dni, DateTime fechaInicio, DateTime fechaFin)
        {
            //int contar = 0;
            SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "pago_contar_cliente_fecha";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cn;

            cmd.Parameters.AddWithValue("@dni", dni);
            cmd.Parameters.AddWithValue("@fechaInicio", fechaInicio);
            cmd.Parameters.AddWithValue("@fechaFin", fechaFin);

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

        public static double SumarPagosClienteFecha(string dni, DateTime fechaInicio, DateTime fechaFin)
        {
            try
            {
                //int contar = 0;
                SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
                SqlCommand cmd = new SqlCommand();

                cmd.CommandText = "pago_sumar_cliente_fecha";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = cn;

                cmd.Parameters.AddWithValue("@dni", dni);
                cmd.Parameters.AddWithValue("@fechaInicio", fechaInicio);
                cmd.Parameters.AddWithValue("@fechaFin", fechaFin);

                //parametro de salida
                cmd.Parameters.Add("@sumar", SqlDbType.Int);
                cmd.Parameters["@sumar"].Direction = ParameterDirection.Output;


                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();

                //obtener el valor del parametro de salida
                double contar_mas = (int)cmd.Parameters["@sumar"].Value;

                //contar = (int)cmd.Parameters["@contar"].Value;
                return contar_mas;
            }
            catch { }
            return 0d;
        }
    }
}
