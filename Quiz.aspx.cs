using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Collections;
using System.Net.Mail;
namespace Interactive_Learning_Portal
{
    public partial class Quiz : System.Web.UI.Page
    {
        static DataSet  ds = new DataSet();
        float score, neg, correct;
        returnbrsem r = new returnbrsem();
        static string qid = string.Empty;
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
                    Session["OngoingQuiz"] = Session["Attempts"] = Session["Correct"] = Session["index"] = Session["ques"] = Session["Ans"] = null;
                    Start.Visible = true;
                    Label1.Visible = Button1.Visible= Button3.Visible= Button4.Visible= Button5.Visible=Label4.Visible=false;
                    RadioButtonList1.SelectedIndex = -1;
                    RadioButtonList1.Visible = false;
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            if(RadioButtonList1.SelectedIndex!=-1)
            {
                Session["Attempts"] = (int)Session["Attempts"] + 1;
                if((int)Session["Ans"]==RadioButtonList1.SelectedIndex)
                {
                    Session["Correct"] = (int)Session["Correct"] + 1;
                }
            }
            RadioButtonList1.SelectedIndex = -1;
            if ((int)Session["index"] < (int)Session["ques"])
            {
                Session["index"] = (int)Session["index"] + 1;
                int index = (int)Session["index"];
                RadioButtonList1.Items.Clear();
                Label1.Text = "Q" + Session["index"].ToString() + ". " + ds.Tables[0].Rows[index-1][1].ToString();
                RadioButtonList1.Items.Add(ds.Tables[0].Rows[index - 1][2].ToString());
                RadioButtonList1.Items.Add(ds.Tables[0].Rows[index - 1][3].ToString());
                RadioButtonList1.Items.Add(ds.Tables[0].Rows[index - 1][4].ToString());
                RadioButtonList1.Items.Add(ds.Tables[0].Rows[index - 1][5].ToString());
                String dq = ds.Tables[0].Rows[index - 1][6].ToString();
                if (dq == "A")
                    Session["Ans"] = 0;
                else if (dq == "B")
                    Session["Ans"] = 1;
                else if (dq == "C")
                    Session["Ans"] = 2;
                else if (dq == "D")
                    Session["Ans"] = 3;
            }
            else
            {
                score = 0;
                neg = correct = 0;
                if (Session["Attempts"] != null)
                {
                    correct = Session["Correct"] != null ? (int)Session["Correct"] : 0;
                    neg = ((int)Session["Attempts"] - correct) / 4;
                }
                score = correct - neg;
                Label1.Text = "Thank you!<br>Your Score is: " + score.ToString() + "/" + Session["ques"].ToString()+"<br>You gaved:<br>Correct: "+Session["Correct"].ToString()+"<br>Attempted: "+Session["Attempts"].ToString();
                RadioButtonList1.Visible = false;
                Button1.Visible = Button3.Visible=false;
                Session["subj"] = (string)Session["OngoingQuiz"];
                Session["max"] = Session["ques"];
                Session["At"] = Session["Attempts"];
                Session["Cor"] = Session["Correct"];
                Session["OngoingQuiz"] = Session["Attempts"]=Session["Correct"]=Session["index"]=Session["ques"]=Session["Ans"]= null;
                ds.Clear();
                Session["count"] = score;
                Button4.Visible = Button5.Visible= true;
                SqlConnection cn = new SqlConnection();
                cn.ConnectionString = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["cn"].ToString();
                cn.Open();
                string str = "insert into Result values(@sid,@result,@dor)";
                SqlCommand cmd = new SqlCommand(str, cn);
                SqlParameter p1 = new SqlParameter("sid", Session["studentid"].ToString());
                SqlParameter p2 = new SqlParameter("result", Session["count"].ToString());
                SqlParameter p3 = new SqlParameter("dor", System.DateTime.Today);
                cmd.Parameters.Add(p1); 
                cmd.Parameters.Add(p2);
                cmd.Parameters.Add(p3);
                cmd.ExecuteNonQuery();
                cn.Close();
            }
        }

        protected void sendmail(string username, string email,string Result)
        {
            MailMessage mail = new MailMessage("saxena.ankur47@gmail.com", email);
            mail.Subject = "Quiz Result - "+Session["subj"];
            mail.Body = "Hi " + username + ",\nGreetings from Shiksha!\nThank you for giving the quiz, we have recorded your result in our system, you can see all results in the Result column \nYour result for the concerned quiz is as follows:"+Result+"\nRegards,\nAdmin";
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
            client.Credentials = new System.Net.NetworkCredential()
            {
                UserName = "saxena.ankur47@gmail.com",
                Password = "saxena.ankur47"
            };
            client.EnableSsl = true;
            client.Send(mail);
        }
  

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Session.Remove("studentid");
            Session.RemoveAll();
            Response.Redirect("StudentLogin.aspx");
        }

        protected void Start_Click(object sender, EventArgs e)
        {
            if (Session["OngoingQuiz"] == null)
            {
                Session["OngoingQuiz"] = Request.QueryString["sub"].ToString();
                SqlConnection cnn = new SqlConnection();
                cnn.ConnectionString = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["cn"].ToString();
                SqlCommand cm = new SqlCommand("select Qid from QuizQuestion where Subject=@sub", cnn);
                cm.Parameters.AddWithValue("sub", Session["OnGoingQuiz"]);
                cnn.Open();
                SqlDataReader dr = cm.ExecuteReader();
         
                if (dr.Read())
                {
                    Start.Visible = false;
                    Label1.Visible = true;
                    Label1.ForeColor = System.Drawing.Color.Black;
                    RadioButtonList1.Visible = true;
                    GetQuestions();
                }
                else
                {
                    Label1.Text = "Sorry!! As of Now we don't have a quiz ready for this subject!!";
                    Label1.ForeColor = System.Drawing.Color.Red;
                    Label1.Visible = true;
                }
            }
            else
            {
                Label1.Text = "You need to log in again to clear bins";
                Label1.ForeColor = System.Drawing.Color.Red;
                Label1.Visible = true;
            }
        }

        private void GetQuestions()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["cn"].ToString();
            SqlCommand cmd = new SqlCommand("select * from QuizQuestion where Subject=@su order by Qid asc", cn);
            cmd.Parameters.AddWithValue("su", Session["OngoingQuiz"]);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            SqlCommandBuilder cmdb = new SqlCommandBuilder(ad);
            ad.Fill(ds);
            Session["ques"] = ds.Tables[0].Rows.Count;
            Session["index"] = 1;
            Label1.Text = "Q" + Session["index"].ToString() + ". " + ds.Tables[0].Rows[0][1].ToString();
            RadioButtonList1.Items.Add(ds.Tables[0].Rows[0][2].ToString());
            RadioButtonList1.Items.Add(ds.Tables[0].Rows[0][3].ToString());
            RadioButtonList1.Items.Add(ds.Tables[0].Rows[0][4].ToString());
            RadioButtonList1.Items.Add(ds.Tables[0].Rows[0][5].ToString());
            String dq = ds.Tables[0].Rows[0][6].ToString();
            if (dq == "A")
                Session["Ans"] = 0;
            else if (dq == "B")
                Session["Ans"] = 1;
            else if (dq == "C")
                Session["Ans"] = 2;
            else if (dq == "D")
                Session["Ans"] = 3;
            Button1.Visible=Button3.Visible = true;
            Session["Attempts"] = Session["Correct"] = 0;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            RadioButtonList1.SelectedIndex = -1;
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("Student.aspx");
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            string Result,sugg;
            int max = (int)Session["max"];
            int correct = (int)Session["Cor"];
            int attempts = (int)Session["At"];
            float neg = (attempts - correct) / 4;
            float score = correct - neg;
            float per = (score * 100) / max;
            sugg = "Your report is under processing";
            if(per>=75)
            {
                sugg = "You have performed extremely good! Keep going!";
            }
            else if(per<75&&per>=50)
            {
                sugg = "Your performance was really good!!"; 
            }
            else if(per<50&&per>=30)
            {
                sugg = "Your performance was satisfactory, but you could do a little better, keep practicing on Shiksha!";
            }
            else if(per<30)
            {
                sugg = "Your performance was very poor you need to practice more!!";
            }
            Result = "\nYou scored as follows\nTotal No of questions=" + max.ToString() + "\nNo of Questions Attempted: " + Session["At"].ToString() + "\nNo of Correct Attempts: " + Session["Cor"].ToString() + "\nScore: " + Session["count"].ToString() + "/" + Session["max"] + "\nOur view: " + sugg;
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["cn"].ToString();
            SqlCommand cmd=new SqlCommand("Select * from AddStudent where RollNo=@uid");
            cmd.Parameters.AddWithValue("uid",Session["studentid"]);
            cmd.Connection = cnn;
            SqlDataAdapter da=new SqlDataAdapter(cmd);
            DataSet d=new DataSet();
            da.Fill(d);
            Label4.Visible = true;
            try
            {
                sendmail(d.Tables[0].Rows[0][1].ToString(), d.Tables[0].Rows[0][10].ToString(), Result);
                Label4.Text = "We have send the report to your register mail id";
                Label4.ForeColor = System.Drawing.Color.Green;
            }
            catch(SmtpException ex)
            {
                Label4.Text= "Network conditions prevent us from sending the report";
                Label4.ForeColor=System.Drawing.Color.Red;
            }
            finally
            {
                Button5.Enabled = false;
            }
        }
    }
}