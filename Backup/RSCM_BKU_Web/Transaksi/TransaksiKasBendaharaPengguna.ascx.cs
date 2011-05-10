using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Telerik.Web.UI;
using Telerik.Web.Design;
using Telerik.Web.Dialogs;
using RSCM_BKU_Web.BusinessObjects;
using EntitySpaces.DynamicQuery;
using EntitySpaces.Core;
using EntitySpaces.Interfaces;
using EntitySpaces.SqlClientProvider;

using RSCM_BKU_Web.Linq;
using System.Globalization;
using System.Threading;
using System.Collections;

namespace RSCM_BKU_Web.Transaksi
{
    public partial class TransaksiKasBendaharaPengguna1 : System.Web.UI.UserControl
    {
        readonly RscmBkuDataContext rscm = new RscmBkuDataContext();
        protected void Page_Load(object sender, EventArgs e)
        {     
            if ((bool)HttpContext.Current.Session["_isEdit"] == false) // ADD
            {
                txtTransCode.Visible = false;
                cmbTransCODE.Visible = true;
                cmbTransCODE.Enabled = true;
                txtKasId.Visible = false;
                cmbKasID.Visible = true;

                //Auto Numbering
                txtTransCode.Text = "{auto}";

                //Trans Code
                //var transCodeQ = new KelAnggaranQuery();
                //transCodeQ.Select(transCodeQ.KaCode, transCodeQ.KaName, (transCodeQ.KaCode + " - " + transCodeQ.KaName).As("KA"));
                //KelAnggaranCollection kAColl = new KelAnggaranCollection()               
                //kAColl.Load(transCodeQ);               

                //var kQ = from k in rscm.Kel_anggarans
                //         where k.IS_DETAIL == true &&
                //         k.IS_KAS == false
                //         select new { k.KA_CODE, KaName = k.KA_NAME, complete = (k.KA_CODE + " - " +k.KA_NAME)};

                //ViewKelAnggaranCodeCombineName vkkk = new ViewKelAnggaranCodeCombineName();
                //vkkk.KaCode
                ViewKelAnggaranCodeCombineNameCollection vKA = new ViewKelAnggaranCodeCombineNameCollection();
                vKA.LoadAll();

                cmbTransCODE.Items.Clear();
                //cmbTransCODE.DataSource = kQ;
                //cmbTransCODE.DataTextField = "complete";
                //cmbTransCODE.DataValueField = "KA_CODE";
                cmbTransCODE.DataSource = vKA;
                cmbTransCODE.DataTextField = "KaCodeName";
                cmbTransCODE.DataValueField = "KaCode";
                cmbTransCODE.AllowCustomText = true;
                cmbTransCODE.MarkFirstMatch = true;
                //cmbTransCODE.DataBind();

                //Kas Code
                var kasCode = from kas in rscm.KAs
                              where kas.PERIODE_ID == (Int32)HttpContext.Current.Session["_periodeId"]
                              select kas;

                cmbKasID.DataSource = kasCode;
                cmbKasID.DataTextField = "KA_NAME";
                cmbKasID.DataValueField = "KA_CODE";
            }
            else //EDIT
            {
                //txtTransCode.Visible = true;
                txtTransCode.Visible = false;
                txtTransCode.ReadOnly = true;
                cmbTransCODE.Visible = true;
                cmbTransCODE.Enabled = true;
                var KelAngQ = from k in rscm.viewKelAnggaranCodeCombineNames
                              select k;

                cmbTransCODE.Items.Clear();
                //cmbTransCODE.DataSource = kQ;
                //cmbTransCODE.DataTextField = "complete";
                //cmbTransCODE.DataValueField = "KA_CODE";

                cmbTransCODE.DataSource = KelAngQ;
                cmbTransCODE.DataTextField = "KaCodeName";
                cmbTransCODE.DataValueField = "KA_CODE";
                cmbTransCODE.AllowCustomText = true;
                cmbTransCODE.MarkFirstMatch = true;

                cmbTransCODE.Visible = true;
                txtKasId.Visible = true;
                txtKasId.ReadOnly = true;
                cmbKasID.Visible = false;
            }
        }

        protected static string FormatCheckBox(object container,string expression)
        {
            string ret = "";
            
            // if column is null set checkbox.checked = false

            if ((DataBinder.Eval(container, expression)).ToString() == "")
                ret = "";
            else // set checkbox.checked to boolean value in Status column
                ret = ((string)DataBinder.Eval(container, expression)).Trim();

            return ret;
        }
        
        protected void cmbTransCODE_DataBound(object sender, EventArgs e)
        {
            var combo = (RadComboBox)sender;
            combo.Items.Insert(0, new RadComboBoxItem(string.Empty, string.Empty));
        }

        protected void cmbKasID_DataBound(object sender, EventArgs e)
        {
            var combo = (RadComboBox)sender;
            combo.Items.Insert(0, new RadComboBoxItem(string.Empty, string.Empty));
        }

        protected void txtTransCode_TextChanged(object sender, EventArgs e)
        {

        }
    }
}