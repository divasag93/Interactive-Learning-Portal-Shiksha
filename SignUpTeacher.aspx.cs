using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Net.Mail;
namespace Interactive_Learning_Portal
{
    public partial class SignUpTeacher : System.Web.UI.Page
    {
        Email em = new Email();
        returnbrsem ret = new returnbrsem();
        protected void Page_Load(object sender, EventArgs e)
        {
          
            alert.Visible = false;
            alert1.Visible = false;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            validate v = new validate();
            SmtpException exc = null;
            try
            {
                SqlConnection cn = new SqlConnection();
                cn.ConnectionString = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["cn"].ToString();
                
                string str = "insert into AddTeacher(TeacherId,TName,TPno,Department,Password,TEmail) values(@tid,@tname,@tpno,@department,@password,@email)";
                SqlCommand cmd = new SqlCommand(str, cn);

                SqlParameter p2 = new SqlParameter("tname", tname.Value);

                SqlParameter p6 = new SqlParameter("email", email.Value);

                cmd.Parameters.Add(p6);

                if (v.istidexist(tid.Value))
                {
                    alert.Visible = true;
                    Label2.Text = "OOPs! Teacher ID already exist";
                }
                else if (tid.Value.Length == 4)
                {
                    SqlParameter p1 = new SqlParameter("tid", department.Value + tid.Value);
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
                string pas = RandomUtil.GetRandomString();
                SqlParameter p5 = new SqlParameter("password",pas);
                cmd.Parameters.Add(p5);
                cn.Open();
                int i=cmd.ExecuteNonQuery();
                cn.Close();
                try
                {
                    sendmail(tname.Value,department.Value+tid.Value, pas, email.Value);
                }
                catch (SmtpException ex)
                {
                    Label2.Text = "Network conditions prevent us from sending an email, although you have been registered.";
                    alert.Visible = true;
                    exc = ex;
                }
                finally
                {
                    alert1.Visible = true;
                    Label1.Text = "Teacher details are successfully saved"+((exc==null)?" and we have sent your login credentials to your Email Address.":    ".");
                    tname.Value = "";
                    tid.Value = "";
                    department.Value = "";
                    tpno.Value = "";
                }
            }
            catch (Exception e1)
            {

            }
        }

        protected void sendmail(string username,string id,string password,string email)
        {
            MailMessage mail = new MailMessage("saxena.ankur47@gmail.com", email);
            mail.Subject = "Welcome to Shiksha!";
            mail.Body = "Hi " + username + ",\nGreetings!\nThank you for being a part of Shiksha(Interactive Learning Portal) account.\nWe have created your profile, below are the details to login:\nUsername: "+id+"\nPassword: " + password + "\nYou can change the password once you login\nRegards,\nAdmin";
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
            
        }
    }
}