using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace Create_Forum_Project
{
    public partial class forumRegistration : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["FRCon"].ConnectionString);
        SqlCommand cmd;
        string sqlquery;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
      
        

        protected void Btn_Registration_Click_Click(object sender, EventArgs e)
        {
            sqlquery = "Insert into Forum_Registration values ('" + txtusername.Text + "','" + txtpassword.Text + "', '" + txtNim.Text + "', '" + txtdob.Text + "', '" + txtemailid.Text + "')";
            cmd = new SqlCommand(sqlquery, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            Response.Redirect("~/forumLogin.aspx");

        }
    }
}