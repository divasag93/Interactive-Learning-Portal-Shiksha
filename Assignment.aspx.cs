using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.IO;
namespace Interactive_Learning_Portal
{
    public partial class Assignment : System.Web.UI.Page
    {
        returnbrsem r = new returnbrsem();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["studentid"] == null)
            {
                Response.Redirect("StudentLogin.aspx");
            }
            else
            {
               
                string s=r.brsem(Session["studentid"].ToString());
                string[] ss = s.Split('.');
                SqlConnection cn = new SqlConnection();
                cn.ConnectionString = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["cn"].ToString();
                cn.Open();
                string str = "select * from Assignment where(Branch='"+ss[0]+"'and Semester='"+ss[1]+"') order by Aid asc";
                SqlCommand cmd = new SqlCommand(str, cn);
                    SqlDataReader dr = cmd.ExecuteReader();
                    ass.Controls.Add(new LiteralControl("<table class='table table-striped'><thead><tr><th>Assignment No.</th><th>Due Date</th><th>Assignment</th></tr></thead><tbody>"));
                    while (dr.Read())
                    {
                        string[] dt = dr[2].ToString().Split(' ');
                        
                        string s1 = Server.MapPath("Shiksha" + "\\" + ss[0] + "\\" + ss[1] + "\\Assignments");
                        DirectoryInfo di = new DirectoryInfo(s1);
            FileInfo[] fi = di.GetFiles();

            foreach (FileInfo ff in fi)
            {
                LinkButton l = new LinkButton();
                l.Text = ff.Name;
                l.CommandName = ff.Name;
                
                ass.Controls.Add(new LiteralControl("<tr><td>" + dr[1].ToString() + "</td><td>" + dt[0] + "</td><td>"));
                ass.Controls.Add(l);
                ass.Controls.Add(new LiteralControl("</td></tr>"));
                l.Click += new EventHandler(MyClick);
            }
                    }
                    ass.Controls.Add(new LiteralControl("</tbody></table>"));
                    cn.Close();
            }
        }
        protected void MyClick(object sender, EventArgs e)
        {
            LinkButton l = (LinkButton)sender;
            string s = r.brsem(Session["studentid"].ToString());
            string[] ss = s.Split('.');
            String str1 =  Server.MapPath("Shiksha" + "\\" + ss[0] + "\\" + ss[1] + "\\Assignments"+"\\"+l.CommandName);
            FileStream fs = new FileStream(str1, FileMode.Open, FileAccess.Read);
            byte[] bb = new byte[fs.Length];
            fs.Read(bb, 0, bb.Length);
            Response.AddHeader("content-disposition", "attachment;filename=" + l.CommandName);
            Response.BinaryWrite(bb);



        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Session.Remove("studentid");
            Session.RemoveAll();
            Response.Redirect("StudentLogin.aspx");

        }
    }
}