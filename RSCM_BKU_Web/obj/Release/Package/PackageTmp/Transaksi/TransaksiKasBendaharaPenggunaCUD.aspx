<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TransaksiKasBendaharaPenggunaCUD.aspx.cs" Inherits="RSCM_BKU_Web.Transaksi.TransaksiKasBendaharaPenggunaCUD" %>

<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <telerik:RadCodeBlock ID="RadCodeBlock1" runat="server">
        <script type="text/javascript">
            function CloseAndRebind(args) {
                //GetRadWindow().BrowserWindow.refreshGrid(args);
                GetRadWindow().close();
            }

            function GetRadWindow() {
                var oWindow = null;
                if (window.radWindow) oWindow = window.radWindow; //Will work in Moz in all cases, including clasic dialog
                else if (window.frameElement.radWindow) oWindow = window.frameElement.radWindow; //IE (and Moz as well)

                return oWindow;
            }

            function CancelEdit() {
                GetRadWindow().close();
            }
        </script>
        </telerik:RadCodeBlock>

        <telerik:RadScriptManager ID="RadScriptManager1" runat="server">
        </telerik:RadScriptManager>
        <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server">
        </telerik:RadAjaxManager>
        <telerik:RadSplitter ID="RadSplitter1" runat="server"  Height="220" 
            Skin="Windows7">
            <telerik:RadPane ID="RadPane1" runat="server" Locked="true" Width="500">
                <table>
                    <tr>
                        <td>Trans. ID</td>
                        <td> 
                            <telerik:RadTextBox ID="txtTransID" runat="server" Width="410" Skin="Windows7" 
                                ReadOnly="True">
                            </telerik:RadTextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>Trans. Number</td>
                        <td> 
                            <telerik:RadTextBox ID="txtTransNumber" runat="server" Width="410" 
                                Skin="Windows7" ReadOnly="True">
                            </telerik:RadTextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>Trans. Code</td>
                        <td> 
                            <telerik:RadComboBox ID="cmbTransCode" runat="server" Width="410" 
                                Skin="Windows7" Filter="Contains">
                                <expandanimation type="InQuint" />
                                <collapseanimation type="InQuint" />
                            </telerik:RadComboBox>
                        </td>
                    </tr>
                    <tr>
                        <td>Trans. Date</td>
                        <td> 
                            <telerik:RadDatePicker ID="dtpTransDate" runat="server" Skin="WebBlue">
                                <calendar skin="WebBlue" usecolumnheadersasselectors="False" 
                                userowheadersasselectors="False" viewselectortext="x">
                                </calendar>
                                <dateinput dateformat="M/d/yyyy" displaydateformat="M/d/yyyy">
                                </dateinput>
                                <datepopupbutton hoverimageurl="" imageurl="" />
                                <datepopupbutton hoverimageurl="" imageurl="" />
                            </telerik:RadDatePicker>
                        </td>
                    </tr>
                    <tr>
                        <td>Kas. ID</td>
                        <td> 
                            <telerik:RadComboBox ID="cmbKasID" runat="server" Width="410" Skin="Windows7" 
                                Filter="Contains">
                                <expandanimation type="InQuint" />
                                <collapseanimation type="InQuint" />
                            </telerik:RadComboBox>                            
                        </td>
                    </tr>
                    <tr>
                        <td>Description</td>
                        <td> 
                            <telerik:RadTextBox ID="txtDescription" runat="server" Width="410" 
                                Skin="Windows7">
                            </telerik:RadTextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>No. Cek/BG</td>
                        <td> 
                            <telerik:RadTextBox ID="txtCekBG" runat="server" Width="410" Skin="Windows7">
                            </telerik:RadTextBox>
                        </td>
                    </tr>
                </table>
            </telerik:RadPane>
            <telerik:RadSplitBar ID="RadSplitBar1" runat="server">
            </telerik:RadSplitBar>
            <telerik:RadPane ID="RadPane2" runat="server" Locked="true" Width="300">
                <table>
                    <tr>
                        <td>Debit Amount</td>
                        <td> 
                            <telerik:RadNumericTextBox ID="txtDebitAmount" runat="server" Width="190" 
                                Skin="Windows7" Culture="id-ID">
                            </telerik:RadNumericTextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>Credit Amount</td>
                        <td> 
                            <telerik:RadNumericTextBox ID="txtCreditAmount" runat="server" Width="190" 
                                Skin="Windows7" Culture="id-ID">
                            </telerik:RadNumericTextBox>
                        </td>
                    </tr>
                </table>
            </telerik:RadPane>            
        </telerik:RadSplitter>
        <telerik:RadSplitter ID="RadSplitter2" runat="server" Height="30" 
            Skin="Windows7">
            <telerik:RadPane ID="RadPane3" runat="server" Width="800">
                <table width="100%">
                    <tr>
                        <td align="right" valign="middle" width="50%"> 
                            <telerik:RadButton ID="cmdSave" runat="server" Text="SAVE" 
                                onclick="cmdSave_Click" Skin="Black">
                            </telerik:RadButton>
                        </td>
                        <td align="left" valign="middle" width="50%"> 
                            <telerik:RadButton ID="cmdCancel" runat="server" Text="CANCEL" Visible="false" 
                                onclick="cmdCancel_Click" Skin="Black">
                            </telerik:RadButton>
                        </td>
                    </tr>
                </table>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*" ControlToValidate="cmbTransCode"></asp:RequiredFieldValidator>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="*" ControlToValidate="dtpTransDate"></asp:RequiredFieldValidator>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="*" ControlToValidate="cmbKasID"></asp:RequiredFieldValidator>
            </telerik:RadPane>
            <telerik:RadSplitBar ID="RadSplitBar2" runat="server">
            </telerik:RadSplitBar>
        </telerik:RadSplitter>
    </div>
    </form>
</body>
</html>
