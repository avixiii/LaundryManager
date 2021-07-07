
namespace LaundryManager.Views
{
    partial class fCreateBill
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fCreateBill));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery1 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions3 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject9 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject10 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject11 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject12 = new DevExpress.Utils.SerializableAppearanceObject();
            this.gcCart = new DevExpress.XtraGrid.GridControl();
            this.gvCart = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colRemove = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riBtnRemove = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colServiceID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collServiceNameBD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDelete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riBtnDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.txtTotal1 = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.dtAppointmentDate = new DevExpress.XtraEditors.DateTimeOffsetEdit();
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
            this.dtBillDate = new DevExpress.XtraEditors.DateTimeOffsetEdit();
            this.txtBillCode = new System.Windows.Forms.TextBox();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gcServiceList = new DevExpress.XtraGrid.GridControl();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.gvServiceList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colServiceName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collAdd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riBtnAdd = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riBtnRemove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riBtnDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtAppointmentDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtBillDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcServiceList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvServiceList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riBtnAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // gcCart
            // 
            this.gcCart.Location = new System.Drawing.Point(644, 0);
            this.gcCart.MainView = this.gvCart;
            this.gcCart.Name = "gcCart";
            this.gcCart.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.riBtnRemove,
            this.riBtnDelete});
            this.gcCart.Size = new System.Drawing.Size(727, 309);
            this.gcCart.TabIndex = 2;
            this.gcCart.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCart});
            // 
            // gvCart
            // 
            this.gvCart.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colRemove,
            this.colServiceID,
            this.collServiceNameBD,
            this.colQuantity,
            this.colTotal,
            this.colDelete});
            this.gvCart.GridControl = this.gcCart;
            this.gvCart.Name = "gvCart";
            this.gvCart.OptionsView.ShowGroupPanel = false;
            // 
            // colRemove
            // 
            this.colRemove.ColumnEdit = this.riBtnRemove;
            this.colRemove.Name = "colRemove";
            this.colRemove.Visible = true;
            this.colRemove.VisibleIndex = 0;
            this.colRemove.Width = 40;
            // 
            // riBtnRemove
            // 
            this.riBtnRemove.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.riBtnRemove.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.riBtnRemove.Name = "riBtnRemove";
            this.riBtnRemove.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.riBtnRemove.Click += new System.EventHandler(this.riBtnRemove_Click);
            // 
            // colServiceID
            // 
            this.colServiceID.Caption = "Mã DV";
            this.colServiceID.FieldName = "ServID";
            this.colServiceID.Name = "colServiceID";
            this.colServiceID.Visible = true;
            this.colServiceID.VisibleIndex = 1;
            // 
            // collServiceNameBD
            // 
            this.collServiceNameBD.Caption = "DỊCH VỤ";
            this.collServiceNameBD.FieldName = "ServiceNameBD";
            this.collServiceNameBD.Name = "collServiceNameBD";
            this.collServiceNameBD.Visible = true;
            this.collServiceNameBD.VisibleIndex = 2;
            this.collServiceNameBD.Width = 381;
            // 
            // colQuantity
            // 
            this.colQuantity.Caption = "SỐ LƯỢNG";
            this.colQuantity.FieldName = "Quantity";
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.Visible = true;
            this.colQuantity.VisibleIndex = 3;
            this.colQuantity.Width = 91;
            // 
            // colTotal
            // 
            this.colTotal.Caption = "THÀNH TIỀN";
            this.colTotal.FieldName = "Total";
            this.colTotal.Name = "colTotal";
            this.colTotal.Visible = true;
            this.colTotal.VisibleIndex = 4;
            this.colTotal.Width = 152;
            // 
            // colDelete
            // 
            this.colDelete.ColumnEdit = this.riBtnDelete;
            this.colDelete.Name = "colDelete";
            this.colDelete.Visible = true;
            this.colDelete.VisibleIndex = 5;
            this.colDelete.Width = 38;
            // 
            // riBtnDelete
            // 
            this.riBtnDelete.AutoHeight = false;
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            this.riBtnDelete.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.riBtnDelete.Name = "riBtnDelete";
            this.riBtnDelete.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.riBtnDelete.Click += new System.EventHandler(this.riBtnDelete_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.txtTotal1);
            this.panelControl1.Controls.Add(this.txtPhone);
            this.panelControl1.Controls.Add(this.btnSave);
            this.panelControl1.Controls.Add(this.dtAppointmentDate);
            this.panelControl1.Controls.Add(this.cbStatus);
            this.panelControl1.Controls.Add(this.ckbPrint);
            this.panelControl1.Controls.Add(this.labelControl11);
            this.panelControl1.Controls.Add(this.labelControl10);
            this.panelControl1.Controls.Add(this.labelControl9);
            this.panelControl1.Controls.Add(this.labelControl8);
            this.panelControl1.Controls.Add(this.labelControl7);
            this.panelControl1.Controls.Add(this.txtAddress);
            this.panelControl1.Controls.Add(this.txtSurcharge);
            this.panelControl1.Controls.Add(this.txtDiscount);
            this.panelControl1.Controls.Add(this.txtTotal);
            this.panelControl1.Controls.Add(this.txtCustomerName);
            this.panelControl1.Controls.Add(this.dtBillDate);
            this.panelControl1.Controls.Add(this.txtBillCode);
            this.panelControl1.Controls.Add(this.labelControl6);
            this.panelControl1.Controls.Add(this.labelControl5);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Location = new System.Drawing.Point(644, 307);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(727, 393);
            this.panelControl1.TabIndex = 3;
            // 
            // txtTotal1
            // 
            this.txtTotal1.Enabled = false;
            this.txtTotal1.Location = new System.Drawing.Point(451, 157);
            this.txtTotal1.Name = "txtTotal1";
            this.txtTotal1.Size = new System.Drawing.Size(202, 21);
            this.txtTotal1.TabIndex = 26;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(451, 113);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(202, 21);
            this.txtPhone.TabIndex = 25;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(536, 286);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(117, 23);
            this.btnSave.TabIndex = 24;
            this.btnSave.Text = "Lưu phiếu";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dtAppointmentDate
            // 
            this.dtAppointmentDate.EditValue = null;
            this.dtAppointmentDate.Location = new System.Drawing.Point(451, 72);
            this.dtAppointmentDate.Name = "dtAppointmentDate";
            this.dtAppointmentDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtAppointmentDate.Size = new System.Drawing.Size(202, 20);
            this.dtAppointmentDate.TabIndex = 21;
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "Chưa giặt",
            "Đã giặt",
            "Đã thanh toán"});
            this.cbStatus.Location = new System.Drawing.Point(451, 30);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(202, 21);
            this.cbStatus.TabIndex = 20;
            // 
            // ckbPrint
            // 
            this.ckbPrint.AutoSize = true;
            this.ckbPrint.Location = new System.Drawing.Point(363, 207);
            this.ckbPrint.Name = "ckbPrint";
            this.ckbPrint.Size = new System.Drawing.Size(99, 17);
            this.ckbPrint.TabIndex = 19;
            this.ckbPrint.Text = "In phiếu khi lưu";
            this.ckbPrint.UseVisualStyleBackColor = true;
            // 
            // labelControl11
            // 
            this.labelControl11.Enabled = false;
            this.labelControl11.Location = new System.Drawing.Point(363, 159);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(51, 13);
            this.labelControl11.TabIndex = 17;
            this.labelControl11.Text = "Thành tiền";
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(363, 116);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(49, 13);
            this.labelControl10.TabIndex = 16;
            this.labelControl10.Text = "Điện thoại";
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(363, 75);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(46, 13);
            this.labelControl9.TabIndex = 15;
            this.labelControl9.Text = "Ngày hẹn";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(363, 30);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(49, 13);
            this.labelControl8.TabIndex = 14;
            this.labelControl8.Text = "Trạng thái";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(200, 157);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(27, 13);
            this.labelControl7.TabIndex = 13;
            this.labelControl7.Text = "CK %";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(94, 242);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(559, 21);
            this.txtAddress.TabIndex = 12;
            // 
            // txtSurcharge
            // 
            this.txtSurcharge.Location = new System.Drawing.Point(94, 199);
            this.txtSurcharge.Name = "txtSurcharge";
            this.txtSurcharge.Size = new System.Drawing.Size(202, 21);
            this.txtSurcharge.TabIndex = 11;
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(226, 154);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(70, 21);
            this.txtDiscount.TabIndex = 10;
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(94, 154);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 21);
            this.txtTotal.TabIndex = 9;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(94, 113);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(202, 21);
            this.txtCustomerName.TabIndex = 8;
            // 
            // dtBillDate
            // 
            this.dtBillDate.EditValue = null;
            this.dtBillDate.Location = new System.Drawing.Point(94, 72);
            this.dtBillDate.Name = "dtBillDate";
            this.dtBillDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtBillDate.Size = new System.Drawing.Size(202, 20);
            this.dtBillDate.TabIndex = 7;
            // 
            // txtBillCode
            // 
            this.txtBillCode.Enabled = false;
            this.txtBillCode.Location = new System.Drawing.Point(94, 30);
            this.txtBillCode.Name = "txtBillCode";
            this.txtBillCode.Size = new System.Drawing.Size(202, 21);
            this.txtBillCode.TabIndex = 6;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(19, 250);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(32, 13);
            this.labelControl6.TabIndex = 5;
            this.labelControl6.Text = "Địa chỉ";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(19, 207);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(37, 13);
            this.labelControl5.TabIndex = 4;
            this.labelControl5.Text = "Phụ thu";
            // 
            // labelControl4
            // 
            this.labelControl4.Enabled = false;
            this.labelControl4.Location = new System.Drawing.Point(19, 162);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(45, 13);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "Tổng tiền";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(19, 121);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(49, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Tên khách";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(19, 79);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(42, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Ngày lập";
            // 
            // labelControl1
            // 
            this.labelControl1.Enabled = false;
            this.labelControl1.Location = new System.Drawing.Point(19, 38);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(41, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Số phiếu";
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
            this.gcServiceList.Size = new System.Drawing.Size(638, 700);
            this.gcServiceList.TabIndex = 4;
            this.gcServiceList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvServiceList});
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "DATABASE_QUANLYTIEMGIATUIConnectionString";
            this.sqlDataSource1.Name = "sqlDataSource1";
            customSqlQuery1.Name = "Query";
            customSqlQuery1.Sql = "SELECT ID, ServiceName, Price FROM Services";
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // gvServiceList
            // 
            this.gvServiceList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colServiceName,
            this.colPrice,
            this.collAdd});
            this.gvServiceList.GridControl = this.gcServiceList;
            this.gvServiceList.Name = "gvServiceList";
            this.gvServiceList.OptionsView.ShowGroupPanel = false;
            // 
            // colID
            // 
            this.colID.Caption = "Mã DV";
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            // 
            // colServiceName
            // 
            this.colServiceName.Caption = "TÊN DỊCH VỤ";
            this.colServiceName.FieldName = "ServiceName";
            this.colServiceName.Name = "colServiceName";
            this.colServiceName.Visible = true;
            this.colServiceName.VisibleIndex = 1;
            this.colServiceName.Width = 390;
            // 
            // colPrice
            // 
            this.colPrice.Caption = "GIÁ";
            this.colPrice.FieldName = "Price";
            this.colPrice.Name = "colPrice";
            this.colPrice.Visible = true;
            this.colPrice.VisibleIndex = 2;
            this.colPrice.Width = 190;
            // 
            // collAdd
            // 
            this.collAdd.ColumnEdit = this.riBtnAdd;
            this.collAdd.Name = "collAdd";
            this.collAdd.Visible = true;
            this.collAdd.VisibleIndex = 3;
            this.collAdd.Width = 33;
            // 
            // riBtnAdd
            // 
            this.riBtnAdd.AutoHeight = false;
            editorButtonImageOptions3.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions3.Image")));
            this.riBtnAdd.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions3, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject9, serializableAppearanceObject10, serializableAppearanceObject11, serializableAppearanceObject12, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.riBtnAdd.Name = "riBtnAdd";
            this.riBtnAdd.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.riBtnAdd.Click += new System.EventHandler(this.ribtnAdd_Click);
            // 
            // fCreateBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 700);
            this.Controls.Add(this.gcServiceList);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.gcCart);
            this.Name = "fCreateBill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LẬP PHIẾU";
            this.Load += new System.EventHandler(this.fCreateBill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcCart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riBtnRemove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riBtnDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtAppointmentDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtBillDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcServiceList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvServiceList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riBtnAdd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.GridControl gcCart;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCart;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn colRemove;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit riBtnRemove;
        private DevExpress.XtraGrid.Columns.GridColumn collServiceNameBD;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colDelete;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit riBtnDelete;
        private DevExpress.XtraGrid.GridControl gcServiceList;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraGrid.Views.Grid.GridView gvServiceList;
        private DevExpress.XtraGrid.Columns.GridColumn colServiceName;
        private DevExpress.XtraGrid.Columns.GridColumn colPrice;
        private DevExpress.XtraGrid.Columns.GridColumn collAdd;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit riBtnAdd;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtSurcharge;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtCustomerName;
        private DevExpress.XtraEditors.DateTimeOffsetEdit dtBillDate;
        private System.Windows.Forms.TextBox txtBillCode;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.DateTimeOffsetEdit dtAppointmentDate;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.CheckBox ckbPrint;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private System.Windows.Forms.TextBox txtTotal1;
        private System.Windows.Forms.TextBox txtPhone;
        private DevExpress.XtraGrid.Columns.GridColumn colServiceID;
    }
}