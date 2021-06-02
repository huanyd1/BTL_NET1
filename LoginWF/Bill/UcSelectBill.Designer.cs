
namespace LoginWF.Bill
{
    partial class UcSelectBill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcSelectBill));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gPaymentType = new DevExpress.XtraGrid.GridControl();
            this.gvPaymentType = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.maKieuThanhToan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tenKieuThanhToan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.mieuTaKieuThanhToan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDeletePaymentType = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddPaymentType = new DevExpress.XtraEditors.SimpleButton();
            this.btnEditPaymentType = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnAddBill = new DevExpress.XtraEditors.SimpleButton();
            this.btnEditBill = new DevExpress.XtraEditors.SimpleButton();
            this.btnDeleteBill = new DevExpress.XtraEditors.SimpleButton();
            this.cbPaymentType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gBill = new DevExpress.XtraGrid.GridControl();
            this.gvBill = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.maHoaDon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.maDatPhong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ngayThanhToan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.soTien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.maKieuThanhToanFRK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ghiChu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gPaymentType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPaymentType)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gBill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBill)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1354, 530);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(671, 524);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kiểu thanh toán";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gPaymentType);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 79);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(665, 442);
            this.panel2.TabIndex = 1;
            // 
            // gPaymentType
            // 
            this.gPaymentType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gPaymentType.Location = new System.Drawing.Point(0, 0);
            this.gPaymentType.MainView = this.gvPaymentType;
            this.gPaymentType.Name = "gPaymentType";
            this.gPaymentType.Size = new System.Drawing.Size(665, 442);
            this.gPaymentType.TabIndex = 10;
            this.gPaymentType.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPaymentType});
            // 
            // gvPaymentType
            // 
            this.gvPaymentType.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.maKieuThanhToan,
            this.tenKieuThanhToan,
            this.mieuTaKieuThanhToan});
            this.gvPaymentType.GridControl = this.gPaymentType;
            this.gvPaymentType.Name = "gvPaymentType";
            this.gvPaymentType.OptionsBehavior.ReadOnly = true;
            this.gvPaymentType.OptionsFind.AlwaysVisible = true;
            this.gvPaymentType.OptionsFind.FindNullPrompt = "Nhập từ khóa để tìm kiếm...";
            this.gvPaymentType.OptionsFind.ShowClearButton = false;
            this.gvPaymentType.OptionsFind.ShowCloseButton = false;
            this.gvPaymentType.OptionsFind.ShowFindButton = false;
            this.gvPaymentType.OptionsView.ShowGroupPanel = false;
            // 
            // maKieuThanhToan
            // 
            this.maKieuThanhToan.Caption = "Mã Kiểu Thanh Toán";
            this.maKieuThanhToan.FieldName = "maKieuThanhToan";
            this.maKieuThanhToan.Name = "maKieuThanhToan";
            this.maKieuThanhToan.Visible = true;
            this.maKieuThanhToan.VisibleIndex = 0;
            // 
            // tenKieuThanhToan
            // 
            this.tenKieuThanhToan.Caption = "Tên Kiểu Thanh Toán";
            this.tenKieuThanhToan.FieldName = "tenKieuThanhToan";
            this.tenKieuThanhToan.Name = "tenKieuThanhToan";
            this.tenKieuThanhToan.Visible = true;
            this.tenKieuThanhToan.VisibleIndex = 1;
            // 
            // mieuTaKieuThanhToan
            // 
            this.mieuTaKieuThanhToan.Caption = "Miêu Tả";
            this.mieuTaKieuThanhToan.FieldName = "mieuTaKieuThanhToan";
            this.mieuTaKieuThanhToan.Name = "mieuTaKieuThanhToan";
            this.mieuTaKieuThanhToan.Visible = true;
            this.mieuTaKieuThanhToan.VisibleIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDeletePaymentType);
            this.panel1.Controls.Add(this.btnAddPaymentType);
            this.panel1.Controls.Add(this.btnEditPaymentType);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(665, 60);
            this.panel1.TabIndex = 0;
            // 
            // btnDeletePaymentType
            // 
            this.btnDeletePaymentType.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDeletePaymentType.ImageOptions.Image")));
            this.btnDeletePaymentType.Location = new System.Drawing.Point(320, 5);
            this.btnDeletePaymentType.Name = "btnDeletePaymentType";
            this.btnDeletePaymentType.Size = new System.Drawing.Size(150, 50);
            this.btnDeletePaymentType.TabIndex = 15;
            this.btnDeletePaymentType.Text = "Xóa";
            this.btnDeletePaymentType.Click += new System.EventHandler(this.btnDeletePaymentType_Click);
            // 
            // btnAddPaymentType
            // 
            this.btnAddPaymentType.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAddPaymentType.ImageOptions.Image")));
            this.btnAddPaymentType.Location = new System.Drawing.Point(8, 5);
            this.btnAddPaymentType.Name = "btnAddPaymentType";
            this.btnAddPaymentType.Size = new System.Drawing.Size(150, 50);
            this.btnAddPaymentType.TabIndex = 13;
            this.btnAddPaymentType.Text = "Thêm";
            this.btnAddPaymentType.Click += new System.EventHandler(this.btnAddPaymentType_Click);
            // 
            // btnEditPaymentType
            // 
            this.btnEditPaymentType.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEditPaymentType.ImageOptions.Image")));
            this.btnEditPaymentType.Location = new System.Drawing.Point(164, 5);
            this.btnEditPaymentType.Name = "btnEditPaymentType";
            this.btnEditPaymentType.Size = new System.Drawing.Size(150, 50);
            this.btnEditPaymentType.TabIndex = 14;
            this.btnEditPaymentType.Text = "Sửa";
            this.btnEditPaymentType.Click += new System.EventHandler(this.btnEditPaymentType_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel3);
            this.groupBox2.Controls.Add(this.gBill);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(680, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(671, 524);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hóa đơn";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnAddBill);
            this.panel3.Controls.Add(this.btnEditBill);
            this.panel3.Controls.Add(this.btnDeleteBill);
            this.panel3.Controls.Add(this.cbPaymentType);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 19);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(665, 100);
            this.panel3.TabIndex = 27;
            // 
            // btnAddBill
            // 
            this.btnAddBill.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAddBill.ImageOptions.Image")));
            this.btnAddBill.Location = new System.Drawing.Point(12, 5);
            this.btnAddBill.Name = "btnAddBill";
            this.btnAddBill.Size = new System.Drawing.Size(150, 50);
            this.btnAddBill.TabIndex = 27;
            this.btnAddBill.Text = "Thêm";
            this.btnAddBill.Click += new System.EventHandler(this.btnAddBill_Click);
            // 
            // btnEditBill
            // 
            this.btnEditBill.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEditBill.ImageOptions.Image")));
            this.btnEditBill.Location = new System.Drawing.Point(168, 5);
            this.btnEditBill.Name = "btnEditBill";
            this.btnEditBill.Size = new System.Drawing.Size(150, 50);
            this.btnEditBill.TabIndex = 28;
            this.btnEditBill.Text = "Sửa";
            this.btnEditBill.Click += new System.EventHandler(this.btnEditBill_Click);
            // 
            // btnDeleteBill
            // 
            this.btnDeleteBill.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteBill.ImageOptions.Image")));
            this.btnDeleteBill.Location = new System.Drawing.Point(324, 5);
            this.btnDeleteBill.Name = "btnDeleteBill";
            this.btnDeleteBill.Size = new System.Drawing.Size(150, 50);
            this.btnDeleteBill.TabIndex = 29;
            this.btnDeleteBill.Text = "Xóa";
            // 
            // cbPaymentType
            // 
            this.cbPaymentType.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPaymentType.FormattingEnabled = true;
            this.cbPaymentType.Location = new System.Drawing.Point(262, 66);
            this.cbPaymentType.Name = "cbPaymentType";
            this.cbPaymentType.Size = new System.Drawing.Size(306, 26);
            this.cbPaymentType.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 18);
            this.label1.TabIndex = 30;
            this.label1.Text = "Lựa chọn kiểu thanh toán : ";
            // 
            // gBill
            // 
            this.gBill.Location = new System.Drawing.Point(3, 119);
            this.gBill.MainView = this.gvBill;
            this.gBill.Name = "gBill";
            this.gBill.Size = new System.Drawing.Size(665, 402);
            this.gBill.TabIndex = 21;
            this.gBill.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvBill});
            // 
            // gvBill
            // 
            this.gvBill.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.maHoaDon,
            this.maDatPhong,
            this.ngayThanhToan,
            this.soTien,
            this.maKieuThanhToanFRK,
            this.ghiChu});
            this.gvBill.GridControl = this.gBill;
            this.gvBill.Name = "gvBill";
            this.gvBill.OptionsBehavior.ReadOnly = true;
            this.gvBill.OptionsFind.AlwaysVisible = true;
            this.gvBill.OptionsFind.FindNullPrompt = "Nhập từ khóa để tìm kiếm...";
            this.gvBill.OptionsFind.ShowClearButton = false;
            this.gvBill.OptionsFind.ShowCloseButton = false;
            this.gvBill.OptionsFind.ShowFindButton = false;
            this.gvBill.OptionsView.ShowGroupPanel = false;
            // 
            // maHoaDon
            // 
            this.maHoaDon.Caption = "Mã Hóa Đơn";
            this.maHoaDon.FieldName = "maHoaDon";
            this.maHoaDon.Name = "maHoaDon";
            this.maHoaDon.Visible = true;
            this.maHoaDon.VisibleIndex = 0;
            // 
            // maDatPhong
            // 
            this.maDatPhong.Caption = "Mã Đặt Phòng";
            this.maDatPhong.FieldName = "maDatPhong";
            this.maDatPhong.Name = "maDatPhong";
            this.maDatPhong.Visible = true;
            this.maDatPhong.VisibleIndex = 1;
            // 
            // ngayThanhToan
            // 
            this.ngayThanhToan.Caption = "Ngày Thanh Toán";
            this.ngayThanhToan.FieldName = "ngayThanhToan";
            this.ngayThanhToan.Name = "ngayThanhToan";
            this.ngayThanhToan.Visible = true;
            this.ngayThanhToan.VisibleIndex = 2;
            // 
            // soTien
            // 
            this.soTien.Caption = "Số Tiền";
            this.soTien.FieldName = "soTien";
            this.soTien.Name = "soTien";
            this.soTien.Visible = true;
            this.soTien.VisibleIndex = 3;
            // 
            // maKieuThanhToanFRK
            // 
            this.maKieuThanhToanFRK.Caption = "Mã Kiểu Thanh Toán";
            this.maKieuThanhToanFRK.FieldName = "maKieuThanhToan";
            this.maKieuThanhToanFRK.Name = "maKieuThanhToanFRK";
            this.maKieuThanhToanFRK.Visible = true;
            this.maKieuThanhToanFRK.VisibleIndex = 4;
            // 
            // ghiChu
            // 
            this.ghiChu.Caption = "Ghi Chú";
            this.ghiChu.FieldName = "ghiChu";
            this.ghiChu.Name = "ghiChu";
            this.ghiChu.Visible = true;
            this.ghiChu.VisibleIndex = 5;
            // 
            // UcSelectBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UcSelectBill";
            this.Size = new System.Drawing.Size(1354, 530);
            this.Load += new System.EventHandler(this.UcSelectBill_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gPaymentType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPaymentType)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gBill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBill)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraGrid.GridControl gPaymentType;
        private DevExpress.XtraGrid.Views.Grid.GridView gvPaymentType;
        private DevExpress.XtraGrid.Columns.GridColumn maKieuThanhToan;
        private DevExpress.XtraGrid.Columns.GridColumn tenKieuThanhToan;
        private DevExpress.XtraGrid.Columns.GridColumn mieuTaKieuThanhToan;
        private DevExpress.XtraEditors.SimpleButton btnDeletePaymentType;
        private DevExpress.XtraEditors.SimpleButton btnAddPaymentType;
        private DevExpress.XtraEditors.SimpleButton btnEditPaymentType;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraEditors.SimpleButton btnAddBill;
        private DevExpress.XtraEditors.SimpleButton btnEditBill;
        private DevExpress.XtraEditors.SimpleButton btnDeleteBill;
        private System.Windows.Forms.ComboBox cbPaymentType;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl gBill;
        private DevExpress.XtraGrid.Views.Grid.GridView gvBill;
        private DevExpress.XtraGrid.Columns.GridColumn maHoaDon;
        private DevExpress.XtraGrid.Columns.GridColumn maDatPhong;
        private DevExpress.XtraGrid.Columns.GridColumn ngayThanhToan;
        private DevExpress.XtraGrid.Columns.GridColumn soTien;
        private DevExpress.XtraGrid.Columns.GridColumn maKieuThanhToanFRK;
        private DevExpress.XtraGrid.Columns.GridColumn ghiChu;
    }
}
