<%@ Page Title="" Language="C#" MasterPageFile="~/RibbonHeader.Master" AutoEventWireup="true" CodeBehind="TransaksiSortTransNumber.aspx.cs" Inherits="RSCM_BKU_Web.Transaksi.TransaksiSortTransNumber" %>
<%@ Register assembly="Ext.Net" namespace="Ext.Net" tagprefix="ext" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <ext:Panel runat="server" ID="pnlMain" Height="500" Title="1">
        <TopBar>
            <ext:Toolbar runat="server">
                <Items>
                    <ext:Button runat="server" ID="btnProcess" Text="PROSESS">
                        <Listeners>
                            <Click Handler="Ext.net.DirectMethods.Proceed();" />
                        </Listeners>
                    </ext:Button>
                </Items>
            </ext:Toolbar>
        </TopBar>
        <Items>
            <ext:TextField runat="server" ID="txtTransNumber" Width="300" />
        </Items>
    </ext:Panel>
</asp:Content>
