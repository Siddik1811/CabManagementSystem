<%@ Page Language="C#" MasterPageFile="~/cool cab services/FinancialHomePage/MasterPage.master" AutoEventWireup="true"
    CodeFile="Changepassword.aspx.cs" Inherits="FinancialHomePage_Changepassword"
    Title="Untitled Page" %>

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
//            if(TxtOldPassword!="")
//            {
//                var name=/^[a-zA-Z_.0-9]+$/;
//                if(!TxtOldPassword.match(name))
//                {
//                        document.getElementById("<%=TxtOldPassword.ClientID%>").focus();
//                        alert ("OldPassword Should be Character");
//                        return false;
//                }
//            }
             var TxtNewpassword=document.getElementById("<%=TxtNewpassword.ClientID%>").value;
            if(TxtNewpassword=="")
            {
                 alert("Newpassword Required");
                 document.getElementById("<%=TxtNewpassword.ClientID%>").focus();
                 return false;
            }
//            if(TxtNewpassword!="")
//            {
//                var name=/^[a-zA-Z _.]+$/;
//                if(!TxtNewpassword.match(name))
//                {
//                        document.getElementById("<%=TxtNewpassword.ClientID%>").focus();
//                        alert ("Newpassword Should be Character");
//                        return false;
//                }
//            }
               var TxtNewpassword=document.getElementById("<%=TxtNewpassword.ClientID%>").value;
             var TxtRetypeNewPassword=document.getElementById("<%=TxtRetypeNewPassword.ClientID%>").value;
            if(TxtRetypeNewPassword=="")
            {
                 alert("Conform Required");
                 document.getElementById("<%=TxtRetypeNewPassword.ClientID%>").focus();
                 return false;
            }
            if(TxtNewpassword!=TxtRetypeNewPassword)
            {
                 alert("Conform password Not Match");
                 document.getElementById("<%=TxtRetypeNewPassword.ClientID%>").focus();
                 return false;
            }
//            if(TxtRetypeNewPassword!="")
//            {
//                var name=/^[a-zA-Z _.]+$/;
//                if(!TxtRetypeNewPassword.match(name))
//                {
//                        document.getElementById("<%=TxtRetypeNewPassword.ClientID%>").focus();
//                        alert ("Conform Should be Character");
//                        return false;
//                }
//            }
   
 }
    </script>

    <table cellspacing="5" cellpadding="0" align="center" width="700" class="border1">
        <tr>
            <td class="border" colspan="3" align="center">
                <b class="title">ChangePassword</b></td>
        </tr>
        <tr>
            <td align="right" width="50%">
                <font color="red">*</font><span><b>Oldpassword :</b></span>
            </td>
            <td>
                <asp:TextBox ID="TxtOldPassword" runat="server" TextMode="Password"></asp:TextBox>&nbsp;
            </td>
        </tr>
        <tr>
            <td align="right">
                <font color="red">*</font><span><b>NewPassword :</b></span>
            </td>
            <td>
                <asp:TextBox ID="TxtNewpassword" runat="server" TextMode="Password"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="right">
                <font color="red">*</font><span><b>Retype NewPassword :</b></span>
            </td>
            <td>
                <asp:TextBox ID="TxtRetypeNewPassword" runat="server" TextMode="Password"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
            </td>
            <td>
                <asp:Button ID="btnSubmit" runat="server" Text="Submit" CssClass="button" OnClientClick="javascript:return check();"
                    OnClick="btnSubmit_Click" />
            </td>
        </tr>
    </table>
</asp:Content>
