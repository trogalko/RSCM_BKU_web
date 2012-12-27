using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using EntitySpaces.Interfaces;
using RSCM_BKU_Web.BusinessObjects;

namespace RSCM_BKU_Web.Transaksi
{
    public partial class TransaksiKasBendaharaPenggunaCUD : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //Load DataSource buat combo Kelompok Anggaran                
                ViewKelAnggaranCodeCombineNameCollection vkaccnc = new ViewKelAnggaranCodeCombineNameCollection();
                vkaccnc.LoadAll();
                cmbTransCode.DataSource = vkaccnc;
                cmbTransCode.DataTextField = "KaCodeName";
                cmbTransCode.DataValueField = "KaCode";
                cmbTransCode.DataBind();
                //Load DataSource buat combo Kas            
                KasCollection kasCollection = new KasCollection();
                kasCollection.LoadAll();
                cmbKasID.DataSource = kasCollection;
                cmbKasID.DataTextField = "KaName";
                cmbKasID.DataValueField = "KaCode";
                cmbKasID.DataBind();
                if (Request.QueryString["BKU_ID"] != null)
                {
                    
                        long BkuID = 0;
                        if (long.TryParse(Request.QueryString["BKU_ID"], out BkuID))
                        {
                            Trans trans = new Trans();
                            if (trans.LoadByPrimaryKey(BkuID))
                            {
                                txtTransID.Text = trans.BkuId.ToString();
                                txtTransNumber.Text = trans.TransNumber;
                                dtpTransDate.SelectedDate = (DateTime)trans.TransDate;
                                cmbTransCode.SelectedValue = trans.KaCode;
                                cmbKasID.SelectedValue = trans.KasId;
                                txtDescription.Text = trans.Descript;
                                txtCekBG.Text = trans.CekBgNumber;
                                txtDebitAmount.Text = trans.DebitAmount.ToString();
                                txtCreditAmount.Text = trans.CreditAmount.ToString();
                            }
                        }
                    
                }
                else
                    txtTransNumber.Text = "{AUTO}";
            }
        }

        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);

            if (Request.QueryString["BKU_ID"] == null)
            {
                this.Page.Title = "ADD TRANSAKSI";
            }
            else
            {
                this.Page.Title = "EDIT TRANSAKSI";
            }
        }

        protected void cmdSave_Click(object sender, EventArgs e)
        {
            //ADD
            Trans trans = new Trans();
            string Descript = txtDescription.Text;
            string CreditAmoun = txtCreditAmount.Text;
            if (Request.QueryString["BKU_ID"] == null)
            {
                int TransDateMonth = ((DateTime)dtpTransDate.SelectedDate).Month;
                string month = TransDateMonth.ToString().Trim();
                string autonumber = "";
                if (month.Length == 1)
                    month = ('0' + month).Trim();

                //Trans Trans = new Trans();
                //Auto Number
                AutoNumberingQuery anQ = new AutoNumberingQuery();
                anQ.SelectAll();
                anQ.Where(anQ.KaMonth == month, anQ.KaYear == DateTime.Now.Year.ToString().Trim());
                AutoNumberingCollection anColl = new AutoNumberingCollection();
                anColl.Load(anQ);
                //New month, new autonumber
                if (anColl.Count == 0)
                {
                    AutoNumberingCollection anCollection = new AutoNumberingCollection();
                    AutoNumbering aN = new AutoNumbering();
                    aN = anCollection.AddNew();
                    aN.KaYear = DateTime.Now.Year.ToString().Trim();
                    aN.KaMonth = month;
                    aN.LastNumber = 1;
                    aN.PrefixNumber = "000";
                    autonumber = String.Format("{0}{1}{2}-0001", autonumber, DateTime.Now.Year.ToString().Trim(), month);
                    try
                    {
                        Decimal DebitAmount = 0;
                        Decimal CreditAmount = 0;
                        TransCollection transColl = new TransCollection();
                        trans = transColl.AddNew();
                        trans.TransNumber = autonumber.ToUpper();
                        trans.KaCode = cmbTransCode.SelectedValue;
                        trans.TransDate = dtpTransDate.SelectedDate;
                        trans.KasId = cmbKasID.SelectedValue;
                        trans.Descript = txtDescription.Text;
                        trans.CekBgNumber = txtCekBG.Text;
                        if (Decimal.TryParse(txtDebitAmount.Text, out DebitAmount))
                            trans.DebitAmount = DebitAmount;
                        else
                            trans.DebitAmount = 0;
                        if (Decimal.TryParse(txtCreditAmount.Text, out CreditAmount))
                            trans.CreditAmount = CreditAmount;
                        else
                            trans.CreditAmount = 0;
                        trans.UserInsert = HttpContext.Current.Session["UserId"].ToString();
                        trans.TglInsert = DateTime.Now;
                        trans.Isverified = false;
                        trans.IsClosed = false;
                        trans.PeriodId = (Int32)HttpContext.Current.Session["_periodeId"];

                        using (esTransactionScope scope = new esTransactionScope())
                        {
                            anCollection.Save();
                            transColl.Save();
                            scope.Complete();
                        }
                    }
                    catch (Exception ex)
                    {
                        string es = ex.Message;
                    }
                }
                // If month already exist, increment autonumber
                else
                {
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
                                Decimal DebitAmount = 0;
                                Decimal CreditAmount = 0;
                                TransCollection transColl = new TransCollection();
                                trans = transColl.AddNew();
                                trans.TransNumber = autonumber.ToUpper();
                                trans.KaCode = cmbTransCode.SelectedValue;
                                trans.TransDate = dtpTransDate.SelectedDate;
                                trans.KasId = cmbKasID.SelectedValue;
                                trans.CekBgNumber = txtCekBG.Text;
                                trans.KasId = cmbKasID.SelectedValue;
                                trans.Descript = txtDescription.Text;
                                if (Decimal.TryParse(txtDebitAmount.Text, out DebitAmount))
                                    trans.DebitAmount = DebitAmount;
                                else
                                    trans.DebitAmount = 0;
                                if (Decimal.TryParse(txtCreditAmount.Text, out CreditAmount))
                                    trans.CreditAmount = CreditAmount;
                                else
                                    trans.CreditAmount = 0;
                                trans.PeriodId = (Int32)HttpContext.Current.Session["_periodeId"];
                                trans.Isverified = false;
                                trans.IsClosed = false;
                                trans.UserInsert = HttpContext.Current.Session["UserId"].ToString();
                                trans.TglInsert = DateTime.Now;

                                anb.LastNumber = aa.LastNumber + 1;

                                using (esTransactionScope scope = new esTransactionScope())
                                {
                                    transColl.Save();
                                    anb.Save();
                                    scope.Complete();
                                }
                                //anb.Save();
                            }
                            catch (Exception ex)
                            {
                                string es = ex.Message;
                            }
                        }
                    }
                }
            }
            //EDIT
            else
            {
                long bkuID = 0;
                Decimal DebitAmount = 0;
                Decimal CreditAmount = 0;
                try
                {
                    if (long.TryParse(txtTransID.Text, out bkuID))
                    {
                        if (trans.LoadByPrimaryKey(bkuID))
                        {
                            trans.TransDate = dtpTransDate.SelectedDate;
                            trans.KaCode = cmbTransCode.SelectedItem.Value;
                            trans.KasId = cmbKasID.SelectedItem.Value;
                            trans.Descript = Descript;
                            trans.CekBgNumber = txtCekBG.Text;
                            if (Decimal.TryParse(txtDebitAmount.Text, out DebitAmount))
                                trans.DebitAmount = DebitAmount;
                            else
                                trans.DebitAmount = 0;
                            if (Decimal.TryParse(txtCreditAmount.Text, out CreditAmount))
                                trans.CreditAmount = CreditAmount;
                            else
                                trans.CreditAmount = 0;
                            trans.UserUpdate = HttpContext.Current.Session["UserId"].ToString();
                            trans.TglUpdate = DateTime.Now;
                            trans.Save();
                        }
                    }
                }
                catch (Exception ex)
                {
                    string es = ex.Message;
                }
            }
            if (Request.QueryString["BKU_ID"] != null)
            {
                ClientScript.RegisterStartupScript(Page.GetType(), "mykey", "CloseAndRebind('navigateAndRebind');", true);
                HttpContext.Current.Session["CUDMode"] = "1"; // EDIT
            }
            else
            {
                ClientScript.RegisterStartupScript(Page.GetType(), "mykey", "CloseAndRebind();", true);
                HttpContext.Current.Session["CUDMode"] = "0"; //ADD
            }
        }

        protected void cmdCancel_Click(object sender, EventArgs e)
        {
            RequiredFieldValidator1.ControlToValidate = "";
            RequiredFieldValidator2.ControlToValidate = "";
            RequiredFieldValidator3.ControlToValidate = "";
            ClientScript.RegisterStartupScript(Page.GetType(), "mykey", "CancelEdit();", true);
        }
    }
}