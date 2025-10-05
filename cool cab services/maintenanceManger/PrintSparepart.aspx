<%@ Page Language="C#" MasterPageFile="~/cool cab services/maintenanceManger/MaintenanceManger.master"
    AutoEventWireup="true" CodeFile="PrintSparepart.aspx.cs" Inherits="maintenanceManger_PrintSparepart"
    Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <script language="javascript" type="text/javascript">
function f()
{
window.print();
}
    </script>
   
    <table align="center" cellpadding="0" cellspacing="5" class="border1" style="position: static"
        width="700">
        <tr>
            <td align="center" class="border" colspan="3">
                <b class="title">SparePartDetails</b></td>
        </tr>
        <tr>
            <td align="center">
                <asp:GridView ID="GdV_SparePart" runat="server" Style="position: static">
                </asp:GridView>
            </td>
        </tr>
        <tr>
            <td align="center">
                <asp:Button ID="Button1" runat="server" Text="Print" CssClass="button" OnClientClick="return f();" />
            </td>
        </tr>
    </table>
</asp:Content>
