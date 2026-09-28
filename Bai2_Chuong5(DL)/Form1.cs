using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class FormDatPhong : Form
    {
        private DateTime ngayNhanParsed;
        private DateTime ngayTraParsed;

        public FormDatPhong()
        {
            InitializeComponent();
        }

        private void MarkError(Control ctrl, CancelEventArgs e, string msg)
        {
            e.Cancel = true;
            errorProvider1.SetError(ctrl, msg);
            ctrl.BackColor = Color.MistyRose;
        }

        private void MarkValid(Control ctrl)
        {
            errorProvider1.SetError(ctrl, "");
            ctrl.BackColor = Color.Honeydew;
        }

        private void txtHoTen_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
                MarkError(txtHoTen, e, "Họ tên không được để trống!");
            else
                MarkValid(txtHoTen);
        }

        private void txtCCCD_Validating(object sender, CancelEventArgs e)
        {
            if (txtCCCD.Text.Length != 12 || !long.TryParse(txtCCCD.Text, out _))
                MarkError(txtCCCD, e, "Số CCCD phải gồm đúng 12 chữ số!");
            else
                MarkValid(txtCCCD);
        }

        private void txtNgayNhan_Validating(object sender, CancelEventArgs e)
        {
            if (!DateTime.TryParseExact(txtNgayNhan.Text.Trim(), "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out ngayNhanParsed)
                || ngayNhanParsed.Date < DateTime.Today)
            {
                MarkError(txtNgayNhan, e, "Ngày nhận phòng phải đúng định dạng dd/MM/yyyy và từ hôm nay trở đi!");
            }
            else
            {
                MarkValid(txtNgayNhan);
            }
        }

        private void txtNgayTra_Validating(object sender, CancelEventArgs e)
        {
            if (!DateTime.TryParseExact(txtNgayTra.Text.Trim(), "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out ngayTraParsed)
                || ngayTraParsed.Date <= ngayNhanParsed.Date)
            {
                MarkError(txtNgayTra, e, "Ngày trả phòng phải sau ngày nhận phòng!");
            }
            else
            {
                MarkValid(txtNgayTra);
            }
        }

        private void txtSoNguoiLon_Validating(object sender, CancelEventArgs e)
        {
            if (!int.TryParse(txtSoNguoiLon.Text, out int n) || n < 1 || n > 4)
                MarkError(txtSoNguoiLon, e, "Số người lớn phải là số nguyên từ 1 đến 4!");
            else
                MarkValid(txtSoNguoiLon);
        }

        private void txtSoTreEm_Validating(object sender, CancelEventArgs e)
        {
            if (!int.TryParse(txtSoTreEm.Text, out int n) || n < 0 || n > 3)
                MarkError(txtSoTreEm, e, "Số trẻ em phải là số nguyên từ 0 đến 3!");
            else
                MarkValid(txtSoTreEm);
        }

        private void Control_Validated(object sender, EventArgs e)
        {
            if (sender is Control ctrl)
            {
                ctrl.BackColor = Color.Honeydew;
            }
        }

        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren()) return;

            int soDem = (ngayTraParsed - ngayNhanParsed).Days;
            string thongTin = $"Đặt phòng thành công!\n" +
                              $"Khách hàng: {txtHoTen.Text}\n" +
                              $"Số đêm lưu trú: {soDem} đêm\n" +
                              $"Số lượng: {txtSoNguoiLon.Text} người lớn, {txtSoTreEm.Text} trẻ em.";

            MessageBox.Show(thongTin, "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}