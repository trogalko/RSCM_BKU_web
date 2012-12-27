using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using RSCM_BKU_Web.Linq;
using Ext.Net;
using System.Collections;

namespace RSCM_BKU_Web.Report
{
    public partial class ReportViewerPerMA : System.Web.UI.Page
    {
        private RscmBkuDataContext db = new RscmBkuDataContext();
        protected void Page_Load(object sender, EventArgs e)
        {          
            
        }

        protected void cmdPreview_Click(object sender, EventArgs e)
        {
            if (dtfStartDate.SelectedDate > dtfEndDate.SelectedDate)
                return;

            var Trans = from t in db.Trans
                        join k in db.Kel_anggarans on t.KA_CODE equals k.KA_CODE
                        where t.TRANS_DATE >= dtfStartDate.SelectedDate && t.TRANS_DATE <= dtfEndDate.SelectedDate 
                        orderby t.TRANS_NUMBER
                        select new { k.KA_NAME,t.TRANS_NUMBER,t.TRANS_DATE,t.DESCRIPT,t.DEBIT_AMOUNT,t.CREDIT_AMOUNT };

            RSCM_BKU_web.Report.LaporanPerKelompokAnggaran report1 = new RSCM_BKU_web.Report.LaporanPerKelompokAnggaran();
            report1.ReportParameters[0].Value = dtfStartDate.SelectedDate;
            report1.ReportParameters[1].Value = dtfEndDate.SelectedDate;
            report1.DataSource = Trans;
            ReportViewer1.Report = report1;
            ReportViewer1.RefreshReport();
        }
    }
}