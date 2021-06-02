
namespace LoginWF.ListRoom
{
    partial class UcSelectListRoom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcSelectListRoom));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gListRoom = new DevExpress.XtraGrid.GridControl();
            this.gvListRoom = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.maPhong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tenPhong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.loaiPhong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.maKhachSan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.mieuTaPhong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tinhTrangPhong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.giaPhong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDeleteListRoom = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddListRoom = new DevExpress.XtraEditors.SimpleButton();
            this.btnEditListRoom = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gBookRoom = new DevExpress.XtraGrid.GridControl();
            this.gvBookRoom = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.maDatPhong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.maKhachHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.maPhongFRK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ngayBatDau = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ngayKetThuc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.mieuTaDatPhong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbCustomer = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDeleteBookRoom = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddBookRoom = new DevExpress.XtraEditors.SimpleButton();
            this.btnEditBookRoom = new DevExpress.XtraEditors.SimpleButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gListRoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvListRoom)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gBookRoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBookRoom)).BeginInit();
            this.panel2.SuspendLayout();
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
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1354, 530);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gListRoom);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(671, 526);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách phòng";
            // 
            // gListRoom
            // 
            this.gListRoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gListRoom.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gListRoom.Location = new System.Drawing.Point(3, 78);
            this.gListRoom.MainView = this.gvListRoom;
            this.gListRoom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gListRoom.Name = "gListRoom";
            this.gListRoom.Size = new System.Drawing.Size(665, 446);
            this.gListRoom.TabIndex = 10;
            this.gListRoom.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvListRoom});
            // 
            // gvListRoom
            // 
            this.gvListRoom.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.maPhong,
            this.tenPhong,
            this.loaiPhong,
            this.maKhachSan,
            this.mieuTaPhong,
            this.tinhTrangPhong,
            this.giaPhong});
            this.gvListRoom.GridControl = this.gListRoom;
            this.gvListRoom.Name = "gvListRoom";
            this.gvListRoom.OptionsBehavior.ReadOnly = true;
            this.gvListRoom.OptionsFind.AlwaysVisible = true;
            this.gvListRoom.OptionsFind.FindNullPrompt = "Nhập từ khóa để tìm kiếm...";
            this.gvListRoom.OptionsFind.ShowClearButton = false;
            this.gvListRoom.OptionsFind.ShowCloseButton = false;
            this.gvListRoom.OptionsFind.ShowFindButton = false;
            this.gvListRoom.OptionsView.ShowGroupPanel = false;
            // 
            // maPhong
            // 
            this.maPhong.Caption = "Mã Phòng";
            this.maPhong.FieldName = "maPhong";
            this.maPhong.Name = "maPhong";
            this.maPhong.Visible = true;
            this.maPhong.VisibleIndex = 0;
            // 
            // tenPhong
            // 
            this.tenPhong.Caption = "Tên Phòng";
            this.tenPhong.FieldName = "tenPhong";
            this.tenPhong.Name = "tenPhong";
            this.tenPhong.Visible = true;
            this.tenPhong.VisibleIndex = 1;
            // 
            // loaiPhong
            // 
            this.loaiPhong.Caption = "Loại Phòng";
            this.loaiPhong.FieldName = "loaiPhong";
            this.loaiPhong.Name = "loaiPhong";
            this.loaiPhong.Visible = true;
            this.loaiPhong.VisibleIndex = 2;
            // 
            // maKhachSan
            // 
            this.maKhachSan.Caption = "Mã Khách Sạn";
            this.maKhachSan.FieldName = "maKhachSan";
            this.maKhachSan.Name = "maKhachSan";
            this.maKhachSan.Visible = true;
            this.maKhachSan.VisibleIndex = 3;
            // 
            // mieuTaPhong
            // 
            this.mieuTaPhong.Caption = "Miêu Tả Phòng";
            this.mieuTaPhong.FieldName = "mieuTaPhong";
            this.mieuTaPhong.Name = "mieuTaPhong";
            this.mieuTaPhong.Visible = true;
            this.mieuTaPhong.VisibleIndex = 4;
            // 
            // tinhTrangPhong
            // 
            this.tinhTrangPhong.Caption = "Tình Trạng Phòng";
            this.tinhTrangPhong.FieldName = "tinhTrangPhong";
            this.tinhTrangPhong.Name = "tinhTrangPhong";
            this.tinhTrangPhong.Visible = true;
            this.tinhTrangPhong.VisibleIndex = 5;
            // 
            // giaPhong
            // 
            this.giaPhong.Caption = "Giá Phòng";
            this.giaPhong.FieldName = "giaPhong";
            this.giaPhong.Name = "giaPhong";
            this.giaPhong.Visible = true;
            this.giaPhong.VisibleIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDeleteListRoom);
            this.panel1.Controls.Add(this.btnAddListRoom);
            this.panel1.Controls.Add(this.btnEditListRoom);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 18);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(665, 60);
            this.panel1.TabIndex = 0;
            // 
            // btnDeleteListRoom
            // 
            this.btnDeleteListRoom.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteListRoom.ImageOptions.Image")));
            this.btnDeleteListRoom.Location = new System.Drawing.Point(318, 5);
            this.btnDeleteListRoom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteListRoom.Name = "btnDeleteListRoom";
            this.btnDeleteListRoom.Size = new System.Drawing.Size(150, 50);
            this.btnDeleteListRoom.TabIndex = 15;
            this.btnDeleteListRoom.Text = "Xóa";
            this.btnDeleteListRoom.Click += new System.EventHandler(this.btnDeleteListRoom_Click);
            // 
            // btnAddListRoom
            // 
            this.btnAddListRoom.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAddListRoom.ImageOptions.Image")));
            this.btnAddListRoom.Location = new System.Drawing.Point(7, 5);
            this.btnAddListRoom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddListRoom.Name = "btnAddListRoom";
            this.btnAddListRoom.Size = new System.Drawing.Size(150, 50);
            this.btnAddListRoom.TabIndex = 13;
            this.btnAddListRoom.Text = "Thêm";
            this.btnAddListRoom.Click += new System.EventHandler(this.btnAddListRoom_Click);
            // 
            // btnEditListRoom
            // 
            this.btnEditListRoom.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEditListRoom.ImageOptions.Image")));
            this.btnEditListRoom.Location = new System.Drawing.Point(163, 5);
            this.btnEditListRoom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditListRoom.Name = "btnEditListRoom";
            this.btnEditListRoom.Size = new System.Drawing.Size(150, 50);
            this.btnEditListRoom.TabIndex = 14;
            this.btnEditListRoom.Text = "Sửa";
            this.btnEditListRoom.Click += new System.EventHandler(this.btnEditListRoom_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gBookRoom);
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(680, 2);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(671, 526);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Đặt phòng";
            // 
            // gBookRoom
            // 
            this.gBookRoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gBookRoom.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gBookRoom.Location = new System.Drawing.Point(3, 114);
            this.gBookRoom.MainView = this.gvBookRoom;
            this.gBookRoom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gBookRoom.Name = "gBookRoom";
            this.gBookRoom.Size = new System.Drawing.Size(665, 410);
            this.gBookRoom.TabIndex = 11;
            this.gBookRoom.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvBookRoom});
            // 
            // gvBookRoom
            // 
            this.gvBookRoom.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.maDatPhong,
            this.maKhachHang,
            this.maPhongFRK,
            this.ngayBatDau,
            this.ngayKetThuc,
            this.gia,
            this.mieuTaDatPhong});
            this.gvBookRoom.GridControl = this.gBookRoom;
            this.gvBookRoom.Name = "gvBookRoom";
            this.gvBookRoom.OptionsBehavior.ReadOnly = true;
            this.gvBookRoom.OptionsFind.AlwaysVisible = true;
            this.gvBookRoom.OptionsFind.FindNullPrompt = "Nhập từ khóa để tìm kiếm...";
            this.gvBookRoom.OptionsFind.ShowClearButton = false;
            this.gvBookRoom.OptionsFind.ShowCloseButton = false;
            this.gvBookRoom.OptionsFind.ShowFindButton = false;
            this.gvBookRoom.OptionsView.ShowGroupPanel = false;
            // 
            // maDatPhong
            // 
            this.maDatPhong.Caption = "Mã Đặt Phòng";
            this.maDatPhong.FieldName = "maDatPhong";
            this.maDatPhong.Name = "maDatPhong";
            this.maDatPhong.Visible = true;
            this.maDatPhong.VisibleIndex = 0;
            // 
            // maKhachHang
            // 
            this.maKhachHang.Caption = "Mã Khách Hàng";
            this.maKhachHang.FieldName = "maKhachHang";
            this.maKhachHang.Name = "maKhachHang";
            this.maKhachHang.Visible = true;
            this.maKhachHang.VisibleIndex = 1;
            // 
            // maPhongFRK
            // 
            this.maPhongFRK.Caption = "Mã Phòng";
            this.maPhongFRK.FieldName = "maPhong";
            this.maPhongFRK.Name = "maPhongFRK";
            this.maPhongFRK.Visible = true;
            this.maPhongFRK.VisibleIndex = 2;
            // 
            // ngayBatDau
            // 
            this.ngayBatDau.Caption = "Ngày Bắt Đầu";
            this.ngayBatDau.FieldName = "ngayBatDau";
            this.ngayBatDau.Name = "ngayBatDau";
            this.ngayBatDau.Visible = true;
            this.ngayBatDau.VisibleIndex = 3;
            // 
            // ngayKetThuc
            // 
            this.ngayKetThuc.Caption = "Ngày Kết Thúc";
            this.ngayKetThuc.FieldName = "ngayKetThuc";
            this.ngayKetThuc.Name = "ngayKetThuc";
            this.ngayKetThuc.Visible = true;
            this.ngayKetThuc.VisibleIndex = 4;
            // 
            // gia
            // 
            this.gia.Caption = "Giá";
            this.gia.FieldName = "gia";
            this.gia.Name = "gia";
            this.gia.Visible = true;
            this.gia.VisibleIndex = 5;
            // 
            // mieuTaDatPhong
            // 
            this.mieuTaDatPhong.Caption = "Miêu Tả Đặt Phòng";
            this.mieuTaDatPhong.FieldName = "mieuTaDatPhong";
            this.mieuTaDatPhong.Name = "mieuTaDatPhong";
            this.mieuTaDatPhong.Visible = true;
            this.mieuTaDatPhong.VisibleIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbCustomer);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnDeleteBookRoom);
            this.panel2.Controls.Add(this.btnAddBookRoom);
            this.panel2.Controls.Add(this.btnEditBookRoom);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 18);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(665, 96);
            this.panel2.TabIndex = 1;
            // 
            // cbCustomer
            // 
            this.cbCustomer.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCustomer.FormattingEnabled = true;
            this.cbCustomer.Location = new System.Drawing.Point(187, 64);
            this.cbCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbCustomer.Name = "cbCustomer";
            this.cbCustomer.Size = new System.Drawing.Size(282, 26);
            this.cbCustomer.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 18);
            this.label1.TabIndex = 32;
            this.label1.Text = "Lựa chọn Khách hàng : ";
            // 
            // btnDeleteBookRoom
            // 
            this.btnDeleteBookRoom.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteBookRoom.ImageOptions.Image")));
            this.btnDeleteBookRoom.Location = new System.Drawing.Point(318, 5);
            this.btnDeleteBookRoom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteBookRoom.Name = "btnDeleteBookRoom";
            this.btnDeleteBookRoom.Size = new System.Drawing.Size(150, 50);
            this.btnDeleteBookRoom.TabIndex = 15;
            this.btnDeleteBookRoom.Text = "Xóa";
            this.btnDeleteBookRoom.Click += new System.EventHandler(this.btnDeleteBookRoom_Click);
            // 
            // btnAddBookRoom
            // 
            this.btnAddBookRoom.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAddBookRoom.ImageOptions.Image")));
            this.btnAddBookRoom.Location = new System.Drawing.Point(7, 5);
            this.btnAddBookRoom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddBookRoom.Name = "btnAddBookRoom";
            this.btnAddBookRoom.Size = new System.Drawing.Size(150, 50);
            this.btnAddBookRoom.TabIndex = 13;
            this.btnAddBookRoom.Text = "Thêm";
            this.btnAddBookRoom.Click += new System.EventHandler(this.btnAddBookRoom_Click);
            // 
            // btnEditBookRoom
            // 
            this.btnEditBookRoom.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEditBookRoom.ImageOptions.Image")));
            this.btnEditBookRoom.Location = new System.Drawing.Point(163, 5);
            this.btnEditBookRoom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditBookRoom.Name = "btnEditBookRoom";
            this.btnEditBookRoom.Size = new System.Drawing.Size(150, 50);
            this.btnEditBookRoom.TabIndex = 14;
            this.btnEditBookRoom.Text = "Sửa";
            this.btnEditBookRoom.Click += new System.EventHandler(this.btnEditBookRoom_Click);
            // 
            // UcSelectListRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UcSelectListRoom";
            this.Size = new System.Drawing.Size(1354, 530);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gListRoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvListRoom)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gBookRoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBookRoom)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnDeleteListRoom;
        private DevExpress.XtraEditors.SimpleButton btnAddListRoom;
        private DevExpress.XtraEditors.SimpleButton btnEditListRoom;
        private DevExpress.XtraGrid.GridControl gListRoom;
        private DevExpress.XtraGrid.Views.Grid.GridView gvListRoom;
        private DevExpress.XtraGrid.Columns.GridColumn maPhong;
        private DevExpress.XtraGrid.Columns.GridColumn tenPhong;
        private DevExpress.XtraGrid.Columns.GridColumn loaiPhong;
        private DevExpress.XtraGrid.Columns.GridColumn maKhachSan;
        private DevExpress.XtraGrid.Columns.GridColumn mieuTaPhong;
        private DevExpress.XtraGrid.Columns.GridColumn tinhTrangPhong;
        private DevExpress.XtraGrid.Columns.GridColumn giaPhong;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.SimpleButton btnDeleteBookRoom;
        private DevExpress.XtraEditors.SimpleButton btnAddBookRoom;
        private DevExpress.XtraEditors.SimpleButton btnEditBookRoom;
        private DevExpress.XtraGrid.GridControl gBookRoom;
        private DevExpress.XtraGrid.Views.Grid.GridView gvBookRoom;
        private DevExpress.XtraGrid.Columns.GridColumn maDatPhong;
        private DevExpress.XtraGrid.Columns.GridColumn maKhachHang;
        private DevExpress.XtraGrid.Columns.GridColumn maPhongFRK;
        private DevExpress.XtraGrid.Columns.GridColumn ngayBatDau;
        private DevExpress.XtraGrid.Columns.GridColumn ngayKetThuc;
        private DevExpress.XtraGrid.Columns.GridColumn gia;
        private DevExpress.XtraGrid.Columns.GridColumn mieuTaDatPhong;
        private System.Windows.Forms.ComboBox cbCustomer;
        private System.Windows.Forms.Label label1;
    }
}
