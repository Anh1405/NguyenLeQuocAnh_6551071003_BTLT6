using System;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class FormBanVe : Form
    {
        public FormBanVe()
        {
            InitializeComponent();
        }

        private void btnChonGhe_Click(object sender, EventArgs e)
        {
            using (FormChonGhe dlg = new FormChonGhe(txtGheDaChon.Text))
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    txtGheDaChon.Text = dlg.GheChon;
                }
            }
        }

        private void btnDatVe_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenKhach.Text) || cboPhim.SelectedItem == null ||
                cboSuatChieu.SelectedItem == null || string.IsNullOrWhiteSpace(txtGheDaChon.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin đặt vé!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string thongTin = $"XÁC NHẬN ĐẶT VÉ\n" +
                              $"Khách hàng: {txtTenKhach.Text}\n" +
                              $"Phim: {cboPhim.SelectedItem}\n" +
                              $"Suất chiếu: {cboSuatChieu.SelectedItem}\n" +
                              $"Ghế: {txtGheDaChon.Text}\n" +
                              $"Giá vé: 75.000 VNĐ";

            MessageBox.Show(thongTin, "Đặt vé thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}