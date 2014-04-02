<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="admin_login.aspx.cs" Inherits="Default2" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style3
        {
        }
        .style4
        {
            width: 100%;
        }
        .style7
        {
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="style1">
        <tr>
            <td class="style3">
                <table class="style4">
                    <tr>
                        <td class="style7">
                            
                            <asp:Image ID="Image1" runat="server" Height="499px" 
                                ImageUrl="~/image/mymobile.jpg" Width="963px" />
                            <br />
                            <br />
                            <asp:LinkButton ID="LinkButton1" runat="server" 
                    PostBackUrl="~/mobile_ details.aspx" Font-Bold="True" Font-Size="Large" 
                    ForeColor="#CC0066">Add Mobile Details</asp:LinkButton>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:LinkButton ID="LinkButton2" runat="server" PostBackUrl="~/operator.aspx" 
                    Font-Bold="True" Font-Size="Large" ForeColor="#CC0066">Add Recharge Details</asp:LinkButton>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:LinkButton ID="LinkButton4" runat="server" Font-Bold="True" 
                    Font-Size="Large" ForeColor="#CC0066" PostBackUrl="~/userdet.aspx">User Details</asp:LinkButton>
                            
                        </td>
                    </tr>
                    </table>
            </td>
        </tr>
        </table>
</asp:Content>

