
namespace LoginWF.CardCustomer
{
    partial class frmAddCardCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddCardCustomer));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.btnAccess = new DevExpress.XtraEditors.SimpleButton();
            this.txtIdCardCustomer = new System.Windows.Forms.NumericUpDown();
            this.txtNameCardCustomer = new System.Windows.Forms.TextBox();
            this.txtIdCardType = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.txtIdCardCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã số thẻ: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên thẻ: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên loại thẻ: ";
            // 
            // btnExit
            // 
            this.btnExit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.ImageOptions.Image")));
            this.btnExit.Location = new System.Drawing.Point(299, 225);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(142, 54);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Thoát";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAccess
            // 
            this.btnAccess.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAccess.ImageOptions.Image")));
            this.btnAccess.Location = new System.Drawing.Point(151, 225);
            this.btnAccess.Name = "btnAccess";
            this.btnAccess.Size = new System.Drawing.Size(142, 54);
            this.btnAccess.TabIndex = 8;
            this.btnAccess.Text = "Đồng ý";
            this.btnAccess.Click += new System.EventHandler(this.btnAccess_Click);
            // 
            // txtIdCardCustomer
            // 
            this.txtIdCardCustomer.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdCardCustomer.Location = new System.Drawing.Point(153, 7);
            this.txtIdCardCustomer.Name = "txtIdCardCustomer";
            this.txtIdCardCustomer.Size = new System.Drawing.Size(288, 27);
            this.txtIdCardCustomer.TabIndex = 10;
            // 
            // txtNameCardCustomer
            // 
            this.txtNameCardCustomer.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameCardCustomer.Location = new System.Drawing.Point(153, 49);
            this.txtNameCardCustomer.Name = "txtNameCardCustomer";
            this.txtNameCardCustomer.Size = new System.Drawing.Size(288, 27);
            this.txtNameCardCustomer.TabIndex = 11;
            // 
            // txtIdCardType
            // 
            this.txtIdCardType.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdCardType.Location = new System.Drawing.Point(153, 90);
            this.txtIdCardType.Multiline = true;
            this.txtIdCardType.Name = "txtIdCardType";
            this.txtIdCardType.Size = new System.Drawing.Size(288, 105);
            this.txtIdCardType.TabIndex = 12;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // frmAddCardCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 291);
            this.Controls.Add(this.txtIdCardType);
            this.Controls.Add(this.txtNameCardCustomer);
            this.Controls.Add(this.txtIdCardCustomer);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAccess);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmAddCardCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thêm/Sửa thẻ khách hàng";
            this.Load += new System.EventHandler(this.frmAddCardCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtIdCardCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SimpleButton btnExit;
        private DevExpress.XtraEditors.SimpleButton btnAccess;
        private System.Windows.Forms.NumericUpDown txtIdCardCustomer;
        private System.Windows.Forms.TextBox txtNameCardCustomer;
        private System.Windows.Forms.TextBox txtIdCardType;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}