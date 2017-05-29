using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Net.Mail;

namespace Interactive_Learning_Portal
{
    public partial class Forgot_Password : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            alert.Visible = false;
            alert1.Visible = false;
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            Label2.Text = "";
            alert.Visible = false;
            if(Session["user"]!=null)
            {
                if (email.Value != null)
                {
                    SqlConnection con=new SqlConnection(WebConfigurationManager.ConnectionStrings["cn"].ToString());
                    SqlCommand cmd = new SqlCommand("select * from " + Session["user"] + " where Email=@email",con);
                    cmd.Parameters.AddWithValue("@email", email.Value);
                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        con.Close();
                        SqlConnection dd = new SqlConnection(WebConfigurationManager.ConnectionStrings["cn"].ConnectionString);
                        SqlCommand cd = new SqlCommand("select * from " + Session["user"] + " where Email=@email", dd);
                        cd.Parameters.AddWithValue("@email", email.Value);
                        SqlDataAdapter ad = new SqlDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        ad.Fill(ds);
                        string username,pass; 
                        if((string)Session["user"]=="AddStudent")
                        {
                            username = ds.Tables[0].Rows[0][1].ToString();
                            pass = ds.Tables[0].Rows[0][13].ToString();
                        }
                        else
                        {
                            username=ds.Tables[0].Rows[0][2].ToString();
                            pass=ds.Tables[0].Rows[0][5].ToString();
                        }
                        MailMessage mail = new MailMessage("divasag93@gmail.com", email.Value);
                        mail.Subject = "Your Password for Shiksha Online Portal";
                        mail.Body = "Hi " + username + ",\nWe have received a forgot password request for your registered Shiksha(Interactive Learning Portal) account.\nYour Password is: " + pass + "\nRegards,\nAdmin";
                        SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                        client.Credentials = new System.Net.NetworkCredential()
                        {
                            UserName = "saxena.ankur47@gmail.com",
                            Password = "saxena.ankur47"
                        };
                        client.EnableSsl = true;
                        client.Send(mail);
                        alert1.Visible = true;
                        Label1.Text = "We have send the password on the registered email id";
                        Session["user"] = null;
                    }
                    else
                    {
                        Label2.Text = "Email id does not exist";
                        Label2.ForeColor = System.Drawing.Color.Red;
                        alert.Visible = true;
                    }
                }
                else
                {
                    alert.Visible = true;
                    Label2.Text = "Enter an email address";
                }
            }
            else
            {
                Response.Redirect("index.aspx");
            }
        }
    }
}