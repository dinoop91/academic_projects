<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="operator.aspx.cs" Inherits="Default2" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style2
        {
            height: 23px;
        }
    .style3
    {
        }
    .style4
    {
        height: 23px;
        width: 198px;
    }
        .style5
        {
            width: 198px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="style1" bgcolor="#CC0000" style="background-color: #FFFFFF">
        <tr>
            <td class="style3" colspan="2">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="Large" 
            Font-Underline="True" Text="Recharge Details" ForeColor="#CC0066"></asp:Label>
                <br />
                <br />
                <br />
                <br />
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style5">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Image ID="Image1" runat="server" Height="63px" Width="115px" />
                &nbsp;</td>
            <td>
                <asp:FileUpload ID="FileUpload1" runat="server" />
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style5">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label2" runat="server" Text="Operator" Font-Size="Large" 
                    ForeColor="#006600"></asp:Label>
                <br />
            </td>
            <td>
                <asp:DropDownList ID="DropDownList1" runat="server" Height="17px" Width="128px">
                    <asp:ListItem>-select-</asp:ListItem>
                    <asp:ListItem>Idea</asp:ListItem>
                    <asp:ListItem>Vodafone</asp:ListItem>
                    <asp:ListItem>Airtel</asp:ListItem>
                    <asp:ListItem>Bsnl</asp:ListItem>
                    <asp:ListItem>Reliance</asp:ListItem>
                    <asp:ListItem>Aircel</asp:ListItem>
                    <asp:ListItem>Tata Indicom</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style5">
                <asp:Label ID="Label3" runat="server" Text="Total Amount" Font-Size="Large" 
                    ForeColor="#006600"></asp:Label>
                <br />
            </td>
            <td>
                <asp:TextBox ID="txttot" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style5">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style5">
                &nbsp;</td>
            <td>
                <asp:Button ID="Button1" runat="server" Height="30px" onclick="Button1_Click" 
                    Text="Submit" Width="118px" Font-Bold="True" Font-Size="Large" 
                    ForeColor="#CC0066" />
                </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style4">
            </td>
            <td class="style2">
                <asp:Button ID="Button2" runat="server" Height="30px" 
                    PostBackUrl="~/recharge_ amount.aspx" Text="Add Recharge Coupon Details" 
                    Width="264px" Font-Bold="True" Font-Size="Large" ForeColor="#CC0066" />
                <asp:Button ID="Button4" runat="server" Height="29px" 
                    PostBackUrl="~/admin_login.aspx" Text="Exit" Width="73px" Font-Bold="True" 
                    Font-Size="Large" ForeColor="#CC0066" />
                <asp:Button ID="Button5" runat="server" Font-Bold="True" Font-Size="Large" 
                    ForeColor="#CC0066" Height="30px" onclick="Button5_Click" Text="Delete" 
                    Width="63px" />
            </td>
            <td class="style2">
                &nbsp;</td>
            <td class="style2">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style5">
                &nbsp;</td>
            <td>
                <asp:Button ID="Button3" runat="server" Height="30px" 
                    PostBackUrl="~/offer_amount.aspx" Text="Add Offer Amount Details" 
                    Width="263px" Font-Bold="True" Font-Size="Large" ForeColor="#CC0066" />
                </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style5">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        </table>
    </asp:Content>

