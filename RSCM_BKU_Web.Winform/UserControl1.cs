#region Using

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;

using Gizmox.WebGUI.Common;
using Gizmox.WebGUI.Forms;

using RSCM_BKU_Web.BusinessObjects;

#endregion

namespace RSCM_BKU_Web.Winform
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
            errorProvider1.SetIconAlignment(textBox1, ErrorIconAlignment.MiddleRight);
            errorProvider1.SetIconPadding(textBox1, 2);
            errorProvider2.SetIconAlignment(textBox2, ErrorIconAlignment.MiddleRight);
            errorProvider2.SetIconPadding(textBox2, 2);
        }

        private void textBox1_Validated(object sender, EventArgs e)
        {
            if (textBox1.Text.Length <= 0)
            {
                errorProvider1.SetError(this.textBox1, string.Empty);
                errorProvider1.SetError(this.textBox1, "Username must be filled");
            }
        }

        private void textBox2_Validated(object sender, EventArgs e)
        {
            if (textBox2.Text.Length <= 0)
            {
                errorProvider2.SetError(this.textBox2, string.Empty);
                errorProvider2.SetError(this.textBox2, "Password must be filled");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AppUser AppUser = new AppUser();
            if (AppUser.LoadByPrimaryKey(textBox1.Text))
            {
                if (AppUser.Password == RSCM_BKU_Web_Winform.AEScipher.Encrypt(textBox1.Text, textBox2.Text))
                {
                    Session["UserId"] = AppUser.UserID;
                    Session["UserName"] = AppUser.UserName;
                    AuditTrail AuditTrail = new AuditTrail();
                    string itemAction = "Login per Tanggal : " + DateTime.Now.ToShortDateString() + " , untuk UserID : " + AppUser.UserID;
                    if (itemAction.Length > 200)
                        itemAction = itemAction.Substring(0, 200);
                    AuditTrail.ItemAction = itemAction;
                    AuditTrail.Aksi = "LOGIN";
                    AuditTrail.DateAction = DateTime.Now;
                    AuditTrail.Save();
                    Context.Redirect("~Default.aspx");
                }
                else
                    return;
            }
            else
                return;
        }
    }
}