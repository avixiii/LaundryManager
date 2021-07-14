
namespace LaundryManager.Views
{
    partial class fEditACashBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fEditACashBook));
            this.ckbPrint = new System.Windows.Forms.CheckBox();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.dtBillDate = new DevExpress.XtraEditors.DateEdit();
            this.cbBillType = new System.Windows.Forms.ComboBox();
            this.txtExplain = new System.Windows.Forms.TextBox();
            this.txtReason = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtPayer = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.dtBillDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtBillDate.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ckbPrint
            // 
            this.ckbPrint.AutoSize = true;
            this.ckbPrint.Location = new System.Drawing.Point(350, 28);
            this.ckbPrint.Name = "ckbPrint";
            this.ckbPrint.Size = new System.Drawing.Size(99, 17);
            this.ckbPrint.TabIndex = 35;
            this.ckbPrint.Text = "In phiếu khi lưu";
            this.ckbPrint.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.ImageOptions.Image")));
            this.btnClose.Location = new System.Drawing.Point(350, 356);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 34;
            this.btnClose.Text = "Đóng";
            // 
            // btnSave
            // 
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.Location = new System.Drawing.Point(219, 356);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 33;
            this.btnSave.Text = "Lưu";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dtBillDate
            // 
            this.dtBillDate.EditValue = null;
            this.dtBillDate.Location = new System.Drawing.Point(155, 112);
            this.dtBillDate.Name = "dtBillDate";
            this.dtBillDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtBillDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtBillDate.Size = new System.Drawing.Size(350, 20);
            this.dtBillDate.TabIndex = 23;
            // 
            // cbBillType
            // 
            this.cbBillType.FormattingEnabled = true;
            this.cbBillType.Items.AddRange(new object[] {
            "Phiếu chi",
            "Phiếu thu"});
            this.cbBillType.Location = new System.Drawing.Point(155, 67);
            this.cbBillType.Name = "cbBillType";
            this.cbBillType.Size = new System.Drawing.Size(350, 21);
            this.cbBillType.TabIndex = 20;
            // 
            // txtExplain
            // 
            this.txtExplain.Location = new System.Drawing.Point(155, 305);
            this.txtExplain.Name = "txtExplain";
            this.txtExplain.Size = new System.Drawing.Size(350, 21);
            this.txtExplain.TabIndex = 30;
            // 
            // txtReason
            // 
            this.txtReason.Location = new System.Drawing.Point(155, 255);
            this.txtReason.Name = "txtReason";
            this.txtReason.Size = new System.Drawing.Size(350, 21);
            this.txtReason.TabIndex = 29;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(155, 207);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(350, 21);
            this.txtAmount.TabIndex = 26;
            // 
            // txtPayer
            // 
            this.txtPayer.Location = new System.Drawing.Point(155, 158);
            this.txtPayer.Name = "txtPayer";
            this.txtPayer.Size = new System.Drawing.Size(350, 21);
            this.txtPayer.TabIndex = 25;
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(155, 25);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(158, 21);
            this.txtID.TabIndex = 32;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(43, 313);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(40, 13);
            this.labelControl7.TabIndex = 31;
            this.labelControl7.Text = "Diễn giải";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(43, 263);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(26, 13);
            this.labelControl6.TabIndex = 28;
            this.labelControl6.Text = "Lý do";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(43, 215);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(33, 13);
            this.labelControl5.TabIndex = 27;
            this.labelControl5.Text = "Số tiền";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(43, 166);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(55, 13);
            this.labelControl4.TabIndex = 24;
            this.labelControl4.Text = "Người nhận";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(43, 120);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(42, 13);
            this.labelControl3.TabIndex = 22;
            this.labelControl3.Text = "Ngày lập";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(43, 75);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(48, 13);
            this.labelControl2.TabIndex = 21;
            this.labelControl2.Text = "Loại phiếu";
            // 
            // labelControl1
            // 
            this.labelControl1.Enabled = false;
            this.labelControl1.Location = new System.Drawing.Point(43, 33);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(43, 13);
            this.labelControl1.TabIndex = 19;
            this.labelControl1.Text = "Mã phiếu";
            // 
            // fEditACashBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 411);
            this.Controls.Add(this.ckbPrint);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dtBillDate);
            this.Controls.Add(this.cbBillType);
            this.Controls.Add(this.txtExplain);
            this.Controls.Add(this.txtReason);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtPayer);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Name = "fEditACashBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chỉnh sửa";
            this.Load += new System.EventHandler(this.fEditACashBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtBillDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtBillDate.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ckbPrint;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.DateEdit dtBillDate;
        private System.Windows.Forms.ComboBox cbBillType;
        private System.Windows.Forms.TextBox txtExplain;
        private System.Windows.Forms.TextBox txtReason;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtPayer;
        private System.Windows.Forms.TextBox txtID;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}