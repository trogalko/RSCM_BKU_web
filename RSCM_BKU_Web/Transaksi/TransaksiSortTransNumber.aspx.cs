using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Ext.Net;
using RSCM_BKU_Web.BusinessObjects;
using System.Data;

namespace RSCM_BKU_Web.Transaksi
{
    public partial class TransaksiSortTransNumber : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        [DirectMethod]
        public void Proses()
        {
            if (string.IsNullOrEmpty(txtTransNumber.Text.Trim()))
                return;
            X.Msg.Confirm("Continue", "Confirm", new MessageBoxButtonsConfig
            {
                Yes = new MessageBoxButtonConfig
                {
                    Handler = "Ext.net.DirectMethods.Proceed()",
                    Text = "Yes"
                },
                No = new MessageBoxButtonConfig
                {
                    Handler = "Ext.net.DirectMethods.Stop()",
                    Text = "No"
                }
            }).Show();
        }

        [DirectMethod]
        public void Proceed()
        {
            int lasnumber = 0;
            DateTime transdate = DateTime.Now;
            TransQuery trans = new TransQuery("a");
            trans.SelectAll();
            trans.Where(trans.TransNumber >= txtTransNumber.Text.Trim());
            trans.OrderBy(trans.TransNumber.Ascending,trans.BkuId.Ascending);

            TransCollection tC = new TransCollection();
            if (tC.Load(trans))
            {
                string autonumber = "201212-0438";
                int count = 438;
                foreach (Trans t in tC)
                {                    
                    Trans tt = new Trans();
                    if (tt.LoadByPrimaryKey((long)t.BkuId))
                    {
                        string number = count.ToString().Trim();
                        if (number.Length == 3)
                            number = "0" + number;
                        tt.TransNumber = "201212-" + number;
                        tt.Save();
                        count++;
                    }
                }
            }
        }

        [DirectMethod]
        public void Stop()
        {
            return;
        }
    }
}