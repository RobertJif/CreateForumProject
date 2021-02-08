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
    public partial class Home_15AK : System.Web.UI.Page
    {
        string user1;
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["FRCon"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                user1 = Session["nam"].ToString();
                welcome.InnerHtml = user1.ToString();
                //div_dashboard_box.Visible = true;
                LoadPost();
            }
            else
            {
                Response.Redirect("~/Default_15AK.aspx");
            }
        }
        /*
        private void GenerateControls()
        {
            if (Session["divCount"] != null)
            {
                int divID = (int)Session["divCount"];

                for (int i = 0; i < divID; i++)
                {
                    HtmlGenericControl divpost = new HtmlGenericControl("div");
                    divpost.Attributes.Add("class", "div_post_display");
                    divpost.Attributes.Add("id", (i + 1).ToString());

                    div_post_display_panel.Controls.Add(divpost);
                }
            }
        }
        
        protected void Btn_Add_div_Click(object sender, EventArgs e)
        {
            if (Session["divCount"] == null)
                Session["divCount"] = 1;
            else
            {
                int divID = (int)Session["divCount"];
                divID++;
                Session["divCount"] = divID;
            }

            HtmlGenericControl divpost = new HtmlGenericControl("div");
            divpost.Attributes.Add("class", "div_post_display");
            divpost.Attributes.Add("id", Session["divCount"].ToString());
            //divpost.Attributes.Add("InnerText") = "hello world";
            HtmlGenericControl h2 = new HtmlGenericControl("h2");
            h2.InnerText = "hello world";
            divpost.Controls.Add(h2);

            div_post_display_panel.Controls.Add(divpost);
        }
        */
        public void LoadPost()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from forum_post15ak where username='" + user1 + "'", con);
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


                    HtmlGenericControl btnReadMore = new HtmlGenericControl("button");
                    btnReadMore.Attributes.Add("class", "btnreadmore");
                    //btnReadMore.InnerText = "Lihat";
                    //btnReadMore.Attributes.Add("href", "javascript:readarticles()");
                    btnReadMore.InnerHtml = "<a href=\"Comment_AK.aspx?field1=" + id + "\">Komentar</a>";
                    divreader.Controls.Add(btnReadMore);


                    /* Post Read More */
                    //HtmlGenericControl btnReadMore = new HtmlGenericControl("button");
                    //btnReadMore.Attributes.Add("class", "btnreadmore");
                    //btnReadMore.InnerText = "Lihat";
                    //btnReadMore.Attributes.Add("href", "javascript:readarticles()");
                    //divreader.Controls.Add(btnReadMore);

                    divpost.Controls.Add(lblauthor);
                    divpost.Controls.Add(h2);
                    divpost.Controls.Add(divpostmsg);
                    divpost.Controls.Add(divreader);
                    div_post_display_panel.Controls.Add(divpost);
                }
            }
        }
        /*
        protected void Btn_Add_div0_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["FRCon"].ConnectionString);
            SqlDataAdapter da = new SqlDataAdapter("Select * from Forum_Post where username='" + user1 + "'", con);
            con.Open();
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {


                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    string id = ds.Tables[0].Rows[i]["postid"].ToString();
                    string title = ds.Tables[0].Rows[i]["posttitle"].ToString();
                    string postmsg = ds.Tables[0].Rows[0]["postmessage"].ToString();
                    HtmlGenericControl divpost = new HtmlGenericControl("div");
                    divpost.Attributes.Add("class", "div_post_display");
                    divpost.Attributes.Add("id", id);
                    HtmlGenericControl h2 = new HtmlGenericControl("h2");
                    h2.InnerText = title.ToString();
                    HtmlGenericControl divpostmsg = new HtmlGenericControl("div");
                    divpostmsg.Attributes.Add("class", "divpostmsg");
                    divpostmsg.InnerText = postmsg.ToString();
                    divpost.Controls.Add(h2);
                    divpost.Controls.Add(divpostmsg);

                    div_post_display_panel.Controls.Add(divpost);
                    Response.Write(ds.Tables[0].Rows[i]["postid"].ToString());
                }
            }
        }
        */
        public void ReadArticles1(string id)
        {
            Response.Write(id);
        }
    }
}
