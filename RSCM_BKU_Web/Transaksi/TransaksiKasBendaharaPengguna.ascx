<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="TransaksiKasBendaharaPengguna.ascx.cs" Inherits="RSCM_BKU_Web.Transaksi.TransaksiKasBendaharaPengguna1" %>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>

<script type="text/javascript">
    function OnClientSelectedIndexChanged(sender, eventArgs) {
        var hidden = $find("<%= HiddenField1.ClientID%>");
        var combo = $find("<%= cmbTransCODE.ClientID%>");
        document.getElementById("<%= HiddenField1.ClientID%>").value = combo.get_value();
    }
</script>
<style type="text/css">
    .style1
    {
        width: 113px;
    }
    .style2
    {
        width: 3px;
    }
    .style3
    {
        width: 103px;
    }
    .style5
    {
        width: 243px;
    }
    .style6
    {
        width: 319px;
    }
    .style7
    {
        width: 5px;
    }
</style>
<telerik:RadFormDecorator ID="RadFormDecorator1" runat="server" 
    Skin="Office2007" />
<table>
    <tr>
        <td class="style1" bgcolor="#CCCCCC">
            Trans. ID</td>
        <td class="style2">
            :</td>
        <td class="style5">
            <telerik:RadTextBox ID="txtTransID" 
                Runat="server" Skin="Office2007" 
                onkeypress="return CkKeyPress(event);"
                Text='<%# DataBinder.Eval( Container, "DataItem.BKU_ID") %>' 
                ReadOnly="True">
            </telerik:RadTextBox>
        </td>
        <td class="style3" bgcolor="#CCCCCC">
            Debit Amount</td>
        <td class="style7">
            :</td>
        <td>
            <telerik:RadNumericTextBox ID="txtDebitAmount" 
                Runat="server" 
                Culture="id-ID" 
                Skin="Office2007" 
                Type="Currency" 
                Width="250px"
                onkeypress="return CkKeyPress(event);"
                
                Text='<%# ((bool)DataBinder.Eval(Container, "OwnerTableView.IsItemInserted")) ? 0 : DataBinder.Eval( Container, "DataItem.DEBIT_AMOUNT") %>' 
                TabIndex="9">                
                <NumberFormat AllowRounding="False" DecimalDigits="2" NegativePattern="(n)" 
                    PositivePattern="n" />
            </telerik:RadNumericTextBox>
        </td>
    </tr>
    <tr>
        <td class="style1" bgcolor="#CCCCCC">
            Trans. Number</td>
        <td class="style2">
            :</td>
        <td class="style5">
            <telerik:RadTextBox ID="txtTransNUMBER" 
                Runat="server" Skin="Office2007"      
                onkeypress="return CkKeyPress(event);"           
                Text='<%# DataBinder.Eval( Container, "DataItem.TRANS_NUMBER") %>' 
                ReadOnly="True" TabIndex="1">
            </telerik:RadTextBox>
        </td>
        <td class="style3" bgcolor="#CCCCCC">
            Credit
            Amount</td>
        <td class="style7">
            :</td>
        <td>
            <telerik:RadNumericTextBox ID="txtCreditAmount" 
                Runat="server" 
                Culture="id-ID" 
                Skin="Office2007" 
                Type="Currency" 
                Width="250px"
                onkeypress="return CkKeyPress(event);"
                
                Text='<%# ((bool)DataBinder.Eval(Container, "OwnerTableView.IsItemInserted")) ? 0 : DataBinder.Eval( Container, "DataItem.CREDIT_AMOUNT") %>' 
                TabIndex="10">
                <NumberFormat AllowRounding="False" DecimalDigits="2" NegativePattern="(n)" 
                    PositivePattern="n" />
            </telerik:RadNumericTextBox>
        </td>
    </tr>
    <tr>
        <td class="style1" bgcolor="#CCCCCC">
            Trans. Code</td>
        <td class="style2">
            :</td>
        <td class="style5">            
            <telerik:RadComboBox ID="cmbTransCODE" 
                Runat="server"
                Skin="Office2007" 
                Width="230px" ondatabound="cmbTransCODE_DataBound" Filter="Contains" 
                TabIndex="2"
                SelectedValue='<%# DataBinder.Eval( Container, "DataItem.KA_CODE") %>' 
                onkeypress="return CkKeyPress(event);" 
                onclientselectedindexchanged="OnClientSelectedIndexChanged">
                <ExpandAnimation Type="InQuint" />
            </telerik:RadComboBox>
        
            <telerik:RadTextBox ID="txtTransCode" 
                Runat="server" 
                Skin="Office2007" 
                Visible="False" 
                Width="230px"
                Text='<%# DataBinder.Eval( Container, "DataItem.KA_NAME") %>' 
                ontextchanged="txtTransCode_TextChanged" TabIndex="3"
                onkeypress="return CkKeyPress(event);">
            </telerik:RadTextBox>
        
        </td>
        <td class="style3">
            &nbsp;</td>
        <td class="style7">
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td bgcolor="#CCCCCC">Trans. Date</td>
        <td>:</td>
        <td>
            <telerik:RadDatePicker ID="dtpTransDate" 
                Runat="server" 
                Culture="id-ID" 
                Skin="Office2007" 
                Width="300px"
                onkeypress="return CkKeyPress(event);"
                DbSelectedDate='<%# DataBinder.Eval( Container, "DataItem.TRANS_DATE") %>' 
                TabIndex="4">
<Calendar UseRowHeadersAsSelectors="False" UseColumnHeadersAsSelectors="False" 
                    ViewSelectorText="x" Skin="Office2007"></Calendar>

<DateInput DisplayDateFormat="dd/MM/yyyy" DateFormat="dd/MM/yyyy" TabIndex="4"></DateInput>

<DatePopupButton ImageUrl="" HoverImageUrl="" TabIndex="4"></DatePopupButton>
            </telerik:RadDatePicker>
        </td>
        <td></td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="style1" bgcolor="#CCCCCC">
            Kas Id</td>
        <td class="style2">
            :</td>
        <td class="style5">
            <telerik:RadComboBox ID="cmbKasID" 
                Runat="server" 
                Width="232px" 
                Skin="Office2007" ondatabound="cmbKasID_DataBound" TabIndex="5"
                onkeypress="return CkKeyPress(event);"> 
                <ExpandAnimation Type="InQuint" />
            </telerik:RadComboBox>
            <telerik:RadTextBox ID="txtKasId" 
                Runat="server" 
                Skin="Office2007" 
                Visible="False" 
                Width="230px"
                onkeypress="return CkKeyPress(event);"
                Text='<%# DataBinder.Eval( Container, "DataItem.KAS_NAME") %>' 
                TabIndex="6">
            </telerik:RadTextBox>
        </td>
        <td class="style3">
            &nbsp;</td>
        <td class="style7">
            &nbsp;</td>
        <td>
            
        </td>
    </tr>
    <tr>
        <td bgcolor="#CCCCCC">Description</td>
        <td>:</td>
        <td>
            <telerik:RadTextBox ID="txtDESC" Runat="server" Skin="Office2007" 
                Width="400px"
                onkeypress="return CkKeyPress(event);"
                Text='<%# DataBinder.Eval( Container, "DataItem.DESCRIPT") %>' 
                TabIndex="7" >
            </telerik:RadTextBox>
        </td>
        <td></td>
        <td></td>
        <td class="style7"></td>
    </tr>
    <tr>
        <td bgcolor="#CCCCCC">No. Cek/BG</td>
        <td>:</td>
        <td>
            
            <telerik:RadTextBox ID="txtCek" 
                Runat="server" 
                Skin="Office2007" 
                Width="250px"
                onkeypress="return CkKeyPress(event);"
                Text='<%# DataBinder.Eval( Container, "DataItem.CEK_BG_NUMBER") %>' 
                TabIndex="8">
            </telerik:RadTextBox>
            
        </td>
        <td></td>
        <td></td>
        <td class="style7"></td>
    </tr>
    <tr>
        <td></td>
        <td></td>
        <td></td>
        <td></td>
        <td></td>
        <td></td>
    </tr>
</table>

<table>
    <tr>
        <td align="right" class="style6" style="width:50%;">
            <asp:Button ID="btnSAVE" runat="server" Height="26px" 
                Text='<%# ((bool)DataBinder.Eval(Container, "OwnerTableView.IsItemInserted")) ? "Insert" : "Update" %>' 
                CommandName='<%# ((bool)DataBinder.Eval(Container, "OwnerTableView.IsItemInserted")) ? "PerformInsert" : "Update" %>' 
                TabIndex="11" />
        </td>
        
        <td align="left" style="width:50%;">
            <asp:Button ID="btnCANCEL" runat="server" Text="Cancel" 
                causesvalidation="False" commandname="Cancel" TabIndex="12" />
        </td>
    </tr>
    <tr>
        <td class="style6" style="width:50%;">
            &nbsp;</td>
        
        <td style="width:50%;">
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style6" style="width:50%;">
            <asp:HiddenField ID="HiddenField1" runat="server" />
        </td>        
        <td>
            &nbsp;</td>
    </tr>
</table>