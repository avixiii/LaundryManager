
namespace LaundryManager.Views
{
    partial class fLaunryManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fLaunryManager));
            this.rbLaunryManager = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnBackup = new DevExpress.XtraBars.BarButtonItem();
            this.btnRestore = new DevExpress.XtraBars.BarButtonItem();
            this.btnDecentralize = new DevExpress.XtraBars.BarButtonItem();
            this.btnChangePass = new DevExpress.XtraBars.BarButtonItem();
            this.btnStoreInfo = new DevExpress.XtraBars.BarButtonItem();
            this.btnSystemHistory = new DevExpress.XtraBars.BarButtonItem();
            this.btnLogout = new DevExpress.XtraBars.BarButtonItem();
            this.btnExit = new DevExpress.XtraBars.BarButtonItem();
            this.btnServicePriceList = new DevExpress.XtraBars.BarButtonItem();
            this.btnCustomerList = new DevExpress.XtraBars.BarButtonItem();
            this.btnEmployeeList = new DevExpress.XtraBars.BarButtonItem();
            this.btnInvoice = new DevExpress.XtraBars.BarButtonItem();
            this.btnFinancialManagement = new DevExpress.XtraBars.BarButtonItem();
            this.btnStatistics = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.panelMain = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.rbLaunryManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelMain)).BeginInit();
            this.SuspendLayout();
            // 
            // rbLaunryManager
            // 
            this.rbLaunryManager.ExpandCollapseItem.Id = 0;
            this.rbLaunryManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.rbLaunryManager.ExpandCollapseItem,
            this.rbLaunryManager.SearchEditItem,
            this.btnBackup,
            this.btnRestore,
            this.btnDecentralize,
            this.btnChangePass,
            this.btnStoreInfo,
            this.btnSystemHistory,
            this.btnLogout,
            this.btnExit,
            this.btnServicePriceList,
            this.btnCustomerList,
            this.btnEmployeeList,
            this.btnInvoice,
            this.btnFinancialManagement,
            this.btnStatistics});
            this.rbLaunryManager.Location = new System.Drawing.Point(0, 0);
            this.rbLaunryManager.MaxItemId = 15;
            this.rbLaunryManager.Name = "rbLaunryManager";
            this.rbLaunryManager.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2});
            this.rbLaunryManager.Size = new System.Drawing.Size(1498, 158);
            this.rbLaunryManager.StatusBar = this.ribbonStatusBar;
            // 
            // btnBackup
            // 
            this.btnBackup.Caption = "Sao lưu";
            this.btnBackup.Id = 1;
            this.btnBackup.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBackup.ImageOptions.Image")));
            this.btnBackup.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnBackup.ImageOptions.LargeImage")));
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBackup_ItemClick);
            // 
            // btnRestore
            // 
            this.btnRestore.Caption = "Phục hồi";
            this.btnRestore.Id = 2;
            this.btnRestore.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRestore.ImageOptions.Image")));
            this.btnRestore.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnRestore.ImageOptions.LargeImage")));
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRestore_ItemClick);
            // 
            // btnDecentralize
            // 
            this.btnDecentralize.Caption = "Phân quyền";
            this.btnDecentralize.Id = 3;
            this.btnDecentralize.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDecentralize.ImageOptions.Image")));
            this.btnDecentralize.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDecentralize.ImageOptions.LargeImage")));
            this.btnDecentralize.ItemAppearance.Disabled.Options.UseTextOptions = true;
            this.btnDecentralize.ItemAppearance.Disabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btnDecentralize.ItemAppearance.Hovered.Options.UseTextOptions = true;
            this.btnDecentralize.ItemAppearance.Hovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btnDecentralize.ItemAppearance.Normal.Options.UseTextOptions = true;
            this.btnDecentralize.ItemAppearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btnDecentralize.ItemAppearance.Pressed.Options.UseTextOptions = true;
            this.btnDecentralize.ItemAppearance.Pressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btnDecentralize.Name = "btnDecentralize";
            this.btnDecentralize.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDecentralize_ItemClick);
            // 
            // btnChangePass
            // 
            this.btnChangePass.Caption = "Đổi mật khẩu";
            this.btnChangePass.Id = 4;
            this.btnChangePass.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnChangePass.ImageOptions.Image")));
            this.btnChangePass.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnChangePass.ImageOptions.LargeImage")));
            this.btnChangePass.ItemAppearance.Disabled.Options.UseTextOptions = true;
            this.btnChangePass.ItemAppearance.Disabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btnChangePass.ItemAppearance.Hovered.Options.UseTextOptions = true;
            this.btnChangePass.ItemAppearance.Hovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btnChangePass.ItemAppearance.Normal.Options.UseTextOptions = true;
            this.btnChangePass.ItemAppearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btnChangePass.ItemAppearance.Pressed.Options.UseTextOptions = true;
            this.btnChangePass.ItemAppearance.Pressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btnChangePass.Name = "btnChangePass";
            this.btnChangePass.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnChangePass_ItemClick);
            // 
            // btnStoreInfo
            // 
            this.btnStoreInfo.Caption = "Thông tin cửa hàng";
            this.btnStoreInfo.Id = 5;
            this.btnStoreInfo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnStoreInfo.ImageOptions.Image")));
            this.btnStoreInfo.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnStoreInfo.ImageOptions.LargeImage")));
            this.btnStoreInfo.ItemAppearance.Disabled.Options.UseTextOptions = true;
            this.btnStoreInfo.ItemAppearance.Disabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btnStoreInfo.ItemAppearance.Hovered.Options.UseTextOptions = true;
            this.btnStoreInfo.ItemAppearance.Hovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btnStoreInfo.ItemAppearance.Normal.Options.UseTextOptions = true;
            this.btnStoreInfo.ItemAppearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btnStoreInfo.ItemAppearance.Pressed.Options.UseTextOptions = true;
            this.btnStoreInfo.ItemAppearance.Pressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btnStoreInfo.Name = "btnStoreInfo";
            this.btnStoreInfo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnStoreInfo_ItemClick);
            // 
            // btnSystemHistory
            // 
            this.btnSystemHistory.Caption = "Lịch sử hệ thống";
            this.btnSystemHistory.Id = 6;
            this.btnSystemHistory.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSystemHistory.ImageOptions.Image")));
            this.btnSystemHistory.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSystemHistory.ImageOptions.LargeImage")));
            this.btnSystemHistory.ItemAppearance.Disabled.Options.UseTextOptions = true;
            this.btnSystemHistory.ItemAppearance.Disabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btnSystemHistory.ItemAppearance.Hovered.Options.UseTextOptions = true;
            this.btnSystemHistory.ItemAppearance.Hovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btnSystemHistory.ItemAppearance.Normal.Options.UseTextOptions = true;
            this.btnSystemHistory.ItemAppearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btnSystemHistory.ItemAppearance.Pressed.Options.UseTextOptions = true;
            this.btnSystemHistory.ItemAppearance.Pressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btnSystemHistory.Name = "btnSystemHistory";
            this.btnSystemHistory.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSystemHistory_ItemClick);
            // 
            // btnLogout
            // 
            this.btnLogout.Caption = "Đăng xuất";
            this.btnLogout.Id = 7;
            this.btnLogout.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.ImageOptions.Image")));
            this.btnLogout.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnLogout.ImageOptions.LargeImage")));
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLogout_ItemClick);
            // 
            // btnExit
            // 
            this.btnExit.Caption = "Thoát";
            this.btnExit.Id = 8;
            this.btnExit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.ImageOptions.Image")));
            this.btnExit.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnExit.ImageOptions.LargeImage")));
            this.btnExit.Name = "btnExit";
            this.btnExit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExit_ItemClick);
            // 
            // btnServicePriceList
            // 
            this.btnServicePriceList.Caption = "Bảng giá dịch vụ";
            this.btnServicePriceList.Id = 9;
            this.btnServicePriceList.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnServicePriceList.ImageOptions.Image")));
            this.btnServicePriceList.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnServicePriceList.ImageOptions.LargeImage")));
            this.btnServicePriceList.Name = "btnServicePriceList";
            this.btnServicePriceList.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            this.btnServicePriceList.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnServicePriceList_ItemClick);
            // 
            // btnCustomerList
            // 
            this.btnCustomerList.Caption = "Danh sách khách hàng";
            this.btnCustomerList.Id = 10;
            this.btnCustomerList.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCustomerList.ImageOptions.Image")));
            this.btnCustomerList.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnCustomerList.ImageOptions.LargeImage")));
            this.btnCustomerList.Name = "btnCustomerList";
            this.btnCustomerList.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            this.btnCustomerList.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCustomerList_ItemClick);
            // 
            // btnEmployeeList
            // 
            this.btnEmployeeList.Caption = "Danh sách nhân viên";
            this.btnEmployeeList.Id = 11;
            this.btnEmployeeList.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEmployeeList.ImageOptions.Image")));
            this.btnEmployeeList.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnEmployeeList.ImageOptions.LargeImage")));
            this.btnEmployeeList.Name = "btnEmployeeList";
            this.btnEmployeeList.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            this.btnEmployeeList.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEmployeeList_ItemClick);
            // 
            // btnInvoice
            // 
            this.btnInvoice.Caption = "Lập phiếu nhận";
            this.btnInvoice.Id = 12;
            this.btnInvoice.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnInvoice.ImageOptions.Image")));
            this.btnInvoice.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnInvoice.ImageOptions.LargeImage")));
            this.btnInvoice.ItemAppearance.Disabled.Options.UseTextOptions = true;
            this.btnInvoice.ItemAppearance.Disabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btnInvoice.ItemAppearance.Hovered.Options.UseTextOptions = true;
            this.btnInvoice.ItemAppearance.Hovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btnInvoice.ItemAppearance.Normal.Options.UseTextOptions = true;
            this.btnInvoice.ItemAppearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btnInvoice.ItemAppearance.Pressed.Options.UseTextOptions = true;
            this.btnInvoice.ItemAppearance.Pressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btnInvoice.Name = "btnInvoice";
            this.btnInvoice.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnInvoice_ItemClick);
            // 
            // btnFinancialManagement
            // 
            this.btnFinancialManagement.Caption = "Quản lý thu chi";
            this.btnFinancialManagement.Id = 13;
            this.btnFinancialManagement.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnFinancialManagement.ImageOptions.Image")));
            this.btnFinancialManagement.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnFinancialManagement.ImageOptions.LargeImage")));
            this.btnFinancialManagement.ItemAppearance.Disabled.Options.UseTextOptions = true;
            this.btnFinancialManagement.ItemAppearance.Disabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btnFinancialManagement.ItemAppearance.Hovered.Options.UseTextOptions = true;
            this.btnFinancialManagement.ItemAppearance.Hovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btnFinancialManagement.ItemAppearance.Normal.Options.UseTextOptions = true;
            this.btnFinancialManagement.ItemAppearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btnFinancialManagement.ItemAppearance.Pressed.Options.UseTextOptions = true;
            this.btnFinancialManagement.ItemAppearance.Pressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btnFinancialManagement.Name = "btnFinancialManagement";
            // 
            // btnStatistics
            // 
            this.btnStatistics.Caption = "Thống kê";
            this.btnStatistics.Id = 14;
            this.btnStatistics.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnStatistics.ImageOptions.Image")));
            this.btnStatistics.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnStatistics.ImageOptions.LargeImage")));
            this.btnStatistics.ItemAppearance.Disabled.Options.UseTextOptions = true;
            this.btnStatistics.ItemAppearance.Disabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btnStatistics.ItemAppearance.Hovered.Options.UseTextOptions = true;
            this.btnStatistics.ItemAppearance.Hovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btnStatistics.ItemAppearance.Normal.Options.UseTextOptions = true;
            this.btnStatistics.ItemAppearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btnStatistics.ItemAppearance.Pressed.Options.UseTextOptions = true;
            this.btnStatistics.ItemAppearance.Pressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.btnStatistics.Name = "btnStatistics";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup3,
            this.ribbonPageGroup4});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "HỆ THỐNG";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnBackup);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnRestore);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "DỮ LIỆU";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnDecentralize);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnChangePass);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "BẢO MẬT";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btnStoreInfo);
            this.ribbonPageGroup4.ItemLinks.Add(this.btnSystemHistory);
            this.ribbonPageGroup4.ItemLinks.Add(this.btnLogout);
            this.ribbonPageGroup4.ItemLinks.Add(this.btnExit);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "HỆ THỐNG";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.ribbonPageGroup5});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "NGHIỆP VỤ";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnServicePriceList);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnCustomerList);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnEmployeeList);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "DANH MỤC";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.btnInvoice);
            this.ribbonPageGroup5.ItemLinks.Add(this.btnFinancialManagement);
            this.ribbonPageGroup5.ItemLinks.Add(this.btnStatistics);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "NGHIỆP VỤ";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 1015);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.rbLaunryManager;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1498, 24);
            // 
            // panelMain
            // 
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 158);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1498, 857);
            this.panelMain.TabIndex = 2;
            // 
            // fLaunryManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1498, 1039);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.rbLaunryManager);
            this.Name = "fLaunryManager";
            this.Ribbon = this.rbLaunryManager;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "PHẦN MỀM QUẢN LÝ TIỆM GIẶT ỦI";
            ((System.ComponentModel.ISupportInitialize)(this.rbLaunryManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl rbLaunryManager;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem btnBackup;
        private DevExpress.XtraBars.BarButtonItem btnRestore;
        private DevExpress.XtraBars.BarButtonItem btnDecentralize;
        private DevExpress.XtraBars.BarButtonItem btnChangePass;
        private DevExpress.XtraBars.BarButtonItem btnStoreInfo;
        private DevExpress.XtraBars.BarButtonItem btnSystemHistory;
        private DevExpress.XtraBars.BarButtonItem btnLogout;
        private DevExpress.XtraBars.BarButtonItem btnExit;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem btnServicePriceList;
        private DevExpress.XtraBars.BarButtonItem btnCustomerList;
        private DevExpress.XtraBars.BarButtonItem btnEmployeeList;
        private DevExpress.XtraBars.BarButtonItem btnInvoice;
        private DevExpress.XtraBars.BarButtonItem btnFinancialManagement;
        private DevExpress.XtraBars.BarButtonItem btnStatistics;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraEditors.PanelControl panelMain;
    }
}