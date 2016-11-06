<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="nameCart.aspx.cs" Inherits="cartridge.nameCart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
    .style1
    {
        height: 21px;
        text-align: center;
    }
    .style4
    {
        text-align: center;
        }
    .style6
    {
        height: 21px;
        width: 336px;
        text-align: center;
    }
    .style7
    {
        width: 483px;
        text-align: center;
    }
    .style9
    {
        height: 21px;
        text-align: center;
    }
    .style10
    {
        height: 21px;
        width: 483px;
        text-align: center;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <table style="width: 100%; height: 480px;">
    <tr>
        <td class="style7">
            наименование картриджа<br> 
            <asp:TextBox ID="TextBox1" runat="server" Width="200px"></asp:TextBox>
            <br />
            <br />
            общее количество<br />
            <asp:TextBox ID="TextBox3" runat="server" Width="200px">0</asp:TextBox>
            <br />
            <br />
            количество заполненных<br />
            <asp:TextBox ID="TextBox4" runat="server" Width="200px">0</asp:TextBox>
        </td>
        <td class="style4" colspan="2">
            наименование принтера(включенного в список)<br />
            
             <asp:DropDownList ID="DropDownList2" runat="server" Height="32px" 
                Width="200px">
             </asp:DropDownList>

            
            <br />
            <br />
            наименование принтера(которого нет в списке)<br />
            <asp:TextBox ID="TextBox2" runat="server" Width="200px"></asp:TextBox>
            <br />
            <br />
            <br />
            <br />
            <br />
        </td>
    </tr>
    <tr>
        <td class="style9" colspan="3">
            <asp:Button ID="Button1" runat="server" Text="Ввод" Width="232px" 
                onclick="Button1_Click" style="text-align: center" />
        </td>
    </tr>
    <tr>
        <td class="style10">
            &nbsp;</td>
        <td class="style6">
            &nbsp;</td>
        <td class="style1">
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style10">
            &nbsp;</td>
        <td class="style6">
            &nbsp;</td>
        <td class="style1">
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style10">
            &nbsp;</td>
        <td class="style6">
            <asp:Button ID="Button2" runat="server" onclick="Button2_Click" 
                Text="Переустановить БД" />
        </td>
        <td class="style1">
            &nbsp;</td>
    </tr>
</table>
</asp:Content>
