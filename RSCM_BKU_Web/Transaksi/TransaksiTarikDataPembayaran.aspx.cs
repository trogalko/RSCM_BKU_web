using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Ext.Net;
using System.Data;
using RSCM_BKU_Web.BusinessObjects;

namespace RSCM_BKU_Web.Transaksi
{
    public partial class TransaksiTarikDataPembayaran : System.Web.UI.Page
    {
        private List<InvoiceSupplier> list = new List<InvoiceSupplier>();
        private void Page_Load(object sender, EventArgs e)
        {            
            if (!X.IsAjaxRequest)
            {                
                this.storeInvoice.DataSource = GetDataTable();
                this.storeInvoice.DataBind();
            }
        }

        protected void Store1_RefreshData(object sender, StoreRefreshDataEventArgs e)
        {
            this.storeInvoice.DataSource = this.GetDataTable();
            this.storeInvoice.DataBind();
        }

        private DataTable GetDataTable()
        {
            //InvoiceSupplierCollection isC = new InvoiceSupplierCollection();
            InvoiceSupplierQuery isQ = new InvoiceSupplierQuery("a");
            isQ.es2.Connection.Name = "KENCANA";
            InvoiceSupplierItemQuery isiQ = new InvoiceSupplierItemQuery("b");
            isiQ.es2.Connection.Name = "KENCANA";
            SupplierQuery sQ = new SupplierQuery("c");
            sQ.es2.Connection.Name = "KENCANA";
            isQ.Select(
            isQ.InvoiceNo, sQ.SupplierName, isQ.InvoiceNotes, isiQ.TransactionNo.As("NO_POR"), isiQ.VerifyAmount, isiQ.PaymentAmount, isiQ.BankAccountNo.As("NO_BG"), isiQ.PPnAmount,
            isiQ.PPh22Amount, isiQ.PPh23Amount,isQ.Isproces)
            .InnerJoin(isiQ).On(isiQ.InvoiceNo == isQ.InvoiceNo)
            .InnerJoin(sQ).On(sQ.SupplierID == isQ.SupplierID)
            .Where(isQ.SRPayableStatus=="2" && isQ.IsVoid == false);
            //isC.Load(isQ);

            //foreach (InvoiceSupplier iS in isC)
            //{
                
            //}
            
            DataTable dt = new DataTable();
            try
            {
                dt = isQ.LoadDataTable();
            }
            catch (Exception ex)
            {
                string error = ex.Message;
            }
            return dt;
        }

        [DirectMethod]
        public void ProceesData_Click(string invoiceNo)
        {
            tm1.StartAll();
            HttpContext.Current.Session["isProcess"] = false;
            gpInvoices.Title = invoiceNo;
            InvoiceSupplier iS = new InvoiceSupplier();
            iS.es.Connection.Name = "KENCANA";
            if (iS.LoadByPrimaryKey(invoiceNo))
            {
                gpInvoices.Title = iS.InvoiceNotes + " " + iS.SupplierID;
            }

            var win = new Window()
            {
                ID = "window1",
                Title = "Proses Invoice Number : " + invoiceNo,
                Width = Unit.Pixel(800),
                Height = Unit.Pixel(600),
                Modal = true,
                AutoRender = false,
                Collapsible = false,
                Maximizable = false,
                Hidden = true, 
                Draggable = false, 
                Resizable = false
            };
            win.AutoLoad.Url = "~/Transaksi/TransaksiTarikDataPembayaranProcess.aspx?invoiceno=" + invoiceNo;
            win.AutoLoad.Mode = Ext.Net.LoadMode.IFrame;
            win.AutoLoad.ShowMask = true;            
            //win.Center();
            //win.Show();

            //this.Form.Controls.Add(win);
            win.Render(this.Form);
            win.Show();
        }

        [DirectMethod]
        public void Refresh_Grid()
        {
            if (HttpContext.Current.Session["isProcess"] == null)
            {
                tm1.StopAll();
                return;
            }
            if ((bool)HttpContext.Current.Session["isProcess"] == false)
                return;
            else
            {
                this.storeInvoice.DataSource = GetDataTable();
                this.storeInvoice.DataBind();
                HttpContext.Current.Session["isProcess"] = false;
                tm1.StopAll();
            }
        }
    }
}