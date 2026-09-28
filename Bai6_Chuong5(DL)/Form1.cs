using System;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class FormChinh : Form
    {
        public FormChinh()
        {
            InitializeComponent();
            CapNhatStatus();
        }

        public void CapNhatStatus()
        {
            lblStatus.Text = $"Số ghi chú đang mở: {this.MdiChildren.Length}";
        }

        private void mnuMoGhiChuMoi_Click(object sender, EventArgs e)
        {
            FormGhiChu frmChild = new FormGhiChu();
            frmChild.MdiParent = this;
            frmChild.FormClosed += (s, ev) => CapNhatStatus();
            frmChild.Show();
            CapNhatStatus();
        }

        private void mnuXepTang_Click(object sender, EventArgs e) => LayoutMdi(MdiLayout.Cascade);
        private void mnuXepNgang_Click(object sender, EventArgs e) => LayoutMdi(MdiLayout.TileHorizontal);
        private void mnuXepDoc_Click(object sender, EventArgs e) => LayoutMdi(MdiLayout.TileVertical);

        private void mnuThoat_Click(object sender, EventArgs e) => Application.Exit();
    }
}