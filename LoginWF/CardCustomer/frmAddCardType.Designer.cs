
namespace LoginWF.CardCustomer
{
    partial class frmAddCardType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddCardType));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescribeCardType = new System.Windows.Forms.TextBox();
            this.txtNameCardType = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtIdCardType = new System.Windows.Forms.NumericUpDown();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.btnAccess = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdCardType)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã loại thẻ: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên loại thẻ: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 96);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Miêu tả loại thẻ: ";
            // 
            // txtDescribeCardType
            // 
            this.txtDescribeCardType.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescribeCardType.Location = new System.Drawing.Point(145, 91);
            this.txtDescribeCardType.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescribeCardType.Multiline = true;
            this.txtDescribeCardType.Name = "txtDescribeCardType";
            this.txtDescribeCardType.Size = new System.Drawing.Size(288, 105);
            this.txtDescribeCardType.TabIndex = 4;
            // 
            // txtNameCardType
            // 
            this.txtNameCardType.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameCardType.Location = new System.Drawing.Point(145, 47);
            this.txtNameCardType.Margin = new System.Windows.Forms.Padding(4);
            this.txtNameCardType.Name = "txtNameCardType";
            this.txtNameCardType.Size = new System.Drawing.Size(288, 28);
            this.txtNameCardType.TabIndex = 5;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // txtIdCardType
            // 
            this.txtIdCardType.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdCardType.Location = new System.Drawing.Point(145, 8);
            this.txtIdCardType.Name = "txtIdCardType";
            this.txtIdCardType.Size = new System.Drawing.Size(288, 28);
            this.txtIdCardType.TabIndex = 8;
            // 
            // btnExit
            // 
            this.btnExit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.ImageOptions.Image")));
            this.btnExit.Location = new System.Drawing.Point(291, 225);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(142, 54);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Thoát";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAccess
            // 
            this.btnAccess.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAccess.ImageOptions.Image")));
            this.btnAccess.Location = new System.Drawing.Point(143, 225);
            this.btnAccess.Name = "btnAccess";
            this.btnAccess.Size = new System.Drawing.Size(142, 54);
            this.btnAccess.TabIndex = 6;
            this.btnAccess.Text = "Đồng ý";
            this.btnAccess.Click += new System.EventHandler(this.btnAccess_Click);
            // 
            // frmAddCardType
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 291);
            this.Controls.Add(this.txtIdCardType);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAccess);
            this.Controls.Add(this.txtNameCardType);
            this.Controls.Add(this.txtDescribeCardType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAddCardType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thêm/Sửa loại thẻ";
            this.Load += new System.EventHandler(this.frmAddCardType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdCardType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescribeCardType;
        private System.Windows.Forms.TextBox txtNameCardType;
        private DevExpress.XtraEditors.SimpleButton btnAccess;
        private DevExpress.XtraEditors.SimpleButton btnExit;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.NumericUpDown txtIdCardType;
    }
}