using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProyectoWebAdo.Modelos;
public partial class Web02DatosEmpleados : System.Web.UI.Page
{
    ModeloSQLEMpleados modelo;
    public Web02DatosEmpleados()
    {
        modelo = new ModeloSQLEMpleados();
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if(this.Page.IsPostBack == false)
        {
            CargarEmpleados();
            //TODOS LOS DIBUJOS AL INICIO DE LA PAGINA
        }
    }
    private void CargarEmpleados()
    {
        this.lstempleados.Items.Clear();
        List<Empleado> lista = modelo.GetEmpleados();
        foreach(Empleado emp in lista)
        {
            ListItem it = new ListItem();
            it.Text = emp.Apellido;
            it.Value = emp.EmpleadoNumero.ToString();
            this.lstempleados.Items.Add(it);
        }
    }

    protected void btnmostrar_Click(object sender, EventArgs e)
    {
        int empno =
            int.Parse(this.lstempleados.SelectedValue);
        Empleado emp = modelo.BuscarEmpleado(empno);
        String html = "<dl>";
        html += "<dt>" + emp.Apellido + "</dt>";
        html += "<dd>Oficio " + emp.Oficio + "</dd>";
        html += "<dd>Salario " + emp.Salario + "</dd>";
        html += "<dd>Departamento " + emp.Departamento + "</dd>";
        html += "<dd>Localidad " + emp.Localidad + "</dd>";
        html += "</dl>";
        this.lbldatos.Text = html;
    }

//pruebadhhh
}