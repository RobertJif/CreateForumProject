using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace Create_Forum_Project
{
    public partial class Comment_TET : System.Web.UI.Page
    {
        string user1;
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["FRCon"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {

            user1 = Session["nam"].ToString();
            lblwelcom.InnerHtml = user1.ToString();
            //div_dashboard_box.Visible = true;

            String s = Request.QueryString["field1"];
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["FRCon"].ConnectionString);
            SqlDataAdapter da = new SqlDataAdapter("Select * from forum_post15tet where postid=" + s, con);
            con.Open();
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    string id = ds.Tables[0].Rows[i]["postid"].ToString();
                    string author = ds.Tables[0].Rows[i]["username"].ToString();
                    string title = ds.Tables[0].Rows[i]["posttitle"].ToString();
                    string postmsg = ds.Tables[0].Rows[i]["postmessage"].ToString();
                    HtmlGenericControl divpost = new HtmlGenericControl("div");
                    divpost.Attributes.Add("class", "div_post_display");
                    divpost.Attributes.Add("id", id);
                    /* Post Authro */
                    HtmlGenericControl lblauthor = new HtmlGenericControl("label");
                    lblauthor.Attributes.Add("class", "divauthor");
                    lblauthor.InnerText = "Author :" + author; ;
                    /* Post Title (H2) */
                    HtmlGenericControl h2 = new HtmlGenericControl("h2");
                    h2.InnerText = title.ToString();
                    /* Post Message */
                    HtmlGenericControl divpostmsg = new HtmlGenericControl("div");
                    divpostmsg.Attributes.Add("class", "divpostmsg");


                    if (postmsg.Length > 0)
                    {
                        divpostmsg.InnerText = postmsg;
                    }
                    HtmlGenericControl divreader = new HtmlGenericControl("div");
                    divreader.Attributes.Add("class", "divreader");
                    divpost.Controls.Add(divreader);


                    divpost.Controls.Add(lblauthor);
                    divpost.Controls.Add(h2);
                    divpost.Controls.Add(divpostmsg);
                    divpost.Controls.Add(divreader);
                    //divpost.Controls.Add(Comment);
                    div_post_display_panel.Controls.Add(divpost);
                    //div_dashboard_box.Visible = true;
                    lblwelcom.InnerText = user1.ToString();


                }
            }



            con = new SqlConnection(ConfigurationManager.ConnectionStrings["FRCon"].ConnectionString);
            da = new SqlDataAdapter("Select * from komen_tet  where postid=" + s, con);
            con.Open();
            ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    string id = ds.Tables[0].Rows[i]["postid"].ToString();
                    string author = ds.Tables[0].Rows[i]["nama"].ToString();
                    string komen = ds.Tables[0].Rows[i]["comment"].ToString();
                    HtmlGenericControl divpost = new HtmlGenericControl("div");
                    divpost.Attributes.Add("class", "div_post_display");
                    divpost.Attributes.Add("id", id);
                    /* Post Authro */
                    HtmlGenericControl lblauthor = new HtmlGenericControl("label");
                    lblauthor.Attributes.Add("class", "divauthor");
                    lblauthor.InnerText = "Author :" + author; ;
                    /* Post Title (H2) */
                    HtmlGenericControl h2 = new HtmlGenericControl("h2");
                    h2.InnerText = komen.ToString();
                    /* Post Message */


                    HtmlGenericControl divreader = new HtmlGenericControl("div");
                    divreader.Attributes.Add("class", "divreader");
                    divpost.Controls.Add(divreader);


                    divpost.Controls.Add(lblauthor);
                    divpost.Controls.Add(h2);
                    divpost.Controls.Add(divreader);
                    //divpost.Controls.Add(Comment);
                    Panel2.Controls.Add(divpost);
                }
        }

        protected void BtnPost_Click(object sender, EventArgs e)
        {
            String user1 = Session["nam"].ToString();
            String s = Request.QueryString["field1"];
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["FRCon"].ConnectionString);
            SqlCommand cmd = new SqlCommand("Insert into komen_tet(comment, postid, nama) values ('" + txtComment.Text + "', '" + s + "', '" + user1 + "')", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            //BtnPost.Click -= new EventHandler(BtnPost_Click);
            //BtnPost.Click += new EventHandler(BtnPost_Click);
            //Response.Redirect("Comment_g15.aspx");
            Page.Response.Redirect(Page.Request.Url.ToString(), true);
        }
    }
}