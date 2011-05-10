using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RSCM_BKU_Web.Linq;
using RSCM_BKU_Web.BusinessObjects;
using Ext.Net;
using DevExpress.Web.ASPxPopupControl;

namespace RSCM_BKU_Web.Transaksi
{
    public partial class TransaksiKasAdd : System.Web.UI.Page
    {
        private RscmBkuDataContext dc = new RscmBkuDataContext();   
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request["KasID"] != null)
            {
                Page.Title = Request["KasID"];
            }
        }

        protected void LinqDataSource1_Selecting(object sender, LinqDataSourceSelectEventArgs e)
        {
            var kelAngg = from k in dc.viewKelAnggaranCodeCombineNames
                          //select new { k.KA_CODE, k.KaCodeName };
                          select k;
            e.Result = kelAngg;
        }

        protected void Save(object sender, DirectEventArgs e)
        {
            this.formAdd.Title = this.cmbKelompokAnggaran.SelectedItem.Text;
            AuditTrail at = new AuditTrail();
            at.Aksi = txtTransNumber.Text;
            at.DateAction = DateTime.Now;
            at.Save();
        }
    }
}