using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

#region pro Almacenados
/*
 CREATE PROCEDURE HOSPITALES
AS
SELECT DISTINCT NOMBRE,HOSPITAL_COD FROM HOSPITAL
GO

ALTER PROCEDURE VEREMPLEADOS
(@HOSPITALCOD NVARCHAR(10))
AS 
SELECT APELLIDO,FUNCION,SALARIO
FROM PLANTILLA
WHERE HOSPITAL_COD = @HOSPITALCOD
union
SELECT APELLIDO,ESPECIALIDAD,SALARIO  
FROM DOCTOR
WHERE HOSPITAL_COD = @HOSPITALCOD
GO

EXEC VEREMPLEADOS 22

ALTER PROCEDURE MODIFICARSALARIO
(@HOSPITALCOD NVARCHAR(10),@INCREMENTO INT OUT)
AS 
 UPDATE DOCTOR 
 SET 
 SALARIO = SALARIO + @INCREMENTO
 WHERE HOSPITAL_COD = @HOSPITALCOD
 SELECT * FROM DOCTOR 
  UPDATE PLANTILLA 
 SET 
 SALARIO = SALARIO + @INCREMENTO
 WHERE HOSPITAL_COD = @HOSPITALCOD
 SELECT * FROM PLANTILLA
GO
     
     */
#endregion
namespace ProyectoWebAdo.Modelos
{
    public class ModeloSQLEmpleadosHospital
    {
        String cadenaconexion;
        SqlConnection cn;
        SqlCommand com;
        SqlDataAdapter ademp;
        DataSet ds;
        public ModeloSQLEmpleadosHospital()
        {
            this.cadenaconexion = ConfigurationManager.ConnectionStrings["tajamar"].ConnectionString;
            this.cn = new SqlConnection(this.cadenaconexion);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
            this.ademp = new SqlDataAdapter();
            this.ds = new DataSet();           
        }

        public List<Hospital> GetHospitales()
        {
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = "HOSPITALES";
            this.ademp.SelectCommand = this.com;
            this.ademp.Fill(this.ds, "HOSPITAL");
            List <Hospital> lista = new List<Hospital>();
            foreach(DataRow f in this.ds.Tables["HOSPITAL"].Rows)
            {
                Hospital hospital = new Hospital();
                hospital.Hospitalcod = f["HOSPITAL_COD"].ToString();
                hospital.Nombre = f["NOMBRE"].ToString();
                lista.Add(hospital);
            }
            return lista;
        }

        public List<EmpleadoHospital> GetEmpleados(String hospitalcod)
        {
            SqlParameter pamhospcod = new SqlParameter("@HOSPITALCOD", hospitalcod);
            this.com.Parameters.Add(pamhospcod);
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = "VEREMPLEADOS";
            this.ademp.SelectCommand = this.com;
            if (this.ds.Tables.Contains("EMPLEADOS"))
            {
                this.ds.Tables["EMPLEADOS"].Rows.Clear();
            }
            this.ademp.Fill(this.ds, "EMPLEADOS");
            this.com.Parameters.Clear();
            List<EmpleadoHospital> lista = new List<EmpleadoHospital>();
            foreach(DataRow f in this.ds.Tables["EMPLEADOS"].Rows)
            {
                EmpleadoHospital emp = new EmpleadoHospital();
                emp.apellido = f["APELLIDO"].ToString();
                emp.funcion = f["FUNCION"].ToString();
                emp.salario = int.Parse(f["SALARIO"].ToString());
                lista.Add(emp);
            }
            return lista;
        }

        public List<EmpleadoHospital> IncrementarSalario(String hospitalcod, int incremento)
        {
            SqlParameter pamhospcod = new SqlParameter("@HOSPITALCOD", hospitalcod);
            SqlParameter pamincremento = new SqlParameter("@INCREMENTO", incremento);
            this.com.Parameters.Add(pamhospcod);
            this.com.Parameters.Add(pamincremento);
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = "MODIFICARSALARIO";
            this.ademp.SelectCommand = this.com;
            if (this.ds.Tables.Contains("EMPLEADOS"))
            {
                this.ds.Tables["EMPLEADOS"].Rows.Clear();
            }
            this.ademp.Fill(this.ds, "EMPLEADOS");
            this.com.Parameters.Clear();
            SqlParameter pamhospcod2 = new SqlParameter("@HOSPITALCOD", hospitalcod);
            this.com.Parameters.Add(pamhospcod2);
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = "VEREMPLEADOS";
            this.ademp.SelectCommand = this.com;

            if (this.ds.Tables.Contains("EMPLEADOS"))
            {
                this.ds.Tables["EMPLEADOS"].Rows.Clear();
            }
            this.ademp.Fill(this.ds, "EMPLEADOS");
            this.com.Parameters.Clear();
            List<EmpleadoHospital> lista = new List<EmpleadoHospital>();
            foreach (DataRow f in this.ds.Tables["EMPLEADOS"].Rows)
            {
                EmpleadoHospital emp = new EmpleadoHospital();
                emp.apellido = f["APELLIDO"].ToString();
                emp.funcion = f["FUNCION"].ToString();
                emp.salario = int.Parse(f["SALARIO"].ToString());
                lista.Add(emp);
            }
            return lista;


        }


    }
}