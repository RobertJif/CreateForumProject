<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Dashboard_14SI.aspx.cs" Inherits="Create_Forum_Project.Dashboard_14SI" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <link href="CSS/dashboard.css" rel="stylesheet" type="text/css" />
    <link href="CSS/divlogo.css" rel="stylesheet" type="text/css" />
</head>
<body style="background-image: url(Gambar/buatdiskusi2.png); background-repeat:no-repeat">
    <form id="form1" runat="server">
    <div>
    <div class="divlogo">
        
        </div>

        <div id="div_header">
     <div id="divwelcome" runat="server" class="div_header" visible="true">
     
     <a href="Default_14SI.aspx" style="text-decoration:none; color:White" >Beranda</a>
     &emsp;|
     &emsp;<a href="Dashboard_14SI.aspx" style="text-decoration:none; color:White">Buat Diskusi</a>
     &emsp;|
     &emsp;<a href="Home_14SI.aspx" style="text-decoration:none; color:White">Lihat Diskusi</a>
     &emsp;|
     &emsp;<a href="G14SI.aspx" style="text-decoration:none; color:White">Pilih Diskusi</a>
     
     
     &emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp; &emsp;&emsp;&emsp;&emsp;&emsp;&emsp;
     Welcome : <label id="lblwelcom" runat="server"/>
      &emsp;|
      &emsp;<a href="forumLogin.aspx" style="text-decoration:none; color:White"> Logout</a></div> 
     
    </div>
    </div>
 
    <div id="div_table">
     <table>
      <tr>
       <td>&emsp;&emsp;&emsp;&emsp;Title : </td>
       <td>
           <asp:TextBox ID="txtposttitle" CssClass="txt" runat="server" Width="500px"></asp:TextBox></td>
      </tr>
      <tr>
       <td colspan="2"></td>
      </tr>
      <tr>
       <td colspan="2">&emsp;&emsp;&emsp;&emsp;
           <textarea id="txtpostmessage" cols="68" rows="15" runat="server"></textarea>
       </td>
      </tr>
      <tr>
       <td><td>
           <asp:Button ID="BtnPost" runat="server" CommandName="Login" Text="Buat Topik" 
               onclick="BtnPost_Click" Width="500px" BackColor="#2aa49c" Height="35px"  
                /></td></td>

      </tr>
     </table>
    <br />
    <br />    </form>
</body>
</html>
