using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
namespace Interactive_Learning_Portal
{
    public partial class TeacherLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            alert.Visible = false;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["cn"].ToString();
            cn.Open();
            string str = "select * from AddTeacher where TeacherId='" + username.Value + "' and Password='" + password.Value + "'";
            SqlCommand cmd = new SqlCommand(str, cn);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Session["teacherid"] = username.Value;
                Response.Redirect("Teacher.aspx");
            }
            else
            {
                alert.Visible = true;
                Label1.Text = "OOPs! Check your Username & Password";

            }

            cn.Close();
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Session["user"] = "AddTeacher";
            Response.Redirect("ForgotPassword.aspx");
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Response.Redirect("SignUpTeacher.aspx");
        }
    }
}