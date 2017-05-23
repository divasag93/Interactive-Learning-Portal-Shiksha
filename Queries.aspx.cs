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
    public partial class Queries : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["uid"] == null)
            {
                Response.Redirect("AdminLogin.aspx");
            }
            else
            {
                SqlConnection cn = new SqlConnection();
                cn.ConnectionString = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["cn"].ToString();
                SqlCommand cmd = new SqlCommand("select * from Contact order by Cid desc", cn);
                DataSet ds = new DataSet();
                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                SqlCommandBuilder cmdb = new SqlCommandBuilder(ad);
                ad.Fill(ds);
                query.Controls.Add(new LiteralControl("<table class='table table-striped'><thead><tr><th>Name</th><th>Email Id</th><th>Phone Number</th><th>Subject</th><th>Query</th></tr></thead><tbody>"));
                foreach (DataRow dr in ds.Tables[0].Rows)
                {

                    query.Controls.Add(new LiteralControl("<tr><td>" + dr[1].ToString() + "</td><td>" + dr[2].ToString() + "</td><td>" + dr[3].ToString() + "</td><td>" + dr[4].ToString() + "</td><td>" + dr[5].ToString() + "</td></tr>"));
                }
                query.Controls.Add(new LiteralControl("</tbody></table>"));
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