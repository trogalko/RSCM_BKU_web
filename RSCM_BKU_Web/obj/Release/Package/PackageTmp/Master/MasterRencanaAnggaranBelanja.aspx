<%@ Page Title="" Language="C#" MasterPageFile="~/RibbonHeader.Master" AutoEventWireup="true" CodeBehind="MasterRencanaAnggaranBelanja.aspx.cs" Inherits="RSCM_BKU_Web.Master.MasterRencanaAnggaranBelanja2" %>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<!--
    <telerik:RadMenu ID="RadMenu1" Runat="server" Skin="Office2007" Width="100%">
            <Items>
                <telerik:RadMenuItem runat="server" Text="MASTER">
                    <Items>
                        <telerik:RadMenuItem runat="server" NavigateUrl="~/Master/masterGroupMA.aspx" 
                            Text="Master Group Anggaran">
                        </telerik:RadMenuItem>
                        <telerik:RadMenuItem runat="server" 
                            NavigateUrl="~/Master/MasterKelompokAnggaran.aspx" 
                            Text="Master Kelompok Anggaran">
                        </telerik:RadMenuItem>
                        <telerik:RadMenuItem runat="server" 
                            NavigateUrl="~/Master/MasterKas.aspx" 
                            Text="Master Kas">
                        </telerik:RadMenuItem>
                        <telerik:RadMenuItem runat="server" 
                            NavigateUrl="~/Master/MasterRencanaAnggaranBelanja.aspx" 
                            Text="Master Rencana Anggaran Belanja">
                        </telerik:RadMenuItem>
                    </Items>
                </telerik:RadMenuItem>
                <telerik:RadMenuItem runat="server" Text="TRANSACTION">
                    <Items>
                        <telerik:RadMenuItem runat="server" 
                            NavigateUrl="~/Transaksi/TransaksiKasBendaharaPengguna.aspx" 
                            Text="Transaksi Kas Bendahara Pengguna">
                        </telerik:RadMenuItem>
                    </Items>
                </telerik:RadMenuItem>
                <telerik:RadMenuItem runat="server" Text="REPORTS">
                    <Items>
                        <telerik:RadMenuItem runat="server" 
                            NavigateUrl="~/Report/LaporanKasBank/LaporanKasBankViewer.aspx" 
                            Text="Laporan Kas dan Bank">
                        </telerik:RadMenuItem>
                        <telerik:RadMenuItem runat="server" 
                            NavigateUrl="~/Report/LaporanBku/LaporanBkuViewer.aspx" 
                            Text="Laporan BKU">
                        </telerik:RadMenuItem>
                    </Items>
                </telerik:RadMenuItem>
            </Items>
        </telerik:RadMenu>
-->
        <telerik:RadGrid ID="RadGrid1" 
            runat="server" 
            AllowPaging="True" 
            AllowSorting="True" GridLines="None" 
            oninsertcommand="RadGrid1_InsertCommand" 
            OnUpdateCommand="RadGrid1_UpdateCommand"
            onneeddatasource="RadGrid1_NeedDataSource" 
            onprerender="RadGrid1_PreRender" 
            Skin="Office2007" 
            AutoGenerateColumns="False"             
            ShowStatusBar="True" onitemcommand="RadGrid1_ItemCommand">

            <ClientSettings>
                <Selecting AllowRowSelect="True" />
<Selecting AllowRowSelect="True"></Selecting>
            </ClientSettings>

            <MasterTableView 
                CommandItemDisplay="Top"                 
                GridLines="None"                 
                DataKeyNames="id" >
                <RowIndicatorColumn>
                    <HeaderStyle Width="20px"></HeaderStyle>
                </RowIndicatorColumn>

                <ExpandCollapseColumn>
                    <HeaderStyle Width="20px"></HeaderStyle>
                </ExpandCollapseColumn>
                <CommandItemSettings AddNewRecordText="ADD NEW RAB" />

<CommandItemSettings AddNewRecordText="ADD NEW RAB"></CommandItemSettings>

                <Columns>
                    <telerik:GridEditCommandColumn>
                    </telerik:GridEditCommandColumn>
                    <telerik:GridBoundColumn DataField="id" 
                        HeaderText="Nomor Urut" 
                        ReadOnly="True" 
                        SortExpression="id" 
                        UniqueName="id">
                    </telerik:GridBoundColumn>

                    <telerik:GridBoundColumn DataField="KA_CODE" 
                        HeaderText="KAS CODE" 
                        ReadOnly="True" 
                        SortExpression="KA_CODE" 
                        UniqueName="KA_CODE">
                    </telerik:GridBoundColumn>

                    <telerik:GridBoundColumn DataField="KA_NAME" 
                        HeaderText="KAS NAME" 
                        ReadOnly="True" 
                        SortExpression="KA_NAME" 
                        UniqueName="KA_NAME">
                    </telerik:GridBoundColumn>

                    <telerik:GridNumericColumn DataField="RAB1"
                        HeaderText="RENCANA ANGGARAN BELANJA" 
                        ReadOnly="True" 
                        SortExpression="RAB1" 
                        UniqueName="RAB1" NumericType="Currency">
                        <ItemStyle HorizontalAlign="Right" />
                    </telerik:GridNumericColumn>

                    <telerik:GridBoundColumn DataField="PERIOD_ID" 
                        HeaderText="PERIODE ANGGARAN ID" 
                        ReadOnly="True" 
                        SortExpression="PERIOD_ID" 
                        UniqueName="PERIOD_ID">
                    </telerik:GridBoundColumn>
                    
                    <telerik:GridDateTimeColumn DataField="Start_Period" 
                        HeaderText="START PERIODE ANGGARAN" 
                        ReadOnly="True" 
                        SortExpression="Start_Period" 
                        UniqueName="Start_Period">
                    </telerik:GridDateTimeColumn>

                    <telerik:GridDateTimeColumn DataField="End_Period" 
                        HeaderText="END PERIODE ANGGARAN" 
                        ReadOnly="True" 
                        SortExpression="End_Period" 
                        UniqueName="End_Period">
                    </telerik:GridDateTimeColumn>

                    <telerik:GridCheckBoxColumn DataField="Is_Closed" 
                        HeaderText="IS CLOSED?" 
                        ReadOnly="True" 
                        SortExpression="Is_Closed" 
                        UniqueName="Is_Closed">
                    </telerik:GridCheckBoxColumn>

                </Columns>

                <EditFormSettings EditFormType="WebUserControl" 
                    UserControlName="MasterRencanaAnggaranBelanja.ascx">
                    <EditColumn UniqueName="EditCommandColumn1"></EditColumn>
                </EditFormSettings>
                <PagerStyle />
            </MasterTableView>            
            <PagerStyle AlwaysVisible="True" />
        </telerik:RadGrid>
</asp:Content>
