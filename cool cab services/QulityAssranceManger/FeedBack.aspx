<%@ Page Language="C#" MasterPageFile="~/cool cab services/QulityAssranceManger/MasterPage.master" AutoEventWireup="true" CodeFile="FeedBack.aspx.cs" Inherits="FinancialHomePage_FeedBack" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<script language="javascript" type="text/javascript">
  function check()
   {
       var DDL_EmployeeID=document.getElementById("<%=DDL_EmployeeID.ClientID%>").selectedIndex;
            if(DDL_EmployeeID==0)
            {
                alert('EmployeeID Required');
                return false;
            }
           
         
             var DDLVendor=document.getElementById("<%=DDLVendor.ClientID%>").selectedIndex;
            if(DDLVendor==0)
            {
                alert('Vendor Required');
                return false;
            }
               var DDLVehicleID=document.getElementById("<%=DDLVehicleID.ClientID%>").selectedIndex;
            if(DDLVehicleID==0)
            {
                alert('VehicleID Required');
                return false;
            }
            //TextBox1
             var TextBox1=document.getElementById("<%=TextBox1.ClientID%>").value;
            if(TextBox1=="")
            {
                   document.getElementById("<%=TextBox1.ClientID%>").focus();
                   alert("Remarks Required");
                   return false;
            }
            if(TextBox1!="")
            {
                var LastName=/^[a-zA-Z _.]+$/;
                if(!TextBox1.match(LastName))
                {
                   alert ("Remarks  Should be Characters");
                   document.getElementById("<%=TextBox1.ClientID%>").focus();
                   return false;
                }
            }
            
 }
</script>
<br />
<br />
<br />
     <table cellspacing="5" cellpadding="0" align="center" width="700"  class="border1"  >
        <tr>
          <td class="border" colspan="2" align="center"  >
              <b class="title">Feed Back</b></td>
        </tr>
        <tr>
            <td align="right" width="50%" ><font color="red">*</font><span><b>Employee :</b></span></td>
            <td >
                <asp:DropDownList ID="DDL_EmployeeID" runat="server" AppendDataBoundItems="True"
                    AutoPostBack="True" Width="151px" 
                    >
                    <asp:ListItem>Select...</asp:ListItem>
                </asp:DropDownList></td>
        </tr>
        <tr>
            <td align="right" ><font color="red">*</font><span><b>VendorID :</b></span>
                </td>
            <td >
                <asp:DropDownList ID="DDLVendor" runat="server" AppendDataBoundItems="True" Style="position: static"
                    Width="154px">
                    <asp:ListItem>Select..</asp:ListItem>
                </asp:DropDownList></td>
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
            <td align="right" ><font color="red">*</font><span><b>Remarks :</b></span>
                </td>
            <td >
                <asp:TextBox ID="TextBox1" runat="server" Style="position: static"></asp:TextBox></td>
        </tr>
        <tr>
            <td >
            </td>
            <td >
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Style="position: static"
                    Text="Submit " CssClass="button" OnClientClick="javascript:return check();" />
                <asp:Button ID="Button2" runat="server" Style="position: static" Text="Clear" CssClass="button" OnClick="Button2_Click"/></td>
        </tr>
    </table>
</asp:Content>

