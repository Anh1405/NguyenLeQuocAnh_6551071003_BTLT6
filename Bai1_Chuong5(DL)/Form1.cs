using System;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class FormDangKy : Form
    {
        public FormDangKy()
        {
            InitializeComponent();
        }

        private bool KiemTraHopLe()
        {
            bool hopLe = true;

            // 1. Kiểm tra Họ tên
            if (string.IsNullOrWhiteSpace(txtHoTen.Text) || txtHoTen.Text.Trim().Length < 3)
            {
                errorProvider1.SetError(txtHoTen, "Họ tên không được để trống và phải tối thiểu 3 ký tự!");
                hopLe = false;
            }
            else
            {
                errorProvider1.SetError(txtHoTen, "");
            }

            // 2. Kiểm tra Số điện thoại
            if (txtSDT.Text.Length != 10 || !txtSDT.Text.StartsWith("0") || !long.TryParse(txtSDT.Text, out _))
            {
                errorProvider1.SetError(txtSDT, "Số điện thoại phải đúng 10 chữ số và bắt đầu bằng số 0!");
                hopLe = false;
            }
            else
            {
                errorProvider1.SetError(txtSDT, "");
            }

            // 3. Kiểm tra Email
            int atIndex = txtEmail.Text.IndexOf('@');
            int dotIndex = txtEmail.Text.LastIndexOf('.');
            if (atIndex <= 0 || dotIndex <= atIndex + 1 || dotIndex >= txtEmail.Text.Length - 1)
            {
                errorProvider1.SetError(txtEmail, "Email không đúng định dạng (phải chứa '@' và dấu '.' phía sau '@')!");
                hopLe = false;
            }
            else
            {
                errorProvider1.SetError(txtEmail, "");
            }

            // 4. Kiểm tra Mật khẩu
            if (txtMatKhau.Text.Length < 6)
            {
                errorProvider1.SetError(txtMatKhau, "Mật khẩu phải tối thiểu 6 ký tự!");
                hopLe = false;
            }
            else
            {
                errorProvider1.SetError(txtMatKhau, "");
            }

            // 5. Kiểm tra Xác nhận mật khẩu
            if (txtXacNhanMK.Text != txtMatKhau.Text)
            {
                errorProvider1.SetError(txtXacNhanMK, "Mật khẩu xác nhận không khớp!");
                hopLe = false;
            }
            else
            {
                errorProvider1.SetError(txtXacNhanMK, "");
            }

            return hopLe;
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (!KiemTraHopLe()) return;

            MessageBox.Show("Đăng ký thành công! Chào mừng " + txtHoTen.Text, "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            btnHuy.CausesValidation = false;
            errorProvider1.Clear();
            this.Close();
        }
    }
}