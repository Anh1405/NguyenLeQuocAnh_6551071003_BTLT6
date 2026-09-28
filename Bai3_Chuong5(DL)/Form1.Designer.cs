namespace WindowsFormsApp
{
    partial class FormNhapDiem
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblMaHS = new System.Windows.Forms.Label();
            this.txtMaHS = new System.Windows.Forms.TextBox();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lblToan = new System.Windows.Forms.Label();
            this.txtToan = new System.Windows.Forms.TextBox();
            this.lblVan = new System.Windows.Forms.Label();
            this.txtVan = new System.Windows.Forms.TextBox();
            this.lblAnh = new System.Windows.Forms.Label();
            this.txtAnh = new System.Windows.Forms.TextBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoaTrang = new System.Windows.Forms.Button();
            this.lstDanhSach = new System.Windows.Forms.ListBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMaHS
            // 
            this.lblMaHS.AutoSize = true;
            this.lblMaHS.Location = new System.Drawing.Point(20, 20);
            this.lblMaHS.Name = "lblMaHS";
            this.lblMaHS.Size = new System.Drawing.Size(50, 17);
            this.lblMaHS.TabIndex = 100;
            this.lblMaHS.Text = "Mã HS";
            // 
            // txtMaHS
            // 
            this.txtMaHS.Location = new System.Drawing.Point(23, 40);
            this.txtMaHS.Name = "txtMaHS";
            this.txtMaHS.Size = new System.Drawing.Size(120, 22);
            this.txtMaHS.TabIndex = 0;
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(160, 20);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(53, 17);
            this.lblHoTen.TabIndex = 101;
            this.lblHoTen.Text = "Họ tên";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(163, 40);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(220, 22);
            this.txtHoTen.TabIndex = 1;
            // 
            // lblToan
            // 
            this.lblToan.AutoSize = true;
            this.lblToan.Location = new System.Drawing.Point(20, 80);
            this.lblToan.Name = "lblToan";
            this.lblToan.Size = new System.Drawing.Size(72, 17);
            this.lblToan.TabIndex = 102;
            this.lblToan.Text = "Điểm Toán";
            // 
            // txtToan
            // 
            this.txtToan.Location = new System.Drawing.Point(23, 100);
            this.txtToan.Name = "txtToan";
            this.txtToan.Size = new System.Drawing.Size(100, 22);
            this.txtToan.TabIndex = 2;
            // 
            // lblVan
            // 
            this.lblVan.AutoSize = true;
            this.lblVan.Location = new System.Drawing.Point(140, 80);
            this.lblVan.Name = "lblVan";
            this.lblVan.Size = new System.Drawing.Size(64, 17);
            this.lblVan.TabIndex = 103;
            this.lblVan.Text = "Điểm Văn";
            // 
            // txtVan
            // 
            this.txtVan.Location = new System.Drawing.Point(143, 100);
            this.txtVan.Name = "txtVan";
            this.txtVan.Size = new System.Drawing.Size(100, 22);
            this.txtVan.TabIndex = 3;
            // 
            // lblAnh
            // 
            this.lblAnh.AutoSize = true;
            this.lblAnh.Location = new System.Drawing.Point(260, 80);
            this.lblAnh.Name = "lblAnh";
            this.lblAnh.Size = new System.Drawing.Size(64, 17);
            this.lblAnh.TabIndex = 104;
            this.lblAnh.Text = "Điểm Anh";
            // 
            // txtAnh
            // 
            this.txtAnh.Location = new System.Drawing.Point(263, 100);
            this.txtAnh.Name = "txtAnh";
            this.txtAnh.Size = new System.Drawing.Size(100, 22);
            this.txtAnh.TabIndex = 4;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(23, 140);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(100, 30);
            this.btnLuu.TabIndex = 5;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoaTrang
            // 
            this.btnXoaTrang.Location = new System.Drawing.Point(143, 140);
            this.btnXoaTrang.Name = "btnXoaTrang";
            this.btnXoaTrang.Size = new System.Drawing.Size(100, 30);
            this.btnXoaTrang.TabIndex = 6;
            this.btnXoaTrang.Text = "Xóa Trắng";
            this.btnXoaTrang.UseVisualStyleBackColor = true;
            this.btnXoaTrang.Click += new System.EventHandler(this.btnXoaTrang_Click);
            // 
            // lstDanhSach
            // 
            this.lstDanhSach.FormattingEnabled = true;
            this.lstDanhSach.ItemHeight = 16;
            this.lstDanhSach.Location = new System.Drawing.Point(23, 185);
            this.lstDanhSach.Name = "lstDanhSach";
            this.lstDanhSach.Size = new System.Drawing.Size(360, 148);
            this.lstDanhSach.TabIndex = 7;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormNhapDiem
            // 
            this.ClientSize = new System.Drawing.Size(410, 355);
            this.Controls.Add(this.lstDanhSach);
            this.Controls.Add(this.btnXoaTrang);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.txtAnh);
            this.Controls.Add(this.lblAnh);
            this.Controls.Add(this.txtVan);
            this.Controls.Add(this.lblVan);
            this.Controls.Add(this.txtToan);
            this.Controls.Add(this.lblToan);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.txtMaHS);
            this.Controls.Add(this.lblMaHS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormNhapDiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhập điểm học sinh";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMaHS;
        private System.Windows.Forms.TextBox txtMaHS;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lblToan;
        private System.Windows.Forms.TextBox txtToan;
        private System.Windows.Forms.Label lblVan;
        private System.Windows.Forms.TextBox txtVan;
        private System.Windows.Forms.Label lblAnh;
        private System.Windows.Forms.TextBox txtAnh;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoaTrang;
        private System.Windows.Forms.ListBox lstDanhSach;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}