﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Create_Forum_Project
{
    public partial class G15TK : System.Web.UI.Page
    {
        string username;

        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["nam"] == null)
            {
                Session["nam"] = 0;


            }
            else
            {
                username = Session["nam"].ToString();
                divwelcome.Visible = true;
                //divlogout.Visible = true;
                div_log_reg_ribbon.Visible = false;
                //div_dashboard_box.Visible = true;
                lblwelcom.InnerText = username.ToString();


            }

        }

    }
}