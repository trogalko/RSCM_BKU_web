﻿<%@ Page Title="" Language="C#" MasterPageFile="~/RibbonHeader.Master" AutoEventWireup="true" CodeBehind="ReportViewerBKU.aspx.cs" Inherits="RSCM_BKU_Web.Report.ReportViewer" %>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="teleriks" %>

<%@ Register Assembly="Ext.Net" Namespace="Ext.Net" TagPrefix="ext" %>
<%@ Register Assembly="Telerik.ReportViewer.WebForms, Version=5.0.11.328, Culture=neutral, PublicKeyToken=a9d7983dfcc261be" Namespace="Telerik.ReportViewer.WebForms" TagPrefix="telerik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <teleriks:RadFormDecorator ID="RadFormDecorator1" runat="server" 
            Skin="Office2007" />    
        <br />
        <ext:Panel ID="Panel1" runat="server" Title="Title" AnchorHorizontal="100%" Height="110" AnchorVertical="110">
            <Items>
                <ext:CompositeField ID="CompositeField1" runat="server" FieldLabel="Trans. Start Date" MsgTarget="Under" >
                    <Items>                    
                        <ext:DateField ID="dtfStartDate" runat="server" Width="200" AllowBlank="false" Vtype="daterange" Format="dd/MM/yyyy" AltFormats="dd/MM/yyyy">
                            <CustomConfig>
                                <ext:ConfigItem Name="endDateField" Value="#{dtfEndDate}" Mode="Value" />
                            </CustomConfig>
                        </ext:DateField>
                    </Items>
                </ext:CompositeField>
                <ext:CompositeField ID="CompositeField2" runat="server" FieldLabel="Trans. End Date" MsgTarget="Under" >
                    <Items>
                        <ext:DateField ID="dtfEndDate" runat="server" Width="200" AllowBlank="false" Vtype="daterange" Format="dd/MM/yyyy" AltFormats="dd/MM/yyyy">
                            <CustomConfig>
                                <ext:ConfigItem Name="startDateField" Value="#{dtfStartDate}" Mode="Value" />
                            </CustomConfig>
                        </ext:DateField>
                    </Items>
                </ext:CompositeField>
            </Items>
        </ext:Panel>  
    <asp:Button ID="cmdPeview" runat="server" Text="PREVIEW" 
        onclick="cmdPeview_Click" Width="100%"/>
        <ext:Panel ID="Panel2" runat="server" Title="Title" AnchorHorizontal="100%" Height="1100">
            <Content>
                <telerik:ReportViewer ID="ReportViewer1" runat="server" Width="100%" Height="1000" Skin="Office2007">
                </telerik:ReportViewer>   
            </Content>
        </ext:Panel> 
   
</asp:Content>
