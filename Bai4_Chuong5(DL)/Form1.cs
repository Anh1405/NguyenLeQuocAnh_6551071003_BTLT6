using System;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class FormDanhBa : Form
    {
        private int indexDangSua = -1;

        public FormDanhBa()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTen.Text) || string.IsNullOrWhiteSpace(txtSDT.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Tên và Số điện thoại!", "Cảnh báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string itemText = $"{txtTen.Text} - {txtSDT.Text}";

            if (indexDangSua == -1)
            {
                lstLienHe.Items.Add(itemText);
                MessageBox.Show("Thêm thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                lstLienHe.Items[indexDangSua] = itemText;
                indexDangSua = -1;
                btnThem.Text = "Thêm";
                MessageBox.Show("Cập nhật thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            txtTen.Clear();
            txtSDT.Clear();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (lstLienHe.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn một liên hệ để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            indexDangSua = lstLienHe.SelectedIndex;
            string selectedStr = lstLienHe.SelectedItem.ToString();
            string[] parts = selectedStr.Split(new[] { " - " }, StringSplitOptions.None);

            if (parts.Length == 2)
            {
                txtTen.Text = parts[0];
                txtSDT.Text = parts[1];
                btnThem.Text = "Lưu cập nhật";
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lstLienHe.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn một liên hệ để xóa", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedStr = lstLienHe.SelectedItem.ToString();
            string ten = selectedStr.Split(new[] { " - " }, StringSplitOptions.None)[0];

            DialogResult dr = MessageBox.Show($"Bạn có chắc muốn xóa liên hệ {ten}?\nThao tác này không thể hoàn tác!",
                                              "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                lstLienHe.Items.RemoveAt(lstLienHe.SelectedIndex);
                MessageBox.Show("Đã xóa liên hệ thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormDanhBa_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtTen.Text) || !string.IsNullOrWhiteSpace(txtSDT.Text))
            {
                DialogResult dr = MessageBox.Show("Bạn có dữ liệu chưa được lưu. Bạn muốn thoát không?",
                                                  "Cảnh báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                if (dr == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
                else if (dr == DialogResult.No)
                {
                    txtTen.Clear();
                    txtSDT.Clear();
                }
            }
        }
    }
}