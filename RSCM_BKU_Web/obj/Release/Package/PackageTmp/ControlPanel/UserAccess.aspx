<%@ Page Title="" Language="C#" MasterPageFile="~/Header.Master" AutoEventWireup="true" CodeBehind="UserAccess.aspx.cs" Inherits="RSCM_BKU_Web.ControlPanel.UserAccess" %>

<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <telerik:RadFormDecorator ID="RadFormDecorator1" runat="server" 
        Skin="Office2007" />
        <telerik:RadGrid ID="RadGrid1" 
            runat="server" 
            AllowPaging="True" 
            AllowSorting="True" GridLines="None"              
            Skin="Office2007" 
            AutoGenerateColumns="False"             
            ShowStatusBar="True">

            <ClientSettings>
                <Selecting AllowRowSelect="True" />
            </ClientSettings>

            <MasterTableView 
                CommandItemDisplay="Top"                 
                GridLines="None"                 
                DataKeyNames="UserID" >
                <RowIndicatorColumn>
                    <HeaderStyle Width="20px"></HeaderStyle>
                </RowIndicatorColumn>

                <ExpandCollapseColumn>
                    <HeaderStyle Width="20px"></HeaderStyle>
                </ExpandCollapseColumn>
                <CommandItemSettings AddNewRecordText="Add New User" />

                <Columns>
                    <telerik:GridEditCommandColumn HeaderStyle-Width="10%">                       
                    </telerik:GridEditCommandColumn>
                    <telerik:GridBoundColumn DataField="UserID" 
                        HeaderText="User ID" 
                        ReadOnly="True" 
                        SortExpression="UserID" 
                        UniqueName="UserID"
                        ItemStyle-Wrap="false" 
                        HeaderStyle-Width="10%">
                    </telerik:GridBoundColumn>

                    <telerik:GridBoundColumn DataField="UserName" 
                        HeaderText="User Name" 
                        ReadOnly="True" 
                        SortExpression="UserName" 
                        UniqueName="UserName"
                        ItemStyle-Wrap="false" 
                        HeaderStyle-Width="10%">
                    </telerik:GridBoundColumn>
                </Columns>

                <EditFormSettings EditFormType="WebUserControl" 
                    UserControlName="UserAccessAddEdit.ascx">
                    <EditColumn UniqueName="EditCommandColumn1"></EditColumn>
                </EditFormSettings>
                <PagerStyle />
            </MasterTableView>            
            <PagerStyle AlwaysVisible="True" />
        </telerik:RadGrid>
</asp:Content>
