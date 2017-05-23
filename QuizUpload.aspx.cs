using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
namespace Interactive_Learning_Portal
{
    public partial class QuizUpload : System.Web.UI.Page
    {
        static int count = 0;
        static string br, sem,sub;
        string a, b,c;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["teacherid"] == null)
            {
                Response.Redirect("TeacherLogin.aspx");
            }
            a = branch2.Value;
            b = semester2.Value;
            c = subject.Value;
            alert.Visible = false;
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "$('#UQuiz').modal({ backdrop: 'static' })", true);
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Session.Remove("teacherid");
            Session.RemoveAll();
            Response.Redirect("AdminLogin.aspx");
        }
        protected void ututorial_Click1(object sender, EventArgs e)
        {
            br = branch2.Value;
            sem = semester2.Value;
            sub = subject.Value;
            UQuiz.Visible = false;
            //Response.Redirect("QuizUpload.aspx?br=" + branch2.Value + "?sem=" + semester2.Value + "");
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (count < 10)
                {
                    SqlConnection cn = new SqlConnection();
                    cn.ConnectionString = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["cn"].ToString();
                    cn.Open();
                    string str = "insert into QuizQuestion(Question,Option1,Option2,Option3,Option4,CA,Branch,Semester,Subject) values(@question,@option1,@option2,@option3,@option4,@ca,@branch,@semester,@subject)";
                    SqlCommand cmd = new SqlCommand(str, cn);
                    SqlParameter p1 = new SqlParameter("question", question.Value);
                    SqlParameter p2 = new SqlParameter("option1", ans1.Value);
                    SqlParameter p3 = new SqlParameter("option2", ans2.Value);
                    SqlParameter p4 = new SqlParameter("option3", ans3.Value);
                    SqlParameter p5 = new SqlParameter("option4", ans4.Value);

                    SqlParameter p7 = new SqlParameter("branch", a);
                    SqlParameter p8 = new SqlParameter("semester", b);
                    SqlParameter p9 = new SqlParameter("subject", c);
                    cmd.Parameters.Add(p1);
                    cmd.Parameters.Add(p2);
                    cmd.Parameters.Add(p3);
                    cmd.Parameters.Add(p4);
                    cmd.Parameters.Add(p5);

                    SqlParameter p6 = new SqlParameter("ca", ca.Value);
                    cmd.Parameters.Add(p6);


                    cmd.Parameters.Add(p7);
                    cmd.Parameters.Add(p8);
                    cmd.Parameters.Add(p9);
                    cmd.ExecuteNonQuery();
                    cn.Close();
                    count++;
                }
                else
                {
                    Response.Redirect("Teacher.aspx");
                }
            }
            catch(Exception e1)
            {
                
                
            }
        }
      
    }
}