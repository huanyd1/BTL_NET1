namespace LoginWF.CardCustomer
{
    partial class UcSelectCadCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcSelectCadCustomer));
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.grbCardCustumer = new System.Windows.Forms.GroupBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.gCardCustomer = new DevExpress.XtraGrid.GridControl();
            this.gvCardCustomer = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.maSoThe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tenThe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.maLoaiTheFRK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cbCardType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDeleteCustomerCard = new DevExpress.XtraEditors.SimpleButton();
            this.btnEditCustomerCard = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddCustomerCard = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.gCardType = new DevExpress.XtraGrid.GridControl();
            this.gvCardType = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.maLoaiThe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tenLoaiThe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.mieuTaLoaiThe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDeleteCardType = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddCardType = new DevExpress.XtraEditors.SimpleButton();
            this.btnEditCardType = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.grbCardCustumer.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gCardCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCardCustomer)).BeginInit();
            this.panel5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gCardType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCardType)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridView1
            // 
            this.gridView1.Name = "gridView1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.grbCardCustumer, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1354, 530);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // grbCardCustumer
            // 
            this.grbCardCustumer.Controls.Add(this.panel6);
            this.grbCardCustumer.Controls.Add(this.panel5);
            this.grbCardCustumer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbCardCustumer.Location = new System.Drawing.Point(680, 3);
            this.grbCardCustumer.Name = "grbCardCustumer";
            this.grbCardCustumer.Size = new System.Drawing.Size(671, 524);
            this.grbCardCustumer.TabIndex = 4;
            this.grbCardCustumer.TabStop = false;
            this.grbCardCustumer.Text = "Thẻ khách hàng";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.gCardCustomer);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(3, 119);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(665, 402);
            this.panel6.TabIndex = 3;
            // 
            // gCardCustomer
            // 
            this.gCardCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gCardCustomer.Location = new System.Drawing.Point(0, 0);
            this.gCardCustomer.MainView = this.gvCardCustomer;
            this.gCardCustomer.Name = "gCardCustomer";
            this.gCardCustomer.Size = new System.Drawing.Size(665, 402);
            this.gCardCustomer.TabIndex = 10;
            this.gCardCustomer.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCardCustomer});
            // 
            // gvCardCustomer
            // 
            this.gvCardCustomer.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.maSoThe,
            this.tenThe,
            this.maLoaiTheFRK});
            this.gvCardCustomer.GridControl = this.gCardCustomer;
            this.gvCardCustomer.Name = "gvCardCustomer";
            this.gvCardCustomer.OptionsFind.AlwaysVisible = true;
            this.gvCardCustomer.OptionsFind.FindNullPrompt = "Nhập từ khóa để tìm kiếm...";
            this.gvCardCustomer.OptionsFind.ShowClearButton = false;
            this.gvCardCustomer.OptionsFind.ShowCloseButton = false;
            this.gvCardCustomer.OptionsFind.ShowFindButton = false;
            this.gvCardCustomer.OptionsView.ShowGroupPanel = false;
            // 
            // maSoThe
            // 
            this.maSoThe.Caption = "Mã Số Thẻ";
            this.maSoThe.FieldName = "maSoThe";
            this.maSoThe.Name = "maSoThe";
            this.maSoThe.Visible = true;
            this.maSoThe.VisibleIndex = 0;
            // 
            // tenThe
            // 
            this.tenThe.Caption = "Tên Thẻ";
            this.tenThe.FieldName = "tenThe";
            this.tenThe.Name = "tenThe";
            this.tenThe.Visible = true;
            this.tenThe.VisibleIndex = 1;
            // 
            // maLoaiTheFRK
            // 
            this.maLoaiTheFRK.Caption = "Mã Loại Thẻ";
            this.maLoaiTheFRK.FieldName = "maLoaiThe";
            this.maLoaiTheFRK.Name = "maLoaiTheFRK";
            this.maLoaiTheFRK.Visible = true;
            this.maLoaiTheFRK.VisibleIndex = 2;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.cbCardType);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.btnDeleteCustomerCard);
            this.panel5.Controls.Add(this.btnEditCustomerCard);
            this.panel5.Controls.Add(this.btnAddCustomerCard);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(3, 19);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(665, 100);
            this.panel5.TabIndex = 2;
            // 
            // cbCardType
            // 
            this.cbCardType.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCardType.FormattingEnabled = true;
            this.cbCardType.Location = new System.Drawing.Point(144, 61);
            this.cbCardType.Name = "cbCardType";
            this.cbCardType.Size = new System.Drawing.Size(324, 26);
            this.cbCardType.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 18);
            this.label1.TabIndex = 16;
            this.label1.Text = "Lựa chọn loại thẻ: ";
            // 
            // btnDeleteCustomerCard
            // 
            this.btnDeleteCustomerCard.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteCustomerCard.ImageOptions.Image")));
            this.btnDeleteCustomerCard.Location = new System.Drawing.Point(318, 5);
            this.btnDeleteCustomerCard.Name = "btnDeleteCustomerCard";
            this.btnDeleteCustomerCard.Size = new System.Drawing.Size(150, 50);
            this.btnDeleteCustomerCard.TabIndex = 15;
            this.btnDeleteCustomerCard.Text = "Xóa";
            this.btnDeleteCustomerCard.Click += new System.EventHandler(this.btnDeleteCustomerCard_Click);
            // 
            // btnEditCustomerCard
            // 
            this.btnEditCustomerCard.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEditCustomerCard.ImageOptions.Image")));
            this.btnEditCustomerCard.Location = new System.Drawing.Point(162, 5);
            this.btnEditCustomerCard.Name = "btnEditCustomerCard";
            this.btnEditCustomerCard.Size = new System.Drawing.Size(150, 50);
            this.btnEditCustomerCard.TabIndex = 14;
            this.btnEditCustomerCard.Text = "Sửa";
            this.btnEditCustomerCard.Click += new System.EventHandler(this.btnEditCustomerCard_Click);
            // 
            // btnAddCustomerCard
            // 
            this.btnAddCustomerCard.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAddCustomerCard.ImageOptions.Image")));
            this.btnAddCustomerCard.Location = new System.Drawing.Point(6, 5);
            this.btnAddCustomerCard.Name = "btnAddCustomerCard";
            this.btnAddCustomerCard.Size = new System.Drawing.Size(150, 50);
            this.btnAddCustomerCard.TabIndex = 13;
            this.btnAddCustomerCard.Text = "Thêm";
            this.btnAddCustomerCard.Click += new System.EventHandler(this.btnAddCustomerCard_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(671, 524);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Loại thẻ";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.gCardType);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 79);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(665, 442);
            this.panel4.TabIndex = 1;
            // 
            // gCardType
            // 
            this.gCardType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gCardType.Location = new System.Drawing.Point(0, 0);
            this.gCardType.MainView = this.gvCardType;
            this.gCardType.Name = "gCardType";
            this.gCardType.Size = new System.Drawing.Size(665, 442);
            this.gCardType.TabIndex = 9;
            this.gCardType.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCardType});
            this.gCardType.Load += new System.EventHandler(this.gCardCustomer_Load);
            // 
            // gvCardType
            // 
            this.gvCardType.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.maLoaiThe,
            this.tenLoaiThe,
            this.mieuTaLoaiThe});
            this.gvCardType.GridControl = this.gCardType;
            this.gvCardType.Name = "gvCardType";
            this.gvCardType.OptionsBehavior.ReadOnly = true;
            this.gvCardType.OptionsFind.AlwaysVisible = true;
            this.gvCardType.OptionsFind.FindNullPrompt = "Nhập từ khóa để tìm kiếm...";
            this.gvCardType.OptionsFind.ShowClearButton = false;
            this.gvCardType.OptionsFind.ShowCloseButton = false;
            this.gvCardType.OptionsFind.ShowFindButton = false;
            this.gvCardType.OptionsView.ShowGroupPanel = false;
            this.gvCardType.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvCardType_FocusedRowChanged);
            // 
            // maLoaiThe
            // 
            this.maLoaiThe.Caption = "Mã Loại Thẻ";
            this.maLoaiThe.FieldName = "maLoaiThe";
            this.maLoaiThe.Name = "maLoaiThe";
            this.maLoaiThe.Visible = true;
            this.maLoaiThe.VisibleIndex = 0;
            // 
            // tenLoaiThe
            // 
            this.tenLoaiThe.Caption = "Tên Loại Thẻ";
            this.tenLoaiThe.FieldName = "tenLoaiThe";
            this.tenLoaiThe.Name = "tenLoaiThe";
            this.tenLoaiThe.Visible = true;
            this.tenLoaiThe.VisibleIndex = 1;
            // 
            // mieuTaLoaiThe
            // 
            this.mieuTaLoaiThe.Caption = "Miêu Tả";
            this.mieuTaLoaiThe.FieldName = "mieuTaLoaiThe";
            this.mieuTaLoaiThe.Name = "mieuTaLoaiThe";
            this.mieuTaLoaiThe.Visible = true;
            this.mieuTaLoaiThe.VisibleIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDeleteCardType);
            this.panel1.Controls.Add(this.btnAddCardType);
            this.panel1.Controls.Add(this.btnEditCardType);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(665, 60);
            this.panel1.TabIndex = 0;
            // 
            // btnDeleteCardType
            // 
            this.btnDeleteCardType.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteCardType.ImageOptions.Image")));
            this.btnDeleteCardType.Location = new System.Drawing.Point(319, 3);
            this.btnDeleteCardType.Name = "btnDeleteCardType";
            this.btnDeleteCardType.Size = new System.Drawing.Size(150, 50);
            this.btnDeleteCardType.TabIndex = 12;
            this.btnDeleteCardType.Text = "Xóa";
            this.btnDeleteCardType.Click += new System.EventHandler(this.btnDeleteCardType_Click);
            // 
            // btnAddCardType
            // 
            this.btnAddCardType.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAddCardType.ImageOptions.Image")));
            this.btnAddCardType.Location = new System.Drawing.Point(7, 3);
            this.btnAddCardType.Name = "btnAddCardType";
            this.btnAddCardType.Size = new System.Drawing.Size(150, 50);
            this.btnAddCardType.TabIndex = 10;
            this.btnAddCardType.Text = "Thêm";
            this.btnAddCardType.Click += new System.EventHandler(this.btnAddCardType_Click);
            // 
            // btnEditCardType
            // 
            this.btnEditCardType.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEditCardType.ImageOptions.Image")));
            this.btnEditCardType.Location = new System.Drawing.Point(163, 3);
            this.btnEditCardType.Name = "btnEditCardType";
            this.btnEditCardType.Size = new System.Drawing.Size(150, 50);
            this.btnEditCardType.TabIndex = 11;
            this.btnEditCardType.Text = "Sửa";
            this.btnEditCardType.Click += new System.EventHandler(this.btnEditCardType_Click);
            // 
            // UcSelectCadCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UcSelectCadCustomer";
            this.Size = new System.Drawing.Size(1354, 530);
            this.Load += new System.EventHandler(this.UcSelectCadCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.grbCardCustumer.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gCardCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCardCustomer)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gCardType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCardType)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraGrid.GridControl gCardType;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCardType;
        private DevExpress.XtraGrid.Columns.GridColumn maLoaiThe;
        private DevExpress.XtraGrid.Columns.GridColumn tenLoaiThe;
        private DevExpress.XtraGrid.Columns.GridColumn mieuTaLoaiThe;
        private DevExpress.XtraEditors.SimpleButton btnDeleteCardType;
        private DevExpress.XtraEditors.SimpleButton btnEditCardType;
        private DevExpress.XtraEditors.SimpleButton btnAddCardType;
        private System.Windows.Forms.GroupBox grbCardCustumer;
        private System.Windows.Forms.Panel panel6;
        private DevExpress.XtraGrid.GridControl gCardCustomer;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCardCustomer;
        private DevExpress.XtraGrid.Columns.GridColumn maSoThe;
        private DevExpress.XtraGrid.Columns.GridColumn tenThe;
        private DevExpress.XtraGrid.Columns.GridColumn maLoaiTheFRK;
        private System.Windows.Forms.Panel panel5;
        private DevExpress.XtraEditors.SimpleButton btnDeleteCustomerCard;
        private DevExpress.XtraEditors.SimpleButton btnEditCustomerCard;
        private DevExpress.XtraEditors.SimpleButton btnAddCustomerCard;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbCardType;
        private System.Windows.Forms.Label label1;
    }
}
