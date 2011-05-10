<%@ Page Title="" Language="C#" MasterPageFile="~/Header.Master" AutoEventWireup="true" CodeBehind="TransaksiKas.aspx.cs" Inherits="RSCM_BKU_Web.Transaksi.TransaksiKas1" %>
<%@ Register Assembly="Ext.Net" Namespace="Ext.Net" TagPrefix="ext" %>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>
<%@ Register assembly="DevExpress.Web.v10.2, Version=10.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxPopupControl" tagprefix="dx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

<script type="text/javascript">
    function OpenPositionedWindow(oButton, url, windowName) {
        var oWnd = window.radopen(url, windowName);
    }
    function openRadWindow(CustomerID) {
        var oWnd = radopen("~/Transaksi/TransaksiKasAdd.aspx?KasID=" + CustomerID, "RadWindow1");
        oWnd.Center();
    }
          
</script>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <ext:ResourceManager ID="ResourceManager1" runat="server" Theme="Slate" />
    <telerik:RadWindowManager ID="RadWindowManager1" runat="server" 
        Skin="Office2007">
    </telerik:RadWindowManager>
    <telerik:RadWindow ID="RadWindow1" runat="server" Height="400px" Modal="True" 
        Skin="Office2007" Width="600px">
    </telerik:RadWindow>
    <asp:LinqDataSource ID="LinqDataSource1" runat="server" 
        onselecting="LinqDataSource1_Selecting">
    </asp:LinqDataSource>
        <ext:Panel ID="Panel1" runat="server" AutoHeight="true" ButtonAlign="Center">
            <TopBar>
                <ext:Toolbar runat="server">
                    <Items>                        
                        <ext:Button runat="server" ID="btnAdd" Icon="Add" Text="Add" >
                            <DirectEvents>
                                <Click OnEvent="AddKas">
                                    <Confirmation ConfirmRequest="true" Title="Add Data?" Message="Are You sure want to add data?" />
                                </Click>
                            </DirectEvents>
                        </ext:Button>
                        <ext:ToolbarSeparator />
                        <ext:Button runat="server" ID="btnEdit" Icon="ApplicationEdit" Text="Edit" >
                            <Listeners>
                                <Click Handler="openRadWindow(document.getElementById(hiddenID).value)" />
                            </Listeners>
                        </ext:Button>
                        <ext:ToolbarSeparator />
                        <ext:Button runat="server" ID="btnVerify" Icon="UserTick" Text="Verify" >
                        </ext:Button>
                        <ext:ToolbarSeparator />
                    </Items>
                </ext:Toolbar>
            </TopBar>
            <Items>
            </Items>
        </ext:Panel>

        <ext:GridPanel ID="GridPanel1" runat="server" Height="300" Title="Transaksi BKU" Frame="true">
            <Store>
                <ext:Store runat="server" DataSourceID="LinqDataSource1" ID="ctl35">
                    <Reader>
                        <ext:JsonReader IDProperty="TRANS_NUMBER">
                            <Fields>
                                <ext:RecordField Name="TRANS_NUMBER"/>
                                <ext:RecordField Name="TRANS_DATE" Type="Date" />
                                <ext:RecordField Name="KA_NAME" />
                                <ext:RecordField Name="DESCRIPT" />
                                <ext:RecordField Name="CEK_BG_NUMBER" />
                                <ext:RecordField Name="DEBIT_AMOUNT" Type="Float" />
                                <ext:RecordField Name="CREDIT_AMOUNT" Type="Float" />
                            </Fields>
                        </ext:JsonReader>
                    </Reader>
                </ext:Store>
            </Store>
            <TopBar>
                <ext:Toolbar ID="Toolbar1" runat="server">
                    <Items>                        
                        <ext:Button runat="server" ID="Button1" Icon="Add" Text="Add" >
                            <Listeners>
                                <Click Handler="function(s, e) {ASPxPopupControl1.Show();}" />
                            </Listeners>
                        </ext:Button>
                        <ext:ToolbarSeparator />
                        <ext:Button runat="server" ID="Button2" Icon="ApplicationEdit" Text="Edit" >
                        </ext:Button>
                        <ext:ToolbarSeparator />
                        <ext:Button runat="server" ID="Button3" Icon="UserTick" Text="Verify" >
                        </ext:Button>
                        <ext:ToolbarSeparator />
                    </Items>
                </ext:Toolbar>
            </TopBar>
            <ColumnModel runat="server" ID="ctl36">
                <Columns>
                    <ext:Column ColumnID="TRANS_NUMBER" DataIndex="TRANS_NUMBER" Header="Trans. Number" Width="100" Sortable="true" />
                    <ext:DateColumn DataIndex="TRANS_DATE" Header="Trans. Date" Width="80" />
                    <ext:Column DataIndex="KA_NAME" Header="Trans. Name" Width="400" />
                    <ext:Column DataIndex="DESCRIPT" Header="Trans. Description" Width="500" />                    
                    <ext:Column DataIndex="CEK_BG_NUMBER" Header="Cheque No." Width="100" />
                    <ext:NumberColumn DataIndex="DEBIT_AMOUNT" Header="Debit Amount" Width="150" Align="Right" />
                    <ext:NumberColumn DataIndex="CREDIT_AMOUNT" Header="Credit Amount" Width="150" Align="Right" />
                </Columns>
            </ColumnModel>
            <View>
                <ext:GridView runat="server" EnableRowBody="true" ID="ctl34">                    
                    <Templates>
                        <Header runat="server" Visible="False" ID="ctl33"></Header>
                    </Templates>                    
                </ext:GridView>
            </View>
            <SelectionModel>
                <ext:RowSelectionModel runat="server" ID="ctl32" />
            </SelectionModel>
            <BottomBar>
                <ext:PagingToolbar runat="server" PageSize="5" ID="ctl37" />
            </BottomBar>
            <DirectEvents>
                <RowClick OnEvent="GetSelected" />
            </DirectEvents>
        </ext:GridPanel>
        <asp:HiddenField ID="hiddenID" runat="server" />
        <dx:ASPxPopupControl ID="ASPxPopupControl1" runat="server" 
            ContentUrl="~/Transaksi/TransaksiKasAdd.aspx" 
            LoadContentViaCallback="None" Width="750px" Height="400px" Modal="True" PopupAction="None" PopupElementID="Button1" ClientInstanceName="ASPxPopupControl1" CloseAction="CloseButton" PopupHorizontalAlign="WindowCenter" PopupVerticalAlign="WindowCenter" EnableClientSideAPI="True">
        </dx:ASPxPopupControl>
</asp:Content>
