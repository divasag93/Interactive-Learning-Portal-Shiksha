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
    public partial class PreviousResult : System.Web.UI.Page
    {
        returnbrsem ret = new returnbrsem();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["studentid"] == null)
            {
                Response.Redirect("StudentLogin.aspx");
            }
            else
            {
                SqlConnection cn = new SqlConnection();
                cn.ConnectionString = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["cn"].ToString();
                SqlCommand cmd = new SqlCommand("select * from Result where Sid='"+Session["studentid"]+"' order by Rid desc", cn);
                DataSet ds = new DataSet();
                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                SqlCommandBuilder cmdb = new SqlCommandBuilder(ad);
                ad.Fill(ds);
                result.Controls.Add(new LiteralControl("<table class='table table-striped'><thead><tr><th>Roll No.</th><th>Name</th><th>Result</th><th>Date of Result</th></tr></thead><tbody>"));
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    string[] dt = dr[3].ToString().Split(' ');
                    result.Controls.Add(new LiteralControl("<tr><td>" + dr[1].ToString() + "</td><td>" + ret.name(dr[1].ToString()) + "</td><td>" + dr[2].ToString() + "</td><td>" + dt[0] + "</td></tr>"));
                }
                result.Controls.Add(new LiteralControl("</tbody></table>"));
                cn.Close();
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