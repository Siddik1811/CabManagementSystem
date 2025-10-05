<%@ Page Language="C#" MasterPageFile="~/cool cab services/HRManger/HRMasterPage.master" AutoEventWireup="true" CodeFile="ViewEmployee.aspx.cs" Inherits="HRManger_ViewEmployee" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<script language="javascript" type="text/javascript">
function f()
{
window.print();
}
    </script>
   

    <table align="center" cellpadding="0" cellspacing="5" class="border1" style="position: static"
        width="700">
        <tr>
            <td align="center" class="border" colspan="3">
                <b class="title">EmployeeDetails</b></td>
           
            
        </tr>
        <tr>
            <td align="right" >
            </td>
            <td >
            </td>
            <td width="30%">
            </td>
        </tr>
        <tr>
            <td align="right"  width="50%">
                <font color="red">*</font><span><b>EmpName :</b></span>
            </td>
            <td>
                <asp:Label ID="Lbl_EmpName" runat="server" Text="Label"></asp:Label>
                </td>
            <td rowspan="6">
                <asp:Image ID="Image1" runat="server" Height="100px" Style="position: static" Width="130px" /></td>
        </tr>
        <tr>
            <td align="right" >
                <font color="red">*</font><span><b>PermanentAddress</b></span> :</td>
            <td>
                <asp:Label ID="Lbl_PAddress" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td align="right" >
                <font color="red">*</font><span><b>CommunicationAddress</b></span> :</td>
            <td>
                <asp:Label ID="Lbl_CAddress" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td align="right" >
                <font color="red">*</font><span><b>Qulification</b></span> :</td>
            <td>
                <asp:Label ID="Lbl_Qulification" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td align="right" >
                <font color="red">*</font><span><b>DOB</b></span> :</td>
            <td align="left">
              <asp:Label ID="Lbl_DOB" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td align="right" >
                <font color="red">*</font><span><b>Vehicle Require</b></span> :</td>
            <td>
                <asp:Label ID="Lbl_VehicleReq" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td align="right" >
                <font color="red">*</font><span><b>Gender</b></span> :</td>
            <td>
                <asp:Label ID="Lbl_Gender" runat="server" Text="Label"></asp:Label></td>
            <td>
            </td>
        </tr>
        <tr>
            <td align="right" >
                <font color="red">*</font> <span><b>Phone NO</b></span> :</td>
            <td>
                <asp:Label ID="Lbl_PhoneNo" runat="server" Text="Label"></asp:Label>
            </td>
            <td>
            </td>
        </tr>
        <tr>
            <td align="right" >
                <font color="red">*</font><span><b>Designation</b></span> :</td>
            <td>
                <asp:Label ID="Lbl_Designation" runat="server" Text="Label"></asp:Label>
            </td>
            <td>
            </td>
        </tr>
        <tr>
            <td align="right" >
                <font color="red">*</font><span><b>Department</b></span> :</td>
            <td>
                <asp:Label ID="Lbl_Department" runat="server" Text="Label"></asp:Label>
            </td>
            <td>
            </td>
        </tr>
        <tr>
            <td align="right" >
                <font color="red">*</font><span><b>DOJ</b></span> :</td>
            <td align="left">
                <asp:Label ID="Lbl_DOj" runat="server" Text="Label"></asp:Label>
            </td>
            <td align="left">
            </td>
        </tr>
        <tr>
            <td align="right" >
                <font color="red">*</font><span><b>Status</b></span> :</td>
            <td>
                <asp:Label ID="Lbl_Status" runat="server" Text="Label"></asp:Label>
            </td>
            <td>
            </td>
        </tr>
        <tr>
            <td align="right" >
                <font color="red">*</font><span><b>Age</b></span> :</td>
            <td>
                <asp:Label ID="Lbl_Age" runat="server" Text="Label"></asp:Label>
            </td>
            <td>
            </td>
        </tr>
        <tr>
            <td align="right" >
                <font color="red">*</font><span><b>TimeSpan</b></span> :</td>
            <td>
                <asp:Label ID="Lbl_Timespan" runat="server" Text="Label"></asp:Label>
            </td>
            <td>
            </td>
        </tr>
        <tr>
            <td align="right" >
                </td>
            <td>
                </td>
            <td>
            </td>
        </tr>
        <tr>
            <td >
            </td>
            <td>
               <asp:Button ID="Btn_Back" runat="server" Style="position: static" Text="Back" CssClass="button" OnClick="Button1_Click" />&nbsp;
                
                <asp:Button ID="Button1" runat="server" Text="Print" OnClientClick="return f();"  class="button" />
                </td><%--onclick="window.open('PrintEmployeeDetails.aspx')"--%>
            <td>
            </td>
        </tr>
    </table>
</asp:Content>

