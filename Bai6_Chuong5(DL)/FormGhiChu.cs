using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class FormGhiChu : Form
    {
        private bool isContentChanged = false;

        public FormGhiChu()
        {
            InitializeComponent();
            this.KeyPreview = true;

            cboMucDoUuTien.Items.Clear();
            cboMucDoUuTien.Items.AddRange(new object[] { "Thấp", "Trung bình", "Cao" });
            cboMucDoUuTien.SelectedIndex = 1;

            txtNoiDung.TextChanged += (s, e) => isContentChanged = true;

            btnLuuGhiChu.MouseEnter += (s, e) => btnLuuGhiChu.BackColor = Color.LightSkyBlue;
            btnLuuGhiChu.MouseLeave += (s, e) => btnLuuGhiChu.BackColor = SystemColors.Control;
        }

        private void FormGhiChu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
            {
                btnLuuGhiChu.PerformClick();
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.Escape)
            {
                if (isContentChanged)
                {
                    DialogResult dr = MessageBox.Show("Nội dung đã thay đổi, bạn có muốn đóng không?", "Xác nhận",
                                                      MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes) this.Close();
                }
                else
                {
                    this.Close();
                }
            }
        }

        private void txtNoiDung_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtNoiDung.Text.Length >= 500 && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void lblTieuDeForm_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
            else
                this.WindowState = FormWindowState.Maximized;
        }

        private void txtTieuDe_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTieuDe.Text) || txtTieuDe.Text.Length > 50)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtTieuDe, "Tiêu đề không được rỗng và tối đa 50 ký tự!");
                txtTieuDe.BackColor = Color.MistyRose;
            }
        }

        private void txtTieuDe_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtTieuDe, "");
            txtTieuDe.BackColor = Color.White;
        }

        private void btnLuuGhiChu_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren()) return;

            this.Text = txtTieuDe.Text;
            isContentChanged = false;
            MessageBox.Show("Đã lưu ghi chú.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}