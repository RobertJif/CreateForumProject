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
    public partial class admin_teknologi : System.Web.UI.Page
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
        }
        public void LoadPost()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["FRCon"].ConnectionString);
            SqlDataAdapter da = new SqlDataAdapter("Select * from klasifikasiteknologi", con);
            con.Open();
            DataSet ds = new DataSet();

            da.Fill(ds);
            con.Close();


            if (ds.Tables[0].Rows.Count > 0)
            {


                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {


                    string berita = ds.Tables[0].Rows[i]["teknologi"].ToString();
                    HtmlGenericControl divpost = new HtmlGenericControl("div");
                    divpost.Attributes.Add("class", "div_post_display");

                    /* Post Authro */
                    HtmlGenericControl lblauthor = new HtmlGenericControl("label");

                    /* Post Title (H2) */
                    HtmlGenericControl h2 = new HtmlGenericControl("h2");
                    h2.InnerText = berita.ToString();
                    /* Post Message */

                    //HtmlGenericControl Comment = new HtmlGenericControl("comment");
                    //Comment.InnerText = "komentar";



                    HtmlGenericControl divreader = new HtmlGenericControl("div");
                    divreader.Attributes.Add("class", "divreader");
                    divpost.Controls.Add(divreader);



                    /* Post Read More */
                    HtmlGenericControl btnReadMore = new HtmlGenericControl("button");
                    btnReadMore.Attributes.Add("class", "btnreadmore");


                    divpost.Controls.Add(lblauthor);
                    divpost.Controls.Add(h2);

                    //divpost.Controls.Add(Comment);
                    div_post_display_panel.Controls.Add(divpost);
                    //txtComment.Controls.Add(divpost);
                    int rows = ds.Tables[0].Rows.Count;
                    lbljumlah.Text = "Jumlah Diskusi Teknologi: " + rows.ToString();
                }
            }
        }

    }
}