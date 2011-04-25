<%@ Page Title="" Language="C#" MasterPageFile="~/Header.Master" AutoEventWireup="true" CodeBehind="ReportViewer.aspx.cs" Inherits="RSCM_BKU_Web.Report.ReportViewer" %>

<%@ Register Assembly="Telerik.ReportViewer.WebForms, Version=4.1.10.921, Culture=neutral, PublicKeyToken=a9d7983dfcc261be"
    Namespace="Telerik.ReportViewer.WebForms" TagPrefix="telerik" %>

<%@ Register Assembly="Ext.Net" Namespace="Ext.Net" TagPrefix="ext" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <ext:Panel ID="Panel1" runat="server" Height="300" Title="Title">
        <Items>
            <ext:BorderLayout ID="BorderLayout1" runat="server">
                <North>
                    <ext:FormPanel ID="pnlParameter" runat="server" Width="100%" Height="300" Padding="5">

                    </ext:FormPanel>
                </North>
                <South>
                    <telerik:ReportViewer ID="ReportViewer1" runat="server">
                    </telerik:ReportViewer>
                </South>
            </ext:BorderLayout>
        </Items>
    </ext:Panel>   
</asp:Content>
