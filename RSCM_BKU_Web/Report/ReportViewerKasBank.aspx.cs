using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

using RSCM_BKU_Web.BusinessObjects;
using RSCM_BKU_Web.Linq;
using RSCM_BKU_web.Report;
using System.Collections;
using System.Reflection;

namespace RSCM_BKU_Web.Report
{
    public partial class ReportViewerKasBank : System.Web.UI.Page
    {
        private RscmBkuDataContext db = new RscmBkuDataContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            var trans = from t in db.Trans
                        join k in db.KAs on t.KAS_ID equals k.KA_CODE
                        select new { t.TRANS_NUMBER, t.TRANS_DATE, t.DESCRIPT, t.CREDIT_AMOUNT, t.DEBIT_AMOUNT, k.KA_CODE, k.KA_NAME };

            store1.DataSource = LinqDataSource1;
            store1.DataBind();
        }

        protected void cmdPreview_Click(object sender, EventArgs e)
        {
            if (dtfStartDate.IsEmpty)
                dtfStartDate.SelectedDate = new DateTime(2011, 01, 01);
            if (dtfEndDate.IsEmpty)
                dtfEndDate.SelectedDate = DateTime.Now;
            if (dtfStartDate.SelectedDate > dtfEndDate.SelectedDate)
                return;            
            if (string.IsNullOrEmpty(cmbJenisKasBank.SelectedItem.Value))
            {
                cmbJenisKasBank.SelectedIndex = 0;
            }
            //ini untuk saldo awal
            KasCollection saldoKas = new KasCollection();
            saldoKas.Query.Select(saldoKas.Query.SaldoAwal);
            saldoKas.Query.Where(saldoKas.Query.KaCode == cmbJenisKasBank.SelectedItem.Value);
            saldoKas.Query.Load();

            //hitung total kredit untuk semua transaksi sebelum tanggal awal
            TransCollection transtotalCreditCollection = new TransCollection();
            transtotalCreditCollection.Query.Select(transtotalCreditCollection.Query.CreditAmount.Sum().Coalesce("0"));
            transtotalCreditCollection.Query.Where(transtotalCreditCollection.Query.TransDate < dtfStartDate.SelectedDate & transtotalCreditCollection.Query.KasId == cmbJenisKasBank.SelectedItem.Value);
            //transtotalCreditCollection.Query.OrderBy(transtotalCreditCollection.Query.TransNumber.Ascending, transtotalCreditCollection.Query.BkuId.Ascending);
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
            transtotalDebitCollection.Query.Where(transtotalDebitCollection.Query.TransDate < dtfStartDate.SelectedDate & transtotalDebitCollection.Query.KasId == cmbJenisKasBank.SelectedItem.Value);
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
            foreach(Kas kkkk in saldoKas)
            {
                SaldoAwal = (decimal)kkkk.SaldoAwal + totalDebit - totalCredit;
            }

            //TransQuery transQ = new TransQuery();
            string zero = "0";
            string zeros = "0.0";
            string sawal = "SALDO AWAL";
            decimal nol = 0;
            DateTime skrg = DateTime.Now;                   
            DateTime startdate = dtfStartDate.SelectedDate;
            startdate = startdate.AddDays(-1);
            var trans = from t in db.Trans
                        join k in db.KAs on t.KAS_ID equals k.KA_CODE
                        where t.TRANS_DATE >= dtfStartDate.SelectedDate && t.TRANS_DATE <= dtfEndDate.SelectedDate && t.KAS_ID == cmbJenisKasBank.SelectedItem.Value
                        select new { NUMBER = (string)t.TRANS_NUMBER, DATES = (DateTime)t.TRANS_DATE, DESCRIPTS = t.DESCRIPT, CREDIT = (decimal)t.CREDIT_AMOUNT, DEBIT = (decimal)t.DEBIT_AMOUNT, CODES = (String)k.KA_CODE, NAMES = (string)k.KA_NAME };
            var Cash =  from kas in db.KAs                        
                        where kas.KA_CODE == cmbJenisKasBank.SelectedItem.Value
                        select new { NUMBER = zero, DATES = startdate, DESCRIPTS = sawal, CREDIT = nol, DEBIT = SaldoAwal, CODES = zeros, NAMES = (string)kas.KA_NAME };            
                        
            var Gab = trans.Union(Cash);

            DataTable Gabungan = AnonymousToDataTable.ToDataTable(Gab);
            Gabungan.Columns.Add("SALDO", typeof(decimal));

            foreach (DataRow dr in Gabungan.Rows)
            {
                if (dr["DESCRIPTS"].ToString() == sawal)
                {
                    dr["SALDO"] = SaldoAwal;
                    continue;
                }
                SaldoAwal = SaldoAwal + (Convert.ToDecimal(dr["DEBIT"])) - (Convert.ToDecimal(dr["CREDIT"]));
                dr["SALDO"] = SaldoAwal;
                Gabungan.AcceptChanges();
            }

            RSCM_BKU_web.Report.LaporanKasBank report1 = new RSCM_BKU_web.Report.LaporanKasBank();
            report1.DataSource = Gabungan;
            ReportViewer1.Report = report1;
            ReportViewer1.RefreshReport();
        }

        protected void LinqDataSource1_Selecting(object sender, LinqDataSourceSelectEventArgs e)
        {
            var KasDataSource = from k in db.KAs
                                select new { k.KA_CODE, k.KA_NAME };
            e.Result = KasDataSource;
        }
    }
}