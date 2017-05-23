using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Interactive_Learning_Portal
{
    public partial class AdminLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            alert.Visible = false;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(username.Value=="admin"&&password.Value=="admin")
            {
                Session["uid"] = "admin";
                Response.Redirect("Admin.aspx");
            }
            else
            {
                alert.Visible = true;
                Label1.Text = "Oops! Check your Username & Password";
            }
        }
    }
}