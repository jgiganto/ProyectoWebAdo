using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProyectoWebAdo.Modelos;
using System.Collections.Specialized;


public partial class Web05OficiosEmpleados : System.Web.UI.Page
{
    ModeloSQLEmpleadosOficio modelo;
    public Web05OficiosEmpleados()
    {
        modelo = new ModeloSQLEmpleadosOficio();
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        //////
        String empno = Request.QueryString["empleadono"];
        if (empno != null)
        {
            // txtoficio.Text = empno;
            int empnum = int.Parse(empno.ToString());
            Empleados emp = modelo.CargarEmpleado(empnum);
            this.txtcomision.Text = emp.comision.ToString();
            this.txtempno.Text = emp.empleadono.ToString();
            this.txtoficio.Text = emp.oficio.ToString();
            this.txtsalario.Text = emp.salario.ToString();
        }
        
     
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
            it.Value = e.oficio.ToString();
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

            foreach (Empleados emp in lista)//<a href="Web05OficiosEmpleados.aspx?a=hola" >prueba</a>
            {
                html += "<tr>";
                html += "<td><a href='Web05OficiosEmpleados.aspx?empleadono="+emp.empleadono+"'>" + emp.apellido + "</a></td>";
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

    protected void btnfiltrar_Click(object sender, EventArgs e)
    {
      
        String oficio = this.lstoficios.SelectedValue;
        List<Empleados> lista = modelo.SeleccionarOficio(oficio);

        if (lista == null)
        {
            this.lblempleados.Text = "< h2 style = 'color:red' > No existen empleados con ese oficio</ h1 >";
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
                html += "<td><a href='Web05OficiosEmpleados.aspx?empleadono=" + emp.empleadono + "'>" + emp.apellido + "</a></td>";
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