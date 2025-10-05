<%@ Page Language="C#" MasterPageFile="~/cool cab services/QulityAssranceManger/MasterPage.master" AutoEventWireup="true" CodeFile="AccidentDetails.aspx.cs" Inherits="FinancialHomePage_AccidentDetails" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<script language="javascript" type="text/javascript">
  function check()
   {
     var DDLVehicleID=document.getElementById("<%=DDLVehicleID.ClientID%>").selectedIndex;
            if(DDLVehicleID==0)
            {
                alert('VehicleID Required');
                return false;
            }
             var DDLdriverID=document.getElementById("<%=DDLdriverID.ClientID%>").selectedIndex;
            if(DDLdriverID==0)
            {
                alert('DriverID Required');
                return false;
            }
             var TxtDate=document.getElementById("<%=TxtDate.ClientID%>").value; 
            if(TxtDate=="")
            {
                alert("Date Required");
                document.getElementById("<%=TxtDate.ClientID%>").focus();
                return false;
            }
             var TextBox1=document.getElementById("<%=TextBox1.ClientID%>").value;
            if(TextBox1=="")
            {
                 alert("Time Required");
                 document.getElementById("<%=TextBox1.ClientID%>").focus();
                 return false;
            }
            if(TextBox1!="")
            {
                var name=/^[a-zA-Z0-9: ]+$/;
                if(!TextBox1.match(name))
                {
                        document.getElementById("<%=TextBox1.ClientID%>").focus();
                        alert ("Time Should be 10:30AM");
                        return false;
                }
            }
             var TextBox2=document.getElementById("<%=TextBox2.ClientID%>").value;
            if(TextBox2=="")
            {
                 alert("Remarks Required");
                 document.getElementById("<%=TextBox2.ClientID%>").focus();
                 return false;
            }
            if(TextBox2!="")
            {
                var name=/^[a-zA-Z _.]+$/;
                if(!TextBox2.match(name))
                {
                        document.getElementById("<%=TextBox2.ClientID%>").focus();
                        alert ("Remarks Should be Character");
                        return false;
                }
            }
            
 }
</script>

     <table cellspacing="5" cellpadding="0" align="center" width="700"  class="border1"  >
        <tr>
          <td class="border" colspan="2" align="center"  >
              <b class="title">Add AccidentDetails</b></td>
        </tr>
        <tr>
            <td align="right" ><font color="red">*</font><span><b>VehicleID :</b></span>
            </td>
            <td >
                <asp:DropDownList ID="DDLVehicleID" runat="server" AppendDataBoundItems="True" Style="position: static"
                    Width="153px">
                    <asp:ListItem>Select...</asp:ListItem>
                </asp:DropDownList></td>
        </tr>
        <tr>
            <td align="right" ><font color="red">*</font><span><b>DriverID :</b></span>
            </td>
            <td >
                <asp:DropDownList ID="DDLdriverID" runat="server" AppendDataBoundItems="True" Style="position: static"
                    Width="152px">
                    <asp:ListItem>Select....</asp:ListItem>
                </asp:DropDownList></td>
        </tr>
        <tr>
            <td align="right" ><font color="red">*</font><span><b>Date :</b></span>
            </td>
             <td align="left">
                            <asp:TextBox ID="TxtDate" runat="server" CssClass="textbox" MaxLength="10" Wrap="False" /><a
                                href="javascript:NewCal('<%=TxtDate.ClientID %>','mmddyyyy')"><img src="../images/cal.gif"
                                    width="16" height="16" border="0" alt="Pick a date" /></a><br /> mm/dd/yyyy 
                            </td>
        </tr>
        <tr>
            <td align="right" ><font color="red">*</font><span><b>Time :</b></span>
            </td>
            <td >
                <asp:TextBox ID="TextBox1" runat="server" Style="position: static"></asp:TextBox></td>
        </tr>
        <tr>
            <td align="right" ><font color="red">*</font><span><b>Remarks :</b></span>
            </td>
            <td >
                <asp:TextBox ID="TextBox2" runat="server" Style="position: static"></asp:TextBox></td>
        </tr>
         <tr>
             <td align="right">
             </td>
             <td>
                 <asp:Button ID="Submit" runat="server" Style="position: static" Text="Submit"  CssClass="button" OnClick="Submit_Click" OnClientClick="javascript:return check();" />
                 <asp:Button ID="Clear" runat="server" Style="position: static" Text="clear" CssClass="button" OnClick="Clear_Click"/></td>
         </tr>
    </table>
</asp:Content>

