using System;
using System.Data;
using RSCM_BKU_Web.BusinessObjects;
using RSCM_BKU_web.Report;
using Ext.Net;

namespace RSCM_BKU_Web.Report.LaporanPerKelompokAnggaran
{
    public partial class ReportViewer : System.Web.UI.Page
    {
        DataTable dt = new DataTable();
        decimal SaldoAwal = 0;
        string titles = "";
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void preview_report(object sender, EventArgs e)
        {
            DateTime startDate = new DateTime(1990, 1, 1);
            DateTime endDate = DateTime.Now;

            TransaksiBKUQuery transBkuQ = new TransaksiBKUQuery();
            SaldoAwalCollection saCol = new SaldoAwalCollection();
            saCol.LoadAll();

            transBkuQ.SelectAll();
            transBkuQ.OrderBy(transBkuQ.TransNumber.ToString());
            transBkuQ.Where(transBkuQ.TransDate >= startDate, transBkuQ.TransDate <= endDate);

            TransaksiBKUCollection transBkuCol = new TransaksiBKUCollection();
            transBkuCol.Load(transBkuQ);

            if (transBkuCol.Count > 0)
            {
                dt = transBkuQ.LoadDataTable();
                dt.Columns.Add("Saldo", typeof(decimal));
                DataTable dtCopy = dt.Clone();

                foreach (RSCM_BKU_Web.BusinessObjects.SaldoAwal sa in saCol)
                {
                    //dt.Rows.Add("", null, "", "", "", "", 0, 0, false, false, true, sa.SaldoAwal);
                    dtCopy.Rows.Add("0", null, "SALDO AWAL TOTAL", "0", "Saldo Awal Total", "", sa.SaldoAwal, 0, false, false, true, "", sa.SaldoAwal);
                    SaldoAwal = Convert.ToDecimal((sa.SaldoAwal));
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


                report1.ReportParameters[0].Value = startDate;
                report1.ReportParameters[1].Value = endDate;
                report1.ReportParameters[6].Value = SaldoAwal.ToString();
                report1.ReportParameters[6].Value = string.Format("{0:N2}", SaldoAwal);
                report1.DataSource = dtCopy;
                ReportViewer1.Report = report1;
                ReportViewer1.Update();
                
            }
            else
                return;
        }
    }
}