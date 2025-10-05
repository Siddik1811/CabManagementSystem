<%@ Page Language="C#" MasterPageFile="~/cool cab services/Admin/WelcomeAdmin.master" AutoEventWireup="true" CodeFile="LoginDetails.aspx.cs" Inherits="Admin_LoginDetails" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table cellspacing="5" cellpadding="0" align="center" width="700" class="border1">
        <tr>
            <td class="border" colspan="2" align="center">
                <b class="title">Login Details</b></td>
        </tr>
        <tr>
            <td >
            </td>
        </tr>
        <tr>
            <td  align="center">
                <asp:GridView ID="GdVLogin" runat="server" Style="position: static" 
                    AllowPaging="True" OnPageIndexChanging="GdVLogin_PageIndexChanging" 
                    onselectedindexchanged="GdVLogin_SelectedIndexChanged">
                </asp:GridView>
            </td>
        </tr>
    </table>
</asp:Content>

