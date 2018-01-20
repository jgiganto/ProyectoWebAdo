using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProyectoWebAdo.Modelos;

public partial class WebAdo_Web07DepartamentosEmpleados : System.Web.UI.Page
{
    ModeloSQLDepartamentosEmpleados modelo;
    public WebAdo_Web07DepartamentosEmpleados()
    {
        modelo = new ModeloSQLDepartamentosEmpleados();
    }
    protected void Page_Load(object sender, EventArgs e)
    {
       
        if (this.Page.IsPostBack == false)
        {
            List<Departamentos> departamentos = modelo.GetDepartamentos();
            this.DibujarDepartamentos(departamentos);
        }
        if (Request.Form["departamentos"] != null)
        {
            String depno = Request.Form["departamentos"];
            this.lblpruebas.Text = depno.ToString();
            //int numerodep = int.Parse(depno);
            List<Empleados> lista = modelo.GetEmpleados(depno);
            Empleados perssuma = modelo.NPersonasSumaSalarial(depno);
            this.DibujarEmpleados(lista);
            this.DibujarPersonasSuma(perssuma);
            
            
        }
        
    }
    
    public void DibujarDepartamentos(List<Departamentos> dep)
    {
        String html = "<form  >";//method='post'
        html += "<select name='departamentos' multiple size='7' >";
        foreach (Departamentos d in dep)
        {
            html += "<option value='"+d.Deptno+"' >"+d.Deptnombre+ "</option>";
            html += "";
            html += "";
        }
        html += "</select>";
        html += "</br></br></br>";
        html += "<button type='submit' >Mostrar datos</button>";// sin tb esto funciona ok : value='Submit' onclick='submit' runat='server' Web07DepartamentosEmpleados.aspx
        html += "</form>";
        this.lblDepartamentos.Text = html;
    }
    public void DibujarEmpleados(List<Empleados> emp)
    {
        if (emp == null)
        { lblEmpleados.Text = "<h1>NULL</h1>"; }
        else
        {
            String html = "<table>";
            html += "<tr>";
            html += "<th>APELLIDO</th><th>OFICIO</th><th>DEPNO</th><th>SALARIO</th><th>COMISION</th>";
            html += "</tr>";
            foreach (Empleados e in emp)
            {
                html += "<tr>";
                html += "<td>" + e.apellido + "</td><td>" + e.oficio + "</td><td>" + e.deptno + "</td> <td>"
                    + e.salario + "</td> <td>" + e.comision + "</td>";
                    
                html += "</tr>";
            }
            html += "</table>";
            lblEmpleados.Text = html;
        }
    }

    public void DibujarPersonasSuma(Empleados persu)
    {
        lbcontrol.Text = "";
        lbnumeropersonas.Text = "";
        lbsumasalarial.Text = "";

        if (persu == null)
        {
            lbcontrol.Text = "<h2>No hay empleados para este departamento</h2>";
        }
        else
        {
            lbnumeropersonas.Text = "<h2>" + persu.numeroempleados + "</h2>";
            lbsumasalarial.Text = "<h2>" + persu.sumasalarial + "</h2>";
        }
    }



}

/*


*/
