<%@ Page Language="C#" MasterPageFile="~/cool cab services/MovementHomePage/MasterPage.master" AutoEventWireup="true" CodeFile="TripSheet.aspx.cs" Inherits="MovementHomePage_TripSheet" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <script language="javascript" type="text/javascript">
  function check()
   {
     var DDLAllocatioID=document.getElementById("<%=DDLAllocatioID.ClientID%>").selectedIndex;
            if(DDLAllocatioID==0)
            {
                alert('AllocatioID Required');
                return false;
            }
        //  DDLVehicleID
         var DDLVehicleID=document.getElementById("<%=DDLVehicleID.ClientID%>").selectedIndex;
            if(DDLVehicleID==0)
            {
                alert('VehicleID Required');
                return false;
            }
             var TxtReatekm=document.getElementById("<%=TxtReatekm.ClientID%>").value;
            if(TxtReatekm=="")
            {
               
                alert('Reatekm Required');
                document.getElementById("<%=TxtReatekm.ClientID%>").focus();
                return false;
            }
            else if(TxtReatekm!="")
            {
                var Exp=/^[0-9 ,.]+$/;
                if(!TxtReatekm.match(Exp))
                {
                    alert('Reatekm Digits Only');
                    document.getElementById("<%=TxtReatekm.ClientID%>").focus();
                    return false;
                }
            }
             var Txtkm=document.getElementById("<%=Txtkm.ClientID%>").value;
            if(Txtkm=="")
            {
               
                alert('km Required');
                document.getElementById("<%=Txtkm.ClientID%>").focus();
                return false;
            }
            else if(Txtkm!="")
            {
                var Exp=/^[0-9 ,.]+$/;
                if(!Txtkm.match(Exp))
                {
                    alert('km Digits Only');
                    document.getElementById("<%=Txtkm.ClientID%>").focus();
                    return false;
                }
            }
            
              var TxtRemark=document.getElementById("<%=TxtRemark.ClientID%>").value;
            if(TxtRemark=="")
            {
                   document.getElementById("<%=TxtRemark.ClientID%>").focus();
                   alert("Remark  Required");
                   return false;
            }
            if(TxtRemark!="")
            {
                var LastName=/^[a-zA-Z _.]+$/;
                if(!TxtRemark.match(LastName))
                {
                   alert ("Remark  Should be Characters");
                   document.getElementById("<%=TxtRemark.ClientID%>").focus();
                   return false;
                }
            }
            
            
 }
    </script>

    <script type="text/javascript">
function m()
{
    
    var y=document.getElementById("<%=TxtReatekm.ClientID %>").value;
    var x=document.getElementById("<%=Txtkm.ClientID %>").value;
    if(y!="" && x!="")
    {
        var Z=Number(y)*Number(x);
        //alert(Z);
        document.getElementById("<%=Txttotalamout.ClientID%>").value=Z;
    }
    else
    {
        alert('Values Required!');
    }
    
}
    </script>

  
    <table cellspacing="5" cellpadding="0" align="center" width="700" class="border1">
        <tr>
            <td class="border" colspan="2" align="center">
                <b class="title">TripSheet</b></td>
        </tr>
        <tr>
            <td align="right" width="50%">
                <font color="red">*</font><span><b>AllocationID :</b></span>
            </td>
            <td>
                <asp:DropDownList ID="DDLAllocatioID" runat="server" Width="152px" AppendDataBoundItems="True">
                    <asp:ListItem>Select...</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td align="right">
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
                <font color="red">*</font><span><b>Rate/Km :</b></span>
            </td>
            <td>
                <asp:TextBox ID="TxtReatekm" runat="server" Style="position: static"></asp:TextBox></td>
        </tr>
        <tr>
            <td align="right">
                <font color="red">*</font><span><b>KM :</b></span>
            </td>
            <td>
                <asp:TextBox ID="Txtkm" runat="server" Style="position: static" onblur="return m(this);"></asp:TextBox></td>
        </tr>
        <tr>
            <td align="right">
                <font color="red">*</font><span><b>TotalAmount :</b></span>
            </td>
            <td>
                <input id="Txttotalamout" type="text" runat="server" readonly="readOnly" /></td>
        </tr>
        <tr>
            <td align="right">
                <font color="red">*</font><span><b>Remark :</b></span>
            </td>
            <td>
                <asp:TextBox ID="TxtRemark" runat="server" Style="position: static"></asp:TextBox></td>
        </tr>
        <tr>
            <td align="right">
            </td>
            <td>
            </td>
        </tr>
        <tr>
            <td>
            </td>
            <td>
                <asp:Button ID="Btn_Click" runat="server" Style="position: static" Text="" CssClass="button"
                    OnClientClick="javascript:return check();" OnClick="Btn_Click_Click" />
                <asp:Button ID="Clear" runat="server" Style="position: static" Text="Clear" CssClass="button"
                    OnClick="Clear_Click1" />
                <asp:Button ID="But_Back" runat="server" Style="position: static" Text="Back" CssClass="button"
                    OnClick="But_Back_Click" /></td>
        </tr>
    </table>
</asp:Content>
