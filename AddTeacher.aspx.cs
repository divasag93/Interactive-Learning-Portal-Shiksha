using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
namespace Interactive_Learning_Portal
{
    public partial class AddTeacher : System.Web.UI.Page
    {
        Email em = new Email();
        returnbrsem ret = new returnbrsem();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["uid"] == null)
            {
                Response.Redirect("AdminLogin.aspx");
            }
            alert.Visible = false;
            alert1.Visible = false;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            validate v = new validate();
            try
            {
                SqlConnection cn = new SqlConnection();
                cn.ConnectionString = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["cn"].ToString();
                cn.Open();
                string str = "insert into AddTeacher(TeacherId,TName,TPno,Department,Password,TEmail) values(@tid,@tname,@tpno,@department,@password,@email)";
                SqlCommand cmd = new SqlCommand(str, cn);
                
                SqlParameter p2 = new SqlParameter("tname", tname.Value);

                SqlParameter p6 = new SqlParameter("email",email.Value);

                cmd.Parameters.Add(p6);

                if (v.istidexist(tid.Value))
                {
                    alert.Visible = true;
                    Label2.Text = "OOPs! Teacher ID already exist";
                }
                else if(tid.Value.Length==4)
                {
                    SqlParameter p1 = new SqlParameter("tid", department.Value+tid.Value);
                    cmd.Parameters.Add(p1);
                }
                else
                {
                    alert.Visible = true;
                    Label2.Text = "Teacher ID is not in correct format and it's length must be 4.";
                }
                cmd.Parameters.Add(p2);
                if (department.Value == "Choose Department")
                {
                    alert.Visible = true;
                    Label2.Text = "Choose the Department of the student";
                }
                else
                {
                    SqlParameter p4 = new SqlParameter("department", department.Value);
                    cmd.Parameters.Add(p4);
                }

                if (v.istpnoexist(tpno.Value))
                {
                    alert.Visible = true;
                    Label2.Text = "OOPs! Phone number already exist";
                }
                else
                {
                    SqlParameter p3 = new SqlParameter("tpno", tpno.Value);
                    cmd.Parameters.Add(p3);
                }
                SqlParameter p5 = new SqlParameter("password", department.Value + tid.Value);
                cmd.Parameters.Add(p5);
                em.send_maill(ret.tname(department.Value + tid.Value), ret.temail(department.Value + tid.Value), 1, department.Value + tid.Value);
                cmd.ExecuteNonQuery();
                cn.Close();
                alert1.Visible = true;
                Label1.Text = "Teacher details are successfully saved";
                tname.Value = "";
                tid.Value = "";
                department.Value = "";
                tpno.Value = "";
            }
            catch (Exception e1)
            {
               
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