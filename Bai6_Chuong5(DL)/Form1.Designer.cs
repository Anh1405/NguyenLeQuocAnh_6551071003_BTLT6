namespace WindowsFormsApp
{
    partial class FormChinh
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuTep = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMoGhiChuMoi = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCuaSo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuXepTang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuXepNgang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuXepDoc = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTep,
            this.mnuCuaSo});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuTep
            // 
            this.mnuTep.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMoGhiChuMoi,
            this.mnuThoat});
            this.mnuTep.Name = "mnuTep";
            this.mnuTep.Size = new System.Drawing.Size(46, 24);
            this.mnuTep.Text = "Tệp";
            // 
            // mnuMoGhiChuMoi
            // 
            this.mnuMoGhiChuMoi.Name = "mnuMoGhiChuMoi";
            this.mnuMoGhiChuMoi.Size = new System.Drawing.Size(201, 26);
            this.mnuMoGhiChuMoi.Text = "Mở ghi chú mới";
            this.mnuMoGhiChuMoi.Click += new System.EventHandler(this.mnuMoGhiChuMoi_Click);
            // 
            // mnuThoat
            // 
            this.mnuThoat.Name = "mnuThoat";
            this.mnuThoat.Size = new System.Drawing.Size(201, 26);
            this.mnuThoat.Text = "Thoát";
            this.mnuThoat.Click += new System.EventHandler(this.mnuThoat_Click);
            // 
            // mnuCuaSo
            // 
            this.mnuCuaSo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuXepTang,
            this.mnuXepNgang,
            this.mnuXepDoc});
            this.mnuCuaSo.Name = "mnuCuaSo";
            this.mnuCuaSo.Size = new System.Drawing.Size(69, 24);
            this.mnuCuaSo.Text = "Cửa sổ";
            // 
            // mnuXepTang
            // 
            this.mnuXepTang.Name = "mnuXepTang";
            this.mnuXepTang.Size = new System.Drawing.Size(163, 26);
            this.mnuXepTang.Text = "Xếp tầng";
            this.mnuXepTang.Click += new System.EventHandler(this.mnuXepTang_Click);
            // 
            // mnuXepNgang
            // 
            this.mnuXepNgang.Name = "mnuXepNgang";
            this.mnuXepNgang.Size = new System.Drawing.Size(163, 26);
            this.mnuXepNgang.Text = "Xếp ngang";
            this.mnuXepNgang.Click += new System.EventHandler(this.mnuXepNgang_Click);
            // 
            // mnuXepDoc
            // 
            this.mnuXepDoc.Name = "mnuXepDoc";
            this.mnuXepDoc.Size = new System.Drawing.Size(163, 26);
            this.mnuXepDoc.Text = "Xếp dọc";
            this.mnuXepDoc.Click += new System.EventHandler(this.mnuXepDoc_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 424);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 26);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(155, 20);
            this.lblStatus.Text = "Số ghi chú đang mở: 0";
            // 
            // FormChinh
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormChinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý Ghi chú (MDI)";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuTep;
        private System.Windows.Forms.ToolStripMenuItem mnuMoGhiChuMoi;
        private System.Windows.Forms.ToolStripMenuItem mnuThoat;
        private System.Windows.Forms.ToolStripMenuItem mnuCuaSo;
        private System.Windows.Forms.ToolStripMenuItem mnuXepTang;
        private System.Windows.Forms.ToolStripMenuItem mnuXepNgang;
        private System.Windows.Forms.ToolStripMenuItem mnuXepDoc;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
    }
}