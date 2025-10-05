<%@ Page Language="C#" MasterPageFile="~/cool cab services/MovementHomePage/MasterPage.master" AutoEventWireup="true" CodeFile="SearchShiftID.aspx.cs" Inherits="MovementHomePage_SearchShiftID" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<script language="javascript" type="text/javascript">
  function check()
   {
     var DDLSearchShift=document.getElementById("<%=DDLSearchShift.ClientID%>").selectedIndex;
            if(DDLSearchShift==0)
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
                <b class="title">Search ShiftDetails</b></td>
        </tr>
        <tr>
            <td width="50%" align="right"><font color="red">*</font><span><b>ShiftID :</b></span>
            </td>
            <td style="width: 3px" >
                <asp:DropDownList ID="DDLSearchShift" runat="server" Style="position: static" Width="134px" AppendDataBoundItems="True">
                    <asp:ListItem>Select....</asp:ListItem>
                </asp:DropDownList></td>
        </tr>
        <tr>
            <td align="right" width="50%">
            </td>
            <td style="width: 3px">
                <asp:Button ID="Search" runat="server" Style="position: static" Text="Search"  CssClass="button" OnClick="Search_Click" OnClientClick="javascript:return check();" /></td>
        </tr>
        <tr>
            <td align="right" width="50%">
            </td>
            <td style="width: 3px">
                <asp:Label ID="Label1" runat="server" Style="position: static" Text="Label"></asp:Label></td>
        </tr>
        <tr>
            <td >
                <asp:Label ID="LblEmp" runat="server" Style="position: static" ForeColor="#C00000" Font-Bold="True"></asp:Label></td>
            <td style="width: 3px" >
                &nbsp;
                <asp:Label ID="LblDriver" runat="server" Style="position: static" ForeColor="#C00000" Font-Bold="True"></asp:Label></td>
        </tr>
        <tr>
            <td align="left" valign="top">
                <asp:GridView ID="GdVSearch" runat="server" Style="position: static" CellPadding="4" ForeColor="#333333" GridLines="None">
                    <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <RowStyle BackColor="#EFF3FB" />
                    <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                    <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                    <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <EditRowStyle BackColor="#2461BF" />
                    <AlternatingRowStyle BackColor="White" />
                </asp:GridView>
            </td>
            <td style="width: 3px" align="left" valign="top">
                <asp:GridView ID="GridView1" runat="server" Style="position: static" CellPadding="4" ForeColor="#333333" GridLines="None" PageSize="5">
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
        <tr>
            <td align="center" colspan="2" >
                &nbsp;&nbsp;
            </td>
        </tr>
    </table>
</asp:Content>

