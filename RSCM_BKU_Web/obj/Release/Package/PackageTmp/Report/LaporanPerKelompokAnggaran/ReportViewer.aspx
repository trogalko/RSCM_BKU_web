<%@ Page Title="" Language="C#" MasterPageFile="~/RibbonHeader.Master" AutoEventWireup="true" CodeBehind="ReportViewer.aspx.cs" Inherits="RSCM_BKU_Web.Report.LaporanPerKelompokAnggaran.ReportViewer" %>

<%@ Register Assembly="Telerik.Web.UI, Version=2012.2.607.35, Culture=neutral, PublicKeyToken=121fae78165ba3d4"
    Namespace="Telerik.Web.UI" TagPrefix="telerik" %>

<%@ Register Assembly="Telerik.ReportViewer.WebForms, Version=5.0.11.328, Culture=neutral, PublicKeyToken=a9d7983dfcc261be"
    Namespace="Telerik.ReportViewer.WebForms" TagPrefix="telerik" %>

<%@ Register Assembly="Ext.Net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=2e12ce3d0176cd87"
    Namespace="Ext.Net" TagPrefix="ext" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel runat="server" Width="100%" Height="25px">
        <telerik:RadButton ID="cmdPreview" runat="server" Text="VIEW REPORT" OnClick="preview_report">
        </telerik:RadButton>  
    </asp:Panel>
    <asp:Panel ID="Report_Panel" runat="server" Height="1000">
        <telerik:ReportViewer ID="ReportViewer1" runat="server" Width="100%" Height="990px">
        </telerik:ReportViewer>
    </asp:Panel>
</asp:Content>
