using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Cart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblBrand.Text = (string)Session["Brand"];
            lblQuantity.Text = (string)Session["QuanTity"];
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/FinalDisplay.aspx");
        }
    }
}