<%@ Page Language="C#" MasterPageFile="~/cool cab services/maintenanceManger/MaintenanceManger.master"
    AutoEventWireup="true" CodeFile="VenderDetails.aspx.cs" Inherits="maintenanceManger_VenderDetails"
    Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <script language="javascript" type="text/javascript">
  function check()
   {
       var TxtVenderName=document.getElementById("<%=TxtVenderName.ClientID%>").value;
            if(TxtVenderName=="")
            {
                 alert("VenderName Required");
                 document.getElementById("<%=TxtVenderName.ClientID%>").focus();
                 return false;
            }
            if(TxtVenderName!="")
            {
                var name=/^[a-zA-Z _.]+$/;
                if(!TxtVenderName.match(name))
                {
                        document.getElementById("<%=TxtVenderName.ClientID%>").focus();
                        alert ("FirstName Should be Character");
                        return false;
                }
            }
            
             var TxtvenderAddress=document.getElementById("<%=TxtvenderAddress.ClientID%>").value;
            if(TxtvenderAddress=="")
            {
               
                alert('VenderAddress Address Required');
                document.getElementById("<%=TxtvenderAddress.ClientID%>").focus();
                return false;
            }
            var TxtPhoneeNo=document.getElementById("<%=TxtPhoneeNo.ClientID%>").value;
          if(TxtPhoneeNo=="")
            {
               
                document.getElementById("<%=TxtPhoneeNo.ClientID%>").focus();
                alert('MobileNo Required');
                return false;
            }
           else if(TxtPhoneeNo!="")
            {
             var Exp=/^[0-9 ()+-]+$/;
              if(!TxtPhoneeNo.match(Exp))
                {
                    alert('MobileNo Digits Only');
                    document.getElementById("<%=TxtPhoneeNo.ClientID%>").focus();
                    return false;
                }
            }
            
             var TxtEmailId=document.getElementById("<%=TxtEmailId.ClientID%>").value;
            if(TxtEmailId=="")
            {
               
                alert('EmailId Required');
                document.getElementById("<%=TxtEmailId.ClientID%>").focus();
                return false;
            }
            else if(TxtEmailId!="")
            {
                var Exp=/^(\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*)+$/;
                if(!TxtEmailId.match(Exp))
                {
                    alert('Invalid EmailId');
                    document.getElementById("<%=TxtEmailId.ClientID%>").focus();
                    return false;
                }
            }
             var TxtRemarks=document.getElementById("<%=TxtRemarks.ClientID%>").value;
            if(TxtRemarks=="")
            {
                 alert("Remarks Required");
                 document.getElementById("<%=TxtRemarks.ClientID%>").focus();
                 return false;
            }
            if(TxtRemarks!="")
            {
                var name=/^[a-zA-Z _.]+$/;
                if(!TxtRemarks.match(name))
                {
                        document.getElementById("<%=TxtRemarks.ClientID%>").focus();
                        alert ("Remarks Should be Character");
                        return false;
                }
            }
}
    </script>

    <table cellspacing="5" cellpadding="0" align="center" width="700" class="border1">
        <tr>
            <td class="border" colspan="2" align="center">
                <b class="title">VendorDetails</b></td>
        </tr>
        <tr>
            <td width="50%" align="right">
                VendorName :</td>
            <td>
                <asp:TextBox ID="TxtVenderName" runat="server" Style="position: static"></asp:TextBox></td>
        </tr>
        <tr>
            <td align="right">
                VendorAddress :</td>
            <td>
                <asp:TextBox ID="TxtvenderAddress" runat="server" Style="position: static"></asp:TextBox></td>
        </tr>
        <tr>
            <td align="right">
                PhoneNo :</td>
            <td>
                <asp:TextBox ID="TxtPhoneeNo" runat="server" Style="position: static"></asp:TextBox></td>
        </tr>
        <tr>
            <td align="right">
                EmailID :</td>
            <td>
                <asp:TextBox ID="TxtEmailId" runat="server" Style="position: static"></asp:TextBox></td>
        </tr>
        <tr>
            <td align="right">
                Remarks :</td>
            <td>
                <asp:TextBox ID="TxtRemarks" runat="server" Style="position: static"></asp:TextBox></td>
        </tr>
        <tr>
            <td align="right">
            </td>
            <td>
            </td>
        </tr>
        <tr>
            <td style="height: 17px">
            </td>
            <td style="height: 17px">
                <asp:Button ID="Button1" runat="server" Style="position: static" CssClass="button"
                    OnClick="Button1_Click" OnClientClick="javascript:return check();" />
                <asp:Button ID="Button2" runat="server" Style="position: static" Text="Clear" CssClass="button"
                    OnClick="Button2_Click" />
                <asp:Button ID="But_Back" runat="server" Style="position: static" Text="Back" CssClass="button"
                    OnClick="But_Back_Click" /></td>
        </tr>
    </table>    
</asp:Content>
