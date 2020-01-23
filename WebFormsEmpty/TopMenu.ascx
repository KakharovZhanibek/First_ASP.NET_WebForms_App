<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="TopMenu.ascx.cs" Inherits="WebFormsEmpty.TopMenu" %>

<asp:Menu ID="Menu1" runat="server" BackColor="#B5C7DE" DynamicHorizontalOffset="2" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#284E98" StaticSubMenuIndent="10px" Orientation="Horizontal">
    <DynamicHoverStyle BackColor="#284E98" ForeColor="White" />
    <DynamicMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
    <DynamicMenuStyle BackColor="#B5C7DE" />
    <DynamicSelectedStyle BackColor="#507CD1" />
    <Items>
        <asp:MenuItem Text="Главная" Value="Главная" NavigateUrl="~/index.aspx"></asp:MenuItem>
        <asp:MenuItem Text="Контакты" Value="Контакты" NavigateUrl="~/Contacts.aspx"></asp:MenuItem>
        <asp:MenuItem Text="О нас" Value="О нас" NavigateUrl="~/About.aspx"></asp:MenuItem>
    </Items>
    <StaticHoverStyle BackColor="#284E98" ForeColor="White" />
    <StaticMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
    <StaticSelectedStyle BackColor="#507CD1" />
</asp:Menu>
