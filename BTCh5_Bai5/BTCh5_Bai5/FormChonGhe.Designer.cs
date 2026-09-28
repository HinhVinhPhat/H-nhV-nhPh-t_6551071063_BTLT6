namespace BanVeXemPhim
{
    partial class FormChonGhe
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lstGhe = new System.Windows.Forms.ListBox();
            this.lblGheDaChon = new System.Windows.Forms.Label();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.btnBoQua = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // lstGhe
            this.lstGhe.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lstGhe.FormattingEnabled = true;
            this.lstGhe.ItemHeight = 21;
            this.lstGhe.Location = new System.Drawing.Point(15, 15);
            this.lstGhe.MultiColumn = true;
            this.lstGhe.ColumnWidth = 55;
            this.lstGhe.Name = "lstGhe";
            this.lstGhe.Size = new System.Drawing.Size(290, 88);
            this.lstGhe.TabIndex = 0;
            this.lstGhe.SelectedIndexChanged += new System.EventHandler(this.lstGhe_SelectedIndexChanged);
            // lblGheDaChon
            this.lblGheDaChon.AutoSize = true;
            this.lblGheDaChon.Location = new System.Drawing.Point(15, 118);
            this.lblGheDaChon.Name = "lblGheDaChon";
            this.lblGheDaChon.Text = "Đang chọn: (chưa chọn)";
            // btnXacNhan
            this.btnXacNhan.Location = new System.Drawing.Point(120, 150);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(85, 30);
            this.btnXacNhan.TabIndex = 1;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // btnBoQua
            this.btnBoQua.Location = new System.Drawing.Point(215, 150);
            this.btnBoQua.Name = "btnBoQua";
            this.btnBoQua.Size = new System.Drawing.Size(85, 30);
            this.btnBoQua.TabIndex = 2;
            this.btnBoQua.Text = "Bỏ qua";
            this.btnBoQua.UseVisualStyleBackColor = true;
            this.btnBoQua.Click += new System.EventHandler(this.btnBoQua_Click);
            // FormChonGhe
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 200);
            this.Controls.Add(this.lstGhe);
            this.Controls.Add(this.lblGheDaChon);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.btnBoQua);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormChonGhe";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Chọn ghế";
            this.AcceptButton = this.btnXacNhan;
            this.CancelButton = this.btnBoQua;
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ListBox lstGhe;
        private System.Windows.Forms.Label lblGheDaChon;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.Button btnBoQua;
    }
}
