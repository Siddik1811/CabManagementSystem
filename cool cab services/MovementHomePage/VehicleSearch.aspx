<%@ Page Language="C#" MasterPageFile="~/cool cab services/MovementHomePage/MasterPage.master" AutoEventWireup="true" CodeFile="VehicleSearch.aspx.cs" Inherits="MovementHomePage_VehicleSearch" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<script language="javascript" type="text/javascript">
  function check()
   {
     var DDLVehicleID=document.getElementById("<%=DDLVehicleID.ClientID%>").selectedIndex;
            if(DDLSeach==0)
            {
                alert('VehicleID Required');
                return false;
            }
 }
</script>

    <table align="center" cellpadding="0" cellspacing="5" class="border1" style="position: static"
        width="700">
        <tr>
            <td align="center" class="border" colspan="3">
                <b class="title">Search VehicleDetails</b></td>
        </tr>
        <tr>
            <td align="right" ><font color="red">*</font><span><b>Vehicle Search :</b></span>
                </td>
            <td >
                <asp:DropDownList ID="DDLVehicleID" runat="server" AppendDataBoundItems="True" Style="position: static"
                    Width="149px">
                    <asp:ListItem>Select....</asp:ListItem>
                </asp:DropDownList></td>
        </tr>
        <tr>
            <td >
            </td>
            <td >
                <asp:Button ID="Search" runat="server" Style="position: static" Text="Search" CssClass="button" OnClick="Search_Click" OnClientClick="javascript:return check();" />
                <asp:Label ID="Label1" runat="server" Style="position: static" Text="Label" Font-Names="Arial" ForeColor="#C00000"></asp:Label></td>
        </tr>
        <tr>
            <td align="center" colspan="2" >
                <asp:GridView ID="GridView1" runat="server" Style="position: static" CellPadding="4" ForeColor="#333333" GridLines="None" Width="428px">
                    <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <RowStyle BackColor="#EFF3FB" />
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

