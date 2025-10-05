<%@ Page Language="C#" MasterPageFile="~/cool cab services/maintenanceManger/MaintenanceManger.master" AutoEventWireup="true" CodeFile="ViewDriverDetail.aspx.cs" Inherits="maintenanceManger_ViewDriverDetail" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
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
                <b class="title">DriverDetails</b></td>
           
            
        </tr>
        <tr>
            <td width="50%" align="right" >
                DriverID :</td>
            <td >
                <asp:Label ID="Lbl_DriverID" runat="server" Style="position: static" Text="Label"></asp:Label></td>
            <td rowspan="5"  width="30%">
                </td>
        </tr>
        <tr>
            <td align="right" >
                Name :</td>
            <td >
                <asp:Label ID="Lbl_Name" runat="server" Style="position: static" Text="Label"></asp:Label></td>
        </tr>
        <tr>
            <td align="right" >
                Address :</td>
            <td >
                <asp:Label ID="Lbl_Address" runat="server" Style="position: static" Text="Label"></asp:Label></td>
        </tr>
        <tr>
            <td align="right" >
                PhoneNo :</td>
            <td >
                <asp:Label ID="Lbl_PhoneNo" runat="server" Style="position: static" Text="Label"></asp:Label></td>
        </tr>
        <tr>
            <td align="right" >
                DOB :</td>
            <td >
                <asp:Label ID="Lbl_DOB" runat="server" Style="position: static" Text="Label"></asp:Label></td>
        </tr>
        <tr>
            <td align="right" >
                DOJ :</td>
            <td >
                <asp:Label ID="Lbl_DOJ" runat="server" Style="position: static" Text="Label"></asp:Label></td>
            <td >
            </td>
        </tr>
        <tr>
            <td align="right" >
                Exprience :</td>
            <td >
                <asp:Label ID="Lbl_Exprience" runat="server" Style="position: static" Text="Label"></asp:Label></td>
            <td >
            </td>
        </tr>
        <tr>
            <td align="right" >
                Lincence :</td>
            <td >
                <asp:Label ID="Lbl_Lincence" runat="server" Style="position: static" Text="Label"></asp:Label></td>
            <td >
            </td>
        </tr>
        <tr>
            <td align="right" >
                No Of Accident :</td>
            <td >
                <asp:Label ID="Lbl_Accident" runat="server" Style="position: static" Text="Label"></asp:Label></td>
            <td >
            </td>
        </tr>
        <tr>
            <td >
            </td>
            <td >
                <asp:Button ID="Button1" runat="server" Style="position: static" Text="Back" CssClass="button" OnClick="Button1_Click" />
                <asp:Button ID="Button2" runat="server" Style="position: static" Text="Print" CssClass="button" OnClientClick="return print();" /></td>
            <td >
            </td>
        </tr>
        <tr>
            <td>
            </td>
            <td>
            </td>
            <td>
            </td>
        </tr>
    </table>
</asp:Content>

