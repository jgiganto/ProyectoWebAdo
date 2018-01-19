using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProyectoWebAdo.Modelos;
public partial class Web06SalasPlantilla : System.Web.UI.Page
{
    ModeloSQLSalasPlantilla modelo;
    public Web06SalasPlantilla()
    {
        modelo = new ModeloSQLSalasPlantilla();
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        String salacod = Request.QueryString["salacod"];
        String empcod = Request.QueryString["empno"];

        if (this.Page.IsPostBack == false)
        {
            List<Salas> salas = modelo.GetSalas();
            this.DibujarSalas(salas);

        }
        //ELIMINA PLANTILLA
        if (empcod != null)
        {
            this.modelo.BorrarEmpleado(empcod);
        }

        //DIBUJAR PLANTILLA
        if (salacod != null)
        {
           
            List<Plantilla> emp = modelo.GetPlantilla(salacod);
            
            this.DibujarPlantilla(emp);
        }
       
       
    }
   
    public void DibujarSalas(List<Salas> sala)
    {
        String html = "<table>";
        html += "<tr>";
        html += "<th>SALAS</th>";
        html += "</tr>";
        foreach (Salas s in sala)
        {
            html += "<tr>";
           html += " <td><a href ='Web06SalasPlantilla.aspx?salacod=" + s.Salacod + "' > " + s.Nombre + " </ a ></ td > ";
            html += "</tr>";
        }
        html += "</table>";
        lblsalas.Text = html;
    }

    public void DibujarPlantilla(List<Plantilla> emp)
    {
        if (emp == null)
        { lblplantilla.Text = "<h2>No hay plantilla para esta Sala</h2>"; }
        else
        {
            String html = "<table>";
            html += "<tr>";
            html += "<th>APELLIDO</th><th>SALA_COD</th><th>FUNCION</th><th>SALARIO</th><th>EMPLEADO_NO</th>";
            html += "</tr>";
            foreach (Plantilla e in emp)
            {
                html += "<tr>";
                html += "<td>" + e.Apellido + "</td><td>" + e.Salacod + "</td><td>" + e.Funcion + "</td> <td>" 
                    + e.Salario + "</td> <td>" + e.empno + "</td>" 
                    + "<td><a href='Web06SalasPlantilla.aspx?empno=" + e.empno + "&salacod="+e.Salacod+"'>Eliminar</a></td>";
                html += "</tr>";
            }
            html += "</table>";
            lblplantilla.Text = html;
        }
    }

}








/*<table>
  <tr>
    <th>APELLIDO</th><th>SALA_COD</th><th>FUNCION</th><th>SALARIO</th><th>EMPLEADO_NO</th>
   
  </tr>
  <tr>
    <td>January</td><td>January</td><td>January</td> <td>January</td> <td>January</td>  
    
  </tr>
   
 
</table>*/
