<%@ Page Title="" Language="C#" MasterPageFile="~/Header.Master" AutoEventWireup="true" CodeBehind="MasterKas.aspx.cs" Inherits="RSCM_BKU_Web.Master.MasterKasBak" %>
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
            ShowStatusBar="True" onitemcommand="RadGrid1_ItemCommand" 
            ondeletecommand="RadGrid1_DeleteCommand">

            <ClientSettings>
                <Selecting AllowRowSelect="True" />
<Selecting AllowRowSelect="True"></Selecting>
            </ClientSettings>

            <MasterTableView 
                CommandItemDisplay="Top"                 
                GridLines="None"                 
                DataKeyNames="id" >
                <RowIndicatorColumn>
                    <HeaderStyle Width="20px"></HeaderStyle>
                </RowIndicatorColumn>

                <ExpandCollapseColumn>
                    <HeaderStyle Width="20px"></HeaderStyle>
                </ExpandCollapseColumn>
                <CommandItemSettings AddNewRecordText="ADD NEW KAS" />

<CommandItemSettings AddNewRecordText="ADD NEW KAS"></CommandItemSettings>

                <Columns>
                    <telerik:GridEditCommandColumn>
                    </telerik:GridEditCommandColumn>
                    <telerik:GridButtonColumn CommandName="Delete" HeaderText="Is Verified" 
                        Text="Verify" UniqueName="btnVerify">
                    </telerik:GridButtonColumn>
                    <telerik:GridButtonColumn ButtonType="ImageButton" 
                        HeaderText="Is Verified" 
                        ImageUrl="~\cancel.png" 
                        UniqueName="ImageVerify">
                    </telerik:GridButtonColumn>
                    <telerik:GridBoundColumn DataField="id" 
                        HeaderText="Nomor Urut" 
                        ReadOnly="True" 
                        SortExpression="id" 
                        UniqueName="id">
                    </telerik:GridBoundColumn>

                    <telerik:GridBoundColumn DataField="KA_CODE" 
                        HeaderText="KAS CODE" 
                        ReadOnly="True" 
                        SortExpression="KA_CODE" 
                        UniqueName="KA_CODE">
                    </telerik:GridBoundColumn>

                    <telerik:GridBoundColumn DataField="KA_NAME" 
                        HeaderText="KAS NAME" 
                        ReadOnly="True" 
                        SortExpression="KA_NAME" 
                        UniqueName="KA_NAME">
                    </telerik:GridBoundColumn>

                    <telerik:GridNumericColumn DataField="SALDO_AWAL"
                        HeaderText="SALDO" 
                        ReadOnly="True" 
                        SortExpression="SALDO_AWAL" 
                        UniqueName="SALDO_AWAL">
                        <ItemStyle HorizontalAlign="Right" />
                    </telerik:GridNumericColumn>

                    <telerik:GridBoundColumn DataField="PERIODE_ID" 
                        HeaderText="PERIODE ANGGARAN ID" 
                        ReadOnly="True" 
                        SortExpression="PERIODE_ID" 
                        UniqueName="PERIODE_ID">
                    </telerik:GridBoundColumn>
                    
                    <telerik:GridDateTimeColumn DataField="Start_Period" 
                        HeaderText="START PERIODE ANGGARAN" 
                        ReadOnly="True" 
                        SortExpression="Start_Period" 
                        UniqueName="Start_Period">
                    </telerik:GridDateTimeColumn>

                    <telerik:GridDateTimeColumn DataField="End_Period" 
                        HeaderText="END PERIODE ANGGARAN" 
                        ReadOnly="True" 
                        SortExpression="End_Period" 
                        UniqueName="End_Period">
                    </telerik:GridDateTimeColumn>

                    <telerik:GridCheckBoxColumn DataField="Is_Closed" 
                        HeaderText="Is Closed?" 
                        ReadOnly="True" 
                        SortExpression="Is_Closed" 
                        UniqueName="Is_Closed">
                    </telerik:GridCheckBoxColumn>

                </Columns>

                <EditFormSettings EditFormType="WebUserControl" 
                    UserControlName="MasterKas.ascx">
                    <EditColumn UniqueName="EditCommandColumn1"></EditColumn>
                </EditFormSettings>
                <PagerStyle />
            </MasterTableView>            
            <PagerStyle AlwaysVisible="True" />
        </telerik:RadGrid>
</asp:Content>
