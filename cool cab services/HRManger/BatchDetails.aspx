<%@ Page Language="C#" MasterPageFile="~/cool cab services/HRManger/HRMasterPage.master" AutoEventWireup="true"
    CodeFile="BatchDetails.aspx.cs" Inherits="HRManger_BatchDetails" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <script language="javascript" type="text/javascript">
  function check()
   {
     var Txt_TNoOFEmployee=document.getElementById("<%=Txt_TNoOFEmployee.ClientID%>").value;
            if(Txt_TNoOFEmployee=="")
            {
               
                alert('Total No O FEmployee Required');
                document.getElementById("<%=Txt_TNoOFEmployee.ClientID%>").focus();
                return false;
            }
            else if(Txt_TNoOFEmployee!="")
            {
                var Exp=/^[0-9]+$/;
                if(!Txt_TNoOFEmployee.match(Exp))
                {
                    alert('Total No O FEmployee Digits Only');
                    document.getElementById("<%=Txt_TNoOFEmployee.ClientID%>").focus();
                    return false;
                }
            }
            var DDL_ShiftID=document.getElementById("<%=DDL_ShiftID.ClientID%>").selectedIndex;
            if(DDL_ShiftID==0)
            {
                alert(' ShiftID Required');
                return false;
            }
 }
    </script>
    
    <table cellspacing="5" cellpadding="0" align="center" width="700" class="border1">
        <tr>
            <td class="border" colspan="2" align="center">
                <b class="title">BatchDetails</b></td>
        </tr>
        <tr>
            <td align="right">
                Total No Of Employee</td>
            <td>
                <asp:TextBox ID="Txt_TNoOFEmployee" runat="server"></asp:TextBox>&nbsp;
            </td>
        </tr>
        <tr>
            <td align="right">
                Shift ID</td>
            <td>
                <asp:DropDownList ID="DDL_ShiftID" runat="server" Style="position: static" AppendDataBoundItems="True">
                    <asp:ListItem>Select....</asp:ListItem>
                </asp:DropDownList>&nbsp;
            </td>
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
                <asp:Button ID="Btn_Submit" runat="server" Style="position: static" CssClass="button"
                    OnClick="Btn_Submit_Click" OnClientClick="javascript:return check();" />
                <asp:Button ID="Button1" runat="server" Style="position: static" Text="Back" CssClass="button"
                    OnClick="Button1_Click" /></td>
        </tr>
    </table>
</asp:Content>
