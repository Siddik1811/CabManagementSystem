<%@ Page Language="C#" MasterPageFile="~/cool cab services/MovementHomePage/MasterPage.master" AutoEventWireup="true" CodeFile="DriverShiftDetails.aspx.cs" Inherits="MovementHomePage_DriverShiftDetails" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<script language="javascript" type="text/javascript">
  function check()
   {
             var DDLdriverID=document.getElementById("<%=DDLdriverID.ClientID%>").selectedIndex;
            if(DDLdriverID==0)
            {
                alert('DriverID Required');
                return false;
            }
            
             var TxtName=document.getElementById("<%=TxtName.ClientID%>").value;
            if(TxtName=="")
            {
                 alert("DriverName Required");
                 document.getElementById("<%=TxtName.ClientID%>").focus();
                 return false;
            }
            if(TxtName!="")
            {
                var name=/^[a-zA-Z _.]+$/;
                if(!TxtName.match(name))
                {
                        document.getElementById("<%=TxtName.ClientID%>").focus();
                        alert ("DriverName Should be Character");
                        return false;
                }
            }
            
              var DDL_ShiftID=document.getElementById("<%=DDL_ShiftID.ClientID%>").selectedIndex;
            if(DDL_ShiftID==0)
            {
                alert('ShiftID Required');
                return false;
            }
             var Txt_DOB=document.getElementById("<%=Txt_DOB.ClientID%>").value; 
            if(Txt_DOB=="")
            {
                alert("Date of Birth Required");
                document.getElementById("<%=Txt_DOB.ClientID%>").focus();
                return false;
            }
            
             var rdo=document.getElementById("<%=RdBtLShift.ClientID %>");
            var opt=rdo.getElementsByTagName('input');
            if(!opt[0].checked && !opt[1].checked)
            {
               alert("Shifting Required");
               return false; 
            }
 }
</script>
<br />
<br />
<br />
   <table cellspacing="5" cellpadding="0" align="center" width="700"  class="border1"  >
        <tr>
          <td class="border" colspan="2" align="center"  >
              <b class="title">DriverShiftDetails</b></td>
        </tr>
        <tr>
            <td align="right" ><font color="red">*</font><span><b>DriverID :</b></span>
            </td>
            <td >
                <asp:DropDownList ID="DDLdriverID" runat="server" Style="position: static" Width="140px" AppendDataBoundItems="True" AutoPostBack="True" OnSelectedIndexChanged="DDLdriverID_SelectedIndexChanged">
                    <asp:ListItem>Select....</asp:ListItem>
                </asp:DropDownList></td>
        </tr>
       <tr>
           <td align="right"><font color="red">*</font><span><b>DriverName :</b></span>
           </td>
           <td>
               <asp:TextBox ID="TxtName" runat="server" Width="135px"></asp:TextBox>
           </td>
       </tr>
        <tr>
            <td align="right" ><font color="red">*</font><span><b>ShiftID :</b></span>
            </td>
            <td >
                <asp:DropDownList ID="DDL_ShiftID" runat="server" Style="position: static" Width="142px" AppendDataBoundItems="True">
                    <asp:ListItem>Select....</asp:ListItem>
                </asp:DropDownList></td>
        </tr>
        <tr>
            <td align="right" ><font color="red">*</font><span><b>Shift Date :</b></span>
            </td>
            <td align="left">
                            <asp:TextBox ID="Txt_DOB" runat="server" CssClass="textbox" MaxLength="10" Wrap="False" /><a
                                href="javascript:NewCal('<%=Txt_DOB.ClientID %>','mmddyyyy')"><img src="../images/cal.gif"
                                    width="16" height="16" border="0" alt="Pick a date" /></a><br /> mm/dd/yyyy 
                            </td>
            
        </tr>
        <tr>
            <td align="right" ><font color="red">*</font><span><b>Shifting :</b></span>
            </td>
            <td >
                <asp:RadioButtonList ID="RdBtLShift" runat="server" Style="position: static"
                    Width="144px" RepeatDirection="Horizontal">
                    <asp:ListItem>PartTime</asp:ListItem>
                    <asp:ListItem Selected="True">FullTime</asp:ListItem>
                </asp:RadioButtonList></td>
        </tr>
        <tr>
            <td >
            </td>
            <td >
                <asp:Button ID="Btn_Insert" runat="server" Style="position: static" CssClass="button" OnClick="Button1_Click" Width="85px" OnClientClick="javascript:return check();" />
                <asp:Button ID="Button2" runat="server" Style="position: static" Text="Clear" CssClass="button" OnClick="Button2_Click" />
                <asp:Button ID="But_Back" runat="server" Style="position: static" Text="Back" CssClass="button" OnClick="But_Back_Click" /></td>
        </tr>
    </table>
</asp:Content>

