using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
#region proc almacenados
/*
 * CREATE PROCEDURE CARGARDEPARTAMENTOS
AS
	SELECT DISTINCT DNOMBRE,DEPT_NO FROM DEPT
GO
EXEC 
ALTER PROCEDURE CARGAREMPLEADOS(@DEPTNO INT)
AS
SELECT * FROM EMPLEADOS
WHERE DEPT_NO = @DEPTNO
GO
EXEC CARGAREMPLEADOS 20

CREATE VIEW VISTAEMPLEADOSPERSONASSUMA
AS
SELECT DEPT_NO, COUNT(EMP_NO)  AS NEMPLEADOS,SUM(SALARIO + COMISION) AS SUMASALARIO FROM EMPLEADOS GROUP BY DEPT_NO
GO


ALTER PROCEDURE EMPLEADOSPERSONASSUMA
(@DEPTNO INT)
AS 
 SELECT * FROM VISTAEMPLEADOSPERSONASSUMA
 WHERE DEPT_NO = @DEPTNO  
GO
EXEC EMPLEADOSPERSONASSUMA 10
 */
#endregion

namespace ProyectoWebAdo.Modelos
{
    public class ModeloSQLDepartamentosEmpleados
    {
        String cadenaconexion;
        SqlConnection cn;
        SqlCommand com;
        SqlDataAdapter adDeptEmp;
        DataSet ds;
        public ModeloSQLDepartamentosEmpleados()
        {
            this.cadenaconexion = ConfigurationManager.ConnectionStrings["tajamar"].ConnectionString;
            this.cn = new SqlConnection(this.cadenaconexion);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
            this.adDeptEmp = new SqlDataAdapter();
            this.ds = new DataSet();
        }

        public List<Departamentos> GetDepartamentos()
        {
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = "CARGARDEPARTAMENTOS";
            this.adDeptEmp.SelectCommand = this.com;
            this.adDeptEmp.Fill(this.ds, "DEPARTAMENTOS");
            this.com.Parameters.Clear();
            List<Departamentos> lista = new List<Departamentos>();
            foreach(DataRow d in this.ds.Tables["DEPARTAMENTOS"].Rows)
            {
                Departamentos dept = new Departamentos();
                dept.Deptno = int.Parse(d["DEPT_NO"].ToString());
                dept.Deptnombre = d["DNOMBRE"].ToString();
                lista.Add(dept);
            }
            return lista;
        }
        public List<Empleados> GetEmpleados()
        {
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = "CARGAREMPLEADOS";
            this.adDeptEmp.SelectCommand = this.com;
            this.adDeptEmp.Fill(this.ds, "EMPLEADOS");
            this.com.Parameters.Clear();
            List<Empleados> lista = new List<Empleados>();
            foreach (DataRow d in this.ds.Tables["EMPLEADOS"].Rows)
            {
                Empleados emp = new Empleados();
                emp.deptno = int.Parse(d["DEPT_NO"].ToString());
                emp.apellido = d["APELLIDO"].ToString();
                emp.comision = int.Parse(d["COMISION"].ToString());
                emp.empleadono = int.Parse(d["EMP_NO"].ToString());
                emp.oficio = d["OFICIO"].ToString();
                emp.salario = int.Parse(d["SALARIO"].ToString());                
                lista.Add(emp);
            }
            return lista;
        }
    }
}

