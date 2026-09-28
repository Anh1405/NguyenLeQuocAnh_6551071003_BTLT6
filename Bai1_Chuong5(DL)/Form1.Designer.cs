namespace WindowsFormsApp
{
    partial class FormDangKy
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
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.lblMoTa = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lblSDT = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblMatKhau = new System.Windows.Forms.Label();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.lblXacNhanMK = new System.Windows.Forms.Label();
            this.txtXacNhanMK = new System.Windows.Forms.TextBox();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.Location = new System.Drawing.Point(30, 20);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(217, 32);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "Đăng ký tài khoản mới";
            // 
            // lblMoTa
            // 
            this.lblMoTa.AutoSize = true;
            this.lblMoTa.ForeColor = System.Drawing.Color.Gray;
            this.lblMoTa.Location = new System.Drawing.Point(32, 55);
            this.lblMoTa.Name = "lblMoTa";
            this.lblMoTa.Size = new System.Drawing.Size(188, 17);
            this.lblMoTa.TabIndex = 1;
            this.lblMoTa.Text = "Vui lòng nhập đầy đủ thông tin";
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(32, 90);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(53, 17);
            this.lblHoTen.TabIndex = 2;
            this.lblHoTen.Text = "Họ tên";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(35, 110);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(260, 22);
            this.txtHoTen.TabIndex = 3;
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Location = new System.Drawing.Point(32, 145);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(91, 17);
            this.lblSDT.TabIndex = 4;
            this.lblSDT.Text = "Số điện thoại";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(35, 165);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(260, 22);
            this.txtSDT.TabIndex = 5;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(32, 200);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(42, 17);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(35, 220);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(260, 22);
            this.txtEmail.TabIndex = 7;
            // 
            // lblMatKhau
            // 
            this.lblMatKhau.AutoSize = true;
            this.lblMatKhau.Location = new System.Drawing.Point(32, 255);
            this.lblMatKhau.Name = "lblMatKhau";
            this.lblMatKhau.Size = new System.Drawing.Size(66, 17);
            this.lblMatKhau.TabIndex = 8;
            this.lblMatKhau.Text = "Mật khẩu";
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(35, 275);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.Size = new System.Drawing.Size(260, 22);
            this.txtMatKhau.TabIndex = 9;
            // 
            // lblXacNhanMK
            // 
            this.lblXacNhanMK.AutoSize = true;
            this.lblXacNhanMK.Location = new System.Drawing.Point(32, 310);
            this.lblXacNhanMK.Name = "lblXacNhanMK";
            this.lblXacNhanMK.Size = new System.Drawing.Size(130, 17);
            this.lblXacNhanMK.TabIndex = 10;
            this.lblXacNhanMK.Text = "Xác nhận mật khẩu";
            // 
            // txtXacNhanMK
            // 
            this.txtXacNhanMK.Location = new System.Drawing.Point(35, 330);
            this.txtXacNhanMK.Name = "txtXacNhanMK";
            this.txtXacNhanMK.PasswordChar = '*';
            this.txtXacNhanMK.Size = new System.Drawing.Size(260, 22);
            this.txtXacNhanMK.TabIndex = 11;
            // 
            // btnDangKy
            // 
            this.btnDangKy.Location = new System.Drawing.Point(35, 375);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(120, 32);
            this.btnDangKy.TabIndex = 12;
            this.btnDangKy.Text = "Đăng Ký";
            this.btnDangKy.UseVisualStyleBackColor = true;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(175, 375);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(120, 32);
            this.btnHuy.TabIndex = 13;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormDangKy
            // 
            this.ClientSize = new System.Drawing.Size(340, 435);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnDangKy);
            this.Controls.Add(this.txtXacNhanMK);
            this.Controls.Add(this.lblXacNhanMK);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.lblMatKhau);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.lblSDT);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.lblMoTa);
            this.Controls.Add(this.lblTieuDe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormDangKy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng ký tài khoản";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblMoTa;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblMatKhau;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Label lblXacNhanMK;
        private System.Windows.Forms.TextBox txtXacNhanMK;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}