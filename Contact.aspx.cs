using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
namespace Interactive_Learning_Portal
{
    public partial class Contact : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            alert1.Visible = false;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection cn = new SqlConnection();
                cn.ConnectionString = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["cn"].ToString();
                cn.Open();
                string str = "insert into Contact(CName,CEmail,CPno,Subject,Comment) values(@cname,@cemail,@cpno,@subject,@comment)";
                SqlCommand cmd = new SqlCommand(str, cn);

                SqlParameter p1 = new SqlParameter("cname", name.Value);
                SqlParameter p2 = new SqlParameter("cemail", email.Value);
                SqlParameter p3 = new SqlParameter("cpno", pno.Value);
                SqlParameter p4 = new SqlParameter("subject", subject.Value);
                SqlParameter p5 = new SqlParameter("comment", message.Value);
                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);
                cmd.Parameters.Add(p3);
                cmd.Parameters.Add(p4);
                cmd.Parameters.Add(p5);
                

                cmd.ExecuteNonQuery();
                cn.Close();
                alert1.Visible = true;
                Label1.Text = "Thanks for your concern. Wait for the reply";
                name.Value = "";
                email.Value = "";
                pno.Value = "";
                subject.Value = "";
                message.Value = "";

            }
            catch (Exception e1)
            {

            }
        }
    }
}