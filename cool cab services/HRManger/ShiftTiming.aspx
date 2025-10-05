<%@ Page Language="C#" MasterPageFile="~/cool cab services/HRManger/HRMasterPage.master" AutoEventWireup="true"
    CodeFile="ShiftTiming.aspx.cs" Inherits="HRManger_ShiftTiming" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <script language="javascript" type="text/javascript">
  function check()
   {
   var TextBox1=document.getElementById("<%=TextBox1.ClientID%>").value;
            if(TextBox1=="")
            {
                 alert("ShiftName Required");
                 document.getElementById("<%=TextBox1.ClientID%>").focus();
                 return false;
            }
            if(TextBox1!="")
            {
                var name=/^[a-zA-Z _.]+$/;
                if(!TextBox1.match(name))
                {
                        document.getElementById("<%=TextBox1.ClientID%>").focus();
                        alert ("ShiftName Should be Character");
                        return false;
                }
            }
            var Txt_startingTime=document.getElementById("<%=Txt_startingTime.ClientID%>").value;
            if(Txt_startingTime=="")
            {
                   document.getElementById("<%=Txt_startingTime.ClientID%>").focus();
                   alert("startingTime Name Required");
                   return false;
            }
            if(Txt_startingTime!="")
            {
                var LastName=/^[a-zA-Z0-9:]+$/;
                if(!Txt_startingTime.match(LastName))
                {
                   alert ("startingTime  Should be Characters");
                   document.getElementById("<%=Txt_startingTime.ClientID%>").focus();
                   return false;
                }
            }
           var Txt_Dispatch=document.getElementById("<%=Txt_Dispatch.ClientID%>").value;
            if(Txt_Dispatch=="")
            {
                   document.getElementById("<%=Txt_Dispatch.ClientID%>").focus();
                   alert("Dispatch Name Required");
                   return false;
            }
            if(Txt_Dispatch!="")
            {
                var LastName=/^[a-zA-Z0-9:]+$/;
                if(!Txt_Dispatch.match(LastName))
                {
                   alert ("Dispatch  Should be Characters");
                   document.getElementById("<%=Txt_Dispatch.ClientID%>").focus();
                   return false;
                }
            }
            //Txt_tnoofbatch
              var Txt_tnoofbatch=document.getElementById("<%=Txt_tnoofbatch.ClientID%>").value;
            if(Txt_tnoofbatch=="")
            {
                   document.getElementById("<%=Txt_tnoofbatch.ClientID%>").focus();
                   alert("Total no Of Batchs Name Required");
                   return false;
            }
            if(Txt_tnoofbatch!="")
            {
                var LastName=/^[0-9]+$/;
                if(!Txt_tnoofbatch.match(LastName))
                {
                   alert ("Total no Of Batchs Should be Digits");
                   document.getElementById("<%=Txt_tnoofbatch.ClientID%>").focus();
                   return false;
                }
            }
   
    }
    </script>

       <table cellspacing="5" cellpadding="0" align="center" width="700" class="border1">
        <tr>
            <td class="border" colspan="2" align="center">
                <b class="title">Shift Timing</b></td>
        </tr>
        <tr>
            <td align="right" width="50%">
                <font color="red">*</font><span><b>ShiftName:</b></span>
            </td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>&nbsp;
            </td>
        </tr>
        <tr>
            <td align="right">
                <font color="red">*</font><span><b>StartIng Time:</b></span>
            </td>
            <td align="left">
                <asp:TextBox ID="Txt_startingTime" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="right">
                <font color="red">*</font><span><b>Dispatch</b></span>
            </td>
            <td>
                <asp:TextBox ID="Txt_Dispatch" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="right">
                <font color="red">*</font><span><b>Total No Of Batches</b></span>
            </td>
            <td>
                <asp:TextBox ID="Txt_tnoofbatch" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
            </td>
            <td>
                <asp:Button ID="Btn_Submit" runat="server" Style="position: static" CssClass="button"
                    OnClick="Btn_Submit_Click" OnClientClick="javascript:return check();" />
                <asp:Button ID="Btn_Clear" runat="server" Style="position: static" Text="Clear" CssClass="button"
                    OnClick="Btn_Clear_Click" />
                <asp:Button ID="Button1" runat="server" Style="position: static" Text="Back" CssClass="button"
                    OnClick="Button1_Click1" /></td>
        </tr>
        <tr>
            <td>
            </td>
            <td>
            </td>
        </tr>
    </table>
</asp:Content>
