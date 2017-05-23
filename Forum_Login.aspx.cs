using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
namespace Interactive_Learning_Portal
{
    public partial class Forum_Login : System.Web.UI.Page
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
            string str = "select * from AddStudent where RollNo='" + username.Value + "' and Password='" + password.Value + "'";
            string str1 = "select * from AddTeacher where TeacherId='" + username.Value + "' and Password='" + password.Value + "'";
            SqlCommand cmd = new SqlCommand(str, cn);
            
            SqlDataReader dr = cmd.ExecuteReader();
            
             
            if (dr.Read())
            {
                Session["fid"] = username.Value;
                Response.Redirect("Shiksha_Forum.aspx");
                
            }
            else
            {
                cmd.Dispose();
                dr.Close();
                alert.Visible = true;
                Label1.Text = "OOPs! Check your Username & Password";
            }
            SqlCommand cmd1 = new SqlCommand(str1, cn);
            SqlDataReader dr1 = cmd1.ExecuteReader();
            if(dr1.Read())
            {
                Session["fid"] = username.Value;
                Response.Redirect("Shiksha_Forum.aspx");
            }
                 
            else
            {
                alert.Visible = true;
                Label1.Text = "OOPs! Check your Username & Password";

            }

            cn.Close();
        }
    }
}