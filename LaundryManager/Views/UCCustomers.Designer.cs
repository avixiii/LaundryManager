
namespace LaundryManager.Views
{
    partial class UCCustomers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCCustomers));
            this.gcCustomers = new DevExpress.XtraGrid.GridControl();
            this.gvCustomers = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalBill = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gcCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // gcCustomers
            // 
            this.gcCustomers.DataMember = "Query";
            this.gcCustomers.DataSource = this.sqlDataSource1;
            this.gcCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcCustomers.Location = new System.Drawing.Point(0, 0);
            this.gcCustomers.MainView = this.gvCustomers;
            this.gcCustomers.Name = "gcCustomers";
            this.gcCustomers.Size = new System.Drawing.Size(1181, 580);
            this.gcCustomers.TabIndex = 0;
            this.gcCustomers.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCustomers});
            // 
            // gvCustomers
            // 
            this.gvCustomers.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colName,
            this.colAddress,
            this.colPhone,
            this.colTotalBill});
            this.gvCustomers.GridControl = this.gcCustomers;
            this.gvCustomers.Name = "gvCustomers";
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "DATABASE_QUANLYTIEMGIATUIConnectionString";
            this.sqlDataSource1.Name = "sqlDataSource1";
            customSqlQuery1.Name = "Query";
            customSqlQuery1.Sql = "SELECT * FROM Customers";
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 1;
            // 
            // colAddress
            // 
            this.colAddress.FieldName = "Address";
            this.colAddress.Name = "colAddress";
            this.colAddress.Visible = true;
            this.colAddress.VisibleIndex = 2;
            // 
            // colPhone
            // 
            this.colPhone.FieldName = "Phone";
            this.colPhone.Name = "colPhone";
            this.colPhone.Visible = true;
            this.colPhone.VisibleIndex = 3;
            // 
            // colTotalBill
            // 
            this.colTotalBill.FieldName = "TotalBill";
            this.colTotalBill.Name = "colTotalBill";
            this.colTotalBill.Visible = true;
            this.colTotalBill.VisibleIndex = 4;
            // 
            // UCCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gcCustomers);
            this.Name = "UCCustomers";
            this.Size = new System.Drawing.Size(1181, 580);
            ((System.ComponentModel.ISupportInitialize)(this.gcCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCustomers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcCustomers;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCustomers;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colPhone;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalBill;
    }
}
