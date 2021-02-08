<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default_15TI.aspx.cs" Inherits="Create_Forum_Project.Default_15TI" %>

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
     <div id="divwelcome" runat="server" class="div_header" visible="false">
     
     <a href="Default_15TI.aspx" style="text-decoration:none; color:White" >Beranda</a>
     &emsp;|
     &emsp;<a href="Dashboard_15TI.aspx" style="text-decoration:none; color:White">Buat Diskusi</a>
     &emsp;|
     &emsp;<a href="Home_15TI.aspx" style="text-decoration:none; color:White">Lihat Diskusi</a>
     &emsp;|
     &emsp;<a href="G15TI.aspx" style="text-decoration:none; color:White">Pilih Diskusi</a>
     
     
     &emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp; &emsp;&emsp;&emsp;&emsp;&emsp;&emsp;
     Welcome : <label id="lblwelcom" runat="server"/>
      &emsp;|
      &emsp;<a href="forumLogin.aspx" style="text-decoration:none; color:White"> Logout</a></div> 
     


         
    </div>
   
    </div>
    <br />
    <div>
    <asp:Panel ID="div_post_display_panel" style="margin-top:-15px;" runat="server"/>
    </div>
    </form>
</body>
</html>
