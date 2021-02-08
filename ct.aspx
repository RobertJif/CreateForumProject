<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ct.aspx.cs" Inherits="Create_Forum_Project.ct" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <div>
    Pesan Barang Harian <br />
    <br />
    Nama Pemesan&nbsp;&nbsp;&nbsp;&nbsp; :
    <asp:TextBox ID ="name" runat="server"></asp:TextBox>
    <br />
    Alamat Antar&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:
    <asp:TextBox ID="alamat" runat="server"></asp:TextBox>
    <br />
    <asp:Button ID="Button1" runat="server" Text="Execute" onclick="Button1_Click" />
    </div>
    
    <asp:Label ID="lbl" runat="server" ></asp:Label>
    </form>
</body>
</html>
