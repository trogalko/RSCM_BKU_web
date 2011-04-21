<%@ Page Title="" Language="C#" MasterPageFile="~/Header.Master" AutoEventWireup="true" CodeBehind="MasterGroupMA.aspx.cs" Inherits="RSCM_BKU_Web.Master.MasterGroupMAs" %>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

        <telerik:RadGrid ID="RadGrid1" 
            runat="server" 
            AllowPaging="True" 
            AllowSorting="True" GridLines="None" 
            oninsertcommand="RadGrid1_InsertCommand" 
            OnUpdateCommand="RadGrid1_UpdateCommand"
            onneeddatasource="RadGrid1_NeedDataSource" 
            onprerender="RadGrid1_PreRender" 
            Skin="Office2007" 
            AutoGenerateColumns="False"             
            ShowStatusBar="True">

            <ClientSettings>
                <Selecting AllowRowSelect="True" />
            </ClientSettings>

            <MasterTableView 
                CommandItemDisplay="Top"                 
                GridLines="None"                 
                DataKeyNames="GtId" >
                <RowIndicatorColumn>
                    <HeaderStyle Width="20px"></HeaderStyle>
                </RowIndicatorColumn>

                <ExpandCollapseColumn>
                    <HeaderStyle Width="20px"></HeaderStyle>
                </ExpandCollapseColumn>
                <CommandItemSettings AddNewRecordText="Add New Group MA" />

                <Columns>
                    <telerik:GridEditCommandColumn HeaderStyle-Width="10%">                       
                    </telerik:GridEditCommandColumn>
                    <telerik:GridBoundColumn DataField="GtId" 
                        HeaderText="Group MA ID" 
                        ReadOnly="True" 
                        SortExpression="GtId" 
                        UniqueName="GtId"
                        ItemStyle-Wrap="false" 
                        HeaderStyle-Width="10%">
                    </telerik:GridBoundColumn>

                    <telerik:GridBoundColumn DataField="GtCode" 
                        HeaderText="Group MA Code" 
                        ReadOnly="True" 
                        SortExpression="GtCode" 
                        UniqueName="GtCode"
                        ItemStyle-Wrap="false" 
                        HeaderStyle-Width="10%">
                    </telerik:GridBoundColumn>
                </Columns>

                <EditFormSettings EditFormType="WebUserControl" 
                    UserControlName="masterGroupMA.ascx">
                    <EditColumn UniqueName="EditCommandColumn1"></EditColumn>
                </EditFormSettings>
                <PagerStyle />
            </MasterTableView>            
            <PagerStyle AlwaysVisible="True" />
        </telerik:RadGrid>
</asp:Content>
