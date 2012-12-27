<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TransaksiTarikDataPembayaranProcess.aspx.cs" Inherits="RSCM_BKU_Web.Transaksi.TransaksiTarikDataPembayaranProcess" %>
<%@ Register assembly="Ext.Net" namespace="Ext.Net" tagprefix="ext" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript">
        var onKeyUp = function () {
            var v = this.getRawValue();

            key = Ext.EventObject.getKey();

            if (key === Ext.EventObject.ENTER ||
        key === Ext.EventObject.ESC) {

                this.collapse();
                return;
            }

            if (key === Ext.EventObject.UP ||
        key === Ext.EventObject.DOWN) {

                return;
            }

            if (v.length > 0) {
                this.getStore().filter(this.displayField, new RegExp(v + "+", "i"));
                this.onLoad();
            } else {
                this.collapse();
            }
        };
    </script>
</head>
<body>
    <ext:ResourceManager runat="server" />
    <form id="form1" runat="server">
    <div>
        <ext:Store
        ID="storeKa"
        runat="server"
        OnReadData="storeKa_RefreshData" >        
        <Reader>
            <ext:JsonReader runat="server">                
                <Fields>
                    <ext:RecordField Name="KA_CODE" />
                    <ext:RecordField Name="KA_NAME" />                    
                </Fields>
            </ext:JsonReader>
        </Reader>
        </ext:Store>

        <ext:Store
        ID="storeKas"
        runat="server"
        OnReadData="storeKas_RefreshData" >        
        <Reader>
            <ext:JsonReader runat="server">                
                <Fields>
                    <ext:RecordField Name="KA_CODE" />
                    <ext:RecordField Name="KA_NAME" />                    
                </Fields>
            </ext:JsonReader>
        </Reader>
        </ext:Store>

        <ext:Panel runat="server" Title="Proses ke BKU" Frame="true" Layout="FitLayout" Height="550">
            <Items>
                <ext:TabPanel runat="server" ID="tpMain" ActiveTabIndex="0" Frame="true" DeferredRender="false">
                    <Items>
                        <ext:Panel ID="TabTransaksi" runat="server" Title="Transaksi" Padding="2" Border="true" Layout="AbsoluteLayout">
                            <Items>
                                <ext:Label ID="LblTransInvoiceNo" runat="server" X="0" Y="15" Text="Invoice No" />
                                <ext:TextField ID="txtTransInvoiceNo" runat="server" X="75" Y="15" AnchorHorizontal="100%" ReadOnly="true" />
                                <ext:Label ID="lblTransKa" runat="server" X="0" Y="42" Text="Kel. Anggaran" />                                
                                <ext:ComboBox ID="cmbTransKa" runat="server" X="75" Y="42" DisplayField="KA_NAME" ValueField="KA_CODE" StoreID="storeKa" TypeAhead="false" HideTrigger="true" ForceSelection="false" EnableKeyEvents="true" Editable="true" SelectOnFocus="true" AnchorHorizontal="100%" >
                                    <Listeners>
                                        <AfterRender Handler="this.mun(this.el, 'keyup', this.onKeyUp, this); this.mon(this.el, 'keyup', onKeyUp, this);" />            
                                    </Listeners>
                                </ext:ComboBox>                              
                                <ext:Label ID="lblTransInvoiceNote" runat="server" X="0" Y="69" Text="Invoice Notes" />
                                <ext:TextField ID="txtTransInvoiceNote" runat="server" X="75" Y="69" AnchorHorizontal="100%" />   
                                <ext:Label ID="lblTransInvoiceDate" runat="server" X="0" Y="96" Text="Invoice Date" />
                                <ext:DateField ID="dfTransInvoiceDate" runat="server" AnchorHorizontal="100%" X="75" Y="96" />
                                <ext:Label ID="LblTransDebitAmount" runat="server" X="0" Y="123" Text="Debit Amount" />                                
                                <ext:TextField ID="txtTransDebitAmount" runat="server" MaskRe="/[0-9\.]/" X="75" Y="123" AnchorHorizontal="100%">
                                    <Listeners>
                                        <%--<Change Handler="this.setValue(Ext.util.Format.number(newValue.replace(/[,]/g, ''), '0,0.00'));" />--%>
                                    </Listeners>
                                </ext:TextField>
                                <ext:Label ID="LblTransCreditAmount" runat="server" X="0" Y="150" Text="Credit Amount" />
                                <ext:TextField ID="txtTransCreditAmount" runat="server" MaskRe="/[0-9\.]/" X="75" Y="150" AnchorHorizontal="100%">
                                    <Listeners>
                                        <%--<Change Handler="this.setValue(Ext.util.Format.number(newValue.replace(/[,]/g, ''), '0,0.00'));" />--%>
                                    </Listeners>
                                </ext:TextField>  
                                <ext:Label ID="lblTransKas" runat="server" X="0" Y="177" Text="Kas" />                                
                                <ext:ComboBox ID="cmbTransKasId" runat="server" X="75" Y="177" DisplayField="KA_NAME" ValueField="KA_CODE" StoreID="storeKas" TypeAhead="false" HideTrigger="true" ForceSelection="false" EnableKeyEvents="true" Editable="true" SelectOnFocus="true" AnchorHorizontal="100%" >
                                    <Listeners>
                                        <AfterRender Handler="this.mun(this.el, 'keyup', this.onKeyUp, this); this.mon(this.el, 'keyup', onKeyUp, this);" />            
                                    </Listeners>
                                </ext:ComboBox>                                                         
                                <ext:Label ID="LblTransBG" runat="server" X="0" Y="204" Text="BG. No" />
                                <ext:TextField ID="txtTransBG" runat="server" X="75" Y="204" AnchorHorizontal="100%" ReadOnly="true" />
                                <ext:Label ID="LblSupplierName" runat="server" X="0" Y="231" Text="Supplier Name" />
                                <ext:TextField ID="txtTransSupplierName" runat="server" X="75" Y="231" AnchorHorizontal="100%" ReadOnly="true" />
                            </Items>
                        </ext:Panel>

                        <ext:Panel ID="TabPpn" runat="server" Title="PPn" Padding="2" Border="true" Layout="AbsoluteLayout">
                            <Items>
                                <ext:Label ID="LblPPnInvoice" runat="server" X="0" Y="15" Text="Invoice No" />
                                <ext:TextField ID="txtPpnInvoiceNo" runat="server" X="75" Y="15" AnchorHorizontal="100%" ReadOnly="true" />
                                <ext:Label ID="LblPPnKa" runat="server" X="0" Y="42" Text="Kel. Anggaran" />                                
                                <ext:ComboBox ID="cmbPPnKa" runat="server" X="75" Y="42" DisplayField="KA_NAME" ValueField="KA_CODE" StoreID="storeKa" TypeAhead="false" HideTrigger="true" ForceSelection="false" EnableKeyEvents="true" Editable="true" SelectOnFocus="true" AnchorHorizontal="100%" >
                                    <Listeners>
                                        <AfterRender Handler="this.mun(this.el, 'keyup', this.onKeyUp, this); this.mon(this.el, 'keyup', onKeyUp, this);" />            
                                    </Listeners>
                                </ext:ComboBox>                               
                                <ext:Label ID="LblPPnInvoicesNote" runat="server" X="0" Y="69" Text="Invoice Notes" />
                                <ext:TextField ID="txtPPnInvoiceNote" runat="server" X="75" Y="69" AnchorHorizontal="100%" />   
                                <ext:Label ID="lblPPnInvoiceDate" runat="server" X="0" Y="96" Text="Invoice Date" />
                                <ext:DateField ID="dfPPnInvoiceDate" runat="server" AnchorHorizontal="100%" X="75" Y="96" />
                                <ext:Label ID="LblPPnDebitAmount" runat="server" X="0" Y="123" Text="Debit Amount" />                                
                                <ext:TextField ID="txtPPnDebitAmount" runat="server" MaskRe="/[0-9\.]/" X="75" Y="123" AnchorHorizontal="100%">
                                    <Listeners>
                                        <Change Handler="this.setValue(Ext.util.Format.number(newValue.replace(/[,]/g, ''), '0,0.00'));" />
                                    </Listeners>
                                </ext:TextField>
                                <ext:Label ID="LblPPnCreditAmount" runat="server" X="0" Y="150" Text="Credit Amount" />
                                <ext:TextField ID="txtPPnCreditAmount" runat="server" MaskRe="/[0-9\.]/" X="75" Y="150" AnchorHorizontal="100%">
                                    <Listeners>
                                        <Change Handler="this.setValue(Ext.util.Format.number(newValue.replace(/[,]/g, ''), '0,0.00'));" />
                                    </Listeners>
                                </ext:TextField>
                                <ext:Label ID="LblPPnKas" runat="server" X="0" Y="177" Text="Kas" />                                
                                <ext:ComboBox ID="cmbPPnKas" runat="server" X="75" Y="177" DisplayField="KA_NAME" ValueField="KA_CODE" StoreID="storeKas" TypeAhead="false" HideTrigger="true" ForceSelection="false" EnableKeyEvents="true" Editable="true" SelectOnFocus="true" AnchorHorizontal="100%" >
                                    <Listeners>
                                        <AfterRender Handler="this.mun(this.el, 'keyup', this.onKeyUp, this); this.mon(this.el, 'keyup', onKeyUp, this);" />            
                                    </Listeners>
                                </ext:ComboBox>
                                <ext:Label ID="LblPPnBG" runat="server" X="0" Y="204" Text="BG. No" />
                                <ext:TextField ID="txtPPnBG" runat="server" X="75" Y="204" AnchorHorizontal="100%" ReadOnly="true" />
                                <ext:Label ID="LblPPnSupplierName" runat="server" X="0" Y="231" Text="Supplier Name" />
                                <ext:TextField ID="txtPPnSupplierName" runat="server" X="75" Y="231" AnchorHorizontal="100%" ReadOnly="true" />
                            </Items>   
                        </ext:Panel>

                        <ext:Panel ID="TabPPh" runat="server" Title="PPh" Padding="2" Border="true" Layout="AbsoluteLayout">
                            <Items>
                                <ext:Label ID="LblPPhInvoiceNo" runat="server" X="0" Y="15" Text="Invoice No" />
                                <ext:TextField ID="txtPphInvoiceNo" runat="server" X="75" Y="15" AnchorHorizontal="100%" ReadOnly="true" />
                                <ext:Label ID="LblPPhKa" runat="server" X="0" Y="42" Text="Kel. Anggaran" />                                
                                <ext:ComboBox ID="cmbPPhKa" runat="server" X="75" Y="42" DisplayField="KA_NAME" ValueField="KA_CODE" StoreID="storeKa" TypeAhead="false" HideTrigger="true" ForceSelection="false" EnableKeyEvents="true" Editable="true" SelectOnFocus="true" AnchorHorizontal="100%" >
                                    <Listeners>
                                        <AfterRender Handler="this.mun(this.el, 'keyup', this.onKeyUp, this); this.mon(this.el, 'keyup', onKeyUp, this);" />            
                                    </Listeners>
                                </ext:ComboBox>
                                <ext:Label ID="LblPPhInvoicesNote" runat="server" X="0" Y="69" Text="Invoice Notes" />
                                <ext:TextField ID="txtPPhInvoiceNote" runat="server" X="75" Y="69" AnchorHorizontal="100%" />   
                                <ext:Label ID="LblPPhInvoiceDate" runat="server" X="0" Y="96" Text="Invoice Date" />
                                <ext:DateField ID="dfPPhInvoiceDate" runat="server" AnchorHorizontal="100%" X="75" Y="96" />
                                <ext:Label ID="LblPPhDebitAmount" runat="server" X="0" Y="123" Text="Debit Amount" />                                
                                <ext:TextField ID="txtPPhDebitAmount" runat="server" MaskRe="/[0-9\.]/" X="75" Y="123" AnchorHorizontal="100%">
                                    <Listeners>
                                        <Change Handler="this.setValue(Ext.util.Format.number(newValue.replace(/[,]/g, ''), '0,0.00'));" />
                                    </Listeners>
                                </ext:TextField>
                                <ext:Label ID="LblPPhCreditAmount" runat="server" X="0" Y="150" Text="Credit Amount" />
                                <ext:TextField ID="txtPPhCreditAmount" runat="server" MaskRe="/[0-9\.]/" X="75" Y="150" AnchorHorizontal="100%">
                                    <Listeners>
                                        <Change Handler="this.setValue(Ext.util.Format.number(newValue.replace(/[,]/g, ''), '0,0.00'));" />
                                    </Listeners>
                                </ext:TextField>  
                                <ext:Label ID="LblPPhKas" runat="server" X="0" Y="177" Text="Kas" />                                
                                <ext:ComboBox ID="cmbPPhKas" runat="server" X="75" Y="177" DisplayField="KA_NAME" ValueField="KA_CODE" StoreID="storeKas" TypeAhead="false" HideTrigger="true" ForceSelection="false" EnableKeyEvents="true" Editable="true" SelectOnFocus="true" AnchorHorizontal="100%" >
                                    <Listeners>
                                        <AfterRender Handler="this.mun(this.el, 'keyup', this.onKeyUp, this); this.mon(this.el, 'keyup', onKeyUp, this);" />            
                                    </Listeners>
                                </ext:ComboBox>
                                <ext:Label ID="LblPPhBG" runat="server" X="0" Y="204" Text="BG. No" />
                                <ext:TextField ID="txtPPhBG" runat="server" X="75" Y="204" AnchorHorizontal="100%" ReadOnly="true" />
                                <ext:Label ID="LblPPhSupplierName" runat="server" X="0" Y="231" Text="Supplier Name" />
                                <ext:TextField ID="txtPPhSupplierName" runat="server" X="75" Y="231" AnchorHorizontal="100%" ReadOnly="true" />
                                <ext:Label ID="LblPPh22" runat="server" X="0" Y="258" Text="Is PPh22?" />
                                <ext:Checkbox ID="chkPPh22" runat="server" X="75" Y="258" Enabled="false" />
                            </Items>   
                        </ext:Panel>
                    </Items>
                </ext:TabPanel>
            </Items>
            <TopBar>
                <ext:Toolbar runat="server">
                    <Items>
                        <ext:Button ID="btnSave" runat="server" Text="SAVE" Icon="Disk">
                            <Listeners>
                                <Click Handler="Ext.net.DirectMethods.SaveData();" />
                            </Listeners>
                        </ext:Button> 
                        <ext:Button ID="btnCancel" runat="server" Text="CANCEL" Icon="Cancel">
                        </ext:Button>
                        <ext:ToolbarFill runat="server" />
                    </Items>
                </ext:Toolbar>
            </TopBar>
        </ext:Panel>
    </div>
    </form>
</body>
</html>
