namespace BTCh5_Bai3
{
    partial class Form1
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
            txtMaHS = new TextBox();
            txtHoTen = new TextBox();
            txtToan = new TextBox();
            txtVan = new TextBox();
            txtAnh = new TextBox();
            btnLuu = new Button();
            btnXoaTrang = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            lstDanhSach = new ListBox();
            SuspendLayout();
            // 
            // txtMaHS
            // 
            txtMaHS.Location = new Point(12, 77);
            txtMaHS.Name = "txtMaHS";
            txtMaHS.Size = new Size(127, 31);
            txtMaHS.TabIndex = 0;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(180, 77);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(127, 31);
            txtHoTen.TabIndex = 1;
            // 
            // txtToan
            // 
            txtToan.Location = new Point(348, 77);
            txtToan.Name = "txtToan";
            txtToan.Size = new Size(127, 31);
            txtToan.TabIndex = 2;
            // 
            // txtVan
            // 
            txtVan.Location = new Point(501, 77);
            txtVan.Name = "txtVan";
            txtVan.Size = new Size(127, 31);
            txtVan.TabIndex = 3;
            // 
            // txtAnh
            // 
            txtAnh.Location = new Point(661, 77);
            txtAnh.Name = "txtAnh";
            txtAnh.Size = new Size(127, 31);
            txtAnh.TabIndex = 4;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.OliveDrab;
            btnLuu.FlatStyle = FlatStyle.Flat;
            btnLuu.Location = new Point(12, 114);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(127, 34);
            btnLuu.TabIndex = 5;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnXoaTrang
            // 
            btnXoaTrang.Location = new Point(145, 114);
            btnXoaTrang.Name = "btnXoaTrang";
            btnXoaTrang.Size = new Size(147, 34);
            btnXoaTrang.TabIndex = 6;
            btnXoaTrang.Text = "Xoá Trắng";
            btnXoaTrang.UseVisualStyleBackColor = true;
            btnXoaTrang.Click += btnXoaTrang_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 49);
            label1.Name = "label1";
            label1.Size = new Size(65, 25);
            label1.TabIndex = 7;
            label1.Text = "Mã HS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(180, 49);
            label2.Name = "label2";
            label2.Size = new Size(66, 25);
            label2.TabIndex = 8;
            label2.Text = "Họ tên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(348, 49);
            label3.Name = "label3";
            label3.Size = new Size(96, 25);
            label3.TabIndex = 9;
            label3.Text = "Điểm Toán";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(501, 49);
            label4.Name = "label4";
            label4.Size = new Size(88, 25);
            label4.TabIndex = 10;
            label4.Text = "Điểm Văn";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(661, 49);
            label5.Name = "label5";
            label5.Size = new Size(91, 25);
            label5.TabIndex = 11;
            label5.Text = "Điểm Anh";
            // 
            // lstDanhSach
            // 
            lstDanhSach.FormattingEnabled = true;
            lstDanhSach.Location = new Point(12, 154);
            lstDanhSach.Name = "lstDanhSach";
            lstDanhSach.Size = new Size(776, 279);
            lstDanhSach.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstDanhSach);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnXoaTrang);
            Controls.Add(btnLuu);
            Controls.Add(txtAnh);
            Controls.Add(txtVan);
            Controls.Add(txtToan);
            Controls.Add(txtHoTen);
            Controls.Add(txtMaHS);
            Name = "Form1";
            Text = "Form Nhập Điểm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMaHS;
        private TextBox txtHoTen;
        private TextBox txtToan;
        private TextBox txtVan;
        private TextBox txtAnh;
        private Button btnLuu;
        private Button btnXoaTrang;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ListBox lstDanhSach;
    }
}