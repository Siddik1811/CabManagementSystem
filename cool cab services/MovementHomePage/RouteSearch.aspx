<%@ Page Language="C#" MasterPageFile="~/cool cab services/MovementHomePage/MasterPage.master" AutoEventWireup="true" CodeFile="RouteSearch.aspx.cs" Inherits="MovementHomePage_RouteSearch" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<script language="javascript" type="text/javascript">
  function check()
   {
     var DDLSeach=document.getElementById("<%=DDLSeach.ClientID%>").selectedIndex;
            if(DDLSeach==0)
            {
                alert('Route Required');
                return false;
            }
 }
</script>

    <table align="center" cellpadding="0" cellspacing="5" class="border1" style="position: static"
        width="700">
        <tr>
            <td align="center" class="border" colspan="3">
                <b class="title">Search RouteDetails</b></td>
        </tr>
        <tr>
            <td align="right"  Width="50%" ><font color="red">*</font><span><b>Select the Route to Search :</b></span>
            </td>
            <td >
                <asp:DropDownList ID="DDLSeach" runat="server" Style="position: static" AppendDataBoundItems="True" Width="133px">
                    <asp:ListItem>Select...</asp:ListItem>
                </asp:DropDownList></td>
        </tr>
        <tr>
            <td >
            </td>
            <td >
                <asp:Button ID="Search" runat="server" Style="position: static" Text="Search" CssClass="button" OnClick="Search_Click" OnClientClick="javascript:return check();" />
                <asp:Label ID="Label1" runat="server" Style="position: static" Text="Label"></asp:Label></td>
        </tr>
        <tr>
            <td align="center" colspan="2" >
                <asp:GridView ID="GdVSearch" runat="server"
                    Style="position: static" Font-Names="Arial" Font-Size="9pt" Width="406px" AllowPaging="True" OnPageIndexChanging="GdVSearch_PageIndexChanging" PageSize="7">
                    <RowStyle HorizontalAlign="Center" />
                </asp:GridView>
            </td>
        </tr>
    </table>
</asp:Content>

