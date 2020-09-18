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
            Session["CK"] = txtCK.Text;
            Session["L"] = txtL.Text;
            Session["TD"] = txtTD.Text;

            if (Convert.ToDouble(txtCK.Text) < 11000)
            {
                ServiceEsfuerzo oEsfuerzo = new ServiceEsfuerzo();
                txtResultado.Text = oEsfuerzo.Calcular().ToString();
            }
            else
            {
                txtResultado.Text = "El campo CK no puede superar 11000!";
            }

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}