﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
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
using System.IO;

namespace RSCM_BKU_Web
{
    public partial class Default : System.Web.UI.Page
    {
        //doo
        private RscmBkuDataContext rscm = new RscmBkuDataContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            Title = Path.GetFileName(Request.PhysicalPath);
            string userLoggedIn = (string)HttpContext.Current.Session["UserId"];
            this.Title = "Welcome " + userLoggedIn + " into RSCM Kencana's Buku Kas Umum";
            if (!string.IsNullOrEmpty(userLoggedIn))
            {
                var per = from p in rscm.PeriodeAnggarans
                          where p.Is_Closed == false
                          select p;
                foreach (RSCM_BKU_Web.Linq.PeriodeAnggaran pp in per)
                {
                    HttpContext.Current.Session["_periodeId"] = (Int32)pp.id;
                }
            }
            else
                Response.Redirect("~/Login/Login.aspx");
        }
    }
}