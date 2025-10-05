<%@ Page Language="C#" MasterPageFile="~/cool cab services/maintenanceManger/MaintenanceManger.master" AutoEventWireup="true" CodeFile="SparePartsDetails.aspx.cs" Inherits="maintenanceManger_SparePartsDetails" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<script language="javascript" type="text/javascript">
  function check()
   {
    var TxtSpName=document.getElementById("<%=TxtSpName.ClientID%>").value;
            if(TxtSpName=="")
            {
                 alert("SparePartName Required");
                 document.getElementById("<%=TxtSpName.ClientID%>").focus();
                 return false;
            }
            if(TxtSpName!="")
            {
                var name=/^[a-zA-Z _.]+$/;
                if(!TxtSpName.match(name))
                {
                        document.getElementById("<%=TxtSpName.ClientID%>").focus();
                        alert ("SparePartName Should be Character");
                        return false;
                }
            }
            var TxtDealerName=document.getElementById("<%=TxtDealerName.ClientID%>").value;
            if(TxtDealerName=="")
            {
                   document.getElementById("<%=TxtDealerName.ClientID%>").focus();
                   alert("DealerName Name Required");
                   return false;
            }
            if(TxtDealerName!="")
            {
                var LastName=/^[a-zA-Z _.]+$/;
                if(!TxtDealerName.match(LastName))
                {
                   alert ("DealerName  Should be Characters");
                   document.getElementById("<%=TxtDealerName.ClientID%>").focus();
                   return false;
                }
            }
            //TxtSparepartType
              var TxtSparepartType=document.getElementById("<%=TxtSparepartType.ClientID%>").value;
            if(TxtSparepartType=="")
            {
                   document.getElementById("<%=TxtSparepartType.ClientID%>").focus();
                   alert("SparepartType Name Required");
                   return false;
            }
            if(TxtSparepartType!="")
            {
                var LastName=/^[a-zA-Z _.]+$/;
                if(!TxtSparepartType.match(LastName))
                {
                   alert ("SparepartType  Should be Characters");
                   document.getElementById("<%=TxtSparepartType.ClientID%>").focus();
                   return false;
                }
            }
            //TxtQuantity
              var TxtQuantity=document.getElementById("<%=TxtQuantity.ClientID%>").value;
          if(TxtQuantity=="")
            {
               
                document.getElementById("<%=TxtQuantity.ClientID%>").focus();
                alert('Quantity Required');
                return false;
            }
           else if(TxtQuantity!="")
            {
             var Exp=/^[0-9.]+$/;
              if(!TxtQuantity.match(Exp))
                {
                    alert('Quantity Digits Only');
                    document.getElementById("<%=TxtQuantity.ClientID%>").focus();
                    return false;
                }
            }
            
             var TxtDOP=document.getElementById("<%=TxtDOP.ClientID%>").value; 
            if(TxtDOP=="")
            {
                alert("Date of Purchase Required");
                document.getElementById("<%=TxtDOP.ClientID%>").focus();
                return false;
            }
            //TxtPrice
                 var TxtPrice=document.getElementById("<%=TxtPrice.ClientID%>").value;
          if(TxtPrice=="")
            {
               
                document.getElementById("<%=TxtPrice.ClientID%>").focus();
                alert('Price Required');
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
            var TxtAmounpaid=document.getElementById("<%=TxtAmounpaid.ClientID%>").value;
          if(TxtAmounpaid=="")
            {
               
                document.getElementById("<%=TxtAmounpaid.ClientID%>").focus();
                alert('Amount Required');
                return false;
            }
           else if(TxtAmounpaid!="")
            {
             var Exp=/^[0-9.]+$/;
              if(!TxtAmounpaid.match(Exp))
                {
                    alert('Amount Digits Only');
                    document.getElementById("<%=TxtAmounpaid.ClientID%>").focus();
                    return false;
                }
            }
            
   }
</script>
  <script type="text/javascript" language="javascript">
function m()
{
   
    var y=document.getElementById("<%=TxtQuantity.ClientID %>").value;
    var x=document.getElementById("<%=TxtPrice.ClientID %>").value;
    if(y!="" && x!="")
    {
        var Z=Number(y)*Number(x);
        //alert(Z);
        document.getElementById("<%=TxtAmounpaid.ClientID%>").value=Z;
    }
    else
    {
        alert('Values Required!');
    }
    }
     </script>
      <table cellspacing="5" cellpadding="0" align="center" width="700"  class="border1"  >
        <tr>
          <td class="border" colspan="2" align="center"  >
              <b class="title">SparePartsDetails</b></td>
        </tr>
        <tr>
            <td align="right"  width="50%"><font color="red">*</font><span><b>SparePatrName :</b></span>
                </td>
            <td >
                <asp:TextBox ID="TxtSpName" runat="server" Style="position: static"></asp:TextBox>
                </td>
        </tr>
        <tr>
            <td align="right" ><font color="red">*</font><span><b>DealerName :</b></span>
                </td>
            <td >
                <asp:TextBox ID="TxtDealerName" runat="server" Style="position: static"></asp:TextBox></td>
        </tr>
        <tr>
            <td align="right" ><font color="red">*</font><span><b>SparePartType :</b></span>
                </td>
            <td >
                <asp:TextBox ID="TxtSparepartType" runat="server" Style="position: static"></asp:TextBox></td>
        </tr>
        <tr>
            <td align="right" ><font color="red">*</font><span><b>Quantity :</b></span>
                </td>
            <td >
                <asp:TextBox ID="TxtQuantity" runat="server" Style="position: static"></asp:TextBox></td>
        </tr>
        <tr>
            <td align="right" ><font color="red">*</font><span><b>Date Of Purchase :</b></span>
                </td>
           <td align="left">
                            <asp:TextBox ID="TxtDOP" runat="server" CssClass="textbox" MaxLength="10" Wrap="False" /><a
                                href="javascript:NewCal('<%=TxtDOP.ClientID %>','mmddyyyy')"><img src="../images/cal.gif"
                                    width="16" height="16" border="0" alt="Pick a date" /></a><br />
                            &nbsp;&nbsp;mm/dd/yyyy
                        </td>
        </tr>
        <tr>
            <td align="right" ><font color="red">*</font><span><b>Price :</b></span>
                </td>
            <td >
                <asp:TextBox ID="TxtPrice" runat="server" Style="position: static" ></asp:TextBox></td>
        </tr>
        <tr>
            <td align="right" ><font color="red">*</font><span><b>AmountPaid :</b></span>
                </td>
            <td >
                <input id="TxtAmounpaid" type="text" runat="server"  onblur="return m(this);" />
               <%-- <asp:TextBox ID="TxtAmounpaid" runat="server" Style="position: static"></asp:TextBox>--%></td>
        </tr>
        <tr>
            <td >
            </td>
            <td >
                <asp:Button ID="Button1" runat="server" Style="position: static" Text="" CssClass="button" OnClick="Button1_Click" OnClientClick="javascript:return check();"  />
                <asp:Button ID="Btn_clear" runat="server" Style="position: static" Text="Clear" CssClass="button" OnClick="Btn_clear_Click"/>
                <asp:Button ID="Back" runat="server" Style="position: static" Text="Back" CssClass="button" OnClick="Back_Click" /></td>
        </tr>
        <tr>
            <td >
            </td>
            <td >
            </td>
        </tr>
    </table>
</asp:Content>

