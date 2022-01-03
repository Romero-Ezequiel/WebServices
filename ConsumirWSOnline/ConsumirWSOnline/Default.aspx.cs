using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ConsumirWSOnline
{
    public partial class Default : System.Web.UI.Page
    {

        WSOnline.CalculatorSoapClient WS = new WSOnline.CalculatorSoapClient();


        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //ACA OCUPO EL METODO DE SUMA DE SOAP y para visualizarlo en la etiqueta hay que parsearlo a string
            Label1.Text = WS.Add(Convert.ToInt32(TextBox1.Text), Convert.ToInt32(TextBox2.Text)).ToString();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Label1.Text = WS.Subtract(Convert.ToInt32(TextBox1.Text), Convert.ToInt32(TextBox2.Text)).ToString();

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Label1.Text = WS.Multiply(Convert.ToInt32(TextBox1.Text), Convert.ToInt32(TextBox2.Text)).ToString();

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Label1.Text = WS.Divide(Convert.ToInt32(TextBox1.Text), Convert.ToInt32(TextBox2.Text)).ToString();

        }
    }
}