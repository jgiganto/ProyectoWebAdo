using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Web01PrimeraPagina : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //rellenamos el listbox
        
        //debemos comprobar siempre en el load, (y solamente aqui)
        //si es la primera vez que carga la pagina
        //se comprueba con ISPOSTBACK == FALSE (ha habido envio??)- si false es la primera vez
        if(this.Page.IsPostBack == false)
        {
            //cargamos los datos de la pagina para el dibujo inicial
            for (int i = 1; i <= 5; i++)
            {
                //los controles lista contienen ListItem(text, value)
                ListItem it = new ListItem();
                it.Text = "Texto: " + i;
                it.Value = "Valor: " + i;

                this.ListBox1.Items.Add(it);

            }
        }

        
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        String nombre = TextBox1.Text;
        //ASP NET PERMITE SALIDA HTML
        Label1.Text = "Su nombre es<h1>" + nombre + "</h1>";
    }
}