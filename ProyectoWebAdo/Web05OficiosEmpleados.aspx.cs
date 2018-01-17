using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProyectoWebAdo.Modelos;

public partial class Web05OficiosEmpleados : System.Web.UI.Page
{
    ModeloSQLEmpleadosOficio modelo;
    public Web05OficiosEmpleados()
    {
        modelo = new ModeloSQLEmpleadosOficio();
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (this.Page.IsPostBack == false)
        {
            this.CargarOficios();
            this.CargarEmpleados();
        }

    }
    private void CargarOficios()
    {
        lstoficios.Items.Clear();
        List<Empleados> lista = modelo.GetOficios();
        foreach (Empleados e in lista)
        {
            ListItem it = new ListItem();
            it.Text = e.oficio;
            lstoficios.Items.Add(it);
        }
    }
    private void CargarEmpleados()
    {
        List<Empleados> lista = modelo.GetListaEmpleados();

        if (lista == null)
        {
            this.lblempleados.Text = "< h2 style = 'color:red' > No existen empleados</ h1 >";
        }
        else
        {
            String html = "<table>";
            html += "<thead>";
            html += "<tr> <th>APELLIDO</th> <th>OFICIO</th> <th>SALARIO</th> <th>COMISION</th> </tr>";
            html += " </thead>";
            html += "<tbody> ";

            foreach (Empleados emp in lista)
            {
                html += "<tr>";
                html += "<td>" + emp.apellido + "</td>";
                html += "<td>" + emp.oficio + "</td>";
                html += "<td>" + emp.salario.ToString() + "</td>";
                html += "<td>" + emp.comision.ToString() + "</td>";
                html += "</tr>";
            }
            html += "</tbody>";
            html += "</table>";
            this.lblempleados.Text = html;
        }
    }
}