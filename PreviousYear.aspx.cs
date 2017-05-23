using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.IO;
namespace Interactive_Learning_Portal
{
    public partial class PreviousYear : System.Web.UI.Page
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

                string s = r.brsem(Session["studentid"].ToString());
                string[] ss = s.Split('.');
                SqlConnection cn = new SqlConnection();
                cn.ConnectionString = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["cn"].ToString();
                cn.Open();
                string str = "select * from AddStudent where(Branch='" + ss[0] + "'and Semester='" + ss[1] + "'and RollNo='" + Session["studentid"].ToString() + "') order by Sid asc";
                SqlCommand cmd = new SqlCommand(str, cn);
                SqlDataReader dr = cmd.ExecuteReader();
                
                while (dr.Read())
                {
                    string s1 = Server.MapPath("Shiksha" + "\\" + ss[0] + "\\" + ss[1] + "\\PreviousYearQuestion");
                        DirectoryInfo di = new DirectoryInfo(s1);
            FileInfo[] fi = di.GetFiles();

            foreach (FileInfo ff in fi)
            {
                LinkButton l = new LinkButton();
                l.Text = ff.Name;
                l.CommandName = ff.Name;
                ass.Controls.Add(l);
                ass.Controls.Add(new LiteralControl("<br>"));
                l.Click += new EventHandler(MyClick);
            }
                }
                cn.Close();
            }
        }
        protected void MyClick(object sender, EventArgs e)
        {
            LinkButton l = (LinkButton)sender;
            string s = r.brsem(Session["studentid"].ToString());
            string[] ss = s.Split('.');
            String str1 = Server.MapPath("Shiksha" + "\\" + ss[0] + "\\" + ss[1] + "\\PreviousYearQuestion" + "\\" + l.CommandName);
            FileStream fs = new FileStream(str1, FileMode.Open, FileAccess.Read);
            byte[] bb = new byte[fs.Length];
            fs.Read(bb, 0, bb.Length);
            Response.AddHeader("content-disposition", "attachment;filename=" + l.CommandName);
            Response.BinaryWrite(bb);



        }
    }
}