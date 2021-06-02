
namespace LoginWF.SalesReport
{
    partial class UcSelectSalesReport
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pieChart1 = new LiveCharts.WinForms.PieChart();
            this.gDoanhThu = new DevExpress.XtraGrid.GridControl();
            this.gvDoanhThu = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaThang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenThang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoTien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GhiChu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gDoanhThu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDoanhThu)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.gDoanhThu, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1354, 530);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pieChart1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(671, 524);
            this.panel1.TabIndex = 0;
            // 
            // pieChart1
            // 
            this.pieChart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pieChart1.Location = new System.Drawing.Point(0, 0);
            this.pieChart1.Name = "pieChart1";
            this.pieChart1.Size = new System.Drawing.Size(671, 524);
            this.pieChart1.TabIndex = 0;
            this.pieChart1.Text = "pieChart1";
            // 
            // gDoanhThu
            // 
            this.gDoanhThu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gDoanhThu.Location = new System.Drawing.Point(680, 3);
            this.gDoanhThu.MainView = this.gvDoanhThu;
            this.gDoanhThu.Name = "gDoanhThu";
            this.gDoanhThu.Size = new System.Drawing.Size(671, 524);
            this.gDoanhThu.TabIndex = 1;
            this.gDoanhThu.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDoanhThu});
            this.gDoanhThu.Click += new System.EventHandler(this.gDoanhThu_Click);
            // 
            // gvDoanhThu
            // 
            this.gvDoanhThu.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaThang,
            this.TenThang,
            this.SoTien,
            this.GhiChu});
            this.gvDoanhThu.GridControl = this.gDoanhThu;
            this.gvDoanhThu.Name = "gvDoanhThu";
            this.gvDoanhThu.OptionsView.ShowFooter = true;
            this.gvDoanhThu.OptionsView.ShowGroupPanel = false;
            // 
            // MaThang
            // 
            this.MaThang.Caption = "Mã Doanh Thu";
            this.MaThang.FieldName = "MaThang";
            this.MaThang.Name = "MaThang";
            this.MaThang.Visible = true;
            this.MaThang.VisibleIndex = 0;
            // 
            // TenThang
            // 
            this.TenThang.Caption = "Tên Tháng";
            this.TenThang.FieldName = "TenThang";
            this.TenThang.Name = "TenThang";
            this.TenThang.Visible = true;
            this.TenThang.VisibleIndex = 1;
            // 
            // SoTien
            // 
            this.SoTien.Caption = "Số Tiền";
            this.SoTien.FieldName = "SoTien";
            this.SoTien.Name = "SoTien";
            this.SoTien.Visible = true;
            this.SoTien.VisibleIndex = 2;
            // 
            // GhiChu
            // 
            this.GhiChu.Caption = "Ghi Chú";
            this.GhiChu.FieldName = "GhiChu";
            this.GhiChu.Name = "GhiChu";
            this.GhiChu.Visible = true;
            this.GhiChu.VisibleIndex = 3;
            // 
            // UcSelectSalesReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UcSelectSalesReport";
            this.Size = new System.Drawing.Size(1354, 530);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gDoanhThu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDoanhThu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private LiveCharts.WinForms.PieChart pieChart1;
        private DevExpress.XtraGrid.GridControl gDoanhThu;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDoanhThu;
        private DevExpress.XtraGrid.Columns.GridColumn MaThang;
        private DevExpress.XtraGrid.Columns.GridColumn TenThang;
        private DevExpress.XtraGrid.Columns.GridColumn SoTien;
        private DevExpress.XtraGrid.Columns.GridColumn GhiChu;
    }
}
