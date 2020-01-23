<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="WebFormsEmpty.index" %>
<%@ Register Src="~/TopMenu.ascx" TagName="Top" TagPrefix="MyMenu" %>
<%@ Register Src="~/Footer.ascx" TagName="Footer" TagPrefix="Foot" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <MyMenu:Top runat="server" ID="MyMenu"></MyMenu:Top>
            <asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Horizontal" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                <AlternatingRowStyle BackColor="#F7F7F7"></AlternatingRowStyle>
                <Columns>
                    <asp:CommandField SelectText="Выбрать" ShowSelectButton="True" />
                </Columns>
                <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C"></FooterStyle>
                <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7"></HeaderStyle>
                <PagerStyle HorizontalAlign="Right" BackColor="#E7E7FF" ForeColor="#4A3C8C"></PagerStyle>
                <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C"></RowStyle>
                <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7"></SelectedRowStyle>
                <SortedAscendingCellStyle BackColor="#F4F4FD"></SortedAscendingCellStyle>
                <SortedAscendingHeaderStyle BackColor="#5A4C9D"></SortedAscendingHeaderStyle>
                <SortedDescendingCellStyle BackColor="#D8D8F0"></SortedDescendingCellStyle>
                <SortedDescendingHeaderStyle BackColor="#3E3277"></SortedDescendingHeaderStyle>
            </asp:GridView>

            <table>
                <tr>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </tr>
            </table>

            <%--<table>
                <tr>
                    <td>
                        <asp:Button ID="AddCountryBtn" runat="server" Text="Add" OnClick="AddCountryBtn_Click" />

                    </td>
                    <td>
                        <asp:Button ID="DeleteCountry" runat="server" Text="Delete" OnClick="DeleteCountry_Click"/>

                    </td>
                    <td>
                        <asp:Button ID="EditCountry" runat="server" Text="Edit" OnClick="EditCountry_Click"/>
                    </td>
                </tr>
            </table>--%>

            <Foot:Footer runat="server" ID="Footer"></Foot:Footer>
        </div>
    </form>
</body>
</html>
