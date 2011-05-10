<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="RSCM_BKU_Web.Login.Login" %>

<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript">

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
    <style type="text/css">
        .style1
        {
            width: 72px;
        }
        .style2
        {
            width: 4px;
        }
        .style3
        {
            width: 261px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" >
    <telerik:RadScriptManager ID="RadScriptManager1" runat="server">
    </telerik:RadScriptManager>
    <telerik:RadFormDecorator ID="RadFormDecorator1" runat="server" 
        Skin="Office2007" />
    <div style="position: absolute; width: 100%; height: 30%; top: 0%; right: 0%; left: 0%; background-image: url('../gradientreverse.gif'); background-repeat: repeat-x; background-size: 100%">
        
        
    </div>
    <div style="position: absolute; width: 100%; height: 70%; top: 30%; right: 0%; bottom: 0%; left: 0%; background-image: url('../gradient.gif'); background-repeat: repeat-x; background-size: 100%">
        <table style="width: 100%;">
            <tr>
                <td class="style3" 
                    style="width: 30%;">
                    &nbsp;
                </td>
                <td class="style1" style="width: 15%" bgcolor="#CCCCCC">                   
                    User ID</td>
                <td class="style2" style="width: 1%">
                    :
                </td>
                <td style="width: 24%">                    
                    <telerik:RadTextBox ID="txtUserId" 
                        Runat="server" 
                        Width="200px"
                        onkeypress="return CkKeyPress(event);" Skin="Office2007">
                    </telerik:RadTextBox>
                </td>
                <td class="style3" 
                    style="width: 30%;">
                    &nbsp;
                </td>
            </tr>
            <tr>
                <td class="style3" style="width: 30%">
                    &nbsp;
                </td>
                <td class="style1" style="width: 15%" bgcolor="#CCCCCC">                    
                    Password</td>
                <td class="style2" style="width: 1%">
                    :
                </td>
                <td style="width: 24%">                    
                    <telerik:RadTextBox ID="txtPassword" Runat="server" Width="200px" 
                        Skin="Office2007" TextMode="Password">
                    </telerik:RadTextBox>
                </td>
                <td class="style3" style="width: 30%">
                    &nbsp;
                </td>
            </tr>            
        </table>
        <table style="width: 100%;">
            <tr>
                <td align="center">                    
                    <asp:Button ID="Button1" runat="server" Text="Login" onclick="Button1_Click" />
                </td>
                                
            </tr>            
        </table>
    </div>
    </form>
</body>
</html>
