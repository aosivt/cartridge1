<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="update_re.aspx.cs" Inherits="cartridge.update_re" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
    .style1
    {
        width: 352px;
        text-align: center;
    }
    .style3
    {
        width: 352px;
        height: 29px;
        text-align: center;
    }
    .style4
    {
        text-align: center;
    }
    .style5
    {
        height: 29px;
        text-align: center;
    }
    .style6
    {
        text-align: center;
        height: 25px;
    }
    .style7
    {
        width: 352px;
        text-align: center;
        height: 25px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <table style="width: 100%; height: 100px;">
    <tr>
        <td class="style4">
            &nbsp;</td>
        <td class="style1">
            &nbsp;</td>
        <td class="style4">
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style4">
            наименование картриджа</td>
        <td class="style1">
            наименование принтера</td>
        <td class="style4">
            наименование отдела</td>
    </tr>
    <tr>
        <td class="style4">
            <asp:DropDownList ID="DropDownList3" runat="server" Width="237px">
            </asp:DropDownList>
        </td>
        <td class="style1">
            <asp:DropDownList ID="DropDownList1" runat="server" Height="24px" Width="213px">
            </asp:DropDownList>
        </td>
        <td class="style4">
            <asp:DropDownList ID="DropDownList2" runat="server" Height="51px" Width="237px">
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td class="style5">
            <asp:Button ID="Button3" runat="server" onclick="Button3_Click" Text="удалить" 
                Width="242px" />
        </td>
        <td class="style3">
            <asp:Button ID="Button1" runat="server" Text="удалить" Width="214px" />
        </td>
        <td class="style5">
            <asp:Button ID="Button2" runat="server" Height="24px" Text="удалить" 
                Width="240px" />
        </td>
    </tr>
    <tr>
        <td class="style4">
            &nbsp;</td>
        <td class="style1">
            &nbsp;</td>
        <td class="style4">
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style4">
            общее количество</td>
        <td class="style1">
            &nbsp;</td>
        <td class="style4">
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style6">
            <asp:TextBox ID="TextBox1" runat="server" Width="242px"></asp:TextBox>
        </td>
        <td class="style7">
        </td>
        <td class="style6">
        </td>
    </tr>
    <tr>
        <td class="style4">
            заправленное количество</td>
        <td class="style1">
            &nbsp;</td>
        <td class="style4">
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style4">
            <asp:TextBox ID="TextBox2" runat="server" Width="238px"></asp:TextBox>
        </td>
        <td class="style1">
            &nbsp;</td>
        <td class="style4">
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style4">
            <asp:Button ID="Button4" runat="server" Text="обновить" Width="234px" />
        </td>
        <td class="style1">
            &nbsp;</td>
        <td class="style4">
            <asp:Button ID="Button5" runat="server" onclick="Button2_Click" 
                Text="Переустановить БД" />
        </td>
    </tr>
    <tr>
        <td class="style4">
            &nbsp;</td>
        <td class="style1">
            &nbsp;</td>
        <td class="style4">
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style4">
            &nbsp;</td>
        <td class="style1">
            &nbsp;</td>
        <td class="style4">
            &nbsp;</td>
    </tr>
</table>
</asp:Content>
