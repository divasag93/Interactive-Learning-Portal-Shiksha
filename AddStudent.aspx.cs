using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
namespace Interactive_Learning_Portal
{
    public partial class AddStudent : System.Web.UI.Page
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
                string str = "insert into AddStudent(Name,RollNo,FName,MName,DOB,Course,Branch,Batch,Pno,Email,Address,Semester,Password) values(@name,@rollno,@fname,@mname,@dob,@course,@branch,@batch,@pno,@email,@address,@semester,@password)";
                SqlCommand cmd = new SqlCommand(str, cn);
                SqlParameter p1 = new SqlParameter("name", name.Value);
                
                SqlParameter p3 = new SqlParameter("fname", fname.Value);
                SqlParameter p4 = new SqlParameter("mname", mname.Value);
                SqlParameter p5 = new SqlParameter("dob", dob.Value);
                SqlParameter p6 = new SqlParameter("course", course.Value);
                SqlParameter p7 = new SqlParameter("branch", branch.Value);
                SqlParameter p8 = new SqlParameter("batch", batch.Value);
                
                
                SqlParameter p11 = new SqlParameter("address", address.Text);
                
                cmd.Parameters.Add(p1);
                if (v.isrollnoexist(rollno.Value))
                {
                    alert.Visible = true;
                    Label2.Text = "OOPs! Roll number already exist";
                }
                else if(rollno.Value.Length==10)
                {
                    SqlParameter p2 = new SqlParameter("rollno", rollno.Value);
                    cmd.Parameters.Add(p2);
                }
                else
                {
                    alert.Visible = true;
                    Label2.Text = "Roll number is not in correct format it should be of length 10.";
                }
                cmd.Parameters.Add(p3);
                cmd.Parameters.Add(p4);
                cmd.Parameters.Add(p5);
                cmd.Parameters.Add(p6);
                cmd.Parameters.Add(p7);
                cmd.Parameters.Add(p8);
                if (v.ispnoexist(pno.Value))
                {
                    alert.Visible = true;
                    Label2.Text = "OOPs! Phone number already exist";
                }
                else
                {
                    SqlParameter p9 = new SqlParameter("pno", pno.Value);
                    cmd.Parameters.Add(p9);
                }
                if (!v.isinStudent(email.Value))
                {
                    SqlParameter p10 = new SqlParameter("email", email.Value);
                    cmd.Parameters.Add(p10);
                }
                else
                {
                    alert.Visible = true;
                    Label2.Text = "OOPs! E-mail address already exist";
                }
                cmd.Parameters.Add(p11);
                if (semester.Value == "Choose semester")
                {
                    alert.Visible = true;
                    Label2.Text = "Choose the semester of the student";
                }
                else
                {
                    SqlParameter p12 = new SqlParameter("semester", semester.Value);
                    cmd.Parameters.Add(p12);
                }
                cmd.Parameters.AddWithValue("password", rollno.Value);
                
                em.send_maill(ret.name(rollno.Value),ret.email(rollno.Value),1,rollno.Value);
                cmd.ExecuteNonQuery();
                cn.Close();
                alert1.Visible = true;
                Label1.Text = "Students details are successfully saved";
                name.Value = "";
                fname.Value = "";
                mname.Value = "";
                dob.Value = "";
                course.Value = "";
                
                batch.Value = "";
                address.Text = "";
                rollno.Value = "";
                pno.Value = "";
                email.Value = "";
                semester.Value = "";
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