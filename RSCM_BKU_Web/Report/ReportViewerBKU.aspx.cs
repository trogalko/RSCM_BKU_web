using System;
using System.Data;
using RSCM_BKU_Web.BusinessObjects;
using RSCM_BKU_Web.Linq;
using RSCM_BKU_web.Report;
using Ext.Net;
using System.Collections.Specialized;
using System.Globalization;

namespace RSCM_BKU_Web.Report
{
    public partial class ReportViewer : System.Web.UI.Page
    {
        private RscmBkuDataContext rscm = new RscmBkuDataContext();        
        DataTable dt = new DataTable();
        decimal SaldoAwal = 0;
        string titles = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            //dtfStartDate.SelectedDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            //dtfEndDate.SelectedDate = DateTime.Now;
        }

        protected void viewReport(object sender, DirectEventArgs e)
        {
            if (dtfStartDate.IsEmpty)
                dtfStartDate.SelectedDate = new DateTime(2010, 01, 01);
            if (dtfEndDate.IsEmpty)
                dtfEndDate.SelectedDate = DateTime.Now;
            if (dtfStartDate.SelectedDate > dtfEndDate.SelectedDate)
                return;
            //ini untuk saldo awal
            TransaksiBKUQuery transBkuQ = new TransaksiBKUQuery();
            SaldoAwalCollection saCol = new SaldoAwalCollection();
            saCol.LoadAll();

            //hitung total kredit untuk semua transaksi sebelum tanggal awal
            TransCollection transtotalCreditCollection = new TransCollection();
            transtotalCreditCollection.Query.Select(transtotalCreditCollection.Query.CreditAmount.Sum().Coalesce("0"));
            transtotalCreditCollection.Query.Where(transtotalCreditCollection.Query.TransDate < dtfStartDate.SelectedDate);
            transtotalCreditCollection.Query.Load();
            decimal totalCredit = transtotalCreditCollection[0].CreditAmount.Value;
            //hitung total debit untuk semua transaksi sebelum tanggal awal
            TransCollection transtotalDebitCollection = new TransCollection();
            transtotalDebitCollection.Query.Select(transtotalDebitCollection.Query.DebitAmount.Sum().Coalesce("0"));
            transtotalDebitCollection.Query.Where(transtotalDebitCollection.Query.TransDate < dtfStartDate.SelectedDate);
            transtotalDebitCollection.Query.Load();
            decimal totalDebit = transtotalCreditCollection[0].DebitAmount.Value;

            transBkuQ.SelectAll();
            transBkuQ.Where(transBkuQ.TransDate >= dtfStartDate.SelectedDate, transBkuQ.TransDate <= dtfEndDate.SelectedDate);
            //transBkuQ.OrderBy(("TransNumber"));
            transBkuQ.OrderBy(transBkuQ.TransNumber.Descending);

            TransaksiBKUCollection transBkuCol = new TransaksiBKUCollection();
            transBkuCol.Load(transBkuQ);            

            if (transBkuCol.Count > 0)
            {
                dt = transBkuQ.LoadDataTable();
                dt.Columns.Add("Saldo", typeof(decimal));
                DataTable dtCopy = dt.Clone();

                foreach (RSCM_BKU_Web.BusinessObjects.SaldoAwal sa in saCol)
                {
                    dt.Rows.Add("0", null, "Saldo Awal Total", "0", "SALDO AWAL", "0", "", 0, 0, false, false, true, sa.SaldoAwal + totalDebit - totalCredit);
                    dtCopy.Rows.Add("0", null, "Saldo Awal Total", "0", "SALDO AWAL", "0", 0, 0, false, false, true, sa.SaldoAwal + totalDebit - totalCredit);
                    SaldoAwal = Convert.ToDecimal((sa.SaldoAwal + totalDebit - totalCredit));                    
                }

                foreach (DataColumn dc in dt.Columns)
                {
                    titles += dc.ColumnName;
                    this.Title = titles;
                }
                foreach (DataRow dr in dt.Rows)
                {

                    SaldoAwal = SaldoAwal + (Convert.ToDecimal(dr["DEBIT_AMOUNT"]) - Convert.ToDecimal(dr["CREDIT_AMOUNT"]));
                    dr["Saldo"] = SaldoAwal;
                    dt.AcceptChanges();
                    dtCopy.Rows.Add(dr["TRANS_NUMBER"], dr["TRANS_DATE"], dr["DESCRIPT"], dr["KA_CODE"], dr["KA_NAME"], dr["GT_CODE"], dr["CEK_BG_NUMBER"], dr["DEBIT_AMOUNT"], dr["CREDIT_AMOUNT"], dr["IS_CLOSED"], dr["ISVERIFIED"], dr["IS_ACTIVE"], dr["Saldo"]);
                }

                RSCM_BKU_web.Report.LaporanBKU report1 = new LaporanBKU();
                report1.ReportParameters[0].Value = dtfStartDate.SelectedDate;
                report1.ReportParameters[1].Value = dtfEndDate.SelectedDate;
                report1.DataSource = dtCopy;
                ReportViewer1.Report = report1;
                ReportViewer1.RefreshReport();
                ReportViewer1.RefreshReport();
            }
            else
                return;
        }

        protected void cmdPeview_Click(object sender, EventArgs e)
        {
            if (dtfStartDate.IsEmpty)
                dtfStartDate.SelectedDate = new DateTime(2010, 01, 01);
            if (dtfEndDate.IsEmpty)
                dtfEndDate.SelectedDate = DateTime.Now;
            if (dtfStartDate.SelectedDate > dtfEndDate.SelectedDate)
                return;
            TransaksiBKUQuery transBkuQ = new TransaksiBKUQuery();
            //KelAnggaranQuery kelAnggaranQuery = new KelAnggaranQuery();
            SaldoAwalCollection saCol = new SaldoAwalCollection();
            saCol.LoadAll();

            //hitung total kredit untuk semua transaksi sebelum tanggal awal
            TransCollection transtotalCreditCollection = new TransCollection();
            transtotalCreditCollection.Query.Select(transtotalCreditCollection.Query.CreditAmount.Sum().Coalesce("0"));
            transtotalCreditCollection.Query.Where(transtotalCreditCollection.Query.TransDate < dtfStartDate.SelectedDate);
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
            transtotalDebitCollection.Query.Where(transtotalDebitCollection.Query.TransDate < dtfStartDate.SelectedDate);
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

            transBkuQ.SelectAll();
            //transBkuQ.Select(transBkuQ.TransNumber,transBkuQ.TransDate,kelAnggaranQuery.GtCode,transBkuQ.Descript,transBkuQ.KaName,transBkuQ.CekBgNumber);
            transBkuQ.OrderBy(transBkuQ.TransNumber.Ascending);
            transBkuQ.Where(transBkuQ.TransDate >= dtfStartDate.SelectedDate & transBkuQ.TransDate <= dtfEndDate.SelectedDate);
            //transBkuQ.InnerJoin(kelAnggaranQuery).On(transBkuQ.KaCode == kelAnggaranQuery.KaCode);

            TransaksiBKUCollection transBkuCol = new TransaksiBKUCollection();
            transBkuCol.Load(transBkuQ);
            
            if (transBkuCol.Count > 0)
            {
                dt = transBkuQ.LoadDataTable();
                dt.Columns.Add("Saldo", typeof(decimal));
                DataTable dtCopy = dt.Clone();

                foreach (RSCM_BKU_Web.BusinessObjects.SaldoAwal sa in saCol)
                {
                    dtCopy.Rows.Add("0", null, "SALDO AWAL TOTAL", "0", "Saldo Awal Total", "", (sa.SaldoAwal + totalDebit - totalCredit), 0, false, false, true, "", (sa.SaldoAwal + totalDebit - totalCredit));
                    SaldoAwal = Convert.ToDecimal((sa.SaldoAwal + totalDebit - totalCredit));
                }

                foreach (DataColumn dc in dt.Columns)
                {
                    titles += dc.ColumnName;
                    this.Title = titles;
                }
                foreach (DataRow dr in dt.Rows)
                {
                    SaldoAwal = SaldoAwal + (Convert.ToDecimal(dr["DEBIT_AMOUNT"]) - Convert.ToDecimal(dr["CREDIT_AMOUNT"]));
                    dr["Saldo"] = SaldoAwal;
                    dt.AcceptChanges();
                    dtCopy.Rows.Add(dr["TRANS_NUMBER"], dr["TRANS_DATE"], dr["DESCRIPT"], dr["KA_CODE"], dr["KA_NAME"], dr["GT_CODE"], dr["DEBIT_AMOUNT"], dr["CREDIT_AMOUNT"], dr["IS_CLOSED"], dr["ISVERIFIED"], dr["IS_ACTIVE"], dr["CEK_BG_NUMBER"], dr["Saldo"]);
                }

                RSCM_BKU_web.Report.LaporanBKU report1 = new LaporanBKU();
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

                
                CultureInfo ci = new CultureInfo("id-ID");
                report1.ReportParameters[0].Value = dtfStartDate.SelectedDate.ToString("d",ci);
                report1.ReportParameters[1].Value = dtfEndDate.SelectedDate.ToString("d",ci);
                report1.ReportParameters[6].Value = SaldoAwal.ToString();
                report1.ReportParameters[6].Value = string.Format("{0:N2}", SaldoAwal);
                report1.DataSource = dtCopy;
                ReportViewer1.Report = report1;
                ReportViewer1.RefreshReport();
                ReportViewer1.RefreshReport();
            }
            else
                return;
        }
    }
}