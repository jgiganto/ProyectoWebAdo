using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProyectoWebAdo.Modelos;

public partial class Web04Hospitales : System.Web.UI.Page
{
    ModeloSQLEmpleadosHospital modelo;
    public Web04Hospitales()
    {
        modelo = new ModeloSQLEmpleadosHospital();
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if(this.Page.IsPostBack == false)
        {
            CargarHospitales();
        }

    }
    private void CargarHospitales()
    {
        this.lsthospitales.Items.Clear();
        List<Hospital> listahospitales = modelo.GetHospitales();
        foreach(Hospital hosp in listahospitales)
        {
            ListItem it = new ListItem();
            it.Text = hosp.Nombre;
            it.Value = hosp.Hospitalcod;
            this.lsthospitales.Items.Add(it);
        }
    }



    protected void lsthospitales_SelectedIndexChanged(object sender, EventArgs e)
    {
      
    }

    protected void btnverempleados_Click(object sender, EventArgs e)
    {
        String hospcod = this.lsthospitales.SelectedValue;
        List<EmpleadoHospital> listaempleados = modelo.GetEmpleados(hospcod);
       String html = "<table border ='1'>";
        foreach (EmpleadoHospital emp in listaempleados)
        {
            html += "<tr> ";
            html += "<td> " + emp.apellido + "</td>";
            html += "<td>" + emp.funcion + "</td>";
            html += "<td>" + emp.salario + "</td>";
            html += "</tr>";

        }
        html += "</table>";
        this.lbmostrartabla.Text = html;
    }

    protected void btnincrementar_Click(object sender, EventArgs e)
    {
        int incremento = int.Parse(this.txtincremento.Text);
       String hospcod = this.lsthospitales.SelectedValue;
      
        List<EmpleadoHospital> listaempleados = modelo.IncrementarSalario(hospcod,incremento);
        String html = "<table border ='1'>";
        foreach (EmpleadoHospital emp in listaempleados)
        {
            html += "<tr> ";
            html += "<td> " + emp.apellido + "</td>";
            html += "<td>" + emp.funcion + "</td>";
            html += "<td>" + emp.salario + "</td>";
            html += "</tr>";

        }
        html += "</table>";
        this.lbmostrartabla.Text = html;
    }

}


