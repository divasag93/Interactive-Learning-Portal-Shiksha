using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
namespace Interactive_Learning_Portal
{
    public partial class StudentProfile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["studentid"] == null)
                {
                    Response.Redirect("StudentLogin.aspx");
                }
                else
                {
                    SqlConnection cn = new SqlConnection();
                    cn.ConnectionString = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["cn"].ToString();
                    cn.Open();
                    string str = "select * from AddStudent where RollNo='" + Session["studentid"].ToString() + "'";
                    SqlCommand cmd = new SqlCommand(str, cn);
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        name.Value = dr[1].ToString();
                        rollno.Value = dr[2].ToString();
                        fname.Value = dr[3].ToString();
                        mname.Value = dr[4].ToString();

                        string[] st = dr[5].ToString().Split(' ');
                        dob.Value = st[0];

                        course.Value = dr[6].ToString();
                        branch.Value = dr[7].ToString();
                        batch.Value = dr[8].ToString();
                        pno.Value = dr[9].ToString();
                        email.Value = dr[10].ToString();
                        address.Text = dr[11].ToString();
                        semester.Value = dr[12].ToString();
                    }
                    cn.Close();
                }
            }
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Session.Remove("studentid");
            Session.RemoveAll();
            Response.Redirect("StudentLogin.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection cn = new SqlConnection();
                cn.ConnectionString = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["cn"].ToString();
                cn.Open();
                string str = "update AddStudent set Pno=@pno,Address=@address where RollNo='" + Session["studentid"].ToString() + "'";
                SqlCommand cmd = new SqlCommand(str, cn);
                SqlParameter p1 = new SqlParameter("pno", pno.Value);
                SqlParameter p2 = new SqlParameter("address", address.Text);
                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);
                cmd.ExecuteNonQuery();
                cn.Close();
            }
            catch(Exception e1)
            {
                
            }
        }
    }
}