<%@ Page Language="C#" MasterPageFile="~/cool cab services/HRManger/HRMasterPage.master" AutoEventWireup="true"
    CodeFile="AddEmployeeDetails.aspx.cs" Inherits="HRManger_AddEmployeeDetails"
    Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <script language="javascript" type="text/javascript">
function check()
   {
  
           var Txt_EmpName=document.getElementById("<%=Txt_EmpName.ClientID%>").value;
            if(Txt_EmpName=="")
            {
                 alert("EmpName Required");
                 document.getElementById("<%=Txt_EmpName.ClientID%>").focus();
                 return false;
            }
            if(Txt_EmpName!="")
            {
                var name=/^[a-zA-Z _.]+$/;
                if(!Txt_EmpName.match(name))
                {
                        document.getElementById("<%=Txt_EmpName.ClientID%>").focus();
                        alert ("EmpName Should be Character");
                        return false;
                }
            }
          var Txt_ParmanentAddress=document.getElementById("<%=Txt_ParmanentAddress.ClientID%>").value;
            if(Txt_ParmanentAddress=="")
            {
               
                alert('ParmanentAddress  Required');
                document.getElementById("<%=Txt_ParmanentAddress.ClientID%>").focus();
                return false;
            }
            var Txt_CommAddress=document.getElementById("<%=Txt_CommAddress.ClientID%>").value;
            if(Txt_CommAddress=="")
            {
               
                alert('Communication Address Required');
                document.getElementById("<%=Txt_CommAddress.ClientID%>").focus();
                return false;
            }
           var Txt_Qulification=document.getElementById("<%=Txt_Qulification.ClientID%>").value;
            if(Txt_Qulification=="")
            {
                 alert("Qulification Required");
                 document.getElementById("<%=Txt_Qulification.ClientID%>").focus();
                 return false;
            }
            if(Txt_Qulification!="")
            {
                var name=/^[a-zA-Z _.]+$/;
                if(!Txt_Qulification.match(name))
                {
                        document.getElementById("<%=Txt_Qulification.ClientID%>").focus();
                        alert ("Qulification Should be Character");
                        return false;
                }
            }
            
             var Txt_DOB=document.getElementById("<%=Txt_DOB.ClientID%>").value; 
            if(Txt_DOB=="")
            {
                alert("Date of Birth Required");
                document.getElementById("<%=Txt_DOB.ClientID%>").focus();
                return false;
            }
            
            var Txt_VehicleRequire=document.getElementById("<%=Txt_VehicleRequire.ClientID%>").value;
            if(Txt_VehicleRequire=="")
            {
                 alert("VehicleRequire Required");
                 document.getElementById("<%=Txt_VehicleRequire.ClientID%>").focus();
                 return false;
            }
            if(Txt_VehicleRequire!="")
            {
                var name=/^[a-zA-Z _.]+$/;
                if(!Txt_VehicleRequire.match(name))
                {
                        document.getElementById("<%=Txt_VehicleRequire.ClientID%>").focus();
                        alert ("VehicleRequire Should be Character");
                        return false;
                }
            }
             var rdo=document.getElementById("<%=RadioButtonList1.ClientID %>");
            var opt=rdo.getElementsByTagName('input');
            if(!opt[0].checked && !opt[1].checked)
            {
               alert("Gender Required");
               return false; 
            }
            
             var Txt_PhoneNo=document.getElementById("<%=Txt_PhoneNo.ClientID%>").value;
          if(Txt_PhoneNo=="")
            {
               
                document.getElementById("<%=Txt_PhoneNo.ClientID%>").focus();
                alert('MobileNo Required');
                return false;
            }
           else if(Txt_PhoneNo!="")
            {
             var Exp=/^[0-9 ()+-]+$/;
              if(!Txt_PhoneNo.match(Exp))
                {
                    alert('MobileNo Digits Only');
                    document.getElementById("<%=Txt_PhoneNo.ClientID%>").focus();
                    return false;
                }
            }
               var Txt_Designation=document.getElementById("<%=Txt_Designation.ClientID%>").value;
            if(Txt_Designation=="")
            {
                 alert("Designation Required");
                 document.getElementById("<%=Txt_Designation.ClientID%>").focus();
                 return false;
            }
            if(Txt_Designation!="")
            {
                var name=/^[a-zA-Z _.]+$/;
                if(!Txt_Designation.match(name))
                {
                        document.getElementById("<%=Txt_Designation.ClientID%>").focus();
                        alert ("Designation Should be Character");
                        return false;
                }
            }
            //Txt_Department
               var Txt_Department=document.getElementById("<%=Txt_Department.ClientID%>").value;
            if(Txt_Department=="")
            {
                 alert("Department Required");
                 document.getElementById("<%=Txt_Department.ClientID%>").focus();
                 return false;
            }
            if(Txt_Department!="")
            {
                var name=/^[a-zA-Z _.]+$/;
                if(!Txt_Department.match(name))
                {
                        document.getElementById("<%=Txt_Department.ClientID%>").focus();
                        alert ("Department Should be Character");
                        return false;
                }
            }
             var Txt_DOJ=document.getElementById("<%=Txt_DOJ.ClientID%>").value; 
            if(Txt_DOJ=="")
            {
                alert("Date of Join Required");
                document.getElementById("<%=Txt_DOJ.ClientID%>").focus();
                return false;
            }
            //Txt_Status
              var Txt_Status=document.getElementById("<%=Txt_Status.ClientID%>").value;
            if(Txt_Status=="")
            {
                 alert("Status Required");
                 document.getElementById("<%=Txt_Status.ClientID%>").focus();
                 return false;
            }
            if(Txt_Status!="")
            {
                var name=/^[a-zA-Z _.]+$/;
                if(!Txt_Status.match(name))
                {
                        document.getElementById("<%=Txt_Status.ClientID%>").focus();
                        alert ("Status Should be Character");
                        return false;
                }
            }
            //Txt_Age
            var Txt_Age=document.getElementById("<%=Txt_Age.ClientID%>").value;
          if(Txt_Age=="")
            {
               
                document.getElementById("<%=Txt_Age.ClientID%>").focus();
                alert('Age Required');
                return false;
            }
           else if(Txt_Age!="")
            {
             var Exp=/^[0-9]+$/;
              if(!Txt_Age.match(Exp))
                {
                    alert('Age Digits Only');
                    document.getElementById("<%=Txt_Age.ClientID%>").focus();
                    return false;
                }
            }
            //
             var Txt_Timespan=document.getElementById("<%=Txt_Timespan.ClientID%>").value;
          if(Txt_Timespan=="")
            {
               
                document.getElementById("<%=Txt_Timespan.ClientID%>").focus();
                alert('Timespan Required');
                return false;
            }
           else if(Txt_Timespan!="")
            {
             var Exp=/^[0-9a-zA-Z ]+$/;
              if(!Txt_Timespan.match(Exp))
                {
                    alert('Timespan Should Digits  Or Charecters');
                    document.getElementById("<%=Txt_Timespan.ClientID%>").focus();
                    return false;
                }
            }
            
     }       
            
    </script>

  
    <table cellspacing="5" cellpadding="0" align="center" width="700" class="border1">
        <tr>
            <td class="border" colspan="3" align="center">
                <b class="title">EmployeeDetails</b></td>
        </tr>
        <tr>
            <td width="50%" align="right">
                <font color="red">*</font><span><b>EmpName :</b></span></td>
            <td colspan="2">
                <asp:TextBox ID="Txt_EmpName" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="right">
                <font color="red">*</font><span><b>PermanentAddress</b></span>&nbsp; :</td>
            <td colspan="2">
                <asp:TextBox ID="Txt_ParmanentAddress" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="right">
                <font color="red">*</font><span><b>CommunicationAddress</b></span>&nbsp; :</td>
            <td colspan="2">
                <asp:TextBox ID="Txt_CommAddress" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="right">
                <font color="red">*</font><span><b>Qulification</b></span>&nbsp; :</td>
            <td colspan="2">
                <asp:TextBox ID="Txt_Qulification" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="right">
                <font color="red">*</font><span><b>DOB</b></span>:</td>
            <td align="left" colspan="2">
                <input id="Txt_DOB" type="text" runat="server"  readonly="readOnly"/>
                <%--<asp:TextBox ID="Txt_DOB" runat="server" CssClass="textbox" MaxLength="10" Wrap="False" />--%><a
                    href="javascript:NewCal('<%=Txt_DOB.ClientID %>','mmddyyyy')"><img src="../images/cal.gif"
                        width="16" height="16" border="0" alt="Pick a date" /></a><br />
                mm/dd/yyyy
            </td>
        </tr>
        <tr>
            <td align="right">
                <font color="red">*</font><span><b>Vehicle Require</b></span>&nbsp; :</td>
            <td colspan="2">
                <asp:TextBox ID="Txt_VehicleRequire" runat="server"></asp:TextBox>
                Yes/No</td>
        </tr>
        <tr>
            <td align="right">
                <font color="red">*</font><span><b>Gender</b></span>&nbsp; :</td>
            <td colspan="2">
                <asp:RadioButtonList ID="RadioButtonList1" runat="server" RepeatDirection="Horizontal"
                    Style="position: static" Width="158px">
                    <asp:ListItem Selected="True">Male</asp:ListItem>
                    <asp:ListItem>Female</asp:ListItem>
                </asp:RadioButtonList></td>
        </tr>
        <tr>
            <td align="right">
                <font color="red">*</font> <span><b>Phone NO</b></span>&nbsp; :</td>
            <td colspan="2">
                <asp:TextBox ID="Txt_PhoneNo" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="right">
                <font color="red">*</font><span><b>Designation</b></span>&nbsp; :</td>
            <td colspan="2">
                <asp:TextBox ID="Txt_Designation" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="right">
                <font color="red">*</font><span><b>Department</b></span>&nbsp; :</td>
            <td colspan="2">
                <asp:TextBox ID="Txt_Department" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="right">
                <font color="red">*</font><span><b>DOJ</b></span>&nbsp; :</td>
            <td align="left">
                <input id="Txt_DOJ" type="text" runat="server"  readonly="readOnly" />
               <%-- <asp:TextBox ID="Txt_DOJ" runat="server" CssClass="textbox" MaxLength="10" Wrap="False" />--%><a
                    href="javascript:NewCal('<%=Txt_DOJ.ClientID %>','mmddyyyy')"><img src="../images/cal.gif"
                        width="16" height="16" border="0" alt="Pick a date" /></a><br />
                &nbsp;&nbsp;mm/dd/yyyy
            </td>
            <td align="left" rowspan="5">
                <asp:Image ID="Image1" runat="server" Height="120px" Style="position: static" Width="120px" /></td>
        </tr>
        <tr>
            <td align="right">
                <font color="red">*</font><span><b>Status</b></span>&nbsp; :</td>
            <td>
                <asp:TextBox ID="Txt_Status" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="right">
                <font color="red">*</font><span><b>Age</b></span>&nbsp; :</td>
            <td>
                <asp:TextBox ID="Txt_Age" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="right">
                <font color="red">*</font><span><b>TimeSpan</b></span>&nbsp; :</td>
            <td>
                <asp:TextBox ID="Txt_Timespan" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="right" style="height: 22px">
                <font color="red"></font><span><b>Select Emp Image</b></span>&nbsp; :</td>
            <td style="height: 22px">
                <asp:FileUpload ID="FUl_UploadImage" runat="server" />
            </td>
        </tr>
        <tr>
            <td align="right" style="height: 22px">
            </td>
            <td style="height: 22px" colspan="2">
                <asp:Label ID="Label1" runat="server" Style="position: static" Text="Label"></asp:Label></td>
        </tr>
        <tr>
            <td>
            </td>
            <td colspan="2">
                <asp:Button ID="Btn_Insert" runat="server" Style="position: static" CssClass="button"
                    OnClick="Button1_Click" OnClientClick="javascript:return check();" />
                <asp:Button ID="Button2" runat="server" Style="position: static" Text="Clear" CssClass="button"
                    OnClick="Button2_Click" />
                <asp:Button ID="But_Back" runat="server" Style="position: static" Text="Back" CssClass="button"
                    OnClick="But_Back_Click" /></td>
        </tr>
    </table>
</asp:Content>
