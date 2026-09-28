using System;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class FormChonGhe : Form
    {
        public string GheChon { get; private set; }

        public FormChonGhe(string gheHienTai)
        {
            InitializeComponent();

            lstGhe.Items.Clear();
            string[] hang = { "A", "B", "C" };
            for (int i = 0; i < hang.Length; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    lstGhe.Items.Add($"{hang[i]}{j}");
                }
            }

            if (!string.IsNullOrEmpty(gheHienTai) && lstGhe.Items.Contains(gheHienTai))
            {
                lstGhe.SelectedItem = gheHienTai;
            }
        }

        private void lstGhe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstGhe.SelectedItem != null)
            {
                lblGheDaChon.Text = "Đang chọn: " + lstGhe.SelectedItem.ToString();
            }
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (lstGhe.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn một ghế trước khi xác nhận!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            GheChon = lstGhe.SelectedItem.ToString();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}