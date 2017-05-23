using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Collections;
using System.Data.SqlClient;
namespace Interactive_Learning_Portal
{
    public partial class UploadMaterial : System.Web.UI.Page
    {
        int p = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["teacherid"] == null)
            {
                Response.Redirect("TeacherLogin.aspx");
            }
            alert.Visible = false;
            alert1.Visible = false;
        }

        protected void previousyearquestion_Click(object sender, EventArgs e)
        {
            try
            {

                if ((Path.GetExtension(pyquestionupload.PostedFile.FileName).Substring(1) == "pdf") || (Path.GetExtension(pyquestionupload.PostedFile.FileName).Substring(1) == "PDF"))
                {
                    string n = Server.MapPath("Shiksha" + "\\" + branch.Value + "\\" + semester.Value + "\\" + "PreviousYearQuestion");
                    DirectoryInfo d = new DirectoryInfo(n);
                    FileInfo[] f = d.GetFiles();
                    p = 1 + f.Count();
                    pyquestionupload.SaveAs(Server.MapPath("Shiksha" + "\\" + branch.Value + "\\" + semester.Value + "\\" + "PreviousYearQuestion" + "\\PYQ" + p + ".pdf"));
                    alert1.Visible = true;
                    Label3.Text = "File has been uploaded.";

                }
                else
                {

                    alert.Visible = true;
                    Label2.Text = "OOPs! Unsupported Format";
           
                }
            }
            catch(Exception e1) {

         
            }
         


        }

        protected void uassignment_Click(object sender, EventArgs e)
        {

            try
            {

                if ((Path.GetExtension(uploadassignment.PostedFile.FileName).Substring(1) == "pdf") || (Path.GetExtension(uploadassignment.PostedFile.FileName).Substring(1) == "PDF"))
                {
                    string n = Server.MapPath("Shiksha" + "\\" + branch1.Value + "\\" + semester1.Value + "\\" + "Assignments");
                    DirectoryInfo d1 = new DirectoryInfo(n);
                    FileInfo[] f = d1.GetFiles();
                    p = 1 + f.Count();
                    uploadassignment.SaveAs(Server.MapPath("Shiksha" + "\\" + branch1.Value + "\\" + semester1.Value + "\\" + "Assignments" + "\\Assignment" + p + ".pdf"));
                    alert1.Visible = true;
                    Label3.Text = "File has been uploaded.";
                    string s="Assignment-"+p;
                    SqlConnection cn = new SqlConnection();
                    cn.ConnectionString = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["cn"].ToString();
                    cn.Open();
                    string str = "insert into Assignment(AssNo,DueDate,Branch,Semester) values (@assno,@duedate,@branch,@semester)";
                    SqlCommand cmd = new SqlCommand(str, cn);
                    SqlParameter p1 = new SqlParameter("assno", s);
                    
                    string d=DateTime.Today.AddDays(7).ToShortDateString();
                    
                    SqlParameter p2 = new SqlParameter("duedate", d);
                    SqlParameter p3 = new SqlParameter("branch", branch1.Value);
                    SqlParameter p4 = new SqlParameter("semester", semester1.Value);
                    cmd.Parameters.Add(p1);
                    cmd.Parameters.Add(p2);
                    cmd.Parameters.Add(p3);
                    cmd.Parameters.Add(p4);
                    cmd.ExecuteNonQuery();
                    cn.Close();
                }
                else
                {

                    alert.Visible = true;
                    Label2.Text = "OOPs! Unsupported Format";
                    

                }
            }
            catch(Exception e1)
            {
                Label1.Text = e1.Message.ToString();

            }
         
         


        }

        protected void ututorial_Click(object sender, EventArgs e)
        {

            try
            {

                if ((Path.GetExtension(uploadtutorial.PostedFile.FileName).Substring(1) == "pdf") || (Path.GetExtension(uploadtutorial.PostedFile.FileName).Substring(1) == "PDF"))
                {
                    string n = Server.MapPath("Shiksha" + "\\" + branch2.Value + "\\" + semester2.Value + "\\" + "Tutorials");
                    DirectoryInfo d2 = new DirectoryInfo(n);
                    FileInfo[] f = d2.GetFiles();
                    p = 1 + f.Count();
                    uploadassignment.SaveAs(Server.MapPath("Shiksha" + "\\" + branch2.Value + "\\" + semester2.Value + "\\" + "Tutorials" + "\\Tutorials" + p + ".pdf"));

                    alert1.Visible = true;
                    Label3.Text = "File has been uploaded.";
                }
                else
                {

                    alert.Visible = true;
                    Label2.Text = "OOPs! Unsupported Format";
                    

                }
            }
            catch(Exception e1)
            {


            }
        }

        protected void uploadlecture_Click(object sender, EventArgs e)
        {

            try
            {

                if ((Path.GetExtension(lectureupload.PostedFile.FileName).Substring(1) == "mp4") || (Path.GetExtension(lectureupload.PostedFile.FileName).Substring(1) == "MP4"))
                {
                    string n = Server.MapPath("Shiksha" + "\\" + branch3.Value + "\\" + semester3.Value + "\\" + "Lectures");
                    DirectoryInfo d3 = new DirectoryInfo(n);
                    FileInfo[] f = d3.GetFiles();
                    p = 1 + f.Count();
                    lectureupload.SaveAs(Server.MapPath("Shiksha" + "\\" + branch3.Value + "\\" + semester3.Value + "\\" + "Lectures" + "\\Lectures" + p + ".mp4"));

                    alert1.Visible = true;
                    Label3.Text = "File has been uploaded.";
                }
                else
                {
                    alert.Visible = true;
                    Label2.Text = "OOPs! Unsupported Format";

                }
            }
            catch(Exception e1)
            {


            }
        }
    }
    
}