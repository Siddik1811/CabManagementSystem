<%@ Page Language="C#" MasterPageFile="~/cool cab services/MovementHomePage/MasterPage.master" AutoEventWireup="true" CodeFile="VehicleAllocationDetails.aspx.cs" Inherits="MovementHomePage_VehicleAllocationDetails" Title="Untitled Page" %>
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
           
         
             var DDL_EmployeeID=document.getElementById("<%=DDL_EmployeeID.ClientID%>").selectedIndex;
            if(DDL_EmployeeID==0)
            {
                alert('EmployeeID Required');
                return false;
            }
             var DDLdriverID=document.getElementById("<%=DDLdriverID.ClientID%>").selectedIndex;
            if(DDLdriverID==0)
            {
                alert('DriverID Required');
                return false;
            }
   
          
              var DDLSeach=document.getElementById("<%=DDLSeach.ClientID%>").selectedIndex;
            if(DDLSeach==0)
            {
                alert('RouteID Required');
                return false;
            }
              var TxtDate=document.getElementById("<%=TxtDate.ClientID%>").value; 
            if(TxtDate=="")
            {
                alert("TxtDate Required");
                document.getElementById("<%=TxtDate.ClientID%>").focus();
                return false;
            }
   
            
 }
</script>

    <table cellspacing="5" cellpadding="0" align="center" width="700"  class="border1"  >
        <tr>
          <td class="border" colspan="2" align="center"  >
              <b class="title">Vehicle Allocation Details</b></td>
        </tr>
        <tr>
            <td align="right" ><font color="red" width="50%">*</font><span><b>VehicleID :</b></span>
            </td>
            <td >
                <asp:DropDownList ID="DDLVehicleID" runat="server" Style="position: static" Width="140px" AppendDataBoundItems="True">
                    <asp:ListItem>Select..</asp:ListItem>
                </asp:DropDownList></td>
        </tr>
        <tr>
            <td align="right" ><font color="red">*</font><span><b>EmployeeID :</b></span>
            </td>
            <td >
                <asp:DropDownList ID="DDL_EmployeeID" runat="server" Style="position: static" Width="138px" AppendDataBoundItems="True">
                    <asp:ListItem>Select...</asp:ListItem>
                </asp:DropDownList></td>
        </tr>
        <tr>
            <td align="right" ><font color="red">*</font><span><b>DriverID :</b></span>
            </td>
            <td >
                <asp:DropDownList ID="DDLdriverID" runat="server" Style="position: static" Width="137px" AppendDataBoundItems="True">
                    <asp:ListItem>Select....</asp:ListItem>
                </asp:DropDownList></td>
        </tr>
        <tr>
            <td align="right" ><font color="red">*</font><span><b>PickupDrop :</b></span>
            </td>
            <td >
                <asp:RadioButtonList ID="RadioButtonList1" runat="server" RepeatDirection="Horizontal"
                    Style="position: static" Width="143px">
                    <asp:ListItem Selected="True">Pickup</asp:ListItem>
                    <asp:ListItem>Drop</asp:ListItem>
                </asp:RadioButtonList></td>
        </tr>
        <tr>
            <td  align="right" ><font color="red">*</font><span><b>RouteID :</b></span>
            </td>
            <td  ><asp:DropDownList ID="DDLSeach" runat="server" Style="position: static" Width="138px" AppendDataBoundItems="True">
                <asp:ListItem>Select....</asp:ListItem>
            </asp:DropDownList></td>
        </tr>
        <tr>
            <td align="right" ><font color="red">*</font><span><b>Date :</b></span>
            </td>
            <td align="left">
                            <asp:TextBox ID="TxtDate" runat="server" CssClass="textbox" MaxLength="10" Wrap="False" /><a
                                href="javascript:NewCal('<%=TxtDate.ClientID %>','mmddyyyy')"><img src="../images/cal.gif"
                                    width="16" height="16" border="0" alt="Pick a date" /></a><br />
                            &nbsp;&nbsp;mm/dd/yyyy
                        </td>
        </tr>
        <tr>
            <td >
            </td>
            <td >
            </td>
        </tr>
        <tr>
            <td  >
            </td>
            <td  >
                <asp:Button ID="Btn_Click" runat="server" Style="position: static" Text="" Width="56px" CssClass="button" OnClick="Btn_Click_Click" OnClientClick="javascript:return check();" />
                <asp:Button ID="Button1" runat="server" Style="position: static" Text="Clear" CssClass="button" OnClick="Button1_Click"/>
                <asp:Button ID="But_Back" runat="server" Style="position: static" Text="Back" CssClass="button" OnClick="But_Back_Click1" /></td>
        </tr>
        <tr>
            <td >
            </td>
            <td >
            </td>
        </tr>
    </table>
</asp:Content>

