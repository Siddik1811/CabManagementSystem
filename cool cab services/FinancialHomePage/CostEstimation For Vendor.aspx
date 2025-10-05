<%@ Page Language="C#" MasterPageFile="~/cool cab services/FinancialHomePage/FinancialMaster.master" AutoEventWireup="true" CodeFile="CostEstimation For Vendor.aspx.cs" Inherits="FinancialHomePage_CostEstimation_For_Vendor" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<script language="javascript" type="text/javascript">
  function check()
   {
    var DDLVendor=document.getElementById("<%=DDLVendor.ClientID%>").selectedIndex;
            if(DDLVendor==0)
            {
                alert('Vendor Required');
                return false;
            }
           
                    
   }
  </script>
  
   <table cellspacing="5" cellpadding="0" align="center" width="700"  class="border1"  >
        <tr>
          <td class="border" colspan="3" align="center"  >
              <b class="title">Cost Estimation For Vendor</b></td>
        </tr>
        <tr>
            <td align="right" ><font color="red">*</font><span><b>VedorID :</b></span>
            </td>
            <td  width="30%">
                <asp:DropDownList ID="DDLVendor" runat="server" AppendDataBoundItems="True" Style="position: static"
                    Width="154px" AutoPostBack="True" >
                    <asp:ListItem>Select..</asp:ListItem>
                </asp:DropDownList>
                </td>
            <td width="30%">
                <asp:Button ID="Button1" runat="server" Style="position: static" Text="Show" CssClass="button" OnClick="Button1_Click"   OnClientClick="javascript:return check();"/></td>
        </tr>
        <tr>
            <td align="right" style="height: 24px" ><font color="red">*</font><span><b>Total :</b></span>
            </td>
            <td colspan="2" style="height: 24px" >
                <asp:TextBox ID="TxtTotal" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="center" colspan="3" >
                <asp:GridView ID="GdVCostEstimation" runat="server" CellPadding="4" 
                    ForeColor="#333333" GridLines="None"
                    Style="position: static" AllowPaging="True" 
                    OnPageIndexChanging="GdVCostEstimation_PageIndexChanging" 
                    onselectedindexchanged="GdVCostEstimation_SelectedIndexChanged">
                    <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <RowStyle BackColor="#EFF3FB" />
                    <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                    <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                    <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <EditRowStyle BackColor="#2461BF" />
                    <AlternatingRowStyle BackColor="White" />
                </asp:GridView>
            </td>
        </tr>
    </table>
</asp:Content>

