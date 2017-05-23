using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
namespace Interactive_Learning_Portal
{
    public partial class Admin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["uid"] == null)
            {
                Response.Redirect("AdminLogin.aspx");
            }
            alert1.Visible = false;
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddStudent.aspx");
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddTeacher.aspx");
        }

        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewDetail.aspx");
        }

        protected void LinkButton4_Click(object sender, EventArgs e)
        {
            Response.Redirect("Queries.aspx");
        }

        protected void LinkButton5_Click(object sender, EventArgs e)
        {
            Response.Redirect("Result.aspx");
        }

       
        protected void LinkButton7_Click(object sender, EventArgs e)
        {
            Session.Remove("uid");
            Session.RemoveAll();
            Response.Redirect("AdminLogin.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["cn"].ToString();
            cn.Open();
            string str = "Delete from QuizQuestion where Branch='" + branch2.Value + "'and Semester='" + semester2.Value + "'and Subject='" + subject.Value + "'";
            SqlCommand cmd = new SqlCommand(str, cn);
            cmd.ExecuteNonQuery();
            cn.Close();
            alert1.Visible = true;
            Label1.Text = "Quiz Questions of"+branch2.Value+" "+semester2.Value+" "+subject.Value+" has been deleted." ;
        }

        protected void LinkButton8_Click(object sender, EventArgs e)
        {
            Response.Redirect("UpdateLatest.aspx");
        }

    }
}