using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
#region proc almacenados
/*
 CREATE PROCEDURE CARGARSALAS
AS
SELECT DISTINCT NOMBRE,SALA_COD FROM  SALA 
GO
CREATE PROCEDURE CARGARPLANTILLA
(@SALACOD NVARCHAR(30))
AS
SELECT * FROM PLANTILLA WHERE SALA_COD = @SALACOD
GO
CREATE PROCEDURE BORRAREMPLEADO(@EMPNO  NVARCHAR(20))
AS
DELETE FROM PLANTILLA
WHERE EMPLEADO_NO = @EMPNO
GO
     */
#endregion


namespace ProyectoWebAdo.Modelos
{
    public class ModeloSQLSalasPlantilla
    {
        String cadenaconexion;
        SqlConnection cn;
        SqlCommand com;
        SqlDataAdapter adsalaspla;         
        DataSet ds;
        public ModeloSQLSalasPlantilla()
        {
            this.cadenaconexion = ConfigurationManager.ConnectionStrings["tajamar"].ConnectionString;
            this.cn = new SqlConnection(this.cadenaconexion);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
            this.adsalaspla = new SqlDataAdapter();
            this.ds = new DataSet();
        }

        public List<Salas> GetSalas()
        {
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = "CARGARSALAS";
            this.adsalaspla.SelectCommand = this.com;
            this.adsalaspla.Fill(this.ds, "SALAS");
            this.com.Parameters.Clear();
            List<Salas> lista = new List<Salas>();
            foreach(DataRow f in this.ds.Tables["SALAS"].Rows)
            {
                Salas sala = new Salas();
                sala.Salacod = int.Parse(f["SALA_COD"].ToString());
                sala.Nombre = f["NOMBRE"].ToString();
                lista.Add(sala);
            }
            return lista;
        }
        public List<Plantilla> GetPlantilla(String salacod)
        {
            SqlParameter pamsala = new SqlParameter("@SALACOD", salacod);
            this.com.Parameters.Add(pamsala);
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = "CARGARPLANTILLA";
            this.adsalaspla.SelectCommand = this.com;
            this.adsalaspla.Fill(this.ds, "PLANTILLA");
            this.com.Parameters.Clear();
            if (this.ds.Tables["PLANTILLA"].Rows.Count == 0)
            {
                return null;
            }
            else
            {

                List<Plantilla> lista = new List<Plantilla>();
                foreach (DataRow f in this.ds.Tables["PLANTILLA"].Rows)
                {
                    Plantilla emp = new Plantilla();
                    emp.Apellido = f["APELLIDO"].ToString();
                    emp.Salacod = f["SALA_COD"].ToString();
                    emp.Funcion = f["FUNCION"].ToString();
                    emp.Salario = int.Parse(f["SALARIO"].ToString());
                    emp.empno = f["EMPLEADO_NO"].ToString();
                    lista.Add(emp);
                }
                return lista;
            }
          
        }

        public void BorrarEmpleado(String empno)
        {
            SqlParameter pamemp = new SqlParameter("@EMPNO",empno);
            this.com.Parameters.Add(pamemp);
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = "BORRAREMPLEADO";
            this.cn.Open();
            this.com.ExecuteNonQuery();
            this.cn.Close();
            this.com.Parameters.Clear();
        }
    }
}
//BORRAREMPLEADO(@EMPNO 
