using System;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class FormNhapDiem : Form
    {
        public FormNhapDiem()
        {
            InitializeComponent();
            lblMaHS.TabStop = false;
            lblHoTen.TabStop = false;
            lblToan.TabStop = false;
            lblVan.TabStop = false;
            lblAnh.TabStop = false;
            DangKyEnterChuyenField();
        }

        private void DangKyEnterChuyenField()
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox txt)
                {
                    txt.KeyPress += Txt_KeyPress;
                    if (txt == txtToan || txt == txtVan || txt == txtAnh)
                    {
                        txt.Enter += ScoreTxt_Enter;
                    }
                }
            }
        }

        private void Txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                if (sender == txtAnh)
                {
                    btnLuu.PerformClick();
                }
                else
                {
                    this.SelectNextControl((Control)sender, true, true, true, true);
                }
            }
        }

        private void ScoreTxt_Enter(object sender, EventArgs e)
        {
            if (sender is TextBox txt)
            {
                txt.SelectAll();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            bool hopLe = true;

            if (string.IsNullOrWhiteSpace(txtMaHS.Text))
            {
                errorProvider1.SetError(txtMaHS, "Mã HS không được rỗng!");
                hopLe = false;
            }

            if (!decimal.TryParse(txtToan.Text, out decimal toan) || toan < 0 || toan > 10)
            {
                errorProvider1.SetError(txtToan, "Điểm Toán phải từ 0.0 đến 10.0!");
                hopLe = false;
            }

            if (!decimal.TryParse(txtVan.Text, out decimal van) || van < 0 || van > 10)
            {
                errorProvider1.SetError(txtVan, "Điểm Văn phải từ 0.0 đến 10.0!");
                hopLe = false;
            }

            if (!decimal.TryParse(txtAnh.Text, out decimal anh) || anh < 0 || anh > 10)
            {
                errorProvider1.SetError(txtAnh, "Điểm Anh phải từ 0.0 đến 10.0!");
                hopLe = false;
            }

            if (!hopLe) return;

            string line = $"{txtMaHS.Text} | {txtHoTen.Text} | T:{toan:F1} V:{van:F1} A:{anh:F1}";
            lstDanhSach.Items.Add(line);

            btnXoaTrang_Click(null, null);
        }

        private void btnXoaTrang_Click(object sender, EventArgs e)
        {
            txtMaHS.Clear();
            txtHoTen.Clear();
            txtToan.Clear();
            txtVan.Clear();
            txtAnh.Clear();
            errorProvider1.Clear();
            txtMaHS.Focus();
        }
    }
}