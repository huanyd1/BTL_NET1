
namespace LoginWF.ListRoom
{
    partial class frmAddBookRoom
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddBookRoom));
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtDescribeBookRoom = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.btnAccess = new DevExpress.XtraEditors.SimpleButton();
            this.txtIdCustomer = new System.Windows.Forms.NumericUpDown();
            this.txtIdRoom = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.txtIdBookRoom = new System.Windows.Forms.NumericUpDown();
            this.dtimeStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtimeEndDate = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdRoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdBookRoom)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // txtDescribeBookRoom
            // 
            this.txtDescribeBookRoom.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescribeBookRoom.Location = new System.Drawing.Point(186, 232);
            this.txtDescribeBookRoom.Multiline = true;
            this.txtDescribeBookRoom.Name = "txtDescribeBookRoom";
            this.txtDescribeBookRoom.Size = new System.Drawing.Size(247, 69);
            this.txtDescribeBookRoom.TabIndex = 68;
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(186, 197);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(247, 24);
            this.txtPrice.TabIndex = 56;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 55;
            this.label3.Text = "Ngày bắt đầu :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 54;
            this.label2.Text = "Mã phòng :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 17);
            this.label1.TabIndex = 53;
            this.label1.Text = "Mã khách hàng : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 17);
            this.label5.TabIndex = 61;
            this.label5.Text = "Miêu tả đặt phòng :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 17);
            this.label4.TabIndex = 60;
            this.label4.Text = "Giá :";
            // 
            // btnExit
            // 
            this.btnExit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.ImageOptions.Image")));
            this.btnExit.Location = new System.Drawing.Point(309, 314);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(122, 44);
            this.btnExit.TabIndex = 58;
            this.btnExit.Text = "Thoát";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAccess
            // 
            this.btnAccess.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAccess.ImageOptions.Image")));
            this.btnAccess.Location = new System.Drawing.Point(175, 314);
            this.btnAccess.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAccess.Name = "btnAccess";
            this.btnAccess.Size = new System.Drawing.Size(122, 44);
            this.btnAccess.TabIndex = 57;
            this.btnAccess.Text = "Đồng ý";
            this.btnAccess.Click += new System.EventHandler(this.btnAccess_Click);
            // 
            // txtIdCustomer
            // 
            this.txtIdCustomer.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdCustomer.Location = new System.Drawing.Point(186, 44);
            this.txtIdCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIdCustomer.Name = "txtIdCustomer";
            this.txtIdCustomer.Size = new System.Drawing.Size(247, 24);
            this.txtIdCustomer.TabIndex = 59;
            // 
            // txtIdRoom
            // 
            this.txtIdRoom.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdRoom.Location = new System.Drawing.Point(186, 80);
            this.txtIdRoom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIdRoom.Name = "txtIdRoom";
            this.txtIdRoom.Size = new System.Drawing.Size(247, 24);
            this.txtIdRoom.TabIndex = 69;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(8, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 17);
            this.label8.TabIndex = 70;
            this.label8.Text = "Mã đặt phòng : ";
            // 
            // txtIdBookRoom
            // 
            this.txtIdBookRoom.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdBookRoom.Location = new System.Drawing.Point(186, 8);
            this.txtIdBookRoom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIdBookRoom.Name = "txtIdBookRoom";
            this.txtIdBookRoom.Size = new System.Drawing.Size(247, 24);
            this.txtIdBookRoom.TabIndex = 71;
            // 
            // dtimeStartDate
            // 
            this.dtimeStartDate.CalendarFont = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtimeStartDate.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtimeStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtimeStartDate.Location = new System.Drawing.Point(186, 122);
            this.dtimeStartDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtimeStartDate.Name = "dtimeStartDate";
            this.dtimeStartDate.Size = new System.Drawing.Size(247, 23);
            this.dtimeStartDate.TabIndex = 72;
            // 
            // dtimeEndDate
            // 
            this.dtimeEndDate.CalendarFont = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtimeEndDate.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtimeEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtimeEndDate.Location = new System.Drawing.Point(186, 162);
            this.dtimeEndDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtimeEndDate.Name = "dtimeEndDate";
            this.dtimeEndDate.Size = new System.Drawing.Size(247, 23);
            this.dtimeEndDate.TabIndex = 74;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(8, 162);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 17);
            this.label9.TabIndex = 73;
            this.label9.Text = "Ngày kết thúc :";
            // 
            // frmAddBookRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 370);
            this.Controls.Add(this.dtimeEndDate);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtimeStartDate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtIdBookRoom);
            this.Controls.Add(this.txtIdRoom);
            this.Controls.Add(this.txtDescribeBookRoom);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtIdCustomer);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAccess);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmAddBookRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thêm/Sửa danh sách phòng";
            this.Load += new System.EventHandler(this.frmAddBookRoom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdRoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdBookRoom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.TextBox txtDescribeBookRoom;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.SimpleButton btnExit;
        private DevExpress.XtraEditors.SimpleButton btnAccess;
        private System.Windows.Forms.NumericUpDown txtIdRoom;
        private System.Windows.Forms.NumericUpDown txtIdCustomer;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown txtIdBookRoom;
        private System.Windows.Forms.DateTimePicker dtimeEndDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtimeStartDate;
    }
}