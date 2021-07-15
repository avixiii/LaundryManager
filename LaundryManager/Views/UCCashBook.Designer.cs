
namespace LaundryManager.Views
{
    partial class UCCashBook
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCCashBook));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnCreate = new DevExpress.XtraEditors.SimpleButton();
            this.gcCashBook = new DevExpress.XtraGrid.GridControl();
            this.gvCashBook = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBillType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBillDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPayer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReason = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExplain = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.dockPanel1 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.dtTime = new DevExpress.XtraEditors.DateEdit();
            this.lblSpendingMoney = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.lblTienThu = new DevExpress.XtraEditors.LabelControl();
            this.btnSearchByID = new DevExpress.XtraEditors.SimpleButton();
            this.dt2 = new DevExpress.XtraEditors.DateTimeOffsetEdit();
            this.dt1 = new DevExpress.XtraEditors.DateEdit();
            this.ckbDate = new System.Windows.Forms.CheckBox();
            this.ckbTime = new System.Windows.Forms.CheckBox();
            this.ckbBillType = new System.Windows.Forms.CheckBox();
            this.ckbEmployee = new System.Windows.Forms.CheckBox();
            this.ckbID = new System.Windows.Forms.CheckBox();
            this.cbBillType = new System.Windows.Forms.ComboBox();
            this.txtEmployee = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcCashBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCashBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            this.dockPanel1.SuspendLayout();
            this.dockPanel1_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtTime.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnClose);
            this.panelControl1.Controls.Add(this.btnPrint);
            this.panelControl1.Controls.Add(this.btnDelete);
            this.panelControl1.Controls.Add(this.btnEdit);
            this.panelControl1.Controls.Add(this.btnCreate);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(382, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(779, 46);
            this.panelControl1.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.ImageOptions.Image")));
            this.btnClose.Location = new System.Drawing.Point(502, 11);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Đóng";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.ImageOptions.Image")));
            this.btnPrint.Location = new System.Drawing.Point(391, 11);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 3;
            this.btnPrint.Text = "In phiếu";
            // 
            // btnDelete
            // 
            this.btnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.Image")));
            this.btnDelete.Location = new System.Drawing.Point(276, 11);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Xoá";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.ImageOptions.Image")));
            this.btnEdit.Location = new System.Drawing.Point(158, 11);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCreate.ImageOptions.Image")));
            this.btnCreate.Location = new System.Drawing.Point(44, 11);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "Tạo phiếu";
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // gcCashBook
            // 
            this.gcCashBook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcCashBook.Location = new System.Drawing.Point(382, 46);
            this.gcCashBook.MainView = this.gvCashBook;
            this.gcCashBook.Name = "gcCashBook";
            this.gcCashBook.Size = new System.Drawing.Size(779, 564);
            this.gcCashBook.TabIndex = 1;
            this.gcCashBook.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCashBook});
            // 
            // gvCashBook
            // 
            this.gvCashBook.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colUserName,
            this.colBillType,
            this.colBillDate,
            this.colPayer,
            this.colAmount,
            this.colReason,
            this.colExplain});
            this.gvCashBook.GridControl = this.gcCashBook;
            this.gvCashBook.Name = "gvCashBook";
            this.gvCashBook.OptionsView.ShowGroupPanel = false;
            // 
            // colID
            // 
            this.colID.Caption = "ID";
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.OptionsColumn.AllowEdit = false;
            this.colID.OptionsColumn.ShowInExpressionEditor = false;
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            // 
            // colUserName
            // 
            this.colUserName.Caption = "Người tạo hoá đơn";
            this.colUserName.FieldName = "FullName";
            this.colUserName.Name = "colUserName";
            this.colUserName.OptionsColumn.AllowEdit = false;
            this.colUserName.OptionsColumn.ShowInExpressionEditor = false;
            this.colUserName.Visible = true;
            this.colUserName.VisibleIndex = 1;
            // 
            // colBillType
            // 
            this.colBillType.Caption = "Loại phiếu";
            this.colBillType.FieldName = "BillType";
            this.colBillType.Name = "colBillType";
            this.colBillType.OptionsColumn.AllowEdit = false;
            this.colBillType.OptionsColumn.ShowInExpressionEditor = false;
            this.colBillType.Visible = true;
            this.colBillType.VisibleIndex = 2;
            // 
            // colBillDate
            // 
            this.colBillDate.Caption = "Ngày tạo hoá đơn";
            this.colBillDate.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.colBillDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colBillDate.FieldName = "BillDate";
            this.colBillDate.Name = "colBillDate";
            this.colBillDate.OptionsColumn.AllowEdit = false;
            this.colBillDate.OptionsColumn.ShowInExpressionEditor = false;
            this.colBillDate.Visible = true;
            this.colBillDate.VisibleIndex = 3;
            // 
            // colPayer
            // 
            this.colPayer.Caption = "Người nhận/Nộp";
            this.colPayer.FieldName = "Payer";
            this.colPayer.Name = "colPayer";
            this.colPayer.OptionsColumn.AllowEdit = false;
            this.colPayer.OptionsColumn.ShowInExpressionEditor = false;
            this.colPayer.Visible = true;
            this.colPayer.VisibleIndex = 4;
            // 
            // colAmount
            // 
            this.colAmount.Caption = "Số tiền";
            this.colAmount.DisplayFormat.FormatString = "{0:#,##0.00}";
            this.colAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colAmount.FieldName = "Amount";
            this.colAmount.Name = "colAmount";
            this.colAmount.OptionsColumn.AllowEdit = false;
            this.colAmount.OptionsColumn.ShowInExpressionEditor = false;
            this.colAmount.Visible = true;
            this.colAmount.VisibleIndex = 5;
            // 
            // colReason
            // 
            this.colReason.Caption = "Lý do";
            this.colReason.FieldName = "Reason";
            this.colReason.Name = "colReason";
            this.colReason.OptionsColumn.AllowEdit = false;
            this.colReason.OptionsColumn.ShowInExpressionEditor = false;
            this.colReason.Visible = true;
            this.colReason.VisibleIndex = 6;
            // 
            // colExplain
            // 
            this.colExplain.Caption = "Diễn giải";
            this.colExplain.FieldName = "Explain";
            this.colExplain.Name = "colExplain";
            this.colExplain.OptionsColumn.AllowEdit = false;
            this.colExplain.OptionsColumn.ShowInExpressionEditor = false;
            this.colExplain.Visible = true;
            this.colExplain.VisibleIndex = 7;
            // 
            // dockManager1
            // 
            this.dockManager1.Form = this;
            this.dockManager1.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.dockPanel1});
            this.dockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "System.Windows.Forms.StatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl",
            "DevExpress.XtraBars.Navigation.OfficeNavigationBar",
            "DevExpress.XtraBars.Navigation.TileNavPane",
            "DevExpress.XtraBars.TabFormControl",
            "DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl",
            "DevExpress.XtraBars.ToolbarForm.ToolbarFormControl"});
            // 
            // dockPanel1
            // 
            this.dockPanel1.Controls.Add(this.dockPanel1_Container);
            this.dockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.dockPanel1.ID = new System.Guid("0fdcaf1d-726a-4fe4-9e14-d657312f8fc5");
            this.dockPanel1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("dockPanel1.ImageOptions.Image")));
            this.dockPanel1.Location = new System.Drawing.Point(0, 0);
            this.dockPanel1.Name = "dockPanel1";
            this.dockPanel1.OriginalSize = new System.Drawing.Size(382, 200);
            this.dockPanel1.Size = new System.Drawing.Size(382, 610);
            this.dockPanel1.Text = "TÌM KIẾM VÀ LỌC DỮ LIỆU";
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.dtTime);
            this.dockPanel1_Container.Controls.Add(this.lblSpendingMoney);
            this.dockPanel1_Container.Controls.Add(this.labelControl9);
            this.dockPanel1_Container.Controls.Add(this.labelControl8);
            this.dockPanel1_Container.Controls.Add(this.lblTienThu);
            this.dockPanel1_Container.Controls.Add(this.btnSearchByID);
            this.dockPanel1_Container.Controls.Add(this.dt2);
            this.dockPanel1_Container.Controls.Add(this.dt1);
            this.dockPanel1_Container.Controls.Add(this.ckbDate);
            this.dockPanel1_Container.Controls.Add(this.ckbTime);
            this.dockPanel1_Container.Controls.Add(this.ckbBillType);
            this.dockPanel1_Container.Controls.Add(this.ckbEmployee);
            this.dockPanel1_Container.Controls.Add(this.ckbID);
            this.dockPanel1_Container.Controls.Add(this.cbBillType);
            this.dockPanel1_Container.Controls.Add(this.txtEmployee);
            this.dockPanel1_Container.Controls.Add(this.txtID);
            this.dockPanel1_Container.Controls.Add(this.labelControl5);
            this.dockPanel1_Container.Controls.Add(this.labelControl4);
            this.dockPanel1_Container.Controls.Add(this.labelControl3);
            this.dockPanel1_Container.Controls.Add(this.labelControl2);
            this.dockPanel1_Container.Controls.Add(this.labelControl1);
            this.dockPanel1_Container.Location = new System.Drawing.Point(3, 26);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(375, 581);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // dtTime
            // 
            this.dtTime.EditValue = null;
            this.dtTime.Enabled = false;
            this.dtTime.Location = new System.Drawing.Point(111, 170);
            this.dtTime.Name = "dtTime";
            this.dtTime.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtTime.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtTime.Size = new System.Drawing.Size(227, 20);
            this.dtTime.TabIndex = 23;
            // 
            // lblSpendingMoney
            // 
            this.lblSpendingMoney.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpendingMoney.Appearance.Options.UseFont = true;
            this.lblSpendingMoney.Location = new System.Drawing.Point(222, 285);
            this.lblSpendingMoney.Name = "lblSpendingMoney";
            this.lblSpendingMoney.Size = new System.Drawing.Size(80, 19);
            this.lblSpendingMoney.TabIndex = 22;
            this.lblSpendingMoney.Text = "3.000.000";
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(227, 327);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(75, 13);
            this.labelControl9.TabIndex = 21;
            this.labelControl9.Text = "TỔNG TIỀN CHI";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(28, 327);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(77, 13);
            this.labelControl8.TabIndex = 20;
            this.labelControl8.Text = "TỔNG TIỀN THU";
            // 
            // lblTienThu
            // 
            this.lblTienThu.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTienThu.Appearance.Options.UseFont = true;
            this.lblTienThu.Location = new System.Drawing.Point(28, 285);
            this.lblTienThu.Name = "lblTienThu";
            this.lblTienThu.Size = new System.Drawing.Size(80, 19);
            this.lblTienThu.TabIndex = 18;
            this.lblTienThu.Text = "5.000.000";
            // 
            // btnSearchByID
            // 
            this.btnSearchByID.Enabled = false;
            this.btnSearchByID.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchByID.ImageOptions.Image")));
            this.btnSearchByID.Location = new System.Drawing.Point(278, 49);
            this.btnSearchByID.Name = "btnSearchByID";
            this.btnSearchByID.Size = new System.Drawing.Size(60, 23);
            this.btnSearchByID.TabIndex = 17;
            this.btnSearchByID.Text = "Xem";
            // 
            // dt2
            // 
            this.dt2.EditValue = null;
            this.dt2.Enabled = false;
            this.dt2.Location = new System.Drawing.Point(238, 217);
            this.dt2.Name = "dt2";
            this.dt2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dt2.Size = new System.Drawing.Size(100, 20);
            this.dt2.TabIndex = 16;
            // 
            // dt1
            // 
            this.dt1.EditValue = null;
            this.dt1.Enabled = false;
            this.dt1.Location = new System.Drawing.Point(111, 217);
            this.dt1.Name = "dt1";
            this.dt1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dt1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dt1.Size = new System.Drawing.Size(100, 20);
            this.dt1.TabIndex = 15;
            // 
            // ckbDate
            // 
            this.ckbDate.AutoSize = true;
            this.ckbDate.Location = new System.Drawing.Point(74, 221);
            this.ckbDate.Name = "ckbDate";
            this.ckbDate.Size = new System.Drawing.Size(15, 14);
            this.ckbDate.TabIndex = 14;
            this.ckbDate.UseVisualStyleBackColor = true;
            this.ckbDate.CheckedChanged += new System.EventHandler(this.ckbDate_CheckedChanged);
            // 
            // ckbTime
            // 
            this.ckbTime.AutoSize = true;
            this.ckbTime.Location = new System.Drawing.Point(74, 173);
            this.ckbTime.Name = "ckbTime";
            this.ckbTime.Size = new System.Drawing.Size(15, 14);
            this.ckbTime.TabIndex = 13;
            this.ckbTime.UseVisualStyleBackColor = true;
            this.ckbTime.CheckedChanged += new System.EventHandler(this.ckbTime_CheckedChanged);
            // 
            // ckbBillType
            // 
            this.ckbBillType.AutoSize = true;
            this.ckbBillType.Location = new System.Drawing.Point(74, 126);
            this.ckbBillType.Name = "ckbBillType";
            this.ckbBillType.Size = new System.Drawing.Size(15, 14);
            this.ckbBillType.TabIndex = 12;
            this.ckbBillType.UseVisualStyleBackColor = true;
            this.ckbBillType.CheckedChanged += new System.EventHandler(this.ckbBillType_CheckedChanged);
            // 
            // ckbEmployee
            // 
            this.ckbEmployee.AutoSize = true;
            this.ckbEmployee.Location = new System.Drawing.Point(74, 93);
            this.ckbEmployee.Name = "ckbEmployee";
            this.ckbEmployee.Size = new System.Drawing.Size(15, 14);
            this.ckbEmployee.TabIndex = 11;
            this.ckbEmployee.UseVisualStyleBackColor = true;
            this.ckbEmployee.CheckedChanged += new System.EventHandler(this.ckbEmployee_CheckedChanged);
            // 
            // ckbID
            // 
            this.ckbID.AutoSize = true;
            this.ckbID.Location = new System.Drawing.Point(74, 52);
            this.ckbID.Name = "ckbID";
            this.ckbID.Size = new System.Drawing.Size(15, 14);
            this.ckbID.TabIndex = 10;
            this.ckbID.UseVisualStyleBackColor = true;
            this.ckbID.CheckedChanged += new System.EventHandler(this.ckbID_CheckedChanged);
            // 
            // cbBillType
            // 
            this.cbBillType.Enabled = false;
            this.cbBillType.FormattingEnabled = true;
            this.cbBillType.Location = new System.Drawing.Point(111, 124);
            this.cbBillType.Name = "cbBillType";
            this.cbBillType.Size = new System.Drawing.Size(227, 21);
            this.cbBillType.TabIndex = 9;
            // 
            // txtEmployee
            // 
            this.txtEmployee.Enabled = false;
            this.txtEmployee.Location = new System.Drawing.Point(111, 89);
            this.txtEmployee.Name = "txtEmployee";
            this.txtEmployee.Size = new System.Drawing.Size(227, 21);
            this.txtEmployee.TabIndex = 6;
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(111, 49);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(161, 21);
            this.txtID.TabIndex = 5;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(4, 225);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(42, 13);
            this.labelControl5.TabIndex = 4;
            this.labelControl5.Text = "Ngày lập";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(4, 177);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(43, 13);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "Thời gian";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(4, 133);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(48, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Loại phiếu";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(4, 97);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(48, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Nhân viên";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(4, 57);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(41, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Số phiếu";
            // 
            // UCCashBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gcCashBook);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.dockPanel1);
            this.Name = "UCCashBook";
            this.Size = new System.Drawing.Size(1161, 610);
            this.Load += new System.EventHandler(this.UCCashBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcCashBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCashBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            this.dockPanel1.ResumeLayout(false);
            this.dockPanel1_Container.ResumeLayout(false);
            this.dockPanel1_Container.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtTime.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.SimpleButton btnCreate;
        private DevExpress.XtraGrid.GridControl gcCashBook;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCashBook;
        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel1;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevExpress.XtraEditors.DateTimeOffsetEdit dt2;
        private DevExpress.XtraEditors.DateEdit dt1;
        private System.Windows.Forms.CheckBox ckbDate;
        private System.Windows.Forms.CheckBox ckbTime;
        private System.Windows.Forms.CheckBox ckbBillType;
        private System.Windows.Forms.CheckBox ckbEmployee;
        private System.Windows.Forms.CheckBox ckbID;
        private System.Windows.Forms.ComboBox cbBillType;
        private System.Windows.Forms.TextBox txtEmployee;
        private System.Windows.Forms.TextBox txtID;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnSearchByID;
        private DevExpress.XtraEditors.LabelControl lblSpendingMoney;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl lblTienThu;
        private DevExpress.XtraEditors.DateEdit dtTime;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colUserName;
        private DevExpress.XtraGrid.Columns.GridColumn colBillType;
        private DevExpress.XtraGrid.Columns.GridColumn colBillDate;
        private DevExpress.XtraGrid.Columns.GridColumn colPayer;
        private DevExpress.XtraGrid.Columns.GridColumn colAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colReason;
        private DevExpress.XtraGrid.Columns.GridColumn colExplain;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
    }
}
