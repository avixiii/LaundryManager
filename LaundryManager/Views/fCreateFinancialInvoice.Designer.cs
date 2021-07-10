
namespace LaundryManager.Views
{
    partial class fCreateFinancialInvoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fCreateFinancialInvoice));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtPayer = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtReason = new System.Windows.Forms.TextBox();
            this.txtExplain = new System.Windows.Forms.TextBox();
            this.cbBillType = new System.Windows.Forms.ComboBox();
            this.dtBillType = new DevExpress.XtraEditors.DateEdit();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.ckbPrint = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtBillType.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtBillType.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(30, 28);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(43, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Mã phiếu";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(30, 70);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(48, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Loại phiếu";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(30, 115);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(42, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Ngày lập";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(30, 161);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(55, 13);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "Người nhận";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(30, 210);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(33, 13);
            this.labelControl5.TabIndex = 4;
            this.labelControl5.Text = "Số tiền";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(30, 258);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(26, 13);
            this.labelControl6.TabIndex = 5;
            this.labelControl6.Text = "Lý do";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(30, 308);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(40, 13);
            this.labelControl7.TabIndex = 6;
            this.labelControl7.Text = "Diễn giải";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(142, 20);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(158, 21);
            this.txtID.TabIndex = 7;
            // 
            // txtPayer
            // 
            this.txtPayer.Location = new System.Drawing.Point(142, 153);
            this.txtPayer.Name = "txtPayer";
            this.txtPayer.Size = new System.Drawing.Size(350, 21);
            this.txtPayer.TabIndex = 10;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(142, 202);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(350, 21);
            this.txtAmount.TabIndex = 11;
            // 
            // txtReason
            // 
            this.txtReason.Location = new System.Drawing.Point(142, 250);
            this.txtReason.Name = "txtReason";
            this.txtReason.Size = new System.Drawing.Size(350, 21);
            this.txtReason.TabIndex = 12;
            // 
            // txtExplain
            // 
            this.txtExplain.Location = new System.Drawing.Point(142, 300);
            this.txtExplain.Name = "txtExplain";
            this.txtExplain.Size = new System.Drawing.Size(350, 21);
            this.txtExplain.TabIndex = 13;
            // 
            // cbBillType
            // 
            this.cbBillType.FormattingEnabled = true;
            this.cbBillType.Items.AddRange(new object[] {
            "Phiếu chi",
            "Phiếu thu"});
            this.cbBillType.Location = new System.Drawing.Point(142, 62);
            this.cbBillType.Name = "cbBillType";
            this.cbBillType.Size = new System.Drawing.Size(350, 21);
            this.cbBillType.TabIndex = 14;
            this.cbBillType.SelectedIndexChanged += new System.EventHandler(this.cbBillType_SelectedIndexChanged);
            // 
            // dtBillType
            // 
            this.dtBillType.EditValue = null;
            this.dtBillType.Location = new System.Drawing.Point(142, 107);
            this.dtBillType.Name = "dtBillType";
            this.dtBillType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtBillType.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtBillType.Size = new System.Drawing.Size(350, 20);
            this.dtBillType.TabIndex = 15;
            // 
            // btnSave
            // 
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btnSave.Location = new System.Drawing.Point(206, 351);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Lưu";
            // 
            // btnClose
            // 
            this.btnClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.btnClose.Location = new System.Drawing.Point(337, 351);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 17;
            this.btnClose.Text = "Đóng";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ckbPrint
            // 
            this.ckbPrint.AutoSize = true;
            this.ckbPrint.Location = new System.Drawing.Point(337, 23);
            this.ckbPrint.Name = "ckbPrint";
            this.ckbPrint.Size = new System.Drawing.Size(99, 17);
            this.ckbPrint.TabIndex = 18;
            this.ckbPrint.Text = "In phiếu khi lưu";
            this.ckbPrint.UseVisualStyleBackColor = true;
            // 
            // fCreateFinancialInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 411);
            this.Controls.Add(this.ckbPrint);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dtBillType);
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
            this.Name = "fCreateFinancialInvoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LẬP PHIẾU";
            this.Load += new System.EventHandler(this.fCreateFinancialInvoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtBillType.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtBillType.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtPayer;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtReason;
        private System.Windows.Forms.TextBox txtExplain;
        private System.Windows.Forms.ComboBox cbBillType;
        private DevExpress.XtraEditors.DateEdit dtBillType;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private System.Windows.Forms.CheckBox ckbPrint;
    }
}