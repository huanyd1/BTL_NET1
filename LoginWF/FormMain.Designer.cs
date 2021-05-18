namespace LoginWF
{
    partial class FormMain
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.btnCustomer = new DevExpress.XtraBars.BarButtonItem();
            this.btnCardCustomer = new DevExpress.XtraBars.BarButtonItem();
            this.btnBill = new DevExpress.XtraBars.BarButtonItem();
            this.btnListRoom = new DevExpress.XtraBars.BarButtonItem();
            this.btnHotelInfomation = new DevExpress.XtraBars.BarButtonItem();
            this.btnSaleReport = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.SalesReportPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.panelSelect = new System.Windows.Forms.Panel();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.barButtonItem1,
            this.btnCustomer,
            this.btnCardCustomer,
            this.btnBill,
            this.btnListRoom,
            this.btnHotelInfomation,
            this.btnSaleReport});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ribbon.MaxItemId = 8;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.SalesReportPage});
            this.ribbon.Size = new System.Drawing.Size(1346, 183);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // btnCustomer
            // 
            this.btnCustomer.Caption = "Customer";
            this.btnCustomer.Id = 2;
            this.btnCustomer.ImageOptions.LargeImage = global::LoginWF.Properties.Resources.customer_feedback;
            this.btnCustomer.ItemAppearance.Disabled.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomer.ItemAppearance.Disabled.Options.UseFont = true;
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCustomer_ItemClick);
            // 
            // btnCardCustomer
            // 
            this.btnCardCustomer.Caption = "Card";
            this.btnCardCustomer.Id = 3;
            this.btnCardCustomer.ImageOptions.LargeImage = global::LoginWF.Properties.Resources.card;
            this.btnCardCustomer.Name = "btnCardCustomer";
            this.btnCardCustomer.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCardCustomer_ItemClick);
            // 
            // btnBill
            // 
            this.btnBill.Caption = "Bill";
            this.btnBill.Id = 4;
            this.btnBill.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnBill.ImageOptions.LargeImage")));
            this.btnBill.Name = "btnBill";
            this.btnBill.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBill_ItemClick);
            // 
            // btnListRoom
            // 
            this.btnListRoom.Caption = "Room";
            this.btnListRoom.Id = 5;
            this.btnListRoom.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnListRoom.ImageOptions.LargeImage")));
            this.btnListRoom.Name = "btnListRoom";
            this.btnListRoom.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnListRoom_ItemClick);
            // 
            // btnHotelInfomation
            // 
            this.btnHotelInfomation.Caption = "Hotel Information";
            this.btnHotelInfomation.Id = 6;
            this.btnHotelInfomation.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnHotelInfomation.ImageOptions.LargeImage")));
            this.btnHotelInfomation.Name = "btnHotelInfomation";
            this.btnHotelInfomation.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHotelInfomation_ItemClick);
            // 
            // btnSaleReport
            // 
            this.btnSaleReport.Caption = "Sales Report";
            this.btnSaleReport.Id = 7;
            this.btnSaleReport.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSaleReport.ImageOptions.LargeImage")));
            this.btnSaleReport.Name = "btnSaleReport";
            this.btnSaleReport.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSaleReport_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Manager";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnCustomer);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnCardCustomer);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnBill);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnListRoom);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnHotelInfomation);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // SalesReportPage
            // 
            this.SalesReportPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.SalesReportPage.Name = "SalesReportPage";
            this.SalesReportPage.Text = "Sales Report";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnSaleReport);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 709);
            this.ribbonStatusBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1346, 41);
            // 
            // panelSelect
            // 
            this.panelSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSelect.Location = new System.Drawing.Point(0, 183);
            this.panelSelect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelSelect.Name = "panelSelect";
            this.panelSelect.Size = new System.Drawing.Size(1346, 526);
            this.panelSelect.TabIndex = 2;
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2010 Blue";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1346, 750);
            this.Controls.Add(this.panelSelect);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormMain";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Phần mềm quản lý khách sạn";
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem btnCustomer;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btnCardCustomer;
        private System.Windows.Forms.Panel panelSelect;
        private DevExpress.XtraBars.BarButtonItem btnBill;
        private DevExpress.XtraBars.BarButtonItem btnListRoom;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraBars.BarButtonItem btnHotelInfomation;
        private DevExpress.XtraBars.BarButtonItem btnSaleReport;
        private DevExpress.XtraBars.Ribbon.RibbonPage SalesReportPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
    }
}