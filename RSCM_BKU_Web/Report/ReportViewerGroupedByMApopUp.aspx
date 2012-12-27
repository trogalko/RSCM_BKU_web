<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ReportViewerGroupedByMApopUp.aspx.cs" Inherits="RSCM_BKU_Web.Report.ReportViewerGroupedByMApopUp" Culture="id-ID" %>

<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <telerik:RadScriptManager ID="RadScriptManager1" runat="server">
        </telerik:RadScriptManager>
        <telerik:RadFormDecorator ID="RadFormDecorator1" runat="server" 
            Skin="Office2007" />

        <script type="text/javascript">
            function GetRadWindow() {
                var oWindow = null;
                if (window.radWindow) oWindow = window.radWindow;
                else if (window.frameElement.radWindow) oWindow = window.frameElement.radWindow;
                return oWindow;
            }
            
            function populateCityName(arg) {
                var cityName = document.getElementById("cityName");
                cityName.value = arg;
            }

            function AdjustRadWidow() {
                var oWindow = GetRadWindow();
                setTimeout(function () { oWindow.autoSize(true); if ($telerik.isChrome || $telerik.isSafari) ChromeSafariFix(oWindow); }, 500);
            }

            //fix for Chrome/Safari due to absolute positioned popup not counted as part of the content page layout
            function ChromeSafariFix(oWindow) {
                var iframe = oWindow.get_contentFrame();
                var body = iframe.contentWindow.document.body;

                setTimeout(function () {
                    var height = body.scrollHeight;
                    var width = body.scrollWidth;

                    var iframeBounds = $telerik.getBounds(iframe);
                    var heightDelta = height - iframeBounds.height;
                    var widthDelta = width - iframeBounds.width;

                    if (heightDelta > 0) oWindow.set_height(oWindow.get_height() + heightDelta);
                    if (widthDelta > 0) oWindow.set_width(oWindow.get_width() + widthDelta);
                    oWindow.center();

                }, 310);
            }

            function returnToParent() {
                //create the argument that will be returned to the parent page
                var oArg = new Object();

                //get the selected start date from RadDatePicker 
                var startDate = $find("<%= dtpStartDate.ClientID %>");
                oArg.StartDate = startDate.get_selectedDate();

                //get the selected end date from RadDatePicker
                var endDate = $find("<%= dtpEndDate.ClientID %>");
                oArg.EndDate = endDate.get_selectedDate();

                //get a reference to the current RadWindow
                var oWnd = GetRadWindow();




                //Close the RadWindow and send the argument to the parent page
                if (oArg.StartDate && oArg.EndDate) {
                    oWnd.close(oArg);
                }
                else {
                    alert("Please fill both start and end date");
                }
            }
    </script>


        <label for="dtpStartDate">Start Date</label> <br />
        <telerik:RadDatePicker ID="dtpStartDate" runat="server" Culture="id-ID" 
            Skin="Office2007">        
            <Calendar UseRowHeadersAsSelectors="False" UseColumnHeadersAsSelectors="False" 
                ViewSelectorText="x" Skin="Office2007">
            </Calendar>
            <DateInput DisplayDateFormat="dd/MM/yyyy" DateFormat="dd/MM/yyyy">
            </DateInput>
            <DatePopupButton ImageUrl="" HoverImageUrl="">
            </DatePopupButton>    
            <ClientEvents OnPopupOpening="AdjustRadWidow" OnPopupClosing="AdjustRadWidow" />
        </telerik:RadDatePicker>
        <br />
        <label for="dtpEndDate">End Date</label> <br />
        <telerik:RadDatePicker ID="dtpEndDate" runat="server" Culture="id-ID" 
            Skin="Office2007">       
            <Calendar UseRowHeadersAsSelectors="False" UseColumnHeadersAsSelectors="False" 
                ViewSelectorText="x" Skin="Office2007">
            </Calendar>
            <DateInput DisplayDateFormat="dd/MM/yyyy" DateFormat="dd/MM/yyyy">
            </DateInput>
            <DatePopupButton ImageUrl="" HoverImageUrl="">
            </DatePopupButton>
            <ClientEvents OnPopupOpening="AdjustRadWidow" OnPopupClosing="AdjustRadWidow" />
        </telerik:RadDatePicker>
        <br /> <br />        
        <asp:Button ID="cmdSubmit" runat="server" Text="Submit" OnClientClick="returnToParent(); return false;" />
    </div>
    </form>
</body>
</html>
