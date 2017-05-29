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
    public partial class SignUpStudent : System.Web.UI.Page
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
            
            SmtpException ev=null;
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
                else if (rollno.Value.Length == 10)
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
                string pas=RandomUtil.GetRandomString();
                cmd.Parameters.AddWithValue("password", pas);
                em.send_maill(ret.name(rollno.Value), ret.email(rollno.Value), 1, rollno.Value);
                int i=cmd.ExecuteNonQuery();
                cn.Close();
                alert1.Visible = true;
                try
                {
                    sendmail(name.Value,rollno.Value, pas, email.Value);
                }
                catch(SmtpException ex)
                {
                    ev = ex;
                    Label2.Text = "Network conditions prevent us to send an email, although you have been registered.";
                    alert.Visible = true;
                }
                finally
                {
                    Label1.Text = "Students details are successfully saved"+(ev==null?", and we have sent your login credentials on the registered email address":".");
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
            }
            catch (Exception e1)
            {


            }
        }

        protected void sendmail(string username,string roll, string password, string email)
        {
            MailMessage mail = new MailMessage("saxena.ankur47@gmail.com", email);
            mail.Subject = "Welcome to Shiksha!";
            mail.Body = "Hi " + username + ",\nGreetings!\nThank you for being a part of Shiksha(Interactive Learning Portal).\nWe have created your profile, below are the credentials to login:\nUsername: " + roll + "\nPassword: " + password + "\nYou can change the password once you login\nRegards,\nAdmin";
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
            client.Credentials = new System.Net.NetworkCredential()
            {
                UserName = "saxena.ankur47@gmail.com",
                Password = "saxena.ankur47"
            };
            client.EnableSsl = true;
            client.Send(mail);
        }


       
    }
}