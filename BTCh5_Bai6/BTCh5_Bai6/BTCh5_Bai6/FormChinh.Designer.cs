namespace BTCh5_Bai6
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
            this.menuTep = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMoGhiChuMoi = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSapXep = new System.Windows.Forms.ToolStripMenuItem();
            this.menuThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCuaSo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuXepTang = new System.Windows.Forms.ToolStripMenuItem();
            this.menuXepNgang = new System.Windows.Forms.ToolStripMenuItem();
            this.menuXepDoc = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblSoGhiChu = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();

            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuTep,
            this.menuCuaSo});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(900, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";

            this.menuTep.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuMoGhiChuMoi,
            this.menuSapXep,
            this.menuThoat});
            this.menuTep.Name = "menuTep";
            this.menuTep.Size = new System.Drawing.Size(47, 24);
            this.menuTep.Text = "Tệp";

            this.menuMoGhiChuMoi.Name = "menuMoGhiChuMoi";
            this.menuMoGhiChuMoi.Size = new System.Drawing.Size(201, 26);
            this.menuMoGhiChuMoi.Text = "Mở ghi chú mới";
            this.menuMoGhiChuMoi.Click += new System.EventHandler(this.menuMoGhiChuMoi_Click);

            this.menuSapXep.Name = "menuSapXep";
            this.menuSapXep.Size = new System.Drawing.Size(201, 26);
            this.menuSapXep.Text = "Sắp xếp cửa sổ";

            this.menuThoat.Name = "menuThoat";
            this.menuThoat.Size = new System.Drawing.Size(201, 26);
            this.menuThoat.Text = "Thoát";
            this.menuThoat.Click += new System.EventHandler(this.menuThoat_Click);

            this.menuCuaSo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuXepTang,
            this.menuXepNgang,
            this.menuXepDoc});
            this.menuCuaSo.Name = "menuCuaSo";
            this.menuCuaSo.Size = new System.Drawing.Size(69, 24);
            this.menuCuaSo.Text = "Cửa sổ";

            this.menuXepTang.Name = "menuXepTang";
            this.menuXepTang.Size = new System.Drawing.Size(164, 26);
            this.menuXepTang.Text = "Xếp tầng";
            this.menuXepTang.Click += new System.EventHandler(this.menuXepTang_Click);

            this.menuXepNgang.Name = "menuXepNgang";
            this.menuXepNgang.Size = new System.Drawing.Size(164, 26);
            this.menuXepNgang.Text = "Xếp ngang";
            this.menuXepNgang.Click += new System.EventHandler(this.menuXepNgang_Click);

            this.menuXepDoc.Name = "menuXepDoc";
            this.menuXepDoc.Size = new System.Drawing.Size(164, 26);
            this.menuXepDoc.Text = "Xếp dọc";
            this.menuXepDoc.Click += new System.EventHandler(this.menuXepDoc_Click);

            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblSoGhiChu});
            this.statusStrip1.Location = new System.Drawing.Point(0, 526);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(900, 26);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";

            this.lblSoGhiChu.Name = "lblSoGhiChu";
            this.lblSoGhiChu.Size = new System.Drawing.Size(138, 20);
            this.lblSoGhiChu.Text = "Số ghi chú đang mở: 0";

            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 552);
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
        private System.Windows.Forms.ToolStripMenuItem menuTep;
        private System.Windows.Forms.ToolStripMenuItem menuMoGhiChuMoi;
        private System.Windows.Forms.ToolStripMenuItem menuSapXep;
        private System.Windows.Forms.ToolStripMenuItem menuThoat;
        private System.Windows.Forms.ToolStripMenuItem menuCuaSo;
        private System.Windows.Forms.ToolStripMenuItem menuXepTang;
        private System.Windows.Forms.ToolStripMenuItem menuXepNgang;
        private System.Windows.Forms.ToolStripMenuItem menuXepDoc;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblSoGhiChu;
    }
}