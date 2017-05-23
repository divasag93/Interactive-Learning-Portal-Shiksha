using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
namespace Interactive_Learning_Portal
{
    public partial class Shiksha_Forum : System.Web.UI.Page
    {
        static SqlCommand cmd1, cmd2;
        static SqlConnection cn;
        static SqlDataAdapter ad1, ad2;
        static DataSet ds1, ds2;
        static SqlCommandBuilder cmdb1, cmdb2;
        static int i, j;
        returnbrsem r = new returnbrsem();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                cn = new SqlConnection();
                cn.ConnectionString = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                cmd1 = new SqlCommand("select * from faq order by qid desc", cn);
                cmd2 = new SqlCommand("Select * from fga order by qid desc", cn);
                ds1 = new DataSet();
                ds2 = new DataSet();
                ad1 = new SqlDataAdapter(cmd1);
                ad2 = new SqlDataAdapter(cmd2);
                cmdb1 = new SqlCommandBuilder(ad1);
                cmdb2 = new SqlCommandBuilder(ad2);
                ad1.Fill(ds1);
                ad2.Fill(ds2);
                j = 0;
                i = 0;

                if (i < ds1.Tables[0].Rows.Count)
                {

                    String divText = ds1.Tables[0].Rows[i][1].ToString();
                    Label2.Text = ds1.Tables[0].Rows[i][0].ToString();
                    Panel12.Controls.Add(new LiteralControl("<p  align='justify'><font size=4><b><div style='word-wrap:break-word;'>Q" + ds1.Tables[0].Rows[i][0].ToString() + ".  " + divText + "</b><p align=right>Posted By :" + ds1.Tables[0].Rows[i][2].ToString() + "&nbsp;&nbsp;" + ds1.Tables[0].Rows[i][3].ToString() + "&nbsp;</p></font></p>"));
                    for (; j < ds2.Tables[0].Rows.Count; j++)
                    {
                        if (ds1.Tables[0].Rows[i][0].ToString() != ds2.Tables[0].Rows[j][0].ToString())
                        {
                            break;
                        }
                        String divAns = ds2.Tables[0].Rows[j][1].ToString() + "<p align=right>Posted By :" + ds2.Tables[0].Rows[j][2].ToString() + "&nbsp;&nbsp;" + ds2.Tables[0].Rows[j][3].ToString() + "&nbsp;</p>";
                        Panel12.Controls.Add(new LiteralControl("<p bgcolor='blue' align='justify'><font size=3>" + divAns + "</div></font></p>"));
                    }

                    Panel2.Visible = true;
                }
                else
                    Panel2.Visible = false;
                i++;
                if (i < ds1.Tables[0].Rows.Count)
                {

                    String divText = ds1.Tables[0].Rows[i][1].ToString();
                    Label3.Text = ds1.Tables[0].Rows[i][0].ToString();
                    Panel13.Controls.Add(new LiteralControl("<p  align='justify'><font size=4><b><div style='word-wrap:break-word;'>Q" + ds1.Tables[0].Rows[i][0].ToString() + ".  " + divText + "</b><p align=right>Posted By :" + ds1.Tables[0].Rows[i][2].ToString() + "&nbsp;&nbsp;" + ds1.Tables[0].Rows[i][3].ToString() + "&nbsp;</p></div></font></p>"));
                    for (; j < ds2.Tables[0].Rows.Count; j++)
                    {
                        if (ds1.Tables[0].Rows[i][0].ToString() != ds2.Tables[0].Rows[j][0].ToString())
                        {
                            break;
                        }
                        String divAns = ds2.Tables[0].Rows[j][1].ToString() + "<p align=right>Posted By :" + ds2.Tables[0].Rows[j][2].ToString() + "&nbsp;&nbsp;" + ds2.Tables[0].Rows[j][3].ToString() + "&nbsp;</p>";
                        Panel13.Controls.Add(new LiteralControl("<p  align='justify'><font size=3><div style='word-wrap:break-word;'>" + divAns + "</div></font></p>"));
                    }
                    Panel4.Visible = true;
                }
                else
                    Panel4.Visible = false;
                i++;
                if (i < ds1.Tables[0].Rows.Count)
                {
                    String divText = ds1.Tables[0].Rows[i][1].ToString();
                    Label4.Text = ds1.Tables[0].Rows[i][0].ToString();
                    Panel14.Controls.Add(new LiteralControl("<p  align='justify'><font size=4><b><div style='word-wrap:break-word;'>Q" + ds1.Tables[0].Rows[i][0].ToString() + ".  " + divText + "</b><p align=right>Posted By :" + ds1.Tables[0].Rows[i][2].ToString() + "&nbsp;&nbsp;" + ds1.Tables[0].Rows[i][3].ToString() + "&nbsp;</p></div></font></p>"));
                    for (; j < ds2.Tables[0].Rows.Count; j++)
                    {
                        if (ds1.Tables[0].Rows[i][0].ToString() != ds2.Tables[0].Rows[j][0].ToString())
                        {
                            break;
                        }
                        String divAns = ds2.Tables[0].Rows[j][1].ToString() + "<p align=right>Posted By :" + ds2.Tables[0].Rows[j][2].ToString() + "&nbsp;&nbsp;" + ds2.Tables[0].Rows[j][3].ToString() + "&nbsp;</p>";
                        Panel14.Controls.Add(new LiteralControl("<p  align='justify'><font size=3><div style='word-wrap:break-word;'>" + divAns + "</div></font></p>"));
                    }
                    Panel6.Visible = true;
                }
                else
                    Panel6.Visible = false;
                i++;
                if (i < ds1.Tables[0].Rows.Count)
                {

                    String divText = ds1.Tables[0].Rows[i][1].ToString();
                    Label5.Text = ds1.Tables[0].Rows[i][0].ToString();
                    Panel15.Controls.Add(new LiteralControl("<p  align='justify'><font size=4><b><div style='word-wrap:break-word;'>Q" + ds1.Tables[0].Rows[i][0].ToString() + ".  " + divText + "</b><p align=right>Posted By :" + ds1.Tables[0].Rows[i][2].ToString() + "&nbsp;&nbsp;" + ds1.Tables[0].Rows[i][3].ToString() + "&nbsp;</p></div></font></p>"));
                    for (; j < ds2.Tables[0].Rows.Count; j++)
                    {
                        if (ds1.Tables[0].Rows[i][0].ToString() != ds2.Tables[0].Rows[j][0].ToString())
                        {
                            break;
                        }
                        String divAns = ds2.Tables[0].Rows[j][1].ToString() + "<p align=right>Posted By :" + ds2.Tables[0].Rows[j][2].ToString() + "&nbsp;&nbsp;" + ds2.Tables[0].Rows[j][3].ToString() + "&nbsp;</p>";
                        Panel15.Controls.Add(new LiteralControl("<p  align='justify'><font size=3><div style='word-wrap:break-word;'>" + divAns + "</div></font></p>"));
                    }
                    Panel8.Visible = true;
                }
                else
                    Panel8.Visible = false;
                i++;
                LinkButton1.Enabled = false;
                LinkButton2.Enabled = false;
                if (ds1.Tables[0].Rows.Count <= 4)
                {
                    LinkButton3.Enabled = false;
                    LinkButton4.Enabled = false;
                }
            }
        }
        protected void LinkButton1_Click(object sender, EventArgs e)
        {

            j = 0;
            i = 0;
            DataView dv = ds2.Tables[0].DefaultView;
            dv.RowFilter = "1=1";
            dv.Sort = "qid desc";

            DataView dv1 = ds1.Tables[0].DefaultView;
            dv1.RowFilter = "1=1";


            dv1.Sort = "qid desc";
            if (i < dv1.ToTable().Rows.Count)
            {
                String divText = dv1.ToTable().Rows[i][1].ToString();
                Label2.Text = dv1.ToTable().Rows[i][0].ToString();
                Panel12.Controls.Add(new LiteralControl("<p  align='justify'><font size=4><b><div style='word-wrap:break-word;'>Q" + dv1.ToTable().Rows[i][0].ToString() + ".  " + divText + "</b><p align=right>Posted By :" + dv1.ToTable().Rows[i][2].ToString() + "&nbsp;&nbsp;" + dv1.ToTable().Rows[i][3].ToString() + "&nbsp;</p></div></font></p>"));
                for (; j < dv.ToTable().Rows.Count; j++)
                {
                    if (dv1.ToTable().Rows[i][0].ToString() != dv.ToTable().Rows[j][0].ToString())
                    {
                        break;
                    }
                    String divAns = dv.ToTable().Rows[j][1].ToString() + "<p align=right>Posted By :" + dv.ToTable().Rows[j][2].ToString() + "&nbsp;&nbsp;" + dv.ToTable().Rows[j][3].ToString() + "&nbsp;</p>";
                    Panel12.Controls.Add(new LiteralControl("<p  align='justify'><font size=3><div style='word-wrap:break-word;'>" + divAns + "</div></font></p><br>"));
                }

                Panel2.Visible = true;
            }
            else
                Panel2.Visible = false;
            i++;
            if (i < dv1.ToTable().Rows.Count)
            {

                String divText = dv1.ToTable().Rows[i][1].ToString();
                Label3.Text = dv1.ToTable().Rows[i][0].ToString();
                Panel13.Controls.Add(new LiteralControl("<p  align='justify'><font size=4><b><div style='word-wrap:break-word;'>Q" + dv1.ToTable().Rows[i][0].ToString() + ".  " + divText + "</b><p align=right>Posted By :" + dv1.ToTable().Rows[i][2].ToString() + "&nbsp;&nbsp;" + dv1.ToTable().Rows[i][3].ToString() + "&nbsp;</p></div></font></p>"));
                for (; j < dv.ToTable().Rows.Count; j++)
                {
                    if (dv1.ToTable().Rows[i][0].ToString() != dv.ToTable().Rows[j][0].ToString())
                    {
                        break;
                    }
                    String divAns = dv.ToTable().Rows[j][1].ToString() + "<p align=right>Posted By :" + dv.ToTable().Rows[j][2].ToString() + "&nbsp;&nbsp;" + dv.ToTable().Rows[j][3].ToString() + "&nbsp;</p>";
                    Panel13.Controls.Add(new LiteralControl("<p  align='justify'><font size=3><div style='word-wrap:break-word;'>" + divAns + "</div></font></p>"));
                }
                Panel4.Visible = true;
            }
            else
                Panel4.Visible = false;
            i++;
            if (i < dv1.ToTable().Rows.Count)
            {
                String divText = dv1.ToTable().Rows[i][1].ToString();
                Label4.Text = dv1.ToTable().Rows[i][0].ToString();
                Panel14.Controls.Add(new LiteralControl("<p  align='justify'><font size=4><b><div style='word-wrap:break-word;'>Q" + dv1.ToTable().Rows[i][0].ToString() + ".  " + divText + "</b><p align=right>Posted By :" + dv1.ToTable().Rows[i][2].ToString() + "&nbsp;&nbsp;" + dv1.ToTable().Rows[i][3].ToString() + "&nbsp;</p></div></font></p>"));
                for (; j < dv.ToTable().Rows.Count; j++)
                {
                    if (dv1.ToTable().Rows[i][0].ToString() != dv.ToTable().Rows[j][0].ToString())
                    {
                        break;
                    }
                    String divAns = dv.ToTable().Rows[j][1].ToString() + "<p align=right>Posted By :" + dv.ToTable().Rows[j][2].ToString() + "&nbsp;&nbsp;" + dv.ToTable().Rows[j][3].ToString() + "&nbsp;</p>";
                    Panel14.Controls.Add(new LiteralControl("<p  align='justify'><font size=3><div style='word-wrap:break-word;'>" + divAns + "</div></font></p>"));
                }
                Panel6.Visible = true;
            }
            else
                Panel6.Visible = false;
            i++;
            if (i < dv1.ToTable().Rows.Count)
            {

                String divText = dv1.ToTable().Rows[i][1].ToString();
                Label5.Text = dv1.ToTable().Rows[i][0].ToString();
                Panel15.Controls.Add(new LiteralControl("<p  align='justify'><font size=4><b><div style='word-wrap:break-word;'>Q" + dv1.ToTable().Rows[i][0].ToString() + ".  " + divText + "</b><p align=right>Posted By :" + dv1.ToTable().Rows[i][2].ToString() + "&nbsp;&nbsp;" + dv1.ToTable().Rows[i][3].ToString() + "&nbsp;</p></div></font></p>"));
                for (; j < dv.ToTable().Rows.Count; j++)
                {
                    if (dv1.ToTable().Rows[i][0].ToString() != dv.ToTable().Rows[j][0].ToString())
                    {
                        break;
                    }
                    String divAns = dv.ToTable().Rows[j][1].ToString() + "<p align=right>Posted By :" + dv.ToTable().Rows[j][2].ToString() + "&nbsp;&nbsp;" + dv.ToTable().Rows[j][3].ToString() + "&nbsp;</p>";
                    Panel15.Controls.Add(new LiteralControl("<p  align='justify'><font size=3><div style='word-wrap:break-word;'>" + divAns + "</div></font></p>"));
                }
                Panel8.Visible = true;
            }
            else
                Panel8.Visible = false;
            i++;

            if (dv1.ToTable().Rows.Count == ds1.Tables[0].Rows.Count)
            {
                LinkButton2.Enabled = false;
                LinkButton1.Enabled = false;
            }
            else
            {
                LinkButton2.Enabled = true;
                LinkButton1.Enabled = true;
            }

            if (dv1.ToTable().Rows.Count <= 4)
            {
                LinkButton3.Enabled = false;
                LinkButton4.Enabled = false;
            }
            else
            {
                LinkButton3.Enabled = true;
                LinkButton4.Enabled = true;
            }

        }

        protected void LinkButton5_Click(object sender, EventArgs e)
        {
            if (ds1.Tables[0].Rows.Count >= 1)
            {
                j = 0;
                i = 0;
                DataView dv = ds2.Tables[0].DefaultView;
                dv.RowFilter = "qid<=" + Label2.Text;
                dv.Sort = "qid desc";
                DataView dv1 = ds1.Tables[0].DefaultView;
                dv1.RowFilter = "qid<=" + Label2.Text;
                dv1.Sort = "qid desc";

                if (i < dv1.ToTable().Rows.Count)
                {

                    String divText = dv1.ToTable().Rows[i][1].ToString();
                    Label2.Text = dv1.ToTable().Rows[i][0].ToString();


                    Panel12.Controls.Add(new LiteralControl("<p  align='justify'><font size=4><b><div style='word-wrap:break-word;'>Q" + dv1.ToTable().Rows[i][0].ToString() + ".  " + divText + "</b><p align=right>Posted By :" + dv1.ToTable().Rows[i][2].ToString() + "&nbsp;&nbsp;" + dv1.ToTable().Rows[i][3].ToString() + "&nbsp;</p></div></font></p>"));
                    for (; j < dv.ToTable().Rows.Count; j++)
                    {
                        if (dv1.ToTable().Rows[i][0].ToString() != dv.ToTable().Rows[j][0].ToString())
                        {
                            break;
                        }
                        String divAns = dv.ToTable().Rows[j][1].ToString() + "<p align=right>Posted By :" + dv.ToTable().Rows[j][2].ToString() + "&nbsp;&nbsp;" + dv.ToTable().Rows[j][3].ToString() + "&nbsp;</p>";
                        Panel12.Controls.Add(new LiteralControl("<p  align='justify'><font size=3><div style='word-wrap:break-word;'>" + divAns + "</div></font></p><br>"));
                    }

                    Panel2.Visible = true;
                }
                else
                    Panel2.Visible = false;
                i++;
                if (i < dv1.ToTable().Rows.Count)
                {

                    String divText = dv1.ToTable().Rows[i][1].ToString();
                    Label3.Text = dv1.ToTable().Rows[i][0].ToString();


                    Panel13.Controls.Add(new LiteralControl("<p  align='justify'><font size=4><b><div style='word-wrap:break-word;'>Q" + dv1.ToTable().Rows[i][0].ToString() + ".  " + divText + "</b><p align=right>Posted By :" + dv1.ToTable().Rows[i][2].ToString() + "&nbsp;&nbsp;" + dv1.ToTable().Rows[i][3].ToString() + "&nbsp;</p></div></font></p>"));
                    for (; j < dv.ToTable().Rows.Count; j++)
                    {
                        if (dv1.ToTable().Rows[i][0].ToString() != dv.ToTable().Rows[j][0].ToString())
                        {
                            break;
                        }
                        String divAns = dv.ToTable().Rows[j][1].ToString() + "<p align=right>Posted By :" + dv.ToTable().Rows[j][2].ToString() + "&nbsp;&nbsp;" + dv.ToTable().Rows[j][3].ToString() + "&nbsp;</p>";
                        Panel13.Controls.Add(new LiteralControl("<p  align='justify'><font size=3><div style='word-wrap:break-word;'>" + divAns + "</div></font></p>"));
                    }
                    Panel4.Visible = true;
                }
                else
                    Panel4.Visible = false;
                i++;
                if (i < dv1.ToTable().Rows.Count)
                {
                    String divText = dv1.ToTable().Rows[i][1].ToString();
                    Label4.Text = dv1.ToTable().Rows[i][0].ToString();


                    Panel14.Controls.Add(new LiteralControl("<p  align='justify'><font size=4><b><div style='word-wrap:break-word;'>Q" + dv1.ToTable().Rows[i][0].ToString() + ".  " + divText + "</b><p align=right>Posted By :" + dv1.ToTable().Rows[i][2].ToString() + "&nbsp;&nbsp;" + dv1.ToTable().Rows[i][3].ToString() + "&nbsp;</p></div></font></p>"));
                    for (; j < dv.ToTable().Rows.Count; j++)
                    {
                        if (dv1.ToTable().Rows[i][0].ToString() != dv.ToTable().Rows[j][0].ToString())
                        {
                            break;
                        }
                        String divAns = dv.ToTable().Rows[j][1].ToString() + "<p align=right>Posted By :" + dv.ToTable().Rows[j][2].ToString() + "&nbsp;&nbsp;" + dv.ToTable().Rows[j][3].ToString() + "&nbsp;</p>";
                        Panel14.Controls.Add(new LiteralControl("<p  align='justify'><font size=3><div style='word-wrap:break-word;'>" + divAns + "</div></font></p>"));
                    }
                    Panel6.Visible = true;
                }
                else
                    Panel6.Visible = false;
                i++;
                if (i < dv1.ToTable().Rows.Count)
                {

                    String divText = dv1.ToTable().Rows[i][1].ToString();
                    Label5.Text = dv1.ToTable().Rows[i][0].ToString();


                    Panel15.Controls.Add(new LiteralControl("<p  align='justify'><font size=4><b><div style='word-wrap:break-word;'>Q" + dv1.ToTable().Rows[i][0].ToString() + ".  " + divText + "</b><p align=right>Posted By :" + dv1.ToTable().Rows[i][2].ToString() + "&nbsp;&nbsp;" + dv1.ToTable().Rows[i][3].ToString() + "&nbsp;</p></div></font></p>"));
                    for (; j < dv.ToTable().Rows.Count; j++)
                    {
                        if (dv1.ToTable().Rows[i][0].ToString() != dv.ToTable().Rows[j][0].ToString())
                        {
                            break;
                        }
                        String divAns = dv.ToTable().Rows[j][1].ToString() + "<p align=right>Posted By :" + dv.ToTable().Rows[j][2].ToString() + "&nbsp;&nbsp;" + dv.ToTable().Rows[j][3].ToString() + "&nbsp;</p>";
                        Panel15.Controls.Add(new LiteralControl("<p  align='justify'><font size=3><div style='word-wrap:break-word;'>" + divAns + "</div></font></p>"));
                    }
                    Panel8.Visible = true;
                }
                else
                    Panel8.Visible = false;
                i++;

                if (dv1.ToTable().Rows.Count == ds1.Tables[0].Rows.Count)
                {
                    LinkButton2.Enabled = false;
                    LinkButton1.Enabled = false;
                }
                else
                {
                    LinkButton2.Enabled = true;
                    LinkButton1.Enabled = true;
                }

                if (dv1.ToTable().Rows.Count <= 4)
                {
                    LinkButton3.Enabled = false;
                    LinkButton4.Enabled = false;
                }
                else
                {
                    LinkButton3.Enabled = true;
                    LinkButton4.Enabled = true;
                }

            }
            Panel10.Visible = true;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            j = 0;
            i = 0;

            DataRow dr = ds2.Tables[0].NewRow();
            dr[0] = Label2.Text;
            dr[1] = TextBox1.Text;
            dr[2] = r.name(Session["fid"].ToString());
            dr[2] = r.tname(Session["fid"].ToString());
            dr[3] = DateTime.Now.ToString();
            ds2.Tables[0].Rows.Add(dr);
            ad2.Update(ds2);
            DataView dv = ds2.Tables[0].DefaultView;
            dv.RowFilter = "qid<=" + Label2.Text;
            dv.Sort = "qid desc";
            DataView dv1 = ds1.Tables[0].DefaultView;
            dv1.RowFilter = "qid<=" + Label2.Text;
            dv1.Sort = "qid desc";

            if (i < dv1.ToTable().Rows.Count)
            {

                String divText = dv1.ToTable().Rows[i][1].ToString();
                Label2.Text = dv1.ToTable().Rows[i][0].ToString();


                Panel12.Controls.Add(new LiteralControl("<p  align='justify'><font size=4><b><div style='word-wrap:break-word;'>Q" + dv1.ToTable().Rows[i][0].ToString() + ".  " + divText + "</b><p align=right>Posted By :" + dv1.ToTable().Rows[i][2].ToString() + "&nbsp;&nbsp;" + dv1.ToTable().Rows[i][3].ToString() + "&nbsp;</p></div></font></p>"));
                for (; j < dv.ToTable().Rows.Count; j++)
                {
                    if (dv1.ToTable().Rows[i][0].ToString() != dv.ToTable().Rows[j][0].ToString())
                    {
                        break;
                    }
                    String divAns = dv.ToTable().Rows[j][1].ToString() + "<p align=right>Posted By :" + dv.ToTable().Rows[j][2].ToString() + "&nbsp;&nbsp;" + dv.ToTable().Rows[j][3].ToString() + "&nbsp;</p>";
                    Panel12.Controls.Add(new LiteralControl("<p  align='justify'><font size=3><div style='word-wrap:break-word;'>" + divAns + "</div></font></p>"));
                }

                Panel2.Visible = true;
            }
            else
                Panel2.Visible = false;
            i++;
            if (i < dv1.ToTable().Rows.Count)
            {

                String divText = dv1.ToTable().Rows[i][1].ToString();
                Label3.Text = dv1.ToTable().Rows[i][0].ToString();


                Panel13.Controls.Add(new LiteralControl("<p  align='justify'><font size=4><b><div style='word-wrap:break-word;'>Q" + dv1.ToTable().Rows[i][0].ToString() + ".  " + divText + "</b><p align=right>Posted By :" + dv1.ToTable().Rows[i][2].ToString() + "&nbsp;&nbsp;" + dv1.ToTable().Rows[i][3].ToString() + "&nbsp;</p></div></font></p>"));
                for (; j < dv.ToTable().Rows.Count; j++)
                {
                    if (dv1.ToTable().Rows[i][0].ToString() != dv.ToTable().Rows[j][0].ToString())
                    {
                        break;
                    }
                    String divAns = dv.ToTable().Rows[j][1].ToString() + "<p align=right>Posted By :" + dv.ToTable().Rows[j][2].ToString() + "&nbsp;&nbsp;" + dv.ToTable().Rows[j][3].ToString() + "&nbsp;</p>";
                    Panel13.Controls.Add(new LiteralControl("<p  align='justify'><font size=3><div style='word-wrap:break-word;'>" + divAns + "</div></font></p>"));
                }
                Panel4.Visible = true;
            }
            else
                Panel4.Visible = false;
            i++;
            if (i < dv1.ToTable().Rows.Count)
            {
                String divText = dv1.ToTable().Rows[i][1].ToString();
                Label4.Text = dv1.ToTable().Rows[i][0].ToString();


                Panel14.Controls.Add(new LiteralControl("<p  align='justify'><font size=4><b><div style='word-wrap:break-word;'>Q" + dv1.ToTable().Rows[i][0].ToString() + ".  " + divText + "</b><p align=right>Posted By :" + dv1.ToTable().Rows[i][2].ToString() + "&nbsp;&nbsp;" + dv1.ToTable().Rows[i][3].ToString() + "&nbsp;</p></div></font></p>"));
                for (; j < dv.ToTable().Rows.Count; j++)
                {
                    if (dv1.ToTable().Rows[i][0].ToString() != dv.ToTable().Rows[j][0].ToString())
                    {
                        break;
                    }
                    String divAns = dv.ToTable().Rows[j][1].ToString() + "<p align=right>Posted By :" + dv.ToTable().Rows[j][2].ToString() + "&nbsp;&nbsp;" + dv.ToTable().Rows[j][3].ToString() + "&nbsp;</p>";
                    Panel14.Controls.Add(new LiteralControl("<p  align='justify'><font size=3><div style='word-wrap:break-word;'>" + divAns + "</div></font></p>"));
                }
                Panel6.Visible = true;
            }
            else
                Panel6.Visible = false;
            i++;
            if (i < dv1.ToTable().Rows.Count)
            {

                String divText = dv1.ToTable().Rows[i][1].ToString();
                Label5.Text = dv1.ToTable().Rows[i][0].ToString();


                Panel15.Controls.Add(new LiteralControl("<p  align='justify'><font size=4><b><div style='word-wrap:break-word;'>Q" + dv1.ToTable().Rows[i][0].ToString() + ".  " + divText + "</b><p align=right>Posted By :" + dv1.ToTable().Rows[i][2].ToString() + "&nbsp;&nbsp;" + dv1.ToTable().Rows[i][3].ToString() + "&nbsp;</p></div></font></p>"));
                for (; j < dv.ToTable().Rows.Count; j++)
                {
                    if (dv1.ToTable().Rows[i][0].ToString() != dv.ToTable().Rows[j][0].ToString())
                    {
                        break;
                    }
                    String divAns = dv.ToTable().Rows[j][1].ToString() + "<p align=right>Posted By :" + dv.ToTable().Rows[j][2].ToString() + "&nbsp;&nbsp;" + dv.ToTable().Rows[j][3].ToString() + "&nbsp;</p>";
                    Panel15.Controls.Add(new LiteralControl("<p  align='justify'><font size=3><div style='word-wrap:break-word;'>" + divAns + "</div></font></p>"));
                }
                Panel8.Visible = true;
            }
            else
                Panel8.Visible = false;
            i++;



            if (dv1.ToTable().Rows.Count == ds1.Tables[0].Rows.Count)
            {
                LinkButton2.Enabled = false;
                LinkButton1.Enabled = false;
            }
            else
            {
                LinkButton2.Enabled = true;
                LinkButton1.Enabled = true;
            }

            if (dv1.ToTable().Rows.Count <= 4)
            {
                LinkButton3.Enabled = false;
                LinkButton4.Enabled = false;
            }
            else
            {
                LinkButton3.Enabled = true;
                LinkButton4.Enabled = true;
            }
            TextBox1.Text = "";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            j = 0;
            i = 0;

            DataRow dr = ds2.Tables[0].NewRow();
            dr[0] = Label3.Text;
            dr[1] = TextBox2.Text;
            dr[2] = r.name(Session["fid"].ToString());
            dr[2] = r.tname(Session["fid"].ToString());
            dr[3] = DateTime.Now.ToString();
            ds2.Tables[0].Rows.Add(dr);
            ad2.Update(ds2);
            DataView dv = ds2.Tables[0].DefaultView;
            dv.RowFilter = "qid<=" + Label2.Text;
            dv.Sort = "qid desc";
            DataView dv1 = ds1.Tables[0].DefaultView;
            dv1.RowFilter = "qid<=" + Label2.Text;
            dv1.Sort = "qid desc";

            if (i < dv1.ToTable().Rows.Count)
            {

                String divText = dv1.ToTable().Rows[i][1].ToString();
                Label2.Text = dv1.ToTable().Rows[i][0].ToString();


                Panel12.Controls.Add(new LiteralControl("<p  align='justify'><font size=4><b><div style='word-wrap:break-word;'>Q" + dv1.ToTable().Rows[i][0].ToString() + ".  " + divText + "</b><p align=right>Posted By :" + dv1.ToTable().Rows[i][2].ToString() + "&nbsp;&nbsp;" + dv1.ToTable().Rows[i][3].ToString() + "&nbsp;</p></div></font></p>"));
                for (; j < dv.ToTable().Rows.Count; j++)
                {
                    if (dv1.ToTable().Rows[i][0].ToString() != dv.ToTable().Rows[j][0].ToString())
                    {
                        break;
                    }
                    String divAns = dv.ToTable().Rows[j][1].ToString() + "<p align=right>Posted By :" + dv.ToTable().Rows[j][2].ToString() + "&nbsp;&nbsp;" + dv.ToTable().Rows[j][3].ToString() + "&nbsp;</p>";
                    Panel12.Controls.Add(new LiteralControl("<p  align='justify'><font size=3><div style='word-wrap:break-word;'>" + divAns + "</div></font></p><br>"));
                }

                Panel2.Visible = true;
            }
            else
                Panel2.Visible = false;
            i++;
            if (i < dv1.ToTable().Rows.Count)
            {

                String divText = dv1.ToTable().Rows[i][1].ToString();
                Label3.Text = dv1.ToTable().Rows[i][0].ToString();


                Panel13.Controls.Add(new LiteralControl("<p  align='justify'><font size=4><b><div style='word-wrap:break-word;'>Q" + dv1.ToTable().Rows[i][0].ToString() + ".  " + divText + "</b><p align=right>Posted By :" + dv1.ToTable().Rows[i][2].ToString() + "&nbsp;&nbsp;" + dv1.ToTable().Rows[i][3].ToString() + "&nbsp;</p></div></font></p>"));
                for (; j < dv.ToTable().Rows.Count; j++)
                {
                    if (dv1.ToTable().Rows[i][0].ToString() != dv.ToTable().Rows[j][0].ToString())
                    {
                        break;
                    }
                    String divAns = dv.ToTable().Rows[j][1].ToString() + "<p align=right>Posted By :" + dv.ToTable().Rows[j][2].ToString() + "&nbsp;&nbsp;" + dv.ToTable().Rows[j][3].ToString() + "&nbsp;</p>";
                    Panel13.Controls.Add(new LiteralControl("<p  align='justify'><font size=3><div style='word-wrap:break-word;'>" + divAns + "</div></font></p>"));
                }
                Panel4.Visible = true;
            }
            else
                Panel4.Visible = false;
            i++;
            if (i < dv1.ToTable().Rows.Count)
            {
                String divText = dv1.ToTable().Rows[i][1].ToString();
                Label4.Text = dv1.ToTable().Rows[i][0].ToString();


                Panel14.Controls.Add(new LiteralControl("<p  align='justify'><font size=4><b><div style='word-wrap:break-word;'>Q" + dv1.ToTable().Rows[i][0].ToString() + ".  " + divText + "</b><p align=right>Posted By :" + dv1.ToTable().Rows[i][2].ToString() + "&nbsp;&nbsp;" + dv1.ToTable().Rows[i][3].ToString() + "&nbsp;</p></div></font></p>"));
                for (; j < dv.ToTable().Rows.Count; j++)
                {
                    if (dv1.ToTable().Rows[i][0].ToString() != dv.ToTable().Rows[j][0].ToString())
                    {
                        break;
                    }
                    String divAns = dv.ToTable().Rows[j][1].ToString() + "<p align=right>Posted By :" + dv.ToTable().Rows[j][2].ToString() + "&nbsp;&nbsp;" + dv.ToTable().Rows[j][3].ToString() + "&nbsp;</p>";
                    Panel14.Controls.Add(new LiteralControl("<p  align='justify'><font size=3><div style='word-wrap:break-word;'>" + divAns + "</div></font></p>"));
                }
                Panel6.Visible = true;
            }
            else
                Panel6.Visible = false;
            i++;
            if (i < dv1.ToTable().Rows.Count)
            {

                String divText = dv1.ToTable().Rows[i][1].ToString();
                Label5.Text = dv1.ToTable().Rows[i][0].ToString();


                Panel15.Controls.Add(new LiteralControl("<p  align='justify'><font size=4><b><div style='word-wrap:break-word;'>Q" + dv1.ToTable().Rows[i][0].ToString() + ".  " + divText + "</b><p align=right>Posted By :" + dv1.ToTable().Rows[i][2].ToString() + "&nbsp;&nbsp;" + dv1.ToTable().Rows[i][3].ToString() + "&nbsp;</p></div></font></p>"));
                for (; j < dv.ToTable().Rows.Count; j++)
                {
                    if (dv1.ToTable().Rows[i][0].ToString() != dv.ToTable().Rows[j][0].ToString())
                    {
                        break;
                    }
                    String divAns = dv.ToTable().Rows[j][1].ToString() + "<p align=right>Posted By :" + dv.ToTable().Rows[j][2].ToString() + "&nbsp;&nbsp;" + dv.ToTable().Rows[j][3].ToString() + "&nbsp;</p>";
                    Panel15.Controls.Add(new LiteralControl("<p  align='justify'><font size=3><div style='word-wrap:break-word;'>" + divAns + "</div></font></p>"));
                }
                Panel8.Visible = true;
            }
            else
                Panel8.Visible = false;
            i++;


            if (dv1.ToTable().Rows.Count == ds1.Tables[0].Rows.Count)
            {
                LinkButton2.Enabled = false;
                LinkButton1.Enabled = false;
            }
            else
            {
                LinkButton2.Enabled = true;
                LinkButton1.Enabled = true;
            }

            if (dv1.ToTable().Rows.Count <= 4)
            {
                LinkButton3.Enabled = false;
                LinkButton4.Enabled = false;
            }
            else
            {
                LinkButton3.Enabled = true;
                LinkButton4.Enabled = true;
            }
            TextBox2.Text = "";
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            j = 0;
            i = 0;

            DataRow dr = ds2.Tables[0].NewRow();
            dr[0] = Label4.Text;
            dr[1] = TextBox3.Text;
            dr[2] = r.name(Session["fid"].ToString());
            dr[2] = r.tname(Session["fid"].ToString());
            dr[3] = DateTime.Now.ToString();
            ds2.Tables[0].Rows.Add(dr);
            ad2.Update(ds2);
            DataView dv = ds2.Tables[0].DefaultView;
            dv.RowFilter = "qid<=" + Label2.Text;
            dv.Sort = "qid desc";
            DataView dv1 = ds1.Tables[0].DefaultView;
            dv1.RowFilter = "qid<=" + Label2.Text;
            dv1.Sort = "qid desc";

            if (i < dv1.ToTable().Rows.Count)
            {

                String divText = dv1.ToTable().Rows[i][1].ToString();
                Label2.Text = dv1.ToTable().Rows[i][0].ToString();


                Panel12.Controls.Add(new LiteralControl("<p  align='justify'><font size=4><b><div style='word-wrap:break-word;'>Q" + dv1.ToTable().Rows[i][0].ToString() + ".  " + divText + "</b><p align=right>Posted By :" + dv1.ToTable().Rows[i][2].ToString() + "&nbsp;&nbsp;" + dv1.ToTable().Rows[i][3].ToString() + "&nbsp;</p></div></font></p>"));
                for (; j < dv.ToTable().Rows.Count; j++)
                {
                    if (dv1.ToTable().Rows[i][0].ToString() != dv.ToTable().Rows[j][0].ToString())
                    {
                        break;
                    }
                    String divAns = dv.ToTable().Rows[j][1].ToString() + "<p align=right>Posted By :" + dv.ToTable().Rows[j][2].ToString() + "&nbsp;&nbsp;" + dv.ToTable().Rows[j][3].ToString() + "&nbsp;</p>";
                    Panel12.Controls.Add(new LiteralControl("<p  align='justify'><font size=3><div style='word-wrap:break-word;'>" + divAns + "</div></font></p><br>"));
                }

                Panel2.Visible = true;
            }
            else
                Panel2.Visible = false;
            i++;
            if (i < dv1.ToTable().Rows.Count)
            {

                String divText = dv1.ToTable().Rows[i][1].ToString();
                Label3.Text = dv1.ToTable().Rows[i][0].ToString();


                Panel13.Controls.Add(new LiteralControl("<p  align='justify'><font size=4><b><div style='word-wrap:break-word;'>Q" + dv1.ToTable().Rows[i][0].ToString() + ".  " + divText + "</b><p align=right>Posted By :" + dv1.ToTable().Rows[i][2].ToString() + "&nbsp;&nbsp;" + dv1.ToTable().Rows[i][3].ToString() + "&nbsp;</p></div></font></p>"));
                for (; j < dv.ToTable().Rows.Count; j++)
                {
                    if (dv1.ToTable().Rows[i][0].ToString() != dv.ToTable().Rows[j][0].ToString())
                    {
                        break;
                    }
                    String divAns = dv.ToTable().Rows[j][1].ToString() + "<p align=right>Posted By :" + dv.ToTable().Rows[j][2].ToString() + "&nbsp;&nbsp;" + dv.ToTable().Rows[j][3].ToString() + "&nbsp;</p>";
                    Panel13.Controls.Add(new LiteralControl("<p  align='justify'><font size=3><div style='word-wrap:break-word;'>" + divAns + "</div></font></p>"));
                }
                Panel4.Visible = true;
            }
            else
                Panel4.Visible = false;
            i++;
            if (i < dv1.ToTable().Rows.Count)
            {
                String divText = dv1.ToTable().Rows[i][1].ToString();
                Label4.Text = dv1.ToTable().Rows[i][0].ToString();


                Panel14.Controls.Add(new LiteralControl("<p  align='justify'><font size=4><b><div style='word-wrap:break-word;'>Q" + dv1.ToTable().Rows[i][0].ToString() + ".  " + divText + "</b><p align=right>Posted By :" + dv1.ToTable().Rows[i][2].ToString() + "&nbsp;&nbsp;" + dv1.ToTable().Rows[i][3].ToString() + "&nbsp;</p></div></font></p>"));
                for (; j < dv.ToTable().Rows.Count; j++)
                {
                    if (dv1.ToTable().Rows[i][0].ToString() != dv.ToTable().Rows[j][0].ToString())
                    {
                        break;
                    }
                    String divAns = dv.ToTable().Rows[j][1].ToString() + "<p align=right>Posted By :" + dv.ToTable().Rows[j][2].ToString() + "&nbsp;&nbsp;" + dv.ToTable().Rows[j][3].ToString() + "&nbsp;</p>";
                    Panel14.Controls.Add(new LiteralControl("<p  align='justify'><font size=3><div style='word-wrap:break-word;'>" + divAns + "</div></font></p>"));
                }
                Panel6.Visible = true;
            }
            else
                Panel6.Visible = false;
            i++;
            if (i < dv1.ToTable().Rows.Count)
            {

                String divText = dv1.ToTable().Rows[i][1].ToString();
                Label5.Text = dv1.ToTable().Rows[i][0].ToString();


                Panel15.Controls.Add(new LiteralControl("<p  align='justify'><font size=4><b><div style='word-wrap:break-word;'>Q" + dv1.ToTable().Rows[i][0].ToString() + ".  " + divText + "</b><p align=right>Posted By :" + dv1.ToTable().Rows[i][2].ToString() + "&nbsp;&nbsp;" + dv1.ToTable().Rows[i][3].ToString() + "&nbsp;</p></div></font></p>"));
                for (; j < dv.ToTable().Rows.Count; j++)
                {
                    if (dv1.ToTable().Rows[i][0].ToString() != dv.ToTable().Rows[j][0].ToString())
                    {
                        break;
                    }
                    String divAns = dv.ToTable().Rows[j][1].ToString() + "<p align=right>Posted By :" + dv.ToTable().Rows[j][2].ToString() + "&nbsp;&nbsp;" + dv.ToTable().Rows[j][3].ToString() + "&nbsp;</p>";
                    Panel15.Controls.Add(new LiteralControl("<p  align='justify'><font size=3><div style='word-wrap:break-word;'>" + divAns + "</div></font></p>"));
                }
                Panel8.Visible = true;
            }
            else
                Panel8.Visible = false;
            i++;

            if (dv1.ToTable().Rows.Count == ds1.Tables[0].Rows.Count)
            {
                LinkButton2.Enabled = false;
                LinkButton1.Enabled = false;
            }
            else
            {
                LinkButton2.Enabled = true;
                LinkButton1.Enabled = true;
            }

            if (dv1.ToTable().Rows.Count <= 4)
            {
                LinkButton3.Enabled = false;
                LinkButton4.Enabled = false;
            }
            else
            {
                LinkButton3.Enabled = true;
                LinkButton4.Enabled = true;
            }
            TextBox3.Text = "";
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            j = 0;
            i = 0;

            DataRow dr = ds2.Tables[0].NewRow();
            dr[0] = Label5.Text;
            dr[1] = TextBox4.Text;
            dr[2] = r.name(Session["fid"].ToString());
            dr[2] = r.tname(Session["fid"].ToString());
            dr[3] = DateTime.Now.ToString();
            ds2.Tables[0].Rows.Add(dr);
            ad2.Update(ds2);
            DataView dv = ds2.Tables[0].DefaultView;
            dv.RowFilter = "qid<=" + Label2.Text;
            dv.Sort = "qid desc";
            DataView dv1 = ds1.Tables[0].DefaultView;
            dv1.RowFilter = "qid<=" + Label2.Text;
            dv1.Sort = "qid desc";

            if (i < dv1.ToTable().Rows.Count)
            {

                String divText = dv1.ToTable().Rows[i][1].ToString();
                Label2.Text = dv1.ToTable().Rows[i][0].ToString();


                Panel12.Controls.Add(new LiteralControl("<p  align='justify'><font size=4><b><div style='word-wrap:break-word;'>Q" + dv1.ToTable().Rows[i][0].ToString() + ".  " + divText + "</b><p align=right>Posted By :" + dv1.ToTable().Rows[i][2].ToString() + "&nbsp;&nbsp;" + dv1.ToTable().Rows[i][3].ToString() + "&nbsp;</p></div></font></p>"));
                for (; j < dv.ToTable().Rows.Count; j++)
                {
                    if (dv1.ToTable().Rows[i][0].ToString() != dv.ToTable().Rows[j][0].ToString())
                    {
                        break;
                    }
                    String divAns = dv.ToTable().Rows[j][1].ToString() + "<p align=right>Posted By :" + dv.ToTable().Rows[j][2].ToString() + "&nbsp;&nbsp;" + dv.ToTable().Rows[j][3].ToString() + "&nbsp;</p>";
                    Panel12.Controls.Add(new LiteralControl("<p  align='justify'><font size=3><div style='word-wrap:break-word;'>" + divAns + "</div></font></p>"));
                }

                Panel2.Visible = true;
            }
            else
                Panel2.Visible = false;
            i++;
            if (i < dv1.ToTable().Rows.Count)
            {

                String divText = dv1.ToTable().Rows[i][1].ToString();
                Label3.Text = dv1.ToTable().Rows[i][0].ToString();


                Panel13.Controls.Add(new LiteralControl("<p  align='justify'><font size=4><b><div style='word-wrap:break-word;'>Q" + dv1.ToTable().Rows[i][0].ToString() + ".  " + divText + "</b><p align=right>Posted By :" + dv1.ToTable().Rows[i][2].ToString() + "&nbsp;&nbsp;" + dv1.ToTable().Rows[i][3].ToString() + "&nbsp;</p></div></font></p>"));
                for (; j < dv.ToTable().Rows.Count; j++)
                {
                    if (dv1.ToTable().Rows[i][0].ToString() != dv.ToTable().Rows[j][0].ToString())
                    {
                        break;
                    }
                    String divAns = dv.ToTable().Rows[j][1].ToString() + "<p align=right>Posted By :" + dv.ToTable().Rows[j][2].ToString() + "&nbsp;&nbsp;" + dv.ToTable().Rows[j][3].ToString() + "&nbsp;</p>";
                    Panel13.Controls.Add(new LiteralControl("<p  align='justify'><font size=3><div style='word-wrap:break-word;'>" + divAns + "</div></font></p>"));
                }
                Panel4.Visible = true;
            }
            else
                Panel4.Visible = false;
            i++;
            if (i < dv1.ToTable().Rows.Count)
            {
                String divText = dv1.ToTable().Rows[i][1].ToString();
                Label4.Text = dv1.ToTable().Rows[i][0].ToString();


                Panel14.Controls.Add(new LiteralControl("<p  align='justify'><font size=4><b><div style='word-wrap:break-word;'>Q" + dv1.ToTable().Rows[i][0].ToString() + ".  " + divText + "</b><p align=right>Posted By :" + dv1.ToTable().Rows[i][2].ToString() + "&nbsp;&nbsp;" + dv1.ToTable().Rows[i][3].ToString() + "&nbsp;</p></div></font></p>"));
                for (; j < dv.ToTable().Rows.Count; j++)
                {
                    if (dv1.ToTable().Rows[i][0].ToString() != dv.ToTable().Rows[j][0].ToString())
                    {
                        break;
                    }
                    String divAns = dv.ToTable().Rows[j][1].ToString() + "<p align=right>Posted By :" + dv.ToTable().Rows[j][2].ToString() + "&nbsp;&nbsp;" + dv.ToTable().Rows[j][3].ToString() + "&nbsp;</p>";
                    Panel14.Controls.Add(new LiteralControl("<p  align='justify'><font size=3><div style='word-wrap:break-word;'>" + divAns + "</div></font></p>"));
                }
                Panel6.Visible = true;
            }
            else
                Panel6.Visible = false;
            i++;
            if (i < dv1.ToTable().Rows.Count)
            {

                String divText = dv1.ToTable().Rows[i][1].ToString();
                Label5.Text = dv1.ToTable().Rows[i][0].ToString();


                Panel15.Controls.Add(new LiteralControl("<p  align='justify'><font size=4><b><div style='word-wrap:break-word;'>Q" + dv1.ToTable().Rows[i][0].ToString() + ".  " + divText + "</b><p align=right>Posted By :" + dv1.ToTable().Rows[i][2].ToString() + "&nbsp;&nbsp;" + dv1.ToTable().Rows[i][3].ToString() + "&nbsp;</p></div></font></p>"));
                for (; j < dv.ToTable().Rows.Count; j++)
                {
                    if (dv1.ToTable().Rows[i][0].ToString() != dv.ToTable().Rows[j][0].ToString())
                    {
                        break;
                    }
                    String divAns = dv.ToTable().Rows[j][1].ToString() + "<p align=right>Posted By :" + dv.ToTable().Rows[j][2].ToString() + "&nbsp;&nbsp;" + dv.ToTable().Rows[j][3].ToString() + "&nbsp;</p>";
                    Panel15.Controls.Add(new LiteralControl("<p  align='justify'><font size=3><div style='word-wrap:break-word;'>" + divAns + "</div></font></p>"));
                }
                Panel8.Visible = true;
            }
            else
                Panel8.Visible = false;
            i++;

            if (dv1.ToTable().Rows.Count == ds1.Tables[0].Rows.Count)
            {
                LinkButton2.Enabled = false;
                LinkButton1.Enabled = false;
            }
            else
            {
                LinkButton2.Enabled = true;
                LinkButton1.Enabled = true;
            }

            if (dv1.ToTable().Rows.Count <= 4)
            {
                LinkButton3.Enabled = false;
                LinkButton4.Enabled = false;
            }
            else
            {
                LinkButton3.Enabled = true;
                LinkButton4.Enabled = true;
            }
            TextBox4.Text = "";
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            DataRow dr = ds1.Tables[0].NewRow();
            dr[0] = ds1.Tables[0].Rows.Count + 1;
            dr[1] = TextBox5.Text;
            dr[2] = r.name(Session["fid"].ToString());
            dr[2] = r.tname(Session["fid"].ToString());
            dr[3] = DateTime.Now.ToString();
            ds1.Tables[0].Rows.Add(dr);
            ad1.Update(ds1);

            j = 0;
            i = 0;

            DataView dv = ds2.Tables[0].DefaultView;
            dv.RowFilter = "1=1";
            dv.Sort = "qid desc";
            DataView dv1 = ds1.Tables[0].DefaultView;
            dv1.RowFilter = "1=1";
            dv1.Sort = "qid desc";

            if (i < dv1.ToTable().Rows.Count)
            {

                String divText = dv1.ToTable().Rows[i][1].ToString();
                Label2.Text = dv1.ToTable().Rows[i][0].ToString();


                Panel12.Controls.Add(new LiteralControl("<p  align='justify'><font size=4><b><div style='word-wrap:break-word;'>Q" + dv1.ToTable().Rows[i][0].ToString() + ".  " + divText + "</b><p align=right>Posted By :" + dv1.ToTable().Rows[i][2].ToString() + "&nbsp;&nbsp;" + dv1.ToTable().Rows[i][3].ToString() + "&nbsp;</p></div></font></p>"));
                for (; j < dv.ToTable().Rows.Count; j++)
                {
                    if (dv1.ToTable().Rows[i][0].ToString() != dv.ToTable().Rows[j][0].ToString())
                    {
                        break;
                    }
                    String divAns = dv.ToTable().Rows[j][1].ToString() + "<p align=right>Posted By :" + dv.ToTable().Rows[j][2].ToString() + "&nbsp;&nbsp;" + dv.ToTable().Rows[j][3].ToString() + "&nbsp;</p>";
                    Panel12.Controls.Add(new LiteralControl("<p  align='justify'><font size=3><div style='word-wrap:break-word;'>" + divAns + "</div></font></p>"));
                }

                Panel2.Visible = true;
            }
            else
                Panel2.Visible = false;
            i++;
            if (i < dv1.ToTable().Rows.Count)
            {

                String divText = dv1.ToTable().Rows[i][1].ToString();
                Label3.Text = dv1.ToTable().Rows[i][0].ToString();


                Panel13.Controls.Add(new LiteralControl("<p  align='justify'><font size=4><b><div style='word-wrap:break-word;'>Q" + dv1.ToTable().Rows[i][0].ToString() + ".  " + divText + "</b><p align=right>Posted By :" + dv1.ToTable().Rows[i][2].ToString() + "&nbsp;&nbsp;" + dv1.ToTable().Rows[i][3].ToString() + "&nbsp;</p></div></font></p>"));
                for (; j < dv.ToTable().Rows.Count; j++)
                {
                    if (dv1.ToTable().Rows[i][0].ToString() != dv.ToTable().Rows[j][0].ToString())
                    {
                        break;
                    }
                    String divAns = dv.ToTable().Rows[j][1].ToString() + "<p align=right>Posted By :" + dv.ToTable().Rows[j][2].ToString() + "&nbsp;&nbsp;" + dv.ToTable().Rows[j][3].ToString() + "&nbsp;</p>";
                    Panel13.Controls.Add(new LiteralControl("<p  align='justify'><font size=3><div style='word-wrap:break-word;'>" + divAns + "</div></font></p>"));
                }
                Panel4.Visible = true;
            }
            else
                Panel4.Visible = false;
            i++;
            if (i < dv1.ToTable().Rows.Count)
            {
                String divText = dv1.ToTable().Rows[i][1].ToString();
                Label4.Text = dv1.ToTable().Rows[i][0].ToString();


                Panel14.Controls.Add(new LiteralControl("<p  align='justify'><font size=4><b><div style='word-wrap:break-word;'>Q" + dv1.ToTable().Rows[i][0].ToString() + ".  " + divText + "</b><p align=right>Posted By :" + dv1.ToTable().Rows[i][2].ToString() + "&nbsp;&nbsp;" + dv1.ToTable().Rows[i][3].ToString() + "&nbsp;</p></div></font></p>"));
                for (; j < dv.ToTable().Rows.Count; j++)
                {
                    if (dv1.ToTable().Rows[i][0].ToString() != dv.ToTable().Rows[j][0].ToString())
                    {
                        break;
                    }
                    String divAns = dv.ToTable().Rows[j][1].ToString() + "<p align=right>Posted By :" + dv.ToTable().Rows[j][2].ToString() + "&nbsp;&nbsp;" + dv.ToTable().Rows[j][3].ToString() + "&nbsp;</p>";
                    Panel14.Controls.Add(new LiteralControl("<p  align='justify'><font size=3><div style='word-wrap:break-word;'>" + divAns + "</div></font></p>"));
                }
                Panel6.Visible = true;
            }
            else
                Panel6.Visible = false;
            i++;
            if (i < dv1.ToTable().Rows.Count)
            {
                String divText = dv1.ToTable().Rows[i][1].ToString();
                Label5.Text = dv1.ToTable().Rows[i][0].ToString();


                Panel15.Controls.Add(new LiteralControl("<p  align='justify'><font size=4><b><div style='word-wrap:break-word;'>Q" + dv1.ToTable().Rows[i][0].ToString() + ".  " + divText + "</b><p align=right>Posted By :" + dv1.ToTable().Rows[i][2].ToString() + "&nbsp;&nbsp;" + dv1.ToTable().Rows[i][3].ToString() + "&nbsp;</p></div></font></p>"));
                for (; j < dv.ToTable().Rows.Count; j++)
                {
                    if (dv1.ToTable().Rows[i][0].ToString() != dv.ToTable().Rows[j][0].ToString())
                    {
                        break;
                    }
                    String divAns = dv.ToTable().Rows[j][1].ToString() + "<p align=right>Posted By :" + dv.ToTable().Rows[j][2].ToString() + "&nbsp;&nbsp;" + dv.ToTable().Rows[j][3].ToString() + "&nbsp;</p>";
                    Panel15.Controls.Add(new LiteralControl("<p  align='justify'><font size=3><div style='word-wrap:break-word;'>" + divAns + "</div></font></p>"));
                }
                Panel8.Visible = true;
            }
            else
                Panel6.Visible = false;
            i++;


            if (dv1.ToTable().Rows.Count == ds1.Tables[0].Rows.Count)
            {
                LinkButton2.Enabled = false;
                LinkButton1.Enabled = false;
            }
            else
            {
                LinkButton2.Enabled = true;
                LinkButton1.Enabled = true;
            }

            if (dv1.ToTable().Rows.Count <= 4)
            {
                LinkButton3.Enabled = false;
                LinkButton4.Enabled = false;
            }
            else
            {
                LinkButton3.Enabled = true;
                LinkButton4.Enabled = true;
            }
            TextBox5.Text = "";
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            j = 0;
            i = 0;


            DataView dv = ds2.Tables[0].DefaultView;
            dv.RowFilter = "qid<=" + (Convert.ToInt32(Label2.Text) + 4);
            dv.Sort = "qid desc";
            DataView dv1 = ds1.Tables[0].DefaultView;
            dv1.RowFilter = "qid<=" + (Convert.ToInt32(Label2.Text) + 4);
            dv1.Sort = "qid desc";

            if (i < dv1.ToTable().Rows.Count)
            {

                String divText = dv1.ToTable().Rows[i][1].ToString();
                Label2.Text = dv1.ToTable().Rows[i][0].ToString();


                Panel12.Controls.Add(new LiteralControl("<p  align='justify'><font size=4><b><div style='word-wrap:break-word;'>Q" + dv1.ToTable().Rows[i][0].ToString() + ".  " + divText + "</b><p align=right>Posted By :" + dv1.ToTable().Rows[i][2].ToString() + "&nbsp;&nbsp;" + dv1.ToTable().Rows[i][3].ToString() + "&nbsp;</p></div></font></p>"));
                for (; j < dv.ToTable().Rows.Count; j++)
                {
                    if (dv1.ToTable().Rows[i][0].ToString() != dv.ToTable().Rows[j][0].ToString())
                    {
                        break;
                    }
                    String divAns = dv.ToTable().Rows[j][1].ToString() + "<p align=right>Posted By :" + dv.ToTable().Rows[j][2].ToString() + "&nbsp;&nbsp;" + dv.ToTable().Rows[j][3].ToString() + "&nbsp;</p>";
                    Panel12.Controls.Add(new LiteralControl("<p  align='justify'><font size=3><div style='word-wrap:break-word;'>" + divAns + "</div></font></p>"));
                }

                Panel2.Visible = true;
            }
            else
                Panel2.Visible = false;
            i++;
            if (i < dv1.ToTable().Rows.Count)
            {

                String divText = dv1.ToTable().Rows[i][1].ToString();
                Label3.Text = dv1.ToTable().Rows[i][0].ToString();


                Panel13.Controls.Add(new LiteralControl("<p  align='justify'><font size=4><b><div style='word-wrap:break-word;'>Q" + dv1.ToTable().Rows[i][0].ToString() + ".  " + divText + "</b><p align=right>Posted By :" + dv1.ToTable().Rows[i][2].ToString() + "&nbsp;&nbsp;" + dv1.ToTable().Rows[i][3].ToString() + "&nbsp;</p></div></font></p>"));
                for (; j < dv.ToTable().Rows.Count; j++)
                {
                    if (dv1.ToTable().Rows[i][0].ToString() != dv.ToTable().Rows[j][0].ToString())
                    {
                        break;
                    }
                    String divAns = dv.ToTable().Rows[j][1].ToString() + "<p align=right>Posted By :" + dv.ToTable().Rows[j][2].ToString() + "&nbsp;&nbsp;" + dv.ToTable().Rows[j][3].ToString() + "&nbsp;</p>";
                    Panel13.Controls.Add(new LiteralControl("<p  align='justify'><font size=3><div style='word-wrap:break-word;'>" + divAns + "</div></font></p>"));
                }
                Panel4.Visible = true;
            }
            else
                Panel4.Visible = false;
            i++;
            if (i < dv1.ToTable().Rows.Count)
            {
                String divText = dv1.ToTable().Rows[i][1].ToString();
                Label4.Text = dv1.ToTable().Rows[i][0].ToString();


                Panel14.Controls.Add(new LiteralControl("<p  align='justify'><font size=4><b><div style='word-wrap:break-word;'>Q" + dv1.ToTable().Rows[i][0].ToString() + ".  " + divText + "</b><p align=right>Posted By :" + dv1.ToTable().Rows[i][2].ToString() + "&nbsp;&nbsp;" + dv1.ToTable().Rows[i][3].ToString() + "&nbsp;</p></div></font></p>"));
                for (; j < dv.ToTable().Rows.Count; j++)
                {
                    if (dv1.ToTable().Rows[i][0].ToString() != dv.ToTable().Rows[j][0].ToString())
                    {
                        break;
                    }
                    String divAns = dv.ToTable().Rows[j][1].ToString() + "<p align=right>Posted By :" + dv.ToTable().Rows[j][2].ToString() + "&nbsp;&nbsp;" + dv.ToTable().Rows[j][3].ToString() + "&nbsp;</p>";
                    Panel14.Controls.Add(new LiteralControl("<p  align='justify'><font size=3><div style='word-wrap:break-word;'>" + divAns + "</div></font></p>"));
                }
                Panel6.Visible = true;
            }
            else
                Panel6.Visible = false;
            i++;
            if (i < dv1.ToTable().Rows.Count)
            {

                String divText = dv1.ToTable().Rows[i][1].ToString();
                Label5.Text = dv1.ToTable().Rows[i][0].ToString();


                Panel15.Controls.Add(new LiteralControl("<p  align='justify'><font size=4><b><div style='word-wrap:break-word;'>Q" + dv1.ToTable().Rows[i][0].ToString() + ".  " + divText + "</b><p align=right>Posted By :" + dv1.ToTable().Rows[i][2].ToString() + "&nbsp;&nbsp;" + dv1.ToTable().Rows[i][3].ToString() + "&nbsp;</p></div></font></p>"));
                for (; j < dv.ToTable().Rows.Count; j++)
                {
                    if (dv1.ToTable().Rows[i][0].ToString() != dv.ToTable().Rows[j][0].ToString())
                    {
                        break;
                    }
                    String divAns = dv.ToTable().Rows[j][1].ToString() + "<p align=right>Posted By :" + dv.ToTable().Rows[j][2].ToString() + "&nbsp;&nbsp;" + dv.ToTable().Rows[j][3].ToString() + "&nbsp;</p>";
                    Panel15.Controls.Add(new LiteralControl("<p  align='justify'><font size=3><div style='word-wrap:break-word;'>" + divAns + "</div></font></p>"));
                }
                Panel8.Visible = true;
            }
            else
                Panel8.Visible = false;
            i++;

            if (dv1.ToTable().Rows.Count == ds1.Tables[0].Rows.Count)
            {
                LinkButton2.Enabled = false;
                LinkButton1.Enabled = false;
            }
            else
            {
                LinkButton2.Enabled = true;
                LinkButton1.Enabled = true;
            }

            if (dv1.ToTable().Rows.Count <= 4)
            {
                LinkButton3.Enabled = false;
                LinkButton4.Enabled = false;
            }
            else
            {
                LinkButton3.Enabled = true;
                LinkButton4.Enabled = true;
            }

        }

        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            j = 0;
            i = 0;
            DataView dv = ds2.Tables[0].DefaultView;
            dv.RowFilter = "qid<=" + (Convert.ToInt32(Label2.Text) - 4);
            dv.Sort = "qid desc";
            DataView dv1 = ds1.Tables[0].DefaultView;
            dv1.RowFilter = "qid<=" + (Convert.ToInt32(Label2.Text) - 4);
            dv1.Sort = "qid desc";

            if (i < dv1.ToTable().Rows.Count)
            {

                String divText = dv1.ToTable().Rows[i][1].ToString();
                Label2.Text = dv1.ToTable().Rows[i][0].ToString();
                Panel12.Controls.Add(new LiteralControl("<p  align='justify'><font size=4><b><div style='word-wrap:break-word;'>Q" + dv1.ToTable().Rows[i][0].ToString() + ".  " + divText + "</b><p align=right>Posted By :" + dv1.ToTable().Rows[i][2].ToString() + "&nbsp;&nbsp;" + dv1.ToTable().Rows[i][3].ToString() + "&nbsp;</p></div></font></p>"));
                for (; j < dv.ToTable().Rows.Count; j++)
                {
                    if (dv1.ToTable().Rows[i][0].ToString() != dv.ToTable().Rows[j][0].ToString())
                    {
                        break;
                    }
                    String divAns = dv.ToTable().Rows[j][1].ToString() + "<p align=right>Posted By :" + dv.ToTable().Rows[j][2].ToString() + "&nbsp;&nbsp;" + dv.ToTable().Rows[j][3].ToString() + "&nbsp;</p>";
                    Panel12.Controls.Add(new LiteralControl("<p  align='justify'><font size=3><div style='word-wrap:break-word;'>" + divAns + "</div></font></p>"));
                }

                Panel2.Visible = true;
            }
            else
                Panel2.Visible = false;
            i++;
            if (i < dv1.ToTable().Rows.Count)
            {

                String divText = dv1.ToTable().Rows[i][1].ToString();
                Label3.Text = dv1.ToTable().Rows[i][0].ToString();
                Panel13.Controls.Add(new LiteralControl("<p  align='justify'><font size=4><b><div style='word-wrap:break-word;'>Q" + dv1.ToTable().Rows[i][0].ToString() + ".  " + divText + "</b><p align=right>Posted By :" + dv1.ToTable().Rows[i][2].ToString() + "&nbsp;&nbsp;" + dv1.ToTable().Rows[i][3].ToString() + "&nbsp;</p></div></font></p>"));
                for (; j < dv.ToTable().Rows.Count; j++)
                {
                    if (dv1.ToTable().Rows[i][0].ToString() != dv.ToTable().Rows[j][0].ToString())
                    {
                        break;
                    }
                    String divAns = dv.ToTable().Rows[j][1].ToString() + "<p align=right>Posted By :" + dv.ToTable().Rows[j][2].ToString() + "&nbsp;&nbsp;" + dv.ToTable().Rows[j][3].ToString() + "&nbsp;</p>";
                    Panel13.Controls.Add(new LiteralControl("<p  align='justify'><font size=3><div style='word-wrap:break-word;'>" + divAns + "</div></font></p>"));
                }
                Panel4.Visible = true;
            }
            else
                Panel4.Visible = false;
            i++;
            if (i < dv1.ToTable().Rows.Count)
            {
                String divText = dv1.ToTable().Rows[i][1].ToString();
                Label4.Text = dv1.ToTable().Rows[i][0].ToString();
                Panel14.Controls.Add(new LiteralControl("<p  align='justify'><font size=4><b><div style='word-wrap:break-word;'>Q" + dv1.ToTable().Rows[i][0].ToString() + ".  " + divText + "</b><p align=right>Posted By :" + dv1.ToTable().Rows[i][2].ToString() + "&nbsp;&nbsp;" + dv1.ToTable().Rows[i][3].ToString() + "&nbsp;</p></div></font></p>"));
                for (; j < dv.ToTable().Rows.Count; j++)
                {
                    if (dv1.ToTable().Rows[i][0].ToString() != dv.ToTable().Rows[j][0].ToString())
                    {
                        break;
                    }
                    String divAns = dv.ToTable().Rows[j][1].ToString() + "<p align=right>Posted By :" + dv.ToTable().Rows[j][2].ToString() + "&nbsp;&nbsp;" + dv.ToTable().Rows[j][3].ToString() + "&nbsp;</p>";
                    Panel14.Controls.Add(new LiteralControl("<p  align='justify'><font size=3><div style='word-wrap:break-word;'>" + divAns + "</div></font></p>"));
                }
                Panel6.Visible = true;
            }
            else
                Panel6.Visible = false;
            i++;
            if (i < dv1.ToTable().Rows.Count)
            {

                String divText = dv1.ToTable().Rows[i][1].ToString();
                Label5.Text = dv1.ToTable().Rows[i][0].ToString();
                Panel15.Controls.Add(new LiteralControl("<p  align='justify'><font size=4><b><div style='word-wrap:break-word;'>Q" + dv1.ToTable().Rows[i][0].ToString() + ".  " + divText + "</b><p align=right>Posted By :" + dv1.ToTable().Rows[i][2].ToString() + "&nbsp;&nbsp;" + dv1.ToTable().Rows[i][3].ToString() + "&nbsp;</p></div></font></p>"));
                for (; j < dv.ToTable().Rows.Count; j++)
                {
                    if (dv1.ToTable().Rows[i][0].ToString() != dv.ToTable().Rows[j][0].ToString())
                    {
                        break;
                    }
                    String divAns = dv.ToTable().Rows[j][1].ToString() + "<p align=right>Posted By :" + dv.ToTable().Rows[j][2].ToString() + "&nbsp;&nbsp;" + dv.ToTable().Rows[j][3].ToString() + "&nbsp;</p>";
                    Panel15.Controls.Add(new LiteralControl("<p  align='justify'><font size=3><div style='word-wrap:break-word;'>" + divAns + "</div></font></p>"));
                }
                Panel8.Visible = true;
            }
            else
                Panel8.Visible = false;
            i++;
            if (dv1.ToTable().Rows.Count == ds1.Tables[0].Rows.Count)
            {
                LinkButton2.Enabled = false;
                LinkButton1.Enabled = false;
            }
            else
            {
                LinkButton2.Enabled = true;
                LinkButton1.Enabled = true;
            }

            if (dv1.ToTable().Rows.Count <= 4)
            {
                LinkButton3.Enabled = false;
                LinkButton4.Enabled = false;
            }
            else
            {
                LinkButton3.Enabled = true;
                LinkButton4.Enabled = true;
            }

        }

        protected void LinkButton4_Click(object sender, EventArgs e)
        {
            int n = ds1.Tables[0].Rows.Count;
            n = n % 4;
            if (n == 0)
                n = 4;
            j = 0;
            i = 0;


            DataView dv = ds2.Tables[0].DefaultView;
            dv.RowFilter = "qid<=" + n;
            dv.Sort = "qid desc";
            DataView dv1 = ds1.Tables[0].DefaultView;
            dv1.RowFilter = "qid<=" + n;
            dv1.Sort = "qid desc";

            if (i < dv1.ToTable().Rows.Count)
            {

                String divText = dv1.ToTable().Rows[i][1].ToString();
                Label2.Text = dv1.ToTable().Rows[i][0].ToString();
                Panel12.Controls.Add(new LiteralControl("<p  align='justify'><font size=4><b><div style='word-wrap:break-word;'>Q" + dv1.ToTable().Rows[i][0].ToString() + ".  " + divText + "</b><p align=right>Posted By :" + dv1.ToTable().Rows[i][2].ToString() + "&nbsp;&nbsp;" + dv1.ToTable().Rows[i][3].ToString() + "&nbsp;</p></div></font></p>"));
                for (; j < dv.ToTable().Rows.Count; j++)
                {
                    if (dv1.ToTable().Rows[i][0].ToString() != dv.ToTable().Rows[j][0].ToString())
                    {
                        break;
                    }
                    String divAns = dv.ToTable().Rows[j][1].ToString() + "<p align=right>Posted By :" + dv.ToTable().Rows[j][2].ToString() + "&nbsp;&nbsp;" + dv.ToTable().Rows[j][3].ToString() + "&nbsp;</p>";
                    Panel12.Controls.Add(new LiteralControl("<p  align='justify'><font size=3><div style='word-wrap:break-word;'>" + divAns + "</div></font></p>"));
                }

                Panel2.Visible = true;
            }
            else
                Panel2.Visible = false;
            i++;
            if (i < dv1.ToTable().Rows.Count)
            {

                String divText = dv1.ToTable().Rows[i][1].ToString();
                Label3.Text = dv1.ToTable().Rows[i][0].ToString();
                Panel13.Controls.Add(new LiteralControl("<p  align='justify'><font size=4><b><div style='word-wrap:break-word;'>Q" + dv1.ToTable().Rows[i][0].ToString() + ".  " + divText + "</b><p align=right>Posted By :" + dv1.ToTable().Rows[i][2].ToString() + "&nbsp;&nbsp;" + dv1.ToTable().Rows[i][3].ToString() + "&nbsp;</p></div></font></p>"));
                for (; j < dv.ToTable().Rows.Count; j++)
                {
                    if (dv1.ToTable().Rows[i][0].ToString() != dv.ToTable().Rows[j][0].ToString())
                    {
                        break;
                    }
                    String divAns = dv.ToTable().Rows[j][1].ToString() + "<p align=right>Posted By :" + dv.ToTable().Rows[j][2].ToString() + "&nbsp;&nbsp;" + dv.ToTable().Rows[j][3].ToString() + "&nbsp;</p>";
                    Panel13.Controls.Add(new LiteralControl("<p  align='justify'><font size=3><div style='word-wrap:break-word;'>" + divAns + "</div></font></p>"));
                }
                Panel4.Visible = true;
            }
            else
                Panel4.Visible = false;
            i++;
            if (i < dv1.ToTable().Rows.Count)
            {
                String divText = dv1.ToTable().Rows[i][1].ToString();
                Label4.Text = dv1.ToTable().Rows[i][0].ToString();
                Panel14.Controls.Add(new LiteralControl("<p  align='justify'><font size=4><b><div style='word-wrap:break-word;'>Q" + dv1.ToTable().Rows[i][0].ToString() + ".  " + divText + "</b><p align=right>Posted By :" + dv1.ToTable().Rows[i][2].ToString() + "&nbsp;&nbsp;" + dv1.ToTable().Rows[i][3].ToString() + "&nbsp;</p></div></font></p>"));
                for (; j < dv.ToTable().Rows.Count; j++)
                {
                    if (dv1.ToTable().Rows[i][0].ToString() != dv.ToTable().Rows[j][0].ToString())
                    {
                        break;
                    }
                    String divAns = dv.ToTable().Rows[j][1].ToString() + "<p align=right>Posted By :" + dv.ToTable().Rows[j][2].ToString() + "&nbsp;&nbsp;" + dv.ToTable().Rows[j][3].ToString() + "&nbsp;</p>";
                    Panel14.Controls.Add(new LiteralControl("<p  align='justify'><font size=3><div style='word-wrap:break-word;'>" + divAns + "</div></font></p>"));
                }
                Panel6.Visible = true;
            }
            else
                Panel6.Visible = false;
            i++;
            if (i < dv1.ToTable().Rows.Count)
            {

                String divText = dv1.ToTable().Rows[i][1].ToString();
                Label5.Text = dv1.ToTable().Rows[i][0].ToString();
                Panel15.Controls.Add(new LiteralControl("<p  align='justify'><font size=4><b><div style='word-wrap:break-word;'>Q" + dv1.ToTable().Rows[i][0].ToString() + ".  " + divText + "</b><p align=right>Posted By :" + dv1.ToTable().Rows[i][2].ToString() + "&nbsp;&nbsp;" + dv1.ToTable().Rows[i][3].ToString() + "&nbsp;</p></div></font></p>"));
                for (; j < dv.ToTable().Rows.Count; j++)
                {
                    if (dv1.ToTable().Rows[i][0].ToString() != dv.ToTable().Rows[j][0].ToString())
                    {
                        break;
                    }
                    String divAns = dv.ToTable().Rows[j][1].ToString() + "<p align=right>Posted By :" + dv.ToTable().Rows[j][2].ToString() + "&nbsp;&nbsp;" + dv.ToTable().Rows[j][3].ToString() + "&nbsp;</p>";
                    Panel15.Controls.Add(new LiteralControl("<p  align='justify'><font size=3><div style='word-wrap:break-word;'>" + divAns + "</div></font></p>"));
                }
                Panel8.Visible = true;
            }
            else
                Panel8.Visible = false;
            i++;
            LinkButton3.Enabled = false;
            LinkButton4.Enabled = false;
            if (dv1.ToTable().Rows.Count == ds1.Tables[0].Rows.Count)
            {
                LinkButton2.Enabled = false;
                LinkButton1.Enabled = false;
            }
            else
            {
                LinkButton2.Enabled = true;
                LinkButton1.Enabled = true;
            }

            if (dv1.ToTable().Rows.Count <= 4)
            {
                LinkButton3.Enabled = false;
                LinkButton4.Enabled = false;
            }
            else
            {
                LinkButton3.Enabled = true;
                LinkButton4.Enabled = true;
            }

        }

        protected void LinkButton6_Click(object sender, EventArgs e)
        {
            Session.Remove("fid");
            Session.RemoveAll();
            Response.Redirect("Forum_Login.aspx");
        }
    }
}