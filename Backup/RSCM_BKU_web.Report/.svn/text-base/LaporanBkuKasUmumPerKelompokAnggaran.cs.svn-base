namespace RSCM_BKU_web.Report
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;
    using Telerik.Reporting;
    using Telerik.Reporting.Drawing;

    /// <summary>
    /// Summary description for LaporanBkuKasUmumPerKelompokAnggaran.
    /// </summary>
    public partial class LaporanBkuKasUmumPerKelompokAnggaran : Telerik.Reporting.Report
    {
        public LaporanBkuKasUmumPerKelompokAnggaran()
        {
            //
            // Required for telerik Reporting designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
            txtHeaderTanggal.Value = "Tanggal :  " + (this.ReportParameters[0]).ToString() + " s/d " + this.ReportParameters[1].ToString();
        }
    }
}