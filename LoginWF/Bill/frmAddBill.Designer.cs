
namespace LoginWF.Bill
{
    partial class frmAddBill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddBill));
            this.txtMoney = new System.Windows.Forms.TextBox();
            this.txtDescribeBill = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtIdBill = new System.Windows.Forms.NumericUpDown();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.btnAccess = new DevExpress.XtraEditors.SimpleButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIdBookRoom = new System.Windows.Forms.NumericUpDown();
            this.dtimeDateOfPayment = new System.Windows.Forms.DateTimePicker();
            this.txtIdPaymentType = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdBill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdBookRoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdPaymentType)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMoney
            // 
            this.txtMoney.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMoney.Location = new System.Drawing.Point(217, 146);
            this.txtMoney.Margin = new System.Windows.Forms.Padding(4);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.Size = new System.Drawing.Size(288, 28);
            this.txtMoney.TabIndex = 21;
            // 
            // txtDescribeBill
            // 
            this.txtDescribeBill.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescribeBill.Location = new System.Drawing.Point(215, 241);
            this.txtDescribeBill.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescribeBill.Multiline = true;
            this.txtDescribeBill.Name = "txtDescribeBill";
            this.txtDescribeBill.Size = new System.Drawing.Size(288, 105);
            this.txtDescribeBill.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 98);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 19);
            this.label3.TabIndex = 19;
            this.label3.Text = "Ngày thanh toán :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 19);
            this.label2.TabIndex = 18;
            this.label2.Text = "Mã đặt phòng :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 19);
            this.label1.TabIndex = 17;
            this.label1.Text = "Mã hóa đơn : ";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // txtIdBill
            // 
            this.txtIdBill.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdBill.Location = new System.Drawing.Point(217, 7);
            this.txtIdBill.Name = "txtIdBill";
            this.txtIdBill.Size = new System.Drawing.Size(288, 28);
            this.txtIdBill.TabIndex = 24;
            // 
            // btnExit
            // 
            this.btnExit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.ImageOptions.Image")));
            this.btnExit.Location = new System.Drawing.Point(361, 366);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(142, 54);
            this.btnExit.TabIndex = 23;
            this.btnExit.Text = "Thoát";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAccess
            // 
            this.btnAccess.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAccess.ImageOptions.Image")));
            this.btnAccess.Location = new System.Drawing.Point(204, 366);
            this.btnAccess.Name = "btnAccess";
            this.btnAccess.Size = new System.Drawing.Size(142, 54);
            this.btnAccess.TabIndex = 22;
            this.btnAccess.Text = "Đồng ý";
            this.btnAccess.Click += new System.EventHandler(this.btnAccess_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 146);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 19);
            this.label4.TabIndex = 25;
            this.label4.Text = "Số tiền :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 190);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 19);
            this.label5.TabIndex = 26;
            this.label5.Text = "Mã kiểu thanh toán :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 241);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 19);
            this.label6.TabIndex = 27;
            this.label6.Text = "Ghi chú :";
            // 
            // txtIdBookRoom
            // 
            this.txtIdBookRoom.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdBookRoom.Location = new System.Drawing.Point(217, 51);
            this.txtIdBookRoom.Name = "txtIdBookRoom";
            this.txtIdBookRoom.Size = new System.Drawing.Size(288, 28);
            this.txtIdBookRoom.TabIndex = 28;
            // 
            // dtimeDateOfPayment
            // 
            this.dtimeDateOfPayment.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtimeDateOfPayment.Location = new System.Drawing.Point(217, 98);
            this.dtimeDateOfPayment.Name = "dtimeDateOfPayment";
            this.dtimeDateOfPayment.Size = new System.Drawing.Size(286, 28);
            this.dtimeDateOfPayment.TabIndex = 29;
            // 
            // txtIdPaymentType
            // 
            this.txtIdPaymentType.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdPaymentType.Location = new System.Drawing.Point(215, 190);
            this.txtIdPaymentType.Name = "txtIdPaymentType";
            this.txtIdPaymentType.Size = new System.Drawing.Size(288, 28);
            this.txtIdPaymentType.TabIndex = 30;
            // 
            // frmAddBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 428);
            this.Controls.Add(this.txtIdPaymentType);
            this.Controls.Add(this.dtimeDateOfPayment);
            this.Controls.Add(this.txtIdBookRoom);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMoney);
            this.Controls.Add(this.txtDescribeBill);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIdBill);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAccess);
            this.Name = "frmAddBill";
            this.Text = "frmAddBill";
            this.Load += new System.EventHandler(this.frmAddBill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdBill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdBookRoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdPaymentType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMoney;
        private System.Windows.Forms.TextBox txtDescribeBill;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.NumericUpDown txtIdBill;
        private DevExpress.XtraEditors.SimpleButton btnExit;
        private DevExpress.XtraEditors.SimpleButton btnAccess;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown txtIdPaymentType;
        private System.Windows.Forms.DateTimePicker dtimeDateOfPayment;
        private System.Windows.Forms.NumericUpDown txtIdBookRoom;
    }
}