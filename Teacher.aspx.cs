using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
namespace Interactive_Learning_Portal
{
    public partial class Teacher : System.Web.UI.Page
    {
        Email em = new Email();
        returnbrsem ret = new returnbrsem();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["teacherid"] == null)
            {
                Response.Redirect("TeacherLogin.aspx");
            }
            alert.Visible = false;
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Session.Remove("teacherid");
            Session.RemoveAll();
            Response.Redirect("TeacherLogin.aspx");
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Response.Redirect("UploadMaterial.aspx");
        }

       

        protected void LinkButton4_Click(object sender, EventArgs e)
        {
            Response.Redirect("Result.aspx");

        }




        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection cn = new SqlConnection();
                cn.ConnectionString = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["cn"].ToString();
                cn.Open();
                string str = "update AddTeacher set Password=@pass where TeacherId='" + Session["teacherid"].ToString() + "'";
                SqlCommand cmd = new SqlCommand(str, cn);
                if (newpass.Value == confirmpass.Value)
                {
                    SqlParameter p1 = new SqlParameter("pass", newpass.Value);
                    cmd.Parameters.Add(p1);
                }
                em.send_maill(ret.name(Session["teacherid"].ToString()), ret.email(Session["teacherid"].ToString()), 2, newpass.Value);
                cmd.ExecuteNonQuery();
                cn.Close();
            }
            catch (Exception e1)
            {

                alert.Visible = true;
                Label2.Text = "You entered the incorrect password";

            }
        }



        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            Response.Redirect("QuizUpload.aspx");
        }

       
    }
}