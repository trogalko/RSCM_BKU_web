namespace RSCM_BKU_web.Report
{
    partial class LaporanTransBKUPerMA
    {
        #region Component Designer generated code
        /// <summary>
        /// Required method for telerik Reporting designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Telerik.Reporting.Drawing.FormattingRule formattingRule1 = new Telerik.Reporting.Drawing.FormattingRule();
            Telerik.Reporting.Drawing.FormattingRule formattingRule2 = new Telerik.Reporting.Drawing.FormattingRule();
            Telerik.Reporting.Drawing.FormattingRule formattingRule3 = new Telerik.Reporting.Drawing.FormattingRule();
            Telerik.Reporting.Drawing.FormattingRule formattingRule4 = new Telerik.Reporting.Drawing.FormattingRule();
            Telerik.Reporting.Drawing.FormattingRule formattingRule5 = new Telerik.Reporting.Drawing.FormattingRule();
            Telerik.Reporting.Drawing.FormattingRule formattingRule6 = new Telerik.Reporting.Drawing.FormattingRule();
            Telerik.Reporting.Drawing.FormattingRule formattingRule7 = new Telerik.Reporting.Drawing.FormattingRule();
            Telerik.Reporting.Drawing.FormattingRule formattingRule8 = new Telerik.Reporting.Drawing.FormattingRule();
            Telerik.Reporting.Drawing.FormattingRule formattingRule9 = new Telerik.Reporting.Drawing.FormattingRule();
            Telerik.Reporting.Drawing.FormattingRule formattingRule10 = new Telerik.Reporting.Drawing.FormattingRule();
            Telerik.Reporting.Drawing.FormattingRule formattingRule11 = new Telerik.Reporting.Drawing.FormattingRule();
            Telerik.Reporting.Drawing.FormattingRule formattingRule12 = new Telerik.Reporting.Drawing.FormattingRule();
            Telerik.Reporting.Drawing.FormattingRule formattingRule13 = new Telerik.Reporting.Drawing.FormattingRule();
            Telerik.Reporting.Drawing.FormattingRule formattingRule14 = new Telerik.Reporting.Drawing.FormattingRule();
            Telerik.Reporting.ReportParameter reportParameter1 = new Telerik.Reporting.ReportParameter();
            Telerik.Reporting.ReportParameter reportParameter2 = new Telerik.Reporting.ReportParameter();
            Telerik.Reporting.ReportParameter reportParameter3 = new Telerik.Reporting.ReportParameter();
            Telerik.Reporting.ReportParameter reportParameter4 = new Telerik.Reporting.ReportParameter();
            Telerik.Reporting.ReportParameter reportParameter5 = new Telerik.Reporting.ReportParameter();
            Telerik.Reporting.ReportParameter reportParameter6 = new Telerik.Reporting.ReportParameter();
            this.detail = new Telerik.Reporting.DetailSection();
            this.txtTRANS_DATE = new Telerik.Reporting.TextBox();
            this.txtDESCRIPT = new Telerik.Reporting.TextBox();
            this.txtDEBIT_AMOUNT = new Telerik.Reporting.TextBox();
            this.txtCREDIT_AMOUNT = new Telerik.Reporting.TextBox();
            this.txtSALDO = new Telerik.Reporting.TextBox();
            this.txtMA = new Telerik.Reporting.TextBox();
            this.txtCEK_BG_NUMBER = new Telerik.Reporting.TextBox();
            this.txtKA_CODE = new Telerik.Reporting.TextBox();
            this.textBox1 = new Telerik.Reporting.TextBox();
            this.textBox2 = new Telerik.Reporting.TextBox();
            this.textBox3 = new Telerik.Reporting.TextBox();
            this.textBox4 = new Telerik.Reporting.TextBox();
            this.textBox5 = new Telerik.Reporting.TextBox();
            this.textBox6 = new Telerik.Reporting.TextBox();
            this.textBox7 = new Telerik.Reporting.TextBox();
            this.pageHeaderSection1 = new Telerik.Reporting.PageHeaderSection();
            this.pictureBox2 = new Telerik.Reporting.PictureBox();
            this.textBox9 = new Telerik.Reporting.TextBox();
            this.pictureBox1 = new Telerik.Reporting.PictureBox();
            this.textBox10 = new Telerik.Reporting.TextBox();
            this.textBox11 = new Telerik.Reporting.TextBox();
            this.reportFooterSection1 = new Telerik.Reporting.ReportFooterSection();
            this.textBox23 = new Telerik.Reporting.TextBox();
            this.textBox22 = new Telerik.Reporting.TextBox();
            this.textBox26 = new Telerik.Reporting.TextBox();
            this.textBox24 = new Telerik.Reporting.TextBox();
            this.textBox29 = new Telerik.Reporting.TextBox();
            this.textBox28 = new Telerik.Reporting.TextBox();
            this.txtDateTimeNow = new Telerik.Reporting.TextBox();
            this.textBox27 = new Telerik.Reporting.TextBox();
            this.textBox31 = new Telerik.Reporting.TextBox();
            this.textBox30 = new Telerik.Reporting.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // detail
            // 
            this.detail.Height = new Telerik.Reporting.Drawing.Unit(0.20003955066204071D, Telerik.Reporting.Drawing.UnitType.Inch);
            this.detail.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.txtTRANS_DATE,
            this.txtDESCRIPT,
            this.txtDEBIT_AMOUNT,
            this.txtCREDIT_AMOUNT,
            this.txtSALDO,
            this.txtMA,
            this.txtCEK_BG_NUMBER,
            this.txtKA_CODE});
            this.detail.Name = "detail";
            // 
            // txtTRANS_DATE
            // 
            this.txtTRANS_DATE.CanGrow = false;
            formattingRule1.Filters.AddRange(new Telerik.Reporting.Data.Filter[] {
            new Telerik.Reporting.Data.Filter("= Fields.TRANS_NUMBER", Telerik.Reporting.Data.FilterOperator.Equal, "X")});
            formattingRule1.Style.BackgroundColor = System.Drawing.SystemColors.GrayText;
            formattingRule2.Filters.AddRange(new Telerik.Reporting.Data.Filter[] {
            new Telerik.Reporting.Data.Filter("Fields.DESCRIPT", Telerik.Reporting.Data.FilterOperator.Equal, "SALDO AKHIR")});
            formattingRule2.Style.BackgroundColor = System.Drawing.SystemColors.GrayText;
            this.txtTRANS_DATE.ConditionalFormatting.AddRange(new Telerik.Reporting.Drawing.FormattingRule[] {
            formattingRule1,
            formattingRule2});
            this.txtTRANS_DATE.Culture = new System.Globalization.CultureInfo("id-ID");
            this.txtTRANS_DATE.Format = "{0:d}";
            this.txtTRANS_DATE.Location = new Telerik.Reporting.Drawing.PointU(new Telerik.Reporting.Drawing.Unit(0D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.00010012308484874666D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.txtTRANS_DATE.Name = "txtTRANS_DATE";
            this.txtTRANS_DATE.Size = new Telerik.Reporting.Drawing.SizeU(new Telerik.Reporting.Drawing.Unit(1.5240001678466797D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.50800031423568726D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.txtTRANS_DATE.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Solid;
            this.txtTRANS_DATE.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid;
            this.txtTRANS_DATE.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Solid;
            this.txtTRANS_DATE.Style.Font.Size = new Telerik.Reporting.Drawing.Unit(6D, Telerik.Reporting.Drawing.UnitType.Point);
            this.txtTRANS_DATE.Style.Padding.Left = new Telerik.Reporting.Drawing.Unit(3D, Telerik.Reporting.Drawing.UnitType.Mm);
            this.txtTRANS_DATE.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.txtTRANS_DATE.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.txtTRANS_DATE.Value = "=TRANS_DATE";
            // 
            // txtDESCRIPT
            // 
            this.txtDESCRIPT.CanGrow = false;
            formattingRule3.Filters.AddRange(new Telerik.Reporting.Data.Filter[] {
            new Telerik.Reporting.Data.Filter("= Fields.TRANS_NUMBER", Telerik.Reporting.Data.FilterOperator.Equal, "X")});
            formattingRule3.Style.BackgroundColor = System.Drawing.SystemColors.GrayText;
            formattingRule4.Filters.AddRange(new Telerik.Reporting.Data.Filter[] {
            new Telerik.Reporting.Data.Filter("=Fields.DESCRIPT", Telerik.Reporting.Data.FilterOperator.Equal, "SALDO AKHIR")});
            formattingRule4.Style.BackgroundColor = System.Drawing.SystemColors.GrayText;
            formattingRule4.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Solid;
            formattingRule4.Style.Font.Bold = true;
            this.txtDESCRIPT.ConditionalFormatting.AddRange(new Telerik.Reporting.Drawing.FormattingRule[] {
            formattingRule3,
            formattingRule4});
            this.txtDESCRIPT.Location = new Telerik.Reporting.Drawing.PointU(new Telerik.Reporting.Drawing.Unit(1.5241999626159668D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.00010012308484874666D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.txtDESCRIPT.Name = "txtDESCRIPT";
            this.txtDESCRIPT.Size = new Telerik.Reporting.Drawing.SizeU(new Telerik.Reporting.Drawing.Unit(8.6355991363525391D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.50800031423568726D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.txtDESCRIPT.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Solid;
            this.txtDESCRIPT.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Solid;
            this.txtDESCRIPT.Style.Font.Size = new Telerik.Reporting.Drawing.Unit(6D, Telerik.Reporting.Drawing.UnitType.Point);
            this.txtDESCRIPT.Style.Padding.Left = new Telerik.Reporting.Drawing.Unit(3D, Telerik.Reporting.Drawing.UnitType.Mm);
            this.txtDESCRIPT.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.txtDESCRIPT.Value = "=DESCRIPT";
            // 
            // txtDEBIT_AMOUNT
            // 
            this.txtDEBIT_AMOUNT.CanGrow = false;
            formattingRule5.Filters.AddRange(new Telerik.Reporting.Data.Filter[] {
            new Telerik.Reporting.Data.Filter("= Fields.TRANS_NUMBER", Telerik.Reporting.Data.FilterOperator.Equal, "X")});
            formattingRule5.Style.BackgroundColor = System.Drawing.SystemColors.GrayText;
            formattingRule6.Filters.AddRange(new Telerik.Reporting.Data.Filter[] {
            new Telerik.Reporting.Data.Filter("Fields.DESCRIPT", Telerik.Reporting.Data.FilterOperator.Equal, "SALDO AKHIR")});
            formattingRule6.Style.BackgroundColor = System.Drawing.SystemColors.GrayText;
            this.txtDEBIT_AMOUNT.ConditionalFormatting.AddRange(new Telerik.Reporting.Drawing.FormattingRule[] {
            formattingRule5,
            formattingRule6});
            this.txtDEBIT_AMOUNT.Culture = new System.Globalization.CultureInfo("id-ID");
            this.txtDEBIT_AMOUNT.Format = "{0:N2}";
            this.txtDEBIT_AMOUNT.Location = new Telerik.Reporting.Drawing.PointU(new Telerik.Reporting.Drawing.Unit(12.699999809265137D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.txtDEBIT_AMOUNT.Name = "txtDEBIT_AMOUNT";
            this.txtDEBIT_AMOUNT.Size = new Telerik.Reporting.Drawing.SizeU(new Telerik.Reporting.Drawing.Unit(2.5398004055023193D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.50800031423568726D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.txtDEBIT_AMOUNT.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Solid;
            this.txtDEBIT_AMOUNT.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Solid;
            this.txtDEBIT_AMOUNT.Style.Font.Size = new Telerik.Reporting.Drawing.Unit(6D, Telerik.Reporting.Drawing.UnitType.Point);
            this.txtDEBIT_AMOUNT.Style.Padding.Right = new Telerik.Reporting.Drawing.Unit(3D, Telerik.Reporting.Drawing.UnitType.Mm);
            this.txtDEBIT_AMOUNT.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right;
            this.txtDEBIT_AMOUNT.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.txtDEBIT_AMOUNT.Value = "=DEBIT_AMOUNT";
            // 
            // txtCREDIT_AMOUNT
            // 
            this.txtCREDIT_AMOUNT.CanGrow = false;
            formattingRule7.Filters.AddRange(new Telerik.Reporting.Data.Filter[] {
            new Telerik.Reporting.Data.Filter("= Fields.TRANS_NUMBER", Telerik.Reporting.Data.FilterOperator.Equal, "X")});
            formattingRule7.Style.BackgroundColor = System.Drawing.SystemColors.GrayText;
            formattingRule8.Filters.AddRange(new Telerik.Reporting.Data.Filter[] {
            new Telerik.Reporting.Data.Filter("Fields.DESCRIPT", Telerik.Reporting.Data.FilterOperator.Equal, "SALDO AKHIR")});
            formattingRule8.Style.BackgroundColor = System.Drawing.SystemColors.GrayText;
            this.txtCREDIT_AMOUNT.ConditionalFormatting.AddRange(new Telerik.Reporting.Drawing.FormattingRule[] {
            formattingRule7,
            formattingRule8});
            this.txtCREDIT_AMOUNT.Culture = new System.Globalization.CultureInfo("id-ID");
            this.txtCREDIT_AMOUNT.DocumentMapText = "";
            this.txtCREDIT_AMOUNT.Format = "{0:N2}";
            this.txtCREDIT_AMOUNT.Location = new Telerik.Reporting.Drawing.PointU(new Telerik.Reporting.Drawing.Unit(15.239999771118164D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.00010012308484874666D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.txtCREDIT_AMOUNT.Name = "txtCREDIT_AMOUNT";
            this.txtCREDIT_AMOUNT.Size = new Telerik.Reporting.Drawing.SizeU(new Telerik.Reporting.Drawing.Unit(2.5397980213165283D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.50800031423568726D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.txtCREDIT_AMOUNT.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Solid;
            this.txtCREDIT_AMOUNT.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Solid;
            this.txtCREDIT_AMOUNT.Style.Font.Size = new Telerik.Reporting.Drawing.Unit(6D, Telerik.Reporting.Drawing.UnitType.Point);
            this.txtCREDIT_AMOUNT.Style.Padding.Right = new Telerik.Reporting.Drawing.Unit(3D, Telerik.Reporting.Drawing.UnitType.Mm);
            this.txtCREDIT_AMOUNT.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right;
            this.txtCREDIT_AMOUNT.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.txtCREDIT_AMOUNT.Value = "= CREDIT_AMOUNT";
            // 
            // txtSALDO
            // 
            this.txtSALDO.CanGrow = false;
            formattingRule9.Filters.AddRange(new Telerik.Reporting.Data.Filter[] {
            new Telerik.Reporting.Data.Filter("= Fields.TRANS_NUMBER", Telerik.Reporting.Data.FilterOperator.Equal, "X")});
            formattingRule9.Style.BackgroundColor = System.Drawing.SystemColors.GrayText;
            formattingRule10.Filters.AddRange(new Telerik.Reporting.Data.Filter[] {
            new Telerik.Reporting.Data.Filter("Fields.DESCRIPT", Telerik.Reporting.Data.FilterOperator.Equal, "SALDO AKHIR")});
            formattingRule10.Style.BackgroundColor = System.Drawing.SystemColors.GrayText;
            formattingRule10.Style.Font.Bold = true;
            this.txtSALDO.ConditionalFormatting.AddRange(new Telerik.Reporting.Drawing.FormattingRule[] {
            formattingRule9,
            formattingRule10});
            this.txtSALDO.Culture = new System.Globalization.CultureInfo("id-ID");
            this.txtSALDO.Format = "{0:N2}";
            this.txtSALDO.Location = new Telerik.Reporting.Drawing.PointU(new Telerik.Reporting.Drawing.Unit(17.779998779296875D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.00010012308484874666D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.txtSALDO.Name = "txtSALDO";
            this.txtSALDO.Size = new Telerik.Reporting.Drawing.SizeU(new Telerik.Reporting.Drawing.Unit(2.5398998260498047D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.50800031423568726D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.txtSALDO.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Solid;
            this.txtSALDO.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Solid;
            this.txtSALDO.Style.Font.Size = new Telerik.Reporting.Drawing.Unit(6D, Telerik.Reporting.Drawing.UnitType.Point);
            this.txtSALDO.Style.Padding.Right = new Telerik.Reporting.Drawing.Unit(3D, Telerik.Reporting.Drawing.UnitType.Mm);
            this.txtSALDO.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right;
            this.txtSALDO.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.txtSALDO.Value = "=SALDO";
            // 
            // txtMA
            // 
            this.txtMA.CanGrow = false;
            formattingRule11.Filters.AddRange(new Telerik.Reporting.Data.Filter[] {
            new Telerik.Reporting.Data.Filter("= Fields.TRANS_NUMBER", Telerik.Reporting.Data.FilterOperator.Equal, "X")});
            formattingRule11.Style.BackgroundColor = System.Drawing.SystemColors.GrayText;
            formattingRule12.Filters.AddRange(new Telerik.Reporting.Data.Filter[] {
            new Telerik.Reporting.Data.Filter("Fields.DESCRIPT", Telerik.Reporting.Data.FilterOperator.Equal, "SALDO AKHIR")});
            formattingRule12.Style.BackgroundColor = System.Drawing.SystemColors.GrayText;
            this.txtMA.ConditionalFormatting.AddRange(new Telerik.Reporting.Drawing.FormattingRule[] {
            formattingRule11,
            formattingRule12});
            this.txtMA.Location = new Telerik.Reporting.Drawing.PointU(new Telerik.Reporting.Drawing.Unit(10.159999847412109D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.00010032494901679456D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.txtMA.Name = "txtMA";
            this.txtMA.Size = new Telerik.Reporting.Drawing.SizeU(new Telerik.Reporting.Drawing.Unit(1.2697997093200684D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.50800013542175293D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.txtMA.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Solid;
            this.txtMA.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Solid;
            this.txtMA.Style.Font.Size = new Telerik.Reporting.Drawing.Unit(6D, Telerik.Reporting.Drawing.UnitType.Point);
            this.txtMA.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.txtMA.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.txtMA.Value = "=GT_CODE";
            // 
            // txtCEK_BG_NUMBER
            // 
            this.txtCEK_BG_NUMBER.CanGrow = false;
            formattingRule13.Filters.AddRange(new Telerik.Reporting.Data.Filter[] {
            new Telerik.Reporting.Data.Filter("= Fields.TRANS_NUMBER", Telerik.Reporting.Data.FilterOperator.Equal, "X")});
            formattingRule13.Style.BackgroundColor = System.Drawing.SystemColors.GrayText;
            formattingRule14.Filters.AddRange(new Telerik.Reporting.Data.Filter[] {
            new Telerik.Reporting.Data.Filter("Fields.DESCRIPT", Telerik.Reporting.Data.FilterOperator.Equal, "SALDO AKHIR")});
            formattingRule14.Style.BackgroundColor = System.Drawing.SystemColors.GrayText;
            this.txtCEK_BG_NUMBER.ConditionalFormatting.AddRange(new Telerik.Reporting.Drawing.FormattingRule[] {
            formattingRule13,
            formattingRule14});
            this.txtCEK_BG_NUMBER.Location = new Telerik.Reporting.Drawing.PointU(new Telerik.Reporting.Drawing.Unit(11.429999351501465D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.00010052680590888485D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.txtCEK_BG_NUMBER.Name = "txtCEK_BG_NUMBER";
            this.txtCEK_BG_NUMBER.Size = new Telerik.Reporting.Drawing.SizeU(new Telerik.Reporting.Drawing.Unit(1.2697997093200684D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.50799989700317383D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.txtCEK_BG_NUMBER.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Solid;
            this.txtCEK_BG_NUMBER.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Solid;
            this.txtCEK_BG_NUMBER.Style.Font.Size = new Telerik.Reporting.Drawing.Unit(6D, Telerik.Reporting.Drawing.UnitType.Point);
            this.txtCEK_BG_NUMBER.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
            this.txtCEK_BG_NUMBER.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.txtCEK_BG_NUMBER.Value = "=CEK_BG_NUMBER";
            // 
            // txtKA_CODE
            // 
            this.txtKA_CODE.CanGrow = false;
            this.txtKA_CODE.Location = new Telerik.Reporting.Drawing.PointU(new Telerik.Reporting.Drawing.Unit(3.3020000457763672D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.txtKA_CODE.Name = "txtKA_CODE";
            this.txtKA_CODE.Size = new Telerik.Reporting.Drawing.SizeU(new Telerik.Reporting.Drawing.Unit(2.0320005416870117D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.50800013542175293D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.txtKA_CODE.Style.Visible = false;
            this.txtKA_CODE.Value = "=TRANS_NUMBER";
            // 
            // textBox1
            // 
            this.textBox1.CanGrow = false;
            this.textBox1.Location = new Telerik.Reporting.Drawing.PointU(new Telerik.Reporting.Drawing.Unit(0D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(3.9622995853424072D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new Telerik.Reporting.Drawing.SizeU(new Telerik.Reporting.Drawing.Unit(1.5240001678466797D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.50800013542175293D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.textBox1.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox1.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox1.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox1.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox1.Style.Font.Bold = true;
            this.textBox1.Style.Font.Size = new Telerik.Reporting.Drawing.Unit(6D, Telerik.Reporting.Drawing.UnitType.Point);
            this.textBox1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.textBox1.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox1.Value = "Tgl. Transaksi";
            // 
            // textBox2
            // 
            this.textBox2.CanGrow = false;
            this.textBox2.Location = new Telerik.Reporting.Drawing.PointU(new Telerik.Reporting.Drawing.Unit(1.5242003202438355D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(3.9622995853424072D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new Telerik.Reporting.Drawing.SizeU(new Telerik.Reporting.Drawing.Unit(8.6355991363525391D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.50800013542175293D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.textBox2.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox2.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox2.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox2.Style.Font.Bold = true;
            this.textBox2.Style.Font.Size = new Telerik.Reporting.Drawing.Unit(6D, Telerik.Reporting.Drawing.UnitType.Point);
            this.textBox2.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.textBox2.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox2.Value = "Uraian";
            // 
            // textBox3
            // 
            this.textBox3.CanGrow = false;
            this.textBox3.Location = new Telerik.Reporting.Drawing.PointU(new Telerik.Reporting.Drawing.Unit(10.159999847412109D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(3.9622995853424072D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new Telerik.Reporting.Drawing.SizeU(new Telerik.Reporting.Drawing.Unit(1.2697997093200684D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.50800013542175293D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.textBox3.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox3.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox3.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox3.Style.Font.Bold = true;
            this.textBox3.Style.Font.Size = new Telerik.Reporting.Drawing.Unit(6D, Telerik.Reporting.Drawing.UnitType.Point);
            this.textBox3.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.textBox3.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox3.Value = "MA";
            // 
            // textBox4
            // 
            this.textBox4.CanGrow = false;
            this.textBox4.Location = new Telerik.Reporting.Drawing.PointU(new Telerik.Reporting.Drawing.Unit(11.429999351501465D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(3.9622995853424072D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new Telerik.Reporting.Drawing.SizeU(new Telerik.Reporting.Drawing.Unit(1.2697997093200684D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.50800013542175293D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.textBox4.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox4.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox4.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox4.Style.Font.Bold = true;
            this.textBox4.Style.Font.Size = new Telerik.Reporting.Drawing.Unit(6D, Telerik.Reporting.Drawing.UnitType.Point);
            this.textBox4.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.textBox4.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox4.Value = "Ref";
            // 
            // textBox5
            // 
            this.textBox5.CanGrow = false;
            this.textBox5.Location = new Telerik.Reporting.Drawing.PointU(new Telerik.Reporting.Drawing.Unit(12.699999809265137D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(3.9622995853424072D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new Telerik.Reporting.Drawing.SizeU(new Telerik.Reporting.Drawing.Unit(2.5398004055023193D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.50800013542175293D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.textBox5.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox5.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox5.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox5.Style.Font.Bold = true;
            this.textBox5.Style.Font.Size = new Telerik.Reporting.Drawing.Unit(6D, Telerik.Reporting.Drawing.UnitType.Point);
            this.textBox5.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.textBox5.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox5.Value = "Debit";
            // 
            // textBox6
            // 
            this.textBox6.CanGrow = false;
            this.textBox6.Location = new Telerik.Reporting.Drawing.PointU(new Telerik.Reporting.Drawing.Unit(15.239999771118164D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(3.9622995853424072D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new Telerik.Reporting.Drawing.SizeU(new Telerik.Reporting.Drawing.Unit(2.5397980213165283D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.50800013542175293D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.textBox6.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox6.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox6.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox6.Style.Font.Bold = true;
            this.textBox6.Style.Font.Size = new Telerik.Reporting.Drawing.Unit(6D, Telerik.Reporting.Drawing.UnitType.Point);
            this.textBox6.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.textBox6.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox6.Value = "Credit";
            // 
            // textBox7
            // 
            this.textBox7.CanGrow = false;
            this.textBox7.Location = new Telerik.Reporting.Drawing.PointU(new Telerik.Reporting.Drawing.Unit(17.779998779296875D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(3.9622995853424072D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new Telerik.Reporting.Drawing.SizeU(new Telerik.Reporting.Drawing.Unit(2.5398998260498047D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.50800013542175293D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.textBox7.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox7.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox7.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox7.Style.Font.Bold = true;
            this.textBox7.Style.Font.Size = new Telerik.Reporting.Drawing.Unit(6D, Telerik.Reporting.Drawing.UnitType.Point);
            this.textBox7.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.textBox7.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox7.Value = "Saldo";
            // 
            // pageHeaderSection1
            // 
            this.pageHeaderSection1.Height = new Telerik.Reporting.Drawing.Unit(1.7599999904632568D, Telerik.Reporting.Drawing.UnitType.Inch);
            this.pageHeaderSection1.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.pictureBox2,
            this.textBox9,
            this.pictureBox1,
            this.textBox10,
            this.textBox11,
            this.textBox1,
            this.textBox2,
            this.textBox3,
            this.textBox4,
            this.textBox5,
            this.textBox6,
            this.textBox7});
            this.pageHeaderSection1.Name = "pageHeaderSection1";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new Telerik.Reporting.Drawing.PointU(new Telerik.Reporting.Drawing.Unit(0.50799989700317383D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.25399994850158691D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new Telerik.Reporting.Drawing.SizeU(new Telerik.Reporting.Drawing.Unit(1.7780002355575562D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(1.5242007970809937D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.pictureBox2.Style.BackgroundImage.ImageData = global::RSCM_BKU_web.Report.Properties.Resources.Bakti_Husada;
            this.pictureBox2.Style.BackgroundImage.MimeType = "image/jpeg";
            this.pictureBox2.Style.BackgroundImage.Repeat = Telerik.Reporting.Drawing.BackgroundRepeat.NoRepeat;
            this.pictureBox2.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None;
            // 
            // textBox9
            // 
            this.textBox9.Location = new Telerik.Reporting.Drawing.PointU(new Telerik.Reporting.Drawing.Unit(2.7940001487731934D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.50799989700317383D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new Telerik.Reporting.Drawing.SizeU(new Telerik.Reporting.Drawing.Unit(13.969799041748047D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.76199984550476074D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.textBox9.Style.Font.Bold = true;
            this.textBox9.Style.Font.Size = new Telerik.Reporting.Drawing.Unit(16D, Telerik.Reporting.Drawing.UnitType.Point);
            this.textBox9.Value = "RSUP NASIONAL DR. CIPTO MANGUNKUSUMO";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new Telerik.Reporting.Drawing.PointU(new Telerik.Reporting.Drawing.Unit(17.272001266479492D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.25399994850158691D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new Telerik.Reporting.Drawing.SizeU(new Telerik.Reporting.Drawing.Unit(2.5399999618530273D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(1.5242007970809937D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.pictureBox1.Style.BackgroundImage.ImageData = global::RSCM_BKU_web.Report.Properties.Resources.rscm_kencana;
            this.pictureBox1.Style.BackgroundImage.MimeType = "image/jpeg";
            // 
            // textBox10
            // 
            this.textBox10.Location = new Telerik.Reporting.Drawing.PointU(new Telerik.Reporting.Drawing.Unit(0.00010012308484874666D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(1.7784007787704468D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new Telerik.Reporting.Drawing.SizeU(new Telerik.Reporting.Drawing.Unit(20.319799423217773D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.60000008344650269D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.textBox10.Style.Font.Bold = true;
            this.textBox10.Style.Font.Size = new Telerik.Reporting.Drawing.Unit(12D, Telerik.Reporting.Drawing.UnitType.Point);
            this.textBox10.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.textBox10.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox10.Value = "LAPORAN BUKU KAS UMUM PER KELOMPOK ANGGARAN";
            // 
            // textBox11
            // 
            this.textBox11.Location = new Telerik.Reporting.Drawing.PointU(new Telerik.Reporting.Drawing.Unit(0.00010012308484874666D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(2.37860107421875D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new Telerik.Reporting.Drawing.SizeU(new Telerik.Reporting.Drawing.Unit(20.319799423217773D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.59999990463256836D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.textBox11.Style.Font.Size = new Telerik.Reporting.Drawing.Unit(10D, Telerik.Reporting.Drawing.UnitType.Point);
            this.textBox11.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.textBox11.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox11.Value = "= \"Tanggal : \" + Parameters.StartDate.Value + \" s.d \" + Parameters.EndDate.Value";
            // 
            // reportFooterSection1
            // 
            this.reportFooterSection1.Height = new Telerik.Reporting.Drawing.Unit(2.059999942779541D, Telerik.Reporting.Drawing.UnitType.Inch);
            this.reportFooterSection1.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.textBox23,
            this.textBox22,
            this.textBox26,
            this.textBox24,
            this.textBox29,
            this.textBox28,
            this.txtDateTimeNow,
            this.textBox27,
            this.textBox31,
            this.textBox30});
            this.reportFooterSection1.Name = "reportFooterSection1";
            // 
            // textBox23
            // 
            this.textBox23.Location = new Telerik.Reporting.Drawing.PointU(new Telerik.Reporting.Drawing.Unit(0.25400054454803467D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.86369925737380981D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.textBox23.Name = "textBox23";
            this.textBox23.Size = new Telerik.Reporting.Drawing.SizeU(new Telerik.Reporting.Drawing.Unit(5.0800008773803711D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.50800031423568726D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.textBox23.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
            this.textBox23.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox23.Value = "Kepala Unit RSCM Kencana";
            // 
            // textBox22
            // 
            this.textBox22.Location = new Telerik.Reporting.Drawing.PointU(new Telerik.Reporting.Drawing.Unit(0.25400054454803467D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.35549953579902649D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.textBox22.Name = "textBox22";
            this.textBox22.Size = new Telerik.Reporting.Drawing.SizeU(new Telerik.Reporting.Drawing.Unit(5.0800008773803711D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.5079994797706604D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.textBox22.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
            this.textBox22.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox22.TextWrap = false;
            this.textBox22.Value = "Mengetahui";
            // 
            // textBox26
            // 
            this.textBox26.Location = new Telerik.Reporting.Drawing.PointU(new Telerik.Reporting.Drawing.Unit(0.25400054454803467D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(4.165499210357666D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.textBox26.Name = "textBox26";
            this.textBox26.Size = new Telerik.Reporting.Drawing.SizeU(new Telerik.Reporting.Drawing.Unit(5.0800008773803711D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.5079994797706604D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.textBox26.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
            this.textBox26.Value = "= Parameters.nipkaunit.Value";
            // 
            // textBox24
            // 
            this.textBox24.Location = new Telerik.Reporting.Drawing.PointU(new Telerik.Reporting.Drawing.Unit(0.25400054454803467D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(3.6572997570037842D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.textBox24.Name = "textBox24";
            this.textBox24.Size = new Telerik.Reporting.Drawing.SizeU(new Telerik.Reporting.Drawing.Unit(4.0002002716064453D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.5079994797706604D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.textBox24.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox24.Style.Font.Underline = false;
            this.textBox24.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
            this.textBox24.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox24.Value = "= Parameters.kaunit.Value";
            // 
            // textBox29
            // 
            this.textBox29.Location = new Telerik.Reporting.Drawing.PointU(new Telerik.Reporting.Drawing.Unit(14.986000061035156D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(1.3718998432159424D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.textBox29.Name = "textBox29";
            this.textBox29.Size = new Telerik.Reporting.Drawing.SizeU(new Telerik.Reporting.Drawing.Unit(5.3338990211486816D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.5079994797706604D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.textBox29.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
            this.textBox29.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox29.Value = "RSCM Kencana";
            // 
            // textBox28
            // 
            this.textBox28.Location = new Telerik.Reporting.Drawing.PointU(new Telerik.Reporting.Drawing.Unit(14.986000061035156D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.86369925737380981D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.textBox28.Name = "textBox28";
            this.textBox28.Size = new Telerik.Reporting.Drawing.SizeU(new Telerik.Reporting.Drawing.Unit(5.3338990211486816D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.50800031423568726D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.textBox28.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
            this.textBox28.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox28.Value = "Kepala Sub Unit Keuangan";
            // 
            // txtDateTimeNow
            // 
            this.txtDateTimeNow.Culture = new System.Globalization.CultureInfo("id-ID");
            this.txtDateTimeNow.Format = "{0:dd MMMM yyyy}";
            this.txtDateTimeNow.Location = new Telerik.Reporting.Drawing.PointU(new Telerik.Reporting.Drawing.Unit(16.510097503662109D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.35549953579902649D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.txtDateTimeNow.Name = "txtDateTimeNow";
            this.txtDateTimeNow.Size = new Telerik.Reporting.Drawing.SizeU(new Telerik.Reporting.Drawing.Unit(3.8098013401031494D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.5079994797706604D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.txtDateTimeNow.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
            this.txtDateTimeNow.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.txtDateTimeNow.Value = "= Now()";
            // 
            // textBox27
            // 
            this.textBox27.Location = new Telerik.Reporting.Drawing.PointU(new Telerik.Reporting.Drawing.Unit(14.986000061035156D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.35549953579902649D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.textBox27.Name = "textBox27";
            this.textBox27.Size = new Telerik.Reporting.Drawing.SizeU(new Telerik.Reporting.Drawing.Unit(1.5238968133926392D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.5079994797706604D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.textBox27.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
            this.textBox27.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox27.Value = "Jakarta";
            // 
            // textBox31
            // 
            this.textBox31.Location = new Telerik.Reporting.Drawing.PointU(new Telerik.Reporting.Drawing.Unit(14.986000061035156D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(4.1654987335205078D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.textBox31.Name = "textBox31";
            this.textBox31.Size = new Telerik.Reporting.Drawing.SizeU(new Telerik.Reporting.Drawing.Unit(5.333899974822998D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.50800031423568726D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.textBox31.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
            this.textBox31.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox31.Value = "= Parameters.nipkasub.Value";
            // 
            // textBox30
            // 
            this.textBox30.Location = new Telerik.Reporting.Drawing.PointU(new Telerik.Reporting.Drawing.Unit(14.986000061035156D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(3.6572997570037842D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.textBox30.Name = "textBox30";
            this.textBox30.Size = new Telerik.Reporting.Drawing.SizeU(new Telerik.Reporting.Drawing.Unit(5.333899974822998D, Telerik.Reporting.Drawing.UnitType.Cm), new Telerik.Reporting.Drawing.Unit(0.5079994797706604D, Telerik.Reporting.Drawing.UnitType.Cm));
            this.textBox30.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox30.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
            this.textBox30.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox30.Value = "= Parameters.kasub.Value";
            // 
            // LaporanTransBKUPerMA
            // 
            this.Culture = new System.Globalization.CultureInfo("id-ID");
            this.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.detail,
            this.pageHeaderSection1,
            this.reportFooterSection1});
            this.PageSettings.Landscape = false;
            this.PageSettings.Margins.Bottom = new Telerik.Reporting.Drawing.Unit(0.5D, Telerik.Reporting.Drawing.UnitType.Cm);
            this.PageSettings.Margins.Left = new Telerik.Reporting.Drawing.Unit(0.125D, Telerik.Reporting.Drawing.UnitType.Cm);
            this.PageSettings.Margins.Right = new Telerik.Reporting.Drawing.Unit(0.125D, Telerik.Reporting.Drawing.UnitType.Cm);
            this.PageSettings.Margins.Top = new Telerik.Reporting.Drawing.Unit(0.5D, Telerik.Reporting.Drawing.UnitType.Cm);
            this.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4;
            reportParameter1.Name = "StartDate";
            reportParameter2.Name = "EndDate";
            reportParameter3.Name = "kaunit";
            reportParameter4.Name = "kasub";
            reportParameter5.Name = "nipkaunit";
            reportParameter6.Name = "nipkasub";
            this.ReportParameters.Add(reportParameter1);
            this.ReportParameters.Add(reportParameter2);
            this.ReportParameters.Add(reportParameter3);
            this.ReportParameters.Add(reportParameter4);
            this.ReportParameters.Add(reportParameter5);
            this.ReportParameters.Add(reportParameter6);
            this.Style.BackgroundColor = System.Drawing.Color.White;
            this.UnitOfMeasure = Telerik.Reporting.Drawing.UnitType.Cm;
            this.Width = new Telerik.Reporting.Drawing.Unit(8D, Telerik.Reporting.Drawing.UnitType.Inch);
            this.Name = "LaporanTransBKUPerMA";
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        #endregion

        private Telerik.Reporting.DetailSection detail;
        private Telerik.Reporting.TextBox txtTRANS_DATE;
        private Telerik.Reporting.TextBox txtDESCRIPT;
        private Telerik.Reporting.TextBox txtDEBIT_AMOUNT;
        private Telerik.Reporting.TextBox txtCREDIT_AMOUNT;
        private Telerik.Reporting.TextBox txtSALDO;
        private Telerik.Reporting.TextBox txtMA;
        private Telerik.Reporting.TextBox txtCEK_BG_NUMBER;
        private Telerik.Reporting.TextBox textBox1;
        private Telerik.Reporting.TextBox textBox2;
        private Telerik.Reporting.TextBox textBox3;
        private Telerik.Reporting.TextBox textBox4;
        private Telerik.Reporting.TextBox textBox5;
        private Telerik.Reporting.TextBox textBox6;
        private Telerik.Reporting.TextBox textBox7;
        private Telerik.Reporting.TextBox txtKA_CODE;
        private Telerik.Reporting.PageHeaderSection pageHeaderSection1;
        private Telerik.Reporting.PictureBox pictureBox2;
        private Telerik.Reporting.TextBox textBox9;
        private Telerik.Reporting.PictureBox pictureBox1;
        private Telerik.Reporting.TextBox textBox10;
        private Telerik.Reporting.TextBox textBox11;
        private Telerik.Reporting.ReportFooterSection reportFooterSection1;
        private Telerik.Reporting.TextBox textBox23;
        private Telerik.Reporting.TextBox textBox22;
        private Telerik.Reporting.TextBox textBox26;
        private Telerik.Reporting.TextBox textBox24;
        private Telerik.Reporting.TextBox textBox29;
        private Telerik.Reporting.TextBox textBox28;
        private Telerik.Reporting.TextBox txtDateTimeNow;
        private Telerik.Reporting.TextBox textBox27;
        private Telerik.Reporting.TextBox textBox31;
        private Telerik.Reporting.TextBox textBox30;
    }
}