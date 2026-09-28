namespace BanVeXemPhim
{
    partial class FormBanVe
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTenKhach = new System.Windows.Forms.Label();
            this.txtTenKhach = new System.Windows.Forms.TextBox();
            this.lblPhim = new System.Windows.Forms.Label();
            this.cboPhim = new System.Windows.Forms.ComboBox();
            this.lblSuatChieu = new System.Windows.Forms.Label();
            this.cboSuatChieu = new System.Windows.Forms.ComboBox();
            this.lblGhe = new System.Windows.Forms.Label();
            this.txtGheDaChon = new System.Windows.Forms.TextBox();
            this.btnChonGhe = new System.Windows.Forms.Button();
            this.btnDatVe = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // lblTenKhach
            this.lblTenKhach.AutoSize = true;
            this.lblTenKhach.Location = new System.Drawing.Point(20, 20);
            this.lblTenKhach.Text = "Tên khách:";
            // txtTenKhach
            this.txtTenKhach.Location = new System.Drawing.Point(20, 42);
            this.txtTenKhach.Name = "txtTenKhach";
            this.txtTenKhach.Size = new System.Drawing.Size(430, 23);
            this.txtTenKhach.TabIndex = 0;
            // lblPhim
            this.lblPhim.AutoSize = true;
            this.lblPhim.Location = new System.Drawing.Point(20, 80);
            this.lblPhim.Text = "Phim:";
            // cboPhim
            this.cboPhim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPhim.Location = new System.Drawing.Point(20, 102);
            this.cboPhim.Name = "cboPhim";
            this.cboPhim.Size = new System.Drawing.Size(430, 23);
            this.cboPhim.TabIndex = 1;
            // lblSuatChieu
            this.lblSuatChieu.AutoSize = true;
            this.lblSuatChieu.Location = new System.Drawing.Point(20, 140);
            this.lblSuatChieu.Text = "Suất chiếu:";
            // cboSuatChieu
            this.cboSuatChieu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSuatChieu.Location = new System.Drawing.Point(20, 162);
            this.cboSuatChieu.Name = "cboSuatChieu";
            this.cboSuatChieu.Size = new System.Drawing.Size(430, 23);
            this.cboSuatChieu.TabIndex = 2;
            // lblGhe
            this.lblGhe.AutoSize = true;
            this.lblGhe.Location = new System.Drawing.Point(20, 200);
            this.lblGhe.Text = "Ghế đã chọn:";
            // txtGheDaChon
            this.txtGheDaChon.Location = new System.Drawing.Point(20, 222);
            this.txtGheDaChon.Name = "txtGheDaChon";
            this.txtGheDaChon.ReadOnly = true;
            this.txtGheDaChon.Size = new System.Drawing.Size(430, 23);
            this.txtGheDaChon.TabStop = false;
            // btnChonGhe
            this.btnChonGhe.Location = new System.Drawing.Point(40, 280);
            this.btnChonGhe.Name = "btnChonGhe";
            this.btnChonGhe.Size = new System.Drawing.Size(120, 32);
            this.btnChonGhe.TabIndex = 3;
            this.btnChonGhe.Text = "Chọn ghế";
            this.btnChonGhe.UseVisualStyleBackColor = true;
            this.btnChonGhe.Click += new System.EventHandler(this.btnChonGhe_Click);
            // btnDatVe
            this.btnDatVe.Location = new System.Drawing.Point(180, 280);
            this.btnDatVe.Name = "btnDatVe";
            this.btnDatVe.Size = new System.Drawing.Size(120, 32);
            this.btnDatVe.TabIndex = 4;
            this.btnDatVe.Text = "Đặt vé";
            this.btnDatVe.UseVisualStyleBackColor = true;
            this.btnDatVe.Click += new System.EventHandler(this.btnDatVe_Click);
            // btnHuy
            this.btnHuy.Location = new System.Drawing.Point(320, 280);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(120, 32);
            this.btnHuy.TabIndex = 5;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // FormBanVe
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 340);
            this.Controls.Add(this.lblTenKhach);
            this.Controls.Add(this.txtTenKhach);
            this.Controls.Add(this.lblPhim);
            this.Controls.Add(this.cboPhim);
            this.Controls.Add(this.lblSuatChieu);
            this.Controls.Add(this.cboSuatChieu);
            this.Controls.Add(this.lblGhe);
            this.Controls.Add(this.txtGheDaChon);
            this.Controls.Add(this.btnChonGhe);
            this.Controls.Add(this.btnDatVe);
            this.Controls.Add(this.btnHuy);
            this.Name = "FormBanVe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bán vé xem phim";
            this.Load += new System.EventHandler(this.FormBanVe_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblTenKhach;
        private System.Windows.Forms.TextBox txtTenKhach;
        private System.Windows.Forms.Label lblPhim;
        private System.Windows.Forms.ComboBox cboPhim;
        private System.Windows.Forms.Label lblSuatChieu;
        private System.Windows.Forms.ComboBox cboSuatChieu;
        private System.Windows.Forms.Label lblGhe;
        private System.Windows.Forms.TextBox txtGheDaChon;
        private System.Windows.Forms.Button btnChonGhe;
        private System.Windows.Forms.Button btnDatVe;
        private System.Windows.Forms.Button btnHuy;
    }
}
