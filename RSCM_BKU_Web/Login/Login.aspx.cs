using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using RSCM_BKU_Web.BusinessObjects;
using RSCM_BKU_Web.Linq;
using System.Threading;
using System.Drawing;

namespace RSCM_BKU_Web.Login
{
    public partial class Login : System.Web.UI.Page
    {
        private RscmBkuDataContext rscm = new RscmBkuDataContext();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            txtUserId.Text = string.Empty;
            txtPassword.Text = string.Empty;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {            
            BusinessObjects.AppUser AppUser = new BusinessObjects.AppUser();
            this.Title = "Welcome " + txtUserId.Text + " into RSCM Kencana's Buku Kas Umum";
            if (AppUser.LoadByPrimaryKey(txtUserId.Text.Trim()))
            {
                if (AppUser.Password == AEScipher.Encrypt(txtUserId.Text, txtPassword.Text))
                {
                    HttpContext.Current.Session["UserId"] = AppUser.UserID;
                    HttpContext.Current.Session["UserName"] = AppUser.UserName;

                    AuditTrail AuditTrail = new AuditTrail();
                    string itemAction = "Login per Tanggal : " + DateTime.Now.ToShortDateString() + " , untuk UserID : " + AppUser.UserID;
                    if (itemAction.Length > 200)
                        itemAction = itemAction.Substring(0, 200);
                    AuditTrail.ItemAction = itemAction;
                    AuditTrail.Aksi = "LOGIN";
                    AuditTrail.DateAction = DateTime.Now;
                    AuditTrail.Save();
                    Response.Redirect("~/Default.aspx");
                }
                else
                {
                    //HttpContext.Current.Session["UserId"] = AppUser.UserID;
                    //HttpContext.Current.Session["UserName"] = AppUser.UserName;
                    //Response.Redirect("~/Default.aspx");
                    return;
                }
            }
            else
            {
                //HttpContext.Current.Session["UserId"] = AppUser.UserID;
                //HttpContext.Current.Session["UserName"] = AppUser.UserName;
                //Response.Redirect("~/Default.aspx");
                return;
            }
        }
    }
}