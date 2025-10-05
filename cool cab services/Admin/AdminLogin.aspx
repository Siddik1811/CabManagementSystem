<%@ Page Language="C#" MasterPageFile="~/cool cab services/Admin/HomePage.master" AutoEventWireup="true" CodeFile="AdminLogin.aspx.cs" Inherits="Admin_AdminLogin" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<script language="javascript" type="text/javascript">
  function check()
   {
    var Txt_UserName=document.getElementById("<%=Txt_UserName.ClientID%>").value;
            if(Txt_UserName=="")
            {
                   document.getElementById("<%=Txt_UserName.ClientID%>").focus();
                   alert("UserName Required");
                   return false;
            }
//            if(Txt_UserName!="")
//            {
//                var LastName=/^[a-zA-Z _.0-9]+$/;
//                if(!Txt_UserName.match(LastName))
//                {
//                   alert ("UserName Should be Characters");
//                   document.getElementById("<%=Txt_UserName.ClientID%>").focus();
//                   return false;
//                }
//            }
             var Txt_Password=document.getElementById("<%=Txt_Password.ClientID%>").value;
            if(Txt_Password=="")
            {
                   document.getElementById("<%=Txt_Password.ClientID%>").focus();
                   alert("Password Required");
                   return false;
            }
//            if(Txt_Password!="")
//            {
//                var LastName=/^[a-zA-Z _.0-9]+$/;
//                if(!Txt_Password.match(LastName))
//                {
//                   alert ("Password  Should be Characters or Digits");
//                   document.getElementById("<%=Txt_Password.ClientID%>").focus();
//                   return false;
//                }
//            }
 }
</script>
    <table style="position: static; background-color: transparent;" height="200" >
        <tr>
            <td colspan="2" width="500" class="title" align="center" >Login
            </td>
        </tr>
        <tr>
            <td colspan="2">
            </td>
        </tr>
        <tr>
            <td align="right"  ><font color="red">*</font><span><b>UserName :</b></span>
            
            </td>
            <td style="height: 25px" >
                <asp:TextBox ID="Txt_UserName" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="right"  ><font color="red">*</font><span><b>Password :</b></span>
                </td>
            <td style="height: 26px" >
                <asp:TextBox ID="Txt_Password" runat="server" Style="position: static" TextMode="Password"></asp:TextBox></td>
        </tr>
        <tr>
            <td align="center" colspan="2">
                <asp:Button ID="But_Login" runat="server" Text="Login"  CssClass="button" OnClick="But_Login_Click" OnClientClick="javascript:return check();" />
            </td>
        </tr>
        <tr>
            <td>
            </td>
            <td>
                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Admin/ForgetPassword.aspx" CssClass="links" Font-Underline="False" >Forgot PassWord</asp:HyperLink>
            </td>
        </tr>
    </table>

</asp:Content>

