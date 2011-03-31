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
            AppUser AppUser = new AppUser();
            if (AppUser.LoadByPrimaryKey(txtUserId.Text.Trim()))
            {
                if (AppUser.Password == AEScipher.Encrypt(txtUserId.Text, txtPassword.Text))
                {
                    HttpContext.Current.Session["UserId"] = AppUser.UserID;
                    HttpContext.Current.Session["UserName"] = AppUser.UserName;

                    AuditTrail AuditTrail = new AuditTrail();
                    AuditTrail.ItemAction = "Login per Tanggal : " + DateTime.Now.ToShortDateString() + " , untuk UserID : " + AppUser.UserID;
                    AuditTrail.Aksi = "LOGIN";
                    AuditTrail.DateAction = DateTime.Now;
                    AuditTrail.Save();
                }
            }
            //else
            //{
            //    AppUser.UserID = "toro";
            //    AppUser.UserName = "Tri Noviantoro";
            //    AppUser.Password = AEScipher.Encrypt(txtUserId.Text,txtPassword.Text);
            //    AppUser.Save();
            //}
            //string ciphertext = AEScipher.Encrypt(txtUserId.Text, txtPassword.Text);
            //this.Title = ciphertext + " - " + AEScipher.Decrypt(ciphertext,txtPassword.Text);
        }
    }
}