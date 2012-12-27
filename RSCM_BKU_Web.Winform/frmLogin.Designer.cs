using Gizmox.WebGUI.Forms;
using Gizmox.WebGUI.Common;

namespace RSCM_BKU_Web.Winform
{
    partial class frmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Visual WebGui Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.userControl11 = new RSCM_BKU_Web.Winform.UserControl1();
            this.SuspendLayout();
            // 
            // userControl11
            // 
            this.userControl11.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.userControl11.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.userControl11.Location = new System.Drawing.Point(0, 0);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(800, 600);
            this.userControl11.TabIndex = 0;
            // 
            // frmLogin
            // 
            this.Controls.Add(this.userControl11);
            this.Size = new System.Drawing.Size(800, 600);
            this.Text = "frmLogin";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControl1 userControl11;


    }
}