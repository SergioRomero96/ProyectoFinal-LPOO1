using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Prestamo
    {
        public Prestamo(int pre_Numero, string cli_Dni, int des_Codigo, int per_Codigo, DateTime pre_Fecha, decimal pre_Importe, double pre_TasaInteres, int pre_CantidadCuotas,
         string pre_Estado)
        {
            this.pre_Numero = pre_Numero;
            this.cli_Dni = cli_Dni;
            this.des_Codigo = des_Codigo;
            this.per_Codigo = per_Codigo;
            this.pre_Fecha = pre_Fecha;
            this.pre_Importe = pre_Importe;
            this.pre_TasaInteres = pre_TasaInteres;
            this.pre_CantidadCuotas = pre_CantidadCuotas;
            this.pre_Estado = pre_Estado;
        }

        public Prestamo()
        {
            // TODO: Complete member initialization
            pre_Estado = "PENDIENTE";
        }

        private int pre_Numero;

        public int Pre_Numero
        {
            get { return pre_Numero; }
            set { pre_Numero = value; }
        }

        private string cli_Dni;

        public string Cli_Dni
        {
            get { return cli_Dni; }
            set { cli_Dni = value; }
        }

        private int des_Codigo;

        public int Des_Codigo
        {
            get { return des_Codigo; }
            set { des_Codigo = value; }
        }

        private int per_Codigo;

        public int Per_Codigo
        {
            get { return per_Codigo; }
            set { per_Codigo = value; }
        }

        private DateTime pre_Fecha;

        public DateTime Pre_Fecha
        {
            get { return pre_Fecha; }
            set { pre_Fecha = value; }
        }

        private decimal pre_Importe;

        public decimal Pre_Importe
        {
            get { return pre_Importe; }
            set { pre_Importe = value; }
        }

        private double pre_TasaInteres;

        public double Pre_TasaInteres
        {
            get { return pre_TasaInteres; }
            set { pre_TasaInteres = value; }
        }

        private int pre_CantidadCuotas;

        public int Pre_CantidadCuotas
        {
            get { return pre_CantidadCuotas; }
            set { pre_CantidadCuotas = value; }
        }

        private string pre_Estado;

        public string Pre_Estado
        {
            get { return pre_Estado; }
            set { pre_Estado = value; }
        }

        public override string ToString()
        {
            return String.Format("Numero Prestamo: {0}\nDNI: {1}\nCodigo Destino: {2}\nCodigo Periodo: {3}\nFecha Prestamo: {4}\nImporte: {5}\nTasa Interes: {6}\nCantidad Cuotas: {7}\nEstado: {8}", pre_Numero, cli_Dni, des_Codigo, per_Codigo, pre_Fecha, pre_Importe, pre_TasaInteres, pre_CantidadCuotas, pre_Estado);
        }
    }
}
