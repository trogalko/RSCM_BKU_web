<%@ Page Title="" Language="C#" MasterPageFile="~/RibbonHeader.Master" AutoEventWireup="true" CodeBehind="TransaksiKas.aspx.cs" Inherits="RSCM_BKU_Web.Transaksi.TransaksiKas1" %>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
</asp:Content>
    

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server"> 
    <telerik:RadAjaxManager ID="RadAjaxManager3" runat="server" 
        onajaxrequest="RadAjaxManager3_AjaxRequest">
        <ajaxsettings>
            <telerik:AjaxSetting AjaxControlID="RadAjaxManager3">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="RadGrid1" />
                </UpdatedControls>
            </telerik:AjaxSetting>

            <telerik:AjaxSetting AjaxControlID="RadGrid1">
                <updatedcontrols>
                    <telerik:AjaxUpdatedControl ControlID="RadGrid1" />
                </updatedcontrols>
            </telerik:AjaxSetting>

            <telerik:AjaxSetting AjaxControlID="cmdSearchGrid">
                <updatedcontrols>
                    <telerik:AjaxUpdatedControl ControlID="RadGrid1" />
                </updatedcontrols>
            </telerik:AjaxSetting>
        </ajaxsettings>
    </telerik:RadAjaxManager>

    <telerik:RadCodeBlock ID="RadCodeBlock2" runat="server">
        <script type="text/javascript">
            function ShowEditForm(id, rowIndex) {
                var grid = $find("<%= RadGrid1.ClientID %>");

                var rowControl = grid.get_masterTableView().get_dataItems()[rowIndex].get_element();
                grid.get_masterTableView().selectItem(rowControl, true);

                var oWnd = window.radopen("TransaksiKasBendaharaPenggunaCUD.aspx?BKU_ID=" + id, "TransaksiCUD");
                oWnd.add_close(OnClientClose);
                return false;
            }
            function ShowInsertForm() {
                var oWnd = window.radopen("TransaksiKasBendaharaPenggunaCUD.aspx", "TransaksiCUD");
                oWnd.add_close(OnClientClose);
                return false;
            }
            function refreshGrid(arg) {
                $find("<%= RadAjaxManager3.ClientID %>").ajaxRequest("Rebind");
            }
            function RowDblClick(sender, eventArgs) {
                window.radopen("TransaksiKasBendaharaPenggunaCUD.aspx?BKU_ID=" + eventArgs.getDataKeyValue("BKU_ID"), "TransaksiCUD");
            }

            function OnClientClose(oWnd) {
                $find("<%= RadAjaxManager3.ClientID %>").ajaxRequest("Rebind");
            }

            function CkKeyPress(e) {
                var evt = (e) ? e : window.event;
                var key = (evt.keyCode) ? evt.keyCode : evt.which;
                if (key == 13) {
                    CancelDefault(evt);
                }
            }
            function CancelDefault(e) {
                if (e.preventDefault) { e.preventDefault(); }
                e.returnValue = false;
            }
        </script>
    </telerik:RadCodeBlock>

    <asp:Panel runat="server" ID="pnlToolbar" Width="100%" Height="50">
        <telerik:RadDatePicker ID="dtpStartDate" Runat="server" 
    Skin="Black">
            <Calendar UseRowHeadersAsSelectors="False" UseColumnHeadersAsSelectors="False" 
        ViewSelectorText="x" skin="Black">
            </Calendar>
            <DateInput DisplayDateFormat="M/d/yyyy" DateFormat="M/d/yyyy">
            </DateInput>
            <DatePopupButton ImageUrl="" HoverImageUrl="">
            </DatePopupButton>
        </telerik:RadDatePicker>
        <telerik:RadDatePicker ID="dtpEndDate" Runat="server" Skin="Black">
            <Calendar skin="Black" UseColumnHeadersAsSelectors="False" 
                UseRowHeadersAsSelectors="False" ViewSelectorText="x">
            </Calendar>
            <DateInput DateFormat="M/d/yyyy" DisplayDateFormat="M/d/yyyy">
            </DateInput>
            <DatePopupButton HoverImageUrl="" ImageUrl="" />
        </telerik:RadDatePicker>
        <telerik:RadButton ID="cmdSearchGrid" runat="server" Skin="Black" 
            Text="Refresh" onclick="cmdSearchGrid_Click">
        </telerik:RadButton>

    </asp:Panel>
    <asp:Panel runat="server" ID="pnlMain" Width="100%" Height="600">
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
            oneditcommand="RadGrid1_EditCommand" 
            ShowStatusBar="True" 
            Culture="id-ID" 
            onitemcommand="RadGrid1_ItemCommand" 
            onitemcreated="RadGrid1_ItemCreated">

            <ClientSettings>
                <Selecting AllowRowSelect="True" />
                <ClientEvents OnRowDblClick="RowDblClick" />
            </ClientSettings>

            <MasterTableView  
                CommandItemDisplay="Top" 
                GridLines="None"
                 DataKeyNames="BKU_ID" >
                <RowIndicatorColumn>
                    <HeaderStyle Width="20px"></HeaderStyle>
                </RowIndicatorColumn>

                <ExpandCollapseColumn>
                    <HeaderStyle Width="20px"></HeaderStyle>
                </ExpandCollapseColumn>
                <CommandItemTemplate>
                    <a href="#" onclick="return ShowInsertForm();">Add New Record</a>
                </CommandItemTemplate>

                <Columns>
                    <telerik:GridTemplateColumn UniqueName="TemplateEditColumn">
                        <ItemTemplate>
                            <asp:HyperLink ID="EditLink" runat="server" Text="Edit"></asp:HyperLink>
                        </ItemTemplate>
                    </telerik:GridTemplateColumn>

                    <telerik:GridBoundColumn DataField="BKU_ID" 
                        HeaderText="Trans ID" 
                        ReadOnly="True" 
                        SortExpression="BKU_ID" 
                        UniqueName="BKU_ID" Visible="false">
                        <HeaderStyle Width="50px" />
                        <ItemStyle Width="50px" />
                    </telerik:GridBoundColumn>

                    <telerik:GridBoundColumn DataField="TRANS_NUMBER" 
                        HeaderText="Trans Number" ReadOnly="True" SortExpression="TRANS_NUMBER" 
                        UniqueName="TRANS_NUMBER">
                    </telerik:GridBoundColumn>

                    <telerik:GridDateTimeColumn DataField="TRANS_DATE" 
                        HeaderText="Trans Date" ReadOnly="True" SortExpression="TRANS_DATE" 
                        UniqueName="TRANS_DATE" DataFormatString="{0:d}">                        
                    </telerik:GridDateTimeColumn>

                    <telerik:GridBoundColumn DataField="KA_CODE" 
                        HeaderText="Trans. Code" ReadOnly="True" SortExpression="KA_CODE" 
                        UniqueName="KA_CODE">
                    </telerik:GridBoundColumn>

                    <telerik:GridBoundColumn DataField="KA_NAME" 
                        HeaderText="Transaction Name" ReadOnly="True" SortExpression="KA_NAME" 
                        UniqueName="KA_NAME">
                    </telerik:GridBoundColumn>

                    <telerik:GridBoundColumn DataField="CEK_BG_NUMBER" 
                        HeaderText="No. Cek/BG" ReadOnly="True" SortExpression="CEK_BG_NUMBER" 
                        UniqueName="CEK_BG_NUMBER">
                        <ItemStyle HorizontalAlign="Right" />
                    </telerik:GridBoundColumn>

                    <telerik:GridNumericColumn DataField="DEBIT_AMOUNT" 
                        HeaderText="Debit Amount" ReadOnly="True" SortExpression="DEBIT_AMOUNT" 
                        NumericType="Currency" UniqueName="DEBIT_AMOUNT" DataType="System.Decimal">
                        <ItemStyle HorizontalAlign="Right" />
                    </telerik:GridNumericColumn>

                    <telerik:GridNumericColumn DataField="CREDIT_AMOUNT" 
                        HeaderText="Cedit Amount" ReadOnly="True" SortExpression="CREDIT_AMOUNT" 
                        UniqueName="CREDIT_AMOUNT" DataType="System.Decimal" NumericType="Currency">
                        <ItemStyle HorizontalAlign="Right" />
                    </telerik:GridNumericColumn>

                    <telerik:GridBoundColumn DataField="DESCRIPT"
                        HeaderText="Description" ReadOnly="true" SortExpression="DESCRIPT"
                        UniqueName="DESCRIPT">
                    </telerik:GridBoundColumn>

                    <telerik:GridBoundColumn DataField="KAS_NAME"
                        HeaderText="KAS" ReadOnly="true" SortExpression="KAS_NAME"
                        UniqueName="KAS_NAME">
                    </telerik:GridBoundColumn>

                    <telerik:GridCheckBoxColumn DataField="ISVERIFIED"
                        HeaderText="Is Verifed?" ReadOnly="true" SortExpression="ISVERIFIED"
                        UniqueName="ISVERIFIED">
                    </telerik:GridCheckBoxColumn>

                    <telerik:GridCheckBoxColumn DataField="IS_CLOSED"
                        HeaderText="Is Closed?" ReadOnly="true" SortExpression="IS_CLOSED"
                        UniqueName="IS_CLOSED">
                    </telerik:GridCheckBoxColumn>

                    <telerik:GridBoundColumn DataField ="KAS_ID" 
                        HeaderText="Kas Id" Visible="false" SortExpression="KAS_ID" 
                        UniqueName="KAS_ID">
                    </telerik:GridBoundColumn>                 

                </Columns>
                <PagerStyle />
            </MasterTableView>        
            <PagerStyle AlwaysVisible="True"/>
        </telerik:RadGrid>

        <telerik:RadWindowManager ID="RadWindowManager1" runat="server" Skin="WebBlue" 
            EnableShadow="True" Behaviors="Close, Maximize, Move, Reload" 
            InitialBehaviors="Pin" Modal="True" VisibleStatusbar="False">
            <windows>
                <telerik:RadWindow ID="TransaksiCUD" runat="server" NavigateUrl="RadWindow1" Skin="Black" Title="Add/Edit Transaction" Height="500px"
                    Width="850px" Left="230px" ReloadOnShow="true" ShowContentDuringLoad="false"
                    Modal="true">
                </telerik:RadWindow>
            </windows>
        </telerik:RadWindowManager>

    </asp:Panel>
</asp:Content>
