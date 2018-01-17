using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
#region pro almacenados
/*CREATE PROCEDURE CARGAROFICIOS
AS
select DISTINCT OFICIO from emp
GO
CREATE VIEW VISTAEMPLEADOS
AS
SELECT EMP_NO,APELLIDO,OFICIO,SALARIO,COMISION FROM EMP
GO
 
 CREATE PROCEDURE CARGAREMPLEADOS
 AS
 SELECT * FROM VISTAEMPLEADOS
 GO

 EXEC CARGAROFICIOS
 
     */
#endregion

namespace ProyectoWebAdo.Modelos
{
    public class ModeloSQLEmpleadosOficio
    {
        String cadenaconexion;
        SqlConnection cn;
        SqlCommand com;
        SqlDataAdapter ademp;
        DataSet ds;
        public ModeloSQLEmpleadosOficio()
        {
            this.cadenaconexion = ConfigurationManager.ConnectionStrings["casa"].ConnectionString;
            this.cn = new SqlConnection(this.cadenaconexion);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
            this.ademp = new SqlDataAdapter();
            this.ds = new DataSet();
        }

        public List<Empleados> GetOficios()
        {
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = "CARGAROFICIOS";
            this.ademp.SelectCommand = this.com;
            this.ademp.Fill(this.ds, "OFICIOS");
            List<Empleados> lista = new List<Empleados>();
            foreach (DataRow f in this.ds.Tables["OFICIOS"].Rows)
            {
                Empleados oficios = new Empleados();
                oficios.oficio = f["OFICIO"].ToString();
                lista.Add(oficios);
            }
            return lista;
        }
        public List<Empleados> GetListaEmpleados()
        {
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = "CARGAREMPLEADOS";
            this.ademp.SelectCommand = this.com;
            this.ademp.Fill(this.ds, "LISTAEMPLEADOS");
            List<Empleados> lista = new List<Empleados>();
            foreach (DataRow f in this.ds.Tables["LISTAEMPLEADOS"].Rows)
            {
                Empleados oficios = new Empleados();

                oficios.empleadono = int.Parse(f["EMP_NO"].ToString());
                oficios.apellido = f["APELLIDO"].ToString();
                oficios.oficio = f["OFICIO"].ToString();
                oficios.salario = int.Parse(f["SALARIO"].ToString());
                oficios.comision = int.Parse(f["COMISION"].ToString());
                //EMP_NO,APELLIDO,OFICIO,SALARIO,COMISION
                lista.Add(oficios);
            }
            return lista;
        }
    }
}