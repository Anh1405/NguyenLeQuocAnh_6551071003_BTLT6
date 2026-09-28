namespace WindowsFormsApp
{
    partial class FormBanVe
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
            this.lblTenKhach = new System.Windows.Forms.Label();
            this.txtTenKhach = new System.Windows.Forms.TextBox();
            this.lblPhim = new System.Windows.Forms.Label();
            this.cboPhim = new System.Windows.Forms.ComboBox();
            this.lblSuatChieu = new System.Windows.Forms.Label();
            this.cboSuatChieu = new System.Windows.Forms.ComboBox();
            this.lblGheDaChon = new System.Windows.Forms.Label();
            this.txtGheDaChon = new System.Windows.Forms.TextBox();
            this.btnChonGhe = new System.Windows.Forms.Button();
            this.btnDatVe = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTenKhach
            // 
            this.lblTenKhach.AutoSize = true;
            this.lblTenKhach.Location = new System.Drawing.Point(25, 25);
            this.lblTenKhach.Name = "lblTenKhach";
            this.lblTenKhach.Size = new System.Drawing.Size(80, 17);
            this.lblTenKhach.TabIndex = 0;
            this.lblTenKhach.Text = "Tên khách:";
            // 
            // txtTenKhach
            // 
            this.txtTenKhach.Location = new System.Drawing.Point(120, 22);
            this.txtTenKhach.Name = "txtTenKhach";
            this.txtTenKhach.Size = new System.Drawing.Size(200, 22);
            this.txtTenKhach.TabIndex = 1;
            // 
            // lblPhim
            // 
            this.lblPhim.AutoSize = true;
            this.lblPhim.Location = new System.Drawing.Point(25, 65);
            this.lblPhim.Name = "lblPhim";
            this.lblPhim.Size = new System.Drawing.Size(43, 17);
            this.lblPhim.TabIndex = 2;
            this.lblPhim.Text = "Phim:";
            // 
            // cboPhim
            // 
            this.cboPhim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPhim.FormattingEnabled = true;
            this.cboPhim.Items.AddRange(new object[] {
            "Chiến binh cuối cùng",
            "Lật mặt 7",
            "Doraemon"});
            this.cboPhim.Location = new System.Drawing.Point(120, 62);
            this.cboPhim.Name = "cboPhim";
            this.cboPhim.Size = new System.Drawing.Size(200, 24);
            this.cboPhim.TabIndex = 3;
            // 
            // lblSuatChieu
            // 
            this.lblSuatChieu.AutoSize = true;
            this.lblSuatChieu.Location = new System.Drawing.Point(25, 105);
            this.lblSuatChieu.Name = "lblSuatChieu";
            this.lblSuatChieu.Size = new System.Drawing.Size(79, 17);
            this.lblSuatChieu.TabIndex = 4;
            this.lblSuatChieu.Text = "Suất chiếu:";
            // 
            // cboSuatChieu
            // 
            this.cboSuatChieu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSuatChieu.FormattingEnabled = true;
            this.cboSuatChieu.Items.AddRange(new object[] {
            "17:00",
            "19:00",
            "21:00"});
            this.cboSuatChieu.Location = new System.Drawing.Point(120, 102);
            this.cboSuatChieu.Name = "cboSuatChieu";
            this.cboSuatChieu.Size = new System.Drawing.Size(200, 24);
            this.cboSuatChieu.TabIndex = 5;
            // 
            // lblGheDaChon
            // 
            this.lblGheDaChon.AutoSize = true;
            this.lblGheDaChon.Location = new System.Drawing.Point(25, 145);
            this.lblGheDaChon.Name = "lblGheDaChon";
            this.lblGheDaChon.Size = new System.Drawing.Size(91, 17);
            this.lblGheDaChon.TabIndex = 6;
            this.lblGheDaChon.Text = "Ghế đã chọn:";
            // 
            // txtGheDaChon
            // 
            this.txtGheDaChon.Location = new System.Drawing.Point(120, 142);
            this.txtGheDaChon.Name = "txtGheDaChon";
            this.txtGheDaChon.ReadOnly = true;
            this.txtGheDaChon.Size = new System.Drawing.Size(100, 22);
            this.txtGheDaChon.TabIndex = 7;
            // 
            // btnChonGhe
            // 
            this.btnChonGhe.Location = new System.Drawing.Point(230, 140);
            this.btnChonGhe.Name = "btnChonGhe";
            this.btnChonGhe.Size = new System.Drawing.Size(90, 26);
            this.btnChonGhe.TabIndex = 8;
            this.btnChonGhe.Text = "Chọn ghế";
            this.btnChonGhe.UseVisualStyleBackColor = true;
            this.btnChonGhe.Click += new System.EventHandler(this.btnChonGhe_Click);
            // 
            // btnDatVe
            // 
            this.btnDatVe.Location = new System.Drawing.Point(120, 185);
            this.btnDatVe.Name = "btnDatVe";
            this.btnDatVe.Size = new System.Drawing.Size(90, 32);
            this.btnDatVe.TabIndex = 9;
            this.btnDatVe.Text = "Đặt vé";
            this.btnDatVe.UseVisualStyleBackColor = true;
            this.btnDatVe.Click += new System.EventHandler(this.btnDatVe_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(230, 185);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(90, 32);
            this.btnHuy.TabIndex = 10;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // FormBanVe
            // 
            this.ClientSize = new System.Drawing.Size(350, 240);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnDatVe);
            this.Controls.Add(this.btnChonGhe);
            this.Controls.Add(this.txtGheDaChon);
            this.Controls.Add(this.lblGheDaChon);
            this.Controls.Add(this.cboSuatChieu);
            this.Controls.Add(this.lblSuatChieu);
            this.Controls.Add(this.cboPhim);
            this.Controls.Add(this.lblPhim);
            this.Controls.Add(this.txtTenKhach);
            this.Controls.Add(this.lblTenKhach);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormBanVe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bán vé xem phim";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTenKhach;
        private System.Windows.Forms.TextBox txtTenKhach;
        private System.Windows.Forms.Label lblPhim;
        private System.Windows.Forms.ComboBox cboPhim;
        private System.Windows.Forms.Label lblSuatChieu;
        private System.Windows.Forms.ComboBox cboSuatChieu;
        private System.Windows.Forms.Label lblGheDaChon;
        private System.Windows.Forms.TextBox txtGheDaChon;
        private System.Windows.Forms.Button btnChonGhe;
        private System.Windows.Forms.Button btnDatVe;
        private System.Windows.Forms.Button btnHuy;
    }
}