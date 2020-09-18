using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            double n1 = 0;
            double n2 = 0;

            n1 = Convert.ToDouble(TextBox1.Text);
            n2 = Convert.ToDouble(TextBox2.Text);

            Service oServicio = new Service();
            double resultado = oServicio.Sumar(n1, n2);
            txtRes.Text = Convert.ToString(resultado);
            
        }
    }
}