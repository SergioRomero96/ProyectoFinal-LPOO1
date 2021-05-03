using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class GestionDeCuotas
    {
        //agregado :: pago
        public static DataTable GetCuotasPendientes(int id)
        {
            SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "cuota_listar_pendientes";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cn;

            cmd.Parameters.AddWithValue("@prestamo", id);

            //ejecuta la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            //Llena los datos de la consulta en el Datatable
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        //agregado :: pago
        public static DataTable GetCuotas(int id)
        {
            SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "cuota_listar";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cn;

            cmd.Parameters.AddWithValue("@prestamo", id);

            //ejecuta la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            //Llena los datos de la consulta en el Datatable
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static int ContarCuotasPagadas(int id)
        {
            //int contar = 0;
            SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "cuota_pagadas_contar";
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

        public static int ContarCuotasPedientes(int id)
        {
            //int contar = 0;
            SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "cuota_pendiente_contar";
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

        public static double SumarCuotasPedientes(int id)
        {
            try
            {
                //int contar = 0;
                SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
                SqlCommand cmd = new SqlCommand();

                cmd.CommandText = "cuota_pendiente_sumar";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = cn;

                cmd.Parameters.AddWithValue("@prestamo", id);

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


        public static double SumarCuotasPagadas(int id)
        {
            try
            {
                //int contar = 0;
                SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
                SqlCommand cmd = new SqlCommand();

                cmd.CommandText = "cuota_pagadas_sumar";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = cn;

                cmd.Parameters.AddWithValue("@prestamo", id);

                //parametro de salida
                cmd.Parameters.Add("@sumar", SqlDbType.Int);
                cmd.Parameters["@sumar"].Direction = ParameterDirection.Output;


                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();

                //obtener el valor del parametro de salida
                double contar_mas = (int)cmd.Parameters["@sumar"].Value;
                return contar_mas;
            }
            catch { }
            return 0d;
           

        }

        public static DataTable BuscarCuotasPorPrestamo(int id)
        {
            SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "cuota_listar_prestamos";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cn;

            cmd.Parameters.AddWithValue("@prestamo", id);

            //ejecuta la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            //Llena los datos de la consulta en el Datatable
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static DataTable SelectCuotas(int prestamo)
        {
            SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "cuota_seleccionar";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cn;

            cmd.Parameters.AddWithValue("@prestamo", prestamo);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static void InsertarCuota(Cuota cuota)
        {
            SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "cuota_insertar";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cn;

            cmd.Parameters.AddWithValue("@prestamo", cuota.Pre_Numero);
            cmd.Parameters.AddWithValue("@numero", cuota.Cuo_Numero);
            cmd.Parameters.AddWithValue("@vencimiento", cuota.Cuo_Vencimiento);
            cmd.Parameters.AddWithValue("@importe", cuota.Cuo_Importe);
            cmd.Parameters.AddWithValue("@estado", cuota.Cuo_Estado);

            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        //agregado :: pago
        public static void ActualizarCuota(int cuota)
        {
            SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "cuota_actualizar";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cn;

            cmd.Parameters.AddWithValue("@codigo", cuota);

            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }
    }
}
