using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Destino
    {
        private static int codAutoincremental = 1;

        


        public Destino()
        {
        }
        public Destino(int des_Codigo, string des_Descripcion)
        {

            this.des_Codigo = des_Codigo;
            this.des_Descripcion = des_Descripcion;

        }
        public Destino(string des_Descripcion)
        {
            this.des_Codigo = codAutoincremental;
            this.des_Descripcion = des_Descripcion;
            codAutoincremental++;
        }
        private int des_Codigo;

        public int Des_Codigo
        {
            get { return des_Codigo; }
            set { des_Codigo = value; }
        }

        private string des_Descripcion;

        public string Des_Descripcion
        {
            get { return des_Descripcion; }
            set { des_Descripcion = value; }
        }
        public static int CodAutoincremental
        {
            get { return Destino.codAutoincremental; }
            set { Destino.codAutoincremental = value; }
        }
        public override string ToString()
        {
            return String.Format("Codigo: {0}\nDescripcion: {1}", des_Codigo, des_Descripcion);
        }
    }
}
