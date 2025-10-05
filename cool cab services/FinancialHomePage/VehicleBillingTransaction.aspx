<%@ Page Language="C#" MasterPageFile="~/cool cab services/FinancialHomePage/MasterPage.master"
    AutoEventWireup="true" CodeFile="VehicleBillingTransaction.aspx.cs" Inherits="FinancialHomePage_VehicleBillingTransaction"
    Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <script type="text/javascript" language="javascript">
function m()
{
    //alert('Values Required!');
    var y=document.getElementById("<%=TxtAmount.ClientID %>").value;
    var x=document.getElementById("<%=TxtDeduction.ClientID %>").value;
    if(y!="" && x!="")
    {
        var Z=Number(y)-Number(x);
        //alert(Z);
        document.getElementById("<%=TxtNet.ClientID%>").value=Z;
    }
    else
    {
        alert('Values Required!');
    }
 }
    </script>

    <script language="javascript" type="text/javascript">
  function check()
   {
          
              var DDLVehicleID=document.getElementById("<%=DDLVehicleID.ClientID%>").selectedIndex;
            if(DDLVehicleID==0)
            {
                alert('VehicleID Required');
                return false;
            }
               var DDLVendor=document.getElementById("<%=DDLVendor.ClientID%>").selectedIndex;
            if(DDLVendor==0)
            {
                alert('Vendor Required');
                return false;
            }
            var TxtDate=document.getElementById("<%=TxtDate.ClientID%>").value; 
            if(TxtDate=="")
            {
                alert("Date Required");
                document.getElementById("<%=TxtDate.ClientID%>").focus();
                return false;
            }
             var TxtDeduction=document.getElementById("<%=TxtDeduction.ClientID%>").value;
          if(TxtDeduction=="")
            {
               
                document.getElementById("<%=TxtDeduction.ClientID%>").focus();
                alert('Deduction Required');
                return false;
            }
           else if(TxtDeduction!="")
            {
             var Exp=/^[0-9 ()+-]+$/;
              if(!TxtDeduction.match(Exp))
                {
                    alert('Deduction Digits Only');
                    document.getElementById("<%=TxtDeduction.ClientID%>").focus();
                    return false;
                }
            }
            //TxtNet
          
            //TxtAmount
               var TxtAmount=document.getElementById("<%=TxtAmount.ClientID%>").value;
          if(TxtAmount=="")
            {
               
                document.getElementById("<%=TxtAmount.ClientID%>").focus();
                alert('Amount Required');
                return false;
            }
           else if(TxtAmount!="")
            {
             var Exp=/^[0-9]+$/;
              if(!TxtAmount.match(Exp))
                {
                    alert('Amount Digits Only');
                    document.getElementById("<%=TxtAmount.ClientID%>").focus();
                    return false;
                }
            }
            //TxtNet
             var TxtNet=document.getElementById("<%=TxtNet.ClientID%>").value;
          if(TxtNet=="")
            {
               
                document.getElementById("<%=TxtNet.ClientID%>").focus();
                alert('NetAmount Required');
                return false;
            }
           else if(TxtNet!="")
            {
             var Exp=/^[0-9.]+$/;
              if(!TxtNet.match(Exp))
                {
                    alert('NetAmount Digits Only');
                    document.getElementById("<%=TxtNet.ClientID%>").focus();
                    return false;
                }
            }
            
}
    </script>

    
    <table cellspacing="5" cellpadding="0" align="center" width="700" class="border1">
        <tr>
            <td class="border" colspan="2" align="center">
                <b class="title">Vehicle BillingTransaction</b></td>
        </tr>
        <tr>
            <td align="right" width="50%">
                <font color="red">*</font><span><b>VehicleID :</b></span>
            </td>
            <td>
                <asp:DropDownList ID="DDLVehicleID" runat="server" AppendDataBoundItems="True" Style="position: static"
                    Width="155px" OnSelectedIndexChanged="DDLVehicleID_SelectedIndexChanged" AutoPostBack="True">
                    <asp:ListItem>Select..</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td align="right">
                <font color="red">*</font><span><b>Amount :</b></span>
            </td>
            <td>
                <asp:TextBox ID="TxtAmount" runat="server" Style="position: static"></asp:TextBox>&nbsp;
            </td>
        </tr>
        <tr>
            <td align="right">
                <font color="red">*</font><span><b>DateOfBilling :</b></span>
            </td>
            <td align="left">
                <asp:TextBox ID="TxtDate" runat="server" CssClass="textbox" MaxLength="10" Wrap="False" /><a
                    href="javascript:NewCal('<%=TxtDate.ClientID %>','mmddyyyy')"><img src="../images/cal.gif"
                        width="16" height="16" border="0" alt="Pick a date" /></a><br />
                mm/dd/yyyy
            </td>
        </tr>
        <tr>
            <td align="right">
                <font color="red">*</font><span><b>VenderID :</b></span>
            </td>
            <td>
                <asp:DropDownList ID="DDLVendor" runat="server" AppendDataBoundItems="True" Style="position: static"
                    Width="156px">
                    <asp:ListItem>Select..</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td align="right">
                <font color="red">*</font><span><b>Deduction :</b></span>
            </td>
            <td>
                <input type="text" id="TxtDeduction" runat="server" onblur="return m(this);" />
            </td>
        </tr>
        <tr>
            <td align="right">
                <font color="red">*</font><span><b>NetAmount :</b></span>
            </td>
            <td>
                <asp:TextBox ID="TxtNet" runat="server" Style="position: static" Width="143px"></asp:TextBox>&nbsp;
            </td>
        </tr>
        <tr>
            <td align="right">
            </td>
            <td>
                <asp:Button ID="Btn_Insert" runat="server" Style="position: static" Text="" CssClass="button"
                    OnClick="Btn_Insert_Click" Width="94px" OnClientClick="javascript:return check();" />
                <asp:Button ID="Button2" runat="server" Style="position: static" Text="Clear" CssClass="button"
                    OnClick="Button2_Click" />
                <asp:Button ID="But_Back" runat="server" Style="position: static" Text="Back" CssClass="button" OnClick="But_Back_Click" /></td>
        </tr>
    </table>
</asp:Content>
