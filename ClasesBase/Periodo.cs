using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Periodo
    {
        public Periodo()
        {
        }

        public Periodo(int per_Codigo, string per_Descripcion)
        {

            this.per_Codigo = per_Codigo;
            this.per_Descripcion = per_Descripcion;

        }
        private int per_Codigo;

        public int Per_Codigo
        {
            get { return per_Codigo; }
            set { per_Codigo = value; }
        }

        private string per_Descripcion;

        public string Per_Descripcion
        {
            get { return per_Descripcion; }
            set { per_Descripcion = value; }
        }
        public override string ToString()
        {
            return String.Format("Codigo: {0}\nDescripcion: {1}", per_Codigo, per_Descripcion);
        }

    }
}
