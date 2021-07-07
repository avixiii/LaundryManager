
namespace LaundryManager.Views
{
    partial class UCInvoice
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
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery1 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCInvoice));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.gcInvoice = new DevExpress.XtraGrid.GridControl();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.gvBills = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colBillCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBillDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAppointmentDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDetailsView = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riBtnDetailsView = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.dockPanel1 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnIgnore = new DevExpress.XtraEditors.SimpleButton();
            this.btnCreateInvoice = new DevExpress.XtraEditors.SimpleButton();
            this.panelCreateBill = new DevExpress.XtraEditors.PanelControl();
            this.riBtnStatus = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gcInvoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBills)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riBtnDetailsView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            this.dockPanel1.SuspendLayout();
            this.dockPanel1_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelCreateBill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riBtnStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // gcInvoice
            // 
            this.gcInvoice.DataMember = "Query";
            this.gcInvoice.DataSource = this.sqlDataSource1;
            this.gcInvoice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcInvoice.Location = new System.Drawing.Point(233, 67);
            this.gcInvoice.MainView = this.gvBills;
            this.gcInvoice.Name = "gcInvoice";
            this.gcInvoice.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.riBtnDetailsView,
            this.riBtnStatus});
            this.gcInvoice.Size = new System.Drawing.Size(979, 661);
            this.gcInvoice.TabIndex = 5;
            this.gcInvoice.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvBills});
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "DATABASE_QUANLYTIEMGIATUIConnectionString";
            this.sqlDataSource1.Name = "sqlDataSource1";
            customSqlQuery1.Name = "Query";
            customSqlQuery1.Sql = "SELECT BillCode, BillDate, Name, AppointmentDate, Phone, Address, Status, Total F" +
    "ROM dbo.Customers , dbo.Bills WHERE dbo.Customers.ID = dbo.Bills.CusID\r\n";
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // gvBills
            // 
            this.gvBills.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colBillCode,
            this.colBillDate,
            this.colName,
            this.colAppointmentDate,
            this.colPhone,
            this.colAddress,
            this.colStatus,
            this.colTotal,
            this.colDetailsView});
            this.gvBills.GridControl = this.gcInvoice;
            this.gvBills.Name = "gvBills";
            this.gvBills.OptionsView.ShowGroupPanel = false;
            // 
            // colBillCode
            // 
            this.colBillCode.FieldName = "BillCode";
            this.colBillCode.Name = "colBillCode";
            this.colBillCode.Visible = true;
            this.colBillCode.VisibleIndex = 0;
            this.colBillCode.Width = 97;
            // 
            // colBillDate
            // 
            this.colBillDate.Caption = "Ngày lập";
            this.colBillDate.FieldName = "BillDate";
            this.colBillDate.Name = "colBillDate";
            this.colBillDate.Visible = true;
            this.colBillDate.VisibleIndex = 1;
            this.colBillDate.Width = 97;
            // 
            // colName
            // 
            this.colName.Caption = "Tên khách hàng";
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 2;
            this.colName.Width = 97;
            // 
            // colAppointmentDate
            // 
            this.colAppointmentDate.Caption = "Ngày hẹn";
            this.colAppointmentDate.FieldName = "AppointmentDate";
            this.colAppointmentDate.Name = "colAppointmentDate";
            this.colAppointmentDate.Visible = true;
            this.colAppointmentDate.VisibleIndex = 3;
            this.colAppointmentDate.Width = 97;
            // 
            // colPhone
            // 
            this.colPhone.Caption = "Số điện thoại";
            this.colPhone.FieldName = "Phone";
            this.colPhone.Name = "colPhone";
            this.colPhone.Visible = true;
            this.colPhone.VisibleIndex = 4;
            this.colPhone.Width = 97;
            // 
            // colAddress
            // 
            this.colAddress.Caption = "Địa chỉ";
            this.colAddress.FieldName = "Address";
            this.colAddress.Name = "colAddress";
            this.colAddress.Visible = true;
            this.colAddress.VisibleIndex = 5;
            this.colAddress.Width = 198;
            // 
            // colStatus
            // 
            this.colStatus.Caption = "Trạng thái";
            this.colStatus.ColumnEdit = this.riBtnStatus;
            this.colStatus.FieldName = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.Visible = true;
            this.colStatus.VisibleIndex = 6;
            this.colStatus.Width = 81;
            // 
            // colTotal
            // 
            this.colTotal.Caption = "Tổng tiền";
            this.colTotal.FieldName = "Total";
            this.colTotal.Name = "colTotal";
            this.colTotal.Visible = true;
            this.colTotal.VisibleIndex = 7;
            this.colTotal.Width = 140;
            // 
            // colDetailsView
            // 
            this.colDetailsView.Caption = "Xem chi tiết";
            this.colDetailsView.ColumnEdit = this.riBtnDetailsView;
            this.colDetailsView.Name = "colDetailsView";
            this.colDetailsView.Visible = true;
            this.colDetailsView.VisibleIndex = 8;
            this.colDetailsView.Width = 50;
            // 
            // riBtnDetailsView
            // 
            this.riBtnDetailsView.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.riBtnDetailsView.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.riBtnDetailsView.Name = "riBtnDetailsView";
            this.riBtnDetailsView.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.riBtnDetailsView.Click += new System.EventHandler(this.riBtnDetailsView_Click);
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
            this.dockPanel1.ID = new System.Guid("930c37a4-e83d-4af0-8dee-7a6e44918c17");
            this.dockPanel1.Location = new System.Drawing.Point(0, 0);
            this.dockPanel1.Name = "dockPanel1";
            this.dockPanel1.OriginalSize = new System.Drawing.Size(233, 200);
            this.dockPanel1.Size = new System.Drawing.Size(233, 728);
            this.dockPanel1.Text = "TÌM KIẾM VÀ LỌC DỮ LIỆU";
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.simpleButton1);
            this.dockPanel1_Container.Controls.Add(this.textBox4);
            this.dockPanel1_Container.Controls.Add(this.textBox2);
            this.dockPanel1_Container.Controls.Add(this.textBox1);
            this.dockPanel1_Container.Controls.Add(this.label5);
            this.dockPanel1_Container.Controls.Add(this.label3);
            this.dockPanel1_Container.Controls.Add(this.label2);
            this.dockPanel1_Container.Controls.Add(this.label1);
            this.dockPanel1_Container.Location = new System.Drawing.Point(3, 26);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(226, 699);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(170, 71);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(45, 23);
            this.simpleButton1.TabIndex = 13;
            this.simpleButton1.Text = "XEM";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(87, 191);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(128, 20);
            this.textBox4.TabIndex = 12;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(87, 113);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(128, 20);
            this.textBox2.TabIndex = 10;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(87, 71);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(76, 20);
            this.textBox1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Trạng thái";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Khách hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số phiếu";
            // 
            // groupControl1
            // 
            this.groupControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(233, 0);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(979, 67);
            this.groupControl1.TabIndex = 1;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnSave);
            this.panelControl1.Controls.Add(this.btnExit);
            this.panelControl1.Controls.Add(this.btnPrint);
            this.panelControl1.Controls.Add(this.btnEdit);
            this.panelControl1.Controls.Add(this.btnIgnore);
            this.panelControl1.Controls.Add(this.btnCreateInvoice);
            this.panelControl1.Location = new System.Drawing.Point(235, 26);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(974, 41);
            this.panelControl1.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.Location = new System.Drawing.Point(636, 7);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Lưu";
            // 
            // btnExit
            // 
            this.btnExit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.ImageOptions.Image")));
            this.btnExit.Location = new System.Drawing.Point(524, 7);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Đóng";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.ImageOptions.Image")));
            this.btnPrint.Location = new System.Drawing.Point(411, 7);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 3;
            this.btnPrint.Text = "In phiếu";
            // 
            // btnEdit
            // 
            this.btnEdit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.ImageOptions.Image")));
            this.btnEdit.Location = new System.Drawing.Point(285, 7);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Sửa";
            // 
            // btnIgnore
            // 
            this.btnIgnore.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnIgnore.ImageOptions.Image")));
            this.btnIgnore.Location = new System.Drawing.Point(160, 7);
            this.btnIgnore.Name = "btnIgnore";
            this.btnIgnore.Size = new System.Drawing.Size(75, 23);
            this.btnIgnore.TabIndex = 1;
            this.btnIgnore.Text = "Bỏ qua";
            this.btnIgnore.Click += new System.EventHandler(this.btnIgnore_Click);
            // 
            // btnCreateInvoice
            // 
            this.btnCreateInvoice.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCreateInvoice.ImageOptions.Image")));
            this.btnCreateInvoice.Location = new System.Drawing.Point(34, 7);
            this.btnCreateInvoice.Name = "btnCreateInvoice";
            this.btnCreateInvoice.Size = new System.Drawing.Size(75, 23);
            this.btnCreateInvoice.TabIndex = 0;
            this.btnCreateInvoice.Text = "Tạo phiếu";
            this.btnCreateInvoice.Click += new System.EventHandler(this.btnCreateInvoice_Click);
            // 
            // panelCreateBill
            // 
            this.panelCreateBill.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelCreateBill.AutoSize = true;
            this.panelCreateBill.Location = new System.Drawing.Point(234, 67);
            this.panelCreateBill.Name = "panelCreateBill";
            this.panelCreateBill.Size = new System.Drawing.Size(978, 10);
            this.panelCreateBill.TabIndex = 4;
            // 
            // riBtnStatus
            // 
            this.riBtnStatus.AutoHeight = false;
            this.riBtnStatus.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.riBtnStatus.Name = "riBtnStatus";
            this.riBtnStatus.Click += new System.EventHandler(this.riBtnStatus_Click);
            // 
            // UCInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.gcInvoice);
            this.Controls.Add(this.panelCreateBill);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.dockPanel1);
            this.Name = "UCInvoice";
            this.Size = new System.Drawing.Size(1212, 728);
            this.Load += new System.EventHandler(this.UCInvoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcInvoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBills)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riBtnDetailsView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            this.dockPanel1.ResumeLayout(false);
            this.dockPanel1_Container.ResumeLayout(false);
            this.dockPanel1_Container.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelCreateBill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riBtnStatus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel1;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnExit;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.SimpleButton btnIgnore;
        private DevExpress.XtraEditors.SimpleButton btnCreateInvoice;
        private DevExpress.XtraEditors.PanelControl panelCreateBill;
        private DevExpress.XtraGrid.GridControl gcInvoice;
        private DevExpress.XtraGrid.Views.Grid.GridView gvBills;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colBillCode;
        private DevExpress.XtraGrid.Columns.GridColumn colBillDate;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colAppointmentDate;
        private DevExpress.XtraGrid.Columns.GridColumn colPhone;
        private DevExpress.XtraGrid.Columns.GridColumn colAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colDetailsView;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit riBtnDetailsView;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit riBtnStatus;
    }
}
