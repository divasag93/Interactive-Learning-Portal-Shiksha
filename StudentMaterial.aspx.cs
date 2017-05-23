using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Interactive_Learning_Portal
{
    public partial class StudentMaterial : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["studentid"] == null)
            {
                Response.Redirect("StudentLogin.aspx");
            }
           
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Session.Remove("studentid");
            Session.RemoveAll();
            Response.Redirect("StudentLogin.aspx");
        
        }
    }
}