<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Klasifikasi_G15SI.aspx.cs" Inherits="Create_Forum_Project.Klasifikasi_G15SI" %>


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
     
     
     
     

     &emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp; &emsp;&emsp;&emsp;&emsp;&emsp;&emsp;
     &emsp;&emsp;&emsp;&emsp;&emsp;&emsp; &emsp;&emsp;&emsp;&emsp;&emsp;&emsp; &emsp;&emsp;&emsp;&emsp;&emsp;&emsp; &emsp;&emsp;&emsp;&emsp;&emsp;&emsp; &emsp;&emsp;&emsp;&emsp;
     Welcome : <label id="lblwelcom" runat="server"/>
      &emsp;|
      &emsp;<a href="forumLogin.aspx" style="text-decoration:none; color:White"> Logout</a></div> 
     


         
    </div>
   
    </div>
    <div class="div_log_reg_ribbon" id="div_log_reg_ribbon" runat="server">
    <center>
    <table>
      <tr>
        <td><a href="forumLogin.aspx">[ Login ]</a></td>
        <td><a href="forumRegistration.aspx">[ Sign Up ]</a></td>
       </tr>
     </table>
    </div>
    
   <br />
    <div>
    <asp:Panel ID="div_post_display_panel" style="margin-top:-15px;" runat="server"/>
    <center>
    <h2>Lihat Hasil Klasifikasi</h2>
        <br />
     <asp:HyperLink ID="link" runat ="server" NavigateUrl="~/G15SI_KlasifikasiEdukasi.aspx">
    <asp:Image ID="img" runat="server" ImageUrl="~/Gambar/edukasi.png" Height="200px" Width="200px" />
       </asp:HyperLink>
       
       &emsp;&emsp;&emsp;&emsp;<asp:HyperLink ID="HyperLink1" runat ="server" NavigateUrl="~/G15SI_KlasifikasiOlahraga.aspx">
       <asp:Image ID="Image1" runat="server" ImageUrl="~/Gambar/olahraga.png" Height="200px" Width="200px" />
       </asp:HyperLink>
       
        &emsp;&emsp;&emsp;&emsp;<asp:HyperLink ID="HyperLink2" runat ="server" NavigateUrl="~/G15SI_KlasifikasiBisnis.aspx">
       <asp:Image ID="Image2" runat="server" ImageUrl="~/Gambar/bisnis.png" Height="200px" Width="200px" />
       </asp:HyperLink>
       
        &emsp;&emsp;&emsp;&emsp;<asp:HyperLink ID="HyperLink3" runat ="server" NavigateUrl="~/G15SI_KlasifikasiBeritaKehilangan.aspx">
       <asp:Image ID="Image3" runat="server" ImageUrl="~/Gambar/berita.png" Height="200px" Width="200px" />
       </asp:HyperLink>
       
        &emsp;&emsp;&emsp;&emsp;<asp:HyperLink ID="HyperLink4" runat ="server" NavigateUrl="~/G15SI_KlasifikasiKepanitiaan.aspx">
       <asp:Image ID="Image4" runat="server" ImageUrl="~/Gambar/panitia.png" Height="200px" Width="200px" />
       </asp:HyperLink> 
       <br /></center>
       <left></left>
          &emsp;&emsp;&emsp;&emsp;&emsp;<asp:Label ID="lbljumlah1" runat="server" Text=""></asp:Label>
          &emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;<asp:Label ID="lbljumlah2" runat="server" Text=""></asp:Label>
          &emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;<asp:Label ID="lbljumlah3" runat="server" Text=""></asp:Label>
          &emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;<asp:Label ID="lbljumlah4" runat="server" Text=""></asp:Label>
          &emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;<asp:Label ID="lbljumlah5" runat="server" Text=""></asp:Label>
    </div>
    <asp:Label ID="lblklas" runat="server" Text=""></asp:Label>
    </form>
</body>
</html>


