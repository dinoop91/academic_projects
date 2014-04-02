<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="mobile_ details.aspx.cs" Inherits="Default4" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
    .style1
    {
        width: 100%;
    }
        .style5
        {
            width: 100%;
        }
        .style6
        {
        }
        .style7
        {
            width: 434px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<table class="style5" 
            style="background-color: #FFFFFF">
        <tr>
            <td class="style6" colspan="2">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="XX-Large" 
        Font-Underline="True" Text="Mobile Details" ForeColor="#CC0000"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style7">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Image ID="Image1" runat="server" Height="209px" Width="226px" 
                    BackColor="#990099" />
            </td>
            <td>
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
            <asp:FileUpload ID="FileUpload1" runat="server" Font-Bold="True" 
                    Font-Size="Large" ForeColor="#FF3300" Width="361px" Height="33px" />
                <br />
                <br />
            </td>
        </tr>
        <tr>
            <td class="style7">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style7">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Size="X-Large" 
                Text="Company" ForeColor="#CC0066"></asp:Label>
            </td>
            <td>
            <asp:DropDownList ID="DropDownList1" runat="server" Height="22px" Width="125px">
                <asp:ListItem>-select-</asp:ListItem>
                <asp:ListItem>Nokia</asp:ListItem>
                <asp:ListItem>SonyEricsson</asp:ListItem>
                <asp:ListItem>Samsung</asp:ListItem>
                <asp:ListItem>Motorola</asp:ListItem>
            </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="style7">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style7">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Size="X-Large" 
                Text="Model" ForeColor="#CC0066"></asp:Label>
            </td>
            <td>
            <asp:TextBox ID="modeltxt" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style7">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style7">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label4" runat="server" Font-Bold="True" Font-Size="X-Large" 
                Text="Feature" ForeColor="#CC0066"></asp:Label>
            </td>
            <td>
            <asp:TextBox ID="featuretxt" runat="server" Height="45px" TextMode="MultiLine" 
                Width="175px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style7">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style7">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label5" runat="server" Font-Bold="True" Font-Size="X-Large" 
                Text="Price" ForeColor="#CC0066"></asp:Label>
            </td>
            <td>
            <asp:TextBox ID="pricetxt" runat="server" Height="16px" 
                    ></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style7">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style7">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label6" runat="server" Font-Bold="True" Font-Size="X-Large" 
                Text="Count" ForeColor="#CC0066"></asp:Label>
            </td>
            <td>
            <asp:TextBox ID="counttxt" runat="server" ></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style7">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style7">
                &nbsp;</td>
            <td>
                <br />
            <asp:Button ID="Button1" runat="server" Font-Bold="True" Font-Size="X-Large" 
                Height="52px" onclick="Button1_Click" Text="Submit" Width="95px" 
                    ForeColor="#FF3300" />
                <br />
            </td>
        </tr>
        <tr>
            <td class="style7">
                &nbsp;</td>
            <td>
            <asp:Button ID="Button3" runat="server" Font-Bold="True" Font-Size="X-Large" 
                Height="51px" onclick="Button3_Click" Text="Edit" Width="94px" 
                    ForeColor="#FF3300" />
            <asp:Button ID="Button4" runat="server" Font-Bold="True" Font-Size="X-Large" 
                Height="49px" onclick="Button4_Click" Text="Delete" Width="78px" 
                    ForeColor="#FF3300" />
            <asp:Button ID="Button5" runat="server" Font-Bold="True" Font-Size="X-Large" 
                Height="50px" PostBackUrl="~/admin_login.aspx" Text="Exit" Width="82px" 
                    ForeColor="#FF3300" />
            </td>
        </tr>
        <tr>
            <td class="style7">
                <br />
            </td>
            <td>
            <asp:Button ID="Button2" runat="server" Height="50px" onclick="Button2_Click" 
                Text="Show Details of Mobiles" Width="253px" Font-Size="Large" 
                    ForeColor="#FF3300" />
                <br />
                <br />
                <br />
                <br />
                <br />
            <asp:DataList ID="DataList1" runat="server" BackColor="#CC0066">
                <ItemTemplate>
                    <table class="style1">
                        <tr>
                            <td>
                                <asp:Image ID="Image2" runat="server" Height="124px" 
                                    ImageUrl='<%# Eval("image") %>' Width="117px" />
                            </td>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td>
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="Label7" runat="server" Text="Company"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="TextBox5" runat="server" Text='<%# Eval("company") %>'></asp:TextBox>
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
                                <asp:Label ID="Label8" runat="server" Text="Model"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="TextBox6" runat="server" Text='<%# Eval("model") %>'></asp:TextBox>
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
                                <asp:Label ID="Label9" runat="server" Text="Features"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="TextBox7" runat="server" Text='<%# Eval("feature") %>'></asp:TextBox>
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
                                <asp:Label ID="Label10" runat="server" Text="Price"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="TextBox9" runat="server" Text='<%# Eval("price") %>'></asp:TextBox>
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
                                <asp:Label ID="Label11" runat="server" Text="Count"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="TextBox8" runat="server" Text='<%# Eval("count") %>'></asp:TextBox>
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
                                &nbsp;</td>
                        </tr>
                    </table>
                </ItemTemplate>
            </asp:DataList>
            </td>
        </tr>
        <tr>
            <td class="style7">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</p>
</asp:Content>

