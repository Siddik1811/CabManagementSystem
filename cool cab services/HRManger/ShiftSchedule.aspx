<%@ Page Language="C#" MasterPageFile="~/cool cab services/HRManger/HRMasterPage.master" AutoEventWireup="true" CodeFile="ShiftSchedule.aspx.cs" Inherits="HRManger_ShiftSchedule" Title="Untitled Page" %>
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
          
            
            var DDL_BatchID=document.getElementById("<%=DDL_BatchID.ClientID%>").selectedIndex;
            if(DDL_BatchID==0)
            {
                alert('BatchID Required');
                return false;
            }
            
         
            //DDL_ShiftID
               
            var DDL_ShiftID=document.getElementById("<%=DDL_ShiftID.ClientID%>").selectedIndex;
            if(DDL_ShiftID==0)
            {
                alert('ShiftID Required');
                return false;
            }
              var DDLSeach=document.getElementById("<%=DDLSeach.ClientID%>").selectedIndex;
            if(DDLSeach==0)
            {
                alert('RouteID Required');
                return false;
            }
            
}
</script>
   <table cellspacing="5" cellpadding="0" align="center" width="700"  class="border1"  >
       <tr>
          <td class="border" colspan="2" align="center"  >
              <b class="title">Shift Schedule</b></td>
        </tr>
        <tr>
            <td align="right" width="50%" ><font color="red">*</font><span><b>Employee ID :</b></span>
            </td>
            <td >
                <asp:DropDownList ID="DDL_EmployeeID" runat="server" AppendDataBoundItems="True" Width="127px" AutoPostBack="True" OnSelectedIndexChanged="DDL_EmployeeID_SelectedIndexChanged">
                    <asp:ListItem>Select...</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td align="right" ><font color="red">*</font><span><b>Department :</b></span>
            </td>
            <td >
                <asp:TextBox ID="Txt_Department" runat="server" Width="120px" ReadOnly="True"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="right" ><font color="red">*</font><span><b>Batch ID :</b></span>
            </td>
            <td >
                <asp:DropDownList ID="DDL_BatchID" runat="server" AppendDataBoundItems="True" Width="127px">
                    <asp:ListItem>Selet...</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td align="right" ><font color="red">*</font><span><b>EmpName :</b></span>
            </td>
            <td >
                <asp:TextBox ID="Txt_EmpName" runat="server" Width="120px" ReadOnly="True"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="right" ><font color="red">*</font><span><b>ShiftID :</b></span>
            </td>
            <td >
                <asp:DropDownList ID="DDL_ShiftID" runat="server" AppendDataBoundItems="True" Width="127px">
                    <asp:ListItem>Select...</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td align="right" ><font color="red">*</font><span><b>Route ID :</b></span>
            </td>
            <td >
                <asp:DropDownList ID="DDLSeach" runat="server" AppendDataBoundItems="True" Width="127px">
                    <asp:ListItem>Select...</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td >
            </td>
            <td >
                <asp:Button ID="Btn_Insert" runat="server" Style="position: static"  CssClass="button" OnClick="Button1_Click" OnClientClick="javascript:return check();" />
                <asp:Button ID="Button2" runat="server" Style="position: static" Text="Clear" CssClass="button" OnClick="Button2_Click" />
                <asp:Button ID="But_Back" runat="server" Style="position: static" Text="Back" CssClass="button" OnClick="But_Back_Click" /></td>
        </tr>
    </table>
</asp:Content>

