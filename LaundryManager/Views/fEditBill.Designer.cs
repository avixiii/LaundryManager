
namespace LaundryManager.Views
{
    partial class fEditBill
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
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery2 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fEditBill));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions4 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject13 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject14 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject15 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject16 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions5 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject17 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject18 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject19 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject20 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions6 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject21 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject22 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject23 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject24 = new DevExpress.Utils.SerializableAppearanceObject();
            this.gcServiceList = new DevExpress.XtraGrid.GridControl();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.gvServiceList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colServiceName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riBtnAdd = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gcCart = new DevExpress.XtraGrid.GridControl();
            this.gvCart = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colRemove = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colServiceID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colServiceNameDB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDelete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riBtnDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtAppointmentDate = new System.Windows.Forms.DateTimePicker();
            this.dtBillDate = new System.Windows.Forms.DateTimePicker();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.txtTotal1 = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.ckbPrint = new System.Windows.Forms.CheckBox();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtSurcharge = new System.Windows.Forms.TextBox();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtBillCode = new System.Windows.Forms.TextBox();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gcServiceList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvServiceList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riBtnAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riBtnDelete)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gcServiceList
            // 
            this.gcServiceList.DataMember = "Query";
            this.gcServiceList.DataSource = this.sqlDataSource1;
            this.gcServiceList.Dock = System.Windows.Forms.DockStyle.Left;
            this.gcServiceList.Location = new System.Drawing.Point(0, 0);
            this.gcServiceList.MainView = this.gvServiceList;
            this.gcServiceList.Name = "gcServiceList";
            this.gcServiceList.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.riBtnAdd});
            this.gcServiceList.Size = new System.Drawing.Size(611, 700);
            this.gcServiceList.TabIndex = 0;
            this.gcServiceList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvServiceList});
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "DATABASE_QUANLYTIEMGIATUIConnectionString";
            this.sqlDataSource1.Name = "sqlDataSource1";
            customSqlQuery2.Name = "Query";
            customSqlQuery2.Sql = "SELECT ID, ServiceName, Price FROM Services";
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery2});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // gvServiceList
            // 
            this.gvServiceList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colServiceName,
            this.colPrice,
            this.colAdd});
            this.gvServiceList.GridControl = this.gcServiceList;
            this.gvServiceList.Name = "gvServiceList";
            this.gvServiceList.OptionsView.ShowGroupPanel = false;
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            this.colID.Width = 146;
            // 
            // colServiceName
            // 
            this.colServiceName.FieldName = "ServiceName";
            this.colServiceName.Name = "colServiceName";
            this.colServiceName.Visible = true;
            this.colServiceName.VisibleIndex = 1;
            this.colServiceName.Width = 146;
            // 
            // colPrice
            // 
            this.colPrice.DisplayFormat.FormatString = "{0:#,##0.00}";
            this.colPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPrice.FieldName = "Price";
            this.colPrice.Name = "colPrice";
            this.colPrice.Visible = true;
            this.colPrice.VisibleIndex = 2;
            this.colPrice.Width = 258;
            // 
            // colAdd
            // 
            this.colAdd.ColumnEdit = this.riBtnAdd;
            this.colAdd.Name = "colAdd";
            this.colAdd.Visible = true;
            this.colAdd.VisibleIndex = 3;
            this.colAdd.Width = 36;
            // 
            // riBtnAdd
            // 
            this.riBtnAdd.AutoHeight = false;
            editorButtonImageOptions4.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions4.Image")));
            this.riBtnAdd.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions4, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject13, serializableAppearanceObject14, serializableAppearanceObject15, serializableAppearanceObject16, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.riBtnAdd.Name = "riBtnAdd";
            this.riBtnAdd.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.riBtnAdd.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.riBtnAdd_ButtonClick);
            // 
            // gcCart
            // 
            this.gcCart.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcCart.Location = new System.Drawing.Point(611, 0);
            this.gcCart.MainView = this.gvCart;
            this.gcCart.Name = "gcCart";
            this.gcCart.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEdit2,
            this.riBtnDelete});
            this.gcCart.Size = new System.Drawing.Size(760, 336);
            this.gcCart.TabIndex = 1;
            this.gcCart.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCart});
            // 
            // gvCart
            // 
            this.gvCart.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colRemove,
            this.colServiceID,
            this.colServiceNameDB,
            this.colQuantity,
            this.colAmount,
            this.colDelete});
            this.gvCart.GridControl = this.gcCart;
            this.gvCart.Name = "gvCart";
            this.gvCart.OptionsView.ShowGroupPanel = false;
            // 
            // colRemove
            // 
            this.colRemove.ColumnEdit = this.repositoryItemButtonEdit2;
            this.colRemove.Name = "colRemove";
            this.colRemove.Visible = true;
            this.colRemove.VisibleIndex = 0;
            this.colRemove.Width = 42;
            // 
            // repositoryItemButtonEdit2
            // 
            this.repositoryItemButtonEdit2.AutoHeight = false;
            editorButtonImageOptions5.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions5.Image")));
            this.repositoryItemButtonEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions5, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject17, serializableAppearanceObject18, serializableAppearanceObject19, serializableAppearanceObject20, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.repositoryItemButtonEdit2.Name = "repositoryItemButtonEdit2";
            this.repositoryItemButtonEdit2.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItemButtonEdit2.Click += new System.EventHandler(this.repositoryItemButtonEdit2_Click);
            // 
            // colServiceID
            // 
            this.colServiceID.Caption = "Mã DV";
            this.colServiceID.FieldName = "ServID";
            this.colServiceID.Name = "colServiceID";
            this.colServiceID.OptionsColumn.AllowEdit = false;
            this.colServiceID.OptionsColumn.AllowFocus = false;
            this.colServiceID.Visible = true;
            this.colServiceID.VisibleIndex = 1;
            this.colServiceID.Width = 136;
            // 
            // colServiceNameDB
            // 
            this.colServiceNameDB.Caption = "Tên dịch vụ";
            this.colServiceNameDB.FieldName = "ServiceName";
            this.colServiceNameDB.Name = "colServiceNameDB";
            this.colServiceNameDB.OptionsColumn.AllowEdit = false;
            this.colServiceNameDB.OptionsColumn.AllowFocus = false;
            this.colServiceNameDB.Visible = true;
            this.colServiceNameDB.VisibleIndex = 2;
            this.colServiceNameDB.Width = 286;
            // 
            // colQuantity
            // 
            this.colQuantity.Caption = "Số lượng";
            this.colQuantity.FieldName = "Quantity";
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.OptionsColumn.AllowEdit = false;
            this.colQuantity.OptionsColumn.AllowFocus = false;
            this.colQuantity.Visible = true;
            this.colQuantity.VisibleIndex = 3;
            this.colQuantity.Width = 73;
            // 
            // colAmount
            // 
            this.colAmount.Caption = "Thành tiền";
            this.colAmount.DisplayFormat.FormatString = "{0:#,##0.00}";
            this.colAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colAmount.FieldName = "Total";
            this.colAmount.Name = "colAmount";
            this.colAmount.OptionsColumn.AllowEdit = false;
            this.colAmount.OptionsColumn.AllowFocus = false;
            this.colAmount.Visible = true;
            this.colAmount.VisibleIndex = 4;
            this.colAmount.Width = 165;
            // 
            // colDelete
            // 
            this.colDelete.ColumnEdit = this.riBtnDelete;
            this.colDelete.Name = "colDelete";
            this.colDelete.Visible = true;
            this.colDelete.VisibleIndex = 5;
            this.colDelete.Width = 33;
            // 
            // riBtnDelete
            // 
            this.riBtnDelete.AutoHeight = false;
            editorButtonImageOptions6.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions6.Image")));
            this.riBtnDelete.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions6, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject21, serializableAppearanceObject22, serializableAppearanceObject23, serializableAppearanceObject24, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.riBtnDelete.Name = "riBtnDelete";
            this.riBtnDelete.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.riBtnDelete.Click += new System.EventHandler(this.riBtnDelete_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtAppointmentDate);
            this.panel1.Controls.Add(this.dtBillDate);
            this.panel1.Controls.Add(this.txtNote);
            this.panel1.Controls.Add(this.labelControl12);
            this.panel1.Controls.Add(this.txtTotal1);
            this.panel1.Controls.Add(this.txtPhone);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.cbStatus);
            this.panel1.Controls.Add(this.ckbPrint);
            this.panel1.Controls.Add(this.labelControl11);
            this.panel1.Controls.Add(this.labelControl10);
            this.panel1.Controls.Add(this.labelControl9);
            this.panel1.Controls.Add(this.labelControl8);
            this.panel1.Controls.Add(this.labelControl7);
            this.panel1.Controls.Add(this.txtAddress);
            this.panel1.Controls.Add(this.txtSurcharge);
            this.panel1.Controls.Add(this.txtDiscount);
            this.panel1.Controls.Add(this.txtTotal);
            this.panel1.Controls.Add(this.txtCustomerName);
            this.panel1.Controls.Add(this.txtBillCode);
            this.panel1.Controls.Add(this.labelControl6);
            this.panel1.Controls.Add(this.labelControl5);
            this.panel1.Controls.Add(this.labelControl4);
            this.panel1.Controls.Add(this.labelControl3);
            this.panel1.Controls.Add(this.labelControl2);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(611, 336);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(760, 364);
            this.panel1.TabIndex = 2;
            // 
            // dtAppointmentDate
            // 
            this.dtAppointmentDate.Location = new System.Drawing.Point(495, 62);
            this.dtAppointmentDate.Name = "dtAppointmentDate";
            this.dtAppointmentDate.Size = new System.Drawing.Size(200, 21);
            this.dtAppointmentDate.TabIndex = 34;
            // 
            // dtBillDate
            // 
            this.dtBillDate.Location = new System.Drawing.Point(138, 62);
            this.dtBillDate.Name = "dtBillDate";
            this.dtBillDate.Size = new System.Drawing.Size(200, 21);
            this.dtBillDate.TabIndex = 31;
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(138, 278);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(559, 21);
            this.txtNote.TabIndex = 44;
            // 
            // labelControl12
            // 
            this.labelControl12.Location = new System.Drawing.Point(63, 286);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(23, 13);
            this.labelControl12.TabIndex = 53;
            this.labelControl12.Text = "Note";
            // 
            // txtTotal1
            // 
            this.txtTotal1.Enabled = false;
            this.txtTotal1.Location = new System.Drawing.Point(495, 152);
            this.txtTotal1.Name = "txtTotal1";
            this.txtTotal1.Size = new System.Drawing.Size(202, 21);
            this.txtTotal1.TabIndex = 52;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(495, 108);
            this.txtPhone.MaxLength = 11;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(202, 21);
            this.txtPhone.TabIndex = 37;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(580, 316);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(117, 23);
            this.btnSave.TabIndex = 46;
            this.btnSave.Text = "Lưu phiếu";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "Chưa giặt",
            "Thanh toán",
            "Đã giặt",
            "Đã thanh toán"});
            this.cbStatus.Location = new System.Drawing.Point(495, 25);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(202, 21);
            this.cbStatus.TabIndex = 30;
            // 
            // ckbPrint
            // 
            this.ckbPrint.AutoSize = true;
            this.ckbPrint.Location = new System.Drawing.Point(407, 202);
            this.ckbPrint.Name = "ckbPrint";
            this.ckbPrint.Size = new System.Drawing.Size(99, 17);
            this.ckbPrint.TabIndex = 45;
            this.ckbPrint.Text = "In phiếu khi lưu";
            this.ckbPrint.UseVisualStyleBackColor = true;
            // 
            // labelControl11
            // 
            this.labelControl11.Enabled = false;
            this.labelControl11.Location = new System.Drawing.Point(407, 154);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(51, 13);
            this.labelControl11.TabIndex = 51;
            this.labelControl11.Text = "Thành tiền";
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(407, 111);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(49, 13);
            this.labelControl10.TabIndex = 50;
            this.labelControl10.Text = "Điện thoại";
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(407, 70);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(46, 13);
            this.labelControl9.TabIndex = 49;
            this.labelControl9.Text = "Ngày hẹn";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(407, 25);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(49, 13);
            this.labelControl8.TabIndex = 48;
            this.labelControl8.Text = "Trạng thái";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(244, 152);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(27, 13);
            this.labelControl7.TabIndex = 47;
            this.labelControl7.Text = "CK %";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(138, 237);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(559, 21);
            this.txtAddress.TabIndex = 42;
            // 
            // txtSurcharge
            // 
            this.txtSurcharge.Location = new System.Drawing.Point(138, 194);
            this.txtSurcharge.Name = "txtSurcharge";
            this.txtSurcharge.Size = new System.Drawing.Size(202, 21);
            this.txtSurcharge.TabIndex = 41;
            this.txtSurcharge.Text = "0";
            this.txtSurcharge.TextChanged += new System.EventHandler(this.txtSurcharge_TextChanged);
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(270, 149);
            this.txtDiscount.MaxLength = 2;
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(70, 21);
            this.txtDiscount.TabIndex = 40;
            this.txtDiscount.Text = "0";
            this.txtDiscount.TextChanged += new System.EventHandler(this.txtDiscount_TextChanged);
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(138, 149);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 21);
            this.txtTotal.TabIndex = 43;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(138, 108);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(202, 21);
            this.txtCustomerName.TabIndex = 36;
            // 
            // txtBillCode
            // 
            this.txtBillCode.Enabled = false;
            this.txtBillCode.Location = new System.Drawing.Point(138, 25);
            this.txtBillCode.Name = "txtBillCode";
            this.txtBillCode.Size = new System.Drawing.Size(202, 21);
            this.txtBillCode.TabIndex = 39;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(63, 245);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(32, 13);
            this.labelControl6.TabIndex = 38;
            this.labelControl6.Text = "Địa chỉ";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(63, 202);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(37, 13);
            this.labelControl5.TabIndex = 35;
            this.labelControl5.Text = "Phụ thu";
            // 
            // labelControl4
            // 
            this.labelControl4.Enabled = false;
            this.labelControl4.Location = new System.Drawing.Point(63, 157);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(45, 13);
            this.labelControl4.TabIndex = 33;
            this.labelControl4.Text = "Tổng tiền";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(63, 116);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(49, 13);
            this.labelControl3.TabIndex = 32;
            this.labelControl3.Text = "Tên khách";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(63, 74);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(42, 13);
            this.labelControl2.TabIndex = 29;
            this.labelControl2.Text = "Ngày lập";
            // 
            // labelControl1
            // 
            this.labelControl1.Enabled = false;
            this.labelControl1.Location = new System.Drawing.Point(63, 33);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(41, 13);
            this.labelControl1.TabIndex = 28;
            this.labelControl1.Text = "Số phiếu";
            // 
            // fEditBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 700);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gcCart);
            this.Controls.Add(this.gcServiceList);
            this.MaximumSize = new System.Drawing.Size(1373, 732);
            this.MinimumSize = new System.Drawing.Size(1373, 732);
            this.Name = "fEditBill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CHỈNH SỬA HOÁ ĐƠN";
            ((System.ComponentModel.ISupportInitialize)(this.gcServiceList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvServiceList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riBtnAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riBtnDelete)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcServiceList;
        private DevExpress.XtraGrid.Views.Grid.GridView gvServiceList;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colServiceName;
        private DevExpress.XtraGrid.Columns.GridColumn colPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colAdd;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit riBtnAdd;
        private DevExpress.XtraGrid.GridControl gcCart;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCart;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtAppointmentDate;
        private System.Windows.Forms.DateTimePicker dtBillDate;
        private System.Windows.Forms.TextBox txtNote;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private System.Windows.Forms.TextBox txtTotal1;
        private System.Windows.Forms.TextBox txtPhone;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.CheckBox ckbPrint;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtSurcharge;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtBillCode;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn colRemove;
        private DevExpress.XtraGrid.Columns.GridColumn colServiceID;
        private DevExpress.XtraGrid.Columns.GridColumn colServiceNameDB;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colDelete;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit2;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit riBtnDelete;
    }
}