using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Rol
    {
        private int rol_Codigo;

        public int Rol_Codigo
        {
            get { return rol_Codigo; }
            set { rol_Codigo = value; }
        }
        private string rol_Descripcion;

        public string Rol_Descripcion
        {
            get { return rol_Descripcion; }
            set { rol_Descripcion = value; }
        }

        public Rol()
        {
        }
        public Rol(int codigo, string descripcion) 
        {
            rol_Codigo = codigo;
            rol_Descripcion = descripcion;
        }

        
      

        public override string ToString()
        {
            return String.Format("Codigo: {0}\nDescripcion: {1}", rol_Codigo, rol_Descripcion);
        }
    }
}
