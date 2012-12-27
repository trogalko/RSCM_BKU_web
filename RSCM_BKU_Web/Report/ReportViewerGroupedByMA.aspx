<%@ Page Title="" Language="C#" MasterPageFile="~/RibbonHeader.Master" AutoEventWireup="true" CodeBehind="ReportViewerGroupedByMA.aspx.cs" Inherits="RSCM_BKU_Web.Report.ReportViewerGroupedByMA" %>

<%@ Register Assembly="Telerik.ReportViewer.WebForms, Version=5.0.11.328, Culture=neutral, PublicKeyToken=a9d7983dfcc261be"
    Namespace="Telerik.ReportViewer.WebForms" TagPrefix="telerik" %>

<%@ Register Assembly="Ext.Net" Namespace="Ext.Net" TagPrefix="ext" %>

<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <telerik:radformdecorator runat="server" Skin="Office2007" />    
    
    <script type="text/javascript">
        //<![CDATA[
        function OnClientClose(oWnd, args) {
            //get the transferred arguments
            var arg = args.get_argument();
            if (arg) {
                var startDate = arg.StartDate;
                var endDate = arg.EndDate;
            }
        }
        //]]>
    </script>
     
    <asp:Panel ID="pnlMain" runat="server" Width="100%" Height="100%">
        <asp:Panel ID="pnlOption" runat="server" Height="10%">            
            <telerik:RadDatePicker ID="dtpStartDate" runat="server" Skin="Office2007">
                <Calendar Skin="Office2007" UseColumnHeadersAsSelectors="False" 
                    UseRowHeadersAsSelectors="False" ViewSelectorText="x">
                </Calendar>
                <DateInput DateFormat="M/d/yyyy" DisplayDateFormat="M/d/yyyy">
                </DateInput>
                <DatePopupButton HoverImageUrl="" ImageUrl="" />
            </telerik:RadDatePicker> &nbsp;&nbsp;
            
            <telerik:RadDatePicker ID="dtpEndDate" runat="server" Skin="Office2007">
                <Calendar Skin="Office2007" UseColumnHeadersAsSelectors="False" 
                    UseRowHeadersAsSelectors="False" ViewSelectorText="x">
                </Calendar>
                <DateInput DateFormat="M/d/yyyy" DisplayDateFormat="M/d/yyyy">
                </DateInput>
                <DatePopupButton HoverImageUrl="" ImageUrl="" />
            </telerik:RadDatePicker> &nbsp;&nbsp;
            <telerik:RadButton ID="cmdProceed" runat="server" Text="Submit"  
                Font-Size="14px" onclick="cmdProceed_Click" 
                Skin="Office2007">
                <Icon SecondaryIconCssClass="rbPrint" PrimaryIconLeft="12" PrimaryIconTop="25" />
            </telerik:RadButton>
        </asp:Panel>

        <asp:Panel ID="pnlReportViewer" runat="server" Height="85%">            
            <telerik:ReportViewer ID="ReportViewer1" runat="server" Width="100%" Height="600" 
                ShowHistoryButtons="False" ShowParametersButton="False" Skin="Office2007">
            </telerik:ReportViewer> 
        </asp:Panel>
    </asp:Panel>

    <telerik:RadWindowManager ID="RadWindowManager1" runat="server">
        <Windows>
            <telerik:RadWindow ID="RadWindow1" 
                runat="server" Behaviors="Close" OnClientClose="OnClientClose" Modal="true" 
                EnableShadow ="true" NavigateUrl="ReportViewerGroupedByMApopUp.aspx" 
                VisibleOnPageLoad="false" Height="200" Width="250" Animation="Fade">
            </telerik:RadWindow>
        </Windows>
    </telerik:RadWindowManager>
</asp:Content>
    