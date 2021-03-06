﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Create_Forum_Project
{
    public partial class Dashboard_G14 : System.Web.UI.Page
    {
        string user1;
        string datetime = System.DateTime.Now.Date.ToLongDateString();
        protected void Page_Load(object sender, EventArgs e)
        {
            user1 = Session["nam"].ToString();
            lblwelcom.InnerHtml = user1.ToString();
            div_dashboard_box.Visible = true;
        }

        protected void BtnPost_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["FRCon"].ConnectionString);
            SqlCommand cmd = new SqlCommand("Insert into Forum_Post_G14(username, posttitle, postmessage) values ('" + user1 + "','" + txtposttitle.Text + "', '" + txtpostmessage.InnerText.ToString() + "')", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            Response.Redirect("~/Home_G14.aspx");
        }
    }
}