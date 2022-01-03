using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ConsumirWSDemo
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSumar_Click(object sender, EventArgs e)
        {
            //Instancio el Web Services
            WSDemo.DemoSoapClient Servicio = new WSDemo.DemoSoapClient();

            //Esto es para visualizar el resultado
            lblResultado.Text = Servicio.Suma(int.Parse(txtNumero1.Text), int.Parse(txtNumero2.Text)).ToString();

        }
    }
}