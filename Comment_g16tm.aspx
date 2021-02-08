<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Comment_g16tm.aspx.cs" Inherits="Create_Forum_Project.Comment_g16tm" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <link href="CSS/dashboard.css" rel="stylesheet" type="text/css" />
    <link href="CSS/divlogo.css" rel="stylesheet" type="text/css" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <div class="divlogo">
        
        </div>
        <div id="div_header">
     <div id="divwelcome" runat="server" class="div_header" visible="true">
     
     <a href="Default_G16TM.aspx" style="text-decoration:none; color:White" >Beranda</a>
     &emsp;|
     &emsp;<a href="Dashboard_G16TM.aspx" style="text-decoration:none; color:White">Buat Diskusi</a>
     &emsp;|
     &emsp;<a href="Home_G16TM.aspx" style="text-decoration:none; color:White">Lihat Diskusi</a>
     &emsp;|
     &emsp;<a href="G16TM.aspx" style="text-decoration:none; color:White">Pilih Diskusi</a>
     
     &emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp; &emsp;&emsp;&emsp;&emsp;&emsp;&emsp;
     Welcome : <label id="lblwelcom" runat="server"/>
      &emsp;|
      &emsp;<a href="forumLogin.aspx" style="text-decoration:none; color:White"> Logout</a></div> 

    </div>
    </div>
    <div>

    <asp:Panel ID="div_post_display_panel" style="margin-top:15px;" runat="server">
    <asp:Panel ID="Panel2" style="margin-top:15px;" runat="server"/></asp:Panel>
    </div>

    <div id="div_table2">

     <table>
      <tr>
       <td>Komentar : </td>
       <td><asp:TextBox ID="txtComment" runat="server" Height="100px" TextMode="MultiLine" Width="350px"></asp:TextBox></td>
      </tr>
      <tr>
      <td></td>
       <td>
           <asp:Button ID="BtnPost" runat="server" Text="Kirim" onclick="BtnPost_Click"  BackColor="#2aa49c" Width="355px" Height="35px" /></td>


          

      </tr>
     </table>
     </div>
    </div>
    </form>
</body>
</html>
