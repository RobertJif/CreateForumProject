using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace Create_Forum_Project
{
    public partial class forumLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //protected void Btn_Login_Click(object sender, EventArgs e)
        //{
        //    int flag = 0;
        //    string nim="";
        //    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["FRCon"].ConnectionString);
        //    SqlCommand cmd = new SqlCommand("select * from Forum_Registration where username='" + txtusername.Text + "'", con);
        //    con.Open();
        //    SqlDataReader dr;
        //    dr = cmd.ExecuteReader();
        //    while (dr.Read())
        //    {
        //        if (dr["username"].ToString().Equals(txtusername.Text) && dr["password"].ToString().Equals(txtpassword.Text))
        //        {
        //            flag = 1;
        //            nim = dr["nim"].ToString();
        //            break;
        //        }
        //    }
        //    nim = nim.Substring(0, 4);
        //    if (nim.Equals("1455"))
        //    {
        //        if (flag == 1)
        //        {
        //            Session["nam"] = txtusername.Text;
        //            Response.Redirect("~/G14TI.aspx");
        //        }
        //        else
        //        {
        //            Response.Write("Invalid Username and Password");
        //        }
        //    }
        //    if (nim.Equals("1555"))
        //    {
        //        if (flag == 1)
        //        {
        //            Session["nam"] = txtusername.Text;
        //            Response.Redirect("~/G15TI.aspx");
        //        }
        //        else
        //        {
        //            Response.Write("Invalid Username and Password");
        //        }
        //    }
        //    if (nim.Equals("1655"))
        //    {
        //        if (flag == 1)
        //        {
        //            Session["nam"] = txtusername.Text;
        //            Response.Redirect("~/G16TI.aspx");
        //        }
        //        else
        //        {
        //            Response.Write("Invalid Username and Password");
        //        }
        //    }
        //    if (nim.Equals("1755"))
        //    {
        //        if (flag == 1)
        //        {
        //            Session["nam"] = txtusername.Text;
        //            Response.Redirect("~/G17TI.aspx");
        //        }
        //        else
        //        {
        //            Response.Write("Invalid Username and Password");
        //        }
        //    }

        //    if (nim.Equals("1457"))
        //    {
        //        if (flag == 1)
        //        {
        //            Session["nam"] = txtusername.Text;
        //            Response.Redirect("~/G14SI.aspx");
        //        }
        //        else
        //        {
        //            Response.Write("Invalid Username and Password");
        //        }
        //    }
        //    if (nim.Equals("1557"))
        //    {
        //        if (flag == 1)
        //        {
        //            Session["nam"] = txtusername.Text;
        //            Response.Redirect("~/G15SI.aspx");
        //        }
        //        else
        //        {
        //            Response.Write("Invalid Username and Password");
        //        }
        //    }
        //    if (nim.Equals("1657"))
        //    {
        //        if (flag == 1)
        //        {
        //            Session["nam"] = txtusername.Text;
        //            Response.Redirect("~/G16SI.aspx");
        //        }
        //        else
        //        {
        //            Response.Write("Invalid Username and Password");
        //        }
        //    }
        //    if (nim.Equals("1757"))
        //    {
        //        if (flag == 1)
        //        {
        //            Session["nam"] = txtusername.Text;
        //            Response.Redirect("~/G17SI.aspx");
        //        }
        //        else
        //        {
        //            Response.Write("Invalid Username and Password");
        //        }
        //    }


        //if (txtNim.Text.Contains("1455"))
        //{

        //    int flag = 0;
        //    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["FRCon"].ConnectionString);
        //    SqlCommand cmd = new SqlCommand("select * from Forum_Registration where username='" + txtusername.Text + "'", con);
        //    con.Open();
        //    if (con.State == ConnectionState.Open)
        //    {
        //        SqlDataReader dr;
        //        dr = cmd.ExecuteReader();
        //        while (dr.Read())
        //        {
        //            if (dr["username"].ToString().Equals(txtusername.Text) && dr["password"].ToString().Equals(txtpassword.Text))
        //            {
        //                flag = 1;
        //                break;
        //            }
        //        }
        //        if (flag == 1)
        //        {
        //            Session["nam"] = txtusername.Text;
        //            Response.Redirect("~/G14TI.aspx");
        //        }
        //    }
        //    Response.Write("Invalid Username and Password");

        //}   

        //else if (txtNim.Text.Contains("1466"))
        //{

        //    int flag = 0;
        //    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["FRCon"].ConnectionString);
        //    SqlCommand cmd = new SqlCommand("select * from Regis2 where username='" + txtusername.Text + "'", con);
        //    con.Open();
        //    if (con.State == ConnectionState.Open)
        //    {
        //        SqlDataReader dr;
        //        dr = cmd.ExecuteReader();
        //        while (dr.Read())
        //        {
        //            if (dr["username"].ToString().Equals(txtusername.Text) && dr["password"].ToString().Equals(txtpassword.Text))
        //            {
        //                flag = 1;
        //                break;
        //            }
        //        }
        //        if (flag == 1)
        //        {
        //            Session["nam"] = txtusername.Text;
        //            Response.Redirect("~/G14SI.aspx");
        //        }
        //    }
        //    Response.Write("Invalid Username and Password");

        //}

        //else if (txtNim.Text.Contains("1477"))
        //{

        //    int flag = 0;
        //    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["FRCon"].ConnectionString);
        //    SqlCommand cmd = new SqlCommand("select * from Regis_14TET where username='" + txtusername.Text + "'", con);
        //    con.Open();
        //    if (con.State == ConnectionState.Open)
        //    {
        //        SqlDataReader dr;
        //        dr = cmd.ExecuteReader();
        //        while (dr.Read())
        //        {
        //            if (dr["username"].ToString().Equals(txtusername.Text) && dr["password"].ToString().Equals(txtpassword.Text))
        //            {
        //                flag = 1;
        //                break;
        //            }
        //        }
        //        if (flag == 1)
        //        {
        //            Session["nam"] = txtusername.Text;
        //            Response.Redirect("~/G14TET.aspx");
        //        }
        //    }
        //    Response.Write("Invalid Username and Password");

        //}

        //else if (txtNim.Text.Contains("1488"))
        //{

        //    int flag = 0;
        //    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["FRCon"].ConnectionString);
        //    SqlCommand cmd = new SqlCommand("select * from Regis_14AK where username='" + txtusername.Text + "'", con);
        //    con.Open();
        //    if (con.State == ConnectionState.Open)
        //    {
        //        SqlDataReader dr;
        //        dr = cmd.ExecuteReader();
        //        while (dr.Read())
        //        {
        //            if (dr["username"].ToString().Equals(txtusername.Text) && dr["password"].ToString().Equals(txtpassword.Text))
        //            {
        //                flag = 1;
        //                break;
        //            }
        //        }
        //        if (flag == 1)
        //        {
        //            Session["nam"] = txtusername.Text;
        //            Response.Redirect("~/G14AK.aspx");
        //        }
        //    }
        //    Response.Write("Invalid Username and Password");

        //}

        //else if (txtNim.Text.Contains("1499"))
        //{

        //    int flag = 0;
        //    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["FRCon"].ConnectionString);
        //    SqlCommand cmd = new SqlCommand("select * from Regis_14TM where username='" + txtusername.Text + "'", con);
        //    con.Open();
        //    if (con.State == ConnectionState.Open)
        //    {
        //        SqlDataReader dr;
        //        dr = cmd.ExecuteReader();
        //        while (dr.Read())
        //        {
        //            if (dr["username"].ToString().Equals(txtusername.Text) && dr["password"].ToString().Equals(txtpassword.Text))
        //            {
        //                flag = 1;
        //                break;
        //            }
        //        }
        //        if (flag == 1)
        //        {
        //            Session["nam"] = txtusername.Text;
        //            Response.Redirect("~/G14TM.aspx");
        //        }
        //    }
        //    Response.Write("Invalid Username and Password");

        //}



        //if (txtNim.Text.Contains("1555"))
        //{

        //    int flag = 0;
        //    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["FRCon"].ConnectionString);
        //    SqlCommand cmd = new SqlCommand("select * from Regis_15TI where username='" + txtusername.Text + "'", con);
        //    con.Open();
        //    if (con.State == ConnectionState.Open)
        //    {
        //        SqlDataReader dr;
        //        dr = cmd.ExecuteReader();
        //        while (dr.Read())
        //        {
        //            if (dr["username"].ToString().Equals(txtusername.Text) && dr["password"].ToString().Equals(txtpassword.Text))
        //            {
        //                flag = 1;
        //                break;
        //            }
        //        }
        //        if (flag == 1)
        //        {
        //            Session["nam"] = txtusername.Text;
        //            Response.Redirect("~/G15TI.aspx");
        //        }
        //    }
        //    Response.Write("Invalid Username and Password");

        //}

        //else if (txtNim.Text.Contains("1566"))
        //{

        //    int flag = 0;
        //    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["FRCon"].ConnectionString);
        //    SqlCommand cmd = new SqlCommand("select * from Regis_15SI where username='" + txtusername.Text + "'", con);
        //    con.Open();
        //    if (con.State == ConnectionState.Open)
        //    {
        //        SqlDataReader dr;
        //        dr = cmd.ExecuteReader();
        //        while (dr.Read())
        //        {
        //            if (dr["username"].ToString().Equals(txtusername.Text) && dr["password"].ToString().Equals(txtpassword.Text))
        //            {
        //                flag = 1;
        //                break;
        //            }
        //        }
        //        if (flag == 1)
        //        {
        //            Session["nam"] = txtusername.Text;
        //            Response.Redirect("~/G15SI.aspx");
        //        }
        //    }
        //    Response.Write("Invalid Username and Password");

        //}

        //else if (txtNim.Text.Contains("1577"))
        //{

        //    int flag = 0;
        //    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["FRCon"].ConnectionString);
        //    SqlCommand cmd = new SqlCommand("select * from Regis_15TET where username='" + txtusername.Text + "'", con);
        //    con.Open();
        //    if (con.State == ConnectionState.Open)
        //    {
        //        SqlDataReader dr;
        //        dr = cmd.ExecuteReader();
        //        while (dr.Read())
        //        {
        //            if (dr["username"].ToString().Equals(txtusername.Text) && dr["password"].ToString().Equals(txtpassword.Text))
        //            {
        //                flag = 1;
        //                break;
        //            }
        //        }
        //        if (flag == 1)
        //        {
        //            Session["nam"] = txtusername.Text;
        //            Response.Redirect("~/G15TET.aspx");
        //        }
        //    }
        //    Response.Write("Invalid Username and Password");

        //}

        //else if (txtNim.Text.Contains("1588"))
        //{

        //    int flag = 0;
        //    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["FRCon"].ConnectionString);
        //    SqlCommand cmd = new SqlCommand("select * from Regis_15AK where username='" + txtusername.Text + "'", con);
        //    con.Open();
        //    if (con.State == ConnectionState.Open)
        //    {
        //        SqlDataReader dr;
        //        dr = cmd.ExecuteReader();
        //        while (dr.Read())
        //        {
        //            if (dr["username"].ToString().Equals(txtusername.Text) && dr["password"].ToString().Equals(txtpassword.Text))
        //            {
        //                flag = 1;
        //                break;
        //            }
        //        }
        //        if (flag == 1)
        //        {
        //            Session["nam"] = txtusername.Text;
        //            Response.Redirect("~/G15AK.aspx");
        //        }
        //    }
        //    Response.Write("Invalid Username and Password");

        //}

        //else if (txtNim.Text.Contains("1599"))
        //{

        //    int flag = 0;
        //    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["FRCon"].ConnectionString);
        //    SqlCommand cmd = new SqlCommand("select * from Regis_15TM where username='" + txtusername.Text + "'", con);
        //    con.Open();
        //    if (con.State == ConnectionState.Open)
        //    {
        //        SqlDataReader dr;
        //        dr = cmd.ExecuteReader();
        //        while (dr.Read())
        //        {
        //            if (dr["username"].ToString().Equals(txtusername.Text) && dr["password"].ToString().Equals(txtpassword.Text))
        //            {
        //                flag = 1;
        //                break;
        //            }
        //        }
        //        if (flag == 1)
        //        {
        //            Session["nam"] = txtusername.Text;
        //            Response.Redirect("~/G15TM.aspx");
        //        }
        //    }
        //    Response.Write("Invalid Username and Password");

        //}



        //protected void Btn_Login_Click_Click(object sender, EventArgs e)
        //{
        //int flag = 0;
        //string nim = "";
        //SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["FRCon"].ConnectionString);
        //SqlCommand cmd = new SqlCommand("select * from Forum_Registration where username='" + txtusername.Text + "'", con);
        //con.Open();
        //SqlDataReader dr;
        //dr = cmd.ExecuteReader();
        //while (dr.Read())
        //{
        //    if (dr["username"].ToString().Equals(txtusername.Text) && dr["password"].ToString().Equals(txtpassword.Text))
        //    {
        //        flag = 1;
        //        nim = dr["nim"].ToString();
        //        break;
        //    }
        //}
        //nim = nim.Substring(0, 4);
        //if (nim.Equals("1455"))
        //{
        //    if (flag == 1)
        //    {
        //        Session["nam"] = txtusername.Text;
        //        Response.Redirect("~/G14TI.aspx");
        //    }
        //    else
        //    {
        //        Response.Write("Invalid Username and Password");
        //    }
        //}
        //if (nim.Equals("1555"))
        //{
        //    if (flag == 1)
        //    {
        //        Session["nam"] = txtusername.Text;
        //        Response.Redirect("~/G15TI.aspx");
        //    }
        //    else
        //    {
        //        Response.Write("Invalid Username and Password");
        //    }
        //}
        //if (nim.Equals("1655"))
        //{
        //    if (flag == 1)
        //    {
        //        Session["nam"] = txtusername.Text;
        //        Response.Redirect("~/G16TI.aspx");
        //    }
        //    else
        //    {
        //        Response.Write("Invalid Username and Password");
        //    }
        //}
        //if (nim.Equals("1755"))
        //{
        //    if (flag == 1)
        //    {
        //        Session["nam"] = txtusername.Text;
        //        Response.Redirect("~/G17TI.aspx");
        //    }
        //    else
        //    {
        //        Response.Write("Invalid Username and Password");
        //    }
        //}

        //if (nim.Equals("1457"))
        //{
        //    if (flag == 1)
        //    {
        //        Session["nam"] = txtusername.Text;
        //        Response.Redirect("~/G14SI.aspx");
        //    }
        //    else
        //    {
        //        Response.Write("Invalid Username and Password");
        //    }
        //}
        //if (nim.Equals("1557"))
        //{
        //    if (flag == 1)
        //    {
        //        Session["nam"] = txtusername.Text;
        //        Response.Redirect("~/G15SI.aspx");
        //    }
        //    else
        //    {
        //        Response.Write("Invalid Username and Password");
        //    }
        //}
        //if (nim.Equals("1657"))
        //{
        //    if (flag == 1)
        //    {
        //        Session["nam"] = txtusername.Text;
        //        Response.Redirect("~/G16SI.aspx");
        //    }
        //    else
        //    {
        //        Response.Write("Invalid Username and Password");
        //    }
        //}
        //if (nim.Equals("1757"))
        //{
        //    if (flag == 1)
        //    {
        //        Session["nam"] = txtusername.Text;
        //        Response.Redirect("~/G17SI.aspx");
        //    }
        //    else
        //    {
        //        Response.Write("Invalid Username and Password");
        //}
        //}
        //}

        //protected void Btn_Login_Click(object sender, EventArgs e)
        //{
        //    int flag = 0;
        //    string nim = "";
        //    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["FRCon"].ConnectionString);
        //    SqlCommand cmd = new SqlCommand("select * from Forum_Registration where username='" + txtusername.Text + "'", con);
        //    con.Open();
        //    SqlDataReader dr;
        //    dr = cmd.ExecuteReader();
        //    while (dr.Read())
        //    {
        //        if (dr["username"].ToString().Equals(txtusername.Text) && dr["password"].ToString().Equals(txtpassword.Text))
        //        {
        //            flag = 1;
        //            nim = dr["nim"].ToString();
        //            break;
        //        }
        //    }
        //    nim = nim.Substring(0, 4);
        //    if (nim.Equals("1455"))
        //    {
        //        if (flag == 1)
        //        {
        //            Session["nam"] = txtusername.Text;
        //            Response.Redirect("~/G14TI.aspx");
        //        }
        //        else
        //        {
        //            Response.Write("Invalid Username and Password");
        //        }
        //    }
        //    if (nim.Equals("1555"))
        //    {
        //        if (flag == 1)
        //        {
        //            Session["nam"] = txtusername.Text;
        //            Response.Redirect("~/G15TI.aspx");
        //        }
        //        else
        //        {
        //            Response.Write("Invalid Username and Password");
        //        }
        //    }
        //    if (nim.Equals("1655"))
        //    {
        //        if (flag == 1)
        //        {
        //            Session["nam"] = txtusername.Text;
        //            Response.Redirect("~/G16TI.aspx");
        //        }
        //        else
        //        {
        //            Response.Write("Invalid Username and Password");
        //        }
        //    }
        //    if (nim.Equals("1755"))
        //    {
        //        if (flag == 1)
        //        {
        //            Session["nam"] = txtusername.Text;
        //            Response.Redirect("~/G17TI.aspx");
        //        }
        //        else
        //        {
        //            Response.Write("Invalid Username and Password");
        //        }
        //    }

        //    if (nim.Equals("1457"))
        //    {
        //        if (flag == 1)
        //        {
        //            Session["nam"] = txtusername.Text;
        //            Response.Redirect("~/G14SI.aspx");
        //        }
        //        else
        //        {
        //            Response.Write("Invalid Username and Password");
        //        }
        //    }
        //    if (nim.Equals("1557"))
        //    {
        //        if (flag == 1)
        //        {
        //            Session["nam"] = txtusername.Text;
        //            Response.Redirect("~/G15SI.aspx");
        //        }
        //        else
        //        {
        //            Response.Write("Invalid Username and Password");
        //        }
        //    }
        //    if (nim.Equals("1657"))
        //    {
        //        if (flag == 1)
        //        {
        //            Session["nam"] = txtusername.Text;
        //            Response.Redirect("~/G16SI.aspx");
        //        }
        //        else
        //        {
        //            Response.Write("Invalid Username and Password");
        //        }
        //    }
        //    if (nim.Equals("1757"))
        //    {
        //        if (flag == 1)
        //        {
        //            Session["nam"] = txtusername.Text;
        //            Response.Redirect("~/G17SI.aspx");
        //        }
        //        else
        //        {
        //            Response.Write("Invalid Username and Password");

        //        }
        //    }

        protected void Btn_Login_Click_Click(object sender, EventArgs e)
        {
            int flag = 0;
            string nim = "";
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["FRCon"].ConnectionString);
            SqlCommand cmd = new SqlCommand("select * from Forum_Registration where username='" + txtusername.Text + "'", con);
            con.Open();
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (dr["username"].ToString().Equals(txtusername.Text) && dr["password"].ToString().Equals(txtpassword.Text))
                {
                    flag = 1;
                    nim = dr["nim"].ToString();
                    break;
                }
                
               
            }

            if (nim != "")
            {
                nim = nim.Substring(0, 8);

            }

            else
            {
                Response.Write("<SCRIPT LANGUAGE='JavaScript'> alert('Username atau Password Salah');</script>");
            }
                
           
            if (nim.Equals("17552010"))
            {
                if (flag == 1)
                {
                    Session["nam"] = txtusername.Text;
                    Response.Redirect("~/G17TI.aspx");
                }
                else
                {
                    Response.Write("Invalid Username and Password");
                }
            }
            else if (nim.Equals("18552010"))
            {
                if (flag == 1)
                {
                    Session["nam"] = txtusername.Text;
                    Response.Redirect("~/G18TI.aspx");
                }
                else
                {
                    Response.Write("Invalid Username and Password");
                }
            }

            else if (nim.Equals("19552010"))
            {
                if (flag == 1)
                {
                    Session["nam"] = txtusername.Text;
                    Response.Redirect("~/G19TI.aspx");
                }
                else
                {
                    Response.Write("Invalid Username and Password");
                }
            }

            else if (nim.Equals("20552010"))
            {
                if (flag == 1)
                {
                    Session["nam"] = txtusername.Text;
                    Response.Redirect("~/G20TI.aspx");
                }
                else
                {
                    Response.Write("Invalid Username and Password");
                }
            }

            
            if (nim.Equals("17572010"))
            {
                if (flag == 1)
                {
                    Session["nam"] = txtusername.Text;
                    Response.Redirect("~/G17SI.aspx");
                }
                else
                {
                    Response.Write("Invalid Username and Password");
                }
            }
            else if (nim.Equals("18572010"))
            {
                if (flag == 1)
                {
                    Session["nam"] = txtusername.Text;
                    Response.Redirect("~/G18SI.aspx");
                }
                else
                {
                    Response.Write("Invalid Username and Password");
                }
            }

            else if (nim.Equals("19572010"))
            {
                if (flag == 1)
                {
                    Session["nam"] = txtusername.Text;
                    Response.Redirect("~/G19SI.aspx");
                }
                else
                {
                    Response.Write("Invalid Username and Password");
                }
            }

            else if (nim.Equals("20572010"))
            {
                if (flag == 1)
                {
                    Session["nam"] = txtusername.Text;
                    Response.Redirect("~/G20SI.aspx");
                }
                else
                {
                    Response.Write("Invalid Username and Password");
                }
            }

            /* if (nim.Equals("14203010"))
             {
                 if (flag == 1)
                 {
                     Session["nam"] = txtusername.Text;
                     Response.Redirect("~/G14TET.aspx");
                 }
                 else
                 {
                     Response.Write("Invalid Username and Password");
                 }
             }
             if (nim.Equals("15203010"))
             {
                 if (flag == 1)
                 {
                     Session["nam"] = txtusername.Text;
                     Response.Redirect("~/G15TET.aspx");
                 }
                 else
                 {
                     Response.Write("Invalid Username and Password");
                 }
             }
             if (nim.Equals("16203010"))
             {
                 if (flag == 1)
                 {
                     Session["nam"] = txtusername.Text;
                     Response.Redirect("~/G16TET.aspx");
                 }
                 else
                 {
                     Response.Write("Invalid Username and Password");
                 }
             }
             if (nim.Equals("17203010"))
             {
                 if (flag == 1)
                 {
                     Session["nam"] = txtusername.Text;
                     Response.Redirect("~/G17TET.aspx");
                 }
                 else
                 {
                     Response.Write("Invalid Username and Password");
                 }
             }

             if (nim.Equals("14204010"))
             {
                 if (flag == 1)
                 {
                     Session["nam"] = txtusername.Text;
                     Response.Redirect("~/G14TE.aspx");
                 }
                 else
                 {
                     Response.Write("Invalid Username and Password");
                 }
             }
             if (nim.Equals("15204010"))
             {
                 if (flag == 1)
                 {
                     Session["nam"] = txtusername.Text;
                     Response.Redirect("~/G15TE.aspx");
                 }
                 else
                 {
                     Response.Write("Invalid Username and Password");
                 }
             }
             if (nim.Equals("16204010"))
             {
                 if (flag == 1)
                 {
                     Session["nam"] = txtusername.Text;
                     Response.Redirect("~/G16TE.aspx");
                 }
                 else
                 {
                     Response.Write("Invalid Username and Password");
                 }
             }
             if (nim.Equals("17204010"))
             {
                 if (flag == 1)
                 {
                     Session["nam"] = txtusername.Text;
                     Response.Redirect("~/G17TE.aspx");
                 }
                 else
                 {
                     Response.Write("Invalid Username and Password");
                 }
             }

             if (nim.Equals("14214120"))
             {
                 if (flag == 1)
                 {
                     Session["nam"] = txtusername.Text;
                     Response.Redirect("~/G14TM.aspx");
                 }
                 else
                 {
                     Response.Write("Invalid Username and Password");
                 }
             }
             if (nim.Equals("15214120"))
             {
                 if (flag == 1)
                 {
                     Session["nam"] = txtusername.Text;
                     Response.Redirect("~/G15TM.aspx");
                 }
                 else
                 {
                     Response.Write("Invalid Username and Password");
                 }
             }
             if (nim.Equals("16214120"))
             {
                 if (flag == 1)
                 {
                     Session["nam"] = txtusername.Text;
                     Response.Redirect("~/G16TM.aspx");
                 }
                 else
                 {
                     Response.Write("Invalid Username and Password");
                 }
             }
             if (nim.Equals("17214120"))
             {
                 if (flag == 1)
                 {
                     Session["nam"] = txtusername.Text;
                     Response.Redirect("~/G17TM.aspx");
                 }
                 else
                 {
                     Response.Write("Invalid Username and Password");
                 }
             }


             if (nim.Equals("14204020"))
             {
                 if (flag == 1)
                 {
                     Session["nam"] = txtusername.Text;
                     Response.Redirect("~/G14TT.aspx");
                 }
                 else
                 {
                     Response.Write("Invalid Username and Password");
                 }
             }
             if (nim.Equals("15204020"))
             {
                 if (flag == 1)
                 {
                     Session["nam"] = txtusername.Text;
                     Response.Redirect("~/G15TT.aspx");
                 }
                 else
                 {
                     Response.Write("Invalid Username and Password");
                 }
             }
             if (nim.Equals("16204020"))
             {
                 if (flag == 1)
                 {
                     Session["nam"] = txtusername.Text;
                     Response.Redirect("~/G16TT.aspx");
                 }
                 else
                 {
                     Response.Write("Invalid Username and Password");
                 }
             }
             if (nim.Equals("17204020"))
             {
                 if (flag == 1)
                 {
                     Session["nam"] = txtusername.Text;
                     Response.Redirect("~/G17TT.aspx");
                 }
                 else
                 {
                     Response.Write("Invalid Username and Password");
                 }
             }


             if (nim.Equals("14624010"))
             {
                 if (flag == 1)
                 {
                     Session["nam"] = txtusername.Text;
                     Response.Redirect("~/G14AK.aspx");
                 }
                 else
                 {
                     Response.Write("Invalid Username and Password");
                 }
             }
             if (nim.Equals("15624010"))
             {
                 if (flag == 1)
                 {
                     Session["nam"] = txtusername.Text;
                     Response.Redirect("~/G15AK.aspx");
                 }
                 else
                 {
                     Response.Write("Invalid Username and Password");
                 }
             }
             if (nim.Equals("16624010"))
             {
                 if (flag == 1)
                 {
                     Session["nam"] = txtusername.Text;
                     Response.Redirect("~/G16AK.aspx");
                 }
                 else
                 {
                     Response.Write("Invalid Username and Password");
                 }
             }
             if (nim.Equals("14724010"))
             {
                 if (flag == 1)
                 {
                     Session["nam"] = txtusername.Text;
                     Response.Redirect("~/G14AK.aspx");
                 }
                 else
                 {
                     Response.Write("Invalid Username and Password");
                 }
             }

             if (nim.Equals("14564010"))
             {
                 if (flag == 1)
                 {
                     Session["nam"] = txtusername.Text;
                     Response.Redirect("~/G14TK.aspx");
                 }
                 else
                 {
                     Response.Write("Invalid Username and Password");
                 }
             }
             if (nim.Equals("15564010"))
             {
                 if (flag == 1)
                 {
                     Session["nam"] = txtusername.Text;
                     Response.Redirect("~/G15TK.aspx");
                 }
                 else
                 {
                     Response.Write("Invalid Username and Password");
                 }
             }
             if (nim.Equals("16564010"))
             {
                 if (flag == 1)
                 {
                     Session["nam"] = txtusername.Text;
                     Response.Redirect("~/G16TK.aspx");
                 }
                 else
                 {
                     Response.Write("Invalid Username and Password");
                 }
             }
             if (nim.Equals("17564010"))
             {
                 if (flag == 1)
                 {
                     Session["nam"] = txtusername.Text;
                     Response.Redirect("~/G17TK.aspx");
                 }
                 else
                 {
                     Response.Write("Invalid Username and Password");
                 }
             }*/
            if (nim.Equals("77777777"))
            {
                if (flag == 1)
                {
                    Session["nam"] = txtusername.Text;
                    Response.Redirect("~/admin.aspx");
                }
                else
                {
                    Response.Write("Invalid Username and Password");
                }
            }


            

            

        }
    }
}