using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Usuario
    {
        private int usu_Id;

        public int Usu_Id
        {
            get { return usu_Id; }
            set { usu_Id = value; }
        }
        private string usu_NombreUsuario;

        public string Usu_NombreUsuario
        {
            get { return usu_NombreUsuario; }
            set { usu_NombreUsuario = value; }
        }
        private string usu_Apellido;

        public string Usu_Apellido
        {
            get { return usu_Apellido; }
            set { usu_Apellido = value; }
        }
        private string usu_Nombre;

        public string Usu_Nombre
        {
            get { return usu_Nombre; }
            set { usu_Nombre = value; }
        }
        private string usu_Password;

        public string Usu_Password
        {
            get { return usu_Password; }
            set { usu_Password = value; }
        }
        private int rol_Codigo;

        public int Rol_Codigo
        {
            get { return rol_Codigo; }
            set { rol_Codigo = value; }
        }

        public Usuario() { }

        public Usuario(string nombreUsuario, string password, int codigoRol) 
        {
            usu_NombreUsuario = nombreUsuario;
            usu_Password = password;
            rol_Codigo = codigoRol;
        }
    }
}
