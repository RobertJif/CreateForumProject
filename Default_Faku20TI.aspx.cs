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
    public partial class Default_Faku20TI : System.Web.UI.Page
    {
        string username;
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["FRCon"].ConnectionString);

        protected void Page_Load(object sender, EventArgs e)
        {


            if (Session["nam"] == null)
            {
                Session["nam"] = 0;
                LoadPost();


            }
            else
            {
                username = Session["nam"].ToString();
                divwelcome.Visible = true;
                //divlogout.Visible = true;
                div_log_reg_ribbon.Visible = false;
                //div_dashboard_box.Visible = true;
                lblwelcom.InnerText = username.ToString();
                LoadPost();

            }
            //if (!IsPostBack)
            //{
            //    username = Session["nam"].ToString();
            //    divwelcome.InnerHtml = username.ToString();
            //    div_dashboard_box.Visible = true;
            //    LoadPost();
            //}
            //else
            //{
            //    Response.Redirect("~/Comment_g15.aspx?field1="+id);
            //    //"Comment_G15.aspx?field1="+id+"
            //}




        }
        public void LoadPost()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["FRCon"].ConnectionString);
            SqlDataAdapter da = new SqlDataAdapter("Select * from forum_postfaku ORDER BY postid DESC", con);
            con.Open();
            DataSet ds = new DataSet();
            da.Fill(ds);
            con.Close();
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

                    //HtmlGenericControl Comment = new HtmlGenericControl("comment");
                    //Comment.InnerText = "komentar";


                    if (postmsg.Length > 0)
                    {
                        divpostmsg.InnerText = postmsg;
                    }
                    HtmlGenericControl divreader = new HtmlGenericControl("div");
                    divreader.Attributes.Add("class", "divreader");
                    divpost.Controls.Add(divreader);

                    /* Post Read More */
                    //HtmlGenericControl btnReadMore = new HtmlGenericControl("a");
                    //btnReadMore.Attributes.Add("class", "btnreadmore");
                    //btnReadMore.InnerText = "Reply";
                    //btnReadMore.InnerHtml = "<a href=\"Comment_G15.aspx?field1="+id+"\">Lihat Diskusi</a>";
                    //divreader.Controls.Add(btnReadMore);



                    //if (!IsPostBack)

                    //{

                    //    Response.Redirect("~/Comment_g15.aspx?field1=" + id);
                    //    //"Comment_G15.aspx?field1="+id+"
                    //}

                    /* Post Read More */
                    HtmlGenericControl btnReadMore = new HtmlGenericControl("button");
                    btnReadMore.Attributes.Add("class", "btnreadmore");
                    //btnReadMore.InnerText = "Lihat";
                    //btnReadMore.Attributes.Add("href", "javascript:readarticles()");
                    btnReadMore.InnerHtml = "<a href=\"Comment_faku20TI.aspx?field1=" + id + "\">Komentar</a>";
                    divreader.Controls.Add(btnReadMore);


                    divpost.Controls.Add(lblauthor);
                    divpost.Controls.Add(h2);
                    divpost.Controls.Add(divpostmsg);
                    divpost.Controls.Add(divreader);
                    //divpost.Controls.Add(Comment);
                    div_post_display_panel.Controls.Add(divpost);
                    //txtComment.Controls.Add(divpost);
                }
            }
        }
        public void ReadArticles1(string id)
        {
            Response.Write(id);
        }
    }
}