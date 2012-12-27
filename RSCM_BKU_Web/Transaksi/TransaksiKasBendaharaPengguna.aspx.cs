using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Telerik.Web.UI;
using Telerik.Web.Design;
using Telerik.Web.Dialogs;
using EntitySpaces.DynamicQuery;
using EntitySpaces.Core;
using EntitySpaces.Interfaces;
using EntitySpaces.SqlClientProvider;
using Ext.Net;

using RSCM_BKU_Web.Linq;
using RSCM_BKU_Web.BusinessObjects;
using System.Globalization;
using System.Threading;
using System.Reflection;

namespace RSCM_BKU_Web.Transaksi
{
    public partial class TransaksiKas : System.Web.UI.Page
    {
        private RscmBkuDataContext rscm = new RscmBkuDataContext();
        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);
        }

        private List<spGridTransaksiSourceResult> GetGridTransaksiSource()
        {
            if (IsPostBack)
            {
                if (dtpStartDate.IsEmpty)
                    dtpStartDate.SelectedDate = new DateTime(2011, 1, 1);
                if (dtpEndDate.IsEmpty)
                    dtpEndDate.SelectedDate = DateTime.Now;
                List<spGridTransaksiSourceResult> result = rscm.spGridTransaksiSource(dtpStartDate.SelectedDate, dtpEndDate.SelectedDate).ToList<spGridTransaksiSourceResult>();
                return result;
            }
            else
            {
                DateTime start = new DateTime(2011, 1, 1);
                List<spGridTransaksiSourceResult> result = rscm.spGridTransaksiSource(start, DateTime.Now).ToList<spGridTransaksiSourceResult>();
                return result;
            }
        }

        private DataTable Transaksi
        {
            get
            { 
                DateTime startDate;
                DateTime endDate;
                if (!IsPostBack)
                {
                    startDate = new DateTime(2011, 1, 1);
                    endDate = DateTime.Now;
                }
                else
                {
                    if (dtpStartDate.IsEmpty)
                    {
                        startDate = new DateTime(2011, 1, 1);                        
                    }
                    else
                        startDate = dtpStartDate.SelectedDate;
                    if (dtpEndDate.IsEmpty)
                    {
                        endDate = DateTime.Now;                        
                    }
                    else
                        endDate = dtpEndDate.SelectedDate;

                    if (dtpStartDate.SelectedDate > dtpEndDate.SelectedDate)
                    {
                        startDate = dtpEndDate.SelectedDate;
                        endDate = dtpStartDate.SelectedDate;
                    }
                }

                var TransQ = from t in rscm.Trans
                             join kA in rscm.Kel_anggarans on t.KA_CODE equals kA.KA_CODE
                             join kas in rscm.KAs on t.KAS_ID equals kas.KA_CODE
                             where kA.IS_DETAIL == true &&
                             t.TRANS_DATE >= startDate &&
                             t.TRANS_DATE <= endDate &&
                             kA.IS_ACTIVE == true &&
                             kA.KA_LEVEL == "3"
                             orderby t.TRANS_NUMBER
                             select new { t.BKU_ID, t.TRANS_NUMBER, t.TRANS_DATE, t.CEK_BG_NUMBER, t.DEBIT_AMOUNT, t.CREDIT_AMOUNT, t.KA_CODE, kA.KA_NAME, t.DESCRIPT, KAS_NAME = kas.KA_NAME, t.ISVERIFIED, t.IS_CLOSED, t.KAS_ID };
                DataTable dt = new DataTable();
                dt = TransQ.CopyToDataTableCustom();
                return dt;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            string userLoggedIn = (string)HttpContext.Current.Session["UserId"];
            if (!string.IsNullOrEmpty(userLoggedIn))
            {
                var per = from p in rscm.PeriodeAnggarans
                          where p.Is_Closed == false
                          select p;
                foreach (RSCM_BKU_Web.Linq.PeriodeAnggaran pp in per)
                {
                    HttpContext.Current.Session["_periodeId"] = (Int32)pp.id;
                }
            }
            else
                Response.Redirect("~/Login/Login.aspx");

            CultureInfo ci = new CultureInfo("id-ID");
            Thread.CurrentThread.CurrentUICulture = ci;
            ci.NumberFormat.CurrencySymbol = "";
            Thread.CurrentThread.CurrentCulture = ci;
            ci = null;
            this.InitializeCulture();
        }

        protected void RadGrid1_UpdateCommand(object source, Telerik.Web.UI.GridCommandEventArgs e)
        {
            GridEditableItem editedItem = e.Item as GridEditableItem;
            UserControl userControl = (UserControl)e.Item.FindControl(GridEditFormItem.EditFormUserControlID);

            Trans Trans = new Trans();
            if (Trans.LoadByPrimaryKey(Convert.ToInt32((userControl.FindControl("txtTransID") as RadTextBox).Text)))
            {
                try
                {                    
                    Trans.KaCode = (userControl.FindControl("HiddenField1") as HiddenField).Value;
                    Trans.CekBgNumber = (userControl.FindControl("txtCek") as RadTextBox).Text;
                    Trans.DebitAmount = Convert.ToDecimal((userControl.FindControl("txtDebitAmount") as RadNumericTextBox).Value);
                    Trans.CreditAmount = Convert.ToDecimal((userControl.FindControl("txtCreditAmount") as RadNumericTextBox).Value);
                    Trans.Descript = (userControl.FindControl("txtDESC") as RadTextBox).Text;
                    Trans.TransDate = (DateTime)(userControl.FindControl("dtpTransDate") as RadDatePicker).DbSelectedDate;                    
                    Trans.KasId = (userControl.FindControl("HiddenField2") as HiddenField).Value;
                    Trans.UserUpdate = "toro";
                    Trans.TglUpdate = DateTime.Now;
                    Trans.Isverified = false;
                    Trans.IsClosed = false;
                    Trans.Save();
                }
                catch (Exception ex)
                {
                    string es = ex.Message;
                }
                finally
                {
                    RadGrid1.Rebind();
                }
            }
        }

        protected void RadGrid1_PreRender(object sender, EventArgs e)
        {
            if (RadGrid1.EditItems.Count > 0)
            {
                foreach (GridDataItem item in RadGrid1.MasterTableView.Items)
                {
                    if (item != RadGrid1.EditItems[0])
                    {
                        item.Visible = false;
                    }
                }
            }
            if (RadGrid1.MasterTableView.IsItemInserted)
            {
                foreach (GridItem item in RadGrid1.Items)
                {
                    item.Visible = false;
                }
            }
            if (!IsPostBack)
            {
                this.RadGrid1.MasterTableView.Rebind();
            }
        }

        protected void RadGrid1_NeedDataSource(object source, Telerik.Web.UI.GridNeedDataSourceEventArgs e)
        {
            //if (!IsPostBack)
            //{
            //    var TransQ = from t in rscm.Trans
            //                 join kA in rscm.Kel_anggarans on t.KA_CODE equals kA.KA_CODE
            //                 join kas in rscm.KAs on t.KAS_ID equals kas.KA_CODE
            //                 where kA.IS_DETAIL == true &&
            //                 kA.IS_ACTIVE == true &&
            //                 kA.KA_LEVEL == "3"
            //                 orderby t.TRANS_NUMBER
            //                 select new { t.BKU_ID, t.TRANS_NUMBER, t.TRANS_DATE, t.CEK_BG_NUMBER, t.DEBIT_AMOUNT, t.CREDIT_AMOUNT, t.KA_CODE, kA.KA_NAME, t.DESCRIPT, KAS_NAME = kas.KA_NAME, t.ISVERIFIED, t.IS_CLOSED, t.KAS_ID };
            //    RadGrid1.DataSource = TransQ;
            //}
            //else
            //{
            //    DateTime startDate;
            //    DateTime endDate;
            //    if (dtpStartDate.IsEmpty)
            //        startDate = new DateTime(2010, 12, 31);
            //    else
            //        startDate = dtpStartDate.SelectedDate;

            //    if (dtpEndDate.IsEmpty)
            //        endDate = DateTime.Now;
            //    else
            //        endDate = dtpEndDate.SelectedDate;

            //    if (ViewState["GridDataSourcePersistenceMode"] != null)
            //    {
            //        RadGrid1.DataSource = ViewState["GridDataSourcePersistenceMode"];
            //    }
            //    else
            //    {
            //        RadGridTransaksiDataSourceCollection radGridColl = new BusinessObjects.RadGridTransaksiDataSourceCollection();
            //        radGridColl.Query.SelectAll();
            //        radGridColl.Query.Where(radGridColl.Query.TransDate >= startDate & radGridColl.Query.TransDate <= endDate);
            //        radGridColl.Query.OrderBy(radGridColl.Query.TransNumber.Ascending);
            //        radGridColl.Query.Load();
            //        DataTable dt = radGridColl.Query.LoadDataTable();
            //        RadGrid1.DataSource = dt;
            //    }
            //}

            //RadGrid1.DataSource = Transaksi;
            RadGrid1.DataSource = GetGridTransaksiSource();
        }

        protected void RadGrid1_InsertCommand(object source, Telerik.Web.UI.GridCommandEventArgs e)
        {
            GridEditableItem editedItem = e.Item as GridEditableItem;
            UserControl userControl = (UserControl)e.Item.FindControl(GridEditFormItem.EditFormUserControlID);
            DateTime TransDateMonth = DateTime.Now;
            try
            {
                TransDateMonth = (DateTime)(userControl.FindControl("dtpTransDate") as RadDatePicker).DbSelectedDate;
            }
            catch (Exception ex)
            {
                string error = ex.Message;
            }
            int transDateMonth = TransDateMonth.Month;
            //perubahan terakhir, autonumber mengikuti bulan transaksi, bukan bulan berjalan
            //string month = DateTime.Now.Month.ToString().Trim();
            string month = transDateMonth.ToString().Trim();
            string autonumber = "";
            if (month.Length == 1)
                month = ('0' + month).Trim();

            Trans Trans = new Trans();
            //Auto Number
            AutoNumberingQuery anQ = new AutoNumberingQuery();
            anQ.SelectAll();
            anQ.Where(anQ.KaMonth == month, anQ.KaYear == DateTime.Now.Year.ToString().Trim());
            AutoNumberingCollection anColl = new AutoNumberingCollection();

            anColl.Load(anQ);
            //KelAnggaranQuery kaQ = new KelAnggaranQuery();
            //kaQ.SelectAll();
            //kaQ.Where(kaQ.KaCode == (userControl.FindControl("cmbTransCODE") as RadComboBox).SelectedValue.Trim());
            //KelAnggaranCollection kaColl = new KelAnggaranCollection();

            //kaColl.Load(kaQ);            

            if (anColl.Count == 0)
            {
                AutoNumberingCollection anCollection = new AutoNumberingCollection();
                AutoNumbering aN = new AutoNumbering();
                aN = anCollection.AddNew();
                aN.KaYear = DateTime.Now.Year.ToString().Trim();
                aN.KaMonth = month;
                aN.LastNumber = 1;
                aN.PrefixNumber = "000";
                //AutoNumbering an = new AutoNumbering { KaYear = DateTime.Now.Year.ToString().Trim(), KaMonth = month, LastNumber = 1, PrefixNumber = "000" };
                autonumber = String.Format("{0}{1}{2}-0001", autonumber, DateTime.Now.Year.ToString().Trim(), month);
                //an.Save();

                try
                {
                    TransCollection transCollection = new TransCollection();
                    Trans = transCollection.AddNew();
                    //Trans.KaCode = (userControl.FindControl("cmbTransCODE") as RadComboBox).SelectedItem.Value;
                    Trans.KaCode = (userControl.FindControl("HiddenField1") as HiddenField).Value;
                    Trans.TransNumber = autonumber.ToUpper();
                    Trans.CekBgNumber = (userControl.FindControl("txtCek") as RadTextBox).Text;
                    //Trans.Amount = Convert.ToDecimal((userControl.FindControl("txtDebitAmount") as RadNumericTextBox).Value - (userControl.FindControl("txtCreditAmount") as RadNumericTextBox).Value);
                    Trans.DebitAmount = Convert.ToDecimal((userControl.FindControl("txtDebitAmount") as RadNumericTextBox).Value);
                    Trans.CreditAmount = Convert.ToDecimal((userControl.FindControl("txtCreditAmount") as RadNumericTextBox).Value);
                    Trans.Descript = (userControl.FindControl("txtDESC") as RadTextBox).Text;
                    Trans.KasId = (userControl.FindControl("cmbKasID") as RadComboBox).SelectedValue.ToUpper();
                    Trans.TransDate = (DateTime)(userControl.FindControl("dtpTransDate") as RadDatePicker).DbSelectedDate;
                    Trans.UserInsert = "toro";
                    Trans.TglInsert = DateTime.Now;
                    Trans.PeriodId = (Int32)HttpContext.Current.Session["_periodeId"];
                    Trans.Isverified = false;
                    Trans.IsClosed = false;

                    using (esTransactionScope scope = new esTransactionScope())
                    {
                        anCollection.Save();
                        transCollection.Save();
                        scope.Complete();
                    }  
                }
                catch (Exception ex)
                {
                    string es = ex.Message;
                }
                finally
                {
                    RadGrid1.Rebind();
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
                    AutoNumbering anb = new AutoNumbering();
                    AutoNumberingCollection anCollection = new AutoNumberingCollection();
                    anb = anCollection.AddNew();
                    if (anb.LoadByPrimaryKey((long)aa.Id))
                    {
                        anb.LastNumber = aa.LastNumber + 1;                        

                        try
                        {
                            TransCollection transCollection = new TransCollection();
                            Trans = transCollection.AddNew();                            
                            Trans.KaCode = (userControl.FindControl("HiddenField1") as HiddenField).Value;
                            Trans.TransNumber = autonumber.ToUpper();
                            Trans.CekBgNumber = (userControl.FindControl("txtCek") as RadTextBox).Text;                            
                            Trans.DebitAmount = Convert.ToDecimal((userControl.FindControl("txtDebitAmount") as RadNumericTextBox).Value);
                            Trans.CreditAmount = Convert.ToDecimal((userControl.FindControl("txtCreditAmount") as RadNumericTextBox).Value);
                            Trans.Descript = (userControl.FindControl("txtDESC") as RadTextBox).Text;
                            Trans.KasId = (userControl.FindControl("cmbKasID") as RadComboBox).SelectedValue.ToUpper();
                            Trans.TransDate = (DateTime)(userControl.FindControl("dtpTransDate") as RadDatePicker).DbSelectedDate;
                            Trans.UserInsert = "toro";
                            Trans.TglInsert = DateTime.Now;
                            Trans.PeriodId = (Int32)HttpContext.Current.Session["_periodeId"];
                            Trans.Isverified = false;
                            Trans.IsClosed = false;

                            anb.LastNumber = aa.LastNumber + 1;

                            using (esTransactionScope scope = new esTransactionScope())
                            {                                
                                transCollection.Save();
                                scope.Complete();
                            }
                            anb.Save();                            
                        }
                        catch (Exception ex)
                        {
                            string es = ex.Message;
                        }
                        finally
                        {
                            RadGrid1.Rebind();
                        }
                    }
                }

        }

        protected void RadGrid1_EditCommand(object source, GridCommandEventArgs e)
        {
            Session["isEdit"] = true;
        }

        protected void RadGrid1_ItemCommand(object source, GridCommandEventArgs e)
        {
            if (e.CommandName == RadGrid.InitInsertCommandName)
            {
                HttpContext.Current.Session["_isEdit"] = false;
            }
            if (e.CommandName == RadGrid.EditCommandName)
            {
                HttpContext.Current.Session["_isEdit"] = true;
            }
        }

        protected void dtpStartDate_Select(object sender, DirectEventArgs e)
        {
 
        }

        protected void cmdRefreshGrid_Click(object sender, DirectEventArgs e)
        {
            RadGrid1.Rebind();
        }

        protected void btnRefreshGrid_Click(object sender, EventArgs e)
        {
            RadGrid1.Rebind();
        }

        protected void LinqDataSource1_Selecting(object sender, LinqDataSourceSelectEventArgs e)
        {
            if (!IsPostBack)
            {
                var TransQ = from t in rscm.Trans
                             join kA in rscm.Kel_anggarans on t.KA_CODE equals kA.KA_CODE
                             join kas in rscm.KAs on t.KAS_ID equals kas.KA_CODE
                             where kA.IS_DETAIL == true &&
                             kA.IS_ACTIVE == true &&
                             kA.KA_LEVEL == "3"
                             orderby t.TRANS_NUMBER
                             select new { t.BKU_ID, t.TRANS_NUMBER, t.TRANS_DATE, t.CEK_BG_NUMBER, t.DEBIT_AMOUNT, t.CREDIT_AMOUNT, t.KA_CODE, kA.KA_NAME, t.DESCRIPT, KAS_NAME = kas.KA_NAME, t.ISVERIFIED, t.IS_CLOSED, t.KAS_ID };
                e.Result = TransQ;
            }            
        }
    }
}