<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Mobilepurchase.aspx.cs" Inherits="Default2" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
    .style1
    {
        width: 100%;
            height: 318px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <table class="style1">
        <tr>
            <td bgcolor="#006600" style="background-color: #FFFFFF">
<p>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label 
        ID="Label5" runat="server" Font-Size="Medium" Text="Select Company" 
        ForeColor="#FF0066" Font-Bold="True"></asp:Label>
    <asp:DropDownList ID="drpcompany" 
        runat="server" Height="46px" Width="162px" AutoPostBack="True" 
        onselectedindexchanged="drpcompany_SelectedIndexChanged1" >
        <asp:ListItem>
        </asp:ListItem>
    </asp:DropDownList>
</p>
                <br />
    <asp:DataList ID="DataList1" runat="server" Font-Size="Medium" 
                    BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" 
                    CellPadding="2" ForeColor="Black" onselectedindexchanged="DataList1_SelectedIndexChanged" 
                   >
        <FooterStyle BackColor="Tan" />
        <ItemTemplate>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <table class="style1">
                <tr>
                    <td>
                        <asp:Image ID="Image1" runat="server" Height="119px" 
                            ImageUrl='<%# Eval("image") %>' Width="136px" />
                    </td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td>
                        &nbsp;</td>
                    <td style="background-color: #FFFFFF; color: #FFFFCC;">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text="ModelName" Font-Size="Large"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox1" runat="server" Text='<%# Eval("model") %>'></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label3" runat="server" Text="Price" Font-Size="Large"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox2" runat="server" Text='<%# Eval("price") %>'></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label4" runat="server" Text="Feature" Font-Size="Large"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox3" runat="server" Text='<%# Eval("feature") %>'></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td>
                        &nbsp;</td>
                    <td>
                        <asp:LinkButton ID="LinkButton1" runat="server" 
                            CommandArgument='<%# Eval("model") %>' oncommand="LinkButton1_Command" 
                            Font-Bold="True" ForeColor="Red" >GO</asp:LinkButton>
                    </td>
                </tr>
            </table>
        </ItemTemplate>
        <AlternatingItemStyle BackColor="PaleGoldenrod" />
        <SelectedItemStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
        <HeaderStyle BackColor="Tan" Font-Bold="True" />
    </asp:DataList>
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
            </td>
        </tr>
        </table>
</asp:Content>

