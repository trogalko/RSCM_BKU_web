<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TransaksiKasAdd.aspx.cs" Inherits="RSCM_BKU_Web.Transaksi.TransaksiKasAdd" %>
<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>
<%@ Register Assembly="Ext.Net" Namespace="Ext.Net" TagPrefix="ext" %>
<%@ Register assembly="DevExpress.Web.v10.2, Version=10.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxPopupControl" tagprefix="dx" %>

<script runat="server">
    
    protected void GetKelompokAnggaranValue(object sender, DirectEventArgs e)
    {
        this.formAdd.Title  = this.cmbKelompokAnggaran.SelectedItem.Value;
    }

    
</script>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<script language="javascript" type="text/javascript">
           function doCloseButtonClick() {
               window.parent.ASPxPopupControl1.Hide();
           }    
</script>

<body>
    <form id="form1" runat="server">
    <div>
        <asp:LinqDataSource ID="LinqDataSource1" runat="server" 
            onselecting="LinqDataSource1_Selecting">
        </asp:LinqDataSource>
        <ext:ResourceManager ID="ResourceManager1" runat="server">
        </ext:ResourceManager>  
        
        <ext:Panel runat="server" Width="900" Height="300">
            <Items>
                <ext:BorderLayout ID="BorderLayout1" runat="server">
                    <West>
                        <ext:FormPanel
                            ID="formAdd" 
                            runat="server" 
                            Title="Detail About Entry"  
                            Width="530px" 
                            Height="300"          
                            Padding="5">
                            <Items>
                                <ext:CompositeField runat="server" FieldLabel="Trans. Number" MsgTarget="Under" >
                                    <Items>
                                        <ext:TextField ID="txtTransNumber" runat="server" Text="{auto}" ReadOnly="true" Icon="Key" Width="100px" />
                                    </Items>
                                </ext:CompositeField>
                                <ext:CompositeField runat="server" FieldLabel="Trans. Date" MsgTarget="Under" >
                                    <Items>
                                        <ext:DateField ID="dateTransDate" runat="server" Icon="Date" AllowBlank="false" Width="200px" />
                                    </Items>
                                </ext:CompositeField>
                                <ext:CompositeField runat="server" FieldLabel="Kelompok Anggaran" MsgTarget="Under" >
                                    <Items>
                                        <ext:ComboBox ID="cmbKelompokAnggaran" runat="server" Icon="Group" AllowBlank="false" Width="400px" MinChars="1" DisplayField="KaCodeName" ValueField="KA_CODE" TriggerAction="All" Grow="True" Editable="False">
                                            <Store>
                                                <ext:Store runat="server" ID="Store1" DataSourceID="LinqDataSource1" AutoLoad="true">
                                                    <Reader>
                                                        <ext:JsonReader IDProperty="KA_CODE" >
                                                            <Fields>
                                                                <ext:RecordField Name="KA_CODE" />
                                                                <ext:RecordField Name="KaCodeName" />
                                                            </Fields>                                            
                                                        </ext:JsonReader>
                                                    </Reader>
                                                </ext:Store>                                
                                            </Store>
                                            <DirectEvents>
                                                <Select OnEvent="GetKelompokAnggaranValue" />
                                            </DirectEvents>
                                        </ext:ComboBox>
                                    </Items>
                                </ext:CompositeField>
                                <ext:CompositeField runat="server" FieldLabel="Description" MsgTarget="Under" >
                                    <Items>
                                        <ext:TextArea ID="txtDescription" runat="server" AllowBlank="false" Width="400px" />
                                    </Items>
                                </ext:CompositeField>
                                <ext:CompositeField runat="server" FieldLabel="Cek/BG Number" >
                                    <Items>
                                        <ext:TextField ID="txtCekNumber" runat="server" Icon="Money" AllowBlank="true" Width="200px" />
                                    </Items>
                                </ext:CompositeField> 
                            </Items>
                        </ext:FormPanel>                         
                    </West>
                    <Center>
                        <ext:Panel
                            ID="FormPanel2" 
                            runat="server" 
                            Title="Amount"  
                            Width="370px" Height="300"
                            Padding="5"> 
                            <Items>
                                <ext:CompositeField runat="server" FieldLabel="Debit Amount" >
                                    <Items>
                                        <ext:NumberField ID="txtDebitAmount" runat="server" Icon="ArrowUp" Width="250px" />
                                    </Items>
                                </ext:CompositeField>
                                <ext:CompositeField runat="server" FieldLabel="Credit Amount" >
                                    <Items>
                                        <ext:NumberField ID="txtCreditAmount" runat="server" Icon="ArrowDown" Width="250px" />
                                    </Items>
                                </ext:CompositeField>    
                            </Items>
                        </ext:Panel>   
                    </Center>
                </ext:BorderLayout>
                
            </Items>
        </ext:Panel>
        <ext:FormPanel ID="FormPanel1" runat="server" Width="900">
                            <Buttons>
                                <ext:Button ID="btnSAVE" Text="SAVE" runat="server" >
                                    <DirectEvents>
                                        <Click OnEvent="Save" Before="return #{formAdd}.isValid();" Success="doCloseButtonClick();" >
                                        </Click>
                                    </DirectEvents>                                    
                                </ext:Button>
                            </Buttons>
                        </ext:FormPanel>
    </div>
    
    </form>
</body>
</html>
