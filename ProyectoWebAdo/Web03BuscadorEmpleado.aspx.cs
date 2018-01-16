using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProyectoWebAdo.Modelos;

public partial class Web03BuscadorEmpleado : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnbuscar_Click(object sender, EventArgs e)
    {
        ModeloSQLEMpleados modelo = new ModeloSQLEMpleados();
        String apellido = this.txtapellido.Text;
        List<Empleado> lista = modelo.BuscarEmpleados(apellido);
        if(lista == null)
        {
            this.lbldatos.Text = "<h2> no existe: " + apellido + "</h2>";

        }
        else
        {
            String html = "<table border ='1'>";
            foreach (Empleado emp in lista) {
                html += "<tr> ";
                html += "<td> " + emp.Apellido + "</td>";
                html += "<td>"+ emp .Oficio+ "</td>";
                html += "<td>" + emp.Salario+ "</td>";
                html += "<td>" + emp.Departamento + "</td>";
                html += "<td>" + emp.Localidad+ "</td>";
                html += "</tr>";
            }
            html += "</table>";
            lbldatos.Text = html;
        }
    }
}