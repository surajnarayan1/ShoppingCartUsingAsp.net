﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class FontPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["Name"] = textName.Text;
            Session["Email-Id"] = textEmail.Text;
            Response.Redirect("~/ItemsForm.aspx");
        }

        protected void Unnamed1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}