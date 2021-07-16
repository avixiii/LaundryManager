
namespace LaundryManager.Views
{
    partial class UCRevenueStatistics
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
            this.gcUnpaid = new DevExpress.XtraGrid.GridControl();
            this.gvUnpaid = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colBillCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmployee = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBillDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcPaid = new DevExpress.XtraGrid.GridControl();
            this.gvPaid = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colBillCode1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhone1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUser1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBillDate1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotal1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPaid = new System.Windows.Forms.Label();
            this.lblUnpaid = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gcUnpaid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvUnpaid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPaid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPaid)).BeginInit();
            this.SuspendLayout();
            // 
            // gcUnpaid
            // 
            this.gcUnpaid.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcUnpaid.Location = new System.Drawing.Point(0, 0);
            this.gcUnpaid.MainView = this.gvUnpaid;
            this.gcUnpaid.Name = "gcUnpaid";
            this.gcUnpaid.Size = new System.Drawing.Size(1302, 379);
            this.gcUnpaid.TabIndex = 0;
            this.gcUnpaid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvUnpaid});
            // 
            // gvUnpaid
            // 
            this.gvUnpaid.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colBillCode,
            this.colName,
            this.colPhone,
            this.colEmployee,
            this.colBillDate,
            this.colTotal});
            this.gvUnpaid.GridControl = this.gcUnpaid;
            this.gvUnpaid.Name = "gvUnpaid";
            // 
            // colBillCode
            // 
            this.colBillCode.Caption = "Số phiếu";
            this.colBillCode.FieldName = "BillCode";
            this.colBillCode.Name = "colBillCode";
            this.colBillCode.OptionsColumn.AllowFocus = false;
            this.colBillCode.Visible = true;
            this.colBillCode.VisibleIndex = 0;
            // 
            // colName
            // 
            this.colName.Caption = "Tên khách hàng";
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.OptionsColumn.AllowFocus = false;
            this.colName.Visible = true;
            this.colName.VisibleIndex = 1;
            // 
            // colPhone
            // 
            this.colPhone.Caption = "Điện thoại";
            this.colPhone.FieldName = "Phone";
            this.colPhone.Name = "colPhone";
            this.colPhone.OptionsColumn.AllowFocus = false;
            this.colPhone.Visible = true;
            this.colPhone.VisibleIndex = 2;
            // 
            // colEmployee
            // 
            this.colEmployee.Caption = "Nhân viên lập";
            this.colEmployee.FieldName = "FullName";
            this.colEmployee.Name = "colEmployee";
            this.colEmployee.OptionsColumn.AllowFocus = false;
            this.colEmployee.Visible = true;
            this.colEmployee.VisibleIndex = 3;
            // 
            // colBillDate
            // 
            this.colBillDate.Caption = "Ngày lập";
            this.colBillDate.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.colBillDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colBillDate.FieldName = "BillDate";
            this.colBillDate.Name = "colBillDate";
            this.colBillDate.OptionsColumn.AllowFocus = false;
            this.colBillDate.Visible = true;
            this.colBillDate.VisibleIndex = 4;
            // 
            // colTotal
            // 
            this.colTotal.Caption = "Thành tiền";
            this.colTotal.DisplayFormat.FormatString = "{0:#,##0.00}";
            this.colTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotal.FieldName = "Total";
            this.colTotal.Name = "colTotal";
            this.colTotal.OptionsColumn.AllowFocus = false;
            this.colTotal.Visible = true;
            this.colTotal.VisibleIndex = 5;
            // 
            // gcPaid
            // 
            this.gcPaid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcPaid.Location = new System.Drawing.Point(0, 379);
            this.gcPaid.MainView = this.gvPaid;
            this.gcPaid.Name = "gcPaid";
            this.gcPaid.Size = new System.Drawing.Size(1302, 346);
            this.gcPaid.TabIndex = 1;
            this.gcPaid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPaid});
            // 
            // gvPaid
            // 
            this.gvPaid.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colBillCode1,
            this.colName1,
            this.colPhone1,
            this.colUser1,
            this.colBillDate1,
            this.colTotal1});
            this.gvPaid.GridControl = this.gcPaid;
            this.gvPaid.Name = "gvPaid";
            // 
            // colBillCode1
            // 
            this.colBillCode1.Caption = "Số phiếu";
            this.colBillCode1.FieldName = "BillCode";
            this.colBillCode1.Name = "colBillCode1";
            this.colBillCode1.OptionsColumn.AllowFocus = false;
            this.colBillCode1.Visible = true;
            this.colBillCode1.VisibleIndex = 0;
            this.colBillCode1.Width = 212;
            // 
            // colName1
            // 
            this.colName1.Caption = "Tên khách hàng";
            this.colName1.FieldName = "Name";
            this.colName1.Name = "colName1";
            this.colName1.OptionsColumn.AllowFocus = false;
            this.colName1.Visible = true;
            this.colName1.VisibleIndex = 1;
            this.colName1.Width = 212;
            // 
            // colPhone1
            // 
            this.colPhone1.Caption = "Điện thoại";
            this.colPhone1.Name = "colPhone1";
            this.colPhone1.OptionsColumn.AllowFocus = false;
            this.colPhone1.Visible = true;
            this.colPhone1.VisibleIndex = 2;
            this.colPhone1.Width = 212;
            // 
            // colUser1
            // 
            this.colUser1.Caption = "Nhân viên lập";
            this.colUser1.FieldName = "FullName";
            this.colUser1.Name = "colUser1";
            this.colUser1.OptionsColumn.AllowFocus = false;
            this.colUser1.Visible = true;
            this.colUser1.VisibleIndex = 3;
            this.colUser1.Width = 212;
            // 
            // colBillDate1
            // 
            this.colBillDate1.Caption = "Ngày lập";
            this.colBillDate1.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.colBillDate1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colBillDate1.FieldName = "BillDate";
            this.colBillDate1.Name = "colBillDate1";
            this.colBillDate1.OptionsColumn.AllowFocus = false;
            this.colBillDate1.Visible = true;
            this.colBillDate1.VisibleIndex = 4;
            this.colBillDate1.Width = 208;
            // 
            // colTotal1
            // 
            this.colTotal1.Caption = "Thành tiền";
            this.colTotal1.DisplayFormat.FormatString = "{0:#,##0.00}";
            this.colTotal1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotal1.FieldName = "Total";
            this.colTotal1.Name = "colTotal1";
            this.colTotal1.OptionsColumn.AllowFocus = false;
            this.colTotal1.Visible = true;
            this.colTotal1.VisibleIndex = 5;
            this.colTotal1.Width = 221;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "CHƯA THANH TOÁN :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 392);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "ĐÃ GIAO  / ĐÃ THANH TOÁN:";
            // 
            // lblPaid
            // 
            this.lblPaid.AutoSize = true;
            this.lblPaid.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaid.ForeColor = System.Drawing.Color.Red;
            this.lblPaid.Location = new System.Drawing.Point(203, 392);
            this.lblPaid.Name = "lblPaid";
            this.lblPaid.Size = new System.Drawing.Size(60, 16);
            this.lblPaid.TabIndex = 5;
            this.lblPaid.Text = "365.000";
            // 
            // lblUnpaid
            // 
            this.lblUnpaid.AutoSize = true;
            this.lblUnpaid.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnpaid.ForeColor = System.Drawing.Color.Red;
            this.lblUnpaid.Location = new System.Drawing.Point(147, 11);
            this.lblUnpaid.Name = "lblUnpaid";
            this.lblUnpaid.Size = new System.Drawing.Size(60, 16);
            this.lblUnpaid.TabIndex = 6;
            this.lblUnpaid.Text = "365.000";
            // 
            // UCRevenueStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblUnpaid);
            this.Controls.Add(this.lblPaid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gcPaid);
            this.Controls.Add(this.gcUnpaid);
            this.Name = "UCRevenueStatistics";
            this.Size = new System.Drawing.Size(1302, 725);
            this.Load += new System.EventHandler(this.UCRevenueStatistics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcUnpaid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvUnpaid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPaid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPaid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcUnpaid;
        private DevExpress.XtraGrid.Views.Grid.GridView gvUnpaid;
        private DevExpress.XtraGrid.GridControl gcPaid;
        private DevExpress.XtraGrid.Views.Grid.GridView gvPaid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPaid;
        private System.Windows.Forms.Label lblUnpaid;
        private DevExpress.XtraGrid.Columns.GridColumn colBillCode;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colPhone;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployee;
        private DevExpress.XtraGrid.Columns.GridColumn colBillDate;
        private DevExpress.XtraGrid.Columns.GridColumn colTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colBillCode1;
        private DevExpress.XtraGrid.Columns.GridColumn colName1;
        private DevExpress.XtraGrid.Columns.GridColumn colPhone1;
        private DevExpress.XtraGrid.Columns.GridColumn colUser1;
        private DevExpress.XtraGrid.Columns.GridColumn colBillDate1;
        private DevExpress.XtraGrid.Columns.GridColumn colTotal1;
    }
}
