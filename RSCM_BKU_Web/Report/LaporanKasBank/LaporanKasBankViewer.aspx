<%@ Page Title="" Language="C#" MasterPageFile="~/Header.Master" AutoEventWireup="true" CodeBehind="LaporanKasBankViewer.aspx.cs" Inherits="RSCM_BKU_Web.Report.LaporanKasBank.LaporanKasBankViewer1" %>
<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>

<%@ Register Assembly="Telerik.ReportViewer.WebForms, Version=5.0.11.328, Culture=neutral, PublicKeyToken=a9d7983dfcc261be" Namespace="Telerik.ReportViewer.WebForms" TagPrefix="telerik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style1
        {
            width: 79px;
        }
        .style2
        {
            width: 11px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server">
            <AjaxSettings>
                <telerik:AjaxSetting AjaxControlID="btnPreview">
                    <UpdatedControls>
                        <telerik:AjaxUpdatedControl ControlID="btnPreview" />
                        <telerik:AjaxUpdatedControl ControlID="LaporanKasBankWebViewer" />
                    </UpdatedControls>
                </telerik:AjaxSetting>
            </AjaxSettings>
        </telerik:RadAjaxManager>
        <telerik:RadFormDecorator ID="RadFormDecorator1" runat="server" 
            Skin="Office2007" />
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
        <table style="width: 100%;">
            <tr>
                <td class="style1">
                    &nbsp;
                <asp:Label ID="Label1" runat="server" Text="Start Date"></asp:Label>
                </td>
                <td class="style2">
                    &nbsp;
                    :</td>
                <td>
                    &nbsp;
                    <telerik:RadDatePicker ID="dtpStartDate" 
                        runat="server" 
                        Skin="Office2007" 
                        Width="225px">
                        <Calendar UseRowHeadersAsSelectors="False" 
                            UseColumnHeadersAsSelectors="False" 
                            ViewSelectorText="x" 
                            Skin="Office2007">
                        </Calendar>

                        <DateInput DisplayDateFormat="dd/MM/yyyy" 
                            DateFormat="dd/MM/yyyy">
                        </DateInput>

                        <DatePopupButton ImageUrl="" 
                            HoverImageUrl="">
                        </DatePopupButton>
                    </telerik:RadDatePicker>
                </td>
            </tr>
            <tr>
                <td class="style1">
                    &nbsp;
                    <asp:Label ID="Label2" runat="server" Text="End Date"></asp:Label>
                </td>
                <td class="style2">
                    &nbsp;
                    :</td>
                <td>
                    &nbsp;
                    <telerik:RadDatePicker ID="dtpEndDate" 
                        runat="server" 
                        Skin="Office2007" 
                        Width="225px">
                        <Calendar UseRowHeadersAsSelectors="False" 
                            UseColumnHeadersAsSelectors="False" 
                            ViewSelectorText="x" 
                            Skin="Office2007">
                        </Calendar>

                        <DateInput DisplayDateFormat="dd/MM/yyyy" 
                            DateFormat="dd/MM/yyyy">
                        </DateInput>

                        <DatePopupButton ImageUrl="" 
                            HoverImageUrl="">
                        </DatePopupButton>
                    </telerik:RadDatePicker>
                </td>
            </tr>            
        </table>
        <table style="width: 100%;">
            <tr>
                <td align="center">
                    
                    <asp:Button ID="btnPreview" runat="server" Text="PREVIEW" 
                        onclick="btnPreview_Click" />                    
                </td>                
            </tr>            
        </table>
        <table style="width: 100%;">
            <telerik:reportviewer runat="server" ID="LaporanKasBankWebViewer" 
            Width="100%" Skin="Office2007"></telerik:reportviewer>
        </table>
</asp:Content>
