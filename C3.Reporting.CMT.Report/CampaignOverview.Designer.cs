namespace C3.Reporting.CMT.Report
{
    partial class CampaignOverview
    {
        #region Component Designer generated code
        /// <summary>
        /// Required method for telerik Reporting designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CampaignOverview));
            Telerik.Reporting.Group group1 = new Telerik.Reporting.Group();
            Telerik.Reporting.ReportParameter reportParameter1 = new Telerik.Reporting.ReportParameter();
            Telerik.Reporting.Drawing.StyleRule styleRule1 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule2 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule3 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule4 = new Telerik.Reporting.Drawing.StyleRule();
            this.segmentDataSource = new Telerik.Reporting.SqlDataSource();
            this.campaignDataSource = new Telerik.Reporting.SqlDataSource();
            this.labelsGroupHeaderSection = new Telerik.Reporting.GroupHeaderSection();
            this.labelsGroupFooterSection = new Telerik.Reporting.GroupFooterSection();
            this.channel_codeCaptionTextBox = new Telerik.Reporting.TextBox();
            this.channel_nameCaptionTextBox = new Telerik.Reporting.TextBox();
            this.channel_type_nameCaptionTextBox = new Telerik.Reporting.TextBox();
            this.created_byCaptionTextBox = new Telerik.Reporting.TextBox();
            this.descriptionCaptionTextBox = new Telerik.Reporting.TextBox();
            this.end_dateCaptionTextBox = new Telerik.Reporting.TextBox();
            this.is_lockedCaptionTextBox = new Telerik.Reporting.TextBox();
            this.offer_codeCaptionTextBox = new Telerik.Reporting.TextBox();
            this.start_dateCaptionTextBox = new Telerik.Reporting.TextBox();
            this.pageHeader = new Telerik.Reporting.PageHeaderSection();
            this.reportNameTextBox = new Telerik.Reporting.TextBox();
            this.pageFooter = new Telerik.Reporting.PageFooterSection();
            this.currentTimeTextBox = new Telerik.Reporting.TextBox();
            this.pageInfoTextBox = new Telerik.Reporting.TextBox();
            this.reportHeader = new Telerik.Reporting.ReportHeaderSection();
            this.titleTextBox = new Telerik.Reporting.TextBox();
            this.reportFooter = new Telerik.Reporting.ReportFooterSection();
            this.detail = new Telerik.Reporting.DetailSection();
            this.channel_codeDataTextBox = new Telerik.Reporting.TextBox();
            this.channel_nameDataTextBox = new Telerik.Reporting.TextBox();
            this.channel_type_nameDataTextBox = new Telerik.Reporting.TextBox();
            this.created_byDataTextBox = new Telerik.Reporting.TextBox();
            this.descriptionDataTextBox = new Telerik.Reporting.TextBox();
            this.end_dateDataTextBox = new Telerik.Reporting.TextBox();
            this.is_lockedDataTextBox = new Telerik.Reporting.TextBox();
            this.offer_codeDataTextBox = new Telerik.Reporting.TextBox();
            this.start_dateDataTextBox = new Telerik.Reporting.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // segmentDataSource
            // 
            this.segmentDataSource.ConnectionString = "C3.Reporting.CMT.Report.Properties.Settings.c3cmtReportConnectionString";
            this.segmentDataSource.Name = "segmentDataSource";
            this.segmentDataSource.Parameters.AddRange(new Telerik.Reporting.SqlDataSourceParameter[] {
            new Telerik.Reporting.SqlDataSourceParameter("@campaignId", System.Data.DbType.String, "=Parameters.campaignId.Value")});
            this.segmentDataSource.SelectCommand = resources.GetString("segmentDataSource.SelectCommand");
            // 
            // campaignDataSource
            // 
            this.campaignDataSource.ConnectionString = "C3.Reporting.CMT.Report.Properties.Settings.c3cmtReportConnectionString";
            this.campaignDataSource.Name = "campaignDataSource";
            this.campaignDataSource.SelectCommand = "SELECT        campaigns.*\r\nFROM            campaigns";
            // 
            // labelsGroupHeaderSection
            // 
            this.labelsGroupHeaderSection.Height = Telerik.Reporting.Drawing.Unit.Cm(1.1058331727981567D);
            this.labelsGroupHeaderSection.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.channel_codeCaptionTextBox,
            this.channel_nameCaptionTextBox,
            this.channel_type_nameCaptionTextBox,
            this.created_byCaptionTextBox,
            this.descriptionCaptionTextBox,
            this.end_dateCaptionTextBox,
            this.is_lockedCaptionTextBox,
            this.offer_codeCaptionTextBox,
            this.start_dateCaptionTextBox});
            this.labelsGroupHeaderSection.Name = "labelsGroupHeaderSection";
            this.labelsGroupHeaderSection.PrintOnEveryPage = true;
            // 
            // labelsGroupFooterSection
            // 
            this.labelsGroupFooterSection.Height = Telerik.Reporting.Drawing.Unit.Cm(0.71437495946884155D);
            this.labelsGroupFooterSection.Name = "labelsGroupFooterSection";
            this.labelsGroupFooterSection.Style.Visible = false;
            // 
            // channel_codeCaptionTextBox
            // 
            this.channel_codeCaptionTextBox.CanGrow = true;
            this.channel_codeCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.channel_codeCaptionTextBox.Name = "channel_codeCaptionTextBox";
            this.channel_codeCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.6983333826065064D), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045D));
            this.channel_codeCaptionTextBox.StyleName = "Caption";
            this.channel_codeCaptionTextBox.Value = "channel_code";
            // 
            // channel_nameCaptionTextBox
            // 
            this.channel_nameCaptionTextBox.CanGrow = true;
            this.channel_nameCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(1.8041666746139526D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.channel_nameCaptionTextBox.Name = "channel_nameCaptionTextBox";
            this.channel_nameCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.6983333826065064D), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045D));
            this.channel_nameCaptionTextBox.StyleName = "Caption";
            this.channel_nameCaptionTextBox.Value = "channel_name";
            // 
            // channel_type_nameCaptionTextBox
            // 
            this.channel_type_nameCaptionTextBox.CanGrow = true;
            this.channel_type_nameCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(3.5554165840148926D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.channel_type_nameCaptionTextBox.Name = "channel_type_nameCaptionTextBox";
            this.channel_type_nameCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.6983333826065064D), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045D));
            this.channel_type_nameCaptionTextBox.StyleName = "Caption";
            this.channel_type_nameCaptionTextBox.Value = "channel_type_name";
            // 
            // created_byCaptionTextBox
            // 
            this.created_byCaptionTextBox.CanGrow = true;
            this.created_byCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(5.3066668510437012D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.created_byCaptionTextBox.Name = "created_byCaptionTextBox";
            this.created_byCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.6983333826065064D), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045D));
            this.created_byCaptionTextBox.StyleName = "Caption";
            this.created_byCaptionTextBox.Value = "created_by";
            // 
            // descriptionCaptionTextBox
            // 
            this.descriptionCaptionTextBox.CanGrow = true;
            this.descriptionCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(7.0579166412353516D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.descriptionCaptionTextBox.Name = "descriptionCaptionTextBox";
            this.descriptionCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.6983333826065064D), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045D));
            this.descriptionCaptionTextBox.StyleName = "Caption";
            this.descriptionCaptionTextBox.Value = "description";
            // 
            // end_dateCaptionTextBox
            // 
            this.end_dateCaptionTextBox.CanGrow = true;
            this.end_dateCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(8.80916690826416D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.end_dateCaptionTextBox.Name = "end_dateCaptionTextBox";
            this.end_dateCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.6983333826065064D), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045D));
            this.end_dateCaptionTextBox.StyleName = "Caption";
            this.end_dateCaptionTextBox.Value = "end_date";
            // 
            // is_lockedCaptionTextBox
            // 
            this.is_lockedCaptionTextBox.CanGrow = true;
            this.is_lockedCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(10.560416221618652D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.is_lockedCaptionTextBox.Name = "is_lockedCaptionTextBox";
            this.is_lockedCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.6983333826065064D), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045D));
            this.is_lockedCaptionTextBox.StyleName = "Caption";
            this.is_lockedCaptionTextBox.Value = "is_locked";
            // 
            // offer_codeCaptionTextBox
            // 
            this.offer_codeCaptionTextBox.CanGrow = true;
            this.offer_codeCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(12.311666488647461D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.offer_codeCaptionTextBox.Name = "offer_codeCaptionTextBox";
            this.offer_codeCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.6983333826065064D), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045D));
            this.offer_codeCaptionTextBox.StyleName = "Caption";
            this.offer_codeCaptionTextBox.Value = "offer_code";
            // 
            // start_dateCaptionTextBox
            // 
            this.start_dateCaptionTextBox.CanGrow = true;
            this.start_dateCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(14.06291675567627D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.start_dateCaptionTextBox.Name = "start_dateCaptionTextBox";
            this.start_dateCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.6983333826065064D), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045D));
            this.start_dateCaptionTextBox.StyleName = "Caption";
            this.start_dateCaptionTextBox.Value = "start_date";
            // 
            // pageHeader
            // 
            this.pageHeader.Height = Telerik.Reporting.Drawing.Unit.Cm(1.1058331727981567D);
            this.pageHeader.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.reportNameTextBox});
            this.pageHeader.Name = "pageHeader";
            // 
            // reportNameTextBox
            // 
            this.reportNameTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.reportNameTextBox.Name = "reportNameTextBox";
            this.reportNameTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(15.708333015441895D), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045D));
            this.reportNameTextBox.StyleName = "PageInfo";
            this.reportNameTextBox.Value = "CampaignOverview";
            // 
            // pageFooter
            // 
            this.pageFooter.Height = Telerik.Reporting.Drawing.Unit.Cm(1.1058331727981567D);
            this.pageFooter.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.currentTimeTextBox,
            this.pageInfoTextBox});
            this.pageFooter.Name = "pageFooter";
            // 
            // currentTimeTextBox
            // 
            this.currentTimeTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.currentTimeTextBox.Name = "currentTimeTextBox";
            this.currentTimeTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(7.8277082443237305D), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045D));
            this.currentTimeTextBox.StyleName = "PageInfo";
            this.currentTimeTextBox.Value = "=NOW()";
            // 
            // pageInfoTextBox
            // 
            this.pageInfoTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(7.9335417747497559D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.pageInfoTextBox.Name = "pageInfoTextBox";
            this.pageInfoTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(7.8277082443237305D), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045D));
            this.pageInfoTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right;
            this.pageInfoTextBox.StyleName = "PageInfo";
            this.pageInfoTextBox.Value = "=PageNumber";
            // 
            // reportHeader
            // 
            this.reportHeader.Height = Telerik.Reporting.Drawing.Unit.Cm(2.0529167652130127D);
            this.reportHeader.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.titleTextBox});
            this.reportHeader.Name = "reportHeader";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0D), Telerik.Reporting.Drawing.Unit.Cm(0D));
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(15.814167022705078D), Telerik.Reporting.Drawing.Unit.Cm(2D));
            this.titleTextBox.StyleName = "Title";
            this.titleTextBox.Value = "Campaign Overview";
            // 
            // reportFooter
            // 
            this.reportFooter.Height = Telerik.Reporting.Drawing.Unit.Cm(0.71437495946884155D);
            this.reportFooter.Name = "reportFooter";
            // 
            // detail
            // 
            this.detail.Height = Telerik.Reporting.Drawing.Unit.Cm(1.1058331727981567D);
            this.detail.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.channel_codeDataTextBox,
            this.channel_nameDataTextBox,
            this.channel_type_nameDataTextBox,
            this.created_byDataTextBox,
            this.descriptionDataTextBox,
            this.end_dateDataTextBox,
            this.is_lockedDataTextBox,
            this.offer_codeDataTextBox,
            this.start_dateDataTextBox});
            this.detail.Name = "detail";
            // 
            // channel_codeDataTextBox
            // 
            this.channel_codeDataTextBox.CanGrow = true;
            this.channel_codeDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.channel_codeDataTextBox.Name = "channel_codeDataTextBox";
            this.channel_codeDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.6983333826065064D), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045D));
            this.channel_codeDataTextBox.StyleName = "Data";
            this.channel_codeDataTextBox.Value = "=Fields.channel_code";
            // 
            // channel_nameDataTextBox
            // 
            this.channel_nameDataTextBox.CanGrow = true;
            this.channel_nameDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(1.8041666746139526D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.channel_nameDataTextBox.Name = "channel_nameDataTextBox";
            this.channel_nameDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.6983333826065064D), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045D));
            this.channel_nameDataTextBox.StyleName = "Data";
            this.channel_nameDataTextBox.Value = "=Fields.channel_name";
            // 
            // channel_type_nameDataTextBox
            // 
            this.channel_type_nameDataTextBox.CanGrow = true;
            this.channel_type_nameDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(3.5554165840148926D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.channel_type_nameDataTextBox.Name = "channel_type_nameDataTextBox";
            this.channel_type_nameDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.6983333826065064D), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045D));
            this.channel_type_nameDataTextBox.StyleName = "Data";
            this.channel_type_nameDataTextBox.Value = "=Fields.channel_type_name";
            // 
            // created_byDataTextBox
            // 
            this.created_byDataTextBox.CanGrow = true;
            this.created_byDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(5.3066668510437012D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.created_byDataTextBox.Name = "created_byDataTextBox";
            this.created_byDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.6983333826065064D), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045D));
            this.created_byDataTextBox.StyleName = "Data";
            this.created_byDataTextBox.Value = "=Fields.created_by";
            // 
            // descriptionDataTextBox
            // 
            this.descriptionDataTextBox.CanGrow = true;
            this.descriptionDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(7.0579166412353516D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.descriptionDataTextBox.Name = "descriptionDataTextBox";
            this.descriptionDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.6983333826065064D), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045D));
            this.descriptionDataTextBox.StyleName = "Data";
            this.descriptionDataTextBox.Value = "=Fields.description";
            // 
            // end_dateDataTextBox
            // 
            this.end_dateDataTextBox.CanGrow = true;
            this.end_dateDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(8.80916690826416D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.end_dateDataTextBox.Name = "end_dateDataTextBox";
            this.end_dateDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.6983333826065064D), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045D));
            this.end_dateDataTextBox.StyleName = "Data";
            this.end_dateDataTextBox.Value = "=Fields.end_date";
            // 
            // is_lockedDataTextBox
            // 
            this.is_lockedDataTextBox.CanGrow = true;
            this.is_lockedDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(10.560416221618652D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.is_lockedDataTextBox.Name = "is_lockedDataTextBox";
            this.is_lockedDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.6983333826065064D), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045D));
            this.is_lockedDataTextBox.StyleName = "Data";
            this.is_lockedDataTextBox.Value = "=Fields.is_locked";
            // 
            // offer_codeDataTextBox
            // 
            this.offer_codeDataTextBox.CanGrow = true;
            this.offer_codeDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(12.311666488647461D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.offer_codeDataTextBox.Name = "offer_codeDataTextBox";
            this.offer_codeDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.6983333826065064D), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045D));
            this.offer_codeDataTextBox.StyleName = "Data";
            this.offer_codeDataTextBox.Value = "=Fields.offer_code";
            // 
            // start_dateDataTextBox
            // 
            this.start_dateDataTextBox.CanGrow = true;
            this.start_dateDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(14.06291675567627D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.start_dateDataTextBox.Name = "start_dateDataTextBox";
            this.start_dateDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.6983333826065064D), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045D));
            this.start_dateDataTextBox.StyleName = "Data";
            this.start_dateDataTextBox.Value = "=Fields.start_date";
            // 
            // CampaignOverview
            // 
            this.DataSource = this.segmentDataSource;
            group1.GroupFooter = this.labelsGroupFooterSection;
            group1.GroupHeader = this.labelsGroupHeaderSection;
            group1.Name = "labelsGroup";
            this.Groups.AddRange(new Telerik.Reporting.Group[] {
            group1});
            this.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.labelsGroupHeaderSection,
            this.labelsGroupFooterSection,
            this.pageHeader,
            this.pageFooter,
            this.reportHeader,
            this.reportFooter,
            this.detail});
            this.Name = "CampaignOverview";
            this.PageSettings.Landscape = true;
            this.PageSettings.Margins = new Telerik.Reporting.Drawing.MarginsU(Telerik.Reporting.Drawing.Unit.Mm(25.399999618530273D), Telerik.Reporting.Drawing.Unit.Mm(25.399999618530273D), Telerik.Reporting.Drawing.Unit.Mm(25.399999618530273D), Telerik.Reporting.Drawing.Unit.Mm(25.399999618530273D));
            this.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4;
            reportParameter1.AvailableValues.DataSource = this.campaignDataSource;
            reportParameter1.AvailableValues.DisplayMember = "= Fields.campaign_name";
            reportParameter1.AvailableValues.ValueMember = "= Fields.campaign_id";
            reportParameter1.Name = "campaignId";
            reportParameter1.Text = "Campaign";
            reportParameter1.Type = Telerik.Reporting.ReportParameterType.Integer;
            reportParameter1.Value = "61";
            reportParameter1.Visible = true;
            this.ReportParameters.Add(reportParameter1);
            this.Style.BackgroundColor = System.Drawing.Color.White;
            styleRule1.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.StyleSelector("Title")});
            styleRule1.Style.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(222)))), ((int)(((byte)(201)))));
            styleRule1.Style.Color = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(39)))), ((int)(((byte)(28)))));
            styleRule1.Style.Font.Name = "Gill Sans MT";
            styleRule1.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(18D);
            styleRule2.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.StyleSelector("Caption")});
            styleRule2.Style.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(222)))), ((int)(((byte)(201)))));
            styleRule2.Style.Color = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(29)))), ((int)(((byte)(20)))));
            styleRule2.Style.Font.Name = "Gill Sans MT";
            styleRule2.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10D);
            styleRule2.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            styleRule3.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.StyleSelector("Data")});
            styleRule3.Style.Color = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(29)))), ((int)(((byte)(20)))));
            styleRule3.Style.Font.Name = "Gill Sans MT";
            styleRule3.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9D);
            styleRule3.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            styleRule4.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.StyleSelector("PageInfo")});
            styleRule4.Style.Color = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(202)))), ((int)(((byte)(189)))));
            styleRule4.Style.Font.Name = "Gill Sans MT";
            styleRule4.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            styleRule4.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.StyleSheet.AddRange(new Telerik.Reporting.Drawing.StyleRule[] {
            styleRule1,
            styleRule2,
            styleRule3,
            styleRule4});
            this.Width = Telerik.Reporting.Drawing.Unit.Cm(15.814167022705078D);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        #endregion

        private Telerik.Reporting.SqlDataSource segmentDataSource;
        private Telerik.Reporting.SqlDataSource campaignDataSource;
        private Telerik.Reporting.GroupHeaderSection labelsGroupHeaderSection;
        private Telerik.Reporting.TextBox channel_codeCaptionTextBox;
        private Telerik.Reporting.TextBox channel_nameCaptionTextBox;
        private Telerik.Reporting.TextBox channel_type_nameCaptionTextBox;
        private Telerik.Reporting.TextBox created_byCaptionTextBox;
        private Telerik.Reporting.TextBox descriptionCaptionTextBox;
        private Telerik.Reporting.TextBox end_dateCaptionTextBox;
        private Telerik.Reporting.TextBox is_lockedCaptionTextBox;
        private Telerik.Reporting.TextBox offer_codeCaptionTextBox;
        private Telerik.Reporting.TextBox start_dateCaptionTextBox;
        private Telerik.Reporting.GroupFooterSection labelsGroupFooterSection;
        private Telerik.Reporting.PageHeaderSection pageHeader;
        private Telerik.Reporting.TextBox reportNameTextBox;
        private Telerik.Reporting.PageFooterSection pageFooter;
        private Telerik.Reporting.TextBox currentTimeTextBox;
        private Telerik.Reporting.TextBox pageInfoTextBox;
        private Telerik.Reporting.ReportHeaderSection reportHeader;
        private Telerik.Reporting.TextBox titleTextBox;
        private Telerik.Reporting.ReportFooterSection reportFooter;
        private Telerik.Reporting.DetailSection detail;
        private Telerik.Reporting.TextBox channel_codeDataTextBox;
        private Telerik.Reporting.TextBox channel_nameDataTextBox;
        private Telerik.Reporting.TextBox channel_type_nameDataTextBox;
        private Telerik.Reporting.TextBox created_byDataTextBox;
        private Telerik.Reporting.TextBox descriptionDataTextBox;
        private Telerik.Reporting.TextBox end_dateDataTextBox;
        private Telerik.Reporting.TextBox is_lockedDataTextBox;
        private Telerik.Reporting.TextBox offer_codeDataTextBox;
        private Telerik.Reporting.TextBox start_dateDataTextBox;

    }
}