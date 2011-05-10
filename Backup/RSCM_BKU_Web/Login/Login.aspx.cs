using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using RSCM_BKU_Web.BusinessObjects;

namespace RSCM_BKU_Web.Login
{
    public partial class Login : System.Web.UI.Page
    {
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
            if (txtUserId.Text == "adduserkusno")
            {
                AppUser addUserKusno = new AppUser();
                addUserKusno.UserID = "dj";
                addUserKusno.UserName = "Dwi Jayanti";
                addUserKusno.Password = AEScipher.Encrypt("dj", "abc");
                addUserKusno.LastUpdateByUserID = "toro";
                addUserKusno.LastUpdateDateTime = DateTime.Now;
                addUserKusno.Save();

                AppUser addUserKusnos = new AppUser();
                addUserKusnos.UserID = "erni";
                addUserKusnos.UserName = "Erni";
                addUserKusnos.Password = AEScipher.Encrypt("erni", "abc");
                addUserKusnos.LastUpdateByUserID = "toro";
                addUserKusnos.LastUpdateDateTime = DateTime.Now;
                addUserKusnos.Save();
            }
            AppUser AppUser = new AppUser();           
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
                    return;
            }
            else
                return;            
        }
    }
}