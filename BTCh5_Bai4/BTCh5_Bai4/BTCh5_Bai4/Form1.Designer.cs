namespace BTCh5_Bai4
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            lstLienHe = new ListBox();
            lblTen = new Label();
            txtTen = new TextBox();
            txtSDT = new TextBox();
            lblSDT = new Label();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnThoat = new Button();
            lblTieuDe = new Label();
            SuspendLayout();
            // 
            // lstLienHe
            // 
            lstLienHe.FormattingEnabled = true;
            lstLienHe.Location = new Point(558, 52);
            lstLienHe.Name = "lstLienHe";
            lstLienHe.Size = new Size(622, 479);
            lstLienHe.TabIndex = 0;
            lstLienHe.SelectedIndexChanged += lstLienHe_SelectedIndexChanged;
            // 
            // lblTen
            // 
            lblTen.AutoSize = true;
            lblTen.Location = new Point(12, 72);
            lblTen.Name = "lblTen";
            lblTen.Size = new Size(102, 25);
            lblTen.TabIndex = 1;
            lblTen.Text = "HỌ VÀ TÊN";
            // 
            // txtTen
            // 
            txtTen.Location = new Point(191, 72);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(243, 31);
            txtTen.TabIndex = 2;
            txtTen.TextChanged += txtTen_TextChanged_1;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(191, 140);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(243, 31);
            txtSDT.TabIndex = 3;
            // 
            // lblSDT
            // 
            lblSDT.AutoSize = true;
            lblSDT.Location = new Point(12, 140);
            lblSDT.Name = "lblSDT";
            lblSDT.Size = new Size(139, 25);
            lblSDT.TabIndex = 4;
            lblSDT.Text = "SỐ ĐIỆN THOẠI";
            // 
            // btnThem
            // 
            btnThem.Location = new Point(285, 224);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(146, 34);
            btnThem.TabIndex = 5;
            btnThem.Text = "THÊM";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(285, 293);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(146, 34);
            btnSua.TabIndex = 6;
            btnSua.Text = "SỬA";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(285, 365);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(146, 34);
            btnXoa.TabIndex = 7;
            btnXoa.Text = "XÓA";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(285, 428);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(146, 34);
            btnThoat.TabIndex = 8;
            btnThoat.Text = "THOÁT";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // lblTieuDe
            // 
            lblTieuDe.AutoSize = true;
            lblTieuDe.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTieuDe.Location = new Point(191, 15);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(236, 32);
            lblTieuDe.TabIndex = 9;
            lblTieuDe.Text = "QUẢN LÝ DANH BẠ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1183, 554);
            Controls.Add(lblTieuDe);
            Controls.Add(btnThoat);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(lblSDT);
            Controls.Add(txtSDT);
            Controls.Add(txtTen);
            Controls.Add(lblTen);
            Controls.Add(lstLienHe);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý danh bạ";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstLienHe;

        private Label lblTen;
        private TextBox txtTen;

        private Label lblSDT;
        private TextBox txtSDT;

        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThoat;

        private Label lblTieuDe;
    }
}