<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home_19SI.aspx.cs" Inherits="Create_Forum_Project.Home_19SI" %>

<<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <link href="CSS/dashboard.css" rel="stylesheet" type="text/css" />
    <link href="CSS/divlogo.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript">
        function readarticles() {
            PageMethods.ReadArticles();
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <div class="divlogo">
        
        </div>
         <div class="div_header">
     
     <a href="Default_19SI.aspx" style="text-decoration:none; color:White" >Beranda</a>
     &emsp;|
     &emsp;<a href="Dashboard_19SI.aspx" style="text-decoration:none; color:White">Buat Diskusi</a>
     &emsp;|
     &emsp;<a href="Home_19SI.aspx" style="text-decoration:none; color:White">Lihat Diskusi</a>
     &emsp;|
     &emsp;<a href="G19SI.aspx" style="text-decoration:none; color:White">Pilih Diskusi</a>
     
     &emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp; &emsp;&emsp;&emsp;&emsp;&emsp;&emsp;
     Welcome : <label id="welcome" runat="server"/>  
     &emsp;|
     &emsp;<a href="forumLogin.aspx" style="text-decoration:none; color:White"> Logout</a></div>    
     
         
    </div>
   
    <!--
      <div class="div_post_display">
       <h2><div id="div_h1" runat="server"></div></h2>
        <p></p><div id="post_msg" runat="server"></div></p>
      </div>
      -->
      <br /><br />
      <asp:Panel ID="div_post_display_panel" style="margin-top:-35px;" runat="server"/>
      <asp:ScriptManager runat="server" EnablePageMethods="true" ID="scrptmgr">
          </asp:ScriptManager>
    </div>
    </form>
</body>
</html>