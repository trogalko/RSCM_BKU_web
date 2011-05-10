<%@ Page Title="" Language="C#" MasterPageFile="~/Header.Master" AutoEventWireup="true" CodeBehind="LaporanBkuViewer.aspx.cs" Inherits="RSCM_BKU_Web.Report.LaporanBku.LaporanBkuViewer1" %>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>
<%@ Register Assembly="Telerik.ReportViewer.WebForms, Version=4.1.10.921, Culture=neutral, PublicKeyToken=a9d7983dfcc261be"
    Namespace="Telerik.ReportViewer.WebForms" TagPrefix="telerik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style3
        {
            width: 77px;
        }
        .style4
        {
            width: 6px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">    
        <telerik:RadFormDecorator ID="RadFormDecorator1" runat="server" 
            Skin="Office2007" />        
        <table>
            <tr>
                <td class="style3">
                    &nbsp;
                    Start Date</td>
                <td class="style4">
                    :</td>
                <td >
                    <telerik:RadDatePicker ID="dtpStartDate" Runat="server" Skin="Office2007" 
                        Width="200px">
<Calendar UseRowHeadersAsSelectors="False" UseColumnHeadersAsSelectors="False" ViewSelectorText="x" 
                            Skin="Office2007"></Calendar>

<DateInput DisplayDateFormat="dd/MM/yyyy" DateFormat="dd/MM/yyyy"></DateInput>

<DatePopupButton ImageUrl="" HoverImageUrl=""></DatePopupButton>
                    </telerik:RadDatePicker>
                </td>
            </tr>
            <tr>
                <td class="style3">
                    &nbsp;
                    End Date</td>
                <td class="style4" >
                    :</td>
                <td >                    
                    <telerik:RadDatePicker ID="dtpEndDate" Runat="server" Skin="Office2007" 
                        Width="200px">
<Calendar UseRowHeadersAsSelectors="False" UseColumnHeadersAsSelectors="False" ViewSelectorText="x" 
                            Skin="Office2007"></Calendar>

<DateInput DisplayDateFormat="dd/MM/yyyy" DateFormat="dd/MM/yyyy"></DateInput>

<DatePopupButton ImageUrl="" HoverImageUrl=""></DatePopupButton>
                    </telerik:RadDatePicker>
                </td>
            </tr>            
        </table>
        <div style="vertical-align: middle; text-align: center">
            <asp:Button ID="btnPreview" runat="server" Text="PREVIEW" 
                onclick="btnPreview_Click" />
            <table>
            <telerik:ReportViewer ID="ReportViewer1" runat="server" Skin="Office2007">
            </telerik:ReportViewer>
        </table>                    
        </div>
        
</asp:Content>
