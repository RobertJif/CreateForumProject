<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="forumLogin.aspx.cs" Inherits="Create_Forum_Project.forumLogin" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <link href="CSS/logincss.css" rel="stylesheet" type="text/css" />
    <link href="CSS/divlogo.css" rel="stylesheet" type="text/css" />
    <link href="CSS/style.css" rel="stylesheet" type="text/css" />
</head>

<body style="background-image: url(Gambar/web2.png)">
    <form id="form1" runat="server">
    <div class="divlogo"></div>
   
    <div class="wrap">
<!-- tab style-1 -->
<div class="row">
	<div class="grid_12 columns">
    <div class="form">
    <br />		
    <br /><br />
    Silahkan masuk kedalam akun kamu<center>
        
        
        <LayoutTemplate>
             <br />
             <asp:TextBox ID="txtusername" runat="server" placeholder="Username"></asp:TextBox>
             <asp:TextBox ID="txtpassword" runat="server" TextMode="Password" placeholder="Password"></asp:TextBox>
                
             <asp:Button ID="Btn_Login_Click" runat="server" CommandName="Login" 
                Text="Log In" onclick="Btn_Login_Click_Click" 
                />

                <div style="width: 100%; height: 20px; border-bottom: 1px solid #ccc; text-align: center">
  <span style="font-size: 14px; background-color: #fff; padding: 10px 10px; color: #CCCCCC; margin-left :175px;">
    ATAU 
  </span>
</div>

                
            <table>
            <tr>
            <td align="left" >
            Belum punya akun?<br />
                <asp:HyperLink ID="HyperLink1" runat="server" ForeColor="#2AA49C" 
                    NavigateUrl="~/forumRegistration.aspx">Daftar sekarang</asp:HyperLink>
            </td>
            </tr>
            </table>
            </div>
        </LayoutTemplate>
    
    </center>
        
	</div>			
</div>            
</div>			

    
    </form>
</body>
</html>
