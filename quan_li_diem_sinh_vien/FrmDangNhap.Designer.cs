namespace quan_li_diem_sinh_vien
{
    partial class FrmDangNhap
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
            this.xtraScrollableControlDangNhap = new DevExpress.XtraEditors.XtraScrollableControl();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.cboKhoa = new System.Windows.Forms.ComboBox();
            this.txbMatKhau = new System.Windows.Forms.TextBox();
            this.txbTenDangNhap = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.xtraScrollableControlDangNhap.SuspendLayout();
            this.SuspendLayout();
            // 
            // xtraScrollableControlDangNhap
            // 
            this.xtraScrollableControlDangNhap.Controls.Add(this.btnThoat);
            this.xtraScrollableControlDangNhap.Controls.Add(this.btnDangNhap);
            this.xtraScrollableControlDangNhap.Controls.Add(this.cboKhoa);
            this.xtraScrollableControlDangNhap.Controls.Add(this.txbMatKhau);
            this.xtraScrollableControlDangNhap.Controls.Add(this.txbTenDangNhap);
            this.xtraScrollableControlDangNhap.Controls.Add(this.label3);
            this.xtraScrollableControlDangNhap.Controls.Add(this.label2);
            this.xtraScrollableControlDangNhap.Controls.Add(this.label1);
            this.xtraScrollableControlDangNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraScrollableControlDangNhap.FireScrollEventOnMouseWheel = true;
            this.xtraScrollableControlDangNhap.Location = new System.Drawing.Point(0, 0);
            this.xtraScrollableControlDangNhap.Name = "xtraScrollableControlDangNhap";
            this.xtraScrollableControlDangNhap.Size = new System.Drawing.Size(541, 322);
            this.xtraScrollableControlDangNhap.TabIndex = 1;
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(300, 239);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(163, 34);
            this.btnThoat.TabIndex = 16;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.Location = new System.Drawing.Point(54, 239);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(163, 34);
            this.btnDangNhap.TabIndex = 15;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.UseVisualStyleBackColor = true;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // cboKhoa
            // 
            this.cboKhoa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboKhoa.FormattingEnabled = true;
            this.cboKhoa.ItemHeight = 24;
            this.cboKhoa.Location = new System.Drawing.Point(202, 43);
            this.cboKhoa.Name = "cboKhoa";
            this.cboKhoa.Size = new System.Drawing.Size(261, 32);
            this.cboKhoa.TabIndex = 14;
            this.cboKhoa.SelectedIndexChanged += new System.EventHandler(this.cboKhoa_SelectedIndexChanged);
            // 
            // txbMatKhau
            // 
            this.txbMatKhau.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMatKhau.Location = new System.Drawing.Point(202, 149);
            this.txbMatKhau.Name = "txbMatKhau";
            this.txbMatKhau.PasswordChar = '*';
            this.txbMatKhau.Size = new System.Drawing.Size(261, 29);
            this.txbMatKhau.TabIndex = 13;
            // 
            // txbTenDangNhap
            // 
            this.txbTenDangNhap.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbTenDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTenDangNhap.Location = new System.Drawing.Point(202, 97);
            this.txbTenDangNhap.Name = "txbTenDangNhap";
            this.txbTenDangNhap.Size = new System.Drawing.Size(261, 29);
            this.txbTenDangNhap.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(110, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "Mật khẩu:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tên đăng nhập:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(137, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Khoa:";
            // 
            // FrmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(541, 322);
            this.Controls.Add(this.xtraScrollableControlDangNhap);
            this.Name = "FrmDangNhap";
            this.Text = "FrmDangNhap";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmDangNhap_Load);
            this.xtraScrollableControlDangNhap.ResumeLayout(false);
            this.xtraScrollableControlDangNhap.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControlDangNhap;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.ComboBox cboKhoa;
        private System.Windows.Forms.TextBox txbMatKhau;
        private System.Windows.Forms.TextBox txbTenDangNhap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}