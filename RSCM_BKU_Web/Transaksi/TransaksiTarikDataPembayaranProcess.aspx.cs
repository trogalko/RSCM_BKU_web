using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RSCM_BKU_Web.BusinessObjects;
using System.Data;
using Ext.Net;
using EntitySpaces.Interfaces;

namespace RSCM_BKU_Web.Transaksi
{
    public partial class TransaksiTarikDataPembayaranProcess : System.Web.UI.Page
    {
        private string invoiceNo = "1";
        private DataTable dtKa;
        private DataTable dtKas;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["invoiceno"] == null)
            {
                X.AddScript("parentAutoLoadControl.close();");                
            }
            invoiceNo = Request.QueryString["invoiceno"].ToString().Trim();

            this.storeKa.DataSource = this.GetDataTableKA();
            this.storeKas.DataSource = this.GetDataTableKas();
            this.storeKa.DataBind();
            this.storeKas.DataBind();

            try
            {
                InvoiceSupplierCollection iSC = new InvoiceSupplierCollection();
                iSC.es.Connection.Name = "KENCANA";
                InvoiceSupplierQuery isQ = new InvoiceSupplierQuery("a");
                isQ.es2.Connection.Name = "KENCANA";
                InvoiceSupplierItemQuery isiQ = new InvoiceSupplierItemQuery("b");
                isiQ.es2.Connection.Name = "KENCANA";
                SupplierQuery sQ = new SupplierQuery("c");
                sQ.es2.Connection.Name = "KENCANA";
                isQ.Select(
                isQ.InvoiceNo, sQ.SupplierName, isQ.InvoiceNotes,isQ.InvoiceDate, isiQ.TransactionNo.As("NO_POR"), isiQ.VerifyAmount, isiQ.PaymentAmount, isiQ.BankAccountNo.As("NO_BG"), isiQ.PPnAmount,
                isiQ.PPh22Amount, isiQ.PPh23Amount, isQ.Isproces)
                .InnerJoin(isiQ).On(isiQ.InvoiceNo == isQ.InvoiceNo)
                .InnerJoin(sQ).On(sQ.SupplierID == isQ.SupplierID)
                .Where((isQ.Isproces == false || isQ.Isproces.IsNull()) && isQ.InvoiceNo == invoiceNo);
                isQ.es.Top = 1;
                iSC.Load(isQ);
                if (iSC.Count > 0)
                {
                    foreach (InvoiceSupplier InvSup in iSC)
                    {
                        decimal? tmp = 0;
                        decimal PaymentAmount = 0;
                        decimal PPnAmount = 0;
                        decimal PPh22Amount = 0;
                        decimal PPh23Amount = 0;                                               

                        txtTransInvoiceNo.Text = invoiceNo;
                        txtPpnInvoiceNo.Text = invoiceNo;
                        txtPphInvoiceNo.Text = invoiceNo;
                        txtTransInvoiceNote.Text = InvSup.InvoiceNotes;
                        txtPPhInvoiceNote.Text = InvSup.InvoiceNotes;
                        txtPPnInvoiceNote.Text = InvSup.InvoiceNotes;
                        dfTransInvoiceDate.SelectedDate = (DateTime)InvSup.InvoiceDate;
                        dfPPnInvoiceDate.SelectedDate = (DateTime)InvSup.InvoiceDate;
                        dfPPhInvoiceDate.SelectedDate = (DateTime)InvSup.InvoiceDate;
                        tmp = (decimal?) InvSup.GetColumn(InvoiceSupplierItemMetadata.ColumnNames.PaymentAmount);
                        if (tmp == null)
                            PaymentAmount = 0;
                        else
                            PaymentAmount = (decimal)tmp;
                        tmp = (decimal?)InvSup.GetColumn(InvoiceSupplierItemMetadata.ColumnNames.PPnAmount);
                        if (tmp == null)
                            PPnAmount = 0;
                        else
                            PPnAmount = (decimal)tmp;
                        tmp = (decimal?)InvSup.GetColumn(InvoiceSupplierItemMetadata.ColumnNames.PPh22Amount);
                        if (tmp == null)
                            PPh22Amount = 0;
                        else
                            PPh22Amount = (decimal)tmp;
                        tmp = (decimal?)InvSup.GetColumn(InvoiceSupplierItemMetadata.ColumnNames.PPh23Amount);
                        if (tmp == null)
                            PPh23Amount = 0;
                        else
                            PPh23Amount = (decimal)tmp;
                        //txtTransCreditAmount.Text = PaymentAmount.ToString();
                        txtTransDebitAmount.Text = PaymentAmount.ToString();
                        txtPPnCreditAmount.Text = PPnAmount.ToString();

                        if (PPh22Amount > PPh23Amount && PPh23Amount <= 0)
                        {
                            txtPPhCreditAmount.Text = PPh22Amount.ToString();
                            chkPPh22.Checked = true;
                        }
                        if (PPh23Amount > PPh22Amount && PPh22Amount <= 0)
                        {
                            txtPPhCreditAmount.Text = PPh23Amount.ToString();
                            chkPPh22.Checked = false;
                        }

                        txtTransBG.Text = (string)InvSup.GetColumn("BG");
                        txtPPnBG.Text = (string)InvSup.GetColumn("BG");
                        txtPPhBG.Text = (string)InvSup.GetColumn("BG");
                        txtTransSupplierName.Text = (string)InvSup.GetColumn(SupplierMetadata.ColumnNames.SupplierName);
                        txtPPnSupplierName.Text = (string)InvSup.GetColumn(SupplierMetadata.ColumnNames.SupplierName);
                        txtPPhSupplierName.Text = (string)InvSup.GetColumn(SupplierMetadata.ColumnNames.SupplierName);
                    }
                }


                //InvoiceSupplier iS = new InvoiceSupplier();
                //iS.es.Connection.Name = "KENCANA";
                //if (iS.LoadByPrimaryKey(invoiceNo))
                //{
                //    txtTransInvoiceNo.Text = invoiceNo;
                //    txtPpnInvoiceNo.Text = invoiceNo;
                //    txtPphInvoiceNo.Text = invoiceNo;
                //    txtTransInvoiceNote.Text = iS.InvoiceNotes;
                //    dfTransInvoiceDate.SelectedDate = (DateTime) iS.InvoiceDate;
                     
                //}
            }
            catch (Exception ex)
            {
                string error = ex.Message;
            }
        }

        protected void storeKa_RefreshData(object sender, StoreRefreshDataEventArgs e)
        {
            this.storeKa.DataSource = this.GetDataTableKA();
            this.storeKa.DataBind();
        }

        protected void storeKas_RefreshData(object sender, StoreRefreshDataEventArgs e)
        {
            this.storeKas.DataSource = this.GetDataTableKas();
            this.storeKas.DataBind();
        }

        private DataTable GetDataTableKA()
        {
            KelAnggaranQuery kaQ = new KelAnggaranQuery();
            kaQ.es2.Connection.Name = "LIVE";
            kaQ.Select(kaQ.KaCode, kaQ.KaName);
            kaQ.Where(kaQ.KaLevel == 3);
            dtKa = kaQ.LoadDataTable();            
            return dtKa;
        }

        private DataTable GetDataTableKas()
        {
            KasQuery kaQ = new KasQuery();            
            kaQ.es2.Connection.Name = "LIVE";
            kaQ.Select(kaQ.KaCode, kaQ.KaName);            
            dtKas = kaQ.LoadDataTable();            
            return dtKas;
        }

        [DirectMethod]
        public void SaveData()
        {
            //Validasi
            if (string.IsNullOrEmpty(txtTransInvoiceNo.Text) || string.IsNullOrEmpty(cmbTransKa.SelectedItem.Value)
                || string.IsNullOrEmpty(txtTransInvoiceNote.Text) || string.IsNullOrEmpty(dfTransInvoiceDate.SelectedDate.ToShortDateString())
                || string.IsNullOrEmpty(cmbTransKasId.SelectedItem.Value))
            {
                X.Msg.Alert("Error on Transaction Tab", "Please fill neccessary field").Show();
                return;
            }
            if (string.IsNullOrEmpty(txtPpnInvoiceNo.Text) || string.IsNullOrEmpty(cmbPPnKa.SelectedItem.Value)
                || string.IsNullOrEmpty(txtPPnInvoiceNote.Text) || string.IsNullOrEmpty(dfPPnInvoiceDate.SelectedDate.ToShortDateString())
                || string.IsNullOrEmpty(cmbPPnKas.SelectedItem.Value))
            {
                X.Msg.Alert("Error on PPN Tab", "Please fill neccessary field").Show();
                return;
            }
            if (string.IsNullOrEmpty(txtPphInvoiceNo.Text) || string.IsNullOrEmpty(cmbPPhKa.SelectedItem.Value)
                || string.IsNullOrEmpty(txtPPhInvoiceNote.Text) || string.IsNullOrEmpty(dfPPhInvoiceDate.SelectedDate.ToShortDateString())
                || string.IsNullOrEmpty(cmbPPhKas.SelectedItem.Value))
            {
                X.Msg.Alert("Error on PPh Tab", "Please fill neccessary field").Show();
                return;
            }

            // Save Transaksi ke Tabel Trans RSCM_BKU
            int transMonth = dfTransInvoiceDate.SelectedDate.Month;
            string month = transMonth.ToString().Trim();
            if (month.Length == 1)
                month = "0" + month;
            string year = dfTransInvoiceDate.SelectedDate.Year.ToString().Trim();            
            string autonumber = string.Empty;

            Trans Trans = new Trans();
            Trans.es.Connection.Name = "LIVE";
            //Auto Number 
            AutoNumberingQuery anQ = new AutoNumberingQuery();
            anQ.es2.Connection.Name = "LIVE";
            anQ.SelectAll();
            anQ.Where(anQ.KaMonth == month, anQ.KaYear == year);
            AutoNumberingCollection anColl = new AutoNumberingCollection();

            anColl.Load(anQ);

            decimal DebitAmount = 0;
            decimal CreditAmount = 0;

            if (anColl.Count == 0)
            {
                AutoNumbering aN = new AutoNumbering();
                aN.es.Connection.Name = "LIVE";                
                aN.KaYear = DateTime.Now.Year.ToString().Trim();
                aN.KaMonth = month;
                aN.LastNumber = 3;
                aN.PrefixNumber = "000";
                //AutoNumbering an = new AutoNumbering { KaYear = DateTime.Now.Year.ToString().Trim(), KaMonth = month, LastNumber = 1, PrefixNumber = "000" };
                autonumber = String.Format("{0}{1}{2}-0001", autonumber, DateTime.Now.Year.ToString().Trim(), month);
                //an.Save();
                string autonumberPpn = String.Format("{0}{1}{2}-0002", string.Empty, DateTime.Now.Year.ToString().Trim(), month);
                string autonumberPph = String.Format("{0}{1}{2}-0003", string.Empty, DateTime.Now.Year.ToString().Trim(), month);
                aN.Save();
                try
                {
                    //Transaksi                                       
                    Trans.KaCode = cmbTransKa.SelectedItem.Value;
                    Trans.TransNumber = autonumber.ToUpper();
                    Trans.CekBgNumber = txtTransBG.Text;
                    if (string.IsNullOrEmpty(txtTransDebitAmount.Text.Trim()))
                        DebitAmount = 0;
                    else
                    {
                        if (!decimal.TryParse(txtTransDebitAmount.Text.Trim(),out DebitAmount))
                            DebitAmount = 0;
                    }
                    if (string.IsNullOrEmpty(txtTransCreditAmount.Text.Trim()))
                        CreditAmount = 0;
                    else
                    {
                        if (!decimal.TryParse(txtTransCreditAmount.Text.Trim(), out CreditAmount))
                            CreditAmount = 0;
                    }

                    Trans.DebitAmount = DebitAmount;
                    Trans.CreditAmount = CreditAmount;
                    Trans.Descript = txtTransInvoiceNo.Text + " - " + txtTransInvoiceNote.Text;
                    Trans.KasId = cmbTransKasId.SelectedItem.Value;
                    Trans.TransDate = dfTransInvoiceDate.SelectedDate;
                    Trans.UserInsert = (string)HttpContext.Current.Session["UserId"];
                    Trans.TglInsert = DateTime.Now;
                    Trans.PeriodId = (Int32)HttpContext.Current.Session["_periodeId"];
                    //Trans.PeriodId = 1;
                    Trans.Isverified = false;
                    Trans.IsClosed = false;
                    Trans.Save();

                    
                    //PPn
                    Trans TransPpn = new Trans();                    
                    TransPpn.es.Connection.Name = "LIVE"; 
                    
                    TransPpn.KaCode = cmbPPnKa.SelectedItem.Value;
                    TransPpn.TransNumber = autonumberPpn.ToUpper();
                    TransPpn.CekBgNumber = txtPPnBG.Text;
                    if (string.IsNullOrEmpty(txtPPnDebitAmount.Text.Trim()))
                        DebitAmount = 0;
                    else
                    {
                        if (!decimal.TryParse(txtPPnDebitAmount.Text.Trim(), out DebitAmount))
                            DebitAmount = 0;
                    }
                    if (string.IsNullOrEmpty(txtPPnCreditAmount.Text.Trim()))
                        CreditAmount = 0;
                    else
                    {
                        if (!decimal.TryParse(txtPPnCreditAmount.Text.Trim(), out CreditAmount))
                            CreditAmount = 0;
                    }
                    TransPpn.DebitAmount = DebitAmount;
                    TransPpn.CreditAmount = CreditAmount;
                    TransPpn.Descript = "Terima PPN dari " + txtPPnSupplierName.Text;
                    TransPpn.KasId = cmbPPnKas.SelectedItem.Value;
                    TransPpn.TransDate = dfPPnInvoiceDate.SelectedDate;
                    TransPpn.UserInsert = (string)HttpContext.Current.Session["UserId"];
                    TransPpn.TglInsert = DateTime.Now;
                    TransPpn.PeriodId = (Int32)HttpContext.Current.Session["_periodeId"];
                    //TransPpn.PeriodId = 1;
                    TransPpn.Isverified = false;
                    TransPpn.IsClosed = false;
                    TransPpn.Save();
                    
                    //PPh
                    Trans TransPph = new Trans(); 
                    TransPph.es.Connection.Name = "LIVE";
                    TransPph.KaCode = cmbPPhKa.SelectedItem.Value;
                    TransPph.TransNumber = autonumberPph.ToUpper();
                    TransPph.CekBgNumber = txtPPhBG.Text;
                    if (string.IsNullOrEmpty(txtPPhDebitAmount.Text.Trim()))
                        DebitAmount = 0;
                    else
                    {
                        if (!decimal.TryParse(txtPPhDebitAmount.Text.Trim(), out DebitAmount))
                            DebitAmount = 0;
                    }
                    if (string.IsNullOrEmpty(txtPPhCreditAmount.Text.Trim()))
                        CreditAmount = 0;
                    else
                    {
                        if (!decimal.TryParse(txtPPhCreditAmount.Text.Trim(), out CreditAmount))
                            CreditAmount = 0;
                    }
                    TransPph.DebitAmount = DebitAmount;
                    TransPph.CreditAmount = CreditAmount;
                    if (chkPPh22.Checked)
                        TransPph.Descript = "Terima PPh 22 dari " + txtPPhSupplierName.Text;
                    else
                        TransPph.Descript = "Terima PPh 23 dari " + txtPPhSupplierName.Text;
                    TransPph.KasId = cmbPPhKas.SelectedItem.Value;
                    TransPph.TransDate = dfPPhInvoiceDate.SelectedDate;
                    TransPph.UserInsert = (string)HttpContext.Current.Session["UserId"];
                    TransPph.TglInsert = DateTime.Now;
                    TransPph.PeriodId = (Int32)HttpContext.Current.Session["_periodeId"];
                    //TransPph.PeriodId = 1;
                    TransPph.Isverified = false;
                    TransPph.IsClosed = false;
                    TransPph.Save();                    
                }
                catch (Exception ex)
                {
                    X.Msg.Alert("Error", ex.Message).Show();
                }                
            }
            else
                foreach (AutoNumbering aa in anColl)
                {
                    string i = (aa.LastNumber + 1).ToString().Trim();
                    if (i.Length == 1)
                        autonumber = String.Format("{0}{1}{2}-000{3}", autonumber, aa.KaYear, aa.KaMonth, i);
                    if (i.Length == 2)
                        autonumber = String.Format("{0}{1}{2}-00{3}", autonumber, aa.KaYear, aa.KaMonth, i);
                    if (i.Length == 3)
                        autonumber = String.Format("{0}{1}{2}-0{3}", autonumber, aa.KaYear, aa.KaMonth, i);
                    if (i.Length == 4)
                        autonumber = String.Format("{0}{1}{2}-{3}", autonumber, aa.KaYear, aa.KaMonth, i);

                    string j = (aa.LastNumber + 2).ToString().Trim();
                    string autonumberPPn = string.Empty; 
                    if (j.Length == 1)
                        autonumberPPn = String.Format("{0}{1}{2}-000{3}", autonumberPPn, aa.KaYear, aa.KaMonth, j);
                    if (j.Length == 2)
                        autonumberPPn = String.Format("{0}{1}{2}-00{3}", autonumberPPn, aa.KaYear, aa.KaMonth, j);
                    if (j.Length == 3)
                        autonumberPPn = String.Format("{0}{1}{2}-0{3}", autonumberPPn, aa.KaYear, aa.KaMonth, j);
                    if (j.Length == 4)
                        autonumberPPn = String.Format("{0}{1}{2}-{3}", autonumberPPn, aa.KaYear, aa.KaMonth, j);

                    string k = (aa.LastNumber + 3).ToString().Trim();
                    string autonumberPPh = string.Empty; 
                    if (k.Length == 1)
                        autonumberPPh = String.Format("{0}{1}{2}-000{3}", autonumberPPh, aa.KaYear, aa.KaMonth, k);
                    if (k.Length == 2)
                        autonumberPPh = String.Format("{0}{1}{2}-00{3}", autonumberPPh, aa.KaYear, aa.KaMonth, k);
                    if (k.Length == 3)
                        autonumberPPh = String.Format("{0}{1}{2}-0{3}", autonumberPPh, aa.KaYear, aa.KaMonth, k);
                    if (k.Length == 4)
                        autonumberPPh = String.Format("{0}{1}{2}-{3}", autonumberPPh, aa.KaYear, aa.KaMonth, k);

                    AutoNumbering anb = new AutoNumbering();
                    anb.es.Connection.Name = "LIVE";                    
                    if (anb.LoadByPrimaryKey((long)aa.Id))
                    {
                        anb.LastNumber = aa.LastNumber + 3;

                        try
                        {
                            //Transaksi                            
                            Trans.KaCode = cmbTransKa.SelectedItem.Value;
                            Trans.TransNumber = autonumber.ToUpper();
                            Trans.CekBgNumber = txtTransBG.Text;
                            if (string.IsNullOrEmpty(txtTransDebitAmount.Text.Trim()))
                                DebitAmount = 0;
                            else
                            {
                                if (!decimal.TryParse(txtTransDebitAmount.Text.Trim(), out DebitAmount))
                                    DebitAmount = 0;
                            }
                            if (string.IsNullOrEmpty(txtTransCreditAmount.Text.Trim()))
                                CreditAmount = 0;
                            else
                            {
                                if (!decimal.TryParse(txtTransCreditAmount.Text.Trim(), out CreditAmount))
                                    CreditAmount = 0;
                            }

                            Trans.DebitAmount = DebitAmount;
                            Trans.CreditAmount = CreditAmount;
                            Trans.Descript = txtTransInvoiceNo.Text + " - " + txtTransInvoiceNote.Text;
                            Trans.KasId = cmbTransKasId.SelectedItem.Value;
                            Trans.TransDate = dfTransInvoiceDate.SelectedDate;
                            Trans.UserInsert = (string)HttpContext.Current.Session["UserId"];
                            Trans.TglInsert = DateTime.Now;
                            Trans.PeriodId = (Int32)HttpContext.Current.Session["_periodeId"];
                            //Trans.PeriodId = 1;
                            Trans.Isverified = false;
                            Trans.IsClosed = false;
                            Trans.Save();

                            //PPn
                            Trans TransPpn = new BusinessObjects.Trans();
                            TransPpn.es.Connection.Name = "LIVE";
                            
                            TransPpn.KaCode = cmbPPnKa.SelectedItem.Value;
                            TransPpn.TransNumber = autonumberPPn.ToUpper();
                            TransPpn.CekBgNumber = txtPPnBG.Text;
                            if (string.IsNullOrEmpty(txtPPnDebitAmount.Text.Trim()))
                                DebitAmount = 0;
                            else
                            {
                                if (!decimal.TryParse(txtPPnDebitAmount.Text.Trim(), out DebitAmount))
                                    DebitAmount = 0;
                            }
                            if (string.IsNullOrEmpty(txtPPnCreditAmount.Text.Trim()))
                                CreditAmount = 0;
                            else
                            {
                                if (!decimal.TryParse(txtPPnCreditAmount.Text.Trim(), out CreditAmount))
                                    CreditAmount = 0;
                            }
                            TransPpn.DebitAmount = DebitAmount;
                            TransPpn.CreditAmount = CreditAmount;
                            TransPpn.Descript = "Terima PPN dari " + txtPPnSupplierName.Text;
                            TransPpn.KasId = cmbPPnKas.SelectedItem.Value;
                            TransPpn.TransDate = dfPPnInvoiceDate.SelectedDate;
                            TransPpn.UserInsert = (string)HttpContext.Current.Session["UserId"];
                            TransPpn.TglInsert = DateTime.Now;
                            TransPpn.PeriodId = (Int32)HttpContext.Current.Session["_periodeId"];
                            //TransPpn.PeriodId = 1;
                            TransPpn.Isverified = false;
                            TransPpn.IsClosed = false;
                            TransPpn.Save();

                            //PPh
                            BusinessObjects.Trans TransPPh = new BusinessObjects.Trans();
                            TransPPh.es.Connection.Name = "LIVE";
                            
                            TransPPh.KaCode = cmbPPhKa.SelectedItem.Value;
                            TransPPh.TransNumber = autonumberPPh.ToUpper();
                            TransPPh.CekBgNumber = txtPPhBG.Text;
                            if (string.IsNullOrEmpty(txtPPhDebitAmount.Text.Trim()))
                                DebitAmount = 0;
                            else
                            {
                                if (!decimal.TryParse(txtPPhDebitAmount.Text.Trim(), out DebitAmount))
                                    DebitAmount = 0;
                            }
                            if (string.IsNullOrEmpty(txtPPhCreditAmount.Text.Trim()))
                                CreditAmount = 0;
                            else
                            {
                                if (!decimal.TryParse(txtPPhCreditAmount.Text.Trim(), out CreditAmount))
                                    CreditAmount = 0;
                            }
                            TransPPh.DebitAmount = DebitAmount;
                            TransPPh.CreditAmount = CreditAmount;
                            if (chkPPh22.Checked)
                                TransPPh.Descript = "Terima PPh 22 dari " + txtPPhSupplierName.Text;
                            else
                                TransPPh.Descript = "Terima PPh 23 dari " + txtPPhSupplierName.Text;
                            TransPPh.KasId = cmbPPnKas.SelectedItem.Value;
                            TransPPh.TransDate = dfPPnInvoiceDate.SelectedDate;
                            TransPPh.UserInsert = (string)HttpContext.Current.Session["UserId"];
                            TransPPh.TglInsert = DateTime.Now;
                            TransPPh.PeriodId = (Int32)HttpContext.Current.Session["_periodeId"];
                            //TransPPh.PeriodId = 1;
                            TransPPh.Isverified = false;
                            TransPPh.IsClosed = false;
                            TransPPh.Save();

                            anb.LastNumber = aa.LastNumber + 3;
                            anb.Save();
                        }
                        catch (Exception ex)
                        {
                            X.Msg.Alert("Error", ex.Message).Show();
                        }                        
                    }
                }
            //Save PPn ke Tabel Trans RSCM_BKU


            InvoiceSupplier inSu = new InvoiceSupplier();
            inSu.es.Connection.Name = "KENCANA";
            if (inSu.LoadByPrimaryKey(invoiceNo))
            {
                inSu.Isproces = true;
                inSu.Save();
            }
            HttpContext.Current.Session["isProcess"] = true;
            X.AddScript("parentAutoLoadControl.close();");            
        }
    }
}