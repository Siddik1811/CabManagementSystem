<%@ Page Language="C#" MasterPageFile="~/cool cab services/QulityAssranceManger/MasterPage.master" AutoEventWireup="true" CodeFile="ChangePassword.aspx.cs" Inherits="QulityAssranceManger_ChangePassword" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <script language="javascript" type="text/javascript">
  function check()
   {
    var TxtOldPassword=document.getElementById("<%=TxtOldPassword.ClientID%>").value;
            if(TxtOldPassword=="")
            {
                 alert("OldPassword Required");
                 document.getElementById("<%=TxtOldPassword.ClientID%>").focus();
                 return false;
            }
          
             var TxtNewpassword=document.getElementById("<%=TxtNewpassword.ClientID%>").value;
            if(TxtNewpassword=="")
            {
                 alert("Newpassword Required");
                 document.getElementById("<%=TxtNewpassword.ClientID%>").focus();
                 return false;
            }
          
            var TxtRetypepwd=document.getElementById("<%=TxtRetypepwd.ClientID%>").value;
            if(TxtRetypepwd=="")
            {
                 alert("RetypeNewPassword Required");
                 document.getElementById("<%=TxtRetypepwd.ClientID%>").focus();
                 return false;
            }
              if(TxtNewpassword!=TxtRetypepwd)
            {
                 alert("Conform password Not Match");
                 document.getElementById("<%=TxtRetypepwd.ClientID%>").focus();
                 return false;
            }
          
 }
    </script>

    <table align="center" cellpadding="0" cellspacing="5" class="border1" style="position: static"
        width="700">
        <tr>
            <td align="center" class="border" colspan="3">
                <b class="title">ChangePassword</b></td>
        </tr>
        <tr>
            <td align="right">
                <font color="red" width="50%">*</font><span><b>Oldpassword :</b></span>
            </td>
            <td>
                <asp:TextBox ID="TxtOldPassword" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="right">
                <font color="red">*</font><span><b>NewPassword :</b></span>
            </td>
            <td>
                <asp:TextBox ID="TxtNewpassword" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="right">
                <font color="red">*</font><span><b>ConformPassword :</b></span>
            </td>
            <td>
                <asp:TextBox ID="TxtRetypepwd" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
            </td>
            <td>
                &nbsp;<asp:Button ID="changepwd" runat="server" Style="position: static" Text="Submit"
                    CssClass="button" OnClick="changepwd_Click" OnClientClick="javascript:return check();" /></td>
        </tr>
    </table>
</asp:Content>
