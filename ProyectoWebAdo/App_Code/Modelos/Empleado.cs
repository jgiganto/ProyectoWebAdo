using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoWebAdo.Modelos
{
    public class Empleado
    {
        public int EmpleadoNumero { get; set; }
        public String Apellido { get; set; }
        public String Oficio { get; set; }
        public String Departamento { get; set; }
        public String Localidad { get; set; }
        public int Salario { get; set; }

        public Empleado()
        {
            
        }
    }
}