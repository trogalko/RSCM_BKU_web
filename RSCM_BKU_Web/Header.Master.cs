using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RSCM_BKU_Web
{
    public partial class Header1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {            
            if (HttpContext.Current.Session["UserId"] == null)
                Response.Redirect("~/Login/Login.aspx");
            string userId = HttpContext.Current.Session["UserId"].ToString();
            if (!string.IsNullOrEmpty(userId))
            {
                lblUserName.Text = HttpContext.Current.Session["UserName"].ToString();
                lnkLogin.Text = "Logout";
            }
            else
                Response.Redirect("~/Login/Login.aspx");
        }

        

        protected void lnkLogin_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Session.RemoveAll();
            Session.Clear();
            Response.Redirect("~/Login/Login.aspx");            
        }
    }
}