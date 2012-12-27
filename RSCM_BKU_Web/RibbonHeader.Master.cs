using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Ext.Net;

namespace RSCM_BKU_Web
{
    public partial class RibbonHeader : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpContext.Current.Session["UserId"] = "toro";
            HttpContext.Current.Session["UserName"] = "Tri Noviantoro";
            //if (HttpContext.Current.Session["UserId"] == null)
            //    Response.Redirect("~/Login/Login.aspx");
            string userId = HttpContext.Current.Session["UserId"].ToString();
            if (!string.IsNullOrEmpty(userId))
            {
                lblUserName.Text = String.Format("Welcome {0}, You're logged in from :{1}", HttpContext.Current.Session["UserName"], HttpContext.Current.Session["IPAddress"]);
                lnkLogin.Text = "Logout";
            }
            else
                Response.Redirect("~/Login/Login.aspx");
        }

        protected void RadRibbonBar1_ButtonClick(object sender, Telerik.Web.UI.RibbonBarButtonClickEventArgs e)
        {
            switch (e.Button.ID)
            {
                case "cmdMasterGroup":
                    Response.Redirect("~/Master/masterGroupMA.aspx");                    
                    break;
                case "cmdMasterKas":
                    Response.Redirect("~/Master/MasterKas.aspx");
                    
                    break;
                case "cmdMasterKelompokAnggaran":
                    Response.Redirect("~/Master/MasterKelompokAnggaran.aspx");
                    break;
                case "cmdMasterRAB":
                    Response.Redirect("~/Master/MasterRencanaAnggaranBelanja.aspx");
                    break;
                case "cmdTransaksiKas":
                    //Response.Redirect("~/Transaksi/TransaksiKasBendaharaPengguna.aspx");
                    Response.Redirect("~/Transaksi/TransaksiKas.aspx");
                    break;
                case "cmdLaporanBKU":
                    Response.Redirect("~/Report/ReportViewerBKU.aspx");
                    break;
                case "cmdLaporanKasBank":
                    Response.Redirect("~/Report/ReportViewerKasBank.aspx");
                    break;
                case "cmdLaporanPerKelompokAnggaran":
                    Response.Redirect("~/Report/ReportViewerPerMA.aspx");
                    break;
                case "cmdGroupedMA":
                    Response.Redirect("~/Report/ReportViewerGroupedByMA.aspx");
                    break;
                case "cmdTransaksiTarikInvoice":
                    Response.Redirect("~/Transaksi/TransaksiTarikDataPembayaran.aspx");
                    break;
                case "cmdTransaksiRearrange":
                    Response.Redirect("~/Transaksi/TransaksiSortTransNumber.aspx");
                    break;
                default:
                    Response.Redirect("Default.aspx");
                    break;
            }
        }

        protected void logout(object sender, DirectEventArgs e)
        {
            Session.Abandon();
            Session.RemoveAll();
            Session.Clear();
            Response.Redirect("~/Login/Login.aspx");
        }
    }
}