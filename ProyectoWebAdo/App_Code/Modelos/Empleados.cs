using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoWebAdo.Modelos
{
    public class Empleados
    {
        //EMP_NO,APELLIDO,OFICIO,SALARIO,COMISION
        public int empleadono { get; set; }
        public int salario { get; set; }
        public int comision { get; set; }
        public String apellido { get; set; }
        public String oficio { get; set; }


        public Empleados()
        {

        }
    }
}