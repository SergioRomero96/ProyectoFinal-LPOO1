using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Pago
    {
        private int pag_Codigo;

        public int Pag_Codigo
        {
            get { return pag_Codigo; }
            set { pag_Codigo = value; }
        }

        private int cuo_Codigo;

        public int Cuo_Codigo
        {
            get { return cuo_Codigo; }
            set { cuo_Codigo = value; }
        }

        private DateTime pag_Fecha;

        public DateTime Pag_Fecha
        {
            get { return pag_Fecha; }
            set { pag_Fecha = value; }
        }

        private Decimal pag_Importe;

        public Decimal Pag_Importe
        {
            get { return pag_Importe; }
            set { pag_Importe = value; }
        }

        public Pago() { }

        public Pago(int pag_Codigo, int cuo_Codigo, DateTime pag_Fecha, Decimal pag_Importe)
        {
            this.pag_Codigo = pag_Codigo;
            this.cuo_Codigo = cuo_Codigo;
            this.pag_Fecha = pag_Fecha;
            this.pag_Importe = pag_Importe;
        }

        public override string ToString()
        {
            return String.Format("Codigo: {0}\nFecha: {1}\nImporte: {2}", pag_Codigo, pag_Fecha.ToString(), pag_Importe);
        }


    }
}
