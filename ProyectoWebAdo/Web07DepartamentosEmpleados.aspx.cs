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
    }
    
    public void DibujarDepartamentos(List<Departamentos> dep)
    {
        String html = "<form>";
        html += "<select name='departamentos' multiple size='7'>";
        foreach (Departamentos d in dep)
        {
            html += "<option value='"+d.Deptno+"' >"+d.Deptnombre+ "</option>";
            html += "";
            html += "";
        }
        html += "</select>";
        html += "</br></br></br>";
        html += "<button type='submit'>Mostrar datos</button>";
        html += "</form>";
        this.lblDepartamentos.Text = html;
    }

}

/*<form action="/action_page.php">
<select name="cars" multiple>
  <option value="volvo">Volvo</option>
  <option value="saab">Saab</option>
  <option value="opel">Opel</option>
  <option value="audi">Audi</option>
</select>

<button type='submit'>Mostrar datos</button>
</form>*/
