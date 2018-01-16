using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
#region PROC ALMACENADOS
/*CREATE PROCEDURE MOSTRAREMPLEADOS
AS
SELECT EMP.EMP_NO,EMP.APELLIDO,EMP.OFICIO,EMP.SALARIO,DEPT.DNOMBRE,DEPT.LOC
FROM EMP
INNER JOIN DEPT
ON EMP.DEPT_NO = DEPT.DEPT_NO
GO

CREATE PROCEDURE BUSCAREMPLEADO
(@EMPNO INT)
AS
	SELECT EMP.EMP_NO,EMP.APELLIDO,EMP.OFICIO,EMP.SALARIO,DEPT.DNOMBRE,DEPT.LOC
	FROM EMP
	INNER JOIN DEPT
	ON EMP.DEPT_NO = DEPT.DEPT_NO
	WHERE EMP.EMP_NO = @EMPNO
GO*/
#endregion
namespace ProyectoWebAdo.Modelos
{
    public class ModeloSQLEMpleados
    {
        String cadenaconexion;
        SqlConnection cn;
        SqlCommand com;
        SqlDataAdapter ademp;
        DataSet ds;
        public ModeloSQLEMpleados()
        {
            this.cadenaconexion = ConfigurationManager.ConnectionStrings["tajamar"].ConnectionString;
            this.cn = new SqlConnection(this.cadenaconexion);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
            this.ademp = new SqlDataAdapter();
            this.ds = new DataSet();

        }
      
        public List<Empleado> GetEmpleados()
        {
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = "MOSTRAREMPLEADOS";
            this.ademp.SelectCommand = this.com;
            this.ademp.Fill(this.ds, "EMP");
            List<Empleado> lista = new List<Empleado>();
            foreach(DataRow f in this.ds.Tables["EMP"].Rows)
            {
                Empleado emp = new Empleado();
                emp.EmpleadoNumero = int.Parse(f["EMP_NO"].ToString());
                emp.Apellido = f["APELLIDO"].ToString();
                emp.Oficio = f["OFICIO"].ToString();
                emp.Salario = int.Parse(f["SALARIO"].ToString());
                emp.Departamento = f["DNOMBRE"].ToString();
                emp.Localidad = f["LOC"].ToString();
                lista.Add(emp);
                
            }
            return lista;
        }

        public Empleado BuscarEmpleado(int empno)
        {
            SqlParameter paemp = new SqlParameter("@EMPNO", empno);
            this.com.Parameters.Add(paemp);
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = "BUSCAREMPLEADO";
            this.ademp.SelectCommand = this.com;
            this.ademp.Fill(this.ds, "EMP");
            this.com.Parameters.Clear();
            DataRow f = this.ds.Tables["EMP"].Rows[0];
            Empleado emp = new Empleado();
            emp.EmpleadoNumero = int.Parse(f["EMP_NO"].ToString());
            emp.Apellido = f["APELLIDO"].ToString();
            emp.Oficio = f["OFICIO"].ToString();
            emp.Salario = int.Parse(f["SALARIO"].ToString());
            emp.Departamento = f["DNOMBRE"].ToString();
            emp.Localidad = f["LOC"].ToString();
            return emp;
        }
    }
}