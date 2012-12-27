using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using RSCM_BKU_Web.BusinessObjects;
using RSCM_BKU_Web.Linq;
using RSCM_BKU_web.Report;

namespace RSCM_BKU_Web.Report
{
    public partial class ReportViewerGroupedByMA : System.Web.UI.Page
    {
        private RscmBkuDataContext rscm = new RscmBkuDataContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (IsPostBack)
            //    RadWindow1.VisibleOnPageLoad = false;
            //else
            //    RadWindow1.VisibleOnPageLoad = true;            
        }

        protected void cmdProceed_Click(object sender, EventArgs e)
        {
            if (dtpStartDate.SelectedDate > dtpEndDate.SelectedDate)
                return;            
            //RadGrid1.Rebind();
            LaporanTransBKUPerMA report1 = new LaporanTransBKUPerMA();
            
            OfficerCollection ofc = new OfficerCollection();
            ofc.LoadAll();
            foreach (Officer o in ofc)
            {
                if (o.Jabatan == "kaunit")
                {
                    report1.ReportParameters[2].Value = o.NamaLengkap;
                    report1.ReportParameters[4].Value = o.Nip;
                }
                else
                {
                    report1.ReportParameters[3].Value = o.NamaLengkap;
                    report1.ReportParameters[5].Value = o.Nip;
                }
            }


            report1.ReportParameters[0].Value = ((DateTime)dtpStartDate.SelectedDate).ToShortDateString();
            report1.ReportParameters[1].Value = ((DateTime)dtpEndDate.SelectedDate).ToShortDateString();
            report1.DataSource = dt;
            ReportViewer1.Report = report1;
            ReportViewer1.RefreshReport();
        }

        private DataTable dt
        {
            get
            {
                DataTable dtTransMA = new DataTable();
                dtTransMA.Columns.Add("kodeMA", typeof(string));
                dtTransMA.Columns.Add("DESCRIPT", typeof(string));
                dtTransMA.Columns.Add("KA_LEVEL", typeof(string));
                dtTransMA.Columns.Add("DEBIT", typeof(Decimal));
                dtTransMA.Columns.Add("CREDIT", typeof(Decimal));
                dtTransMA.AcceptChanges();
                //TABLE SALDO Per Kelompok Anggaran
                var transMA = (from transma in rscm.Trans
                              where transma.TRANS_DATE >= dtpStartDate.SelectedDate && transma.TRANS_DATE <= dtpEndDate.SelectedDate
                              orderby transma.KA_CODE
                              group transma by new
                              {
                                  kodeMA = transma.KA_CODE
                              }
                                  into grp
                                  select new
                                  {
                                      grp.Key.kodeMA,
                                      DESCRIPT = "",
                                      KA_LEVEL = "3",
                                      DEBIT = grp.Sum(o => o.DEBIT_AMOUNT),
                                      CREDIT = grp.Sum(o => o.CREDIT_AMOUNT)
                                  });

                foreach (var yy in transMA)
                {
                    DataRow dr = dtTransMA.NewRow();
                    dr["kodeMA"] = yy.kodeMA;
                    dr["DESCRIPT"] = yy.DESCRIPT;
                    dr["KA_LEVEL"] = yy.KA_LEVEL;
                    dr["DEBIT"] = Convert.ToDecimal(yy.DEBIT);
                    dr["CREDIT"] = Convert.ToDecimal(yy.CREDIT);
                    dtTransMA.Rows.Add(dr);
                }

                DataTable dtKelompokAnggaran = new DataTable();
                dtKelompokAnggaran.Columns.Add("kodeMA", typeof(string));
                dtKelompokAnggaran.Columns.Add("DESCRIPT", typeof(string));
                dtKelompokAnggaran.Columns.Add("KA_LEVEL", typeof(string));
                dtKelompokAnggaran.Columns.Add("DEBIT", typeof(Decimal));
                dtKelompokAnggaran.Columns.Add("CREDIT", typeof(Decimal));
                dtKelompokAnggaran.AcceptChanges();

                var kelompokAnggaran = from a in rscm.Kel_anggarans
                                       select new 
                                       {
                                           kodeMA = a.KA_CODE,
                                           DESCRIPT = a.KA_NAME,
                                           a.KA_LEVEL,
                                           DEBIT = Convert.ToDecimal(0),
                                           CREDIT = Convert.ToDecimal(0)
                                       };

                foreach (var xx in kelompokAnggaran)
                {
                    DataRow dr = dtKelompokAnggaran.NewRow();
                    dr["kodeMA"] = xx.kodeMA;
                    dr["DESCRIPT"] = xx.DESCRIPT;
                    dr["KA_LEVEL"] = xx.KA_LEVEL;
                    dr["DEBIT"] = Convert.ToDecimal(xx.DEBIT);
                    dr["CREDIT"] = Convert.ToDecimal(xx.CREDIT);
                    dtKelompokAnggaran.Rows.Add(dr);
                }

                //DataTable saldoPerMA = transMA.CopyToDataTableCustom();                

                //DataTable KelompokAnggaran = kelompokAnggaran.CopyToDataTableCustom();

                //foreach (DataRow drKelMA in KelompokAnggaran.Rows)
                //{
                //    foreach (DataRow drSaldoMA in saldoPerMA.Rows)
                //    {
                //        if ( drKelMA["kodeMA"].ToString() == drSaldoMA["kodeMA"].ToString())
                //        {
                //            string input = drSaldoMA["DEBIT"].ToString();
                //            decimal output = 0;
                //            if (Decimal.TryParse(input, out output))
                //                drKelMA["DEBIT"] = output;
                //            else
                //                drKelMA["DEBIT"] = 0;
                //            input = drSaldoMA["CREDIT"].ToString();                            
                //            if (Decimal.TryParse(input, out output))
                //                drKelMA["CREDIT"] = output;
                //            else
                //                drKelMA["CREDIT"] = 0;
                //            drKelMA.AcceptChanges();
                //        }                        
                //    }
                //}

                foreach (DataRow drKelMA in dtKelompokAnggaran.Rows)
                {
                    foreach (DataRow drSaldoMA in dtTransMA.Rows)
                    {
                        if (drKelMA["kodeMA"].ToString() == drSaldoMA["kodeMA"].ToString())
                        {
                            string input = drSaldoMA["DEBIT"].ToString();
                            decimal output = 0;
                            if (Decimal.TryParse(input, out output))
                                drKelMA["DEBIT"] = output;
                            else
                                drKelMA["DEBIT"] = 0;
                            input = drSaldoMA["CREDIT"].ToString();
                            if (Decimal.TryParse(input, out output))
                                drKelMA["CREDIT"] = output;
                            else
                                drKelMA["CREDIT"] = 0;
                            drKelMA.AcceptChanges();
                        }
                    }
                }

                // SALDO AWAL
                //ini untuk saldo awal
                KasCollection saldoKas = new KasCollection();
                saldoKas.Query.Select(saldoKas.Query.SaldoAwal);
                saldoKas.Query.Load();

                //hitung total kredit untuk semua transaksi sebelum tanggal awal
                TransCollection transtotalCreditCollection = new TransCollection();
                transtotalCreditCollection.Query.Select(transtotalCreditCollection.Query.CreditAmount.Sum().Coalesce("0"));
                transtotalCreditCollection.Query.Where(transtotalCreditCollection.Query.TransDate < dtpStartDate.SelectedDate);
                transtotalCreditCollection.Query.Load();
                decimal totalCredit = 0;
                if (!transtotalCreditCollection[0].CreditAmount.HasValue)
                {
                    totalCredit = 0;
                }
                else
                {
                    totalCredit = (decimal)transtotalCreditCollection[0].CreditAmount.Value;
                }
                //hitung total debit untuk semua transaksi sebelum tanggal awal
                TransCollection transtotalDebitCollection = new TransCollection();
                transtotalDebitCollection.Query.Select(transtotalDebitCollection.Query.DebitAmount.Sum().Coalesce("0"));
                transtotalDebitCollection.Query.Where(transtotalDebitCollection.Query.TransDate < dtpStartDate.SelectedDate);
                transtotalDebitCollection.Query.Load();
                decimal totalDebit = 0;

                if (transtotalDebitCollection[0].DebitAmount.HasValue == false)
                {
                    totalDebit = 0;
                }
                else
                {
                    totalDebit = (decimal)transtotalDebitCollection[0].DebitAmount.Value;
                }
                //so, Saldo Awal adalah ... 
                decimal SaldoAwal = 0;
                foreach (Kas kkkk in saldoKas)
                {
                    SaldoAwal = SaldoAwal + (decimal)kkkk.SaldoAwal;
                }
                SaldoAwal = SaldoAwal + totalDebit - totalCredit;
                // END SALDO AWAL

                var ReportSource = rscm.spReportSourceTransPerMA(dtpStartDate.SelectedDate, dtpEndDate.SelectedDate);
                DataTable dtReportSource = new DataTable();
                dtReportSource.Columns.Add("KA_CODE",typeof(string));
                dtReportSource.Columns.Add("KA_LEVEL", typeof(string));
                dtReportSource.Columns.Add("TRANS_NUMBER", typeof(string));
                dtReportSource.Columns.Add("TRANS_DATE", typeof(DateTime));
                dtReportSource.Columns.Add("DESCRIPT", typeof(string));
                dtReportSource.Columns.Add("GT_CODE", typeof(string));
                dtReportSource.Columns.Add("CEK_BG_NUMBER", typeof(string));
                dtReportSource.Columns.Add("DEBIT_AMOUNT", typeof(Decimal));
                dtReportSource.Columns.Add("CREDIT_AMOUNT", typeof(Decimal));
                dtReportSource.Columns.Add("PERIOD_ID", typeof(long));
                dtReportSource.Columns.Add("ISVERIFIED", typeof(bool));
                dtReportSource.Columns.Add("IS_CLOSED", typeof(bool));
                dtReportSource.Columns.Add("KAS_ID", typeof(string));
                dtReportSource.Columns.Add("KA_NAME", typeof(string));
                dtReportSource.Columns.Add("KAS_NAME", typeof(string));
                dtReportSource.AcceptChanges();
                                
                foreach ( spReportSourceTransPerMAResult sp in ReportSource)
                { 
                    DataRow dr = dtReportSource.NewRow();
                    dr["KA_CODE"] = sp.KA_CODE;
                    dr["KA_LEVEL"] = sp.KA_LEVEL;
                    dr["TRANS_NUMBER"] = sp.TRANS_NUMBER;
                    if (string.IsNullOrEmpty(sp.TRANS_DATE.ToString()))
                        dr["TRANS_DATE"] = DBNull.Value;
                    else
                        dr["TRANS_DATE"] = (DateTime)sp.TRANS_DATE;
                    dr["DESCRIPT"] = sp.DESCRIPT;
                    dr["GT_CODE"] = sp.GT_CODE;
                    dr["CEK_BG_NUMBER"] = sp.CEK_BG_NUMBER;
                    if (string.IsNullOrEmpty(sp.DEBIT_AMOUNT.ToString()))
                        dr["DEBIT_AMOUNT"] = DBNull.Value;
                    else
                        dr["DEBIT_AMOUNT"] = sp.DEBIT_AMOUNT;
                    if (string.IsNullOrEmpty(sp.CREDIT_AMOUNT.ToString()))
                        dr["CREDIT_AMOUNT"] = DBNull.Value;
                    else
                        dr["CREDIT_AMOUNT"] = sp.CREDIT_AMOUNT;
                    if (string.IsNullOrEmpty(sp.PERIOD_ID.ToString()))
                        dr["PERIOD_ID"] = DBNull.Value;
                    else
                        dr["PERIOD_ID"] = sp.PERIOD_ID;
                    if (string.IsNullOrEmpty(sp.ISVERIFIED.ToString()))
                        dr["ISVERIFIED"] = DBNull.Value;
                    else
                        dr["ISVERIFIED"] = sp.ISVERIFIED;
                    if (string.IsNullOrEmpty(sp.IS_CLOSED.ToString()))
                        dr["IS_CLOSED"] = DBNull.Value;
                    else
                        dr["IS_CLOSED"] = sp.IS_CLOSED;
                    if (string.IsNullOrEmpty(sp.KAS_ID))
                        dr["KAS_ID"] = DBNull.Value;
                    else
                        dr["KAS_ID"] = sp.KAS_ID;
                    if (string.IsNullOrEmpty(sp.KA_NAME))
                        dr["KA_NAME"] = DBNull.Value;
                    else
                        dr["KA_NAME"] = sp.KA_NAME;
                    if (string.IsNullOrEmpty(sp.KAS_NAME))
                        dr["KAS_NAME"] = DBNull.Value;
                    else
                        dr["KAS_NAME"] = sp.KAS_NAME;
                    dtReportSource.Rows.Add(dr);
                }

                //DataTable DT = ReportSource.CopyToDataTableCustom();
                DataColumn dc = new DataColumn("SALDO");
                dc.DataType = Type.GetType("System.Decimal");
                //DT.Columns.Add(dc);
                dtReportSource.Columns.Add(dc);

                string SaldoAww;
                SaldoAww = "SALDO AWAL";
                //DataRow rowSaldo = DT.NewRow();
                DataRow rowSaldo = dtReportSource.NewRow();
                rowSaldo["KA_LEVEL"] = "0";
                rowSaldo["TRANS_DATE"] = (DateTime)dtpStartDate.SelectedDate;
                rowSaldo["DESCRIPT"] = SaldoAww;
                rowSaldo["SALDO"] = SaldoAwal;                
                //DT.Rows.InsertAt(rowSaldo, 0);
                dtReportSource.Rows.InsertAt(rowSaldo, 0);

                //foreach (DataRow dr in DT.Rows)
                foreach (DataRow dr in dtReportSource.Rows)
                {
                    if ((dr["DESCRIPT"]).ToString().Length > 45)
                    {
                        dr["DESCRIPT"] = dr["DESCRIPT"].ToString().Substring(0, 45);
                    }

                    if (Convert.ToInt32((dr["KA_LEVEL"])) < 3)
                    {
                        dr["DESCRIPT"] = dr["KA_NAME"];
                        dr["SALDO"] = SaldoAwal;
                    }

                    if (Convert.ToInt32(dr["KA_LEVEL"].ToString()) == 3 && String.IsNullOrEmpty(dr["TRANS_NUMBER"].ToString()))
                    {
                        dr["DESCRIPT"] = dr["KA_NAME"];
                        dr["SALDO"] = SaldoAwal;
                    }

                    if (Convert.ToInt32(dr["KA_LEVEL"].ToString()) == 3 && !String.IsNullOrEmpty(dr["TRANS_NUMBER"].ToString()))
                    {
                        decimal DebitAmount = 0;
                        decimal CreditAmount = 0;
                        if (string.IsNullOrEmpty(dr["DEBIT_AMOUNT"].ToString()))
                            DebitAmount = 0;
                        else
                            DebitAmount = Convert.ToDecimal(dr["DEBIT_AMOUNT"].ToString());
                        if (string.IsNullOrEmpty(dr["CREDIT_AMOUNT"].ToString()))
                            CreditAmount = 0;
                        else
                            CreditAmount = Convert.ToDecimal(dr["CREDIT_AMOUNT"].ToString());
                        SaldoAwal = SaldoAwal + DebitAmount - CreditAmount;
                        dr["SALDO"] = SaldoAwal;
                        dr["DESCRIPT"] = dr["DESCRIPT"];
                    }
                    dr.AcceptChanges();
                    
                }
                //DataTable reportSource = DT.Clone();
                DataTable reportSource = dtReportSource.Clone();
                //reportSource.ImportRow(DT.Rows[0]);
                reportSource.ImportRow(dtReportSource.Rows[0]);
                //DT.Columns.Remove("KA_LEVEL");
                //DT.Columns.Remove("PERIOD_ID");
                //DT.Columns.Remove("ISVERIFIED");
                //DT.Columns.Remove("IS_CLOSED");
                //DT.Columns.Remove("KAS_ID");
                //DT.Columns.Remove("KA_NAME");
                //DT.Columns.Remove("KAS_NAME");

                // ADD saldo akhir per Kelompok Anggaran
                //foreach (DataRow dr in saldoPerMA.Rows)
                //foreach (DataRow dr in KelompokAnggaran.Rows)
                foreach (DataRow dr in dtKelompokAnggaran.Rows)
                {
                    //foreach (DataRow drs in DT.Rows)
                    foreach (DataRow drs in dtReportSource.Rows)                        
                    {
                        if (dr["kodeMA"].ToString() != drs["KA_CODE"].ToString())
                        {
                            continue;
                        }
                        else
                        {
                            if (Convert.ToInt32(drs["KA_LEVEL"].ToString()) == 3 && String.IsNullOrEmpty(drs["TRANS_NUMBER"].ToString()))
                            {
                                reportSource.ImportRow(drs);
                            }
                            if (Convert.ToInt32(drs["KA_LEVEL"].ToString()) == 3 && !String.IsNullOrEmpty(drs["TRANS_NUMBER"].ToString()))
                            {
                                reportSource.ImportRow(drs);
                            }                            
                        }
                    }
                    DataRow drCopySaldo = reportSource.NewRow();
                    decimal debitAmount = 0;
                    decimal creditAmount = 0;
                    drCopySaldo["KA_CODE"] = dr["kodeMA"];
                    if (dr["KA_LEVEL"].ToString().Trim() == "3")
                    {
                        drCopySaldo["TRANS_NUMBER"] = "X";
                        drCopySaldo["DESCRIPT"] = "Sub Total " + dr["DESCRIPT"].ToString();
                    }
                    else
                        drCopySaldo["DESCRIPT"] = dr["DESCRIPT"].ToString();
                    if (string.IsNullOrEmpty(dr["DEBIT"].ToString()))
                        drCopySaldo["DEBIT_AMOUNT"] = 0;
                    else
                    {
                        drCopySaldo["DEBIT_AMOUNT"] = Convert.ToDecimal(dr["DEBIT"]);
                        debitAmount = Convert.ToDecimal(dr["DEBIT"]);
                    }
                    if (string.IsNullOrEmpty(dr["CREDIT"].ToString()))
                        drCopySaldo["CREDIT_AMOUNT"] = 0;
                    else
                    {
                        drCopySaldo["CREDIT_AMOUNT"] = Convert.ToDecimal(dr["CREDIT"]);
                        creditAmount = Convert.ToDecimal(dr["CREDIT"]);
                    }
                    if (debitAmount > creditAmount)
                    {
                        drCopySaldo["DEBIT_AMOUNT"] = debitAmount - creditAmount;
                        drCopySaldo["CREDIT_AMOUNT"] = 0;
                    }
                    else
                    {
                        drCopySaldo["DEBIT_AMOUNT"] = 0;
                        drCopySaldo["CREDIT_AMOUNT"] = creditAmount - debitAmount;
                    }
                    if (debitAmount == creditAmount)
                    {
                        drCopySaldo["DEBIT_AMOUNT"] = 0;
                        drCopySaldo["CREDIT_AMOUNT"] = 0;
                    }                    
                    reportSource.Rows.Add(drCopySaldo);
                    reportSource.AcceptChanges();
                }

                int Index = 0;
                decimal SaldoAwl = 0;
                decimal debitamount = 0;
                decimal creditamount = 0;

                foreach (DataRow dataRow in reportSource.Rows)
                {
                    // SALDO AWAL 
                    if (Index == 0)
                        SaldoAwl = Convert.ToDecimal(dataRow["SALDO"].ToString());
                    Index++;
                    //SYNC saldo awal per baris
                    if (decimal.TryParse(dataRow["DEBIT_AMOUNT"].ToString(), out debitamount))
                    {
                        if (dataRow["TRANS_NUMBER"].ToString() != "X")
                            SaldoAwl = SaldoAwl + debitamount;
                    }
                    
                    if (decimal.TryParse(dataRow["CREDIT_AMOUNT"].ToString(), out creditamount))
                    {
                        if (dataRow["TRANS_NUMBER"].ToString() != "X")
                            SaldoAwl = SaldoAwl - creditamount;
                    }
                    
                    dataRow["SALDO"] = SaldoAwl;
                    int i = 0;
                    //int i = Convert.ToInt32(dataRow["KA_LEVEL"].ToString());
                    if (!Int32.TryParse(dataRow["KA_LEVEL"].ToString(), out i))
                        i = 0;
                    for (int j = 0; j < i; j++)
                    {
                        //dataRow["DESCRIPT"] = "&nbsp;&nbsp;&nbsp;" + dataRow["DESCRIPT"];
                        dataRow["DESCRIPT"] = "    " + dataRow["DESCRIPT"];
                    }
                    dataRow.AcceptChanges();                    
                }
                DataRow drBlankRow = reportSource.NewRow();
                reportSource.Rows.Add(drBlankRow);
                DataRow drReportSource = reportSource.NewRow();
                drReportSource["DESCRIPT"] = "SALDO AKHIR";
                drReportSource["SALDO"] = SaldoAwl;
                reportSource.Rows.Add(drReportSource);
                reportSource.AcceptChanges();
                //return DT;
                return reportSource;
            }
        }
    }
}