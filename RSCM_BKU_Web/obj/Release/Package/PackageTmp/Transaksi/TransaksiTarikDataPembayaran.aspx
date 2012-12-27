<%@ Page Title="" Language="C#" MasterPageFile="~/RibbonHeader.Master" AutoEventWireup="true" CodeBehind="TransaksiTarikDataPembayaran.aspx.cs" Inherits="RSCM_BKU_Web.Transaksi.TransaksiTarikDataPembayaran" %>
<%@ Register assembly="Ext.Net" namespace="Ext.Net" tagprefix="ext" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server"> 
    <ext:Store
        ID="storeInvoice"
        runat="server"
        OnReadData="storeInvoice_RefreshData" >        
        <Reader>
            <ext:JsonReader runat="server">                
                <Fields>
                    <ext:RecordField Name="InvoiceNo" />
                    <ext:RecordField Name="SupplierName" />
                    <ext:RecordField Name="InvoiceNotes" />
                    <ext:RecordField Name="NO_POR" />
                    <ext:RecordField Name="VerifyAmount" Type="Float" />
                    <ext:RecordField Name="PaymentAmount" Type="Auto" />
                    <ext:RecordField Name="NO_BG" />
                    <ext:RecordField Name="PPnAmount" Type="Auto" />
                    <ext:RecordField Name="PPh22Amount" Type="Auto" />
                    <ext:RecordField Name="PPh23Amount" Type="Auto" />
                    <ext:RecordField Name="Isproces" Type="Boolean" />
                </Fields>
            </ext:JsonReader>
        </Reader>
    </ext:Store>

    <ext:GridPanel
        id="gpInvoices"
        runat="server"
        StoreID="storeInvoice"
        Title="List of Unprocessed Invoices"
        AutoHeight="true">
        <View>
            <ext:GridView ID="gdvInvoices" runat="server" ForceFit="true" LoadMask="true" LoadingText="Please wait loading students data....." />            
        </View>
        <ColumnModel ID="ColumnModel1" runat="server">
            <Columns>   
                <ext:CommandColumn runat="server" Width="20" Header="Process?" >
                    <Commands>
                        <ext:GridCommand Icon="Tick" CommandName="Proceed">                            
                            <ToolTip Text="Proses Data" />
                        </ext:GridCommand>
                    </Commands>                    
                </ext:CommandColumn>     
                <ext:Column runat="server" Header="No. Invoice" DataIndex="InvoiceNo" Width="80" />
                <ext:Column runat="server" Header="Supplier Name" DataIndex="SupplierName" Width="150" />
                <ext:Column runat="server" Header="Note" DataIndex="InvoiceNotes" Width="200" />
                <ext:Column runat="server" Header="No. POR" DataIndex="NO_POR" />
                <ext:Column runat="server" Header="Amount Verified" DataIndex="VerifyAmount" Align="Right" >
                    <Renderer Fn="Ext.util.Format.numberRenderer('Rp 0,000.00')" />
                </ext:Column>
                <ext:Column runat="server" Header="Amount Payment" DataIndex="PaymentAmount" Align="Right" >
                    <Renderer Fn="Ext.util.Format.numberRenderer('Rp 0,000.00')" />
                </ext:Column>
                <ext:Column runat="server" Header="No. BG" DataIndex="NO_BG" />
                <ext:Column runat="server" Header="Amount PPn" DataIndex="PPnAmount" Align="Right" >
                    <Renderer Fn="Ext.util.Format.numberRenderer('Rp 0,000.00')" />
                </ext:Column>
                <ext:Column runat="server" Header="Amount PPh. 22" DataIndex="PPh22Amount" Align="Right" >
                    <Renderer Fn="Ext.util.Format.numberRenderer('Rp 0,000.00')" />
                </ext:Column>
                <ext:Column runat="server" Header="Amount PPh. 23" DataIndex="PPh23Amount" Align="Right" >
                    <Renderer Fn="Ext.util.Format.numberRenderer('Rp 0,000.00')" />
                </ext:Column>
            </Columns>
        </ColumnModel>
        <SelectionModel>
            <ext:RowSelectionModel ID="RowSelectionModel1" runat="server" Mode="Single">                
            </ext:RowSelectionModel>            
        </SelectionModel>
        <%--<TopBar>
            <ext:Toolbar ID="Toolbar1" runat="server">
                <Items>
                    <ext:ToolbarFill ID="ToolbarFill1" runat="server" />
                    <ext:Label ID="lblMhswID" runat="server" />
                    <ext:Button ID="btnSave" runat="server" Text="Save" Icon="Add">
                        <Listeners>
                            <Click Handler="Ext.net.DirectMethods.btnSave_Click();" />
                        </Listeners>                       
                    </ext:Button>
                </Items>
            </ext:Toolbar>
        </TopBar>--%>
        <Listeners>
            <Command Handler="Ext.net.DirectMethods.ProceesData_Click(record.data.InvoiceNo);" />
        </Listeners> 
    </ext:GridPanel>

    <ext:TaskManager runat="server" ID="tm1" Enabled="true">
        <Tasks>
            <ext:Task 
                TaskID="servertimer" 
                Interval="2000">                
                <Listeners>                    
                    <Update Handler="Ext.net.DirectMethods.Refresh_Grid();" />                    
                </Listeners>
            </ext:Task>
        </Tasks>
    </ext:TaskManager>

</asp:Content>
