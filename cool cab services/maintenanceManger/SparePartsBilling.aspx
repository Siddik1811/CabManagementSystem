<%@ Page Language="C#" MasterPageFile="~/cool cab services/maintenanceManger/MaintenanceManger.master"
    AutoEventWireup="true" CodeFile="SparePartsBilling.aspx.cs" Inherits="maintenanceManger_SparePartsBilling"
    Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
<script language="javascript" type="text/javascript">
  function check()
   {
    var DDLVehicleID=document.getElementById("<%=DDLVehicleID.ClientID%>").selectedIndex;
            if(DDLVehicleID==0)
            {
                alert('VehicleID Required');
                return false;
            }
            //DDLSpareType
              var DDLSpareType=document.getElementById("<%=DDLSpareType.ClientID%>").selectedIndex;
            if(DDLSpareType==0)
            {
                alert('SpareType Required');
                return false;
            }
             var TxtQuantity=document.getElementById("<%=TxtQuantity.ClientID%>").value;
            if(TxtQuantity=="")
            {
               
                alert('Quantity Required');
                document.getElementById("<%=TxtQuantity.ClientID%>").focus();
                return false;
            }
            else if(TxtQuantity!="")
            {
                var Exp=/^[0-9 ,.]+$/;
                if(!TxtQuantity.match(Exp))
                {
                    alert('Quantity Digits Only');
                    document.getElementById("<%=TxtQuantity.ClientID%>").focus();
                    return false;
                }
            }
            
             var TxtBillDate=document.getElementById("<%=TxtBillDate.ClientID%>").value; 
            if(TxtBillDate=="")
            {
                alert("BillDate Required");
                document.getElementById("<%=TxtBillDate.ClientID%>").focus();
                return false;
            }
            //DDLSparePart
               var DDLSparePart=document.getElementById("<%=DDLSparePart.ClientID%>").selectedIndex;
            if(DDLSparePart==0)
            {
                alert('SparePart Required');
                return false;
            }
            //TxtPrice
              var TxtPrice=document.getElementById("<%=TxtPrice.ClientID%>").value;
            if(TxtPrice=="")
            {
               
                alert('Price Required');
                document.getElementById("<%=TxtPrice.ClientID%>").focus();
                return false;
            }
            else if(TxtPrice!="")
            {
                var Exp=/^[0-9.]+$/;
                if(!TxtPrice.match(Exp))
                {
                    alert('Price Digits Only');
                    document.getElementById("<%=TxtPrice.ClientID%>").focus();
                    return false;
                }
            }
            //TxtTotalAmount
                var TxtTotalAmount=document.getElementById("<%=TxtTotalAmount.ClientID%>").value;
            if(TxtTotalAmount=="")
            {
               
                alert('TotalAmount Required');
                document.getElementById("<%=TxtTotalAmount.ClientID%>").focus();
                return false;
            }
            else if(TxtTotalAmount!="")
            {
                var Exp=/^[0-9.]+$/;
                if(!TxtTotalAmount.match(Exp))
                {
                    alert('TotalAmount Digits Only');
                    document.getElementById("<%=TxtTotalAmount.ClientID%>").focus();
                    return false;
                }
            }
            
 }
</script>


     <script type="text/javascript" language="javascript">
function m()
{
   // alert('swathi');
    var y=document.getElementById("<%=TxtQuantity.ClientID %>").value;
    var x=document.getElementById("<%=TxtPrice.ClientID %>").value;
    if(y!="" && x!="")
    {
        var Z=Number(y)*Number(x);
      
        document.getElementById("<%=TxtTotalAmount.ClientID%>").value=Z;
    }
    else
    {
        alert('Values Required!');
    }
    }
     </script>
   
                <table cellspacing="5" cellpadding="0" align="center" width="700" class="border1"
                    onclick="return TABLE1_onclick()">
                    <tr>
                        <td class="border" colspan="2" align="center">
                            <b class="title">SpareParts Billing</b></td>
                    </tr>
                    <tr>
                        <td align="right" width="50%">
                            <font color="red">*</font><span><b>VehicleID :</b></span>
                        </td>
                        <td>
                            <asp:DropDownList ID="DDLVehicleID" runat="server" Width="153px" AppendDataBoundItems="True">
                                <asp:ListItem>Select...</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td align="right">
                            <font color="red">*</font><span><b>SpareType :</b></span>
                        </td>
                        <td>
                            <asp:DropDownList ID="DDLSpareType" runat="server" Width="152px" AppendDataBoundItems="True" AutoPostBack="True" OnSelectedIndexChanged="DDLSpareType_SelectedIndexChanged">
                                <asp:ListItem>Select...</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td align="right">
                            <font color="red">*</font><span><b>Quantity :</b></span>
                        </td>
                        <td>
                            <asp:TextBox ID="TxtQuantity" runat="server" Width="145px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="right">
                            <font color="red">*</font><span><b>BillDate :</b></span>
                        </td>
                        <td align="left">
                            <asp:TextBox ID="TxtBillDate" runat="server" CssClass="textbox" MaxLength="10" Wrap="False" /><a
                                href="javascript:NewCal('<%=TxtBillDate.ClientID %>','mmddyyyy')"><img src="../images/cal.gif"
                                    width="16" height="16" border="0" alt="Pick a date" /></a><br />
                            &nbsp;&nbsp;mm/dd/yyyy
                        </td>
                    </tr>
                    <tr>
                        <td align="right">
                            <font color="red">*</font><span><b>SparePart :</b></span>
                        </td>
                        <td>
                            <asp:DropDownList ID="DDLSparePart" runat="server" Width="154px" AppendDataBoundItems="True">
                                <asp:ListItem>Select....</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td align="right" >
                            <font color="red">*</font><span><b>Price :</b></span>
                        </td>
                        <td >
                            <input id="TxtPrice" type="text" runat="server" onblur="return m(this);"  />
                           <%-- <asp:TextBox ID="TxtPrice" runat="server" Width="148px"></asp:TextBox>--%>
                        </td>
                    </tr>
                    <tr>
                        <td align="right">
                            <font color="red">*</font><span><b>TotalAmount :</b></span>
                        </td>
                        <td>
                            <asp:TextBox ID="TxtTotalAmount" runat="server" Width="147px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td style="height: 13px">
                        </td>
                        <td style="height: 13px">
                            <asp:Button ID="Button1" runat="server" Style="position: static" CssClass="button" OnClientClick="javascript:return check();" 
                                OnClick="Button1_Click" />
                            <asp:Button ID="Button2" runat="server" Style="position: static" Text="Clear" CssClass="button"
                                OnClick="Button2_Click" />
                            <asp:Button ID="Back" runat="server" Style="position: static" Text="Back" CssClass="button" OnClick="Back_Click" /></td>
                    </tr>
                </table>
      
</asp:Content>
