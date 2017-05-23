using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
namespace Interactive_Learning_Portal
{
    public partial class Subject_Quiz : System.Web.UI.Page
    {
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
                    cn.Open();
                    string str = "select * from AddStudent where RollNo='" + Session["studentid"].ToString() + "'";
                    SqlCommand cmd = new SqlCommand(str, cn);
                    SqlDataReader dr = cmd.ExecuteReader();
               
                    if (dr.Read())
                    {
                        string branch = dr[7].ToString();
                        int semester = Convert.ToInt32(dr[12].ToString());
                        string cmd1 = "select qid from subj_ref where Branch=@br and Semester=@sem";
                        SqlConnection cnn = new SqlConnection();
                        cnn.ConnectionString = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["cn"].ToString();
                        cnn.Open();
                        SqlCommand cm = new SqlCommand(cmd1, cnn);
                        cm.Parameters.AddWithValue("br", branch);
                        cm.Parameters.AddWithValue("sem", semester);
                        int qid = (int)cm.ExecuteScalar();
                        string cmd2 = "select name from Subjects where qid=@qd";
                        SqlConnection cnn1 = new SqlConnection();
                        cnn1.ConnectionString = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["cn"].ToString();
                        cnn1.Open();
                        SqlCommand cm1 = new SqlCommand(cmd2, cnn1);
                        cm1.Parameters.AddWithValue("qd", qid);
                        SqlDataReader ds1 = cm1.ExecuteReader();
                        if(ds1.Read())
                        {
                            RadioButton1.Text = ds1[0].ToString();
                            ds1.Read();
                            RadioButton2.Text = ds1[0].ToString();
                        }
                        else
                        {
                            Response.Redirect("");
                        }
                    }
                    else
                    {
                        
                    }
            }
        }
        protected void StartQuiz_Click(object sender, EventArgs e)
        {
            if(RadioButton1.Checked==true)
            {
                Response.Redirect("Quiz.aspx?sub="+RadioButton1.Text+"");
            }else if(RadioButton2.Checked==true)
            {
                Response.Redirect("Quiz.aspx?sub=" + RadioButton2.Text + "");
            }
            
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Session.Remove("studnetid");
            Session.RemoveAll();
            Response.Redirect("StudnetLogin.aspx");
        }
    }
}