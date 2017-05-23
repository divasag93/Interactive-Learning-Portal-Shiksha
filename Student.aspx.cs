using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
namespace Interactive_Learning_Portal
{
    public partial class Student : System.Web.UI.Page
    {
        Email em = new Email();
        returnbrsem ret = new returnbrsem();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["studentid"] == null)
            {
                Response.Redirect("StudentLogin.aspx");
            }
            alert.Visible = false;
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Session.Remove("studentid");
            Session.RemoveAll();
            Response.Redirect("StudentLogin.aspx");
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Response.Redirect("index.aspx");
        }

        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            Response.Redirect("StudentProfile.aspx");
        }

        protected void LinkButton4_Click(object sender, EventArgs e)
        {
            Response.Redirect("Subject_Quiz.aspx");
        }

        protected void LinkButton5_Click(object sender, EventArgs e)
        {
            Response.Redirect("PreviousResult.aspx");
        }

        protected void LinkButton6_Click(object sender, EventArgs e)
        {
            Response.Redirect("StudentMaterial.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection cn = new SqlConnection();
                cn.ConnectionString = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["cn"].ToString();
                cn.Open();
                string str = "update AddStudent set Password=@pass where RollNo='" + Session["studentid"].ToString() + "'";
                SqlCommand cmd = new SqlCommand(str, cn);
                if (newpass.Value == confirmpass.Value)
                {
                    SqlParameter p1 = new SqlParameter("pass", newpass.Value);
                    cmd.Parameters.Add(p1);
                }
                em.send_maill(ret.name(Session["studentid"].ToString()),ret.email(Session["studentid"].ToString()),2,newpass.Value);
                cmd.ExecuteNonQuery();
                cn.Close();
            }
            catch (Exception e1)
            {

                alert.Visible = true;
                Label2.Text = "You entered the incorrect password";

            }

        }
    }
}