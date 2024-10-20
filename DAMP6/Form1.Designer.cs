namespace DAMP6
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgv_sinhvien = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txt_ten = new TextBox();
            txt_email = new TextBox();
            txt_diachi = new TextBox();
            txt_sdt = new TextBox();
            cb_ph = new ComboBox();
            btn_them = new Button();
            btn_xoa = new Button();
            btn_sua = new Button();
            txt_id = new TextBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_sinhvien).BeginInit();
            SuspendLayout();
            // 
            // dgv_sinhvien
            // 
            dgv_sinhvien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_sinhvien.Location = new Point(2, 235);
            dgv_sinhvien.Name = "dgv_sinhvien";
            dgv_sinhvien.Size = new Size(786, 203);
            dgv_sinhvien.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 191);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 1;
            label1.Text = "Phụ Huynh";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 53);
            label2.Name = "label2";
            label2.Size = new Size(25, 15);
            label2.TabIndex = 2;
            label2.Text = "Tên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 157);
            label3.Name = "label3";
            label3.Size = new Size(27, 15);
            label3.TabIndex = 3;
            label3.Text = "SĐT";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 122);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 4;
            label4.Text = "Địa Chỉ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 86);
            label5.Name = "label5";
            label5.RightToLeft = RightToLeft.No;
            label5.Size = new Size(36, 15);
            label5.TabIndex = 5;
            label5.Text = "Email";
            // 
            // txt_ten
            // 
            txt_ten.Location = new Point(91, 50);
            txt_ten.Name = "txt_ten";
            txt_ten.Size = new Size(256, 23);
            txt_ten.TabIndex = 6;
            // 
            // txt_email
            // 
            txt_email.Location = new Point(91, 78);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(256, 23);
            txt_email.TabIndex = 7;
            // 
            // txt_diachi
            // 
            txt_diachi.Location = new Point(91, 114);
            txt_diachi.Name = "txt_diachi";
            txt_diachi.Size = new Size(256, 23);
            txt_diachi.TabIndex = 8;
            // 
            // txt_sdt
            // 
            txt_sdt.Location = new Point(91, 149);
            txt_sdt.Name = "txt_sdt";
            txt_sdt.Size = new Size(256, 23);
            txt_sdt.TabIndex = 9;
            // 
            // cb_ph
            // 
            cb_ph.FormattingEnabled = true;
            cb_ph.Location = new Point(93, 190);
            cb_ph.Name = "cb_ph";
            cb_ph.Size = new Size(254, 23);
            cb_ph.TabIndex = 10;
            // 
            // btn_them
            // 
            btn_them.Location = new Point(516, 30);
            btn_them.Name = "btn_them";
            btn_them.Size = new Size(177, 36);
            btn_them.TabIndex = 11;
            btn_them.Text = "Thêm";
            btn_them.UseVisualStyleBackColor = true;
            btn_them.Click += btn_them_Click;
            // 
            // btn_xoa
            // 
            btn_xoa.Location = new Point(516, 129);
            btn_xoa.Name = "btn_xoa";
            btn_xoa.Size = new Size(177, 36);
            btn_xoa.TabIndex = 12;
            btn_xoa.Text = "Xóa";
            btn_xoa.UseVisualStyleBackColor = true;
            btn_xoa.Click += btn_xoa_Click;
            // 
            // btn_sua
            // 
            btn_sua.Location = new Point(516, 81);
            btn_sua.Name = "btn_sua";
            btn_sua.Size = new Size(177, 36);
            btn_sua.TabIndex = 13;
            btn_sua.Text = "Sửa";
            btn_sua.UseVisualStyleBackColor = true;
            btn_sua.Click += btn_sua_Click;
            // 
            // txt_id
            // 
            txt_id.Location = new Point(91, 21);
            txt_id.Name = "txt_id";
            txt_id.Size = new Size(256, 23);
            txt_id.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(29, 29);
            label6.Name = "label6";
            label6.Size = new Size(18, 15);
            label6.TabIndex = 15;
            label6.Text = "ID";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(txt_id);
            Controls.Add(btn_sua);
            Controls.Add(btn_xoa);
            Controls.Add(btn_them);
            Controls.Add(cb_ph);
            Controls.Add(txt_sdt);
            Controls.Add(txt_diachi);
            Controls.Add(txt_email);
            Controls.Add(txt_ten);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgv_sinhvien);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgv_sinhvien).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_sinhvien;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txt_ten;
        private TextBox txt_email;
        private TextBox txt_diachi;
        private TextBox txt_sdt;
        private ComboBox cb_ph;
        private Button btn_them;
        private Button btn_xoa;
        private Button btn_sua;
        private TextBox txt_id;
        private Label label6;
    }
}
