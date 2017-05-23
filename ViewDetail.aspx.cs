using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
namespace Interactive_Learning_Portal
{
    public partial class ViewDetail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["uid"] == null)
            {
                Response.Redirect("AdminLogin.aspx");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["cn"].ToString();
            if (details.Value == "Student")
            {
                
                SqlCommand cmd = new SqlCommand("select * from AddStudent order by Sid desc", cn);
                DataSet ds = new DataSet();
                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                SqlCommandBuilder cmdb = new SqlCommandBuilder(ad);
                ad.Fill(ds);
                detail.Controls.Add(new LiteralControl("<table class='table table-striped'><thead><tr><th>Name</th><th>Roll No.</th><th>Father Name</th><th>Mother Name</th><th>Date of Birth</th><th>Course</th><th>Branch</th><th>Batch</th><th>Phone No.</th><th>E-mail</th><th>Address</th><th>Semester</th><th>Password</th></tr></thead><tbody>"));
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    string[] dt = dr[5].ToString().Split(' ');
                    detail.Controls.Add(new LiteralControl("<tr><td>" + dr[1].ToString() + "</td><td>" + dr[2].ToString() + "</td><td>" + dr[3].ToString() + "</td><td>" + dr[4].ToString() + "</td><td>" + dt[0] + "</td><td>" + dr[6].ToString() + "</td><td>" + dr[7].ToString() + "</td><td>" + dr[8].ToString() + "</td><td>" + dr[9].ToString() + "</td><td>" + dr[10].ToString() + "</td><td>" + dr[11].ToString() + "</td><td>" + dr[12].ToString() + "</td><td>" + dr[13].ToString() + "</td></tr>"));
                }
                detail.Controls.Add(new LiteralControl("</tbody></table>"));
                cn.Close();
            }else if(details.Value=="Teacher")
            {
                SqlCommand cmd = new SqlCommand("select * from AddTeacher order by Tid desc", cn);
                DataSet ds = new DataSet();
                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                SqlCommandBuilder cmdb = new SqlCommandBuilder(ad);
                ad.Fill(ds);
                detail.Controls.Add(new LiteralControl("<table class='table table-striped'><thead><tr><th>Teacher ID</th><th>Name</th><th>Phone No.</th><th>Department</th><th>Password</th></tr></thead><tbody>"));
                foreach (DataRow dr in ds.Tables[0].Rows)
                {

                    detail.Controls.Add(new LiteralControl("<tr><td>" + dr[1].ToString() + "</td><td>" + dr[2].ToString() + "</td><td>" + dr[3].ToString() + "</td><td>" + dr[4].ToString() + "</td><td>" + dr[5].ToString() + "</td></tr>"));
                }
                detail.Controls.Add(new LiteralControl("</tbody></table>"));
                cn.Close();
            }
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Session.Remove("uid");
            Session.RemoveAll();
            Response.Redirect("AdminLogin.aspx");
        }
    }
}