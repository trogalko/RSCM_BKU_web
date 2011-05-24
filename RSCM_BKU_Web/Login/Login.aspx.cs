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
                //AppUser addUserKusno = new AppUser();
                //addUserKusno.UserID = "dj";
                //addUserKusno.UserName = "Dwi Jayanti";
                //addUserKusno.Password = AEScipher.Encrypt("dj", "abc");
                //addUserKusno.LastUpdateByUserID = "toro";
                //addUserKusno.LastUpdateDateTime = DateTime.Now;
                //addUserKusno.Save();

                //AppUser addUserKusnos = new AppUser();
                //addUserKusnos.UserID = "erni";
                //addUserKusnos.UserName = "Erni";
                //addUserKusnos.Password = AEScipher.Encrypt("erni", "abc");
                //addUserKusnos.LastUpdateByUserID = "toro";
                //addUserKusnos.LastUpdateDateTime = DateTime.Now;
                //addUserKusnos.Save();
                TransCollection TransColl = new TransCollection();                
                TransQuery transQ = new TransQuery();
                transQ.SelectAll();
                //transQ.OrderBy("TRANS_DATE");
                TransColl.Load(transQ);
                int number = 0;
                foreach (Trans t in TransColl)
                {
                    if (((DateTime)t.TransDate).Month.ToString().Trim() == "5" || ((DateTime)t.TransDate).Month.ToString().Trim() == "05")
                    {
                        Trans trans = new Trans();
                        if (trans.LoadByPrimaryKey((long)t.BkuId))
                        {
                            number += 1;
                            switch (number.ToString().Trim().Length)
                            {
                                case 0:
                                    
                                    break;
                                case 1:
                                    trans.TransNumber = "201105-000" + number.ToString().Trim();
                                    break;
                                case 2:
                                    trans.TransNumber = "201105-00" + number.ToString().Trim();
                                    break;
                                case 3:
                                    trans.TransNumber = "201105-0" + number.ToString().Trim();
                                    break;
                                case 4:
                                    trans.TransNumber = "201105-" + number.ToString().Trim();
                                    break;
                            }
                            trans.Save();
                        }
                    }
                }
            }
            AppUser AppUser = new AppUser();           
            if (AppUser.LoadByPrimaryKey(txtUserId.Text.Trim()))
            {
                if (AppUser.Password == AEScipher.Encrypt(txtUserId.Text, txtPassword.Text))
                {
                    HttpContext.Current.Session["UserId"] = AppUser.UserID;
                    HttpContext.Current.Session["UserName"] = AppUser.UserName;

                    //System.Web.HttpContext context = System.Web.HttpContext.Current;
                    //string IPAddress = "";
                    
                    //if (string.IsNullOrEmpty(context.Request.ServerVariables["HTTP_X_FORWARDED_FOR"].ToString()))
                    //{
                    //    IPAddress = context.Request.ServerVariables["REMOTE_ADDR"].ToString();
                    //}
                    //else
                    //{
                    //    IPAddress = context.Request.ServerVariables["HTTP_X_FORWARDED_FOR"].ToString();
                    //}

                    //HttpContext.Current.Session["IPAddress"] = IPAddress;

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