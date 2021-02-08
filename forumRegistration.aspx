<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="forumRegistration.aspx.cs" Inherits="Create_Forum_Project.forumRegistration" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="CSS/forum.css" rel="stylesheet" type="text/css" />    
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

     Silahkan daftar <center>
        
        <LayoutTemplate>
         <table>
        
         <tr>
             <td><asp:TextBox ID="txtusername" runat="server" placeholder="Username"></asp:TextBox></td>
             <td><asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                ControlToValidate="txtusername">Masukkan username</asp:RequiredFieldValidator></td></tr>

             <tr>
             <td><asp:TextBox ID="txtNim" runat="server" placeholder="Nim"></asp:TextBox></td>
             <td><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                ControlToValidate="txtNim">Masukkan Nim</asp:RequiredFieldValidator></td></tr>


                <tr>
                 <td><asp:TextBox ID="txtpassword" runat="server" TextMode="Password" placeholder="Password"></asp:TextBox></td>
                 <td><asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                ControlToValidate="txtpassword">Gunakan password yang baik</asp:RequiredFieldValidator></td></tr>

                <tr>
                <td><asp:TextBox ID="txtdob" CssClass="textbox" runat="server" placeholder="Tanggal lahir(DDMMYYYY)"
                ToolTip="Please Enter Date-Of-Birth (DDMMYYYY)"></asp:TextBox></td>
                <td><asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                ControlToValidate="txtdob">Masukkan format(DDMMYYYY) </asp:RequiredFieldValidator></td></tr>


                <tr>
                <td><asp:TextBox ID="txtemailid"  CssClass="textbox" runat="server" placeholder="email"></asp:TextBox></td>
                <td><asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" 
                ControlToValidate="txtemailid" ErrorMessage="(Invalid Email ID)" 
                ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">(Invalid Email ID)</asp:RegularExpressionValidator></td>
                </tr>
             
             <tr>
             <td><asp:Button ID="Btn_Registration" runat="server" CommandName="Login" 
                Text="Daftar" onclick="Btn_Registration_Click_Click" /></td></tr>
                </table>
                 
                 </LayoutTemplate>
             
    </div>
    </div>
    </div>
    </form>
</body>
</html>
