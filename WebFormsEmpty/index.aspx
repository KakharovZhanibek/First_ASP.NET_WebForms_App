<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="WebFormsEmpty.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="TB_1" runat="server"></asp:TextBox>
            <asp:TextBox ID="TB_2" runat="server"></asp:TextBox>
            <asp:TextBox ID="TB_3" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="Button 1" BackColor="#6666FF" BorderColor="Maroon" ForeColor="Yellow" OnClick="Button1_Click" />
            <asp:DropDownList ID="DropDownList1" runat="server">
            </asp:DropDownList>
            <asp:HiddenField ID="HiddenField1" runat="server" />
        </div>
    </form>
</body>
</html>
