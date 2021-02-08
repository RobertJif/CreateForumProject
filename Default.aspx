<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Create_Forum_Project.Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <link href="CSS/dashboard.css" rel="stylesheet" type="text/css" />
    <link href="CSS/divlogo.css" rel="stylesheet" type="text/css" />
    <title></title>
</head>
<body bgcolor=""    >
    <form id="form1" runat="server">
    <div>
    <div class="divlogo">
        <asp:Image ID="Image1" runat="server" Height="70px" 
            ImageUrl="~/Gambar/Subjek11.png" Width="150px" />
        </div>
     <div id="divwelcome" runat="server" class="div_header" visible="false">
     Welcome : <label id="lblwelcom" runat="server"/>     
    </div>
    <div id="divlogout" runat="server" class="div_logout" visible="false"><a href="forumLogin.aspx">Logout</a></div>
    <div class="div_log_reg_ribbon" id="div_log_reg_ribbon" runat="server">
    <table>
      <tr>
        <td><a href="forumLogin.aspx">[ Login ]</a></td>
        <td><a href="forumRegistration.aspx">[ Sign Up ]</a></td>
       </tr>
     </table>
    </div>
    </div>
    <div id="div_dashboard_box" class="div_dashboard" runat="server" visible="false">
     <table>
      <tr>
       <th>Dashboard G 14 TI</th>
      </tr>
      <tr>
       <td><a href="Default.aspx">Home Page</a></td>
      </tr>
      <tr>
       <td><a href="Dashboard.aspx">Post Articles</a></td>
      </tr>
      <tr>
       <td><a href="Home.aspx">Your Articles</a></td>
      </tr>
     </table>
    </div>
    <div>
    <asp:Panel ID="div_post_display_panel" style="margin-top:-15px;" runat="server"/>
    </div>
    <br /><br />
    <center ><h1>Selamat Datang di Website Forum Diskusi PCR</h1></center>
    <center ><asp:Image ID="Image2" runat="server" ImageUrl="~/Gambar/pcr1.jpg" 
        Height="500px" Width="1300px" /></center>
    </form>
</body>
</html>
