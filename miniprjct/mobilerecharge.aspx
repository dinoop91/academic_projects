<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="mobilerecharge.aspx.cs" Inherits="Default2" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
    .style1
    {
        width: 100%;
    }
        .style7
        {
            width: 189px;
        }
        .style8
        {
            width: 115px;
        }
        .style9
        {
            width: 66px;
        }
        .style10
        {
        }
        .style11
        {
            height: 297px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="style1" style="background-color: #FFFFFF">
    <tr>
        <td class="style11" colspan="4" style="background-color: #66CCFF">
            <asp:Image ID="Image4" runat="server" Height="359px" 
                ImageUrl="~/images/online_mobile_recharge.gif" Width="424px" />
            <asp:Image ID="Image5" runat="server" Height="359px" 
                ImageUrl="~/images/rechargeyourmobilehere.jpg" Width="522px" />
        </td>
    </tr>
    <tr>
        <td class="style10">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
        <td class="style9">
            <asp:Label ID="Label2" 
                runat="server" Text="Operator" Font-Size="Large" ForeColor="#CC0099" 
                Font-Bold="True"></asp:Label>
        </td>
        <td class="style8">
            <asp:DropDownList ID="drpoper" runat="server" AutoPostBack="True" Height="19px" 
                Width="132px" onselectedindexchanged="drpoper_SelectedIndexChanged1">
                <asp:ListItem>
                &nbsp; -select-</asp:ListItem>
            </asp:DropDownList>
        </td>
        <td class="style7">
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style10">
            &nbsp;</td>
        <td class="style9">
            &nbsp;</td>
        <td class="style8">
            &nbsp;</td>
        <td class="style7">
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style10">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </td>
        <td class="style9">
            <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Size="Large" 
                ForeColor="#CC0099" Text="Amount"></asp:Label>
        </td>
        <td class="style8">
            <asp:TextBox ID="txtamount" runat="server"></asp:TextBox>
        </td>
        <td class="style7">
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style10">
            &nbsp;</td>
        <td class="style9">
            &nbsp;</td>
        <td class="style8">
            &nbsp;</td>
        <td class="style7">
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style10">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
        <td class="style9">
            <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/profile.aspx">Back</asp:LinkButton>
        </td>
        <td class="style8">
            <asp:Button ID="Button3" runat="server" onclick="Button3_Click" 
                Text="Recharge Now&gt;&gt;" Font-Bold="True" Font-Size="Large" 
                BackColor="Yellow" Width="155px" />
            
        </td>
        <td class="style7">
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style10">
            <asp:Image ID="Image2" runat="server" Height="100px" ImageUrl="~/image/11.jpeg" 
                Width="204px" />
            <asp:Label 
                ID="offer" runat="server" Font-Bold="True" Font-Size="Large" 
                Text="OfferAmount Details" ForeColor="#CC0000"></asp:Label>
            &nbsp;<asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" 
                Height="166px" CellPadding="3" Font-Bold="True" Font-Size="Medium" 
                BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" 
                CellSpacing="2"  
                Width="372px">
                <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
                <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
                <Columns>
                    <asp:BoundField DataField="operator" HeaderText="operator" />
                    <asp:BoundField DataField="amount" HeaderText="amount" />
                    <asp:BoundField DataField="talk" HeaderText="talk" />
                    <asp:BoundField DataField="validity" HeaderText="validity" />
                </Columns>
                <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
                <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
            </asp:GridView>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;</td>
        <td class="style9">
            &nbsp;</td>
        <td class="style8">
            &nbsp;</td>
        <td class="style7">
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style10">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            </td>
        <td class="style9">
            &nbsp;</td>
        <td class="style8">
            &nbsp;</td>
        <td class="style7">
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style10">
            &nbsp;<asp:Image ID="Image3" runat="server" Height="92px" 
                ImageUrl="~/image/22.jpg" Width="214px" />
            <asp:Label ID="rchg" runat="server" Font-Bold="True" Font-Size="Large" 
                Text="RechargeAmount Details" ForeColor="#CC0000"></asp:Label>
        </td>
        <td class="style9">
            &nbsp;</td>
        <td class="style8">
            &nbsp;</td>
        <td class="style7">
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style10">
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                Height="146px" 
                CellPadding="3" Font-Size="Large" BackColor="#DEBA84" 
                BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellSpacing="2">
                <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
                <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
                <Columns>
                    <asp:BoundField DataField="operator" HeaderText="operator" />
                    <asp:BoundField DataField="amount" HeaderText="amount" />
                    <asp:BoundField DataField="talk" HeaderText="talk" />
                    <asp:BoundField DataField="validity" HeaderText="validity" />
                </Columns>
                <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
                <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
            </asp:GridView>
            </td>
        <td class="style9">
            &nbsp;</td>
        <td class="style8">
            &nbsp;</td>
        <td class="style7">
            &nbsp;</td>
        <td>
            &nbsp;&nbsp;&nbsp;&nbsp;
            </td>
        <td>
            &nbsp;</td>
    </tr>
    </table>
</asp:Content>

