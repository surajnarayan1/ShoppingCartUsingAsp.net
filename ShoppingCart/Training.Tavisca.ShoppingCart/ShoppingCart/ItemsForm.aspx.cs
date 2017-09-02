using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class ItemsForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblName.Text = (string)Session["Name"];
            lblEmail.Text = (string)Session["Email-Id"];
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
          
        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {




        }
        protected void ImageButton4_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            Session["QuanTity"] = TextBoxQuantity.Text;
            Session["Brand"] = TextBoxBrand.Text;
            Response.Redirect("~/Cart.aspx");

        }
    }
}