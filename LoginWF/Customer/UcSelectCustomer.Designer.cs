
namespace LoginWF.Customer
{
    partial class UcSelectCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcSelectCustomer));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gCustomer = new DevExpress.XtraGrid.GridControl();
            this.gvCustomer = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.maKhachHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tenKhachHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tenDangNhap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.matKhau = new DevExpress.XtraGrid.Columns.GridColumn();
            this.maSoThe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.diaChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.mieuTaKhachHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbCardCustomer = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDeleteCustomer = new DevExpress.XtraEditors.SimpleButton();
            this.btnEditCustomer = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddCustomer = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCustomer)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gCustomer);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(1354, 530);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Khách hàng";
            // 
            // gCustomer
            // 
            this.gCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gCustomer.Location = new System.Drawing.Point(3, 80);
            this.gCustomer.MainView = this.gvCustomer;
            this.gCustomer.Name = "gCustomer";
            this.gCustomer.Size = new System.Drawing.Size(1348, 446);
            this.gCustomer.TabIndex = 10;
            this.gCustomer.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCustomer});
            // 
            // gvCustomer
            // 
            this.gvCustomer.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.maKhachHang,
            this.tenKhachHang,
            this.tenDangNhap,
            this.matKhau,
            this.maSoThe,
            this.diaChi,
            this.mieuTaKhachHang});
            this.gvCustomer.GridControl = this.gCustomer;
            this.gvCustomer.Name = "gvCustomer";
            this.gvCustomer.OptionsBehavior.ReadOnly = true;
            this.gvCustomer.OptionsFind.AlwaysVisible = true;
            this.gvCustomer.OptionsFind.FindNullPrompt = "Nhập từ khóa để tìm kiếm...";
            this.gvCustomer.OptionsFind.ShowClearButton = false;
            this.gvCustomer.OptionsFind.ShowCloseButton = false;
            this.gvCustomer.OptionsFind.ShowFindButton = false;
            this.gvCustomer.OptionsView.ShowGroupPanel = false;
            // 
            // maKhachHang
            // 
            this.maKhachHang.Caption = "Mã Khách Hàng";
            this.maKhachHang.FieldName = "maKhachHang";
            this.maKhachHang.Name = "maKhachHang";
            this.maKhachHang.Visible = true;
            this.maKhachHang.VisibleIndex = 0;
            // 
            // tenKhachHang
            // 
            this.tenKhachHang.Caption = "Tên Khách Hàng";
            this.tenKhachHang.FieldName = "tenKhachHang";
            this.tenKhachHang.Name = "tenKhachHang";
            this.tenKhachHang.Visible = true;
            this.tenKhachHang.VisibleIndex = 1;
            // 
            // tenDangNhap
            // 
            this.tenDangNhap.Caption = "Tên Đăng Nhập";
            this.tenDangNhap.FieldName = "tenDangNhap";
            this.tenDangNhap.Name = "tenDangNhap";
            this.tenDangNhap.Visible = true;
            this.tenDangNhap.VisibleIndex = 2;
            // 
            // matKhau
            // 
            this.matKhau.Caption = "Mật Khẩu";
            this.matKhau.FieldName = "matKhau";
            this.matKhau.Name = "matKhau";
            this.matKhau.Visible = true;
            this.matKhau.VisibleIndex = 3;
            // 
            // maSoThe
            // 
            this.maSoThe.Caption = "Mã Số Thẻ";
            this.maSoThe.FieldName = "maSoThe";
            this.maSoThe.Name = "maSoThe";
            this.maSoThe.Visible = true;
            this.maSoThe.VisibleIndex = 4;
            // 
            // diaChi
            // 
            this.diaChi.Caption = "Địa Chỉ";
            this.diaChi.FieldName = "diaChi";
            this.diaChi.Name = "diaChi";
            this.diaChi.Visible = true;
            this.diaChi.VisibleIndex = 5;
            // 
            // mieuTaKhachHang
            // 
            this.mieuTaKhachHang.Caption = "Miêu Tả Khách Hàng";
            this.mieuTaKhachHang.FieldName = "mieuTaKhachHang";
            this.mieuTaKhachHang.Name = "mieuTaKhachHang";
            this.mieuTaKhachHang.Visible = true;
            this.mieuTaKhachHang.VisibleIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbCardCustomer);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnDeleteCustomer);
            this.panel1.Controls.Add(this.btnEditCustomer);
            this.panel1.Controls.Add(this.btnAddCustomer);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1348, 60);
            this.panel1.TabIndex = 0;
            // 
            // cbCardCustomer
            // 
            this.cbCardCustomer.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCardCustomer.FormattingEnabled = true;
            this.cbCardCustomer.Location = new System.Drawing.Point(668, 17);
            this.cbCardCustomer.Name = "cbCardCustomer";
            this.cbCardCustomer.Size = new System.Drawing.Size(324, 26);
            this.cbCardCustomer.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(503, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 18);
            this.label1.TabIndex = 18;
            this.label1.Text = "Lựa chọn tên thẻ: ";
            // 
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteCustomer.ImageOptions.Image")));
            this.btnDeleteCustomer.Location = new System.Drawing.Point(319, 5);
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Size = new System.Drawing.Size(150, 50);
            this.btnDeleteCustomer.TabIndex = 15;
            this.btnDeleteCustomer.Text = "Xóa";
            this.btnDeleteCustomer.Click += new System.EventHandler(this.btnDeleteCustomer_Click);
            // 
            // btnEditCustomer
            // 
            this.btnEditCustomer.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEditCustomer.ImageOptions.Image")));
            this.btnEditCustomer.Location = new System.Drawing.Point(163, 5);
            this.btnEditCustomer.Name = "btnEditCustomer";
            this.btnEditCustomer.Size = new System.Drawing.Size(150, 50);
            this.btnEditCustomer.TabIndex = 14;
            this.btnEditCustomer.Text = "Sửa";
            this.btnEditCustomer.Click += new System.EventHandler(this.btnEditCustomer_Click);
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAddCustomer.ImageOptions.Image")));
            this.btnAddCustomer.Location = new System.Drawing.Point(7, 5);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(150, 50);
            this.btnAddCustomer.TabIndex = 13;
            this.btnAddCustomer.Text = "Thêm";
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // UcSelectCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UcSelectCustomer";
            this.Size = new System.Drawing.Size(1354, 530);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCustomer)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnDeleteCustomer;
        private DevExpress.XtraEditors.SimpleButton btnEditCustomer;
        private DevExpress.XtraEditors.SimpleButton btnAddCustomer;
        private DevExpress.XtraGrid.GridControl gCustomer;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCustomer;
        private DevExpress.XtraGrid.Columns.GridColumn maKhachHang;
        private DevExpress.XtraGrid.Columns.GridColumn tenKhachHang;
        private DevExpress.XtraGrid.Columns.GridColumn tenDangNhap;
        private DevExpress.XtraGrid.Columns.GridColumn matKhau;
        private DevExpress.XtraGrid.Columns.GridColumn maSoThe;
        private DevExpress.XtraGrid.Columns.GridColumn diaChi;
        private DevExpress.XtraGrid.Columns.GridColumn mieuTaKhachHang;
        private System.Windows.Forms.ComboBox cbCardCustomer;
        private System.Windows.Forms.Label label1;
    }
}
