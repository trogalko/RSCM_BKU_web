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
            
        }

        protected void cmdPreview_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(dtfStartDate.SelectedDate.ToShortDateString()))
                dtfStartDate.SelectedDate = dtfStartDate.MinDate;
            if (string.IsNullOrEmpty(dtfEndDate.SelectedDate.ToShortDateString()))
                dtfEndDate.SelectedDate = DateTime.Now;
            if (dtfStartDate.SelectedDate > dtfEndDate.SelectedDate)
                return;
            //TransQuery transQ = new TransQuery();
            string zero = "0";
            string zeros = "0.0";
            string sawal = "SALDO AWAL";
            decimal nol = 0;
            DateTime skrg = DateTime.Now;
            var trans = from t in db.Trans
                        join k in db.KAs on t.KAS_ID equals k.KA_CODE
                        where t.TRANS_DATE >= dtfStartDate.SelectedDate && t.TRANS_DATE <= dtfEndDate.SelectedDate 
                        select new { NUMBER = (string)t.TRANS_NUMBER, DATES = (DateTime)t.TRANS_DATE, DESCRIPTS = t.DESCRIPT, CREDIT = (decimal)t.CREDIT_AMOUNT, DEBIT = (decimal)t.DEBIT_AMOUNT, CODES = (String)k.KA_CODE, NAMES = (string)k.KA_NAME };
            var Cash =  from kas in db.KAs
                        select new { NUMBER = zero, DATES = skrg, DESCRIPTS = sawal, CREDIT = nol, DEBIT = (decimal)kas.SALDO_AWAL, CODES = zeros, NAMES = (string)kas.KA_NAME };
                        
            var Gab = trans.Union(Cash);

            RSCM_BKU_web.Report.LaporanKasBank report1 = new RSCM_BKU_web.Report.LaporanKasBank();
            report1.DataSource = Gab;
            ReportViewer1.Report = report1;
            ReportViewer1.RefreshReport();
        }
    }
}