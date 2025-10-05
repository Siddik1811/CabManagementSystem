<%@ Page Language="C#" MasterPageFile="~/cool cab services/MovementHomePage/MasterPage.master"
    AutoEventWireup="true" CodeFile="RouteDetails.aspx.cs" Inherits="MovementHomePage_RouteDetails"
    Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <script language="javascript" type="text/javascript">
  function check()
   {
   var TxtRoutedesc=document.getElementById("<%=TxtRoutedesc.ClientID%>").value;
            if(TxtRoutedesc=="")
            {
                 alert("RouteDescription Required");
                 document.getElementById("<%=TxtRoutedesc.ClientID%>").focus();
                 return false;
            }
            if(TxtRoutedesc!="")
            {
                var name=/^[a-zA-Z _.]+$/;
                if(!TxtRoutedesc.match(name))
                {
                        document.getElementById("<%=TxtRoutedesc.ClientID%>").focus();
                        alert ("RouteDescription Should be Character");
                        return false;
                }
            }
              var TxtSource=document.getElementById("<%=TxtSource.ClientID%>").value;
            if(TxtSource=="")
            {
                 alert("Source Required");
                 document.getElementById("<%=TxtSource.ClientID%>").focus();
                 return false;
            }
            if(TxtSource!="")
            {
                var name=/^[a-zA-Z _.]+$/;
                if(!TxtSource.match(name))
                {
                        document.getElementById("<%=TxtSource.ClientID%>").focus();
                        alert ("Source Should be Character");
                        return false;
                }
            }
              var TxtDestination=document.getElementById("<%=TxtDestination.ClientID%>").value;
            if(TxtDestination=="")
            {
                 alert("Destination Required");
                 document.getElementById("<%=TxtDestination.ClientID%>").focus();
                 return false;
            }
            if(TxtDestination!="")
            {
                var name=/^[a-zA-Z _.]+$/;
                if(!TxtDestination.match(name))
                {
                        document.getElementById("<%=TxtDestination.ClientID%>").focus();
                        alert ("Destination Should be Character");
                        return false;
                }
            }
            
 }
    </script>

    <br />
    <br />
    <br />
    <table cellspacing="5" cellpadding="0" align="center" width="700" class="border1">
        <tr>
            <td class="border" colspan="2" align="center">
                <b class="title">RouteDetails</b></td>
        </tr>
        <tr>
            <td>
            </td>
            <td>
            </td>
        </tr>
        <tr>
            <td align="right" width="50%">
                <font color="red">*</font><span><b>RouteDescription :</b></span>
            </td>
            <td>
                <asp:TextBox ID="TxtRoutedesc" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="right">
                <font color="red">*</font><span><b>Source :</b></span>
            </td>
            <td>
                <asp:TextBox ID="TxtSource" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="right">
                <font color="red">*</font><span><b>Destination :</b></span>
            </td>
            <td>
                <asp:TextBox ID="TxtDestination" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
            </td>
            <td>
                <asp:Button ID="BtnSubmit" runat="server" Style="position: static" Text="" CssClass="button"
                    Width="85px" OnClick="BtnSubmit_Click" OnClientClick="javascript:return check();" />
                <asp:Button ID="BtnClear" runat="server" Style="position: static" Text="Clear" CssClass="button"
                    OnClick="BtnClear_Click" />
                <asp:Button ID="BtnBack" runat="server" Style="position: static" Text="Back" CssClass="button"
                    OnClick="BtnBack_Click" /></td>
        </tr>
        <tr>
            <td>
            </td>
            <td>
            </td>
        </tr>
    </table>
</asp:Content>
