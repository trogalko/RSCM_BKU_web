<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TransaksiKasAdd.aspx.cs" Inherits="RSCM_BKU_Web.Transaksi.TransaksiKasAdd" %>

<%@ Register Assembly="Ext.Net" Namespace="Ext.Net" TagPrefix="ext" %>

<%@ Register assembly="DevExpress.Web.v10.2, Version=10.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxPopupControl" tagprefix="dx" %>

<script runat="server">
    
</script>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <ext:ResourceManager ID="ResourceManager1" runat="server">
        </ext:ResourceManager>  
        
        <ext:FormPanel
            ID="formAdd" 
            runat="server" 
            Title="Add Transaksi Kas"  
            Width="700px"           
            Padding="5" 
            DefaultAnchor="0" >
            <Items>
                <ext:CompositeField runat="server" MsgTarget="Side" >
                    <Items>
                        <ext:TextField ID="txtTransNumber" runat="server" FieldLabel="Trans. Number" Text="{auto}" ReadOnly="true" Icon="Key" Width="100px" />
                        <ext:DateField ID="dateTransDate" runat="server" FieldLabel="Trans. Date" Icon="Date" AllowBlank="false" Width="200px" />
                        <ext:ComboBox ID="cmbKelompokAnggaran" runat="server" FieldLabel="Kelompok Anggaran" Icon="Group" AllowBlank="false" Width="400px" />
                        <ext:TextField ID="txtDescription" runat="server" FieldLabel="Description" Icon="Note" AllowBlank="false" Width="550px" />
                        <ext:TextField ID="txtCekNumber" runat="server" FieldLabel="Cek/BG Number" Icon="Money" AllowBlank="false" Width="200px" />
                        <ext:NumberField ID="txtDebitAmount" runat="server" FieldLabel="Debit Amount" Icon="PictureDelete" AllowBlank="false" Width="200px" />
                        <ext:NumberField ID="txtCreditAmount" runat="server" FieldLabel="Credit Amount" Icon="PictureAdd" AllowBlank="false" Width="200px" />
                    </Items>
                </ext:CompositeField>
            </Items>
            <Buttons>
                <ext:Button ID="btnSave" Text="SAVE" runat="server">
                </ext:Button>
                <ext:Button ID="btnCancel" Text="CANCEL" runat="server">
                </ext:Button>
            </Buttons>
        </ext:FormPanel> 
    </div>
    
    </form>
</body>
</html>
