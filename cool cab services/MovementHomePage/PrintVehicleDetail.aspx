<%@ Page Language="C#" MasterPageFile="~/cool cab services/MovementHomePage/MasterPage.master" AutoEventWireup="true" CodeFile="PrintVehicleDetail.aspx.cs" Inherits="MovementHomePage_PrintVehicleDetail" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<script language="javascript" type="text/javascript">
function f()
{
window.print();
}
    </script>
    <br />
    <br />
    <br />
<table align="center" cellpadding="0" cellspacing="5" class="border1" style="position: static"
        width="700">
        <tr>
            <td align="center" class="border" colspan="3">
                <b class="title">View VehicleAlloctionDetails</b></td>
        </tr>
        <tr>
            <td  align="center">
                <asp:Button ID="Button1" runat="server" Style="position: static" Text="Print" 
                    CssClass="button" OnClientClick="return f();" onclick="Button1_Click" /></td>
        </tr>
        <tr>
            <td  align="center">
                <asp:GridView ID="GridView1" runat="server" Style="position: static" 
                    Font-Names="Arial" Font-Size="9pt" CellPadding="4" ForeColor="#333333" 
                    GridLines="None" Width="472px" 
                    onselectedindexchanged="GridView1_SelectedIndexChanged" >
                    
                    <RowStyle HorizontalAlign="Center" BackColor="#EFF3FB" />
                    <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                    <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                    <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <EditRowStyle BackColor="#2461BF" />
                    <AlternatingRowStyle BackColor="White" />
                </asp:GridView>
                
            </td>
        </tr>
    </table>
</asp:Content>

