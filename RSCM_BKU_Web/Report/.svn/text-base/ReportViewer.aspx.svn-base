<%@ Page Title="" Language="C#" MasterPageFile="~/Header.Master" AutoEventWireup="true" CodeBehind="ReportViewer.aspx.cs" Inherits="RSCM_BKU_Web.Report.ReportViewer" %>

<%@ Register Assembly="Telerik.ReportViewer.WebForms, Version=4.1.10.921, Culture=neutral, PublicKeyToken=a9d7983dfcc261be"
    Namespace="Telerik.ReportViewer.WebForms" TagPrefix="telerik" %>

<%@ Register Assembly="Ext.Net" Namespace="Ext.Net" TagPrefix="ext" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <ext:ResourceManager ID="ResourceManager1" runat="server"></ext:ResourceManager>
    
        <br />
        <ext:Panel ID="Panel1" runat="server" Title="Title" AnchorHorizontal="100%" Height="110" AnchorVertical="110">
            <Items>
                <ext:CompositeField ID="CompositeField1" runat="server" FieldLabel="Trans. Start Date" MsgTarget="Under" >
                    <Items>                    
                        <ext:DateField ID="dtfStartDate" runat="server" Width="200" />
                    </Items>
                </ext:CompositeField>
                <ext:CompositeField ID="CompositeField2" runat="server" FieldLabel="Trans. End Date" MsgTarget="Under" >
                    <Items>
                        <ext:DateField ID="dtfEndDate" runat="server" Width="200" />
                    </Items>
                </ext:CompositeField>
            
                    <ext:Button ID="btnPreview" runat="server" Text="PREVIEW"/>            
            
            </Items>
        </ext:Panel>  
        <ext:Panel ID="Panel2" runat="server" Title="Title" AnchorHorizontal="100%" Height="600">
            <Content>
                <telerik:ReportViewer ID="ReportViewer1" runat="server" Width="100%">
                </telerik:ReportViewer>   
            </Content>
        </ext:Panel> 
   
</asp:Content>
