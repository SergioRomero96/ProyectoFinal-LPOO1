using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Cliente
    {
        public Cliente(string dni, string nombre, string apellido, string sexo, DateTime fechaNac, decimal ingresos, string direccion, string telefono)
        {
            this.cli_Dni = dni;
            this.cli_Nombre = nombre;
            this.cli_Apellido = apellido;
            this.cli_Sexo = sexo;
            this.cli_FechaNacimiento = fechaNac;
            this.cli_Ingresos = ingresos;
            this.cli_Direccion = direccion;
            this.cli_Telefono = telefono;
        }

        private string cli_Dni;

        public string Cli_Dni
        {
            get { return cli_Dni; }
            set { cli_Dni = value; }
        }
        private string cli_Nombre;

        public string Cli_Nombre
        {
            get { return cli_Nombre; }
            set { cli_Nombre = value; }
        }
        private string cli_Apellido;

        public string Cli_Apellido
        {
            get { return cli_Apellido; }
            set { cli_Apellido = value; }
        }
        private string cli_Sexo;

        public string Cli_Sexo
        {
            get { return cli_Sexo; }
            set { cli_Sexo = value; }
        }
        private DateTime cli_FechaNacimiento;

        public DateTime Cli_FechaNacimiento
        {
            get { return cli_FechaNacimiento; }
            set { cli_FechaNacimiento = value; }
        }
        private decimal cli_Ingresos;

        public decimal Cli_Ingresos
        {
            get { return cli_Ingresos; }
            set { cli_Ingresos = value; }
        }
        private string cli_Direccion;

        public string Cli_Direccion
        {
            get { return cli_Direccion; }
            set { cli_Direccion = value; }
        }
        private string cli_Telefono;

        public string Cli_Telefono
        {
            get { return cli_Telefono; }
            set { cli_Telefono = value; }
        }

        public Cliente() { }

        

        public override string ToString()
        {
            return String.Format("DNI: {0}\nApellido: {1}\nNombre: {2}\nSexo: {3}\nFecha Nacimiento: {4}\nDireccion: {5}\nTelefono: {6}\nIngresos: {7}",cli_Dni, cli_Apellido,cli_Nombre,cli_Sexo,cli_FechaNacimiento.ToString(),cli_Direccion,cli_Telefono,cli_Ingresos);
        }
    }
}
