<%@ Page Title="" Language="C#" MasterPageFile="~/Header.Master" AutoEventWireup="true" CodeBehind="MasterKelompokAnggaran.aspx.cs" Inherits="RSCM_BKU_Web.Master.MasterKelompokAnggaran2" %>
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
            ShowStatusBar="True" onitemcommand="RadGrid1_ItemCommand" PageSize="100">

            <ClientSettings>
                <Selecting AllowRowSelect="True" />
            </ClientSettings>

            <MasterTableView 
                CommandItemDisplay="Top" 
                GridLines="None"
                 DataKeyNames="KaId" >
                <RowIndicatorColumn>
                    <HeaderStyle Width="20px"></HeaderStyle>
                </RowIndicatorColumn>

                <ExpandCollapseColumn>
                    <HeaderStyle Width="20px"></HeaderStyle>
                </ExpandCollapseColumn>
                <CommandItemSettings AddNewRecordText="Add New Kelompok Anggaran" />

                <Columns>
                    <telerik:GridEditCommandColumn>
                    </telerik:GridEditCommandColumn>
                    <telerik:GridBoundColumn DataField="KaId" 
                        HeaderText="Kel. Anggaran ID" 
                        ReadOnly="True" 
                        SortExpression="KaId" 
                        UniqueName="KaId">
                    </telerik:GridBoundColumn>

                    <telerik:GridBoundColumn DataField="KaCode" 
                        HeaderText="Kel. Anggaran Code" ReadOnly="True" SortExpression="KaCode" 
                        UniqueName="KaCode">
                    </telerik:GridBoundColumn>

                    <telerik:GridBoundColumn DataField="KaName" 
                        HeaderText="Kel. Anggaran" ReadOnly="True" SortExpression="KaName" 
                        UniqueName="KaName">
                    </telerik:GridBoundColumn>

                    <telerik:GridBoundColumn DataField="Parent" 
                        HeaderText="Parent" ReadOnly="True" SortExpression="Parent" 
                        UniqueName="Parent">
                    </telerik:GridBoundColumn>

                    <telerik:GridBoundColumn DataField="GtCode" 
                        HeaderText="Group MA" ReadOnly="True" SortExpression="GtCode" 
                        UniqueName="GtCode">
                    </telerik:GridBoundColumn>

                    <telerik:GridBoundColumn DataField="Prefix" 
                        HeaderText="Prefix" ReadOnly="True" SortExpression="Prefix" 
                        UniqueName="Prefix">
                    </telerik:GridBoundColumn>

                    <telerik:GridBoundColumn DataField="KaLevel" 
                        HeaderText="Level MA" ReadOnly="True" SortExpression="KaLevel" 
                        UniqueName="KaLevel">
                    </telerik:GridBoundColumn>

                    <telerik:GridBoundColumn DataField="Type" 
                        HeaderText="Type MA" ReadOnly="True" SortExpression="Type" 
                        UniqueName="Type">
                    </telerik:GridBoundColumn>

                    <telerik:GridCheckBoxColumn DataField="IsDetail" 
                        HeaderText="Is Detail?" ReadOnly="True" SortExpression="IsDetail" 
                        UniqueName="IsDetail">
                    </telerik:GridCheckBoxColumn>

                    <telerik:GridCheckBoxColumn DataField="IsActive" 
                        HeaderText="Is Active?" ReadOnly="True" SortExpression="IsActive" 
                        UniqueName="IsActive">
                    </telerik:GridCheckBoxColumn>
                    
                </Columns>

                <EditFormSettings EditFormType="WebUserControl" 
                    UserControlName="MasterKelompokAnggaran.ascx">
                    <EditColumn UniqueName="EditCommandColumn1"></EditColumn>
                </EditFormSettings>
                <PagerStyle />
            </MasterTableView>
            <PagerStyle AlwaysVisible="True" />
        </telerik:RadGrid>
</asp:Content>
