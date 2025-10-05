<%@ Page Language="C#" MasterPageFile="~/cool cab services/maintenanceManger/MaintenanceManger.master" AutoEventWireup="true" CodeFile="DriverDetails.aspx.cs" Inherits="maintenanceManger_DriverDetails" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<script language="javascript" type="text/javascript">
  function check()
   {
    var TxtDriverName=document.getElementById("<%=TxtDriverName.ClientID%>").value;
            if(TxtDriverName=="")
            {
                 alert("DriverName Required");
                 document.getElementById("<%=TxtDriverName.ClientID%>").focus();
                 return false;
            }
            if(TxtDriverName!="")
            {
                var name=/^[a-zA-Z _.]+$/;
                if(!TxtDriverName.match(name))
                {
                        document.getElementById("<%=TxtDriverName.ClientID%>").focus();
                        alert ("DriverName Should be Character");
                        return false;
                }
            }
             var TxtAddress=document.getElementById("<%=TxtAddress.ClientID%>").value;
            if(TxtAddress=="")
            {
               
                alert('Address Required');
                document.getElementById("<%=TxtAddress.ClientID%>").focus();
                return false;
            }
            var TxtPhoneNo=document.getElementById("<%=TxtPhoneNo.ClientID%>").value;
          if(TxtPhoneNo=="")
            {
               
                document.getElementById("<%=TxtPhoneNo.ClientID%>").focus();
                alert('MobileNo Required');
                return false;
            }
           else if(TxtPhoneNo!="")
            {
             var Exp=/^[0-9 ()+-]+$/;
              if(!TxtPhoneNo.match(Exp))
                {
                    alert('MobileNo Digits Only');
                    document.getElementById("<%=TxtPhoneNo.ClientID%>").focus();
                    return false;
                }
            }
            var Txt_DOB=document.getElementById("<%=Txt_DOB.ClientID%>").value; 
            if(Txt_DOB=="")
            {
                alert("Date of Birth Required");
                document.getElementById("<%=Txt_DOB.ClientID%>").focus();
                return false;
            }
             var Txt_DOJ=document.getElementById("<%=Txt_DOJ.ClientID%>").value; 
            if(Txt_DOJ=="")
            {
                alert("DOJ Required");
                document.getElementById("<%=Txt_DOJ.ClientID%>").focus();
                return false;
            }
             var TxtExprince=document.getElementById("<%=TxtExprince.ClientID%>").value;
            if(TxtExprince=="")
            {
                 alert("Exprince Required");
                 document.getElementById("<%=TxtExprince.ClientID%>").focus();
                 return false;
            }
            if(TxtExprince!="")
            {
                var name=/^[a-zA-Z 0-9]+$/;
                if(!TxtExprince.match(name))
                {
                        document.getElementById("<%=TxtExprince.ClientID%>").focus();
                        alert ("Exprince Should be Character or Numbers");
                        return false;
                }
            }
            //TxtLicence
              var TxtLicence=document.getElementById("<%=TxtLicence.ClientID%>").value;
            if(TxtLicence=="")
            {
                 alert("LicenceNo Required");
                 document.getElementById("<%=TxtLicence.ClientID%>").focus();
                 return false;
            }
            if(TxtLicence!="")
            {
                var name=/^[a-zA-Z 0-9]+$/;
                if(!TxtLicence.match(name))
                {
                        document.getElementById("<%=TxtLicence.ClientID%>").focus();
                        alert ("Licence No Should be Character or Numbers");
                        return false;
                }
            }
            //TxtAccident
               var TxtAccident=document.getElementById("<%=TxtAccident.ClientID%>").value;
            if(TxtAccident=="")
            {
                 alert("No Of Accident Required");
                 document.getElementById("<%=TxtAccident.ClientID%>").focus();
                 return false;
            }
            if(TxtAccident!="")
            {
                var name=/^[0-9]+$/;
                if(!TxtAccident.match(name))
                {
                        document.getElementById("<%=TxtAccident.ClientID%>").focus();
                        alert (" No Of Accident Should be  Numbers");
                        return false;
                }
            }
            
            
   }
</script>

    <table cellspacing="5" cellpadding="0" align="center" width="700"  class="border1"  >
        <tr>
          <td class="border" colspan="2" align="center"  >
              <b class="title">DriverDetails</b></td>
        </tr>
        <tr>
            <td align="right" width="50%" style="height: 25px" ><font color="red">*</font><span><b>DriverName :</b></span>
            </td>
            <td style="width: 344px; height: 25px;" >
                <asp:TextBox ID="TxtDriverName" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="right" ><font color="red">*</font><span><b>Address :</b></span>
            </td>
            <td style="width: 344px" >
                <asp:TextBox ID="TxtAddress" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="right" style="height: 20px" ><font color="red">*</font><span><b>PhoneNo :</b></span>
            </td>
            <td style="height: 20px; width: 344px;" >
                <asp:TextBox ID="TxtPhoneNo" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="right" ><font color="red">*</font><span><b>DOB :</b></span>
            </td>
            <td align="left" style="width: 344px">
                            <asp:TextBox ID="Txt_DOB" runat="server" CssClass="textbox" MaxLength="10" Wrap="False" /><a
                                href="javascript:NewCal('<%=Txt_DOB.ClientID %>','mmddyyyy')"><img src="../images/cal.gif"
                                    width="16" height="16" border="0" alt="Pick a date" /></a><br />
                            &nbsp;&nbsp;mm/dd/yyyy
                        </td>
        </tr>
        <tr>
            <td align="right" ><font color="red">*</font><span><b>DOJ :</b></span>
            </td>
             <td align="left" style="width: 344px">
                            <asp:TextBox ID="Txt_DOJ" runat="server" CssClass="textbox" MaxLength="10" Wrap="False" /><a
                                href="javascript:NewCal('<%=Txt_DOJ.ClientID %>','mmddyyyy')"><img src="../images/cal.gif"
                                    width="16" height="16" border="0" alt="Pick a date" /></a><br />
                            &nbsp;&nbsp;mm/dd/yyyy
                        </td>
        </tr>
        <tr>
            <td align="right" ><font color="red">*</font><span><b>Exprience :</b></span>
            </td>
            <td style="width: 344px" >
                <asp:TextBox ID="TxtExprince" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="right" ><font color="red">*</font><span><b>Licence No :</b></span>
            </td>
            <td style="width: 344px" >
                <asp:TextBox ID="TxtLicence" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="right" ><font color="red">*</font><span><b>No Of Accident :</b></span>
            </td>
            <td style="width: 344px" >
                <asp:TextBox ID="TxtAccident" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="right" >
            </td>
            <td style="width: 344px" >
                &nbsp;</td>
        </tr>
        <tr>
            <td >
            </td>
            <td style="width: 344px" >
                <asp:Button ID="Btn_Click" runat="server" Style="position: static" CssClass="button" Width="61px" OnClick="Btn_Click_Click" OnClientClick="javascript:return check();" />
                <asp:Button ID="Button1" runat="server" Style="position: static" Text="Clear" CssClass="button" OnClick="Button1_Click" />
                <asp:Button ID="But_Back" runat="server" Style="position: static" Text="Back" CssClass="button" OnClick="But_Back_Click" /></td>
        </tr>
        <tr>
            <td >
            </td>
            <td style="width: 344px" >
            </td>
        </tr>
    </table>
</asp:Content>

