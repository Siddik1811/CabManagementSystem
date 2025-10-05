<%@ Page Language="C#" MasterPageFile="~/cool cab services/maintenanceManger/MaintenanceManger.master" AutoEventWireup="true" CodeFile="Vehicledetails.aspx.cs" Inherits="maintenanceManger_Vehicledetails" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<script language="javascript" type="text/javascript">
  function check()
   {
   
   //debugger;
           var TxtName=document.getElementById("<%=TxtName.ClientID%>").value;
            if(TxtName=="")
            {
                 alert("VehicleName Required");
                 document.getElementById("<%=TxtName.ClientID%>").focus();
                 return false;
            }
            if(TxtName!="")
            {
                var name=/^[a-zA-Z _.]+$/;
                if(!TxtName.match(name))
                {
                        document.getElementById("<%=TxtName.ClientID%>").focus();
                        alert ("VehicleName Should be Character");
                        return false;
                }
            }
             var DDLVendor=document.getElementById("<%=DDLVendor.ClientID%>").selectedIndex;
            if(DDLVendor==0)
            {
                alert('Vendor Required');
                return false;
            }
             var DDLdriverID=document.getElementById("<%=DDLdriverID.ClientID%>").selectedIndex;
            if(DDLdriverID==0)
            {
                alert('DriverID Required');
                return false;
            }
             var TxtVehicle=document.getElementById("<%=TxtVehicle.ClientID%>").value;
            if(TxtVehicle=="")
            {
                 alert("VehicleType Required");
                 document.getElementById("<%=TxtVehicle.ClientID%>").focus();
                 return false;
            }
            if(TxtVehicle!="")
            {
                var name=/^[a-zA-Z _.]+$/;
                if(!TxtVehicle.match(name))
                {
                        document.getElementById("<%=TxtVehicle.ClientID%>").focus();
                        alert ("VehicleType Should be Character");
                        return false;
                }
            }
            var TxtRegister=document.getElementById("<%=TxtRegister.ClientID%>").value;
            if(TxtRegister=="")
            {
               
                alert('Register Required');
                document.getElementById("<%=TxtRegister.ClientID%>").focus();
                return false;
            }
            else if(TxtRegister!="")
            {
                var Exp=/^[0-9 ,.]+$/;
                if(!TxtRegister.match(Exp))
                {
                    alert('Register Digits Only');
                    document.getElementById("<%=TxtRegister.ClientID%>").focus();
                    return false;
                }
            }
            
           
            var TxtRatekm=document.getElementById("<%=TxtRatekm.ClientID%>").value;
            
            if(TxtRatekm=="")
            {
           
               
                alert('Ratekm Required');
                document.getElementById("<%=TxtRatekm.ClientID%>").focus();
                return false;
            }
            if(TxtRatekm!="")
            {
                var Exp=/^[0-9 ,.]+$/;
                if(!TxtRatekm.match(Exp))
                {
                    alert('Ratekm Digits Only');
                    document.getElementById("<%=TxtRatekm.ClientID%>").focus();
                    return false;
                }
            }
            
              var TxtCapacity=document.getElementById("<%=TxtCapacity.ClientID%>").value;
            if(TxtCapacity=="")
            {
               
                alert('Capacity Required');
                document.getElementById("<%=TxtCapacity.ClientID%>").focus();
                return false;
            }
            else if(TxtCapacity!="")
            {
                var Exp=/^[0-9.]+$/;
                if(!TxtCapacity.match(Exp))
                {
                    alert('Capacity Digits Only');
                    document.getElementById("<%=TxtCapacity.ClientID%>").focus();
                    return false;
                }
            }
               var DDLRouteID=document.getElementById("<%=DDLRouteID.ClientID%>").selectedIndex;
            if(DDLRouteID==0)
            {
                alert('RouteID Required');
                return false;
           }
  }
</script>

     <table cellspacing="5" cellpadding="0" align="center" width="700"  class="border1"  >
        <tr>
          <td class="border" colspan="2" align="center"  >
              <b class="title">VehicleDetails</b></td>
        </tr>
        <tr>
            <td align="right" width="50%">
                VehicleName</td>
            <td>
                <asp:TextBox ID="TxtName" runat="server" Style="position: static"></asp:TextBox></td>
        </tr>
        <tr>
            <td  width="50%" align="right">
                Vendor ID&nbsp; :</td>
            <td >
                <asp:DropDownList ID="DDLVendor" runat="server" Style="position: static" Width="154px" AppendDataBoundItems="True">
                    <asp:ListItem>Select..</asp:ListItem>
                </asp:DropDownList></td>
        </tr>
        <tr>
            <td align="right" >
                Driver ID :</td>
            <td >
                <asp:DropDownList ID="DDLdriverID" runat="server" Style="position: static" Width="153px" AppendDataBoundItems="True">
                    <asp:ListItem>Select..</asp:ListItem>
                </asp:DropDownList></td>
        </tr>
        <tr>
            <td align="right" >
                Vehicle Type :</td>
            <td >
                <asp:TextBox ID="TxtVehicle" runat="server" Style="position: static"></asp:TextBox></td>
        </tr>
        <tr>
            <td align="right" >
                Register No :</td>
            <td >
                <asp:TextBox ID="TxtRegister" runat="server" Style="position: static"></asp:TextBox></td>
        </tr>
        <tr>
            <td align="right" style="height: 24px" >
                Rate/KM :</td>
            <td style="height: 24px" >
                <asp:TextBox ID="TxtRatekm" runat="server" Style="position: static"></asp:TextBox></td>
        </tr>
        <tr>
            <td align="right" >
                Capacity :</td>
            <td >
                <asp:TextBox ID="TxtCapacity" runat="server" Style="position: static"></asp:TextBox></td>
        </tr>
        <tr>
            <td align="right" >
                Route ID :</td>
            <td >
                <asp:DropDownList ID="DDLRouteID" runat="server" Style="position: static" Width="156px" AppendDataBoundItems="True">
                    <asp:ListItem>Select..</asp:ListItem>
                </asp:DropDownList></td>
        </tr>
        <tr>
            <td >
            </td>
            <td >
                <asp:Button ID="Button1" runat="server" Style="position: static" CssClass="button" OnClick="Button1_Click" OnClientClick="javascript:return check();" />
                <asp:Button ID="Button2" runat="server" Style="position: static" Text="Clear" CssClass="button" OnClick="Button2_Click"/>
                <asp:Button ID="But_Back" runat="server" Style="position: static" Text="Back" CssClass="button" OnClick="Button3_Click"/></td>
        </tr>
        <tr>
            <td >
            </td>
            <td >
            </td>
        </tr>
    </table>
</asp:Content>

