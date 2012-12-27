<%@ Page Title="" Language="C#" MasterPageFile="~/RibbonHeader.Master" AutoEventWireup="true" CodeBehind="ReportViewerKasBank.aspx.cs" Inherits="RSCM_BKU_Web.Report.ReportViewerKasBank" %>

<%@ Register Assembly="Telerik.Web.UI, Version=2012.2.607.35, Culture=neutral, PublicKeyToken=121fae78165ba3d4"
    Namespace="Telerik.Web.UI" TagPrefix="telerik" %>

<%@ Register Assembly="Telerik.ReportViewer.WebForms, Version=5.0.11.328, Culture=neutral, PublicKeyToken=a9d7983dfcc261be" Namespace="Telerik.ReportViewer.WebForms" TagPrefix="telerik" %>

<%@ Register Assembly="Ext.Net" Namespace="Ext.Net" TagPrefix="ext" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">   
    <telerik:RadFormDecorator ID="RadFormDecorator1" runat="server" />
    <br />
    <asp:LinqDataSource ID="LinqDataSource1" runat="server" 
        onselecting="LinqDataSource1_Selecting">
    </asp:LinqDataSource>
    <ext:Store ID="store1" runat="server">
        <Reader>
            <ext:JsonReader>
                <Fields>
                    <ext:RecordField Name="KA_CODE" />
                    <ext:RecordField Name="KA_NAME" />
                </Fields>
            </ext:JsonReader>
        </Reader>
    </ext:Store>
    <ext:Panel ID="Panel1" runat="server" Title="Title" AnchorHorizontal="100%" Height="110" AnchorVertical="110">
            <Items>
                <ext:CompositeField ID="CompositeField1" runat="server" FieldLabel="Trans. Start Date" MsgTarget="Under" >
                    <Items>                    
                        <ext:DateField ID="dtfStartDate" runat="server" Width="200" AllowBlank="false" />
                    </Items>
                </ext:CompositeField>
                <ext:CompositeField ID="CompositeField2" runat="server" FieldLabel="Trans. End Date" MsgTarget="Under" >
                    <Items>
                        <ext:DateField ID="dtfEndDate" runat="server" Width="200" AllowBlank="false" />
                    </Items>
                </ext:CompositeField>
                <ext:CompositeField ID="CompositeField3" runat="server" FieldLabel="Jenis Kas/Bank" MsgTarget="Under" >
                    <Items>                        
                        <ext:ComboBox ID="cmbJenisKasBank" runat="server" Width="350" AllowBlank="true" StoreID="Store1" Editable="false" DisplayField="KA_NAME" ValueField="KA_CODE" />
                    </Items>
                </ext:CompositeField>
            </Items>
    </ext:Panel>
    <telerik:RadButton ID="cmdPreview" runat="server" Text="PREVIEW" 
        onclick="cmdPreview_Click">
    </telerik:RadButton>
    <ext:Panel ID="Panel2" runat="server" Title="Title" AnchorHorizontal="100%" Height="1100">
        <Content>
            <telerik:ReportViewer ID="ReportViewer1" runat="server" Width="100%" Height="1000" Skin="Office2007">
            </telerik:ReportViewer>   
        </Content>
    </ext:Panel>
</asp:Content>
