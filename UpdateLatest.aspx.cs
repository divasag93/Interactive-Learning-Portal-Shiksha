using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
namespace Interactive_Learning_Portal
{
    public partial class UpdateLatest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["uid"] == null)
            {
                Response.Redirect("AdminLogin.aspx");
            }
            alert1.Visible = false;
        }
        protected void LinkButton7_Click(object sender, EventArgs e)
        {
            Session.Remove("uid");
            Session.RemoveAll();
            Response.Redirect("AdminLogin.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection cn = new SqlConnection();
                cn.ConnectionString = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["cn"].ToString();
                cn.Open();
                string str = "insert into Latest(Type,Msg) values(@type,@msg)";
                SqlCommand cmd = new SqlCommand(str, cn);
                cmd.Parameters.AddWithValue("type", "event");
                SqlParameter p1 = new SqlParameter("msg",events.Value);
                
                cmd.Parameters.Add(p1);
                cmd.ExecuteNonQuery();
                cn.Close();
                events.Value = "";
            }
            catch(Exception e1)
            {

            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection cn = new SqlConnection();
                cn.ConnectionString = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["cn"].ToString();
                cn.Open();
                string str = "insert into Latest(Type,Msg) values(@type,@msg)";
                SqlCommand cmd = new SqlCommand(str, cn);
                cmd.Parameters.AddWithValue("type", "news");
                SqlParameter p1 = new SqlParameter("msg", news.Value);

                cmd.Parameters.Add(p1);
                cmd.ExecuteNonQuery();
                cn.Close();
                news.Value = "";
            }
            catch (Exception e1)
            {

            }
 
        }

    }
}