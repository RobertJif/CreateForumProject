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
    public partial class Klasifikasi_G15SI : System.Web.UI.Page
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
            SqlDataAdapter da = new SqlDataAdapter("Select * from klasifikasi_edukasi", con);
            SqlDataAdapter da2 = new SqlDataAdapter("Select * from klasifikasi_olahraga", con);
            SqlDataAdapter da3 = new SqlDataAdapter("Select * from klasifikasi_bisnis", con);
            SqlDataAdapter da4 = new SqlDataAdapter("Select * from klasifikasi_berita", con);
            SqlDataAdapter da5 = new SqlDataAdapter("Select * from klasifikasi_kepanitiaan", con);

            con.Open();
            DataSet ds = new DataSet();


            DataSet ds2 = new DataSet();
            DataSet ds3 = new DataSet();
            DataSet ds4 = new DataSet();
            DataSet ds5 = new DataSet();
            DataSet ds6 = new DataSet();

            da.Fill(ds2);
            da2.Fill(ds3);
            da3.Fill(ds4);
            da4.Fill(ds5);
            da5.Fill(ds6);


            con.Close();

            //int rows1 = ds2.Tables[0].Rows.Count;
            //lbljumlah1.Text = "Jumlah Diskusi:" + rows1.ToString();

            //int rows2 = ds3.Tables[0].Rows.Count;
            //lbljumlah2.Text = "Jumlah Diskusi: " + rows2.ToString();

            //int rows3 = ds4.Tables[0].Rows.Count;
            //lbljumlah3.Text = "Jumlah Diskusi: " + rows3.ToString();

            //int rows4 = ds5.Tables[0].Rows.Count;
            //lbljumlah4.Text = "Jumlah Diskusi: " + rows4.ToString();

            //int rows5 = ds6.Tables[0].Rows.Count;
            //lbljumlah5.Text = "Jumlah Diskusi: " + rows5.ToString();


            


        }
    }
}





