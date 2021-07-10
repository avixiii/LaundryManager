
namespace LaundryManager.Views
{
    partial class UCFinancialManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCFinancialManagement));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnCreate = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.dockPanel1 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
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
            this.dtTime = new DevExpress.XtraEditors.DateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            this.dockPanel1.SuspendLayout();
            this.dockPanel1_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTime.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTime.Properties)).BeginInit();
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
            // 
            // btnEdit
            // 
            this.btnEdit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.ImageOptions.Image")));
            this.btnEdit.Location = new System.Drawing.Point(158, 11);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Sửa";
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
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(382, 46);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(779, 564);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
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
            this.dockPanel1_Container.Controls.Add(this.labelControl7);
            this.dockPanel1_Container.Controls.Add(this.labelControl9);
            this.dockPanel1_Container.Controls.Add(this.labelControl8);
            this.dockPanel1_Container.Controls.Add(this.labelControl6);
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
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(222, 285);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(80, 19);
            this.labelControl7.TabIndex = 22;
            this.labelControl7.Text = "3.000.000";
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
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(28, 285);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(80, 19);
            this.labelControl6.TabIndex = 18;
            this.labelControl6.Text = "5.000.000";
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
            // UCFinancialManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.dockPanel1);
            this.Name = "UCFinancialManagement";
            this.Size = new System.Drawing.Size(1161, 610);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            this.dockPanel1.ResumeLayout(false);
            this.dockPanel1_Container.ResumeLayout(false);
            this.dockPanel1_Container.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTime.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTime.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.SimpleButton btnCreate;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
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
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.DateEdit dtTime;
    }
}
