using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RSCM_BKU_Web.Linq;
using Ext.Net;

namespace RSCM_BKU_Web.Transaksi
{
    public partial class TransaksiKas1 : System.Web.UI.Page
    {
        private RscmBkuDataContext dc = new RscmBkuDataContext();        
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void LinqDataSource1_Selecting(object sender, LinqDataSourceSelectEventArgs e)
        {
            var Transaksi = from t in dc.Trans
                            join k in dc.Kel_anggarans on t.KA_CODE equals k.KA_CODE
                            select new { t.TRANS_NUMBER, t.TRANS_DATE, k.KA_NAME, t.DESCRIPT, t.CEK_BG_NUMBER, t.DEBIT_AMOUNT, t.CREDIT_AMOUNT };
            e.Result = Transaksi;
        }

        public void Button1_Click(object sender, DirectEventArgs e)
        {
            RowSelectionModel sm = this.GridPanel1.SelectionModel.Primary as RowSelectionModel;
            if (sm.SelectedRows.Count > 0)
            {
                foreach (SelectedRow sr in sm.SelectedRows)
                {
                    this.GridPanel1.Title = sr.RecordID;
                }
            }
        }

        protected void AddKas(object sender, DirectEventArgs e)
        {
            RowSelectionModel sm = this.GridPanel1.SelectionModel.Primary as RowSelectionModel;
            if (sm.SelectedRows.Count > 0)
            {
                foreach (SelectedRow sr in sm.SelectedRows)
                {

                }
            }
        }

        protected void AddTransaksiKas(object sender, DirectEventArgs e)
        {

        }

        protected void GetSelected(object sender, DirectEventArgs e)
        {
            RowSelectionModel sm = this.GridPanel1.SelectionModel.Primary as RowSelectionModel;
            if (sm.SelectedRows.Count > 0)
            {
                foreach (SelectedRow sr in sm.SelectedRows)
                {
                    this.Response.Redirect("~/Transaksi/TransaksiKasAdd.aspx?KasID=" + sr.RecordID);
                }
            }
        }
    }
}