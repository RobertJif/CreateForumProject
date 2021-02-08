<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="G15SI.aspx.cs" Inherits="Create_Forum_Project.G15SI" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <link href="CSS/dashboard.css" rel="stylesheet" type="text/css" />
    <link href="CSS/divlogo.css" rel="stylesheet" type="text/css" />
    <title></title>
</head>
<body style="background-image: url(Gambar/web2.png)">
    <form id="form1" runat="server">
    <div>
    <div class="divlogo">
        
        </div>
        <div id="div_header">
     <div id="divwelcome" runat="server" class="div_header" visible="false">
       
     

     &emsp;&emsp;&emsp;&emsp;&emsp;&emsp; &emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp; &emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp; &emsp;&emsp;&emsp;&emsp;&emsp;&emsp;
     &nbsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;
     Welcome : <label id="lblwelcom" runat="server"/>
      &emsp;|
      &emsp;<a href="forumLogin.aspx" style="text-decoration:none; color:White"> Logout</a></div> 
     


         
    </div>
   
    </div>
    <div class="div_log_reg_ribbon" id="div_log_reg_ribbon" runat="server">
    <table>
      <tr>
        <td><a href="forumLogin.aspx">[ Login ]</a></td>
        <td><a href="forumRegistration.aspx">[ Sign Up ]</a></td>
       </tr>
     </table>
    </div>
   
    <br /><br />
    <center>
    <h2>Pilih Diskusi</h2><br />
     <asp:HyperLink ID="link" runat ="server" NavigateUrl="~/Default_G15SI.aspx">
    <asp:Image ID="img" runat="server" ImageUrl="~/Gambar/G15 SI.png" Height="300px" Width="300px" />
       </asp:HyperLink>
       
       &emsp;&emsp;&emsp;&emsp;&emsp;&emsp;<asp:HyperLink ID="HyperLink1" runat ="server" NavigateUrl="~/Default_15SI.aspx">
       <asp:Image ID="Image1" runat="server" ImageUrl="~/Gambar/si2.png" Height="300px" Width="300px" />
       </asp:HyperLink>
       
        &emsp;&emsp;&emsp;&emsp;&emsp;&emsp;<asp:HyperLink ID="HyperLink2" runat ="server" NavigateUrl="~/Default_Umum_15SI.aspx">
       <asp:Image ID="Image2" runat="server" ImageUrl="~/Gambar/umum si.png" Height="300px" Width="300px" />
       </asp:HyperLink> 
    
    <div>
    <asp:Panel ID="div_post_display_panel" style="margin-top:-15px;" runat="server"/>
    </div>
    </form>
</body>
</html>
